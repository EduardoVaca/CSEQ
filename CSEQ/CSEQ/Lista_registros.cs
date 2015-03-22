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
            this.Hide();
            Menu_registros Menu_registros = new Menu_registros();
            Menu_registros.ShowDialog();
            this.Close();
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
                this.Hide();
                editar.ShowDialog();
            }
            else if(valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Persona");
                this.Hide();
                eliminar.ShowDialog();
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
                this.Hide();
                editar.ShowDialog();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Colonia");
                this.Hide();
                eliminar.ShowDialog();
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
                this.Hide();
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Delegacion");
                this.Hide();
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
                this.Hide();
                editar.ShowDialog();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Municipio");
                this.Hide();
                eliminar.ShowDialog();
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
                this.Hide();
                editar.ShowDialog();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Estado");
                this.Hide();
                eliminar.ShowDialog();
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
                this.Hide();
                editar.ShowDialog();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("InstitucionEducativa");
                this.Hide();
                eliminar.ShowDialog();
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
                this.Hide();
                editar.ShowDialog();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Censo");
                this.Hide();
                eliminar.ShowDialog();
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
                this.Hide();
                editar.ShowDialog();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("AparatoAuditivo");
                this.Hide();
                eliminar.ShowDialog();
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
                this.Hide();
                editar.ShowDialog();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Marca");
                this.Hide();
                eliminar.ShowDialog();
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
                this.Hide();
                editar.ShowDialog();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Causa");
                this.Hide();
                eliminar.ShowDialog();
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
                this.Hide();
                editar.ShowDialog();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Sueldo");
                this.Hide();
                eliminar.ShowDialog();
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
                this.Hide();
                editar.ShowDialog();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("AreaTrabajo");
                this.Hide();
                eliminar.ShowDialog();
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
                this.Hide();
                editar.ShowDialog();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Usuario");
                this.Hide();
                eliminar.ShowDialog();
            }
        }



    }
}
