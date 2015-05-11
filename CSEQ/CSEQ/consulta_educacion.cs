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
    public partial class consulta_educacion : Form
    {
        int index;
        int rol;

        public consulta_educacion(int index, int rol)
        {
            this.index = index;
            this.rol = rol;
            InitializeComponent();            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas salir de la aplicación?", "Mensaje de Confirmación", MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void close_picture_MouseHover(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(close_picture, "Salir de la aplicación");
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }
        }

        private void logout_MouseHover(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(logout, "Cerrar sesión");
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            Menu_consultas Menu_principalConsultas = new Menu_consultas(rol);
            Menu_principalConsultas.Show();
            this.Close();
        }

        private void consulta_educacion_Load(object sender, EventArgs e)
        {
            Util.llenarComboBox(ID_censo, "SELECT * FROM Censo");
            if (index == 0){
                titulo.Text = "Comunicación y Lenguaje";
                comunicacion_combo.Visible = true;
            }

            else if (index == 1)
            {
                titulo.Text = "Nivel Educativo y Tipo de Educación";
                nivelEducativo_combo.Visible = true;
            }
                
        }

        private void back_picture_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(back_picture);
        }

        private void back_picture_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(back_picture);
        }

        private void nivelEducativo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eleccion_gp.Enabled = true;
            Reporte.Enabled = true;

            if (nivelEducativo_combo.SelectedIndex == 2)
            {
                nivelesEducativos_gp.Visible = true;
            }
            else
            {
                nivelesEducativos_gp.Visible = false;
            }

            if (nivelEducativo_combo.SelectedIndex == 3)
            {
                privada_radio.Visible = true;
                publica_radio.Visible = true;
            }
            else
            {
                privada_radio.Visible = false;
                publica_radio.Visible = false;
            }
        }

        private void comunicacion_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eleccion_gp.Enabled = true;
            Reporte.Enabled = true;
        }
    }
}
