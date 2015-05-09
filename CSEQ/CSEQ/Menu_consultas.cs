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
    public partial class Menu_consultas : Form
    {
        int rol;

        public Menu_consultas(int rol)
        {
            this.rol = rol;
            InitializeComponent();

        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_picture_Click(object sender, EventArgs e)
        {            
            Menu_principal Menu_principal = new Menu_principal(rol);
            Menu_principal.Show();
            this.Close();
        }

        private void ConsultaGrafica_btn_Click(object sender, EventArgs e)
        {
            ConsultaGrafica consulta = new ConsultaGrafica(rol);
            this.Close();
            consulta.Show();
            
        }

        private void ConsultaRedactada_btn_Click(object sender, EventArgs e)
        {
            ConsultaRedactada consulta = new ConsultaRedactada();
            this.Close();
            consulta.Show();
            
        }

        private void salud_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            salud_combo.Enabled = true;
            empleo_combo.Enabled = false;
            demografia_combo.Enabled = false;
            educacion_combo.Enabled = false;           
        }

        private void demografia_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            salud_combo.Enabled = false;
            empleo_combo.Enabled = false;
            demografia_combo.Enabled = true;
            educacion_combo.Enabled = false;  
        }

        private void educacion_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            salud_combo.Enabled = false;
            empleo_combo.Enabled = false;
            demografia_combo.Enabled = false;
            educacion_combo.Enabled = true;  
        }

        private void empleo_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            salud_combo.Enabled = false;
            empleo_combo.Enabled = true;
            demografia_combo.Enabled = false;
            educacion_combo.Enabled = false;  
        }

        private void salud_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = salud_combo.SelectedIndex;
            consultas_salud salud = new consultas_salud(index, rol);
            salud.Show();
            this.Close();
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

        private void Menu_consultas_Load(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(x_picture, "Salir de la aplicación");
            cerrarSesion_tt.SetToolTip(logout, "Cerrar sesión");
        }

        private void educacion_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = educacion_combo.SelectedIndex;
            consulta_educacion educacion = new consulta_educacion(index, rol);
            educacion.Show();
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

        private void demografia_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = demografia_combo.SelectedIndex;
            consultas_demografia demografia = new consultas_demografia(index, rol);
            demografia.Show();
            this.Close();
        }

        private void empleo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = empleo_combo.SelectedIndex;
            consultas_empleo empleo = new consultas_empleo(index, rol);
            empleo.Show();
            this.Close();
        }
    }
}
