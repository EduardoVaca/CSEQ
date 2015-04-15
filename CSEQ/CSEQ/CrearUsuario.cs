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
        String nombre_selected;
        String nombre;
        String contrasena;
        int ID_rolViejo;

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
            Util.llenarComboBox(ID_rol, "SELECT ID_rol, nombre FROM Rol");
        }

        private void Guardar_txt_Click(object sender, EventArgs e)
        {
            String loginU = login_txt.Text;
            String passwordU = password_usuario_txt.Text;
            int rolU = Int32.Parse(ID_rol.SelectedValue.ToString());

            if (Util.executeStoredProcedure("registrarUsuario", loginU, passwordU, rolU))
            {
                MessageBox.Show("El usuario se ha registrado con exito!");
            }
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
                modificar_btn.Enabled = true; //Activacion de botones
                eliminar_btn.Enabled = true;
                nombre = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Usuario u, TieneRol t WHERE u.login = '" + nombre + "'  AND u.login = t.login;";
                Util.showData(this, sqlActiveRow);
                ID_rolViejo = Int32.Parse(ID_rol.SelectedValue.ToString());
            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar al usuario:'" + nombre + "'?", "Confirmacion de eliminar", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarUsuario", nombre))
                {
                    MessageBox.Show("Se elimino usuario con exito!");
                }
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
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
                Ventana.mostrarOculta(Ventana.Ventanas.Login);
            }
        }
    }
}
