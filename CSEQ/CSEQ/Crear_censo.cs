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
    public partial class Crear_censo : Form
    {
        public Crear_censo()
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

        //Metodo donde se agrega el registro a la base de datos
        private void guardar_btn_Click(object sender, EventArgs e)
        {
            if (ano_txt.TextLength == 4)
            {                
                int cAno = Int16.Parse(ano_txt.Text);
                
                if (Util.executeStoredProcedure("registrarCenso", cAno))
                {
                    MessageBox.Show("El Censo se ha registrado con exito!");
                }
            }
            else
                MessageBox.Show("El año debe tener 4 digitos");
            
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

            int busquedaNum;
            if (busqueda_txt.Text != "" && busqueda_txt.Text.Length > 3)
            {
                busquedaNum = Convert.ToInt16(busqueda_txt.Text.ToString());
                Util.fillGrid(busqueda_grid, "busquedaEnCenso", busquedaNum);
            }
            else
                busquedaNum = 2010;
                Util.fillGrid(busqueda_grid, "busquedaEnCenso", busquedaNum);

        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int censo;

            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                censo = Convert.ToInt16(busqueda_grid.Rows[e.RowIndex].Cells[0].Value);
                String sqlActiveRow = "SELECT * FROM Censo WHERE ";
                sqlActiveRow += " ano= '" + censo + "';";
                Util.showData(this, sqlActiveRow);
            }
        }

        private void Crear_censo_Load(object sender, EventArgs e)
        {

        }
    }
}
