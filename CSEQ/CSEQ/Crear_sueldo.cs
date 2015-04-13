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

        String minimo_selected;
        String maximo_selected;

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
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_btn.Enabled = true; //Activacion de botones
                eliminar_btn.Enabled = true;
                minimo_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                maximo_selected = busqueda_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                String sqlActiveRow = "SELECT * FROM sueldo WHERE ";
                sqlActiveRow += " maximo= '" + maximo_selected + "' AND minimo= '" + minimo_selected + "';";
                Util.showData(this, sqlActiveRow);
            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar el sueldo?", "Confirmacion de eliminacion", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarSueldo", minimo_selected, maximo_selected))
                {
                    MessageBox.Show("El sueldo se elimino con exito!");
                }
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String minimoNuevo = minimo_txt.Text;
            String maximoNuevo = maximo_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar salario minimo: " + minimo_selected + " y salario maximo: "+maximo_selected+"'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarSueldo", minimo_selected, maximo_selected,minimoNuevo,maximoNuevo))
                {
                    MessageBox.Show("El salario se modifico con exito");
                }
            }
        }


    }
}
