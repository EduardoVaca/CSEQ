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
    public partial class consultas_salud : Form
    {
        int index;
        String query;

        public consultas_salud(int index)
        {
            this.index = index;
            InitializeComponent();
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            Menu_consultas Menu_principalConsultas = new Menu_consultas();
            Menu_principalConsultas.Show();
            this.Close();
        }

        private void consultas_salud_Load(object sender, EventArgs e)
        {            
            if (index == 0)
            {
                titulo.Text = "Auxiliares Auditivos";
                AuxiliaresAuditivos_grp.Visible = true;
            }

            Util.llenarComboBox(ID_censo, "SELECT * FROM Censo");
        }

        private void auxiliarAuditivo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ID_censo.Enabled = true;
            todoscensos_radio.Enabled = true;
        }


        private void todoscensos_radio_CheckedChanged(object sender, EventArgs e)
        {
            Reporte.Enabled = true;

            query = "CALL consultaMarca();";
            String type = "Barra";
            index = 0;
            Util.graphData(zedGraph, query, type);
        }

        private void ID_censo_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            int id_censo = Int32.Parse(ID_censo.SelectedValue.ToString());
            Reporte.Enabled = true;
           
            switch (auxiliarAuditivo_combo.SelectedIndex)
            {
                case 0:
                    query = "CALL consultaMarcaPorCenso(" + id_censo + ");";
                    String type = "Barra";
                    index = 0;
                    Util.graphData(zedGraph, query, type);
                    break;

                default:
                    break;
            }
        }

        private void Reporte_Click(object sender, EventArgs e)
        {

            Reporte Nuevo = new Reporte(query,index);
            Nuevo.Show();            
            
        }
    }
}
