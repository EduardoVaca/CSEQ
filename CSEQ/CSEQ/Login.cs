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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresar_btn_Click(object sender, EventArgs e)
        {
            Menu_principal Menu_principal = new Menu_principal();
            this.Hide();
            Menu_principal.Show();            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Util.creaConexion("localhost", "CSEQ", "EduardoVaca", "EduardoVaca");
        }




       
    }
}
