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

        public Crear_InstitucionEducativa()
        {
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
            ID_estado.SelectedIndex = id_estado-1;
            Util.llenarComboBox(ID_municipio, "SELECT m.ID_municipio,m.nombre FROM Municipio m,Estado e WHERE m.ID_estado=e.ID_estado AND e.ID_estado=" + id_estado + ";");
           
            
            if (ID_municipio.SelectedItem != null)
            {
                int id_municipio = Int32.Parse(ID_municipio.SelectedValue.ToString());
                //MessageBox.Show(ID_municipio.SelectedValue.ToString());
                String inicio = "SELECT distinct d.ID_delegacion,d.nombre FROM Municipio m, Delegacion d, Colonia c WHERE d.ID_municipio=m.ID_municipio AND m.ID_municipio=c.ID_municipio AND d.ID_delegacion = c.ID_Delegacion;";
                Util.llenarComboBox(ID_delegacion, inicio);
                inicio = "SELECT distinct  c.ID_colonia, c.nombre FROM Municipio m, Delegacion d, Colonia c WHERE d.ID_municipio=m.ID_municipio AND m.ID_municipio=c.ID_municipio AND d.ID_delegacion = c.ID_Delegacion;";
                Util.llenarComboBox(ID_colonia, inicio);
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
            String valorComboBox = ID_municipio.SelectedValue.ToString();                                                
            Util.llenarComboBox(ID_delegacion, "SELECT ID_delegacion, nombre FROM Delegacion WHERE " +
                                                "ID_municipio = " + valorComboBox);
            Util.llenarComboBox(ID_colonia, "SELECT ID_colonia, nombre FROM Colonia WHERE " +
                                               "ID_municipio = " + valorComboBox);
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

            if (Util.executeStoredProcedure("registrarInstitucionEducativa", iNombre, iCalle, iTelefono, iCorreo, iPrivada, iEspecializada, iID_colonia))
            {
                MessageBox.Show("La Institucion Educativa se registro con exito!");
            }

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
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
                
                String sqlActiveRow = "SELECT * FROM InstitucionEducativa i, Estado e, Municipio m, Delegacion d, Colonia c , LocalizaInstitucionEducativa l WHERE ";
                sqlActiveRow += (" i.nombre= '" + nombre_selected + "' AND i.correo= '" + correo + "' AND l.ID_institucioneducativa=i.ID_institucioneducativa "+
                                                                                        "AND l.ID_colonia=c.ID_colonia AND c.ID_delegacion=d.ID_delegacion AND c.ID_municipio=m.ID_municipio "+
                                                                                        "AND m.ID_estado=e.ID_estado;");
                /*
                String sqlActiveRow = "SELECT * FROM InstitucionEducativa WHERE ";
                sqlActiveRow += " nombre= '" + nombre + "' AND correo= '" + correo + "';";
                */
                Util.showData(this, sqlActiveRow);
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

        }
    }
}
