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
        String nombre_selected;
        int idMunicpio;
        String nombre;
        int ID_selected;

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
            int id_estado = 22;
            ID_estado.SelectedIndex = id_estado - 1;
            Util.llenarComboBox(ID_municipio, "SELECT m.ID_municipio,m.nombre FROM Municipio m,Estado e WHERE m.ID_estado=e.ID_estado AND e.ID_estado=" + id_estado + ";");


            if (ID_municipio.SelectedItem != null)
            {
                int id_municipio = Int32.Parse(ID_municipio.SelectedValue.ToString());
                String inicio = "SELECT distinct d.ID_delegacion,d.nombre FROM Municipio m, Delegacion d, Colonia c WHERE d.ID_municipio=m.ID_municipio AND m.ID_municipio=c.ID_municipio AND d.ID_delegacion = c.ID_Delegacion;";
                Util.llenarComboBox(ID_delegacion, inicio);
            }

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
        /*------------------------------------------------------------------------------------*/
        private void Guardar_Click(object sender, EventArgs e)
        {
            String cNombre = nombre_txt.Text;
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
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_btn.Enabled = true; //Activacion de botones
                eliminar_btn.Enabled = true;
                nombre_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT DISTINCT * FROM Colonia c, Estado e, Delegacion d , Municipio m WHERE ";
                sqlActiveRow += " c.nombre= '" + nombre_selected + "' AND c.ID_municipio=m.ID_municipio  AND c.ID_delegacion=d.ID_delegacion AND m.ID_estado=e.ID_estado;";
                Util.showData(this, sqlActiveRow);
                idMunicpio = Int32.Parse(ID_municipio.SelectedValue.ToString());
                ID_selected = Int32.Parse(ID_municipio.SelectedValue.ToString());
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombre_txt.Text;
            int ID_nuevo = Int32.Parse(ID_municipio.SelectedValue.ToString());
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar la colonia: " + nombre + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarColonia", nombre, ID_selected, nombreNuevo, ID_nuevo))
                {
                    MessageBox.Show("La colonia se modifico con exito");
                }
            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar colonia:'" + nombre_selected + "'?", "Confirmacion de Eliminar",
                                        MessageBoxButtons.YesNo);
                       
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarColonia", nombre_selected, idMunicpio))
                {
                    MessageBox.Show("La colonia se elimino con exito!");
                }
            }
        }
        




        
    }
}
