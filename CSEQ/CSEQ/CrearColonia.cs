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
    public partial class CrearColonia : Form
    {
        public CrearColonia()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        private void CrearColonia_Load(object sender, EventArgs e)
        {
            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado;");

        }
        /*--------------------------------------------------------------------------------
         * Metodos los cuales llenan un comboBox basandose en el contenido de otro comboBox
         * Ejemplo: Estado - > Municipios
         */
        private void ID_estado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String valorComboBox = ID_estado.SelectedValue.ToString();           
            Util.llenarComboBox(ID_municipio, "SELECT ID_municipio, nombre FROM Municipio WHERE " +
                                                "ID_estado = " + valorComboBox + ";");
        }

        private void ID_municipio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String valorComboBox = ID_municipio.SelectedValue.ToString();
            Util.llenarComboBox(ID_delegacion, "SELECT ID_delegacion, nombre FROM Delegacion WHERE " +
                                                "ID_municipio = " + valorComboBox + ";");
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            String cNombre = colonia_txt.Text;
            int cID_delegacion = Int32.Parse(ID_delegacion.SelectedValue.ToString());
            int cID_municipio = Int32.Parse(ID_municipio.SelectedValue.ToString());

            if (Util.executeStoredProcedure("registrarColonia", cNombre, cID_delegacion, cID_municipio))
            {
                MessageBox.Show("La Colonia se ha registrado con exito!");
            }
            //Falta checar duda de atributos en nulo
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnColonia", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            String nombre;

            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                nombre = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Colonia WHERE ";
                sqlActiveRow += " nombre= '" + nombre + "';";
                Util.showData(this, sqlActiveRow);
            }
        }
        /*------------------------------------------------------------------------------------*/




        
    }
}
