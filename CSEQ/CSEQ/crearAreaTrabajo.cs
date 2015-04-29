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
    public partial class crearAreaTrabajo : Form
    {
        String nombre_selected;
        int rol;

        public crearAreaTrabajo(int rol)
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

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            String aNombre = nombreArea_txt.Text;

            if (Util.executeStoredProcedure("registrarAreaTrabajo", aNombre))
            {
                MessageBox.Show("Area de Trabajo se guardo con exito!");
                Util.fillGrid(busqueda_grid, "busquedaEnAreaTrabajo", "%");
            }
        }
        

        private void Buscar_Click(object sender, EventArgs e)
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnAreaTrabajo", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {            
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_btn.Enabled = true; //Activacion de botones
                eliminar_btn.Enabled = true;
                nombre_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM AreaTrabajo WHERE ";
                sqlActiveRow += " nombre= '" + nombre_selected + "';";
                Util.showData(this, sqlActiveRow);
            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar area: '" + nombre_selected + "'?", "Confirmacion de Eliminar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarAreaTrabajo", nombre_selected))
                {
                    MessageBox.Show("El Area de Trabajo se ha elimnado con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnAreaTrabajo", "%");
                }
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombreArea_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Area de trabajo: " + nombre_selected + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarAreaTrabajo", nombre_selected, nombreNuevo))
                {
                    MessageBox.Show("El area de trabajo se modifico con exito");
                    Util.fillGrid(busqueda_grid, "busquedaEnAreaTrabajo", "%");
                }
            }
        }

        private void crearAreaTrabajo_Load(object sender, EventArgs e)
        {
            if (rol == 1)
            {
                imagen.Visible = false;
                Busqueda_grp.Visible = true;
                eliminar_btn.Visible = true;
                modificar_btn.Visible = true;
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
    }
}
