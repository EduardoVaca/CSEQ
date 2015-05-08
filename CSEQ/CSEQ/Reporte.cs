﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace CSEQ
{
    public partial class Reporte : Form
    {
        String query;
        int index;
        int entrada;
        int censo;
        int indexReporte;
        DataSet Tablas;
        String nombre;

        //salida =1 Genera reporte de todos los censos
        //salida =2 Genera reporte de censo por año

        public Reporte(String query,int index,int indexReporte,int entrada,int censo)
        {
            InitializeComponent();
            this.query = query;
            this.index = index;
            this.entrada = entrada;
            this.censo = censo;
            this.indexReporte = indexReporte;
            
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            switch (index)
            {
                case 0:
                    switch(indexReporte){
                        case 0:
                            if (entrada == 1)
                            {
                                ReporteMarca report = new ReporteMarca();

                                report.SetDatabaseLogon("cpseqcen", "cww85Sj43O", "cpseqcensos.org", "cpseq_censos");
                                reportViewer.ReportSource = report;
                            }
                            if (entrada == 2) { 
                                ReporteMarcaCenso report = new ReporteMarcaCenso();
                                //report.SetDataSource(Util.getData(query));
                               // report.Parameter_Año.CurrentValues.Insert(censo,censo);
                                //report.SetParameterValue(censo, report.Parameter_censo);
                                report.SetParameterValue("censo", censo);
                                reportViewer.ReportSource = report;
                            }
                            break;
                        case 1:
                            if (entrada == 1)
                            {
                                ReporteAuxiliares report = new ReporteAuxiliares();
                                query = "CALL consultaAuxiliares();";
                                reportViewer.ReportSource = report;
                            }
                            if (entrada == 2) {
                        
                                if (query.Contains("SiTiene"))
                                {
                                    ReporteAuxiliaresCenso report = new ReporteAuxiliaresCenso();
                                    report.SetParameterValue("censo", censo);
                                    report.SetDatabaseLogon("cpseqcen","cww85Sj43O","cpseqcensos.org","cpseq_censos");
                                    MessageBox.Show("entro");
                                    reportViewer.ReportSource = report;
                                }
                                else if (query.Contains("NoTiene"))
                                {
                                    ReporteNoAuxiliaresCenso report = new ReporteNoAuxiliaresCenso();
                                    report.SetParameterValue("censo", censo);
                                    reportViewer.ReportSource = report;
                                }
                                //report.SetDataSource(Util.getData(query));
                               // report.Parameter_Año.CurrentValues.Insert(censo,censo);
                                //report.SetParameterValue(censo, report.Parameter_censo);
                            }
                            break;
                        case 2:
                            if (entrada == 1)
                            {
                                ReporteCoclear report = new ReporteCoclear();
                                reportViewer.ReportSource = report;
                            }
                            if (entrada == 2)
                            {
                                ReporteCoclearCenso report = new ReporteCoclearCenso();
                                report.SetParameterValue("censo", censo);
                                reportViewer.ReportSource = report;
                            }
                            break;
                        default:
                            MessageBox.Show("Reporte no valido");
                            break;
                    }

                    break;
                case 1:
                    //MessageBox.Show(query + "-" + index + "-" + indexReporte + "-" + entrada);
                    switch (indexReporte)
                    {
                        case 0:
                            if (entrada == 1)
                            {
                                
                                ReporteAlergia report = new ReporteAlergia();
                                reportViewer.ReportSource = report;
                            }
                            if (entrada == 2)
                            {
                                ReporteAlergiaCenso report = new ReporteAlergiaCenso();
                                reportViewer.ReportSource = report;
                            }
                            break;
                        case 1:
                            if (entrada == 1)
                            {
                                ReporteEnfermedad report = new ReporteEnfermedad();
                                reportViewer.ReportSource = report;
                            }
                            if (entrada == 2)
                            {
                                ReporteEnfermedadCenso report = new ReporteEnfermedadCenso();
                                //report.SetDataSource(Util.getData(query));
                                // report.Parameter_Año.CurrentValues.Insert(censo,censo);
                                //report.SetParameterValue(censo, report.Parameter_censo);
                                report.SetParameterValue("censo", censo);
                                reportViewer.ReportSource = report;
                            }
                            break;
                        case 2:
                            break;
                        default:
                            MessageBox.Show("Reporte no valido");
                            break;
                    }

                break;
            }
        }
    }
}
