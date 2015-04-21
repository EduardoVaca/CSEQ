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
    public partial class Persona : Form
    {
        String nombre_selected;
        int rol;
        String CURP_selected;

        public Persona(int rol)
        {
            InitializeComponent();
            this.rol = rol;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Persona_Load(object sender, EventArgs e)
        {
            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado");
            Util.llenarComboBox(Censo, "Select * FROM Censo");
            Util.llenarComboBox(ID_estadoCivil, "Select ID_estadoCivil, nombre FROM EstadoCivil");
            Util.llenarComboBox(ID_nivelEducativo, "SELECT ID_nivelEducativo, nivel FROM NivelEducativo");
            Util.llenarComboBox(ID_institucionEducativa, "SELECT ID_institucionEducativa, nombre FROM InstitucionEducativa");
            Util.llenarComboBox(ID_lenguaDominante, "SELECT ID_lenguaDominante, nombre FROM LenguaDominante");
            Util.llenarComboBox(ID_nivelEspanol, "SELECT ID_nivelEspanol, nivel FROM NivelEspanol");
            Util.llenarComboBox(ID_nivelIngles, "SELECT ID_nivelIngles, nivel FROM NivelIngles");
            Util.llenarComboBox(ID_nivelLSM, "SELECT ID_nivelLSM, nivel FROM NivelLSM");
            Util.llenarComboBox(ID_areaTrabajo, "SELECT ID_areaTrabajo, nombre FROM AreaTrabajo");
            Util.llenarComboBox(ID_periodo, "SELECT ID_periodo, periodo FROM Periodo");
            Util.llenarComboBox(ID_perdidaAuditiva, "SELECT ID_perdidaAuditiva, tipo FROM PerdidaAuditiva");
            Util.llenarComboBox(ID_grado, "SELECT ID_grado, CONCAT(grado, ': ', descripcion) FROM Grado");
            Util.llenarComboBox(ID_causa, "SELECT ID_causa, causa FROM Causa");
            Util.llenarComboBox(ID_aparatoAuditivo, "SELECT ID_aparatoAuditivo, contenido FROM AparatoConMarca");
            //Util.llenarComboBox(ID_marca, "SELECT ID_marca, nombre FROM Marca");
            Util.llenarComboBox(ID_sueldo, "SELECT ID_sueldo, CONCAT('$',minimo, ' a ','$',maximo) FROM Sueldo");
            Util.llenarComboBox(ID_estadoEmpleo, "SELECT ID_estado, nombre FROM Estado");
            masculino_check.Checked = true;
            if (rol == 1)
            {
                modificar_btn.Visible = true;
                modificar_lb.Visible = true;
                eliminar_btn.Visible = true;
                eliminar_lb.Visible = true;
            }
        }

        /*--------------------------------------------------------------------------------
         * Metodos los cuales llenan un comboBox basandose en el contenido de otro comboBox
         * Ejemplo: Estado - > Municipios
         */
        private void ID_estado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("Cambio estado");
            String valorComboBox = ID_estado.SelectedValue.ToString();           
            Util.llenarComboBox(ID_municipio, "SELECT ID_municipio, nombre FROM Municipio WHERE " +
                                                "ID_estado = " + valorComboBox);
        }

        private void ID_municipio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("Cambio mun");
            String valorComboBox = ID_municipio.SelectedValue.ToString();
            Util.llenarComboBox(ID_colonia, "SELECT ID_colonia, nombre FROM Colonia WHERE " +
                                               "ID_municipio = " + valorComboBox);
        }

        private void estadoEmpleo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String valorComboBox = ID_estadoEmpleo.SelectedValue.ToString();
            Util.llenarComboBox(ID_municipioEmpleo, "SELECT ID_municipio, nombre FROM Municipio WHERE " +
                                                "ID_estado = " + valorComboBox);
        }

        private void municipioEmpleo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String valorComboBox = ID_municipioEmpleo.SelectedValue.ToString();
            Util.llenarComboBox(ID_coloniaEmpleo, "SELECT ID_colonia, nombre FROM Colonia WHERE " +
                                               "ID_municipio = " + valorComboBox);
        }
        /*-------------------------------------------------------------------------------------*/

        private void Buscar_Click(object sender, EventArgs e)
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaPersonaCOMPLETO", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            String nombre;
            String CURP;
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                eliminar_btn.Enabled = true;
                modificar_btn.Enabled = true;
                nombre = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                CURP = busqueda_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                int censoInput = Int16.Parse(busqueda_grid.Rows[e.RowIndex].Cells[3].Value.ToString());

                String sqlActiveRow = "CALL mostrarPersona('" + nombre + "','" + CURP + "'," + censoInput + ");";

                textBox1.Text = sqlActiveRow;
                Util.showData(this, sqlActiveRow);
                nombre_selected = Nombre_txt.Text;
                CURP_selected = CURP_txt.Text;
                //Se vuelven a llenar los comboBox DEPENDIENTES para que no sean valores nulos
                //Domicilio Persona
                ID_estado.SelectedValue = Int16.Parse(busqueda_grid.Rows[e.RowIndex].Cells[6].Value.ToString());
                Util.llenarComboBox(ID_municipio, "SELECT ID_municipio, nombre FROM Municipio WHERE ID_estado = " + ID_estado.SelectedValue + ";");
                ID_municipio.SelectedValue = Int16.Parse(busqueda_grid.Rows[e.RowIndex].Cells[5].Value.ToString());
                Util.llenarComboBox(ID_colonia, "SELECT ID_colonia, nombre FROM Colonia WHERE ID_municipio = " + ID_municipio.SelectedValue + ";");
                ID_colonia.SelectedValue = Int16.Parse(busqueda_grid.Rows[e.RowIndex].Cells[4].Value.ToString());
                //Domicilio Empleo
                ID_estadoEmpleo.SelectedValue = Int16.Parse(busqueda_grid.Rows[e.RowIndex].Cells[10].Value.ToString());
                Util.llenarComboBox(ID_municipioEmpleo, "SELECT ID_municipio, nombre FROM Municipio WHERE ID_estado = " + ID_estadoEmpleo.SelectedValue + ";");
                ID_municipioEmpleo.SelectedValue = Int16.Parse(busqueda_grid.Rows[e.RowIndex].Cells[9].Value.ToString());
                Util.llenarComboBox(ID_coloniaEmpleo, "SELECT ID_colonia, nombre FROM Colonia WHERE ID_municipio = " + ID_municipioEmpleo.SelectedValue + ";");
                ID_coloniaEmpleo.SelectedValue = Int16.Parse(busqueda_grid.Rows[e.RowIndex].Cells[8].Value.ToString());
            }
        }
    

        //Procedimiento unicamente para registrar hijo
        private void registraHijo_button_Click(object sender, EventArgs e)
        {
            String nombreH = nombreHijo_txt.Text;
            String fechaNacH = fechaNacimientoHijo.Value.ToShortDateString();
            Boolean sordoH = sordoHijo_check.Checked;
            String curpP = CURP_txt.Text;

            if(Util.executeStoredProcedure("registrarHijo", nombreH, fechaNacH, sordoH, curpP)){
                MessageBox.Show("El Hijo se ha registrado con exito!");
            }

        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            //Obtenion de datos **********************************************************************
            String CURPP = CURP_txt.Text;
            String nombreP = Nombre_txt.Text;
            String fechaNacP = fecha_nacimiento.Value.ToShortDateString();
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
            int anoEstudioP =  Int32.Parse(ano_txt.Text);
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
            int ID_coloniaEmpleoP = Int32.Parse(ID_coloniaEmpleo.SelectedValue.ToString());
            int ID_perdidaAuditivaP = Int32.Parse(ID_perdidaAuditiva.SelectedValue.ToString());
            Boolean prelinguisticaP = prelinguistica_check.Checked;
            int ID_gradoP = Int32.Parse(ID_grado.SelectedValue.ToString());
            Boolean bilateralP = bilateral_check.Checked;
            int ID_causaP = Int32.Parse(ID_causa.SelectedValue.ToString());
            int ID_aparatoAuditivoP = Int32.Parse(ID_aparatoAuditivo.SelectedValue.ToString());
            String modeloP = modelo_txt.Text;
            //***********************************************************************************************

            if(Util.executeStoredProcedure("registrarPersonaCOMPLETO", CURPP, nombreP, fechaNacP, sexoH, telefonoP, 
                                            correoP, calleP, examenP, implanteP, comunidadIndP, alergiaP, enfermedadP,
                                            mexicanoP, ifeP, ID_periodoP, ID_censoP, ID_coloniaP, ID_estadoCivilP, 
                                            ID_nivelEducativoP, ID_institucionEducativaP, anoEstudioP, ID_lenguaDominanteP,
                                            ID_nivelEspanolP, ID_nivelInglesP, ID_nivelLSMP, descripcionEmpleoP,
                                            nombreCompanyP, correoEmpleoP, telefonoEmpleoP, calleEmpleoP, interpretacionLSMP,
                                            ID_areaTrabajoP, ID_sueldoP, ID_coloniaEmpleoP, ID_perdidaAuditivaP,
                                            prelinguisticaP, ID_gradoP, bilateralP, ID_causaP, ID_aparatoAuditivoP, modeloP))
            {
                MessageBox.Show("La persona " + nombreP + " se ha registrado con exito!");
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


        private void Persona_tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage != DatosPersonales_tab && e.TabPage != BuscarRegistro_tab)
            {
                if (!datosPersonalesLlenos())
                {
                    e.Cancel = true;
                }
                else if (e.TabPage == PerdidaAuditiva_tab || e.TabPage == Familia_tab)
                {
                    if (!datosLaboralesLlenos())
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        // Funciones para ver si las tab tienen la información obligatoria requerida...
        private bool datosPersonalesLlenos()
        {
            if (!String.IsNullOrEmpty(CURP_txt.Text) && !String.IsNullOrEmpty(Nombre_txt.Text) &&
                (masculino_check.Checked || femenino_check.Checked))
            {
                return true;
            }

            return false;
        }

        private bool datosLaboralesLlenos()
        {
            if (!String.IsNullOrEmpty(descripcion_txt.Text))
            {
                return true;
            }

            return false;
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String CURPP = CURP_txt.Text;
            String nombreP = Nombre_txt.Text;
            String fechaNacP = fecha_nacimiento.Value.ToShortDateString();
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
            int ID_coloniaEmpleoP = Int32.Parse(ID_coloniaEmpleo.SelectedValue.ToString());
            int ID_perdidaAuditivaP = Int32.Parse(ID_perdidaAuditiva.SelectedValue.ToString());
            Boolean prelinguisticaP = prelinguistica_check.Checked;
            int ID_gradoP = Int32.Parse(ID_grado.SelectedValue.ToString());
            Boolean bilateralP = bilateral_check.Checked;
            int ID_causaP = Int32.Parse(ID_causa.SelectedValue.ToString());
            int ID_aparatoAuditivoP = Int32.Parse(ID_aparatoAuditivo.SelectedValue.ToString());
            String modeloP = modelo_txt.Text;

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
                                            prelinguisticaP, ID_gradoP,bilateralP, ID_causaP, ID_aparatoAuditivoP, 
                                            modeloP))
                {
                    MessageBox.Show("La persona se ha modificado con exito!");
                }
            }           
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

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro que quieres eliminar a '" + nombre_selected + "'? TODA la " +
                "informacion referente a esta persona se borrara...", "Confirmacion de eliminacion", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarPersona", CURP_selected))
                {
                    MessageBox.Show("Se elimino a la persona con exito!");
                }
            }
        }

    }
}
