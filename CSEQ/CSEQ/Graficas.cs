using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSEQ
{
    public partial class Graficas : Form
    {

        public Graficas()
        {
            InitializeComponent();

        }

        private void btnLlenarBarras_Click(object sender, EventArgs e)
        {
            String query = "CALL consultaHombresMujeres";
            String type = "Barra";
            Util.graphData(zedGraph,query,type);
        }

        private void btnLlenarPay_Click(object sender, EventArgs e)
        {
            String query = "CALL consultaHombresMujeres";
            String type = "Pay";
            Util.graphData(zedGraph, query, type);
        }

        private void Graficas_Load(object sender, EventArgs e)
        {
            Util.creaConexion("localhost", "CSEQ", "root", "");
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
