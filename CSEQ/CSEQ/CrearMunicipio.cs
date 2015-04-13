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
    public partial class CrearMunicipio : Form
    {
        String nombre;
        int ID_selected;

        public CrearMunicipio()
        {
            InitializeComponent();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
            this.Close();
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

        private void CrearMunicipio_Load(object sender, EventArgs e)
        {
            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado");
        }

        //Metodo donde se agrega el registro a la base de datos
        private void guardar_txt_Click(object sender, EventArgs e)
        {
            int mID_estado = Int32.Parse(ID_estado.SelectedValue.ToString());
            String mNombre = nombre_txt.Text;          
            if (Util.executeStoredProcedure("registrarMunicipio", mNombre, mID_estado))
            {
                MessageBox.Show("El Municipio se ha registrado con exito!");
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnMunicipio", busqueda);
            
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            

            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                nombre = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Municipio WHERE ";
                sqlActiveRow += " nombre= '" + nombre + "';";
                Util.showData(this, sqlActiveRow);
                ID_selected = Int32.Parse(ID_estado.SelectedValue.ToString());
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombre_txt.Text;
            int ID_nuevo = Int32.Parse(ID_estado.SelectedValue.ToString());
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar el municipio: " + nombre + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarMunicipio", nombre,ID_selected, nombreNuevo,ID_nuevo))
                {
                    MessageBox.Show("El municipio se modifico con exito");
                }
            }
        }
    }
}
