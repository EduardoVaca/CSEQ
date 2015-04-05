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

        //Metodo donde se agrega el registro a la base de datos
        private void Guardar_txt_Click(object sender, EventArgs e)
        {            
            String mTipo = tipo_txt.Text;
            int mID_marca = Int32.Parse(ID_marca.SelectedValue.ToString());
            
            if (Util.executeStoredProcedure("registrarAparatoAuditivo", mTipo, mID_marca))
            {
                MessageBox.Show("El Aparato Auditivo se ha registrado con exito!");
            }
        }
    }
}
