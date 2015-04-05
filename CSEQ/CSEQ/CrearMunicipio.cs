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
    public partial class CrearMunicipio : Form
    {
        public CrearMunicipio()
        {
            InitializeComponent();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
            this.Close();
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

        private void CrearMunicipio_Load(object sender, EventArgs e)
        {
            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado");
        }

        //Metodo donde se agrega el registro a la base de datos
        private void guardar_txt_Click(object sender, EventArgs e)
        {
            int mID_estado = Int32.Parse(ID_estado.SelectedValue.ToString());
            String mNombre = municipio_txt.Text;          
            if (Util.executeStoredProcedure("registrarMunicipio", mNombre, mID_estado))
            {
                MessageBox.Show("El Municipio se ha registrado con exito!");
            }
        }
    }
}
