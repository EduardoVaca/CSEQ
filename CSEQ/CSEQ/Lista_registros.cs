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
    public partial class Lista_registros : Form
    {
        private int rol;
        //Recibe como parametro un entero para saber en que modo esta "Crear", "Editar" o "Eliminar"
        public Lista_registros(int rol)
        {
            this.rol = rol;
            InitializeComponent();
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            Menu_registros Menu_registros = new Menu_registros();
            this.Close();
            Menu_registros.Show();
        }

        private void Lista_registros_Load(object sender, EventArgs e)
        {
            if (rol == 1)
            {
                usuario_btn.Visible = true;
                usuario_lb.Visible = true;
            }
        }

        /*************************************************************************
         * Se crean diferentes formas dependiendo de lo que se quiere crear
         * Si esta en modo de EDITAR, manda como parametro el nombre de la tabla a la que
         * quiere crear
         * Si esta en modo ELIMINAR pasa lo mismo
         * En crear no manda parametros
         * ***********************************************************************
         */ 
        private void persona_btn_Click(object sender, EventArgs e)
        {             
            Persona crear = new Persona(rol);
            this.Hide();
            crear.Show();
        }

        private void colonia_btn_Click(object sender, EventArgs e)
        {
            CrearColonia crear = new CrearColonia(rol);
            this.Hide();
            crear.Show();            
        }

        private void delegacion_btn_Click(object sender, EventArgs e)
        {
            Crear_delegacion crear = new Crear_delegacion(rol);
            this.Hide();
            crear.Show();
        }

        private void municipio_btn_Click(object sender, EventArgs e)
        {
            CrearMunicipio crear = new CrearMunicipio(rol);
            this.Hide();
            crear.Show();
        }

        private void estado_btn_Click(object sender, EventArgs e)
        {
            CrearEstado crear = new CrearEstado(rol);
            this.Hide();
            crear.Show();
        }

        private void institucionEducativa_btn_Click(object sender, EventArgs e)
        {
            Crear_InstitucionEducativa crear = new Crear_InstitucionEducativa(rol);
            this.Hide();
            crear.Show();
        }

        private void censo_btn_Click(object sender, EventArgs e)
        {
            Crear_censo crear = new Crear_censo(rol);
            this.Hide();
            crear.Show();
        }

        private void aparatoAuditivo_btn_Click(object sender, EventArgs e)
        {
            CrearAparatoAuditivo crear = new CrearAparatoAuditivo(rol);
            this.Hide();
            crear.Show();
        }

        private void marca_btn_Click(object sender, EventArgs e)
        {
            Crear_marca crear = new Crear_marca(rol);
            this.Hide();
            crear.Show();
        }

        private void causa_btn_Click(object sender, EventArgs e)
        {
            Crear_causa crear = new Crear_causa(rol);
            this.Hide();
            crear.Show();
        }

        private void sueldo_btn_Click(object sender, EventArgs e)
        {
            Crear_sueldo crear = new Crear_sueldo(rol);
            this.Hide();
            crear.Show();
        }

        private void areaTrabajo_btn_Click(object sender, EventArgs e)
        {
            crearAreaTrabajo crear = new crearAreaTrabajo(rol);
            this.Hide();
            crear.Show();
        }

        private void usuario_btn_Click(object sender, EventArgs e)
        {
            CrearUsuario crear = new CrearUsuario();
            this.Hide();
            crear.Show();
        }



    }
}
