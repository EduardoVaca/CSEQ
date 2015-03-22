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
    public partial class Crear_causa : Form
    {
        public Crear_causa(String Nombre)
        {
            InitializeComponent();
            nombreCausa_txt.Text = Nombre;
        }

        private void close_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
