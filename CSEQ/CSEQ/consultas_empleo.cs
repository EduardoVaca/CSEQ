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
    public partial class consultas_empleo : Form
    {

        int index;
        int rol;

        public consultas_empleo(int index, int rol)
        {
            this.index = index;
            this.rol = rol;
            InitializeComponent();
        }

        private void consultas_empleo_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(close_picture, "Salir");
            toolTip.SetToolTip(logout, "Cerrar Sesión");
            Util.llenarComboBox(ID_censo, "SELECT * FROM Censo");
            if (index == 0)
                titulo.Text = "Estadísticas Generales";
        }

        private void close_picture_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas salir de la aplicación?", "Mensaje de Confirmación", MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            } 
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

        private void back_picture_Click(object sender, EventArgs e)
        {
            Menu_consultas Menu_principalConsultas = new Menu_consultas(rol);
            Menu_principalConsultas.Show();
            this.Close();
        }

        private void back_picture_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(back_picture);
        }

        private void back_picture_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(back_picture);
        }

        private void generales_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eleccion_gp.Enabled = true;
            Reporte.Enabled = true;

            if (generales_combo.SelectedIndex == 0)
            {
                conEmpleo_radio.Visible = true;
                sinEmpleo_radio.Visible = true;
            }
            else
            {
                conEmpleo_radio.Visible = false;
                sinEmpleo_radio.Visible = false;
                areaTrabajo_gp.Visible = false;
            }
        }

        private void conEmpleo_radio_CheckedChanged(object sender, EventArgs e)
        {
            areaTrabajo_gp.Visible = true;
        }

        private void sinEmpleo_radio_CheckedChanged(object sender, EventArgs e)
        {
            areaTrabajo_gp.Visible = false;
        }
    }
}
