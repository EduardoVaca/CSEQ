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
    public partial class CrearColonia : Form
    {
        String nombre_selected;
        int idMunicpio;        
        int ID_selected;
        int rol;

        public CrearColonia(int rol)
        {
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

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        private void llenarComboBoxes()
        {
            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado ORDER BY nombre ASC");
            int id_estado = Int32.Parse(ID_estado.SelectedValue.ToString());
            Util.llenarComboBox(ID_municipio, "SELECT m.ID_municipio,m.nombre FROM Municipio m,Estado e WHERE m.ID_estado=e.ID_estado AND e.ID_estado=" + id_estado + " ORDER BY m.nombre ASC;");

        }

        private void CrearColonia_Load(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(pictureBox2, "Salir de la aplicación");
            cerrarSesion_tt.SetToolTip(logout, "Cerrar sesión");
            llenarComboBoxes();

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
                                                "ID_estado = " + valorComboBox + ";");
        }

        /*------------------------------------------------------------------------------------*/


        /*********************************************************
         * Metodo que busca en la Tabla un registro dado por el usuario
         * llenando el grid con la tabla obtenida
         * ******************************************************/
        private void buscar()
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Cursor = Cursors.WaitCursor;
            Util.fillGrid(busqueda_grid, "busquedaEnColonia", busqueda);
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
            Cursor = Cursors.WaitCursor;
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_pb.Enabled = true; //Activacion de botones
                eliminar_pb.Enabled = true;
                nombre_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();                

                String sqlActiveRow = "SELECT DISTINCT * FROM Colonia c, Estado e, Municipio m WHERE ";
                sqlActiveRow += " c.nombre= '" + nombre_selected + "' AND c.ID_municipio=m.ID_municipio AND m.ID_estado=e.ID_estado;";                
                
                Util.showData(this, sqlActiveRow);
                if (ID_municipio.SelectedItem != null)
                {
                    idMunicpio = Int32.Parse(ID_municipio.SelectedValue.ToString());
                    ID_selected = Int32.Parse(ID_municipio.SelectedValue.ToString());
                }
                String valorComboBox = ID_estado.SelectedValue.ToString();
                Util.llenarComboBox(ID_municipio, "SELECT ID_municipio, nombre FROM Municipio WHERE " +
                                                    "ID_estado = " + valorComboBox + ";");
                Util.showData(this, sqlActiveRow);
            }
            Cursor = Cursors.Default;
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

        private void nombre_txt_TextChanged(object sender, EventArgs e)
        {
            guardar_pb.Enabled = true;
        }

        private void Atras_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(Atras);
        }

        private void Atras_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(Atras);
        }

        /*Metodo que guarda un nuevo registro en la Base*/
        private void guardar_pb_Click(object sender, EventArgs e)
        {
            String cNombre = nombre_txt.Text;
            int cID_municipio = Int32.Parse(ID_municipio.SelectedValue.ToString());
            String cDelegacion = delegacion_txt.Text;
            if (cDelegacion == "")
                cDelegacion = "null";

            if (cNombre.Length > 0)
            {
                if (Util.executeStoredProcedure("registrarColonia", cNombre, cID_municipio, cDelegacion))
                {
                    MessageBox.Show("La Colonia se ha registrado con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnColonia", "%");
                }
            }
            else
            {
                MessageBox.Show("No se puede guardar un registro vacío");
            }  
        }

        /*Metodo que modifica un registro en la Base*/
        private void modificar_pb_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombre_txt.Text;
            int ID_nuevo = Int32.Parse(ID_municipio.SelectedValue.ToString());
            String delegacionNuevo = delegacion_txt.Text;
            if (delegacionNuevo == "")
                delegacionNuevo = "null";

            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar la colonia: " + nombre_selected + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (nombreNuevo.Length > 0)
                if (respuesta == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Util.executeStoredProcedure("modificarColonia", nombre_selected, ID_selected, nombreNuevo, ID_nuevo, delegacionNuevo))
                    {
                        MessageBox.Show("La colonia se modifico con exito");
                        Util.fillGrid(busqueda_grid, "busquedaEnColonia", "%");
                    }
                }
        }

        /*Metodo que elimina un registro elegido de la base*/
        private void eliminar_pb_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar colonia:'" + nombre_selected + "'?", "Confirmacion de Eliminar",
                                        MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarColonia", nombre_selected, idMunicpio))
                {
                    MessageBox.Show("La colonia se elimino con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnColonia", "%");
                }
            }
        }

        private void guardar_pb_MouseHover(object sender, EventArgs e)
        {
            Util.maximizarCualquierIcono(guardar_pb, new Size(50, 50), 3);
             //MessageBox.Show(guardar_pb.Size.ToString() + "\n" + guardar_pb.Top.ToString() + "\n" + guardar_pb.Left.ToString());
        }

        private void modificar_pb_MouseHover(object sender, EventArgs e)
        {
            // MessageBox.Show(modificar_pb.Size.ToString() + "\n" + modificar_pb.Top.ToString() + "\n" + modificar_pb.Left.ToString());
            Util.maximizarCualquierIcono(modificar_pb, new Size(38, 50), 3);
        }

        private void eliminar_pb_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show(eliminar_pb.Size.ToString() + "\n" + eliminar_pb.Top.ToString() + "\n" + eliminar_pb.Left.ToString());
            Util.maximizarCualquierIcono(eliminar_pb, new Size(45, 50), 3);
        }

        private void guardar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(guardar_pb, new Size(44, 44), 415, 65);
        }

        private void modificar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(modificar_pb, new Size(34, 44), 415, 176);
        }

        private void eliminar_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(eliminar_pb, new Size(39, 44), 415, 285);
        }

        private void Buscar_MouseHover(object sender, EventArgs e)
        {            
            Util.maximizarCualquierIcono(Buscar, new Size(36, 44), 4);
        }

        private void Buscar_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(Buscar, new Size(30, 36), 32, 305);
        }

        private void nuevoRegistro_pb_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show(nuevoRegistro_pb.Top.ToString() + "left: " + nuevoRegistro_pb.Left.ToString() + "size: " + nuevoRegistro_pb.Size.Height.ToString() + nuevoRegistro_pb.Size.Width.ToString());
            Util.maximizarCualquierIcono(nuevoRegistro_pb, new Size(36, 42), 3);
        }

        private void nuevoRegistro_pb_Click(object sender, EventArgs e)
        {
            Util.clear(this);
            llenarComboBoxes();
        }

        private void nuevoRegistro_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(nuevoRegistro_pb, new Size(32, 38), 483, 6);
        }

        //Metodo que habilita los Enter en las busquedas
        private void busqueda_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                buscar();
            }
        }

    }
}





