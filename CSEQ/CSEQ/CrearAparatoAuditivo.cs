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
            Util.llenarComboBox(ID_marca, "SELECT ID_marca, nombre FROM Marca");

            if (rol == 1)
            {
                Busqueda_grp.Visible = true;
                modificar_btn.Visible = true;
                eliminar_btn.Visible = true;
            }
        }

        //Metodo donde se agrega el registro a la base de datos
        private void Guardar_txt_Click(object sender, EventArgs e)
        {            
            String mTipo = tipo_txt.Text;
            int mID_marca = Int32.Parse(ID_marca.SelectedValue.ToString());
            
            if (Util.executeStoredProcedure("registrarAparatoAuditivo", mTipo, mID_marca))
            {
                MessageBox.Show("El Aparato Auditivo se ha registrado con exito!");
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnAparatoAuditivo", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {                
                modificar_btn.Enabled = true; //Activacion de botones
                eliminar_btn.Enabled = true;
                tipo_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombreMarca_selected = busqueda_grid.Rows[e.RowIndex].Cells[1].Value.ToString();               
                String sqlActiveRow = "SELECT * FROM AparatoAuditivo a, Marca m WHERE ";
                sqlActiveRow += " a.tipo= '" + tipo_selected + "' AND m.nombre= '" + nombreMarca_selected +
                                "' AND a.ID_marca=m.ID_marca;";
                Util.showData(this, sqlActiveRow);

                ID_marca_selected = Int32.Parse(ID_marca.SelectedValue.ToString());
                mID_marca = Int32.Parse(ID_marca.SelectedValue.ToString());
            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
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
                }
            }           
        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo = tipo_txt.Text;
            int IDnuevo=Int32.Parse(ID_marca.SelectedValue.ToString());
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar Aparato Auditivo: " + nombreMarca_selected + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarAparatoAuditivo", nombreMarca_selected,mID_marca, nombreNuevo,IDnuevo))
                {
                    MessageBox.Show("El Aparato Auditivo se modifico con exito");
                }
            }
        }

    }
}
