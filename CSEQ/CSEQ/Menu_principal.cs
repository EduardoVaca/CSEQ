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

        private void x_picture_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(x_picture, "Salir de la aplicación");
        }

        private void logout_MouseHover(object sender, EventArgs e)
        {
            cerrarSesion_tt.SetToolTip(logout, "Cerrar Sesión");
        }

        private void registros_pb_Click(object sender, EventArgs e)
        {
            Lista_registros Lista_registros = new Lista_registros(rol);
            this.Close();
            Lista_registros.Show();
        }

        private void consultas_pb_Click(object sender, EventArgs e)
        {
            Menu_consultas Menu_consultas = new Menu_consultas(rol);
            this.Close();
            Menu_consultas.Show();
        }

        private void registros_pb_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show(registros_pb.Size.ToString() + "\n" + registros_pb.Top.ToString() + "\n" + registros_pb.Left.ToString());
            Util.maximizarCualquierIcono(registros_pb, new Size(114, 132), 5);            
        }

        private void registros_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(registros_pb, new Size(104, 122), 162, 187);
        }

        private void consultas_pb_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show(consultas_pb.Size.ToString() + "\n" + consultas_pb.Top.ToString() + "\n" + consultas_pb.Left.ToString());
            Util.maximizarCualquierIcono(consultas_pb, new Size(114, 132), 5);
        }

        private void consultas_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(consultas_pb, new Size(104, 122), 162, 543);
        }

    }
}
