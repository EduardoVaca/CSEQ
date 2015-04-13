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
        //Recibe como parametro un entero para saber en que modo esta "Crear", "Editar" o "Eliminar"
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
            this.Close();
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
            if(valor_decision == 1)
            {                
                Persona crear = new Persona();
                this.Hide();
                crear.Show();
            }
            else if(valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Persona");
                this.Hide();
                editar.Show();
            }
            else if(valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Persona");
                this.Hide();
                eliminar.Show();
            }
        }

        private void colonia_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {
                CrearColonia crear = new CrearColonia();
                this.Hide();
                crear.Show();
            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Colonia");
                this.Hide();
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Colonia");
                this.Hide();
                eliminar.Show();
            }
        }

        private void delegacion_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {
                Crear_delegacion crear = new Crear_delegacion();
                this.Hide();
                crear.Show();

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
                CrearMunicipio crear = new CrearMunicipio();
                this.Hide();
                crear.Show();

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Municipio");
                this.Hide();
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Municipio");
                this.Hide();
                eliminar.Show();
            }
        }

        private void estado_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {
                CrearEstado crear = new CrearEstado();
                this.Hide();
                crear.Show();
            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Estado");
                this.Hide();
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Estado");
                this.Hide();
                eliminar.Show();
            }
        }

        private void institucionEducativa_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {
                Crear_InstitucionEducativa crear = new Crear_InstitucionEducativa();
                this.Hide();
                crear.Show();
            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("InstitucionEducativa");
                this.Hide();
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("InstitucionEducativa");
                this.Hide();
                eliminar.Show();
            }
        }

        private void censo_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {
                Crear_censo crear = new Crear_censo();
                this.Hide();
                crear.Show();
            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Censo");
                this.Hide();
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Censo");
                this.Hide();
                eliminar.Show();
            }
        }

        private void aparatoAuditivo_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {
                CrearAparatoAuditivo crear = new CrearAparatoAuditivo();
                this.Hide();
                crear.Show();

            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("AparatoAuditivo");
                this.Hide();
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("AparatoAuditivo");
                this.Hide();
                eliminar.Show();
            }
        }

        private void marca_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {
                Crear_marca crear = new Crear_marca();
                this.Hide();
                crear.Show();
            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Marca");
                this.Hide();
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Marca");
                this.Hide();
                eliminar.Show();
            }
        }

        private void causa_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {
                Crear_causa crear = new Crear_causa();
                this.Hide();
                crear.Show();
            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Causa");
                this.Hide();
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Causa");
                this.Hide();
                eliminar.Show();
            }
        }

        private void sueldo_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {
                Crear_sueldo crear = new Crear_sueldo();
                this.Hide();
                crear.Show();
            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Sueldo");
                this.Hide();
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Sueldo");
                this.Hide();
                eliminar.Show();
            }
        }

        private void areaTrabajo_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {
                crearAreaTrabajo crear = new crearAreaTrabajo();
                this.Hide();
                crear.Show();
            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("AreaTrabajo");
                this.Hide();
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("AreaTrabajo");
                this.Hide();
                eliminar.Show();
            }
        }

        private void usuario_btn_Click(object sender, EventArgs e)
        {
            if (valor_decision == 1)
            {
                CrearUsuario crear = new CrearUsuario();
                this.Hide();
                crear.Show();
            }
            else if (valor_decision == 2)
            {
                Editar_registro editar = new Editar_registro("Usuario");
                this.Hide();
                editar.Show();
            }
            else if (valor_decision == 3)
            {
                Eliminar_registro eliminar = new Eliminar_registro("Usuario");
                this.Hide();
                eliminar.Show();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



    }
}
