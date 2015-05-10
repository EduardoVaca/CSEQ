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
    public partial class informacion : Form
    {
        int rol;

        public informacion(int rol)
        {
            InitializeComponent();
            this.rol = rol;
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            Menu_principal menu = new Menu_principal(rol);
            this.Close();
            menu.Show();
        }

        private void back_picture_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(back_picture);
        }

        private void back_picture_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(back_picture);
        }
    }
}
