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
    public partial class CrearAparatoAuditivo : Form
    {
        String nombreMarca_selected;
        String tipo_selected;
        int ID_marca_selected;
        int mID_marca;
        int rol;

        public CrearAparatoAuditivo(int rol)
        {
            this.rol = rol;
            InitializeComponent();
        }

        private void x_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Atras_picture_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        private void CrearAparatoAuditivo_Load(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(x_picture, "Salir de la aplicación");
            cerrarSesion_tt.SetToolTip(logout, "Cerrar sesión");
            Util.llenarComboBox(ID_marca, "SELECT ID_marca, nombre FROM Marca");

            if (rol == 1)
            {
                imagen.Visible = false;
                Busqueda_grp.Visible = true;
                modificar_pb.Visible = true;
                eliminar_pb.Visible = true;
            }
        }


        /*********************************************************
         * Metodo que busca en la Tabla un registro dado por el usuario
         * llenando el grid con la tabla obtenida
         * ******************************************************/
        private void buscar()
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Cursor = Cursors.WaitCursor;
            Util.fillGrid(busqueda_grid, "busquedaEnAparatoAuditivo", busqueda);
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
                tipo_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombreMarca_selected = busqueda_grid.Rows[e.RowIndex].Cells[1].Value.ToString();               
                String sqlActiveRow = "SELECT * FROM AparatoAuditivo a, Marca m WHERE ";
                sqlActiveRow += " a.tipo= '" + tipo_selected + "' AND m.nombre= '" + nombreMarca_selected +
                                "' AND a.ID_marca=m.ID_marca;";
                Util.showData(this, sqlActiveRow);

                ID_marca_selected = Int32.Parse(ID_marca.SelectedValue.ToString());
                mID_marca = Int32.Parse(ID_marca.SelectedValue.ToString());
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

        private void Atras_picture_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(Atras_picture);
        }

        private void Atras_picture_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(Atras_picture);
        }

        /*Metodo que guarda un nuevo registro en la Base*/
        private void guardar_pb_Click(object sender, EventArgs e)
        {
            String mTipo = tipo_txt.Text;
            int mID_marca = Int32.Parse(ID_marca.SelectedValue.ToString());

            if (Util.executeStoredProcedure("registrarAparatoAuditivo", mTipo, mID_marca))
            {
                MessageBox.Show("El Aparato Auditivo se ha registrado con exito!");
                Util.fillGrid(busqueda_grid, "busquedaEnAparatoAuditivo", "%");
            }
        }

        /*Metodo que modifica un registro en la Base*/
        private void modificar_pb_Click(object sender, EventArgs e)
        {
            String nombreNuevo = tipo_txt.Text;
            int IDnuevo = Int32.Parse(ID_marca.SelectedValue.ToString());
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Aparato Auditivo: " + nombreMarca_selected + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarAparatoAuditivo", nombreMarca_selected, mID_marca, nombreNuevo, IDnuevo))
                {
                    MessageBox.Show("El Aparato Auditivo se modifico con exito");
                    Util.fillGrid(busqueda_grid, "busquedaEnAparatoAuditivo", "%");
                }
            }
        }

        /*Metodo que elimina un registro elegido de la base*/
        private void eliminar_pb_Click(object sender, EventArgs e)
        {
            String tipo_selected = tipo_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Eliminar '" + tipo_selected + "', marca: " + nombreMarca_selected + "?",
                                        "Confirmación de eliminación", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarAparatoAuditivo", tipo_selected, ID_marca_selected))
                {
                    MessageBox.Show("El aparato: '" + tipo_selected + "' se elimino con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnAparatoAuditivo", "%");
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

        private void Buscar_MouseHover(object sender, EventArgs e)
        {
            Util.maximizarCualquierIcono(Buscar, new Size(38, 44), 4);
        }

        private void Buscar_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(Buscar, new Size(30, 36), 32, 305);
        }

        private void nuevoRegistro_pb_Click(object sender, EventArgs e)
        {
            Util.clear(this);
            Util.llenarComboBox(ID_marca, "SELECT ID_marca, nombre FROM Marca");
        }

        private void nuevoRegistro_pb_MouseHover(object sender, EventArgs e)
        {
            Util.maximizarCualquierIcono(nuevoRegistro_pb, new Size(36, 42), 3);
        }

        private void nuevoRegistro_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(nuevoRegistro_pb, new Size(32, 38), 480, 6);
        }

        //Metodo para habilitar los Enter en las busquedas
        private void busqueda_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                buscar();
            }
        }



    }
}
