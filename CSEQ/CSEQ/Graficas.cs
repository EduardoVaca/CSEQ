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
        double[] yValues = { 49.3, 38.5, 5.9, 1.0 };
        string[] xValuesPay = { "49.3%", "38.5%", "5.9%", "1.0%" };
        string[] xValuesBarras = { "holi", "lol", "xD", ":P" };
        

        public Graficas()
        {
            InitializeComponent();
        }

        private void btnLlenarBarras_Click(object sender, EventArgs e)
        {
            chartBarras.Palette = ChartColorPalette.Fire;
            chartBarras.Series.Add("Serie1");
            chartBarras.Series[0].Name = "Series";
            chartBarras.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chartBarras.Series[0].ChartArea = "ChartArea1";

            chartBarras.Legends.Add("");
            chartBarras.Legends[0].Name = "";
            chartBarras.Series[0].Points.DataBindXY(xValuesBarras, yValues);

            for (int i = 0; i < yValues.Length; i++)
            {
                chartBarras.Series[0].Points[i].Label = yValues[i].ToString();
            }

            btnLlenarBarras.Enabled = false;
        }

        private void btnLlenarPay_Click(object sender, EventArgs e)
        {
            chartPay.Series.Add("");
            chartPay.Series[0].Name = "";
            chartPay.Series[0].Color = Color.Transparent;
            chartPay.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chartPay.Legends.Add("");
            chartPay.Legends[0].Name = "";
            chartPay.Series[0].Points.DataBindXY(xValuesPay, yValues);
            chartPay.Series[0].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;

            for (int i = 0; i < xValuesPay.Length; i++)
            {
                chartBarras.Series[0].Points[i].LegendText = xValuesBarras[i];
            }

            btnLlenarPay.Enabled = false;
        }

        private void Graficas_Load(object sender, EventArgs e)
        {

        }
    }
}
