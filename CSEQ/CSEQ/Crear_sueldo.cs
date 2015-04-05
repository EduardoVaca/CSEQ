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
    public partial class Crear_sueldo : Form
    {
        public Crear_sueldo()
        {
            InitializeComponent();            

        }

        private void close_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void atras_picture_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            String sMinimo = sueldoMinimo_txt.Text;
            String sMaximo = sueldoMaximo_txt.Text;

            if (Util.executeStoredProcedure("registrarSueldo", sMinimo, sMaximo))
            {
                MessageBox.Show("El Sueldo se ha registrado con exito!");
            }
        }

    }
}
