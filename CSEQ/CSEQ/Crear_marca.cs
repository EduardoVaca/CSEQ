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
    public partial class Crear_marca : Form
    {
        public Crear_marca()
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

        //Metodo donde se agrega el registro a la base de datos
        private void guardar_btn_Click(object sender, EventArgs e)
        {
            String dml;
            String mNombre = nombre_txt.Text;

            dml = "INSERT INTO Marca VALUES('" + mNombre + "')";
            if (Util.execute(dml))
            {
                MessageBox.Show("La Marca se ha registrado con exito!");
            }
        }
    }
}
