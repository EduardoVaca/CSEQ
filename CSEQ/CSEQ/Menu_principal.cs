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
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registros_btn_Click(object sender, EventArgs e)
        {
            Menu_registros Menu_registros = new Menu_registros();
            this.Close();
            Menu_registros.Show();
            
        }

        private void consultas_btn_Click(object sender, EventArgs e)
        {
            Menu_consultas Menu_consultas = new Menu_consultas();
            this.Close();
            Menu_consultas.Show();
          
        }

    }
}
