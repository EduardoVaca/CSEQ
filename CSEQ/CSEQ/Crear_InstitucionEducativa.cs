using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSEQ
{
    public partial class Crear_InstitucionEducativa : Form
    {
        String nombre_selected;
        int rol;

        public Crear_InstitucionEducativa(int rol)
        {
            this.rol = rol;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        private void Crear_InstitucionEducativa_Load(object sender, EventArgs e)
        {
            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado");
            int id_estado = 22;
            ID_estado.SelectedIndex = id_estado - 1;
            Util.llenarComboBox(ID_municipio, "SELECT m.ID_municipio,m.nombre FROM Municipio m,Estado e WHERE m.ID_estado=e.ID_estado AND e.ID_estado=" + id_estado + ";");


            if (ID_municipio.SelectedItem != null)
            {
                int id_municipio = Int32.Parse(ID_municipio.SelectedValue.ToString());
                //MessageBox.Show(ID_municipio.SelectedValue.ToString());
                String inicio = "SELECT distinct  c.ID_colonia, c.nombre FROM Municipio m, Colonia c WHERE m.ID_municipio=c.ID_municipio;";
                Util.llenarComboBox(ID_colonia, inicio);
            }

            if (rol == 1)
            {
                imagen.Visible = false;
                Busqueda_grp.Visible = true;
                modificar_btn.Visible = true;
                eliminar_btn.Visible = true;
            }

        }

        /*--------------------------------------------------------------------------------
         * Metodos los cuales llenan un comboBox basandose en el contenido de otro comboBox
         * Ejemplo: Estado - > Municipios
         */
        private void ID_estado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String valorComboBox = ID_estado.SelectedValue.ToString();
            Util.llenarComboBox(ID_municipio, "SELECT ID_municipio, nombre FROM Municipio WHERE " +
                                                "ID_estado = " + valorComboBox);            
        }

        private void ID_municipio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int ID_municipio_selected = Int32.Parse(ID_municipio.SelectedValue.ToString());
            MessageBox.Show(ID_municipio_selected.ToString());
            Util.llenarComboBox(ID_colonia, "SELECT ID_colonia, nombre FROM Colonia WHERE " +
                                               "ID_municipio = " + ID_municipio_selected);            
        }
        /*---------------------------------------------------------------------*/

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            String iNombre = nombre_txt.Text;
            String iTelefono = telefono_txt.Text;
            String iCorreo = correo_txt.Text;
            String iCalle = calle_txt.Text;
            int iID_colonia = Int32.Parse(ID_colonia.SelectedValue.ToString());
            int iPrivada;
            int iEspecializada;
            if (privada_check.Checked)
                iPrivada = 1;
            else
                iPrivada = 0;
            if (especializada_check.Checked)
                iEspecializada = 1;
            else
                iEspecializada = 0;
            if(iNombre.Length > 0)
                if (Util.executeStoredProcedure("registrarInstitucionEducativa", iNombre, iCalle, iTelefono, iCorreo, iPrivada, iEspecializada, iID_colonia))
                {
                    MessageBox.Show("La Institucion Educativa se registro con exito!");
                }

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnInstitucionEducativa", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            String correo;
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_btn.Enabled = true; //Activacion de botones
                eliminar_btn.Enabled = true;
                nombre_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                correo = busqueda_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                String sqlActiveRow = "SELECT * FROM InstitucionEducativa i, LocalizaInstitucionEducativa l, Colonia c, Municipio m WHERE ";
                sqlActiveRow += (" i.nombre= '" + nombre_selected + "' AND i.correo= '" + correo + "' AND l.ID_institucioneducativa=i.ID_institucioneducativa " +
                                                                                       "AND l.ID_colonia = c.ID_colonia AND c.ID_municipio=m.ID_municipio;");
                Util.showData(this, sqlActiveRow);
                //Se vuelven a llenar los comboBox DEPENDIENTES para que no sean valores nulos
                ID_estado.SelectedValue = Int16.Parse(busqueda_grid.Rows[e.RowIndex].Cells[4].Value.ToString());
                Util.llenarComboBox(ID_municipio, "SELECT ID_municipio, nombre FROM Municipio WHERE ID_estado = " + ID_estado.SelectedValue + ";");
                ID_municipio.SelectedValue = Int16.Parse(busqueda_grid.Rows[e.RowIndex].Cells[3].Value.ToString());
                Util.llenarComboBox(ID_colonia, "SELECT ID_colonia, nombre FROM Colonia WHERE ID_municipio = " + ID_municipio.SelectedValue + ";");
                ID_colonia.SelectedValue = Int16.Parse(busqueda_grid.Rows[e.RowIndex].Cells[2].Value.ToString());
            }



        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar Institucion: '" + nombre_selected + "'?", "Confirmacion de eliminar",
                                        MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarInstitucionEducativa", nombre_selected))
                {
                    MessageBox.Show("La institucion se ha eliminado con exito!");
                }
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            //nombreViejo VARCHAR(90), nombreNuevo VARCHAR(90), calleNuevo VARCHAR(80), telefonoNuevo VARCHAR(20), correoNuevo VARCHAR(80),
            //privadaNuevo BOOLEAN, especializadaNuevo BOOLEAN
            String nombreNuevo = nombre_txt.Text;
            String calleNuevo = calle_txt.Text;
            String telefonoNuevo = telefono_txt.Text;
            String correoNuevo = correo_txt.Text;
            bool privadaNuevo = privada_check.Checked;
            bool especializadaNuevo = especializada_check.Checked;
            int IDcoloniaNuevo = Int32.Parse(ID_colonia.SelectedValue.ToString());

            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Institucion: '" + nombre_selected + "'?", "Confirmacion de eliminar",
                                        MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarInstitucionEducativa", nombre_selected, nombreNuevo,
                                               calleNuevo, telefonoNuevo, correoNuevo, privadaNuevo, especializadaNuevo,
                                               IDcoloniaNuevo))
                {
                    MessageBox.Show("La institucion se ha modificado con exito!");
                }
            }

        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }
        }

        private void nombre_txt_TextChanged(object sender, EventArgs e)
        {
            guardar_btn.Enabled = true;
        }
    }
}
