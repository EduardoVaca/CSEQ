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
    public partial class CrearAparatoAuditivo : Form
    {
        public CrearAparatoAuditivo()
        {
            InitializeComponent();
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Atras_picture_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        private void CrearAparatoAuditivo_Load(object sender, EventArgs e)
        {
            Util.llenarComboBox(ID_marca, "SELECT ID_marca, nombre FROM Marca");
        }
    }
}
