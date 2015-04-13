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
        public Persona()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        private void Persona_Load(object sender, EventArgs e)
        {
            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado");
            Util.llenarComboBox(ID_censo, "Select ID_censo, ano FROM Censo");
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
            Util.llenarComboBox(ID_aparatoAuditivo, "SELECT ID_aparatoAuditivo, tipo FROM AparatoAuditivo");
            //Util.llenarComboBox(ID_marca, "SELECT ID_marca, nombre FROM Marca");
            Util.llenarComboBox(ID_sueldo, "SELECT ID_sueldo, CONCAT('$',minimo, ' a ','$',maximo) FROM Sueldo");
            Util.llenarComboBox(estadoEmpleo_combo, "SELECT ID_estado, nombre FROM Estado");
        }

        /*--------------------------------------------------------------------------------
         * Metodos los cuales llenan un comboBox basandose en el contenido de otro comboBox
         * Ejemplo: Estado - > Municipios
         */
        private void ID_estado_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            String valorComboBox = ID_estado.SelectedValue.ToString();           
            Util.llenarComboBox(ID_municipio, "SELECT ID_municipio, nombre FROM Municipio WHERE " +
                                                "ID_estado = " + valorComboBox);
        }

        private void ID_municipio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String valorComboBox = ID_municipio.SelectedValue.ToString();
            Util.llenarComboBox(ID_delegacion, "SELECT ID_delegacion, nombre FROM Delegacion WHERE " +
                                                "ID_municipio = " + valorComboBox);
            Util.llenarComboBox(ID_colonia, "SELECT ID_colonia, nombre FROM Colonia WHERE " +
                                               "ID_municipio = " + valorComboBox);
        }

        private void estadoEmpleo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String valorComboBox = estadoEmpleo_combo.SelectedValue.ToString();
            Util.llenarComboBox(municipioEmpleo_combo, "SELECT ID_municipio, nombre FROM Municipio WHERE " +
                                                "ID_estado = " + valorComboBox);
        }

        private void municipioEmpleo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String valorComboBox = municipioEmpleo_combo.SelectedValue.ToString();
            Util.llenarComboBox(delegacionEmpleo_combo, "SELECT ID_delegacion, nombre FROM Delegacion WHERE " +
                                                "ID_municipio = " + valorComboBox);
            Util.llenarComboBox(ID_coloniaEmpleo, "SELECT ID_colonia, nombre FROM Colonia WHERE " +
                                               "ID_municipio = " + valorComboBox);
        }

        /*-------------------------------------------------------------------------------------*/

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
            String nombreP = nombre_txt.Text;
            String fechaNacP = ID_fechaNacimiento.Value.ToShortDateString();
            Boolean sexoH = masculino_check.Checked;
            String telefonoP = telefono_txt.Text;
            String correoP = correo_txt.Text;
            String calleP = calle_txt.Text;
            Boolean examenP = examen_audiometria.Checked;
            Boolean implanteP = implante_coclear_check.Checked;
            Boolean comunidadIndP = comunidadIndigena_check.Checked;
            Boolean alergiaP = alergia_check.Checked;
            Boolean enfermedadP = enfermedad_check.Checked;
            Boolean mexicanoP = mexicano_check.Checked;
            Boolean ifeP = ife_check.Checked;
            int ID_periodoP = Int32.Parse(ID_periodo.SelectedValue.ToString());
            int ID_censoP = Int32.Parse(ID_censo.SelectedValue.ToString());
            int ID_coloniaP = Int32.Parse(ID_colonia.SelectedValue.ToString());
            int ID_estadoCivilP = Int32.Parse(ID_estadoCivil.SelectedValue.ToString());
            int ID_nivelEducativoP = Int32.Parse(ID_nivelEducativo.SelectedValue.ToString());
            int ID_institucionEducativaP = Int32.Parse(ID_institucionEducativa.SelectedValue.ToString());
            int anoEstudioP =  Int32.Parse(anoEstudio_txt.Text);
            int ID_lenguaDominanteP = Int32.Parse(ID_lenguaDominante.SelectedValue.ToString());
            int ID_nivelEspanolP = Int32.Parse(ID_nivelEspanol.SelectedValue.ToString());
            int ID_nivelInglesP = Int32.Parse(ID_nivelIngles.SelectedValue.ToString());
            int ID_nivelLSMP = Int32.Parse(ID_nivelLSM.SelectedValue.ToString());
            String descripcionEmpleoP = descripcionEmpleo_txt.Text;
            String nombreCompanyP = compania_txt.Text;
            String correoEmpleoP = correoEmpleo_txt.Text;
            String telefonoEmpleoP = telefonoEmpleo_txt.Text;
            String calleEmpleoP = calleEmpleo_txt.Text;
            Boolean interpretacionLSMP = interpretacionLSM_check.Checked;
            int ID_areaTrabajoP = Int32.Parse(ID_areaTrabajo.SelectedValue.ToString());
            int ID_sueldoP = Int32.Parse(ID_sueldo.SelectedValue.ToString());
            int ID_coloniaEmpleoP = Int32.Parse(ID_coloniaEmpleo.SelectedValue.ToString());
            int ID_perdidaAuditivaP = Int32.Parse(ID_perdidaAuditiva.SelectedValue.ToString());
            Boolean prelinguisticaP = prelinguistica_check.Checked;
            int ID_gradoP = Int32.Parse(ID_grado.SelectedValue.ToString());
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
                                            prelinguisticaP, ID_gradoP, ID_causaP, ID_aparatoAuditivoP, modeloP))
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
            femenino_check.Checked = false;
        }

        private void femenino_check_CheckedChanged(object sender, EventArgs e)
        {
            masculino_check.Checked = false;
        }

        

       



    }
}
