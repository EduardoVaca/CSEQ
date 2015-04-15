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
    public partial class Reporte : Form
    {
        String query;
        int index;

        public Reporte(String query,int index)
        {
            InitializeComponent();
            this.query = query;
            this.index = index;
            
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            switch(index){
                case 0:
                    ReporteMarca report = new ReporteMarca();
                    report.SetDataSource(Util.getData(query));
                    reportViewer.ReportSource = report;
                    break;
                default:
                    MessageBox.Show("Reporte no valido");
                    break;
            }
            //ReportesCSEQ report = new ReportesCSEQ();
            //report.SetDataSource(Util.getData(query));
           // reportViewer.ReportSource = report;
        }
    }
}
