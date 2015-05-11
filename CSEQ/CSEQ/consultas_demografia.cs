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
                titulo.Text = "Migración";
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

        private void generales_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eleccion_gp.Enabled = true;
            Reporte.Enabled = true;

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

            if (generales_combo.SelectedIndex == 5)
            {
                empleo_gp.Visible = true;
            }
            else
            {
                empleo_gp.Visible = false;
                areaTrabajo_gp.Visible = false;
            }
            todoscensos_radio.Checked = !todoscensos_radio.Checked;
            todoscensos_radio.Checked = !todoscensos_radio.Checked;

        }

        private void conEmpleo_radio_CheckedChanged(object sender, EventArgs e)
        {
            areaTrabajo_gp.Visible = true;
        }

        private void sinEmpleo_radio_CheckedChanged(object sender, EventArgs e)
        {
            areaTrabajo_gp.Visible = false;
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
            }
        }

        private void conHijos_radio_CheckedChanged(object sender, EventArgs e)
        {
            hijos_gp.Visible = true;
        }

        private void sinHijos_radio_CheckedChanged(object sender, EventArgs e)
        {
            hijos_gp.Visible = false;
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
                                //query = "CALL consultaPorEdad();";
                                type = "Barra";
                                //Util.graphData(zedGraph, query, type);
                                break;
                            case 4:
                                Reporte.Enabled = true;
                                query = "CALL consultaPorLenguaDominante();";
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

                        break;
                    case 2:

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
                query = "CALL consultaGradoPerdidaAuditivaPorLenguaDominante(" + espanol_check.Checked.ToString() + "," + ingles_check.Checked.ToString() + ","
                            + LSM_check.Checked.ToString() + "," + LSEUA_check.Checked.ToString() + ");";
            }
            else
            {
                query = "CALL consultaGradoPerdidaAuditivaPorLenguaDominantePorCenso(" + espanol_check.Checked.ToString() + "," + ingles_check.Checked.ToString() + ","
                            + LSM_check.Checked.ToString() + "," + LSEUA_check.Checked.ToString() + ID_censo.SelectedValue.ToString() + ID_censo.SelectedValue.ToString() + ");";
            }
            Util.graphData(zedGraph, query, "Barra");
        }
    }
}
