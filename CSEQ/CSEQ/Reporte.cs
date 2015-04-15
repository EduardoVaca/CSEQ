﻿using System;
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
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            String query = "CALL consultaHombresMujeres;";
            ReportesCSEQ report = new ReportesCSEQ();
            report.SetDataSource(Util.getData(query));
            reportViewer.ReportSource = report;
        }
    }
}
