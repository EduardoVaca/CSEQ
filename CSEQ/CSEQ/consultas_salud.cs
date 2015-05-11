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
    public partial class consultas_salud : Form
    {
        int index;
        int indexReporte;
        String query;
        int salida=1;
        int rol;
        //salida =1 Genera reporte de todos los censos
        //salida =2 Genera reporte de censo por año

        public consultas_salud(int index, int rol)
        {
            this.index = index;
            this.rol=rol;
            InitializeComponent();
            todoscensos_radio.Checked = true;
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas salir de la aplicación?", "Mensaje de Confirmación", MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void back_picture_Click(object sender, EventArgs e)
        {
            Menu_consultas Menu_principalConsultas = new Menu_consultas(rol);
            Menu_principalConsultas.Show();
            this.Close();
        }

        private void consultas_salud_Load(object sender, EventArgs e)
        {            
            if (index == 0)
            {
                titulo.Text = "Auxiliares Auditivos";                
                auxiliarAuditivo_combo.Visible = true;
            }
            if (index == 1)
            {
                titulo.Text = "Estado de Salud";
                estadoSalud_combo.Visible = true;
            }
            if (index == 2)
            {
                titulo.Text = "Tipología de Pérdida Auditiva";
                tipologia_combo.Visible = true;
            }

            Util.llenarComboBox(ID_censo, "SELECT * FROM Censo");
        }

        private void auxiliarAuditivo_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ID_censo.Enabled = true;
            todoscensos_radio.Enabled = true;
            indexReporte = auxiliarAuditivo_combo.SelectedIndex;
            tienen_radio.Visible = false;
            noTienen_radio.Visible = false;
            tienen_radio.Checked = tienen_radio.Visible;
            noTienen_radio.Checked = tienen_radio.Visible;
            switch(auxiliarAuditivo_combo.SelectedIndex){
                case 1:
                    tienen_radio.Visible = true;
                    tienen_radio.Checked = true;
                    noTienen_radio.Visible = true;
                    break;
                case 2:
                    break;
            }
            todoscensos_radio.Checked = false;
            todoscensos_radio.Checked = true;
        }

        private void estadoSalud_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ID_censo.Enabled = true;
            todoscensos_radio.Enabled = true;
            indexReporte = auxiliarAuditivo_combo.SelectedIndex;            
            todoscensos_radio.Checked = true;
        }

        private void todoscensos_radio_CheckedChanged(object sender, EventArgs e)
        {
            String type;
            if (index == 0)
            {
                switch (auxiliarAuditivo_combo.SelectedIndex)
                {
                    case 0:
                        Reporte.Enabled = true;
                        salida = 1;
                        query = "CALL consultaMarca();";
                        type = "Barra";
                        indexReporte = 0;
                        Util.graphData(zedGraph, query, type);
                        break;
                    case 1:
                        Reporte.Enabled = true;
                        salida = 1;
                        if (tienen_radio.Checked)
                            query = " CALL consultaSiTienenAuxiliar();";
                        if (noTienen_radio.Checked)
                            query = " CALL consultaNoTienenAuxiliar();";
                        type = "Barra";
                        indexReporte = 1;
                        Util.graphData(zedGraph, query, type);
                        break;
                    case 2:
                        Reporte.Enabled = true;
                        salida = 1;
                        query = " Call consultaTienenImplanteCoclear();";
                        type = "Pay";
                        indexReporte = 2;
                        Util.graphData(zedGraph, query, type);
                        break;
                }
                
            }
            if (index == 1)
            {
                switch (this.estadoSalud_combo.SelectedIndex)
                {
                    case 0:
                        Reporte.Enabled = true;
                        salida = 1;
                        query = "CALL consultaTienenAlergia();";
                        type = "Barra";
                        indexReporte = 0;
                        Util.graphData(zedGraph, query, type);
                        break;
                    case 1:
                        Reporte.Enabled = true;
                        salida = 1;
                        query = "CALL consultaTienenEnfermedad();";
                        type = "Barra";
                        indexReporte = 1;
                        Util.graphData(zedGraph, query, type);
                        break;
                   
                }
            }
            
        }

        private void ID_censo_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            int id_censo = Int32.Parse(ID_censo.SelectedValue.ToString());

            Reporte.Enabled = true;
            todoscensos_radio.Checked = false;
            String type;
            if(index==0){
                switch (auxiliarAuditivo_combo.SelectedIndex)
                {
                    case 0:
                        query = "CALL consultaMarcaPorCenso(" + id_censo + ");";
                        type = "Barra";
                        salida = 2;
                        indexReporte = 0;
                        Util.graphData(zedGraph, query, type);
                        break;
                    case 1:
                        if (tienen_radio.Checked)
                            query = " CALL consultaSiTienenAuxiliarPorCenso(" + id_censo + ");";
                        if (noTienen_radio.Checked)
                            query = " CALL consultaNoTienenAuxiliarPorCenso(" + id_censo + ");";
                        type = "Barra";
                        salida = 2;
                        indexReporte = 1;
                        Util.graphData(zedGraph, query, type);
                        break;
                    case 2:
                        query = " CALL consultaTienenImplanteCoclearPorCenso(" + id_censo + ");";
                        type = "Pay";
                        salida = 2;
                        indexReporte = 2;
                        Util.graphData(zedGraph, query, type);
                        break;
                    case 3:

                        break;
                    default:

                        break;
                }
            }
            if (index == 1)
            {
                switch (estadoSalud_combo.SelectedIndex)
                {
                    case 0:
                        salida = 2;
                        query = "CALL consultaTienenAlergiaPorCenso(" +id_censo+");";
                        type = "Barra";
                        indexReporte = 0;
                        Util.graphData(zedGraph, query, type);
                        break;
                    case 1:
                        query = "CALL consultaTienenEnfermedadPorCenso(" + id_censo + ");";
                        type = "Barra";
                        salida = 2;
                        indexReporte = 1;
                        Util.graphData(zedGraph, query, type);
                        break;
                    
                    default:

                        break;
                }
            }
            
        }

        private void Reporte_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("query:" + query + "-" + "index:" + index + "-" + "reporte:" + indexReporte + "-" + salida);
            Util.generaPDF(query);
            
            
        }

        private int getId_censo()
        {
            return Int32.Parse(ID_censo.SelectedValue.ToString());
        }

        private void tienen_radio_CheckedChanged(object sender, EventArgs e)
        {
            if(todoscensos_radio.Checked && tienen_radio.Checked){
                String type;
                query = "CALL consultaSiTienenAuxiliar();";
                type = "Barra";
                indexReporte = 1;
                Util.graphData(zedGraph, query, type);
            }
            else if(tienen_radio.Checked)
            {
                String type;
                query = " CALL consultaSiTienenAuxiliarPorCenso(" + getId_censo() + ");";
                type = "Barra";
                indexReporte = 1;
                Util.graphData(zedGraph, query, type);
            }
            
        }

        private void noTienen_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (todoscensos_radio.Checked && noTienen_radio.Checked)
            {
                 String type;
                query = "CALL consultaNoTienenAuxiliar();";
                type = "Barra";
                indexReporte = 1;
                Util.graphData(zedGraph, query, type);
            }
            else if(noTienen_radio.Checked)
            {
                String type;
                query = " CALL consultaNoTienenAuxiliarPorCenso(" + getId_censo() + ");";
                type = "Barra";
                indexReporte = 1;
                Util.graphData(zedGraph, query, type);
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

        private void back_picture_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(back_picture);
        }

        private void back_picture_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(back_picture);
        }

        private void x_picture_MouseHover(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(x_picture, "Salir de la aplicación");
        }

        private void logout_MouseHover(object sender, EventArgs e)
        {
            cerrarSesion_tt.SetToolTip(logout, "Cerrar sesión");
        }

        private void tipologia_combo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ID_censo.Enabled = true;
            todoscensos_radio.Enabled = true;
            indexReporte = tipologia_combo.SelectedIndex;
            Reporte.Enabled = true;
            if (tipologia_combo.SelectedIndex == 0)
            {
                gradoPerdida_gp.Visible = true;
            }
            else
            {
                gradoPerdida_gp.Visible = false;
            }
            if (tipologia_combo.SelectedIndex == 1)
            {
                unilateral_radio.Visible = true;
                bilateral_radio.Visible = true;
            }
            else
            {
                unilateral_radio.Visible = false;
                bilateral_radio.Visible = false;
            }
            if (tipologia_combo.SelectedIndex == 3)
            {
                tipoPerdida_gp.Visible = true;
            }
            else
            {
                tipoPerdida_gp.Visible = false;
            }
            if (tipologia_combo.SelectedIndex == 4)
            {
                prelingual_radio.Visible = true;
                postlingual_radio.Visible = true;
            }
            else
            {
                prelingual_radio.Visible = false;
                postlingual_radio.Visible = false;
            }
        }
    }
}
