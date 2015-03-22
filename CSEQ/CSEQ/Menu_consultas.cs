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
        public Menu_consultas()
        {
            InitializeComponent();

        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_principal Menu_principal = new Menu_principal();
            Menu_principal.ShowDialog();
            this.Close();
        }
    }
}
