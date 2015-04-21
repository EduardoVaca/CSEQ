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
        Size newSize = new Size(120, 120);
        Size oldSize = new Size(100,100);
        int oldTop;
        int oldLeft;
        double originalFontSize = 13.875;
        int personaX = 130, personaY = 180;
        int coloniaX = 290, coloniaY = 180;
        //int coloniaX 
        
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
            Menu_principal Menu = new Menu_principal(rol);
            this.Close();
            Menu.Show();
        }

        private void Lista_registros_Load(object sender, EventArgs e)
        {
            if (rol == 1)
            {                
                usuario_lb.Visible = true;
                usuario_pb.Visible = true;
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

        private void persona_pb_MouseDown(object sender, MouseEventArgs e)
        {
            persona_press.Visible = true;
            persona_pb.Visible = false;
        }

        private void colonia_pb_MouseDown(object sender, MouseEventArgs e)
        {
            colonia_pb.Visible = false;
            colonia_press.Visible = true;
        }

        private void municipio_pb_MouseDown(object sender, MouseEventArgs e)
        {
            municipio_pb.Visible = false;
            municipio_press.Visible = true;
        }

        private void estado_pb_MouseDown(object sender, MouseEventArgs e)
        {
            estado_pb.Visible = false;
            estado_press.Visible = true;
        }

        private void censo_pb_MouseDown(object sender, MouseEventArgs e)
        {
            censo_pb.Visible = false;
            censo_press.Visible = true;
        }

        private void aparato_pb_MouseDown(object sender, MouseEventArgs e)
        {
            aparato_pb.Visible = false;
            aparato_press.Visible = true;
        }

        private void marca_pb_MouseDown(object sender, MouseEventArgs e)
        {
            marca_pb.Visible = false;
            marca_press.Visible = true;
        }

        private void causa_pb_MouseDown(object sender, MouseEventArgs e)
        {
            causa_pb.Visible = false;
            causa_press.Visible = true;
        }

        private void sueldo_pb_MouseDown(object sender, MouseEventArgs e)
        {
            sueldo_pb.Visible = false;
            sueldo_press.Visible = true;
        }

        private void areaTrabajo_pb_MouseDown(object sender, MouseEventArgs e)
        {
            areaTrabajo_pb.Visible = false;
            areaTrabajo_press.Visible = true;
        }

        private void usuario_pb_MouseDown(object sender, MouseEventArgs e)
        {
            usuario_pb.Visible = false;
            usuario_press.Visible = true;
        }


        private void persona_pb_MouseUp(object sender, MouseEventArgs e)
        {
            Form f = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Persona);
            if (f == null)
            {
                Persona crear = new Persona(rol);                
                crear.Show();
            }
            else
            {                
                Ventana.mostrarOculta(Ventana.Ventanas.Persona);
            }
            this.Hide();
            persona_pb.Visible = true;
            persona_press.Visible = false;
            
           
        }

        private void colonia_pb_MouseUp(object sender, MouseEventArgs e)
        {
            CrearColonia crear = new CrearColonia(rol);
            colonia_press.Visible = false;
            colonia_pb.Visible = true;
            this.Hide();
            crear.Show();
        }


        private void municipio_pb_MouseUp(object sender, MouseEventArgs e)
        {
            CrearMunicipio crear = new CrearMunicipio(rol);
            this.Hide();
            municipio_press.Visible = false;
            municipio_pb.Visible = true;
            crear.Show();
        }

        private void estado_pb_MouseUp(object sender, MouseEventArgs e)
        {
            CrearEstado crear = new CrearEstado(rol);
            this.Hide();
            estado_press.Visible = false;
            estado_pb.Visible = true;
            crear.Show();
        }

        private void institucion_pb_MouseDown(object sender, MouseEventArgs e)
        {
            institucion_pb.Visible = false;
            institucion_press.Visible = true;
        }

        private void institucion_pb_MouseUp(object sender, MouseEventArgs e)
        {
            Crear_InstitucionEducativa crear = new Crear_InstitucionEducativa(rol);
            this.Hide();
            institucion_press.Visible = false;
            institucion_pb.Visible = true;
            crear.Show();
        }

        private void censo_pb_MouseUp(object sender, MouseEventArgs e)
        {
            Crear_censo crear = new Crear_censo(rol);
            this.Hide();
            censo_press.Visible = false;
            censo_pb.Visible = true;
            crear.Show();
        }

        private void aparato_pb_MouseUp(object sender, MouseEventArgs e)
        {
            CrearAparatoAuditivo crear = new CrearAparatoAuditivo(rol);
            this.Hide();
            aparato_press.Visible = false;
            aparato_pb.Visible = true;
            crear.Show();
        }

        private void marca_pb_MouseUp(object sender, MouseEventArgs e)
        {
            Crear_marca crear = new Crear_marca(rol);
            this.Hide();
            marca_press.Visible = false;
            marca_pb.Visible = true;
            crear.Show();
        }

        private void causa_pb_MouseUp(object sender, MouseEventArgs e)
        {
            Crear_causa crear = new Crear_causa(rol);
            this.Hide();
            causa_press.Visible = false;
            causa_pb.Visible = true;
            crear.Show();
        }

        private void sueldo_pb_MouseUp(object sender, MouseEventArgs e)
        {
            Crear_sueldo crear = new Crear_sueldo(rol);
            this.Hide();
            sueldo_pb.Visible = true;
            sueldo_press.Visible = false;
            crear.Show();
        }

        private void areaTrabajo_pb_MouseUp(object sender, MouseEventArgs e)
        {
            crearAreaTrabajo crear = new crearAreaTrabajo(rol);
            this.Hide();
            areaTrabajo_press.Visible = false;
            areaTrabajo_pb.Visible = true;
            crear.Show();
        }

        private void usuario_pb_MouseUp(object sender, MouseEventArgs e)
        {
            CrearUsuario crear = new CrearUsuario();
            this.Hide();
            usuario_press.Visible = false;
            usuario_pb.Visible = true;
            crear.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Restart();
            }
        }

        /*Metodos que hacen mas visual la interaccion, Las imagenes crecen cuando se pasa el mouse sobre ellas*/
        private void maximizarIcono(PictureBox picture, Label label, PictureBox picturePressed)
        {
            //oldSize = picture.Size;
            picture.Top -= 10;
            picture.Left -= 10;
            picture.Size = newSize;
            label.Font = new System.Drawing.Font(label.Font.FontFamily, label.Font.Size + 2);
            label.Location = new Point(label.Location.X - 10, label.Location.Y + 5);
            picturePressed.Top = picture.Top;
            picturePressed.Left = picture.Left;
            picturePressed.Size = newSize;
        }

        private void minimizarIcono(PictureBox picture, Label label, int posX, int posY, int oldTop, int oldLeft)
        {
            picture.Top = oldTop;
            picture.Left = oldLeft;
            picture.Size = oldSize;
            label.Font = new System.Drawing.Font(label.Font.FontFamily, (float)originalFontSize);
            label.Location = new Point(posX, posY);
        }
        /*Fin de metodos de interaccion visual*/

        private void persona_pb_MouseHover(object sender, EventArgs e)
        {
           // MessageBox.Show("X: " + persona_lb.Location.X + "Y: " + persona_lb.Location.Y);
            maximizarIcono(persona_pb, persona_lb, persona_press);
            //MessageBox.Show(persona_pb.Top + " " + persona_pb.Left);
        }

        private void persona_pb_MouseLeave(object sender, EventArgs e)
        {
            minimizarIcono(persona_pb, persona_lb, personaX, personaY, 74, 116);
        }

        private void colonia_pb_MouseHover(object sender, EventArgs e)
        {
         //   MessageBox.Show("X: " + colonia_lb.Location.X + "Y: " + colonia_lb.Location.Y);
            maximizarIcono(colonia_pb, colonia_lb, colonia_press);
            //MessageBox.Show(colonia_pb.Top + " " + colonia_pb.Left);
        }

        private void colonia_pb_MouseLeave(object sender, EventArgs e)
        {
            minimizarIcono(colonia_pb, colonia_lb, coloniaX, personaY, 74, 273);
        }






    }
}
