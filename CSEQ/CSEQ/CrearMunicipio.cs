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
    public partial class CrearMunicipio : Form
    {
        String nombre_selected;
        int mID_estado;
        int rol;

        public CrearMunicipio(int rol)
        {
            this.rol = rol;
            InitializeComponent();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana.mostrarOculta(Ventana.Ventanas.ListaRegistros);
            this.Close();
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

        private void CrearMunicipio_Load(object sender, EventArgs e)
        {
            salir_tt.SetToolTip(x_picture, "Salir de la aplicación");
            cerrarSesion_tt.SetToolTip(logout, "Cerrar sesión");
            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado");

            if (rol == 1)
            {
                imagen.Visible = false;
                Busqueda_grp.Visible = true;
                modificar_btn.Visible = true;
                eliminar_btn.Visible = true;
            }
        }

        //Metodo donde se agrega el registro a la base de datos
        private void guardar_txt_Click(object sender, EventArgs e)
        {
            int mID_estado = Int32.Parse(ID_estado.SelectedValue.ToString());
            String mNombre = nombre_txt.Text; 
            if(mNombre.Length > 0)
                if (Util.executeStoredProcedure("registrarMunicipio", mNombre, mID_estado))
                {
                    MessageBox.Show("El Municipio se ha registrado con exito!");
                    Util.fillGrid(busqueda_grid, "busquedaEnMunicipio", "%");
                }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            busqueda_grid.Visible = true;
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnMunicipio", busqueda);
            
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {            
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_btn.Enabled = true; //Activacion de botones
                eliminar_btn.Enabled = true;
                nombre_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Municipio WHERE ";
                sqlActiveRow += " nombre= '" + nombre_selected + "';";
                Util.showData(this, sqlActiveRow);
                mID_estado = Int32.Parse(ID_estado.SelectedValue.ToString());
            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar municipio: '" + nombre_selected + "'?", "Confirmacion de eliminar",
                                            MessageBoxButtons.YesNo);       
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarMunicipio", nombre_selected, mID_estado))
                {
                    MessageBox.Show("El municipio se elimino con exito");
                    Util.fillGrid(busqueda_grid, "busquedaEnMunicipio", "%");
                }               
            }
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo = nombre_txt.Text;
            int ID_nuevo = Int32.Parse(ID_estado.SelectedValue.ToString());
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar el municipio: " + nombre_selected + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if(nombreNuevo.Length > 0)
                if (respuesta == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Util.executeStoredProcedure("modificarMunicipio", nombre_selected, mID_estado, nombreNuevo,ID_nuevo))
                    {
                        MessageBox.Show("El municipio se modifico con exito");
                        Util.fillGrid(busqueda_grid, "busquedaEnMunicipio", "%");
                    }
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

        private void nombre_txt_TextChanged(object sender, EventArgs e)
        {
            guardar.Enabled = true;
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
