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
    public partial class ConsultaGrafica : Form
    {
        public ConsultaGrafica()
        {
            InitializeComponent();
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Atras_picture_Click(object sender, EventArgs e)
        {
            Menu_consultas menu = new Menu_consultas();
            menu.Show();
            this.Close();
        }

        private void btnLlenarBarras_Click(object sender, EventArgs e)
        {
            String query = "CALL consultaHombresMujeres";
            String type = "Barra";
            Util.graphData(zedGraph, query, type);
        }

        private void ConsultaGrafica_Load(object sender, EventArgs e)
        {

        }

        private void btnLlenarPay_Click(object sender, EventArgs e)
        {
            String query = "CALL consultaHombresMujeres";
            String type = "Pay";
            Util.graphData(zedPie, query, type);
        }

        private void ImprimirConsulta_btn_Click(object sender, EventArgs e)
        {
            /*Reporte Nuevo = new Reporte();
            Nuevo.Show();*/
        }
    }
}
