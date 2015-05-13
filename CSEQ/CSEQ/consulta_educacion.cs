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
    public partial class consulta_educacion : Form
    {
        int index;
        int rol;
        String query;

        public consulta_educacion(int index, int rol)
        {
            this.index = index;
            this.rol = rol;
            InitializeComponent();            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas salir de la aplicación?", "Mensaje de Confirmación", MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void close_picture_MouseHover(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(close_picture, "Salir de la aplicación");
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

        private void logout_MouseHover(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(logout, "Cerrar sesión");
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            Menu_consultas Menu_principalConsultas = new Menu_consultas(rol);
            Menu_principalConsultas.Show();
            this.Close();
        }

        private void consulta_educacion_Load(object sender, EventArgs e)
        {
            Util.llenarComboBox(ID_censo, "SELECT * FROM Censo");
            if (index == 0){
                titulo.Text = "Comunicación y Lenguaje";
                comunicacion_combo.Visible = true;
            }

            else if (index == 1)
            {
                titulo.Text = "Nivel Educativo y Tipo de Educación";
                nivelEducativo_combo.Visible = true;
            }
            todoscensos_radio.Checked = true;
                
        }

        private void back_picture_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(back_picture);
        }

        private void back_picture_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(back_picture);
        }

        private void nivelEducativo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eleccion_gp.Enabled = true;
            Reporte.Enabled = true;

            if (nivelEducativo_combo.SelectedIndex == 0)
            {
                hanEstudiado_radio.Visible = true;
                noHanEstudiado_radio.Visible = true;
                hanEstudiado_radio.Checked = true;
            }else
            {
                hanEstudiado_radio.Visible = false;
                noHanEstudiado_radio.Visible = false;
            }

           
            if (nivelEducativo_combo.SelectedIndex == 2)
            {
                nivelesEducativos_gp.Visible = true;
            }
            else
            {
                nivelesEducativos_gp.Visible = false;
            }

            if (nivelEducativo_combo.SelectedIndex == 1)
            {
                especial_radio.Visible = true;
                especial_radio.Checked = true;
                normal_radio.Visible = true;
            }
            else
            {
                especial_radio.Visible = false;
                normal_radio.Visible = false;
            }

            if (nivelEducativo_combo.SelectedIndex == 3)
            {
                privada_radio.Visible = true;   
                publica_radio.Visible = true;
                publica_radio.Checked = true;
            }
            else
            {
                privada_radio.Visible = false;
                publica_radio.Visible = false;
            }
            todoscensos_radio.Checked = !todoscensos_radio.Checked;
            todoscensos_radio.Checked = !todoscensos_radio.Checked;

        }

        private void comunicacion_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eleccion_gp.Enabled = true;
            Reporte.Enabled = true;
            todoscensos_radio.Checked = !todoscensos_radio.Checked;
            todoscensos_radio.Checked = !todoscensos_radio.Checked;
        }

        private void ID_censo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            todoscensos_radio.Checked = false;
            String type;
            switch (index)
            {
                case 0:
                    switch (comunicacion_combo.SelectedIndex)
                    {
                        case 0:
                            Reporte.Enabled = true;
                            query = "CALL consultaPorDominioEspanolPorCenso("+ ID_censo.SelectedValue.ToString() +");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;
                        case 1:
                            Reporte.Enabled = true;
                            query = "CALL consultaPorDominioInglesPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;
                        case 2:
                            Reporte.Enabled = true;
                            query = "CALL consultaPorDominioLSMPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;

                    }
                    break;
                case 1:
                    switch (nivelEducativo_combo.SelectedIndex)
                    {
                        case 0:
                            Reporte.Enabled = true;
                            actualizaEstudiado();
                            break;
                        case 1:
                            Reporte.Enabled = true;
                            actualizaEducacionEspecial();
                            break;
                        case 2:
                            Reporte.Enabled = true;
                            query = "CALL consultaPorCadaNivelEducativoPorCenso(" + prescolar_check.Checked.ToString() + "," + primaria_check.Checked.ToString() + "," + secundaria_check.Checked.ToString() + ","
                                    + preparatoria_check.Checked.ToString() + "," + carreraTecnica_check.Checked.ToString() + "," + licenciatura_check.Checked.ToString() + ","
                                    + especialidad_check.Checked.ToString() + "," + maestria_check.Checked.ToString() + "," + doctorado_check.Checked.ToString() + "," + ID_censo.SelectedValue.ToString() + ");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;
                        case 3:
                            Reporte.Enabled = true;
                            publica_radio.Checked = !publica_radio.Checked;
                            publica_radio.Checked = !publica_radio.Checked;
                            break;
                    }
                    break;
            }
            
        }

        private void todoscensos_radio_CheckedChanged(object sender, EventArgs e)
        {
            String type;
            if (todoscensos_radio.Checked)
            {
                switch (index)
                {
                    case 0:
                        switch (comunicacion_combo.SelectedIndex)
                        {
                            case 0:
                                Reporte.Enabled = true;
                                query = "CALL consultaPorDominioEspanol();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                            case 1:
                                Reporte.Enabled = true;
                                query = "CALL consultaPorDominioIngles();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                            case 2:
                                Reporte.Enabled = true;
                                query = "CALL consultaPorDominioLSM();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;

                        }
                        break;
                    case 1:
                        switch (nivelEducativo_combo.SelectedIndex)
                        {
                            case 0:
                                Reporte.Enabled = true;
                                actualizaEstudiado();
                                break;
                            case 1:
                                Reporte.Enabled = true;
                                actualizaEducacionEspecial();
                                break;
                            case 2:
                                Reporte.Enabled = true;
                                query = "CALL consultaPorCadaNivelEducativo(" + prescolar_check.Checked + "," + primaria_check.Checked.ToString() + "," + secundaria_check.Checked.ToString() + ","
                                    + preparatoria_check.Checked.ToString() + "," + carreraTecnica_check.Checked.ToString() + "," + licenciatura_check.Checked.ToString() + ","
                                    + especialidad_check.Checked.ToString() + "," + maestria_check.Checked.ToString() + "," + doctorado_check.Checked.ToString() + ");";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                            case 3:
                                Reporte.Enabled = true;
                                publica_radio.Checked = !publica_radio.Checked;
                                publica_radio.Checked = !publica_radio.Checked;
                                break;
                        }
                        break;
                }
            }
        }

        private void prescolar_check_CheckedChanged(object sender, EventArgs e)
        {
            actuliazaEducacion();
        }

        private void primaria_check_CheckedChanged(object sender, EventArgs e)
        {
            actuliazaEducacion();
        }

        private void secundaria_check_CheckedChanged(object sender, EventArgs e)
        {
            actuliazaEducacion();
        }

        private void preparatoria_check_CheckedChanged(object sender, EventArgs e)
        {
            actuliazaEducacion();
        }

        private void carreraTecnica_check_CheckedChanged(object sender, EventArgs e)
        {
            actuliazaEducacion();
        }

        private void licenciatura_check_CheckedChanged(object sender, EventArgs e)
        {
            actuliazaEducacion();
        }

        private void especialidad_check_CheckedChanged(object sender, EventArgs e)
        {
            actuliazaEducacion();
        }

        private void maestria_check_CheckedChanged(object sender, EventArgs e)
        {
            actuliazaEducacion();
        }

        private void doctorado_check_CheckedChanged(object sender, EventArgs e)
        {
            actuliazaEducacion();
        }

        private void actuliazaEducacion()
        {
            if (todoscensos_radio.Checked)
            {
                query = "CALL consultaPorCadaNivelEducativo(" + prescolar_check.Checked.ToString() + "," + primaria_check.Checked.ToString() + "," + secundaria_check.Checked.ToString() + ","
                                    + preparatoria_check.Checked.ToString() + "," + carreraTecnica_check.Checked.ToString() + "," + licenciatura_check.Checked.ToString() + ","
                                    + especialidad_check.Checked.ToString() + "," + maestria_check.Checked.ToString() + "," + doctorado_check.Checked.ToString() +");";
            }
            else
            {
                query = "CALL consultaPorCadaNivelEducativoPorCenso(" + prescolar_check.Checked.ToString() + "," + primaria_check.Checked.ToString() + "," + secundaria_check.Checked.ToString() + ","
                                    + preparatoria_check.Checked.ToString() + "," + carreraTecnica_check.Checked.ToString() + "," + licenciatura_check.Checked.ToString() + ","
                                    + especialidad_check.Checked.ToString() + "," + maestria_check.Checked.ToString() + "," + doctorado_check.Checked.ToString() + "," + ID_censo.SelectedValue.ToString() + ");";
            }
            Util.graphData(zedGraph, query, "Barra");
        }

        private void privada_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaInstitucion();
        }

        private void publica_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaInstitucion();
        }

        private void actualizaInstitucion()
        {
            if (todoscensos_radio.Checked)
            {
                if (publica_radio.Checked)
                {
                    query = "CALL consultaPersonasInstitucionPublica();";
                }
                if (privada_radio.Checked)
                {
                    query = "CALL consultaPersonasInstitucionPrivada();";
                }
            }
            else
            {
                if (publica_radio.Checked)
                {
                    query = "CALL consultaPersonasInstitucionPublicaPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                }
                if (privada_radio.Checked)
                {
                    query = "CALL consultaPersonasInstitucionPrivadaPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                }
            }

            Util.graphData(zedGraph, query, "Barra");
        }

        private void Reporte_Click(object sender, EventArgs e)
        {
            String periodoRep;
            if (todoscensos_radio.Checked)
            {
                periodoRep = "(Todos los censos)";
            }
            else
            {
                periodoRep = ID_censo.SelectedValue.ToString();
            }
            Util.generaPDF(query, titulo.Text, periodoRep);
        }

        private void hanEstudiado_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaEstudiado();
        }

        private void noHanEstudiado_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaEstudiado();
        }

        private void actualizaEstudiado()
        {
            if (todoscensos_radio.Checked)
            {
                if (hanEstudiado_radio.Checked)
                {
                    query = "CALL consultaConEducacion();";
                }
                if (noHanEstudiado_radio.Checked)
                {
                    query = "CALL consultaSinEducacion();";
                }
            }
            else
            {
                if (hanEstudiado_radio.Checked)
                {
                    query = "CALL consultaConEducacionPorCenso("+ ID_censo.SelectedValue.ToString() +");";
                }
                if (noHanEstudiado_radio.Checked)
                {
                    query = "CALL consultaSinEducacionPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                }
            }
            Util.graphData(zedGraph, query, "Barra");
        }

        private void especial_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaEducacionEspecial();
        }

        private void normal_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaEducacionEspecial();
        }

        private void actualizaEducacionEspecial()
        {
            if (todoscensos_radio.Checked)
            {
                if (especial_radio.Checked)
                {
                    query = "CALL consultaPersonasInstitucionEspecializada();";
                }
                if (normal_radio.Checked)
                {
                    query = "CALL consultaPersonasInstitucionNoEspecializada();";
                }
            }
            else
            {
                
                if (especial_radio.Checked)
                {
                    query = "CALL consultaPersonasInstitucionEspecializadaPorCenso("+ ID_censo.SelectedValue.ToString() +");";
                }
                if (normal_radio.Checked)
                {
                    query = "CALL consultaPersonasInstitucionNoEspecializadaPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                }   
            }

            Util.graphData(zedGraph, query, "Barra");
        }
    }
}
