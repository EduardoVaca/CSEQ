namespace CSEQ
{
    partial class CrearMunicipio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearMunicipio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ID_estado = new System.Windows.Forms.ComboBox();
            this.estado_label = new System.Windows.Forms.Label();
            this.Nombre_label = new System.Windows.Forms.Label();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.Mun = new System.Windows.Forms.Label();
            this.Atras_picture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.x_picture = new System.Windows.Forms.PictureBox();
            this.guardar = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Busqueda_grp = new System.Windows.Forms.GroupBox();
            this.busqueda_grid = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.PictureBox();
            this.busqueda_txt = new System.Windows.Forms.TextBox();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Atras_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).BeginInit();
            this.Busqueda_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busqueda_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_estado
            // 
            this.ID_estado.Font = new System.Drawing.Font("Candara", 10F);
            this.ID_estado.FormattingEnabled = true;
            this.ID_estado.Location = new System.Drawing.Point(268, 513);
            this.ID_estado.Margin = new System.Windows.Forms.Padding(6);
            this.ID_estado.Name = "ID_estado";
            this.ID_estado.Size = new System.Drawing.Size(490, 41);
            this.ID_estado.TabIndex = 28;
            // 
            // estado_label
            // 
            this.estado_label.AutoSize = true;
            this.estado_label.BackColor = System.Drawing.Color.Transparent;
            this.estado_label.Font = new System.Drawing.Font("Candara", 14F);
            this.estado_label.ForeColor = System.Drawing.Color.White;
            this.estado_label.Location = new System.Drawing.Point(111, 507);
            this.estado_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.estado_label.Name = "estado_label";
            this.estado_label.Size = new System.Drawing.Size(131, 46);
            this.estado_label.TabIndex = 27;
            this.estado_label.Text = "Estado";
            // 
            // Nombre_label
            // 
            this.Nombre_label.AutoSize = true;
            this.Nombre_label.BackColor = System.Drawing.Color.Transparent;
            this.Nombre_label.Font = new System.Drawing.Font("Candara", 14F);
            this.Nombre_label.ForeColor = System.Drawing.Color.White;
            this.Nombre_label.Location = new System.Drawing.Point(90, 366);
            this.Nombre_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nombre_label.Name = "Nombre_label";
            this.Nombre_label.Size = new System.Drawing.Size(152, 46);
            this.Nombre_label.TabIndex = 26;
            this.Nombre_label.Text = "Nombre";
            // 
            // nombre_txt
            // 
            this.nombre_txt.Font = new System.Drawing.Font("Candara", 12F);
            this.nombre_txt.Location = new System.Drawing.Point(268, 365);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(494, 47);
            this.nombre_txt.TabIndex = 25;
            this.nombre_txt.TextChanged += new System.EventHandler(this.nombre_txt_TextChanged);
            // 
            // Mun
            // 
            this.Mun.AutoSize = true;
            this.Mun.BackColor = System.Drawing.Color.Transparent;
            this.Mun.Font = new System.Drawing.Font("Candara", 18F);
            this.Mun.ForeColor = System.Drawing.Color.White;
            this.Mun.Location = new System.Drawing.Point(676, 46);
            this.Mun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mun.Name = "Mun";
            this.Mun.Size = new System.Drawing.Size(224, 59);
            this.Mun.TabIndex = 24;
            this.Mun.Text = "Municipio";
            // 
            // Atras_picture
            // 
            this.Atras_picture.BackColor = System.Drawing.Color.Transparent;
            this.Atras_picture.Image = ((System.Drawing.Image)(resources.GetObject("Atras_picture.Image")));
            this.Atras_picture.Location = new System.Drawing.Point(15, 15);
            this.Atras_picture.Margin = new System.Windows.Forms.Padding(6);
            this.Atras_picture.Name = "Atras_picture";
            this.Atras_picture.Size = new System.Drawing.Size(60, 56);
            this.Atras_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras_picture.TabIndex = 23;
            this.Atras_picture.TabStop = false;
            this.Atras_picture.Click += new System.EventHandler(this.Atras_picture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1226, 962);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "ROMPIENDO PARADIGMAS";
            // 
            // x_picture
            // 
            this.x_picture.BackColor = System.Drawing.Color.Transparent;
            this.x_picture.Image = ((System.Drawing.Image)(resources.GetObject("x_picture.Image")));
            this.x_picture.Location = new System.Drawing.Point(1536, 2);
            this.x_picture.Margin = new System.Windows.Forms.Padding(4);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(60, 56);
            this.x_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.x_picture.TabIndex = 21;
            this.x_picture.TabStop = false;
            this.x_picture.Click += new System.EventHandler(this.x_picture_Click);
            // 
            // guardar
            // 
            this.guardar.Enabled = false;
            this.guardar.Font = new System.Drawing.Font("Candara", 10F);
            this.guardar.Location = new System.Drawing.Point(82, 821);
            this.guardar.Margin = new System.Windows.Forms.Padding(6);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(160, 62);
            this.guardar.TabIndex = 29;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_txt_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label30.Location = new System.Drawing.Point(768, 513);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(32, 42);
            this.label30.TabIndex = 50;
            this.label30.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(768, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 42);
            this.label2.TabIndex = 51;
            this.label2.Text = "*";
            // 
            // Busqueda_grp
            // 
            this.Busqueda_grp.BackColor = System.Drawing.Color.Transparent;
            this.Busqueda_grp.Controls.Add(this.busqueda_grid);
            this.Busqueda_grp.Controls.Add(this.Buscar);
            this.Busqueda_grp.Controls.Add(this.busqueda_txt);
            this.Busqueda_grp.Font = new System.Drawing.Font("Candara", 9.75F);
            this.Busqueda_grp.ForeColor = System.Drawing.Color.White;
            this.Busqueda_grp.Location = new System.Drawing.Point(832, 160);
            this.Busqueda_grp.Margin = new System.Windows.Forms.Padding(6);
            this.Busqueda_grp.Name = "Busqueda_grp";
            this.Busqueda_grp.Padding = new System.Windows.Forms.Padding(6);
            this.Busqueda_grp.Size = new System.Drawing.Size(708, 723);
            this.Busqueda_grp.TabIndex = 73;
            this.Busqueda_grp.TabStop = false;
            this.Busqueda_grp.Text = "Búsqueda de registros";
            this.Busqueda_grp.Visible = false;
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
            this.busqueda_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.busqueda_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.busqueda_grid.Location = new System.Drawing.Point(24, 134);
            this.busqueda_grid.Margin = new System.Windows.Forms.Padding(6);
            this.busqueda_grid.Name = "busqueda_grid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.busqueda_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.busqueda_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.busqueda_grid.Size = new System.Drawing.Size(608, 537);
            this.busqueda_grid.TabIndex = 56;
            this.busqueda_grid.Visible = false;
            this.busqueda_grid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.busqueda_grid_RowEnter);
            // 
            // Buscar
            // 
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.Location = new System.Drawing.Point(610, 62);
            this.Buscar.Margin = new System.Windows.Forms.Padding(6);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(78, 69);
            this.Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Buscar.TabIndex = 55;
            this.Buscar.TabStop = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // busqueda_txt
            // 
            this.busqueda_txt.Font = new System.Drawing.Font("Candara", 12F);
            this.busqueda_txt.Location = new System.Drawing.Point(12, 75);
            this.busqueda_txt.Margin = new System.Windows.Forms.Padding(6);
            this.busqueda_txt.MaximumSize = new System.Drawing.Size(796, 40);
            this.busqueda_txt.MinimumSize = new System.Drawing.Size(196, 4);
            this.busqueda_txt.Name = "busqueda_txt";
            this.busqueda_txt.Size = new System.Drawing.Size(588, 47);
            this.busqueda_txt.TabIndex = 8;
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.Enabled = false;
            this.eliminar_btn.Font = new System.Drawing.Font("Candara", 10F);
            this.eliminar_btn.Location = new System.Drawing.Point(602, 821);
            this.eliminar_btn.Margin = new System.Windows.Forms.Padding(4);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(160, 62);
            this.eliminar_btn.TabIndex = 76;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.UseVisualStyleBackColor = true;
            this.eliminar_btn.Visible = false;
            this.eliminar_btn.Click += new System.EventHandler(this.eliminar_btn_Click);
            // 
            // modificar_btn
            // 
            this.modificar_btn.Enabled = false;
            this.modificar_btn.Font = new System.Drawing.Font("Candara", 10F);
            this.modificar_btn.Location = new System.Drawing.Point(342, 821);
            this.modificar_btn.Margin = new System.Windows.Forms.Padding(4);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(160, 62);
            this.modificar_btn.TabIndex = 75;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = true;
            this.modificar_btn.Visible = false;
            this.modificar_btn.Click += new System.EventHandler(this.modificar_btn_Click);
            // 
            // imagen
            // 
            this.imagen.BackColor = System.Drawing.Color.Transparent;
            this.imagen.Image = global::CSEQ.Properties.Resources.EstadoB;
            this.imagen.Location = new System.Drawing.Point(850, 244);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(500, 500);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 77;
            this.imagen.TabStop = false;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Image = global::CSEQ.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(1536, 66);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(60, 56);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 78;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // CrearMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.BackgroundImage = global::CSEQ.Properties.Resources.fondonopesado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 1019);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.Busqueda_grp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.ID_estado);
            this.Controls.Add(this.estado_label);
            this.Controls.Add(this.Nombre_label);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.Mun);
            this.Controls.Add(this.Atras_picture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.x_picture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CrearMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "crearMunicipio";
            this.Load += new System.EventHandler(this.CrearMunicipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Atras_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).EndInit();
            this.Busqueda_grp.ResumeLayout(false);
            this.Busqueda_grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busqueda_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ID_estado;
        private System.Windows.Forms.Label estado_label;
        private System.Windows.Forms.Label Nombre_label;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label Mun;
        private System.Windows.Forms.PictureBox Atras_picture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox x_picture;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Busqueda_grp;
        private System.Windows.Forms.DataGridView busqueda_grid;
        private System.Windows.Forms.PictureBox Buscar;
        private System.Windows.Forms.TextBox busqueda_txt;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.PictureBox logout;
    }
}