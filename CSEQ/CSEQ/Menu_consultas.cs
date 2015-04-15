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
    public partial class Menu_consultas : Form
    {
        public Menu_consultas()
        {
            InitializeComponent();

        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_picture_Click(object sender, EventArgs e)
        {            
            Menu_principal Menu_principal = new Menu_principal(1);
            Menu_principal.Show();
            this.Close();
        }

        private void ConsultaGrafica_btn_Click(object sender, EventArgs e)
        {
            ConsultaGrafica consulta = new ConsultaGrafica();
            this.Close();
            consulta.Show();
            
        }

        private void ConsultaRedactada_btn_Click(object sender, EventArgs e)
        {
            ConsultaRedactada consulta = new ConsultaRedactada();
            this.Close();
            consulta.Show();
            
        }

        private void salud_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            salud_combo.Enabled = true;
            empleo_combo.Enabled = false;
            demografia_combo.Enabled = false;
            educacion_combo.Enabled = false;           
        }

        private void demografia_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            salud_combo.Enabled = false;
            empleo_combo.Enabled = false;
            demografia_combo.Enabled = true;
            educacion_combo.Enabled = false;  
        }

        private void educacion_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            salud_combo.Enabled = false;
            empleo_combo.Enabled = false;
            demografia_combo.Enabled = false;
            educacion_combo.Enabled = true;  
        }

        private void empleo_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            salud_combo.Enabled = false;
            empleo_combo.Enabled = true;
            demografia_combo.Enabled = false;
            educacion_combo.Enabled = false;  
        }

        private void salud_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = salud_combo.SelectedIndex;
            consultas_salud salud = new consultas_salud(index);
            salud.Show();
            this.Close();
        }
    }
}
