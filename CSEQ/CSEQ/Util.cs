using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias para hacer servicio cliente-servidor
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSEQ
{
    class Util
    {
        //Conexion que se utilizara para conectarse con la base
        static SqlConnection conexion;

        /*
        ----------------------------------------------------------------
        * Crea una conexion con el servidor pasando como parametro utilizando el nom
        * de usuario y password conectandose al catalogo pasado como parametro
        @param servidor    El servidor al que se va a conectar
        @param catalogo    El catalogo al que se va a conectar
        @param user        El nombre de usuario con el que te conectas
        @param pass        Password de usuario
        -----------------------------------------------------------------
        */
        public static void creaConexion(String servidor, String catalogo, String usuario, String password)
        {
            conexion = new SqlConnection();

            //Obtenemos el string con el datasource de .net
            String strConexion = @"Data Source=" + servidor + ";Initial Catalog="
                                + catalogo + ";Persist Security Info=True; User ID="
                                + usuario + ";Password=" + password;

            conexion.ConnectionString = strConexion;
        }

        /*
        -------------------------------------------------------------
        Muestra en pantalla una ventana de dialogo con el icono critico
        con el mensaje pasado como parametro
        @param msj para mostrar en la pantalla
        -------------------------------------------------------------
        */
        public static void mostrarMensajeError(String mensaje)
        {
            MessageBox.Show(mensaje, "Error de ejecucion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*
        ----------------------------------------------------------------------------------------------------
        Esta función utiliza la conexión abierta para realizar el query pasado como parámetro y regresa un  
        DataTable con los datos leídos                                                                      
	                                                                                                          
        @param  query  El query que se va a ejecutar en la base de datos                                    
        @return  Un DataTable con los datos leídos de la base de datos al ejecutar el query                 
        ---------------------------------------------------------------------------------------------------
        */
        public static DataTable getData(String consulta)
        {
            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable tabla = new DataTable();

            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                conexion.Close();

                if (tabla.Rows.Count > 0)
                    return tabla;
                else
                    return null;
            }
            catch (SqlException ex)
            {
                mostrarMensajeError("No se puede realizar la consulta <getData>" + Environment.NewLine +
                                    "Error: " + ex.Message);
                tabla = null;
                return tabla;
            }
            finally
            {
                conexion.Close();
            }
        }

        /*
          ----------------------------------------------------------------------------------------------------
        Llena el ComboBox pasado como parámetro con los datos que se recuperan del query pasado como parámetro.
        El ComboBox se va a llenar mediante su ValueMember y su DisplayMember con la primera y segunda columna 
        regresadas del query respectivamente.                                                                  
	                                                                                                            
        @param  lst    El ComboBox que se va a llenar con los datos del query                                 
        @param  query  El query que se quiere ejecutar en la base de datos. El query debe tener la forma      
                       SELECT INTEGER, $ FROM Tabla [...]                                                      
                       en donde $ es un dato de cualquier tipo.                                               
          -------------------------------------------------------------------------------------------------
          */
        public static void llenarComboBox(ComboBox box, String consulta)
        {
            try
            {
                DataTable tabla;
                tabla = getData(consulta);
                box.DataSource = null;
                box.Items.Clear();
                box.DataSource = tabla;

                if (tabla.Columns.Count == 2)
                {
                    box.ValueMember = tabla.Columns[0].ToString();
                    box.DisplayMember = tabla.Columns[1].ToString();
                }
                else
                {
                    box.DisplayMember = tabla.Columns[0].ToString();
                }
            }
            catch (Exception ex)
            {
                mostrarMensajeError("No se puede llenar el control - llenarComboBox<ComboBox>" + Environment.NewLine +
                                    "Error: " + ex.Message);
            }
        }


    }
}
