using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSEQ
{
    static class Ventana
    {
        public enum Ventanas { Login, MenuPrincipal, MenuRegistros, MenuConsultas, EditarRegistro, ListaRegistros, EliminarRegistros, Persona};

        static public void mostrarOculta(Ventanas ventana)
        {
            Form formToShow = null;

            switch (ventana)
            {
                case Ventanas.Login:
                    formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Login);
                    break;

                case Ventanas.MenuPrincipal:
                    formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Menu_principal);
                    break;

                case Ventanas.MenuConsultas:
                    formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Menu_consultas);
                    break;

                case Ventanas.ListaRegistros:
                    formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Lista_registros);
                    break;

                case Ventanas.Persona: 
                    formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Persona);
                    break;
            }

            if (formToShow != null)
            {                
                formToShow.Visible = false;
                formToShow.Show();
            }

        }

    }
}
