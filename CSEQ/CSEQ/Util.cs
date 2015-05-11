using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias para hacer servicio cliente-servidor
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//Librerias zedgraph
using ZedGraph;
using System.Drawing;
//Librerias itextsharp
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
 


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

            conexion.ConnectionString = strConexion + "Allow Zero Datetime=True";
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

                if (tabla.Columns.Count >= 2)
                {
                    box.ValueMember = tabla.Columns[0].ToString();
                    box.DisplayMember = tabla.Columns[1].ToString();
                }
                else
                {
                    box.DisplayMember = tabla.Columns[0].ToString();
                    box.ValueMember = tabla.Columns[0].ToString();
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
            if (param.Equals(0))
                return "null";
            //En caso de ser alfanumerico
            if (param is String)
            {
                if (param.Equals("null"))
                {
                    return "null";
                }
                String sParam;
                sParam = param.ToString();
                return ("'" + sParam.Replace("'", "\'") + "'");
            }
            else if (param is DateTime)
            {
                return "'" + ((DateTime)param).ToString("yyyy-MM-dd HH:mm:ss") + "'";
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
            //MessageBox.Show(comando); 
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
            else
                grid.Visible = false;
        }

        public static void fillGridAviso(DataGridView grid, String nombre, System.Windows.Forms.Label lb, params Object[] parametros)
        {
            lb.Visible = true;
            DataTable table;
            String query = consultaStoredProcedure(nombre, parametros);
            table = getData(query);
            // MessageBox.Show(query);
            if (table != null)
                grid.DataSource = table;
            //lb.Visible = false;
        }



        public static void showData(Control form, String query)
        {
            DataTable table;
            table = getData(query);

            if (table != null)
            {
                foreach (Control ctrl in form.Controls)
                {
                    String nombreTemporal;
                    // Si existe un campo asociado al nombre del control
                    if (ctrl is TextBox || ctrl is MaskedTextBox)
                        nombreTemporal = ctrl.Name.Remove(ctrl.Name.Length - 4);
                    else if (ctrl is CheckBox)
                        nombreTemporal = ctrl.Name.Remove(ctrl.Name.Length - 6);
                    else
                        nombreTemporal = ctrl.Name;

                    if (ctrl is TabControl || ctrl is TabPage)
                    {
                        showDataTabs(table, ctrl);
                    }


                    if (table.Columns.Contains(nombreTemporal))
                    {
                        if (ctrl is TextBox || ctrl is MaskedTextBox)
                            ctrl.Text = table.Rows[0][nombreTemporal].ToString();
                        else if (ctrl is ComboBox || ctrl is ListBox)
                            ((ComboBox)ctrl).SelectedValue = table.Rows[0][nombreTemporal].ToString();
                        else if (ctrl is DateTimePicker){
                            String fecha = formatoFechaVS(table.Rows[0][nombreTemporal].ToString());
                            MessageBox.Show(fecha.ToString());
                            ((DateTimePicker)ctrl).Value = Convert.ToDateTime(fecha);
                        }                            
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


        public static void showDataTabs(DataTable table,Control form)
        {
            foreach (Control ctrl in form.Controls)
            {
                String nombreTemporal;
                // Si existe un campo asociado al nombre del control
                if (ctrl is TextBox || ctrl is MaskedTextBox)
                    nombreTemporal = ctrl.Name.Remove(ctrl.Name.Length - 4);
                else if (ctrl is CheckBox)
                {
                    nombreTemporal = ctrl.Name.Remove(ctrl.Name.Length - 6);
                       
                    if (ctrl.Name=="masculino_check" || ctrl.Name=="femenino_check")
                    {
                        nombreTemporal = "sexo_masculino";
                    }

                }
                else
                    nombreTemporal = ctrl.Name;

                if (ctrl is TabPage)
                {
                    showDataTabs(table, ctrl);

                }

                if (table.Columns.Contains(nombreTemporal))
                {
                    if (ctrl is TextBox || ctrl is MaskedTextBox)
                        ctrl.Text = table.Rows[0][nombreTemporal].ToString();
                    else if (ctrl is ComboBox || ctrl is ListBox)
                    {
                        //MessageBox.Show(ctrl.Name);
                        ((ComboBox)ctrl).SelectedValue = table.Rows[0][nombreTemporal].ToString();
                    }
                    else if (ctrl is DateTimePicker){
                        String fecha = formatoFechaVS(table.Rows[0][nombreTemporal].ToString());                        
                       ((DateTimePicker)ctrl).Value = Convert.ToDateTime(fecha);
                    }                        
                    else if (ctrl is CheckBox)
                    {
                        if (nombreTemporal == "sexo_masculino")
                        {
                            if (ctrl.Name == "masculino_check")
                                ((CheckBox)ctrl).Checked = (bool)(table.Rows[0][nombreTemporal]);
                            else
                                ((CheckBox)ctrl).Checked = !(bool)(table.Rows[0][nombreTemporal]);
                        }
                        else
                            ((CheckBox)ctrl).Checked = (bool)(table.Rows[0][nombreTemporal]);
                    }
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

        public static void clear(Control f)
        {
            foreach (Control ctrl in f.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
                if (ctrl is ComboBox || ctrl is ListBox)
                    ((ComboBox)ctrl).SelectedValue = -1;
                if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Checked = false;
                if (ctrl.HasChildren)
                    clear(ctrl);

            }
        }

        /**
    '---------------------------------------------------------------------------------------------------------'
    '  Grafica los puntos que se obtienen de ejecutar el query pasado como parámetro. El query debe tener la  '
	'  forma "SELECT ejeX, ejeY FROM..." donde ejeX puede ser cualquier tipo que sea convertible a String y   '
	'  ejeY tiene que ser numérico.                                                                           '
    '                                                                                                         '
    '  @param  zgc    El ZedGraphControl que se va a utilizar para graficar                                   '
    '  @param  query  El query que se quiere ejecutar en la base de datos. El query debe tener la forma       '
    '                 SELECT $, INTEGER FROM Tabla [...]                                                      ' 
    '                 en donde $ es un dato de cualquier tipo que se pueda convertir a String.                '
    '---------------------------------------------------------------------------------------------------------'
    */

        public static void graphData(ZedGraphControl zgc, String query,String tipo)
        {
            
            ZedGraph.PointPairList list = new PointPairList();

            Color[] colores = {Color.AliceBlue, Color.AntiqueWhite, Color.Aqua,
                            Color.Aquamarine, Color.Azure, Color.Beige,
                            Color.Bisque, Color.BlanchedAlmond, Color.Blue,
                            Color.BlueViolet, Color.BurlyWood, Color.Chartreuse,
                            Color.Coral, Color.Cornsilk, Color.Crimson,
                            Color.Cyan, Color.Firebrick, Color.FloralWhite,
                            Color.ForestGreen, Color.Gainsboro, Color.Gold,
                            Color.Green, Color.Honeydew, Color.IndianRed,
                            Color.Lavender, Color.LemonChiffon, Color.LightBlue,
                            Color.LightGreen, Color.LightCoral};

            DataTable dt;
            ZedGraph.GraphPane graph;
            zgc.GraphPane.CurveList.Clear();
            zgc.GraphPane.GraphObjList.Clear();
            graph = zgc.GraphPane;
            graph.Chart.Fill = new Fill(Color.White);
            graph.Fill = new Fill(Color.White);
            dt = getData(query);

            if (dt != null && tipo=="Barra")
            {
                graph.Title.Text = dt.TableName;
                graph.XAxis.Title.Text = dt.Columns[0].ColumnName;
                graph.XAxis.Title.FontSpec.Size = 15.0f;
                graph.YAxis.Title.Text = dt.Columns[1].ColumnName;
                graph.YAxis.Title.FontSpec.Size = 15.0f;
                String[] nombres = new String[dt.Rows.Count];
                // Obtenemos los encabezados de las columnas
                for (int i = 0; i < dt.Rows.Count; i++)
                    nombres[i] = dt.Rows[i].ItemArray[0].ToString();
                // Configuramos la gráfica
                graph.XAxis.MajorTic.IsBetweenLabels = true;
                graph.XAxis.Type = AxisType.Text;
                graph.XAxis.Scale.TextLabels = nombres;
                graph.XAxis.Scale.FontSpec.Size = 15.0F;
                graph.XAxis.Scale.FontSpec.Angle = 90;
                graph.YAxis.IsVisible = true;
                graph.XAxis.IsVisible = true;
                // Llenamos la grafica
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    double x = i + 1;
                    double y = Double.Parse(dt.Rows[i].ItemArray[1].ToString());
                    double z = i / 4.0;
                    //Labels de numero
                    TextObj barLabel = new TextObj(dt.Rows[i].ItemArray[1].ToString(),x,y+.5);
                    barLabel.FontSpec.Border.IsVisible = false;
                    barLabel.FontSpec.Fill.IsVisible = false;
                    list.Add(x, y, z);
                    graph.GraphObjList.Add(barLabel);
                }
                BarItem bar = graph.AddBar("Cantidad", list, Color.Blue);
                bar.Bar.Fill = new Fill(Color.Aqua);
                bar.Bar.Fill.Type = FillType.Brush;
                bar.Bar.Fill.RangeMin = 0;
                bar.Bar.Fill.RangeMax = 6;

                zgc.AxisChange();
                zgc.Refresh();
            }


            if (dt != null && tipo=="Pay")
            {
                zgc.GraphPane.GraphObjList.Clear();
                graph.Title.Text = dt.TableName;
                graph.XAxis.Title.Text = dt.Columns[0].ColumnName;
                graph.YAxis.Title.Text = " " ;
                String[] nombres = new String[dt.Rows.Count];
                double[] valores = new double[dt.Rows.Count];
                // Obtenemos los encabezados de las columnas
                for (int i = 0; i < dt.Rows.Count; i++)
                    nombres[i] = "-";
                // Configuramos la gráfica
                graph.XAxis.MajorTic.IsBetweenLabels = true;
                graph.XAxis.Type = AxisType.Text;
                graph.XAxis.Scale.TextLabels = nombres;
                graph.XAxis.Scale.FontSpec.Size = 10.0F;
                graph.XAxis.Scale.FontSpec.Angle = 90;
                graph.YAxis.IsVisible = false;
                // Llenamos la grafica
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    double x = i + 1;
                    double y = Double.Parse(dt.Rows[i].ItemArray[1].ToString());
                    PieItem pay = graph.AddPieSlice(y,colores[i],0F,dt.Rows[i].ItemArray[1].ToString());
                }

            }
            zgc.GetImage().Save("Grafica.png");
            zgc.Refresh();
        }

        //Metodo para agrandar la imagen de "Atras" cada vez que el mouse este sobre ella
        public static void agrandarIconoAtras(PictureBox pb)
        {
            pb.Top -= 3;
            pb.Left -= 3;
            pb.Size = new Size(40, 39);
        }

        //Metodo para minimizar la imagen de "Atras" cuando el mouse este sobre ella
        public static void minimizarIconoAtras(PictureBox pb)
        {
            pb.Top = 7;
            pb.Left = 6;
            pb.Size = new Size(33, 32);
        }

        /****************************************************************************
         * Metodo que agranda el tamaño del icono una vez que el mouse este sobre el
         * ParamterosÑ
         * @PictureBox
         * @Nuevo tamano
         * @retroseso en entero
         * **************************************************************************/
        public static void maximizarCualquierIcono(PictureBox pb, Size newSize, int retroseso)
        {
            pb.Top -= retroseso;
            pb.Left -= retroseso;
            pb.Size = newSize;
        }

        /****************************************************************************
         * Metodo que minimiza el tamaño del icono una vez que el mouse este sobre el
         * ParamterosÑ
         * @PictureBox
         * @Viejo tamano
         * @retroseso en entero -> Debe ser el mismo que el metodo maximizarCualquierIcono
         * **************************************************************************/
        public static void minimizarCualquierIcono(PictureBox pb, Size oldSize, int oldTop, int oldLeft)
        {
            pb.Top = oldTop;
            pb.Left = oldLeft;
            pb.Size = oldSize;
        }


        public static void generaPDF(String query,String textoTitulo,String periodo)
        {
            //Creacion del filestream
            FileStream salida;
            try
            {
                 salida = new FileStream("Reporte.pdf", FileMode.Create, FileAccess.ReadWrite, FileShare.Read); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Archivo abierto \n Cierre el reporte anterior para crear uno nuevo","Aceptar",MessageBoxButtons.OK);
                return;
            }
            //Caracteristicas del pds
            Document doc = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
            //Llamada al escritor de pdf
            PdfWriter writer = PdfWriter.GetInstance(doc, salida);
            //Creacion de datatable para llenar el reporte
            DataTable dt;
            doc.Open();
            dt = getData(query);
            String[] nombres = new String[dt.Rows.Count];
            //Tablas
            PdfPTable tabla = new PdfPTable(dt.Columns.Count);
            // Obtenemos los encabezados de las columnas
            List listaItems = new List(List.ALPHABETICAL);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                PdfPCell celda = new PdfPCell(new Phrase(dt.Columns[i].ToString()));
                celda.HorizontalAlignment = 1;
                tabla.AddCell(celda);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PdfPCell celda = new PdfPCell(new Phrase(dt.Rows[i].ItemArray[0].ToString()));
                celda.HorizontalAlignment = 1;
                tabla.AddCell(celda);
                for (int a = 1; a < dt.Columns.Count; a++)
                {
                    PdfPCell celdaNums = new PdfPCell(new Phrase(dt.Rows[i].ItemArray[a].ToString()));
                    celdaNums.HorizontalAlignment = 1;
                    tabla.AddCell(celdaNums);
                }
            }
            //Grafica del reporte
            iTextSharp.text.Image imgLogo = iTextSharp.text.Image.GetInstance("Resources/Logo.jpg");
            imgLogo.ScalePercent(10);
            imgLogo.SetAbsolutePosition(50,doc.PageSize.Height - 200);
            iTextSharp.text.Image imgGrafica = iTextSharp.text.Image.GetInstance("Grafica.png");
            imgGrafica.Alignment = (int)(HorizontalAlignment.Center-(int)imgGrafica.Width);
            imgGrafica.ScalePercent(60);
            Paragraph titulo = new Paragraph("Censo de Población y Desarrollo Integral para Personas con Discapacidad Auditiva \n\n");
            titulo.Alignment = 1;
            titulo.Font.Size= 10f;
            doc.Add(titulo);

            PdfContentByte Ob= writer.DirectContent;
            Ob.MoveTo(0, doc.PageSize.Height-60);
            Ob.LineTo(doc.PageSize.Width, doc.PageSize.Height-60);
            Ob.Stroke();
            Ob.SetColorStroke(BaseColor.RED);
            Ob.MoveTo(0, doc.PageSize.Height - 215);
            Ob.LineTo(doc.PageSize.Width, doc.PageSize.Height - 215);
            Ob.Stroke();

            doc.Add(imgLogo);
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));

            Paragraph Lema = new Paragraph("COMISIÓN DE PERSONAS SORDAS DEL ESTADO DE QUERÉTARO, A.C.");
            Lema.Alignment = 1; 
            Lema.Font.Size = 17f;
            Lema.IndentationLeft = 175f;
            doc.Add(Lema);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));
            Paragraph fecha = new Paragraph("Fecha: " + DateTime.Now.Day +"/"+ DateTime.Now.Month+"/"+DateTime.Now.Year);
            fecha.Alignment = 2;
            fecha.Font.Size = 10f;
            doc.Add(fecha);
            doc.Add(new Paragraph(" "));
            Paragraph TituloReporte = new Paragraph(textoTitulo);
            TituloReporte.Alignment = 1;
            TituloReporte.Font.Size = 20f;
            doc.Add(TituloReporte);
            doc.Add(new Paragraph(" "));
            doc.Add(tabla);
            doc.Add(listaItems);
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));
            doc.Add( imgGrafica );

            PdfContentByte cbPie;
            cbPie = writer.DirectContent;
            cbPie.BeginText();
            cbPie.SetFontAndSize(FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont, 10);
            cbPie.SetColorFill(iTextSharp.text.BaseColor.BLACK);
            cbPie.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Página: " + writer.PageNumber.ToString(), 540, 25, 0);
            cbPie.EndText();
            
            Paragraph piePagina = new Paragraph("Esta muestra se realizó con datos cualitativos y cuantitativos obtenidos en el Censo de Población y Desarrollo Integral del (año o período): "
                    +periodo+" para personas con discapacidad auditiva, realizado por la Comisión de Personas Sordas del Estado de Querétaro."
                    +"\nNota 1: Los datos obtenidos exponen una realidad aproximada sobre la comunidad de personas Sordas."
                    +"Análisis diversos de este programa calculan sus porcentajes en porción del número total de personas con discapacidad auditiva registradas en el sistema."
                    +"\nNota 2: Según el Censo de Población y Vivienda 2010 (INEGI) se contaron 7,178 personas con discapacidad auditiva en el Estado de Querétaro.");
            piePagina.IndentationLeft = 15f;
            piePagina.IndentationRight = 15f;
            piePagina.Font.Size = 10f;
            doc.Add(piePagina);
            doc.Close();
            

            string pdfPath = Path.Combine(Application.StartupPath, "Reporte.pdf");
            Process.Start(pdfPath);
        }


        /***************************************************************************
         * Metodo  que voltea la fecha al formato yyyy-mm-dd de MySQL
         * Parametros:
         * @String de fecha
         * ************************************************************************/
        public static String formatoFechaMySQL(String fecha)
        {
            String year, month, day;
            char[] separators = { '/' };
            String [] fechaSeparada = fecha.Split(separators);
            day = fechaSeparada[0];
            month = fechaSeparada[1];
            year = fechaSeparada[2];
            String MySQLdate = year + "-" + month + "-" + day;
            return MySQLdate;
        }

        /**************************************************************************
         * Metodo para regresar la fecha al formato de VS
         * Parametros:
         * @String fecha
         * ***********************************************************************/
        public static String formatoFechaVS(String fecha)
        {
            String f;
            String[] stringSeparado = fecha.Split(' ');
            f = stringSeparado[0];
            return f;
        }

    }
}
