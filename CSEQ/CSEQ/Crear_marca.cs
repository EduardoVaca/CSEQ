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
    public partial class Crear_marca : Form
    {
        String nombre_selected;
        int rol;

        public Crear_marca(int rol)
        {
            this.rol = rol;
            InitializeComponent();            
        }

        private void close_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void atras_picture_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        //Metodo donde se agrega el registro a la base de datos
        private void guardar_btn_Click(object sender, EventArgs e)
        {            
            String mNombre = nombre_txt.Text;
            
            if (Util.executeStoredProcedure("registrarMarca", mNombre))
            {
                MessageBox.Show("La Marca se ha registrado con exito!");
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnMarca", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {            
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_btn.Enabled = true; //activacion de botones
                eliminar_btn.Enabled = true;
                nombre_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Marca WHERE ";
                sqlActiveRow += " nombre= '" + nombre_selected + "';";
                Util.showData(this, sqlActiveRow);
            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Seguro quiere eliminar marca:'" + nombre_selected + "'?",
                                    "Confirmación de Eliminar", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarMarca", nombre_selected))
                {
                    MessageBox.Show("La marca:" + nombre_selected + " se elimino con exito!");
                }
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombre_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Marca: " + nombre_selected + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarMarca", nombre_selected, nombreNuevo))
                {
                    MessageBox.Show("La marca se modifico con exito");
                }
            }
        }

        private void Crear_marca_Load(object sender, EventArgs e)
        {
            if (rol == 1)
            {
                imagen.Visible = false;
                Busqueda_grp.Visible = true;
                modificar_btn.Visible = true;
                eliminar_btn.Visible = true;
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
