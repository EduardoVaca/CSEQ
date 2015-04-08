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

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            String iNombre = nombre_txt.Text;
            String iTelefono = telefono_txt.Text;
            String iCorreo = correo_txt.Text;
            String iCalle = calle_txt.Text;
            int iID_colonia = Int32.Parse(ID_colonia.SelectedValue.ToString());
            int iPrivada;
            int iEspecializada;
            if (privada_check.Checked)
                iPrivada = 1;
            else
                iPrivada = 0;
            if (especializada_check.Checked)
                iEspecializada = 1;
            else
                iEspecializada = 0;

            if (Util.executeStoredProcedure("registrarInstitucionEducativa", iNombre, iCalle, iTelefono, iCorreo, iPrivada, iEspecializada, iID_colonia))
            {
                MessageBox.Show("La Institucion Educativa se registro con exito!");
            }

        }
       


    }
}
