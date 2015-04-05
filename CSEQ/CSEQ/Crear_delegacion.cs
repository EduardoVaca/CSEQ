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


    }
}
