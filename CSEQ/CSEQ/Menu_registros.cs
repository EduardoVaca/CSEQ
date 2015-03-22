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
    public partial class Menu_registros : Form
    {
        public Menu_registros()
        {
            InitializeComponent();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_principal Menu_principal = new Menu_principal();
            Menu_principal.ShowDialog();
            this.Close();
        }

        private void Cregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
           Lista_registros Lista_registros= new Lista_registros(1);
            Lista_registros.ShowDialog();
            this.Close();
        }

        private void EditarRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_registros Lista_registros = new Lista_registros(2);
            Lista_registros.ShowDialog();
            this.Close();
        }

        private void EliminarRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_registros Lista_registros = new Lista_registros(3);
            Lista_registros.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
