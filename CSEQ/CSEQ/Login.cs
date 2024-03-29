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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas salir de la aplicación?", "Mensaje de Confirmación", MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void RBAC()
        {
            String login = login_txt.Text;
            String password = password_txt.Text;
            DataTable tabla = new DataTable();

            tabla = Util.getData("CALL validacionLogin('" + login + "','" + password + "');");

            if (tabla != null)
            {                
                int rol = Int16.Parse(tabla.Rows[0][0].ToString());
                if (rol == 1 || rol == 2)
                {                    
                    Menu_principal Menu_principal = new Menu_principal(rol);                    
                    Menu_principal.Show();
                    this.Hide();                    
                }
                else
                {
                    MessageBox.Show("Error en el usuario, vuelva a intentarlo");
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválidos, vuelva a intentarlo");
            }         
        }

        //Modelo RBAC
        private void ingresar_btn_Click(object sender, EventArgs e)
        {
            RBAC();                                  
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Util.creaConexion("localhost", "CSEQ", "root", "");
            Util.creaConexion("cpseqcenso.org", "cpseqcen_censos", "cpseqcen_Admin", "ajaksordos%25");
            salir_tt.SetToolTip(x_picture, "Salir de la aplicación");            
            Util.clear(this);
        }

        private void password_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                RBAC();
            }
        }
        private void password_txt_Enter(object sender, EventArgs e)
        {
            String loginInput = login_txt.Text;
            DataTable tabla = new DataTable();

            tabla = Util.getData("CALL validacionNombreLogin('" + loginInput + "');");
            if (tabla == null)
            {
                mensaje.Text = "El usuario '" + loginInput + "' no existe...";
            }
            else
            {
                mensaje.Text = "";
            }
        }       
    }
}
