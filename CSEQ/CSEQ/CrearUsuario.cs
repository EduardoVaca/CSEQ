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
    public partial class CrearUsuario : Form
    {                      
        int ID_rolViejo;
        String nombre;
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Atras_picture_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(x_picture, "Salir de la aplicación");
            cerrarSesion_tt.SetToolTip(logout, "Cerrar sesión");
            Util.llenarComboBox(ID_rol, "SELECT ID_rol, nombre FROM Rol");
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
            Util.fillGrid(busqueda_grid, "busquedaEnUsuario", busqueda);
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
            Cursor = Cursors.WaitCursor;
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_pb.Enabled = true; //Activacion de botones
                eliminar_pb.Enabled = true;
                nombre = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Usuario u, TieneRol t WHERE u.login = '" + nombre + "'  AND u.login = t.login;";
                Util.showData(this, sqlActiveRow);
                ID_rolViejo = Int32.Parse(ID_rol.SelectedValue.ToString());
            }
            Cursor = Cursors.Default;
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

        private void Atras_picture_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(Atras_picture);
        }

        private void Atras_picture_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(Atras_picture);
        }

        /*Metodo que guarda un nuevo registro en la Base*/
        private void guardar_pb_Click(object sender, EventArgs e)
        {
            String loginU = login_txt.Text;
            String passwordU = password_usuario_txt.Text;
            int rolU = Int32.Parse(ID_rol.SelectedValue.ToString());

            if (Util.executeStoredProcedure("registrarUsuario", loginU, passwordU, rolU))
            {
                MessageBox.Show("El usuario se ha registrado con exito!");
                Util.fillGrid(busqueda_grid, "busquedaEnUsuario", "%");
            }
        }

        /*Metodo que modifica un registro en la Base*/
        private void modificar_pb_Click(object sender, EventArgs e)
        {
            String nombreNuevo = login_txt.Text;
            String nuevoPass = password_usuario_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Usuario: " + nombre + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            int ID_rolNuevo = Int32.Parse(ID_rol.SelectedValue.ToString());
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarUsuario", nombre, nombreNuevo, nuevoPass, ID_rolViejo, ID_rolNuevo))
                {
                    MessageBox.Show("El area Usuario se modifico con exito");
                    Util.fillGrid(busqueda_grid, "busquedaEnUsuario", "%");
                }
            }
        }

        /*Metodo que elimina un registro elegido de la base*/
        private void eliminar_pb_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar al usuario:'" + nombre + "'?", "Confirmacion de eliminar", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarUsuario", nombre))
                {
                    MessageBox.Show("Se elimino usuario con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnUsuario", "%");
                }
            }
        }

        private void guardar_pb_MouseHover(object sender, EventArgs e)
        {
            Util.maximizarCualquierIcono(guardar_pb, new Size(50, 53), 3);
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
            Util.minimizarCualquierIcono(guardar_pb, new Size(44, 47), 362, 62);
        }

        private void modificar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(modificar_pb, new Size(36, 48), 362, 182);
        }

        private void eliminar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(eliminar_pb, new Size(40, 48), 362, 294);
        }

        private void Buscar_MouseHover(object sender, EventArgs e)
        {
            Util.maximizarCualquierIcono(Buscar, new Size(34, 38), 4);
        }

        private void Buscar_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(Buscar, new Size(30, 36), 32, 305);
        }

        private void nuevoRegistro_pb_Click(object sender, EventArgs e)
        {
            Util.clear(this);
            Util.llenarComboBox(ID_rol, "SELECT ID_rol, nombre FROM Rol");
        }

        private void nuevoRegistro_pb_MouseHover(object sender, EventArgs e)
        {
            Util.maximizarCualquierIcono(nuevoRegistro_pb, new Size(36, 42), 3);
        }

        private void nuevoRegistro_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(nuevoRegistro_pb, new Size(32, 38), 485, 6);
        }

        //Metodo que habilita los Enter en las busquedas
        private void busqueda_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                buscar();
            }
        }
    }
}
