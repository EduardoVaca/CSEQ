namespace CSEQ
{
    partial class Crear_delegacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_delegacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.delegacion_label = new System.Windows.Forms.Label();
            this.close_picture = new System.Windows.Forms.PictureBox();
            this.atras_picture = new System.Windows.Forms.PictureBox();
            this.ID_municipio = new System.Windows.Forms.ComboBox();
            this.nombre_label = new System.Windows.Forms.Label();
            this.municipio_label = new System.Windows.Forms.Label();
            this.rompiendoParadigmas_label = new System.Windows.Forms.Label();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_estado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.busqueda_grid = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.PictureBox();
            this.busqueda_txt = new System.Windows.Forms.TextBox();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.modificar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.close_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atras_picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busqueda_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_txt
            // 
            this.nombre_txt.Font = new System.Drawing.Font("Candara", 12F);
            this.nombre_txt.Location = new System.Drawing.Point(122, 117);
            this.nombre_txt.MaximumSize = new System.Drawing.Size(400, 40);
            this.nombre_txt.MinimumSize = new System.Drawing.Size(100, 4);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(268, 27);
            this.nombre_txt.TabIndex = 7;
            // 
            // delegacion_label
            // 
            this.delegacion_label.AutoSize = true;
            this.delegacion_label.Font = new System.Drawing.Font("Candara", 18F);
            this.delegacion_label.ForeColor = System.Drawing.Color.White;
            this.delegacion_label.Location = new System.Drawing.Point(349, 28);
            this.delegacion_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.delegacion_label.Name = "delegacion_label";
            this.delegacion_label.Size = new System.Drawing.Size(125, 29);
            this.delegacion_label.TabIndex = 6;
            this.delegacion_label.Text = "Delegación";
            // 
            // close_picture
            // 
            this.close_picture.Image = ((System.Drawing.Image)(resources.GetObject("close_picture.Image")));
            this.close_picture.Location = new System.Drawing.Point(766, 7);
            this.close_picture.Margin = new System.Windows.Forms.Padding(2);
            this.close_picture.Name = "close_picture";
            this.close_picture.Size = new System.Drawing.Size(30, 29);
            this.close_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_picture.TabIndex = 8;
            this.close_picture.TabStop = false;
            this.close_picture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // atras_picture
            // 
            this.atras_picture.Image = ((System.Drawing.Image)(resources.GetObject("atras_picture.Image")));
            this.atras_picture.Location = new System.Drawing.Point(6, 487);
            this.atras_picture.Name = "atras_picture";
            this.atras_picture.Size = new System.Drawing.Size(30, 29);
            this.atras_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atras_picture.TabIndex = 9;
            this.atras_picture.TabStop = false;
            this.atras_picture.Click += new System.EventHandler(this.atras_picture_Click);
            // 
            // ID_municipio
            // 
            this.ID_municipio.Font = new System.Drawing.Font("Candara", 10F);
            this.ID_municipio.FormattingEnabled = true;
            this.ID_municipio.Location = new System.Drawing.Point(122, 293);
            this.ID_municipio.Name = "ID_municipio";
            this.ID_municipio.Size = new System.Drawing.Size(268, 23);
            this.ID_municipio.TabIndex = 10;
            this.ID_municipio.Text = "Selecciona Municipio";
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.Font = new System.Drawing.Font("Candara", 14F);
            this.nombre_label.ForeColor = System.Drawing.Color.White;
            this.nombre_label.Location = new System.Drawing.Point(28, 116);
            this.nombre_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(78, 23);
            this.nombre_label.TabIndex = 11;
            this.nombre_label.Text = "Nombre";
            // 
            // municipio_label
            // 
            this.municipio_label.AutoSize = true;
            this.municipio_label.Font = new System.Drawing.Font("Candara", 14F);
            this.municipio_label.ForeColor = System.Drawing.Color.White;
            this.municipio_label.Location = new System.Drawing.Point(28, 290);
            this.municipio_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.municipio_label.Name = "municipio_label";
            this.municipio_label.Size = new System.Drawing.Size(89, 23);
            this.municipio_label.TabIndex = 12;
            this.municipio_label.Text = "Municipio";
            // 
            // rompiendoParadigmas_label
            // 
            this.rompiendoParadigmas_label.AutoSize = true;
            this.rompiendoParadigmas_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rompiendoParadigmas_label.ForeColor = System.Drawing.SystemColors.Control;
            this.rompiendoParadigmas_label.Location = new System.Drawing.Point(613, 500);
            this.rompiendoParadigmas_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rompiendoParadigmas_label.Name = "rompiendoParadigmas_label";
            this.rompiendoParadigmas_label.Size = new System.Drawing.Size(183, 15);
            this.rompiendoParadigmas_label.TabIndex = 13;
            this.rompiendoParadigmas_label.Text = "ROMPIENDO PARADIGMAS";
            // 
            // guardar_btn
            // 
            this.guardar_btn.AutoSize = true;
            this.guardar_btn.Font = new System.Drawing.Font("Candara", 10F);
            this.guardar_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guardar_btn.Location = new System.Drawing.Point(30, 417);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(80, 32);
            this.guardar_btn.TabIndex = 14;
            this.guardar_btn.Text = "Guardar";
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Estado";
            // 
            // ID_estado
            // 
            this.ID_estado.Font = new System.Drawing.Font("Candara", 10F);
            this.ID_estado.FormattingEnabled = true;
            this.ID_estado.Location = new System.Drawing.Point(122, 207);
            this.ID_estado.Name = "ID_estado";
            this.ID_estado.Size = new System.Drawing.Size(268, 23);
            this.ID_estado.TabIndex = 15;
            this.ID_estado.Text = "Selecciona Estado";
            this.ID_estado.SelectionChangeCommitted += new System.EventHandler(this.ID_estado_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(394, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(394, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(394, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 54;
            this.label4.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.busqueda_grid);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.busqueda_txt);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(416, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 372);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de registros";
            // 
            // busqueda_grid
            // 
            this.busqueda_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.busqueda_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.busqueda_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.busqueda_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.busqueda_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.busqueda_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.busqueda_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.busqueda_grid.Location = new System.Drawing.Point(6, 91);
            this.busqueda_grid.Name = "busqueda_grid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.busqueda_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.busqueda_grid.Size = new System.Drawing.Size(341, 275);
            this.busqueda_grid.TabIndex = 56;
            this.busqueda_grid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.busqueda_grid_RowEnter);
            // 
            // Buscar
            // 
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.Location = new System.Drawing.Point(305, 32);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(39, 36);
            this.Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Buscar.TabIndex = 55;
            this.Buscar.TabStop = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // busqueda_txt
            // 
            this.busqueda_txt.Font = new System.Drawing.Font("Candara", 12F);
            this.busqueda_txt.Location = new System.Drawing.Point(6, 39);
            this.busqueda_txt.MaximumSize = new System.Drawing.Size(400, 40);
            this.busqueda_txt.MinimumSize = new System.Drawing.Size(100, 4);
            this.busqueda_txt.Name = "busqueda_txt";
            this.busqueda_txt.Size = new System.Drawing.Size(296, 27);
            this.busqueda_txt.TabIndex = 8;
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.Enabled = false;
            this.eliminar_btn.Font = new System.Drawing.Font("Candara", 10F);
            this.eliminar_btn.Location = new System.Drawing.Point(298, 417);
            this.eliminar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(80, 32);
            this.eliminar_btn.TabIndex = 60;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.UseVisualStyleBackColor = true;
            // 
            // modificar_btn
            // 
            this.modificar_btn.Enabled = false;
            this.modificar_btn.Font = new System.Drawing.Font("Candara", 10F);
            this.modificar_btn.Location = new System.Drawing.Point(164, 417);
            this.modificar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(80, 32);
            this.modificar_btn.TabIndex = 59;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = true;
            // 
            // Crear_delegacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(400, 276);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_estado);
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.rompiendoParadigmas_label);
            this.Controls.Add(this.municipio_label);
            this.Controls.Add(this.nombre_label);
            this.Controls.Add(this.ID_municipio);
            this.Controls.Add(this.atras_picture);
            this.Controls.Add(this.close_picture);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.delegacion_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crear_delegacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Crear_delegacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atras_picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busqueda_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label delegacion_label;
        private System.Windows.Forms.PictureBox close_picture;
        private System.Windows.Forms.PictureBox atras_picture;
        private System.Windows.Forms.ComboBox ID_municipio;
        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.Label municipio_label;
        private System.Windows.Forms.Label rompiendoParadigmas_label;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ID_estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.TextBox busqueda_txt;
        private System.Windows.Forms.PictureBox Buscar;
        private System.Windows.Forms.DataGridView busqueda_grid;
    }
}