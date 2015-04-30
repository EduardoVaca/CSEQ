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

    public partial class Crear_delegacion : Form
    {
        String delegacion_selected;
        int dID_municipio;                
        int ID_selected;
        int rol;
        String municipio;
        String delegacion;

        public Crear_delegacion(int rol)
        {
            this.rol = rol;
            InitializeComponent();            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void atras_picture_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        private void Crear_delegacion_Load(object sender, EventArgs e)
        {

            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado");
            int id_estado = 22;
            ID_estado.SelectedIndex = id_estado - 1;
            Util.llenarComboBox(ID_municipio, "SELECT m.ID_municipio,m.nombre FROM Municipio m,Estado e WHERE m.ID_estado=e.ID_estado AND e.ID_estado=" + id_estado + ";");

            if (rol == 1)
            {
                imagen.Visible = false;
                Busqueda_grp.Visible = true;
                modificar_pb.Visible = true;
                eliminar_pb.Visible = true;
            }
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

        /*-----------------------------------------------------------------------------------*/

        private void Buscar_Click(object sender, EventArgs e)
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnDelegacion", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_pb.Enabled = true; //Activacion de botones
                eliminar_pb.Enabled = true;
                delegacion_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                municipio = busqueda_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Delegacion d, Municipio m WHERE ";
                sqlActiveRow += " d.nombre= '" + delegacion_selected +"' AND m.nombre='" + municipio +"' AND d.ID_municipio=m.ID_municipio;";
                Util.showData(this, sqlActiveRow);
                dID_municipio = Int32.Parse(ID_municipio.SelectedValue.ToString());
                ID_selected = Int32.Parse(ID_estado.SelectedValue.ToString());
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

        private void atras_picture_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(atras_picture);
        }

        private void atras_picture_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(atras_picture);
        }

        private void close_picture_MouseHover(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(close_picture, "Salir de la aplicación");
        }

        private void logout_MouseHover(object sender, EventArgs e)
        {
            cerrarSesion_tt.SetToolTip(logout, "Cerrar Sesión");
        }

        private void guardar_pb_Click(object sender, EventArgs e)
        {
            String dNombre = nombre_txt.Text;
            int dID_municipio = Int32.Parse(ID_municipio.SelectedValue.ToString());

            if (Util.executeStoredProcedure("registrarDelegacion", dNombre, dID_municipio))
            {
                MessageBox.Show("La Delegacion se ha registrado con exito!");
                Util.fillGrid(busqueda_grid, "busquedaEnDelegacion", "%");
            }
        }

        private void modificar_pb_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombre_txt.Text;
            String municipioNuevo = ID_municipio.SelectedValue.ToString();
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar la delegacion: " + delegacion + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarDelegacion", delegacion, municipio, nombreNuevo, municipioNuevo))
                {
                    MessageBox.Show("La delegacion se modifico con exito");
                    Util.fillGrid(busqueda_grid, "busquedaEnDelegacion", "%");
                }
            }
        }

        private void eliminar_pb_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar delegacion:" + delegacion_selected + "'?",
                                                "Confirmacion de eliminar", MessageBoxButtons.YesNo);


            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarDelegacion", delegacion_selected, dID_municipio))
                {
                    MessageBox.Show("La delegacion se elimino con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnDelegacion", "%");
                }
            }
        }

        private void guardar_pb_MouseHover(object sender, EventArgs e)
        {
            Util.maximizarCualquierIcono(guardar_pb, new Size(50, 53), 3);
        }

        private void modificar_pb_MouseHover(object sender, EventArgs e)
        {
            Util.maximizarCualquierIcono(modificar_pb, new Size(42, 54), 3);
        }

        private void eliminar_pb_MouseHover(object sender, EventArgs e)
        {
            Util.maximizarCualquierIcono(eliminar_pb, new Size(46, 54), 3);
        }

        private void guardar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(guardar_pb, new Size(44, 47), 362, 62);
        }

        private void modificar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(modificar_pb, new Size(36, 48), 362, 182);
        }

        private void eliminar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(eliminar_pb, new Size(40, 48), 362, 294);
        }

    }
}
