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
    public partial class consultas_demografia : Form
    {
        int index;
        int rol;
        String query;

        public consultas_demografia(int index, int rol)
        {
            this.index = index;
            this.rol = rol;
            InitializeComponent();
            todoscensos_radio.Checked = true;
        }

        private void consultas_demografia_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(logout, "Cerrar Sesión");
            toolTip.SetToolTip(close_picture, "Salir");
            Util.llenarComboBox(ID_censo, "SELECT * FROM Censo");            
            if (index == 0){
                titulo.Text = "Estadísticas Generales";
                generales_combo.Visible = true;
            }
                
            else if (index == 1){
                titulo.Text = "Estado Civil y Familia";
                estadoCivil_combo.Visible = true;
            }
            else if (index == 2)
            {
                titulo.Text = "Migración";
                migracion_combo.Visible = true;
            }
                
        }

        private void close_picture_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas salir de la aplicación?", "Mensaje de Confirmación", MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
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

        private void back_picture_Click(object sender, EventArgs e)
        {
            Menu_consultas Menu_principalConsultas = new Menu_consultas(rol);
            Menu_principalConsultas.Show();
            this.Close();
        }

        private void back_picture_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(back_picture);
        }

        private void back_picture_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(back_picture);
        }

        private void migracion_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eleccion_gp.Enabled = true;
            Reporte.Enabled = true;
            todoscensos_radio.Checked = true;
            todoscensos_radio.Checked = !todoscensos_radio.Checked;
            todoscensos_radio.Checked = !todoscensos_radio.Checked;

        }

        private void generales_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eleccion_gp.Enabled = true;
            Reporte.Enabled = true;
            todoscensos_radio.Checked = true;
            if (generales_combo.SelectedIndex == 3)
            {
                edades_gp.Visible = true;
            }
            else
            {
                edades_gp.Visible = false;
            }
            

            if (generales_combo.SelectedIndex == 4)
            {
                lenguaDom_gp.Visible = true;
            }
            else
            {
                lenguaDom_gp.Visible = false;
            }

            if (generales_combo.SelectedIndex == 6)
            {
                label2.Visible = false;
                ID_censo.Visible = false;
            }
            else
            {
                ID_censo.Visible = true;
                label2.Visible = true;
            }
            if (generales_combo.SelectedIndex == 3)
            {
                ninos_radio.Checked = true;
            }
            todoscensos_radio.Checked = !todoscensos_radio.Checked;
            todoscensos_radio.Checked = !todoscensos_radio.Checked;

        }


        private void estadoCivil_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eleccion_gp.Enabled = true;
            Reporte.Enabled = true;

            if (estadoCivil_combo.SelectedIndex == 0)
            {
                estadoCivil_gp.Visible = true;
            }
            else
            {
                estadoCivil_gp.Visible = false;
            }

            if (estadoCivil_combo.SelectedIndex == 1)
            {
                conHijos_radio.Visible = true;
                sinHijos_radio.Visible = true;
                conHijos_radio.Checked = true;
                hijos_sordos_radio.Checked = true;
            }
            todoscensos_radio.Checked = !todoscensos_radio.Checked;
            todoscensos_radio.Checked = !todoscensos_radio.Checked;
        }

        private void conHijos_radio_CheckedChanged(object sender, EventArgs e)
        {
            
            if (conHijos_radio.Checked)
            {
                hijos_gp.Visible = true;
                hijos_sordos_radio.Visible = true;
                hijos_noSordos_radio.Visible = true;

            }
            
        }

        private void sinHijos_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (sinHijos_radio.Checked)
            {
                hijos_gp.Visible = false;
            }
            actualizaHijos();
        }

        private void ID_censo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            todoscensos_radio.Checked = false;
            String type;
            switch (index)
            {
                case 0:
                    switch (generales_combo.SelectedIndex)
                    {
                        case 0:
                            Reporte.Enabled = true;
                            query = "CALL consultaPorEstadoPorCenso("+ID_censo.SelectedValue.ToString()+");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;
                        case 1:
                            Reporte.Enabled = true;
                            query = "CALL consultaPorMunicipioPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;
                        case 2:
                            Reporte.Enabled = true;
                            query = "CALL consultaHombresMujeresPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;
                        case 3:
                            Reporte.Enabled = true;
                            actualizaEdades();
                            break;
                        case 4:
                            Reporte.Enabled = true;
                            query = "CALL consultaPorCadaLenguaDominantePorCenso(" + espanol_check.Checked.ToString() + "," + ingles_check.Checked.ToString() + ","
                            + LSM_check.Checked.ToString() + "," + LSEUA_check.Checked.ToString() + "," + ID_censo.SelectedValue.ToString() + ");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;
                        case 5:
                            Reporte.Enabled = true;
                            query = "CALL consultaTienenEmpleoPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;
                        case 6:
                            Reporte.Enabled = true;
                            query = "CALL consultaPersonasPorCensoPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;
                    }
                    break;
                case 1:
                    switch (estadoCivil_combo.SelectedIndex)
                    {
                        case 0:
                            Reporte.Enabled = true;
                            query = "CALL consultaPorCadaEstadoCivilPorCenso(" + soltero_check.Checked + "," + casado_check.Checked + "," + divorciado_check.Checked + "," + viudo_check.Checked + "," + ID_censo.SelectedValue.ToString() + ")";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;
                        case 1:
                            Reporte.Enabled = true;
                            actualizaHijos();
                            break;
                    }
                    break;
                case 2:
                    switch (migracion_combo.SelectedIndex)
                    {
                        case 0:
                            Reporte.Enabled = true;
                            query = "CALL consultaOtrosEstadosPorCenso("+ ID_censo.SelectedValue.ToString() +");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;
                        case 1:
                            Reporte.Enabled = true;
                            query = "CALL consultaExtranjerosPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
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
                        switch(generales_combo.SelectedIndex){
                            case 0:
                                Reporte.Enabled = true;
                                query = "CALL consultaPorEstado();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                            case 1:
                                Reporte.Enabled = true;
                                query = "CALL consultaPorMunicipio();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                            case 2:
                                Reporte.Enabled = true;
                                query = "CALL consultaHombresMujeres();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                            case 3:
                                Reporte.Enabled = true;
                                actualizaEdades();
                                break;
                            case 4:
                                Reporte.Enabled = true;
                                query = "CALL consultaPorCadaLenguaDominante(" + espanol_check.Checked.ToString() + "," + ingles_check.Checked.ToString() + "," + LSM_check.Checked.ToString() + ","
                                         + LSEUA_check.Checked.ToString() + ");";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                            case 5:
                                Reporte.Enabled = true;
                                query = "CALL consultaTienenEmpleo();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                            case 6:
                                Reporte.Enabled = true;
                                query = "CALL consultaPersonasPorCenso();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                        }
                        break;  
                    case 1:
                        switch (estadoCivil_combo.SelectedIndex)
                        {
                            case 0:
                                Reporte.Enabled = true;
                                query = "CALL consultaPorCadaEstadoCivil(" + soltero_check.Checked + "," + casado_check.Checked + "," + divorciado_check.Checked + "," + viudo_check.Checked + ");";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                            case 1:
                                Reporte.Enabled = true;
                                query = "CALL consultaHijos();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                        }
                        break;
                    case 2:
                        switch (migracion_combo.SelectedIndex)
                        {
                            case 0:
                                Reporte.Enabled = true;
                                query = "CALL consultaOtrosEstados();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                            case 1:
                                Reporte.Enabled = true;
                                query = "CALL consultaExtranjeros();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                        }
                        break;
                }
            }
            
        }

        private void espanol_check_CheckedChanged(object sender, EventArgs e)
        {
            actilizaLenguajes();
        }

        private void ingles_check_CheckedChanged(object sender, EventArgs e)
        {
            actilizaLenguajes();
        }

        private void LSM_check_CheckedChanged(object sender, EventArgs e)
        {
            actilizaLenguajes();
        }

        private void LSEUA_check_CheckedChanged(object sender, EventArgs e)
        {
            actilizaLenguajes();
        }


        private void actilizaLenguajes()
        {
            if (todoscensos_radio.Checked)
            {
                query = "CALL consultaPorCadaLenguaDominante(" + espanol_check.Checked.ToString() + "," + ingles_check.Checked.ToString() + ","
                            + LSM_check.Checked.ToString() + "," + LSEUA_check.Checked.ToString() + ");";
            }
            else
            {
                query = "CALL consultaPorCadaLenguaDominantePorCenso(" + espanol_check.Checked.ToString() + "," + ingles_check.Checked.ToString() + ","
                            + LSM_check.Checked.ToString() + "," + LSEUA_check.Checked.ToString()+ "," + ID_censo.SelectedValue.ToString() + ");";
            }
            Util.graphData(zedGraph, query, "Barra");
        }

        private void soltero_check_CheckedChanged(object sender, EventArgs e)
        {
            actualizaCivil();
        }

        private void casado_check_CheckedChanged(object sender, EventArgs e)
        {
            actualizaCivil();
        }

        private void divorciado_check_CheckedChanged(object sender, EventArgs e)
        {
            actualizaCivil();
        }

        private void viudo_check_CheckedChanged(object sender, EventArgs e)
        {
            actualizaCivil();
        }

        private void actualizaCivil()
        {
            if (todoscensos_radio.Checked)
            {
                query = "CALL consultaPorCadaEstadoCivil(" + soltero_check.Checked + "," + casado_check.Checked + "," + divorciado_check.Checked + "," + viudo_check.Checked + ")";
            }
            else
            {
                query = "CALL consultaPorCadaEstadoCivilPorCenso(" + soltero_check.Checked + "," + casado_check.Checked + "," + divorciado_check.Checked + "," + viudo_check.Checked + "," + ID_censo.SelectedValue.ToString() + ");";
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

        private void ninos_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaEdades();
        }

        private void adolescentes_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaEdades();
        }

        private void adulto_mayor_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaEdades();
        }

        private void adultoMayor_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaEdades();
        }

        private void anciano_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaEdades();
        }

        private void actualizaEdades()
        {
            if (todoscensos_radio.Checked)
            {
                if (ninos_radio.Checked)
                {
                    query = "CALL consultaEdadNinos();";
                }
                if (adolescentes_radio.Checked)
                {
                    query = "CALL consultaEdadAdolescentes();";
                }
                if (adulto_mayor_radio.Checked)
                {
                    query = "CALL consultaEdadAdultosJovenes();";
                }
                if (adultoMayor_radio.Checked)
                {
                    query = "CALL consultaEdadAdultosMayores();";
                }
                if (anciano_radio.Checked)
                {
                    query = "CALL consultaEdadAncianos();";
                }
            }
            else
            {
                if (ninos_radio.Checked)
                {
                    query = "CALL consultaEdadNinosPorCenso("+ ID_censo.SelectedValue.ToString() +");";
                }
                if (adolescentes_radio.Checked)
                {
                    query = "CALL consultaEdadAdolescentesPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                }
                if (adulto_mayor_radio.Checked)
                {
                    query = "CALL consultaEdadAdultosJovenesPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                }
                if (adultoMayor_radio.Checked)
                {
                    query = "CALL consultaEdadAdultosMayoresPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                }
                if (anciano_radio.Checked)
                {
                    query = "CALL consultaEdadAncianosPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                }
            }

            Util.graphData(zedGraph, query, "Barra");
        }


        private void actualizaHijos()
        {
            if (todoscensos_radio.Checked)
            {
                if (conHijos_radio.Checked)
                {
                    if (hijos_sordos_radio.Checked)
                    {
                        query = "CALL consultaConHijosSordos();";
                    }
                    else
                    {
                        query = "CALL consultaConHijosNoSordos();";
                    }
                }
                if (sinHijos_radio.Checked)
                {
                    query = "CALL consultaSinHijos();";
                }
            }
            else
            {
                if (conHijos_radio.Checked)
                {
                    if (hijos_sordos_radio.Checked)
                    {
                        query = "CALL consultaConHijosSordosPorCenso("+ ID_censo.SelectedValue.ToString() +");";
                    }
                    else
                    {
                        query = "CALL consultaConHijosNoSordosPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                    }
                }
                if (sinHijos_radio.Checked)
                {
                    query = "CALL consultaSinHijosPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                }
            }

            Util.graphData(zedGraph, query, "Barra");
            
        }

        private void hijos_noSordos_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaHijos();
        }

        private void hijos_sordos_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaHijos();
        }

    }
}
