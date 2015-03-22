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
    public partial class ConsultaRedactada : Form
    {
        public ConsultaRedactada()
        {
            InitializeComponent();
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SinEm_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SinEm_radioBtn.Checked)
            {
                PersonasEmpleo_label.Text = "Personas sin empleo:";
                NumPersonas_label.Text = "45";
                NumPorcentaje_label.Text = "45%";

            }
        }

        private void ConEm_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ConEm_radioBtn.Checked)
            {
                PersonasEmpleo_label.Text = "Personas con empleo:";
                NumPersonas_label.Text = "55";
                NumPorcentaje_label.Text = "55%";
            }
        }

        private void Atras_picture_Click(object sender, EventArgs e)
        {
            Menu_consultas menu = new Menu_consultas();
            menu.Show();
            this.Close();
        }
    }
}
