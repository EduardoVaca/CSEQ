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
        public enum Ventanas { Login, MenuPrincipal, MenuRegistros, MenuConsultas, EditarRegistro, ListaRegistros, EliminarRegistros };

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

                case Ventanas.MenuRegistros:
                    formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Menu_registros);
                    break;

                case Ventanas.MenuConsultas:
                    formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Menu_consultas);
                    break;

                case Ventanas.ListaRegistros:
                    formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Lista_registros);
                    break;

                case Ventanas.EliminarRegistros:
                    formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Eliminar_registro);
                    break;

                case Ventanas.EditarRegistro:
                    formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Editar_registro);
                    break;
            }

            if (formToShow != null)
            {
                formToShow.ShowDialog();
            }

        }

    }
}
