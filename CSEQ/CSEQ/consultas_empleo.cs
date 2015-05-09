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
    public partial class consultas_empleo : Form
    {

        int index;
        int rol;

        public consultas_empleo(int index, int rol)
        {
            this.index = index;
            this.rol = rol;
            InitializeComponent();
        }

        private void consultas_empleo_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(close_picture, "Salir");
            toolTip.SetToolTip(logout, "Cerrar Sesión");
            Util.llenarComboBox(ID_censo, "SELECT * FROM Censo");
            if (index == 0)
                titulo.Text = "Estadísticas Generales";
        }

        private void close_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
