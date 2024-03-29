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
    public partial class Persona : Form
    {
        String nombre_selected;
        int rol;
        String CURP_selected;
        Boolean registro_persona = false;
        int ID_hijoSelected, censoInput;        

        public Persona(int rol)
        {
            InitializeComponent();
            this.rol = rol;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas salir de la aplicación?", "Mensaje de Confirmación", MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void back_picture_Click(object sender, EventArgs e)
        {

            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea Guardar Borrador?", "Mantener cambios", MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
            }
            else
            {
                this.Close();
            }            
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }
        
        /*********************************************************************
         * Metodo que carga todos los combobox
         * Les establece un valor
         * *****************************************************************/
        private void cargaCombosBoxes()
        {
            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado" + " ORDER BY nombre ASC");
            Util.llenarComboBox(ID_municipio, "SELECT ID_municipio, nombre FROM Municipio WHERE ID_estado = " + ID_estado.SelectedValue + " ORDER BY nombre ASC");
            Util.llenarComboBox(ID_colonia, "SELECT ID_colonia, nombre FROM Colonia WHERE ID_municipio =" + ID_municipio.SelectedValue + " ORDER BY nombre ASC");
            Util.llenarComboBox(Censo, "Select * FROM Censo");
            Util.llenarComboBox(ID_estadoCivil, "Select ID_estadoCivil, nombre FROM EstadoCivil");
            Util.llenarComboBox(ID_nivelEducativo, "SELECT ID_nivelEducativo, nivel FROM NivelEducativo");
            Util.llenarComboBox(ID_institucionEducativa, "SELECT ID_institucionEducativa, nombre FROM InstitucionEducativa" + " ORDER BY nombre ASC");
            Util.llenarComboBox(ID_lenguaDominante, "SELECT ID_lenguaDominante, nombre FROM LenguaDominante");
            Util.llenarComboBox(ID_nivelEspanol, "SELECT ID_nivelEspanol, nivel FROM NivelEspanol");
            Util.llenarComboBox(ID_nivelIngles, "SELECT ID_nivelIngles, nivel FROM NivelIngles");
            Util.llenarComboBox(ID_nivelLSM, "SELECT ID_nivelLSM, nivel FROM NivelLSM");
            Util.llenarComboBox(ID_areaTrabajo, "SELECT ID_areaTrabajo, nombre FROM AreaTrabajo" + " ORDER BY nombre ASC");
            Util.llenarComboBox(ID_periodo, "SELECT ID_periodo, periodo FROM Periodo");
            Util.llenarComboBox(ID_perdidaAuditiva, "SELECT ID_perdidaAuditiva, CONCAT('Pérdida Auditiva ', tipo) FROM PerdidaAuditiva");
            Util.llenarComboBox(ID_grado, "SELECT ID_grado, CONCAT(grado, ': ', descripcion) FROM Grado");
            Util.llenarComboBox(ID_causa, "SELECT ID_causa, causa FROM Causa" + " ORDER BY causa ASC");
            Util.llenarComboBox(ID_aparatoAuditivo, "SELECT ID_aparatoAuditivo, contenido FROM AparatoConMarca" + " ORDER BY contenido ASC");
            Util.llenarComboBox(ID_sueldo, "SELECT ID_sueldo, CONCAT(minimo, ' a ',maximo) FROM Sueldo");
            Util.llenarComboBox(ID_estadoEmpleo, "SELECT ID_estado, nombre FROM Estado" + " ORDER BY nombre ASC");
            Util.llenarComboBox(ID_municipioEmpleo, "SELECT ID_municipio, nombre FROM Municipio WHERE ID_estado = " + ID_estado.SelectedValue + " ORDER BY nombre ASC");
            Util.llenarComboBox(ID_coloniaEmpleo, "SELECT ID_colonia, nombre FROM Colonia WHERE ID_municipio =" + ID_municipio.SelectedValue + " ORDER BY nombre ASC");
            masculino_check.Checked = true;
        }

        private void Persona_Load(object sender, EventArgs e)
        {            
            cargaCombosBoxes();
            if (rol == 1)
            {
                modificar_pb.Visible = true;                
                eliminar_pb.Visible = true;                
            }
            salir_tt.SetToolTip(pictureBox2, "Salir de la aplicación");
            cerrarSesion_tt.SetToolTip(logout, "Cerrar sesión");
            refresh_toolTip.SetToolTip(refresh_municipio, "Actualizar Municipios");
            refresh_toolTip.SetToolTip(refresh_estado, "Actualizar Estados");
            refresh_toolTip.SetToolTip(refresh_colonia, "Actualizar Colonias");
            refresh_toolTip.SetToolTip(censo_refresh, "Actualizar Censos");
            refresh_toolTip.SetToolTip(institucion_refresh, "Actualizar Instituciones");
            refresh_toolTip.SetToolTip(sueldo_refresh, "Actualizar Sueldos");
            refresh_toolTip.SetToolTip(areaTrabajo_refresh, "Actualizar Areas Trabajo");
            refresh_toolTip.SetToolTip(estadoEmpelo_refresh, "Actualizar Estados");
            refresh_toolTip.SetToolTip(municipioEmpleo_refresh, "Actualizar Municipios");
            refresh_toolTip.SetToolTip(coloniaEmpleo_refresh, "Actualizar Colonias");
            refresh_toolTip.SetToolTip(causa_refresh, "Actualizar Causas");
            refresh_toolTip.SetToolTip(aparato_refresh, "Actualizar Aparatos");            
        }

        /*--------------------------------------------------------------------------------
         * Metodos los cuales llenan un comboBox basandose en el contenido de otro comboBox
         * Ejemplo: Estado - > Municipios
         */
        private void ID_estado_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            String valorComboBox = ID_estado.SelectedValue.ToString();           
            Util.llenarComboBox(ID_municipio, "SELECT ID_municipio, nombre FROM Municipio WHERE " +
                                                "ID_estado = " + valorComboBox + " ORDER BY nombre ASC");
        }

        private void ID_municipio_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            String valorComboBox = ID_municipio.SelectedValue.ToString();
            Util.llenarComboBox(ID_colonia, "SELECT ID_colonia, nombre FROM Colonia WHERE " +
                                               "ID_municipio = " + valorComboBox + " ORDER BY nombre ASC");
        }

        private void estadoEmpleo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String valorComboBox = ID_estadoEmpleo.SelectedValue.ToString();
            Util.llenarComboBox(ID_municipioEmpleo, "SELECT ID_municipio, nombre FROM Municipio WHERE " +
                                                "ID_estado = " + valorComboBox + " ORDER BY nombre ASC");
        }

        private void municipioEmpleo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String valorComboBox = ID_municipioEmpleo.SelectedValue.ToString();
            Util.llenarComboBox(ID_coloniaEmpleo, "SELECT ID_colonia, nombre FROM Colonia WHERE " +
                                               "ID_municipio = " + valorComboBox + " ORDER BY nombre ASC");
        }
        /*-------------------------------------------------------------------------------------*/


        /*********************************************************
         * Metodo que busca en la Tabla un registro dado por el usuario
         * llenando el grid con la tabla obtenida
         * ******************************************************/
        private void buscar()
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Cursor = Cursors.WaitCursor;
            Util.fillGrid(busqueda_grid, "buscarPersona", busqueda);
            Cursor = Cursors.Default;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            buscar();  
        }

        /**********************************************************
         * Metodo que llena todo el form con los datos obtenidos del
         * registro seleccionado en el grid
         * Se activan los botones de Modificar y Eliminar
         * *******************************************************/
        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            String nombre;
            String CURP;
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                //loading_lb.Visible = true;
                CURP_txt.Enabled = false;
                Cursor = Cursors.WaitCursor;
                buscar_blanco.Visible = true;
                buscar_gris.Visible = false;
                registro_persona = true;
                hijos_grid.Visible = true;
                eliminar_pb.Enabled = true;
                modificar_pb.Enabled = true;
                nombre = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                CURP = busqueda_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                censoInput = Int16.Parse(busqueda_grid.Rows[e.RowIndex].Cells[2].Value.ToString());
                Boolean tiene_empleo = Boolean.Parse(busqueda_grid.Rows[e.RowIndex].Cells[3].Value.ToString());
                Boolean tiene_aparato = Boolean.Parse(busqueda_grid.Rows[e.RowIndex].Cells[4].Value.ToString());

                String sqlActiveRow;

                if(tiene_empleo && tiene_aparato)
                {
                    sqlActiveRow = "CALL mostrarPersona('" + nombre + "','" + CURP + "'," + censoInput + ");";
                    noTieneAparato_check.Checked = false;
                    sinEmpleo_check.Checked = false;
                }                    
                else if(tiene_empleo)
                {
                    sqlActiveRow = "CALL mostrarPersonaSinAparato('" + nombre + "','" + CURP + "'," + censoInput + ");";
                    noTieneAparato_check.Checked = true;
                    sinEmpleo_check.Checked = false;
                    limpiarFormaDeAparatoAuditivo();
                }                    
                else if(tiene_aparato)
                {
                    sqlActiveRow = "CALL mostrarPersonaSinEmpleo('" + nombre + "','" + CURP + "'," + censoInput + ");";
                    sinEmpleo_check.Checked = true;
                    noTieneAparato_check.Checked = false;
                    limpiarFormDeEmpleo();
                }
                else
                {
                    sqlActiveRow = "CALL mostrarPersonaSinEmpleoSinAparato('" + nombre + "','" + CURP + "'," + censoInput + ");";
                    noTieneAparato_check.Checked = true;
                    sinEmpleo_check.Checked = true;
                    limpiarFormDeEmpleo();
                    limpiarFormaDeAparatoAuditivo();
                }
                   
                
                Util.showData(this, sqlActiveRow);
                nombre_selected = Nombre_txt.Text;
                CURP_selected = CURP_txt.Text;
                Util.fillGrid(hijos_grid, "BusquedaEnHijo", CURP_selected);

                //Se vuelven a llenar los comboBox DEPENDIENTES para que no sean valores nulos
                DataTable direccionPersona = new DataTable();
                DataTable direccionEmpleo = new DataTable();
                direccionPersona = Util.getData("CALL obtenerDireccionPersona('" + CURP + "'," + censoInput + ");");
                //Domicilio Persona                
                ID_estado.SelectedValue = Int16.Parse(direccionPersona.Rows[0][0].ToString());
                Util.llenarComboBox(ID_municipio, "SELECT ID_municipio, nombre FROM Municipio WHERE ID_estado = " + ID_estado.SelectedValue + ";");
                ID_municipio.SelectedValue = Int16.Parse(direccionPersona.Rows[0][1].ToString());
                Util.llenarComboBox(ID_colonia, "SELECT ID_colonia, nombre FROM Colonia WHERE ID_municipio = " + ID_municipio.SelectedValue + ";");
                ID_colonia.SelectedValue = Int16.Parse(direccionPersona.Rows[0][2].ToString());
                //Domicilio Empleo (solo si tiene empleo)
                if (tiene_empleo)
                {
                    direccionPersona = Util.getData("CALL obtenerDireccionEmpleo('" + CURP + "'," + censoInput + ");");
                    ID_estadoEmpleo.SelectedValue = Int16.Parse(direccionPersona.Rows[0][0].ToString());
                    Util.llenarComboBox(ID_municipioEmpleo, "SELECT ID_municipio, nombre FROM Municipio WHERE ID_estado = " + ID_estadoEmpleo.SelectedValue + ";");
                    ID_municipioEmpleo.SelectedValue = Int16.Parse(direccionPersona.Rows[0][1].ToString());
                    Util.llenarComboBox(ID_coloniaEmpleo, "SELECT ID_colonia, nombre FROM Colonia WHERE ID_municipio = " + ID_municipioEmpleo.SelectedValue + ";");
                    ID_coloniaEmpleo.SelectedValue = Int16.Parse(direccionPersona.Rows[0][2].ToString());
                }
                Cursor = Cursors.Default;                
            }
        }

        private void tieneHijo_check_CheckedChanged(object sender, EventArgs e)
        {
            if (tieneHijo_check.Checked)
            {
                nombreHijo_txt.Enabled = true;
                fechaNacimientoHijo.Enabled = true;
                sordoHijo_check.Enabled = true;
                registraHijo_button.Enabled = true;                
            }
        }

        private void masculino_check_CheckedChanged(object sender, EventArgs e)
        {
            if (masculino_check.Checked)
            {
                femenino_check.Checked = false;
                masculino_check.Checked = true;
            }
            
        }

        private void femenino_check_CheckedChanged(object sender, EventArgs e)
        {
            if (femenino_check.Checked)
            {
                femenino_check.Checked = true;
                masculino_check.Checked = false;
            }
        }

        //Metodo para verificar si en pestanas determinadas los datos esenciales estan llenos, de manera que
        //permite o no avanzar a la siguiente pestana
        private void Persona_tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage != DatosPersonales_tab && e.TabPage != BuscarRegistro_tab)
            {
                if (!datosPersonalesLlenos())
                {
                    e.Cancel = true;
                    MessageBox.Show("Faltan campos esenciales por llenar, favor de verificar");
                }
                else if (e.TabPage == PerdidaAuditiva_tab)
                {
                    if (!datosLaboralesLlenos())
                    {
                        MessageBox.Show("Faltan campos esenciales por llenar, favor de verificar");
                        e.Cancel = true;
                    }
                }
                else if (e.TabPage == Familia_tab)
                {
                    if (registro_persona == false)
                    {
                        e.Cancel = true;
                        MessageBox.Show("Se debe guardar la Persona antes de registrar a su familia");
                    }
                }
                if (e.TabPage == PerdidaAuditiva_tab)
                    guardar_pb.Enabled = true;
            }
        }

        // Funciones para ver si las tab tienen la información obligatoria requerida...
        private bool datosPersonalesLlenos()
        {
            if (!String.IsNullOrEmpty(CURP_txt.Text) && !String.IsNullOrEmpty(Nombre_txt.Text) &&
                (masculino_check.Checked || femenino_check.Checked) && ID_colonia.SelectedValue != null
                && ID_colonia.SelectedValue != null)
            {
                if (CURP_txt.TextLength == 18)
                    return true;
                else
                    MessageBox.Show("CURP inválido, favor de verificar");
            }

            return false;
        }

        private bool datosLaboralesLlenos()
        {
            if (!String.IsNullOrEmpty(descripcion_txt.Text) || sinEmpleo_check.Checked)
            {
                return true;
            }

            return false;
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


        //Metodo que permite que una persona sea registrada sin empleo
        private void sinEmpleo_check_CheckedChanged(object sender, EventArgs e)
        {
            if (sinEmpleo_check.Checked)
            {
                descripcion_txt.Enabled = false;
                nombre_compania_txt.Enabled = false;
                ID_sueldo.Enabled = false;
                ID_areaTrabajo.Enabled = false;
                telefonoEmpleo_txt.Enabled = false;
                calleEmpleo_txt.Enabled = false;
                correoEmpleo_txt.Enabled = false;
                ID_estadoEmpleo.Enabled = false;
                ID_municipioEmpleo.Enabled = false;
                ID_coloniaEmpleo.Enabled = false;
                interpretacion_LSM_check.Enabled = false;
            }
            else
            {
                descripcion_txt.Enabled = true;
                nombre_compania_txt.Enabled = true;
                ID_sueldo.Enabled = true;
                ID_areaTrabajo.Enabled = true;
                telefonoEmpleo_txt.Enabled = true;
                calleEmpleo_txt.Enabled = true;
                correoEmpleo_txt.Enabled = true;
                ID_estadoEmpleo.Enabled = true;
                ID_municipioEmpleo.Enabled = true;
                ID_coloniaEmpleo.Enabled = true;
                interpretacion_LSM_check.Enabled = true;
            }            
        }

        //Metodo para desabilitar los campos de Aparato si la persona no posee alguno
        private void noTieneAparato_check_CheckedChanged(object sender, EventArgs e)
        {
            if (noTieneAparato_check.Checked)
            {
                ID_aparatoAuditivo.Enabled = false;
                modelo_txt.Enabled = false;                                
            }
            else
            {
                ID_aparatoAuditivo.Enabled = true;
                modelo_txt.Enabled = true;
            }
        }

        // Metodo que limpia la pestaña de aparato auditivo en caso de que la persona no cuente con uno
        private void limpiarFormaDeAparatoAuditivo()
        {
            modelo_txt.Text = "";
        }
        //Metodo que limpia pestaña de Empleo en caso de que la persona no cuente con uno
        private void limpiarFormDeEmpleo()
        {
            descripcion_txt.Text = "";
            nombre_compania_txt.Text = "";
            telefonoEmpleo_txt.Text = "";
            calleEmpleo_txt.Text = "";
            correoEmpleo_txt.Text = "";
        }        

        //Metodo que rellena los campos asociados al hijo seleccionado en el grid
        private void hijos_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ID_hijoSelected = Int16.Parse(hijos_grid.Rows[e.RowIndex].Cells[3].Value.ToString());
            
            String MySqlActiveRow = "CALL mostrarHijo(" + ID_hijoSelected + ");";
            Util.showData(this, MySqlActiveRow);
            tieneHijo_check.Checked = true;
            modificarHijo_btn.Enabled = true;
            eliminarHijo_btn.Enabled = true;
        }

        //Procedimiento unicamente para registrar hijo y mostrar en el grid los hijos de esa persona
        private void registraHijo_button_Click(object sender, EventArgs e)
        {
            String nombreH = nombreHijo_txt.Text;
            String fechaNacH = Util.formatoFechaMySQL(fechaNacimientoHijo.Value.ToShortDateString());
            Boolean sordoH = sordoHijo_check.Checked;
            String curpP = CURP_txt.Text;

            if (Util.executeStoredProcedure("registrarHijo", nombreH, fechaNacH, sordoH, curpP))
            {
                MessageBox.Show("El Hijo se ha registrado con exito!");
            }
            hijos_grid.Visible = true;
            nombreHijo_txt.Text = "";
            sordoHijo_check.Checked = false;
            Util.fillGrid(hijos_grid, "BusquedaEnHijo", curpP);
        }

        //Metodo para modificar el hijo seleccionado del grid, toma los nuevo valores y se basa en el ID del hijo
        // para modificarlo
        private void moficiarHijo_btn_Click(object sender, EventArgs e)
        {
            String nombreHijoP = nombreHijo_txt.Text;
            Boolean esSordoP = sordoHijo_check.Checked;
            String fechaNacP = Util.formatoFechaMySQL(fechaNacimientoHijo.Value.ToShortDateString());

            if (Util.executeStoredProcedure("modificarHijo", ID_hijoSelected, nombreHijoP, fechaNacP, esSordoP))
            {
                MessageBox.Show("El hijo se ha modificado con exito!");
                Util.fillGrid(hijos_grid, "BusquedaEnHijo", CURP_selected);
            }
        }

        //Metodo que elimina el hijo seleccionado del grid, se pasa su ID como parametro para eliminarlo
        private void eliminarHijo_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Seguro desea eliminar al hijo: " + nombreHijo_txt.Text + "?",
                                           "Mensaje de Confirmación", MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarHijo", ID_hijoSelected))
                {
                    MessageBox.Show("El hijo se ha eliminado con exito!");
                    Util.fillGrid(hijos_grid, "BusquedaEnHijo", CURP_selected);
                }
            }
        }

        /*Metodo que guarda un nuevo registro en la Base*/
        private void guardar_pb_Click(object sender, EventArgs e)
        {
            //Obtenion de datos **********************************************************************
            String CURPP = CURP_txt.Text;
            String nombreP = Nombre_txt.Text;
            String fechaNacP = Util.formatoFechaMySQL(fecha_nacimiento.Value.ToShortDateString());
            Boolean sexoH = masculino_check.Checked;
            String telefonoP = telefono_txt.Text;
            String correoP = Correo_txt.Text;
            String calleP = calle_txt.Text;
            Boolean examenP = examen_audiometria_check.Checked;
            Boolean implanteP = implante_coclear_check.Checked;
            Boolean comunidadIndP = comunidad_indigena_check.Checked;
            Boolean alergiaP = alergia_check.Checked;
            Boolean enfermedadP = enfermedad_check.Checked;
            Boolean mexicanoP = mexicano_check.Checked;
            Boolean ifeP = credencialIFE_check.Checked;
            int ID_periodoP = Int32.Parse(ID_periodo.SelectedValue.ToString());
            int ID_censoP = Int32.Parse(Censo.SelectedValue.ToString());
            int ID_coloniaP = Int32.Parse(ID_colonia.SelectedValue.ToString());
            int ID_estadoCivilP = Int32.Parse(ID_estadoCivil.SelectedValue.ToString());
            int ID_nivelEducativoP = Int32.Parse(ID_nivelEducativo.SelectedValue.ToString());
            int ID_institucionEducativaP = Int32.Parse(ID_institucionEducativa.SelectedValue.ToString());
            int anoEstudioP = Int32.Parse(ano_txt.Text);
            int ID_lenguaDominanteP = Int32.Parse(ID_lenguaDominante.SelectedValue.ToString());
            int ID_nivelEspanolP = Int32.Parse(ID_nivelEspanol.SelectedValue.ToString());
            int ID_nivelInglesP = Int32.Parse(ID_nivelIngles.SelectedValue.ToString());
            int ID_nivelLSMP = Int32.Parse(ID_nivelLSM.SelectedValue.ToString());
            String descripcionEmpleoP = descripcion_txt.Text;
            String nombreCompanyP = nombre_compania_txt.Text;
            String correoEmpleoP = correoEmpleo_txt.Text;
            String telefonoEmpleoP = telefonoEmpleo_txt.Text;
            String calleEmpleoP = calleEmpleo_txt.Text;
            Boolean interpretacionLSMP = interpretacion_LSM_check.Checked;
            int ID_areaTrabajoP = Int32.Parse(ID_areaTrabajo.SelectedValue.ToString());
            int ID_sueldoP = Int32.Parse(ID_sueldo.SelectedValue.ToString());
            int ID_coloniaEmpleoP;
            if (sinEmpleo_check.Checked)
                ID_coloniaEmpleoP = 0;
            else
                ID_coloniaEmpleoP = Int32.Parse(ID_coloniaEmpleo.SelectedValue.ToString());
            int ID_perdidaAuditivaP = Int32.Parse(ID_perdidaAuditiva.SelectedValue.ToString());
            Boolean prelinguisticaP = prelinguistica_check.Checked;
            int ID_gradoP = Int32.Parse(ID_grado.SelectedValue.ToString());
            Boolean bilateralP = bilateral_check.Checked;
            int ID_causaP = Int32.Parse(ID_causa.SelectedValue.ToString());
            int ID_aparatoAuditivoP = Int32.Parse(ID_aparatoAuditivo.SelectedValue.ToString());
            String modeloP = modelo_txt.Text;
            Boolean tiene_empleoP;
            Boolean tiene_aparatoP;

            if (sinEmpleo_check.Checked)
                tiene_empleoP = false;
            else
                tiene_empleoP = true;
            if (noTieneAparato_check.Checked)
                tiene_aparatoP = false;
            else
                tiene_aparatoP = true;


            //***********************************************************************************************          
            if (Util.executeStoredProcedure("registrarPersonaCOMPLETO", CURPP, nombreP, fechaNacP, sexoH, telefonoP,
                                            correoP, calleP, examenP, implanteP, comunidadIndP, alergiaP, enfermedadP,
                                            mexicanoP, ifeP, ID_periodoP, ID_censoP, ID_coloniaP, ID_estadoCivilP,
                                            ID_nivelEducativoP, ID_institucionEducativaP, anoEstudioP, ID_lenguaDominanteP,
                                            ID_nivelEspanolP, ID_nivelInglesP, ID_nivelLSMP, descripcionEmpleoP,
                                            nombreCompanyP, correoEmpleoP, telefonoEmpleoP, calleEmpleoP, interpretacionLSMP,
                                            ID_areaTrabajoP, ID_sueldoP, ID_coloniaEmpleoP, ID_perdidaAuditivaP,
                                            prelinguisticaP, ID_gradoP, bilateralP, ID_causaP, ID_aparatoAuditivoP, modeloP,
                                            tiene_empleoP, tiene_aparatoP))
            {
                MessageBox.Show("La persona " + nombreP + " se ha registrado con exito!");
               // Util.fillGrid(busqueda_grid, "buscarPersona", "%");
                registro_persona = true;
            }
        }

        /*Metodo que modifica un registro en la Base*/
        private void modificar_pb_Click(object sender, EventArgs e)
        {
            String CURPP = CURP_txt.Text;
            String nombreP = Nombre_txt.Text;
            String fechaNacP = Util.formatoFechaMySQL(fecha_nacimiento.Value.ToShortDateString());
            Boolean sexoH = masculino_check.Checked;
            String telefonoP = telefono_txt.Text;
            String correoP = Correo_txt.Text;
            String calleP = calle_txt.Text;
            Boolean examenP = examen_audiometria_check.Checked;
            Boolean implanteP = implante_coclear_check.Checked;
            Boolean comunidadIndP = comunidad_indigena_check.Checked;
            Boolean alergiaP = alergia_check.Checked;
            Boolean enfermedadP = enfermedad_check.Checked;
            Boolean mexicanoP = mexicano_check.Checked;
            Boolean ifeP = credencialIFE_check.Checked;
            int ID_periodoP = Int32.Parse(ID_periodo.SelectedValue.ToString());
            int ID_censoP = Int16.Parse(Censo.SelectedValue.ToString());
            int ID_coloniaP = Int32.Parse(ID_colonia.SelectedValue.ToString());
            int ID_estadoCivilP = Int32.Parse(ID_estadoCivil.SelectedValue.ToString());
            int ID_nivelEducativoP = Int32.Parse(ID_nivelEducativo.SelectedValue.ToString());
            int ID_institucionEducativaP = Int32.Parse(ID_institucionEducativa.SelectedValue.ToString());
            int anoEstudioP = Int32.Parse(ano_txt.Text);
            int ID_lenguaDominanteP = Int32.Parse(ID_lenguaDominante.SelectedValue.ToString());
            int ID_nivelEspanolP = Int32.Parse(ID_nivelEspanol.SelectedValue.ToString());
            int ID_nivelInglesP = Int32.Parse(ID_nivelIngles.SelectedValue.ToString());
            int ID_nivelLSMP = Int32.Parse(ID_nivelLSM.SelectedValue.ToString());
            String descripcionEmpleoP = descripcion_txt.Text;
            String nombreCompanyP = nombre_compania_txt.Text;
            String correoEmpleoP = correoEmpleo_txt.Text;
            String telefonoEmpleoP = telefonoEmpleo_txt.Text;
            String calleEmpleoP = calleEmpleo_txt.Text;
            Boolean interpretacionLSMP = interpretacion_LSM_check.Checked;
            int ID_areaTrabajoP = Int32.Parse(ID_areaTrabajo.SelectedValue.ToString());
            int ID_sueldoP = Int32.Parse(ID_sueldo.SelectedValue.ToString());
            int ID_coloniaEmpleoP;
            if (sinEmpleo_check.Checked)
                ID_coloniaEmpleoP = 0;
            else
                ID_coloniaEmpleoP = Int32.Parse(ID_coloniaEmpleo.SelectedValue.ToString()); int ID_perdidaAuditivaP = Int32.Parse(ID_perdidaAuditiva.SelectedValue.ToString());
            Boolean prelinguisticaP = prelinguistica_check.Checked;
            int ID_gradoP = Int32.Parse(ID_grado.SelectedValue.ToString());
            Boolean bilateralP = bilateral_check.Checked;
            int ID_causaP = Int32.Parse(ID_causa.SelectedValue.ToString());
            int ID_aparatoAuditivoP = Int32.Parse(ID_aparatoAuditivo.SelectedValue.ToString());
            String modeloP = modelo_txt.Text;
            Boolean tiene_empleoP;
            Boolean tiene_aparatoP;

            if (sinEmpleo_check.Checked)
                tiene_empleoP = false;
            else
                tiene_empleoP = true;
            if (noTieneAparato_check.Checked)
                tiene_aparatoP = false;
            else
                tiene_aparatoP = true;

            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Persona: '" + nombre_selected + "'?", "Confirmacion de eliminar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarPersona", CURPP, nombreP, fechaNacP, sexoH, telefonoP,
                                            correoP, calleP, examenP, implanteP, comunidadIndP, alergiaP, enfermedadP,
                                            mexicanoP, ifeP, ID_periodoP, ID_censoP, ID_coloniaP, ID_estadoCivilP,
                                            ID_nivelEducativoP, ID_institucionEducativaP, anoEstudioP, ID_lenguaDominanteP,
                                            ID_nivelEspanolP, ID_nivelInglesP, ID_nivelLSMP, descripcionEmpleoP,
                                            nombreCompanyP, correoEmpleoP, telefonoEmpleoP, calleEmpleoP, interpretacionLSMP,
                                            ID_areaTrabajoP, ID_sueldoP, ID_coloniaEmpleoP, ID_perdidaAuditivaP,
                                            prelinguisticaP, ID_gradoP, bilateralP, ID_causaP, ID_aparatoAuditivoP,
                                            modeloP, tiene_empleoP, tiene_aparatoP))
                {
                    MessageBox.Show("La persona se ha modificado con exito!");
                    Util.fillGrid(busqueda_grid, "buscarPersona", "%");
                }
            }           
        }

        /*Metodo que elimina un registro elegido de la base*/
        private void eliminar_pb_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro que quieres eliminar a '" + nombre_selected + "'? TODA la " +
                "informacion referente a esta persona se borrara...", "Confirmacion de eliminacion", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarPersona", CURP_selected, censoInput))
                {
                    MessageBox.Show("Se elimino a la persona con exito!");
                    Util.fillGrid(busqueda_grid, "buscarPersona", "%");
                }
            }
        }

        //Metodo que limpia todo el form para hacer un nuevo registro
        private void nuevoRegistro_pb_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea continuar? Perderá los cambios sin guardar", "Confirmación", MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                CURP_txt.Enabled = true;
                Cursor = Cursors.WaitCursor;
                Util.clear(this);
                cargaCombosBoxes();
                hijos_grid.Visible = false;
                Cursor = Cursors.Default;
            }
            Persona_tabControl.SelectedTab = DatosPersonales_tab;
        }

        //Metodos que cambian de tamano los iconos
        private void guardar_pb_MouseHover(object sender, EventArgs e)
        {            
            Util.maximizarCualquierIcono(guardar_pb, new Size(34, 35), 3);
        }

        private void modificar_pb_MouseHover(object sender, EventArgs e)
        {           
            Util.maximizarCualquierIcono(modificar_pb, new Size(27, 37), 3);
        }

        private void eliminar_pb_MouseHover(object sender, EventArgs e)
        {           
            Util.maximizarCualquierIcono(eliminar_pb, new Size(30, 37), 3);
        }

        private void nuevoRegistro_pb_MouseHover(object sender, EventArgs e)
        {            
            Util.maximizarCualquierIcono(nuevoRegistro_pb, new Size(30, 36), 3);
        }

        private void guardar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(guardar_pb, new Size(28, 29), 529, 212);
        }

        private void modificar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(modificar_pb, new Size(21, 31), 529, 362);
        }

        private void eliminar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(eliminar_pb, new Size(24, 31), 529, 490);
        }

        private void nuevoRegistro_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(nuevoRegistro_pb, new Size(24, 30), 529, 734);
        }

        private void Buscar_MouseHover(object sender, EventArgs e)
        {
           Util.maximizarCualquierIcono(buscar_blanco, new Size(45, 50), 5);
           Util.maximizarCualquierIcono(buscar_gris, new Size(45, 50), 5);
        }

        private void Buscar_MouseLeave(object sender, EventArgs e)
        {           
           Util.minimizarCualquierIcono(buscar_blanco, new Size(32, 37), 54, 426);
        }

        /*************************************************************************************
        Metodos que recargan los combo boxes una vez reabierto el borrador pendiente
        Esto con la razon de mantenerlos actualizados
         * **********************************************************************************/
        private void refresh_estado_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado" + " ORDER BY nombre ASC");
            Cursor = Cursors.Default;
        }
        private void refresh_municipio_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Util.llenarComboBox(ID_municipio, "SELECT ID_municipio, nombre FROM Municipio WHERE ID_estado = " + ID_estado.SelectedValue + " ORDER BY nombre ASC");
            Cursor = Cursors.Default;
        }

        private void refresh_colonia_Click(object sender, EventArgs e)
        {            
            Cursor = Cursors.WaitCursor;
            Util.llenarComboBox(ID_colonia, "SELECT ID_colonia, nombre FROM Colonia WHERE ID_municipio =" + ID_municipio.SelectedValue + " ORDER BY nombre ASC");
            Cursor = Cursors.Default;
        }

        private void censo_refresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Util.llenarComboBox(Censo, "Select * FROM Censo");
            Cursor = Cursors.Default;
        }

        private void institucion_refresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Util.llenarComboBox(ID_institucionEducativa, "SELECT ID_institucionEducativa, nombre FROM InstitucionEducativa" + " ORDER BY nombre ASC");
            Cursor = Cursors.Default;
        }

        private void sueldo_refresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Util.llenarComboBox(ID_sueldo, "SELECT ID_sueldo, CONCAT(minimo, ' a ',maximo) FROM Sueldo");
            Cursor = Cursors.Default;
        }

        private void areaTrabajo_refresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Util.llenarComboBox(ID_areaTrabajo, "SELECT ID_areaTrabajo, nombre FROM AreaTrabajo" + " ORDER BY nombre ASC");
            Cursor = Cursors.Default;
        }

        private void estadoEmpelo_refresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Util.llenarComboBox(ID_estadoEmpleo, "SELECT ID_estado, nombre FROM Estado" + " ORDER BY nombre ASC");
            Cursor = Cursors.Default;
        }

        private void municipioEmpleo_refresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Util.llenarComboBox(ID_municipioEmpleo, "SELECT ID_municipio, nombre FROM Municipio WHERE ID_estado = " + ID_estado.SelectedValue + " ORDER BY nombre ASC");
            Cursor = Cursors.Default;
        }

        private void coloniaEmpleo_refresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Util.llenarComboBox(ID_coloniaEmpleo, "SELECT ID_colonia, nombre FROM Colonia WHERE ID_municipio =" + ID_municipio.SelectedValue + " ORDER BY nombre ASC");
            Cursor = Cursors.Default;
        }

        private void causa_refresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Util.llenarComboBox(ID_causa, "SELECT ID_causa, causa FROM Causa" + " ORDER BY causa ASC");
            Cursor = Cursors.Default;
        }

        private void aparato_refresh_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Util.llenarComboBox(ID_aparatoAuditivo, "SELECT ID_aparatoAuditivo, contenido FROM AparatoConMarca" + " ORDER BY contenido ASC");
            Cursor = Cursors.Default;
        }


        //Metodo que habilita el Enter en las busquedas
        private void busqueda_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                buscar();
            }
        }

        private void label49_Click(object sender, EventArgs e)
        {
            String nombreH = nombreHijo_txt.Text;
            String fechaNacH = Util.formatoFechaMySQL(fechaNacimientoHijo.Value.ToShortDateString());
            Boolean sordoH = sordoHijo_check.Checked;
            String curpP = CURP_txt.Text;

            if (Util.executeStoredProcedure("registrarHijo", nombreH, fechaNacH, sordoH, curpP))
            {
                MessageBox.Show("El Hijo se ha registrado con exito!");
            }
            hijos_grid.Visible = true;
            nombreHijo_txt.Text = "";
            sordoHijo_check.Checked = false;
            Util.fillGrid(hijos_grid, "BusquedaEnHijo", curpP);
        }

        private void label51_Click(object sender, EventArgs e)
        {
            String nombreHijoP = nombreHijo_txt.Text;
            Boolean esSordoP = sordoHijo_check.Checked;
            String fechaNacP = Util.formatoFechaMySQL(fechaNacimientoHijo.Value.ToShortDateString());

            if (Util.executeStoredProcedure("modificarHijo", ID_hijoSelected, nombreHijoP, fechaNacP, esSordoP))
            {
                MessageBox.Show("El hijo se ha modificado con exito!");
                Util.fillGrid(hijos_grid, "BusquedaEnHijo", CURP_selected);
            }
        }

        private void label68_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Seguro desea eliminar al hijo: " + nombreHijo_txt.Text + "?",
                                           "Mensaje de Confirmación", MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarHijo", ID_hijoSelected))
                {
                    MessageBox.Show("El hijo se ha eliminado con exito!");
                    Util.fillGrid(hijos_grid, "BusquedaEnHijo", CURP_selected);
                }
            }
        }
        
       
    }
}
