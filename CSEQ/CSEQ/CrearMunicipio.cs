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
    public partial class CrearMunicipio : Form
    {
        String nombre_selected;
        int mID_estado;

        public CrearMunicipio()
        {
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
            Util.llenarComboBox(ID_estado, "SELECT ID_estado, nombre FROM Estado");
        }

        //Metodo donde se agrega el registro a la base de datos
        private void guardar_txt_Click(object sender, EventArgs e)
        {
            int mID_estado = Int32.Parse(ID_estado.SelectedValue.ToString());
            String mNombre = municipio_txt.Text;          
            if (Util.executeStoredProcedure("registrarMunicipio", mNombre, mID_estado))
            {
                MessageBox.Show("El Municipio se ha registrado con exito!");
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
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
                if (Util.executeStoredProcedure("eliminarDelegacion", nombre_selected, mID_estado))
                {
                    MessageBox.Show("El municipio se elimino con exito");
                }
            }


        }
    }
}
