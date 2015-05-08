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
    public partial class Crear_marca : Form
    {
        String nombre_selected;
        int rol;

        public Crear_marca(int rol)
        {
            this.rol = rol;
            InitializeComponent();            
        }

        private void close_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void atras_picture_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
        }

        //Metodo donde se agrega el registro a la base de datos
        private void guardar_btn_Click(object sender, EventArgs e)
        {            
            String mNombre = nombre_txt.Text;
            
            if (Util.executeStoredProcedure("registrarMarca", mNombre))
            {
                MessageBox.Show("La Marca se ha registrado con exito!");
                Util.fillGrid(busqueda_grid, "busquedaEnMarca", "%");
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
            Util.fillGrid(busqueda_grid, "busquedaEnMarca", busqueda);
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
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_pb.Enabled = true; //activacion de botones
                eliminar_pb.Enabled = true;
                nombre_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Marca WHERE ";
                sqlActiveRow += " nombre= '" + nombre_selected + "';";
                Util.showData(this, sqlActiveRow);
            }
            else
            {
                MessageBox.Show("No existe");
            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Seguro quiere eliminar marca:'" + nombre_selected + "'?",
                                    "Confirmación de Eliminar", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarMarca", nombre_selected))
                {
                    MessageBox.Show("La marca:" + nombre_selected + " se elimino con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnMarca", "%");
                }
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombre_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Marca: " + nombre_selected + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarMarca", nombre_selected, nombreNuevo))
                {
                    MessageBox.Show("La marca se modifico con exito");
                    Util.fillGrid(busqueda_grid, "busquedaEnMarca", "%");
                }
            }
        }

        private void Crear_marca_Load(object sender, EventArgs e)
        {
            if (rol == 1)
            {
                imagen.Visible = false;
                Busqueda_grp.Visible = true;
                modificar_pb.Visible = true;
                eliminar_pb.Visible = true;
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
            cerrarSesion_tt.SetToolTip(logout, "Cerrar sesión");
        }

        /*Metodo que guarda un nuevo registro en la Base*/
        private void guardar_pb_Click(object sender, EventArgs e)
        {
            String mNombre = nombre_txt.Text;

            if (Util.executeStoredProcedure("registrarMarca", mNombre))
            {
                MessageBox.Show("La Marca se ha registrado con exito!");
                Util.fillGrid(busqueda_grid, "busquedaEnMarca", "%");
            }
        }

        private void modificar_pb_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombre_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Marca: " + nombre_selected + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarMarca", nombre_selected, nombreNuevo))
                {
                    MessageBox.Show("La marca se modifico con exito");
                    Util.fillGrid(busqueda_grid, "busquedaEnMarca", "%");
                }
            }
        }

        private void eliminar_pb_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Seguro quiere eliminar marca:'" + nombre_selected + "'?",
                                    "Confirmación de Eliminar", MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarMarca", nombre_selected))
                {
                    MessageBox.Show("La marca:" + nombre_selected + " se elimino con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnMarca", "%");
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
            Util.maximizarCualquierIcono(Buscar, new Size(36, 44), 4);
        }

        private void Buscar_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(Buscar, new Size(30, 36), 32, 306);
        }

        private void nuevoRegistro_pb_Click(object sender, EventArgs e)
        {
            Util.clear(this);
        }

        private void nuevoRegistro_pb_MouseHover(object sender, EventArgs e)
        {
            Util.maximizarCualquierIcono(nuevoRegistro_pb, new Size(36, 42), 3);
        }

        private void nuevoRegistro_pb_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarCualquierIcono(nuevoRegistro_pb, new Size(32, 38), 490, 6);
        }

        //Metodo para habilitar el Enter en las busquedas
        private void busqueda_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                buscar();
            }
        }
    }
}
