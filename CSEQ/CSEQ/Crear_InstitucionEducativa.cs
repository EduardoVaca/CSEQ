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

        /*Metodo que llena los combo boxes de la Forma*/
        private void llenarComboBoxes()
        {
            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado");
            int id_estado = Int32.Parse(ID_estado.SelectedValue.ToString());
            Util.llenarComboBox(ID_municipio, "SELECT m.ID_municipio,m.nombre FROM Municipio m,Estado e WHERE m.ID_estado=e.ID_estado AND e.ID_estado=" + id_estado + ";");


            if (ID_municipio.SelectedItem != null)
            {
                int id_municipio = Int32.Parse(ID_municipio.SelectedValue.ToString());
                String inicio = "SELECT distinct  c.ID_colonia, c.nombre FROM Municipio m, Colonia c WHERE m.ID_municipio=c.ID_municipio;";
                Util.llenarComboBox(ID_colonia, inicio);
            }
        }

        private void Crear_InstitucionEducativa_Load(object sender, EventArgs e)
        {

            llenarComboBoxes();

            if (rol == 1)
            {
                imagen.Visible = false;
                Busqueda_grp.Visible = true;
                modificar_pb.Visible = true;
                eliminar_pb.Visible = true;
            }

        }

        /*--------------------------------------------------------------------------------
         * Metodos los cuales llenan un comboBox basandose en el contenido de otro comboBox
         * Ejemplo: Estado - > Municipios
         *********************************************************************************/
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

        /*Metodo que guarda un nuevo registro en la base*/
        private void guardar_btn_Click(object sender, EventArgs e)
        {
            String iNombre = nombre_txt.Text;
            String iTelefono = telefono_txt.Text;
            String iCorreo = correo_txt.Text;
            String iCalle = calle_txt.Text;
            int iID_colonia = Int32.Parse(ID_colonia.SelectedValue.ToString());
            Boolean iPrivada = privada_check.Checked;
            Boolean iEspecializada = especializada_check.Checked;

            if(iNombre.Length > 0)
                if (Util.executeStoredProcedure("registrarInstitucionEducativa", iNombre, iCalle, iTelefono, iCorreo, iPrivada, iEspecializada, iID_colonia))
                {
                    MessageBox.Show("La Institucion Educativa se registro con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnInstitucionEducativa", "%");
                }

        }


        /*********************************************************
         * Metodo que busca en la Tabla un registro dado por el usuario
         * llenando el grid con la tabla obtenida
         * ******************************************************/
        private void buscar()
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Cursor = Cursors.WaitCursor;
            Util.fillGrid(busqueda_grid, "busquedaEnInstitucionEducativa", busqueda);
            Cursor = Cursors.Default;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            buscar();
        }


        /**********************************************************
         * Metodo que llena todo el form con los datos obtenidos del
         * registro seleccionado en el grid
         * Se activan los botones de Modificar y Eliminar
         * *******************************************************/
        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            String correo;
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_pb.Enabled = true; //Activacion de botones
                eliminar_pb.Enabled = true;
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
                    Util.fillGrid(busqueda_grid, "busquedaEnInstitucionEducativa", "%");
                }
            }
        }
        /*Metodo que modifica un registro en la Base*/
        private void modificar_btn_Click(object sender, EventArgs e)
        {            
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
                    Util.fillGrid(busqueda_grid, "busquedaEnInstitucionEducativa", "%");
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
            guardar_pb.Enabled = true;
        }

        private void back_picture_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(back_picture);
        }

        private void back_picture_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(back_picture);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(pictureBox2, "Salir de la aplicación");
        }

        private void logout_MouseHover(object sender, EventArgs e)
        {
            cerrarSesion_tt.SetToolTip(logout, "Cerrar Sesión");
        }

        /*Metodo que guarda un nuevo registro en la Base*/
        private void guardar_pb_Click(object sender, EventArgs e)
        {
            String iNombre = nombre_txt.Text;
            String iTelefono = telefono_txt.Text;
            String iCorreo = correo_txt.Text;
            String iCalle = calle_txt.Text;
            int iID_colonia = Int32.Parse(ID_colonia.SelectedValue.ToString());
            Boolean iPrivada = privada_check.Checked;
            Boolean iEspecializada = especializada_check.Checked;

            if (iNombre.Length > 0)
                if (Util.executeStoredProcedure("registrarInstitucionEducativa", iNombre, iCalle, iTelefono, iCorreo, iPrivada, iEspecializada, iID_colonia))
                {
                    MessageBox.Show("La Institucion Educativa se registro con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnInstitucionEducativa", "%");
                }
        }

        private void modificar_pb_Click(object sender, EventArgs e)
        {
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
                    Util.fillGrid(busqueda_grid, "busquedaEnInstitucionEducativa", "%");
                }
            }
        }

        /*Metodo que elimina un registro elegido de la base*/
        private void eliminar_pb_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar Institucion: '" + nombre_selected + "'?", "Confirmacion de eliminar",
                                        MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarInstitucionEducativa", nombre_selected))
                {
                    MessageBox.Show("La institucion se ha eliminado con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnInstitucionEducativa", "%");
                }
            }
        }

        private void guardar_pb_MouseHover(object sender, EventArgs e)
        {             
             Util.maximizarCualquierIcono(guardar_pb, new Size(50, 54), 3);
        }

        private void modificar_pb_MouseHover(object sender, EventArgs e)
        {            
            Util.maximizarCualquierIcono(modificar_pb, new Size(42, 54), 3);
        }

        private void eliminar_pb_MouseHover(object sender, EventArgs e)
        {            
            Util.maximizarCualquierIcono(eliminar_pb, new Size(46, 54), 3);
        }

        private void guardar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(guardar_pb, new Size(44, 48), 448, 61);
        }

        private void modificar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(modificar_pb, new Size(36, 48), 448, 194);
        }

        private void eliminar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(eliminar_pb, new Size(40, 48), 448, 320);
        }

        private void Buscar_MouseHover(object sender, EventArgs e)
        {
            Util.maximizarCualquierIcono(Buscar, new Size(36, 44), 4);            
        }

        private void Buscar_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(Buscar, new Size(28, 36), 268, 275);
        }

        private void nuevoRegistro_pb_MouseHover(object sender, EventArgs e)
        {
            Util.maximizarCualquierIcono(nuevoRegistro_pb, new Size(41, 52), 3);
            //MessageBox.Show(nuevoRegistro_pb.Top.ToString() + "left: " + nuevoRegistro_pb.Left.ToString() + "size: " + nuevoRegistro_pb.Size.Height.ToString() + nuevoRegistro_pb.Size.Width.ToString());
        }

        private void nuevoRegistro_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(nuevoRegistro_pb, new Size(37, 48), 448, 423);
        }

        private void nuevoRegistro_pb_Click(object sender, EventArgs e)
        {
            Util.clear(this);
            llenarComboBoxes();
        }

        //Metodo para habilitar los enter en la busqueda
        private void busqueda_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                buscar();
            }
        }
    }
}
