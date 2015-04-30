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

        private void Buscar_Click(object sender, EventArgs e)
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnUsuario", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {            
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_pb.Enabled = true; //Activacion de botones
                eliminar_pb.Enabled = true;
                nombre = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Usuario u, TieneRol t WHERE u.login = '" + nombre + "'  AND u.login = t.login;";
                Util.showData(this, sqlActiveRow);
                ID_rolViejo = Int32.Parse(ID_rol.SelectedValue.ToString());
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

        private void Atras_picture_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(Atras_picture);
        }

        private void Atras_picture_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(Atras_picture);
        }

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
    }
}
