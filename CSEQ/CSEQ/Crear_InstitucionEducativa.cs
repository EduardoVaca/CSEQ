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
    public partial class Crear_InstitucionEducativa : Form
    {
        public Crear_InstitucionEducativa()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        private void Crear_InstitucionEducativa_Load(object sender, EventArgs e)
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

        private void ID_municipio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String valorComboBox = ID_municipio.SelectedValue.ToString();                                                
            Util.llenarComboBox(ID_delegacion, "SELECT ID_delegacion, nombre FROM Delegacion WHERE " +
                                                "ID_municipio = " + valorComboBox);
            Util.llenarComboBox(ID_colonia, "SELECT ID_colonia, nombre FROM Colonia WHERE " +
                                               "ID_municipio = " + valorComboBox);
        }
        /*---------------------------------------------------------------------*/


    }
}
