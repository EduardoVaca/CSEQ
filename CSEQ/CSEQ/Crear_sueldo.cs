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
    public partial class Crear_sueldo : Form
    {
        public Crear_sueldo()
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
            String sMinimo = minimo_txt.Text;
            String sMaximo = maximo_txt.Text;

            if (Util.executeStoredProcedure("registrarSueldo", sMinimo, sMaximo))
            {
                MessageBox.Show("El Sueldo se ha registrado con exito!");
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnSueldo", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            String minimo;
            String maximo;

            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                minimo = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                maximo = busqueda_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                String sqlActiveRow = "SELECT * FROM sueldo WHERE ";
                sqlActiveRow += " maximo= '" + maximo + "' AND minimo= '" + minimo + "';";
                Util.showData(this, sqlActiveRow);
            }
        }


    }
}
