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
        }

        private void auxiliarAuditivo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

            switch (auxiliarAuditivo_combo.SelectedIndex)
            {
                case 0:
                    query = "CALL consultaMarca();";
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
            
            MessageBox.Show(auxiliarAuditivo_combo.SelectedIndex.ToString());
            
           // if (auxiliarAuditivo_combo.SelectedValue != "")
           // {
                Reporte Nuevo = new Reporte(query,index);
                Nuevo.Show();
            //}
            
        }
    }
}
