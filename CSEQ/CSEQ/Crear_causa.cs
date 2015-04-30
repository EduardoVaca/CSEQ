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
    public partial class Crear_causa : Form
    {
        String causa_selected;
        int rol;

        public Crear_causa(int rol)
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


        private void Buscar_Click(object sender, EventArgs e)
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnCausa", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {            
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_pb.Enabled = true; //Activacion de botones
                eliminar_pb.Enabled = true;
                causa_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Causa WHERE ";
                sqlActiveRow += " causa= '" + causa_selected + "';";
                Util.showData(this, sqlActiveRow);
            }
        }

        private void Crear_causa_Load(object sender, EventArgs e)
        {
            if (rol == 1)
            {
                Busqueda_grp.Visible = true;
                modificar_pb.Visible = true;
                eliminar_pb.Visible = true;
                imagen.Visible = false;
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

        private void guardar_pb_Click(object sender, EventArgs e)
        {
            String cNombre = causa_txt.Text;

            if (Util.executeStoredProcedure("registrarCausa", cNombre))
            {
                MessageBox.Show("La Causa se ha registrado con exito!");
                Util.fillGrid(busqueda_grid, "busquedaEnCausa", "%");
            }
        }

        private void modificar_pb_Click(object sender, EventArgs e)
        {
            String nombreNuevo = causa_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar causa: " + causa_selected + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarCausa", causa_selected, nombreNuevo))
                {
                    MessageBox.Show("La causa se modifico con exito");
                    Util.fillGrid(busqueda_grid, "busquedaEnCausa", "%");
                }
            }
        }

        private void eliminar_pb_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar causa: " + causa_selected + "'?", "Confirmacion de eliminar",
                                        MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarCausa", causa_selected))
                {
                    MessageBox.Show("Se eliminó la causa:" + causa_selected + " con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnCausa", "%");
                }
            }
        }

        private void guardar_pb_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show(guardar_pb.Size.ToString() + "\n" + guardar_pb.Top.ToString() + "\n" + guardar_pb.Left.ToString());
        }

        private void modificar_pb_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show(modificar_pb.Size.ToString() + "\n" + modificar_pb.Top.ToString() + "\n" + modificar_pb.Left.ToString());
        }

        private void eliminar_pb_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show(eliminar_pb.Size.ToString() + "\n" + eliminar_pb.Top.ToString() + "\n" + eliminar_pb.Left.ToString());
        }


    }
}
