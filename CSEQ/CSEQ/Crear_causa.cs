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
    public partial class Crear_causa : Form
    {
        public Crear_causa()
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
            String cNombre = causa_txt.Text;
                       
            if (Util.executeStoredProcedure("registrarCausa", cNombre))
            {
                MessageBox.Show("La Causa se ha registrado con exito!");
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnCausa", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            String causa;

            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                causa = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Causa WHERE ";
                sqlActiveRow += " causa= '" + causa + "';";
                Util.showData(this, sqlActiveRow);
            }
        }


    }
}
