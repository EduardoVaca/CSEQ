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
    public partial class Menu_principal : Form
    {
        int rol; 
        public Menu_principal(int rol)
        {
            InitializeComponent();
            this.rol = rol;
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registros_btn_Click(object sender, EventArgs e)
        {
            Lista_registros Lista_registros = new Lista_registros(rol);
            this.Close();
            Lista_registros.Show();
        }

        private void consultas_btn_Click(object sender, EventArgs e)
        {
            Menu_consultas Menu_consultas = new Menu_consultas(rol);
            this.Close();
            Menu_consultas.Show();
          
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

    }
}
