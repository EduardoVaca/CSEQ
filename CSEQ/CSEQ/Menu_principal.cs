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
            this.Hide();
            Menu_registros Menu_registros = new Menu_registros();            
            Menu_registros.ShowDialog();
            this.Close();
        }

        private void consultas_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_consultas Menu_consultas = new Menu_consultas();
            Menu_consultas.ShowDialog();
            this.Close();
        }

    }
}
