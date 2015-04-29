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
    public partial class CrearEstado : Form
    {
        String nombre_selected;        
        int rol;
        String nombre;

        public CrearEstado(int rol)
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

        //Metodo donde se agrega el registro a la base de datos
        private void Guardar_txt_Click(object sender, EventArgs e)
        {            
            String eNombre = nombre_txt.Text;

            if(eNombre.Length > 0)
                if (Util.executeStoredProcedure("registrarEstado", eNombre))
                {
                    MessageBox.Show("El Estado se ha registrado con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnEstado", "%");
                }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnEstado", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {            
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_btn.Enabled = true; //Activacion de botones
                eliminar_btn.Enabled = true;
                nombre_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Estado WHERE ";
                sqlActiveRow += " nombre= '" + nombre_selected + "';";
                Util.showData(this, sqlActiveRow);  
            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Desea eliminar el estado: '" + nombre_selected + "'?", "Confirmacion de eliminar",
                                        MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarEstado", nombre_selected))
                {
                    MessageBox.Show("El estado se elimino con exito");
                    Util.fillGrid(busqueda_grid, "busquedaEnEstado", "%");
                }
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombre_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Estado: " + nombre + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarEstado", nombre, nombreNuevo))
                {
                    MessageBox.Show("El estado se modifico con exito");
                    Util.fillGrid(busqueda_grid, "busquedaEnEstado", "%");
                }
            }
        }

        private void CrearEstado_Load(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(x_picture, "Salir de la aplicación");
            cerrarSesion_tt.SetToolTip(logout, "Cerrar sesión");
            if (rol == 1)
            {
                imagen.Visible = false;
                Busqueda_grp.Visible = true;
                modificar_btn.Visible = true;
                eliminar_btn.Visible = true;
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

        private void Atras_picture_MouseHover(object sender, EventArgs e)
        {
            Util.agrandarIconoAtras(Atras_picture);
        }

        private void Atras_picture_MouseLeave(object sender, EventArgs e)
        {
            Util.minimizarIconoAtras(Atras_picture);
        }
    }
}
