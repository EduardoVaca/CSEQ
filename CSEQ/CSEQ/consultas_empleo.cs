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
    public partial class consultas_empleo : Form
    {

        int index;
        int rol;
        String query;

        public consultas_empleo(int index, int rol)
        {
            this.index = index;
            this.rol = rol;
            InitializeComponent();
        }

        private void consultas_empleo_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(close_picture, "Salir");
            toolTip.SetToolTip(logout, "Cerrar Sesión");
            Util.llenarComboBox(ID_censo, "SELECT * FROM Censo");
            if (index == 0)
                titulo.Text = "Estadísticas Generales";
            generales_combo.Visible = true;
            todoscensos_radio.Checked = true;
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
            todoscensos_radio.Checked = !todoscensos_radio.Checked;
            todoscensos_radio.Checked = !todoscensos_radio.Checked;

            if (generales_combo.SelectedIndex == 0)
            {
                conEmpleo_radio.Visible = true;
                sinEmpleo_radio.Visible = true;
                conEmpleo_radio.Checked = true;
            }
            else
            {
                conEmpleo_radio.Visible = false;
                sinEmpleo_radio.Visible = false;
                areaTrabajo_gp.Visible = false;
            }
        }

        private void conEmpleo_radio_CheckedChanged(object sender, EventArgs e)
        {
            areaTrabajo_gp.Visible = true;
            areaTrabajo_radio.Checked = true;
            actualizaEmpleo();
        }

        private void sinEmpleo_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (sinEmpleo_radio.Checked)
            {
                areaTrabajo_gp.Visible = false;
            }
            
            actualizaEmpleo();
        }

        private void actualizaEmpleo()
        {
            if (todoscensos_radio.Checked)
            {
                if (conEmpleo_radio.Checked)
                {
                    if (areaTrabajo_radio.Checked)
                    {
                        query = "CALL consultaEmpleadosPorAreaTrabajo();";
                    }
                    else
                    {
                        query = "CALL consultaEmpleados()";
                    }
                }
                else
                {
                    query = "CALL consultaDesempleados()";
                }
            }
            else
            {
                if (conEmpleo_radio.Checked)
                {
                    if (areaTrabajo_radio.Checked)
                    {
                        query = "CALL consultaEmpleadosPorAreaTrabajoPorCenso("+ID_censo.SelectedValue.ToString()+");";
                    }
                    else
                    {
                        query = "CALL consultaEmpleadosPorCenso(" + ID_censo.SelectedValue.ToString() + ")";
                    }
                }
                else
                {
                    query = "CALL consultaDesempleadosPorCenso(" + ID_censo.SelectedValue.ToString() + ")";
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

        private void todoscensos_radio_CheckedChanged(object sender, EventArgs e)
        {
            String type;
            if (todoscensos_radio.Checked)
            {
                switch (index)
                {
                    case 0:
                        switch (generales_combo.SelectedIndex)
                        {
                            case 0:
                                Reporte.Enabled = true;
                                actualizaEmpleo();
                                break;
                            case 1:
                                Reporte.Enabled = true;
                                query = "CALL consultaIngresosPersonasEmpleadas();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;
                            case 2:
                                Reporte.Enabled = true;
                                query = "CALL consultaEmpleoInterpretacionLSM();";
                                type = "Barra";
                                Util.graphData(zedGraph, query, type);
                                break;

                        }
                        break;
                }
            }
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
                            actualizaEmpleo();
                            break;
                        case 1:
                            Reporte.Enabled = true;
                            query = "CALL consultaIngresosPersonasEmpleadasPorCenso("+ID_censo.SelectedValue.ToString()+");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;
                        case 2:
                            Reporte.Enabled = true;
                            query = "CALL consultaEmpleoInterpretacionLSMPorCenso(" + ID_censo.SelectedValue.ToString() + ");";
                            type = "Barra";
                            Util.graphData(zedGraph, query, type);
                            break;

                    }
                    break;
            }
        }

        private void areaTrabajo_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaEmpleo();
        }

        private void todaslasAreas_radio_CheckedChanged(object sender, EventArgs e)
        {
            actualizaEmpleo();
        }
    }
}
