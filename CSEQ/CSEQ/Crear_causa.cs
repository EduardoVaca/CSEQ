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

        //Metodo donde se agrega el registro a la base de datos
        private void guardar_btn_Click(object sender, EventArgs e)
        {            
            String cNombre = causa_txt.Text;
                       
            if (Util.executeStoredProcedure("registrarCausa", cNombre))
            {
                MessageBox.Show("La Causa se ha registrado con exito!");
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String busqueda = "%" + busqueda_txt.Text + "%";
            Util.fillGrid(busqueda_grid, "busquedaEnCausa", busqueda);
        }

        private void busqueda_grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {            
            if (busqueda_grid.Rows[e.RowIndex].Cells[0].Value != null)
            {
                modificar_btn.Enabled = true; //Activacion de botones
                eliminar_btn.Enabled = true;
                causa_selected = busqueda_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                String sqlActiveRow = "SELECT * FROM Causa WHERE ";
                sqlActiveRow += " causa= '" + causa_selected + "';";
                Util.showData(this, sqlActiveRow);
            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar causa: " + causa_selected + "'?", "Confirmacion de eliminar",
                                        MessageBoxButtons.YesNo);

            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("eliminarCausa", causa_selected))
                {
                    MessageBox.Show("Se eliminó la causa:" + causa_selected + " con exito!");
                }
            }

        }

        private void modificar_btn_Click(object sender, EventArgs e)
        {
            String nombreNuevo=causa_txt.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea modificar causa: " + causa_selected + "'?", "Confirmacion de modificar",
                                        MessageBoxButtons.YesNo);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                if (Util.executeStoredProcedure("modificarCausa", causa_selected, nombreNuevo))
                {
                    MessageBox.Show("La causa se modifico con exito");
                }
            }
        }

        private void Crear_causa_Load(object sender, EventArgs e)
        {
            if (rol == 1)
            {
                Busqueda_grp.Visible = true;
                modificar_btn.Visible = true;
                eliminar_btn.Visible = true;
            }
        }


    }
}
