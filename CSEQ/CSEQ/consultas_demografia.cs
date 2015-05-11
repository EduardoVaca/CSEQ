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
    public partial class consultas_demografia : Form
    {
        int index;
        int rol;

        public consultas_demografia(int index, int rol)
        {
            this.index = index;
            this.rol = rol;
            InitializeComponent();
        }

        private void consultas_demografia_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(logout, "Cerrar Sesión");
            toolTip.SetToolTip(close_picture, "Salir");
            Util.llenarComboBox(ID_censo, "SELECT * FROM Censo");            
            if (index == 0){
                titulo.Text = "Estadísticas Generales";
                generales_combo.Visible = true;
            }
                
            else if (index == 1){
                titulo.Text = "Estado Civil y Familia";
                estadoCivil_combo.Visible = true;
            }
            else if (index == 2)
            {
                titulo.Text = "Migración";
                migracion_combo.Visible = true;
            }
                
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

            if (generales_combo.SelectedIndex == 3)
            {
                edades_gp.Visible = true;
            }
            else
            {
                edades_gp.Visible = false;
            }
            

            if (generales_combo.SelectedIndex == 4)
            {
                lenguaDom_gp.Visible = true;
            }
            else
            {
                lenguaDom_gp.Visible = false;
            }

            if (generales_combo.SelectedIndex == 5)
            {
                empleo_gp.Visible = true;
            }
            else
            {
                empleo_gp.Visible = false;                
            }
        }


        private void estadoCivil_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eleccion_gp.Enabled = true;
            Reporte.Enabled = true;

            if (estadoCivil_combo.SelectedIndex == 0)
            {
                estadoCivil_gp.Visible = true;
            }
            else
            {
                estadoCivil_gp.Visible = false;
            }

            if (estadoCivil_combo.SelectedIndex == 1)
            {
                conHijos_radio.Visible = true;
                sinHijos_radio.Visible = true;
            }
        }

        private void conHijos_radio_CheckedChanged(object sender, EventArgs e)
        {
            hijos_gp.Visible = true;
        }

        private void sinHijos_radio_CheckedChanged(object sender, EventArgs e)
        {
            hijos_gp.Visible = false;
        }

        private void Reporte_Click(object sender, EventArgs e)
        {

        }
    }
}
