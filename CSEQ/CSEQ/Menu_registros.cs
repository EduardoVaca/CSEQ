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
            Menu_principal Menu_principal = new Menu_principal();
            Menu_principal.Show();
        }

        private void Cregistro_Click(object sender, EventArgs e)
        {
           Lista_registros Lista_registros= new Lista_registros(1);
           this.Close();
            Lista_registros.Show();
        }

        private void EditarRegistro_Click(object sender, EventArgs e)
        {
            Lista_registros Lista_registros = new Lista_registros(2);
            this.Close();
            Lista_registros.Show();
        }

        private void EliminarRegistro_Click(object sender, EventArgs e)
        {
            Lista_registros Lista_registros = new Lista_registros(3);
            this.Close();
            Lista_registros.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
