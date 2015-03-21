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
    public partial class Lista_registros : Form
    {
        private int valor_decision;

        public Lista_registros(int valor_decision)
        {
            this.valor_decision = valor_decision;
            InitializeComponent();
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            Menu_registros Menu_registros = new Menu_registros();
            Menu_registros.Show();
        }

        private void Lista_registros_Load(object sender, EventArgs e)
        {
            if (valor_decision == 1)
                titulo.Text = "Crear Registro";
            else if (valor_decision == 2)
                titulo.Text = "Editar Registro";
            else if (valor_decision == 3)
                titulo.Text = "Eliminar Registro";
        }

        private void persona_btn_Click(object sender, EventArgs e)
        {
            if(valor_decision == 1)
            {
                
            }
            else if(valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Persona");
                editar.Show();
            }
            else if(valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Persona");
                eliminar.Show();
            }
        }

        private void colonia_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Colonia");
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Colonia");
                eliminar.Show();
            }
        }

        private void delegacion_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Delegacion");
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Delegacion");
                eliminar.Show();
            }
        }

        private void municipio_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Municipio");
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Municipio");
                eliminar.Show();
            }
        }

        private void estado_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Estado");
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Estado");
                eliminar.Show();
            }
        }

        private void institucionEducativa_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("InstitucionEducativa");
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("InstitucionEducativa");
                eliminar.Show();
            }
        }

        private void censo_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Censo");
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Censo");
                eliminar.Show();
            }
        }

        private void aparatoAuditivo_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("AparatoAuditivo");
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("AparatoAuditivo");
                eliminar.Show();
            }
        }

        private void marca_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Marca");
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Marca");
                eliminar.Show();
            }
        }

        private void causa_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Causa");
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Causa");
                eliminar.Show();
            }
        }

        private void sueldo_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Sueldo");
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Sueldo");
                eliminar.Show();
            }
        }

        private void areaTrabajo_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("AreaTrabajo");
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("AreaTrabajo");
                eliminar.Show();
            }
        }

        private void usuario_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Usuario");
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Usuario");
                eliminar.Show();
            }
        }



    }
}
