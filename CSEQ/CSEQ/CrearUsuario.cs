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
        String nombre;
        String contrasena;

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
           
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnUsuario", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           

            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                nombre = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                contrasena = busqueda_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Usuario WHERE ";
                sqlActiveRow += " nombre= '" + nombre + "';";
                Util.showData(this, sqlActiveRow);
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombre_txt.Text;
            String nuevoPass = password_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Usuario: " + nombre + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarAreaTrabajo", nombre,contrasena , nombreNuevo,nuevoPass))
                {
                    MessageBox.Show("El area de trabajo se modifico con exito");
                }
            }
        }
    }
}
