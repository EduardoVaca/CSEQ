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
    public partial class crearAreaTrabajo : Form
    {
        String nombre;

        public crearAreaTrabajo()
        {
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

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            String aNombre = nombreArea_txt.Text;

            if (Util.executeStoredProcedure("registrarAreaTrabajo", aNombre))
            {
                MessageBox.Show("Area de Trabajo se guardo con exito!");
            }
        }
        

        private void Buscar_Click(object sender, EventArgs e)
        {
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnAreaTrabajo", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                nombre = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM AreaTrabajo WHERE ";
                sqlActiveRow += " nombre= '" + nombre + "';";
                Util.showData(this, sqlActiveRow);
            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {

        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombreArea_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Area de trabajo: " + nombre + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarAreaTrabajo", nombre, nombreNuevo))
                {
                    MessageBox.Show("El area de trabajo se modifico con exito");
                }
            }
        }
    }
}
