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

    public partial class Crear_delegacion : Form
    {
        String delegacion;
        String municipio;
        int ID_selected;
        public Crear_delegacion()
        {
            InitializeComponent();            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void atras_picture_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        private void Crear_delegacion_Load(object sender, EventArgs e)
        {

            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado");
            int id_estado = 22;
            ID_estado.SelectedIndex = id_estado - 1;
            Util.llenarComboBox(ID_municipio, "SELECT m.ID_municipio,m.nombre FROM Municipio m,Estado e WHERE m.ID_estado=e.ID_estado AND e.ID_estado=" + id_estado + ";");
        }

        /*--------------------------------------------------------------------------------
         * Metodos los cuales llenan un comboBox basandose en el contenido de otro comboBox
         * Ejemplo: Estado - > Municipios
         */
        private void ID_estado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String valorComboBox = ID_estado.SelectedValue.ToString();
            Util.llenarComboBox(ID_municipio, "SELECT ID_municipio, nombre FROM Municipio WHERE " +
                                                "ID_estado = " + valorComboBox);
        }

        /*-----------------------------------------------------------------------------------*/

        //Metodo donde se agrega el registro a la base de datos
        private void guardar_btn_Click(object sender, EventArgs e)
        {            
            String dNombre = nombre_txt.Text;
            int dID_municipio = Int32.Parse(ID_municipio.SelectedValue.ToString());
            
            if (Util.executeStoredProcedure("registrarDelegacion", dNombre, dID_municipio))
            {
                MessageBox.Show("La Delegacion se ha registrado con exito!");
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnDelegacion", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            

            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                delegacion = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                municipio = busqueda_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Delegacion d, Municipio m WHERE ";
                sqlActiveRow += " d.nombre= '" + delegacion +"' AND m.nombre='" + municipio +"' AND d.ID_municipio=m.ID_municipio;";
                Util.showData(this, sqlActiveRow);
                ID_selected = Int32.Parse(ID_estado.SelectedValue.ToString());
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombre_txt.Text;
            String municipioNuevo = ID_municipio.SelectedValue.ToString();
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar la delegacion: " + delegacion + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarDelegacion", delegacion, municipio, nombreNuevo, municipioNuevo))
                {
                    MessageBox.Show("La delegacion se modifico con exito");
                }
            }
        }



    }
}
