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
        int censo_selected;

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
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_btn.Enabled = true; //activacion de botones
                eliminar_btn.Enabled = true;
                censo_selected = Convert.ToInt16(busqueda_grid.Rows[e.RowIndex].Cells[0].Value);
                String sqlActiveRow = "SELECT * FROM Censo WHERE ";
                sqlActiveRow += " ano= '" + censo_selected + "';";
                Util.showData(this, sqlActiveRow);
            }
        }


        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Eliminar Censo:'" + censo_selected + "'?", "Confirmación de eliminación", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                respuesta = MessageBox.Show("Se eliminará TODA la informacion respecto al censo " + censo_selected +
                                            ". ¿Desea eliminarlo PERMANENTEMENTE?", "Mensaje de Seguridad", MessageBoxButtons.YesNo);
                if (respuesta == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Util.executeStoredProcedure("eliminarCenso", censo_selected))
                    {
                        MessageBox.Show("Se eliminó el Censo " + censo_selected + "con éxito!");
                    }
                }
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo = ano_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Censo: " + censo_selected + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarCenso", censo_selected, nombreNuevo))
                {
                    MessageBox.Show("El Censo se modifico con exito");
                }
            }
        }
    }
}
