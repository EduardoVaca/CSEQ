using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias para hacer servicio cliente-servidor
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSEQ
{
    
    class Util
    {
        
        //Conexion que se utilizara para conectarse con la base
        static MySqlConnection conexion;

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
        public static void creaConexion(String servidor, String nombreBaseDatos, String usuario, String password)
        {
            conexion = new MySqlConnection();

            //Obtenemos el string con el datasource de .net
            String strConexion = "Server=" + servidor + ";Database=" + nombreBaseDatos +
                                ";Uid=" + usuario + ";Pwd=" + password + ";";

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
            MySqlCommand comando = new MySqlCommand();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
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
            catch (MySqlException ex)
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

        /*------------------------------------------------------------------------------
         * Esta funcion permite ejecutar Estatutos DML (Insert, delete, update)
         @ param DML Sentencia DML que se ejecutara en la cbase de datos
         @ return TRUE si se ejecuto con exito, FALSE si ocurrio algun error
         --------------------------------------------------------------------------------*/

        public static bool execute(String DML)
        {
            MySqlCommand command = new MySqlCommand(DML, conexion);

            try
            {
                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                String err;
                err = "Error de base de datos al ejecutar el comando" +
                        Environment.NewLine + ex.Message;
                mostrarMensajeError(err);
                return false;
            }
            catch (Exception ex)
            {
                String err;
                err = "Error al ejecutar comando"
                        + Environment.NewLine + ex.Message;
                mostrarMensajeError(err);
                return false;
            }
            finally
            {
                try
                {
                    conexion.Close();
                }
                catch { }
            }
        }

        /*----------------------------------------------------------------------
        * Cambia el formato del objeto pasado como parámetro a un formato que entiende MySQL Server               
         @param  param  El objeto que se quiere convertir a formato de MySQL Server                               
         @return  Un String que representa al objeto con un formato comprensible por SQL Server 
        -----------------------------------------------------------------------*/
        public static String MySQLFormat(Object param)
        {
            //En caso de ser alfanumerico
            if (param is String)
            {
                String sParam;
                sParam = param.ToString();
                return ("'" + sParam.Replace("'", "\'") + "'");
            }
            else if (param is DateTime)
            {
                return "'" + ((DateTime)param).ToString("d/MM/yyyy HH:mm:ss") + "'";
            }
            else if (param == null)
            {
                return "null";
            }
            else
            {
                try
                {
                    return param.ToString();
                }
                catch (Exception ex)
                {
                    String error;
                    error = "Error al ejecutar " + Environment.NewLine + ex.Message;
                    mostrarMensajeError(error);
                    return "null";
                }
            }

        }
    /*------------------------------------------------------------------------------------
    Ejecuta un stored procedure de nombre name y pasa los parámetros mandados en el arreglo 
       parameters                                                              
    @param  name        El nombre del stored procedure que se desea ejecutar                               
    @param  parameters  Un arreglo de Objects que se van a pasar como parámetros del stored procedure  
    --------------------------------------------------------------------------------------------'*/
        public static bool executeStoredProcedure(String nombre, params Object[] parametros)
        {
            String comando;
            comando = "CALL " + nombre + " (";
            int size = parametros.Length;
            int contador_parametros = 0;
            foreach (Object param in parametros)
            {
                if(contador_parametros + 1 == size)
                    comando += MySQLFormat(param);
                else
                    comando += MySQLFormat(param) + ", ";
                contador_parametros++;
            }            
            comando += ");";                
            return execute(comando);
        }


        public static String consultaStoredProcedure(String nombre, params Object[] parametros)
        {
            String comando;
            comando = "CALL " + nombre + " (";
            int size = parametros.Length;
            int contador_parametros = 0;
            foreach (Object param in parametros)
            {
                if (contador_parametros + 1 == size)
                    comando += MySQLFormat(param);
                else
                    comando += MySQLFormat(param) + ", ";
                contador_parametros++;
            }
            comando += ");";
            return comando;
        }

        /**
         * ---------------------------------------------------------------------------------------------------------'
             Llena el DataGrid pasado como parámetro con los datos que se recuperan del query pasado como           '
             parámetro.                                                                                             '
                                                                                                                    '
             @param  grid   El DataGrid que se va a llenar con los datos del query                                  '
             @param  query  El query que se quiere ejecutar en la base de datos.                                    '
           --------------------------------------------------------------------------------------------------------'
   
         * */

        public static void fillGrid(DataGridView grid, String nombre, params Object[] parametros)
        {
            DataTable table;
            String query = consultaStoredProcedure(nombre, parametros);
            table = getData(query);
           // MessageBox.Show(query);
            if (table != null)
                grid.DataSource = table;
        }



        public static void showData(Form form, String query)
        {
            DataTable table;
            table = getData(query);

            if (table != null)
            {
                foreach (Control ctrl in form.Controls)
                {
                    String nombreTemporal;
                    // Si existe un campo asociado al nombre del control
                    if(ctrl is TextBox)
                        nombreTemporal = ctrl.Name.Remove(ctrl.Name.Length - 4);
                    else if (ctrl is CheckBox)
                        nombreTemporal = ctrl.Name.Remove(ctrl.Name.Length - 6);
                    else
                        nombreTemporal = ctrl.Name;

                    if (table.Columns.Contains(nombreTemporal))
                    {
                        if (ctrl is TextBox || ctrl is MaskedTextBox)
                            ctrl.Text = table.Rows[0][nombreTemporal].ToString();
                        else if (ctrl is ComboBox || ctrl is ListBox)
                            ((ComboBox)ctrl).SelectedValue = table.Rows[0][nombreTemporal].ToString();
                        else if (ctrl is DateTimePicker)
                            ((DateTimePicker)ctrl).Value = (DateTime)(table.Rows[0][nombreTemporal]);
                        else if (ctrl is CheckBox)
                            ((CheckBox)ctrl).Checked = (bool)(table.Rows[0][nombreTemporal]);
                        else
                            try
                            {
                                ctrl.Text = table.Rows[0][nombreTemporal].ToString();
                            }
                            catch (Exception ex)
                            {

                            }
                    }
                }
            }
        }


    }
}
