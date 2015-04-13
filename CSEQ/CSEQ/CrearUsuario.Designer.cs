namespace CSEQ
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.x_picture = new System.Windows.Forms.PictureBox();
            this.Atras_picture = new System.Windows.Forms.PictureBox();
            this.Usuario_label = new System.Windows.Forms.Label();
            this.Nombre_label = new System.Windows.Forms.Label();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.Guardar_txt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_rol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eliminar_btn = new System.Windows.Forms.Button();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.busqueda_grid = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.PictureBox();
            this.busqueda_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras_picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busqueda_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // x_picture
            // 
            this.x_picture.Image = ((System.Drawing.Image)(resources.GetObject("x_picture.Image")));
            this.x_picture.Location = new System.Drawing.Point(766, 7);
            this.x_picture.Margin = new System.Windows.Forms.Padding(2);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(30, 29);
            this.x_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.x_picture.TabIndex = 22;
            this.x_picture.TabStop = false;
            this.x_picture.Click += new System.EventHandler(this.x_picture_Click);
            // 
            // Atras_picture
            // 
            this.Atras_picture.Image = ((System.Drawing.Image)(resources.GetObject("Atras_picture.Image")));
            this.Atras_picture.Location = new System.Drawing.Point(6, 487);
            this.Atras_picture.Name = "Atras_picture";
            this.Atras_picture.Size = new System.Drawing.Size(30, 29);
            this.Atras_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras_picture.TabIndex = 24;
            this.Atras_picture.TabStop = false;
            this.Atras_picture.Click += new System.EventHandler(this.Atras_picture_Click);
            // 
            // Usuario_label
            // 
            this.Usuario_label.AutoSize = true;
            this.Usuario_label.Font = new System.Drawing.Font("Candara", 18F);
            this.Usuario_label.ForeColor = System.Drawing.Color.White;
            this.Usuario_label.Location = new System.Drawing.Point(356, 29);
            this.Usuario_label.Name = "Usuario_label";
            this.Usuario_label.Size = new System.Drawing.Size(91, 29);
            this.Usuario_label.TabIndex = 25;
            this.Usuario_label.Text = "Usuario";
            // 
            // Nombre_label
            // 
            this.Nombre_label.AutoSize = true;
            this.Nombre_label.Font = new System.Drawing.Font("Candara", 14F);
            this.Nombre_label.ForeColor = System.Drawing.Color.White;
            this.Nombre_label.Location = new System.Drawing.Point(18, 156);
            this.Nombre_label.Name = "Nombre_label";
            this.Nombre_label.Size = new System.Drawing.Size(78, 23);
            this.Nombre_label.TabIndex = 26;
            this.Nombre_label.Text = "Nombre";
            // 
            // nombre_txt
            // 
            this.nombre_txt.Font = new System.Drawing.Font("Candara", 12F);
            this.nombre_txt.Location = new System.Drawing.Point(133, 152);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(247, 27);
            this.nombre_txt.TabIndex = 27;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Candara", 14F);
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(12, 225);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(101, 23);
            this.password_label.TabIndex = 28;
            this.password_label.Text = "Contraseña";
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Candara", 12F);
            this.password_txt.Location = new System.Drawing.Point(133, 223);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(247, 27);
            this.password_txt.TabIndex = 29;
            // 
            // Guardar_txt
            // 
            this.Guardar_txt.Font = new System.Drawing.Font("Candara", 10F);
            this.Guardar_txt.Location = new System.Drawing.Point(35, 409);
            this.Guardar_txt.Name = "Guardar_txt";
            this.Guardar_txt.Size = new System.Drawing.Size(80, 32);
            this.Guardar_txt.TabIndex = 30;
            this.Guardar_txt.Text = "Guardar";
            this.Guardar_txt.UseVisualStyleBackColor = true;
            this.Guardar_txt.Click += new System.EventHandler(this.Guardar_txt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Rol";
            // 
            // ID_rol
            // 
            this.ID_rol.Font = new System.Drawing.Font("Candara", 10F);
            this.ID_rol.FormattingEnabled = true;
            this.ID_rol.Location = new System.Drawing.Point(133, 294);
            this.ID_rol.Margin = new System.Windows.Forms.Padding(2);
            this.ID_rol.Name = "ID_rol";
            this.ID_rol.Size = new System.Drawing.Size(159, 23);
            this.ID_rol.Sorted = true;
            this.ID_rol.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(383, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(383, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(293, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "*";
            // 
            // eliminar_btn
            // 
            this.eliminar_btn.Enabled = false;
            this.eliminar_btn.Font = new System.Drawing.Font("Candara", 10F);
            this.eliminar_btn.Location = new System.Drawing.Point(299, 409);
            this.eliminar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.eliminar_btn.Name = "eliminar_btn";
            this.eliminar_btn.Size = new System.Drawing.Size(80, 32);
            this.eliminar_btn.TabIndex = 76;
            this.eliminar_btn.Text = "Eliminar";
            this.eliminar_btn.UseVisualStyleBackColor = true;
            // 
            // modificar_btn
            // 
            this.modificar_btn.Enabled = false;
            this.modificar_btn.Font = new System.Drawing.Font("Candara", 10F);
            this.modificar_btn.Location = new System.Drawing.Point(167, 409);
            this.modificar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(80, 32);
            this.modificar_btn.TabIndex = 75;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.busqueda_grid);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.busqueda_txt);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(416, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 376);
            this.groupBox1.TabIndex = 77;
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
            this.busqueda_grid.Location = new System.Drawing.Point(6, 108);
            this.busqueda_grid.Name = "busqueda_grid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.busqueda_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.busqueda_grid.Size = new System.Drawing.Size(342, 262);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(613, 500);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 15);
            this.label5.TabIndex = 78;
            this.label5.Text = "ROMPIENDO PARADIGMAS";
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.eliminar_btn);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID_rol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.Nombre_label);
            this.Controls.Add(this.Usuario_label);
            this.Controls.Add(this.Atras_picture);
            this.Controls.Add(this.x_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearUsuario";
            this.Load += new System.EventHandler(this.CrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras_picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busqueda_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox x_picture;
        private System.Windows.Forms.PictureBox Atras_picture;
        private System.Windows.Forms.Label Usuario_label;
        private System.Windows.Forms.Label Nombre_label;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button Guardar_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ID_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button eliminar_btn;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView busqueda_grid;
        private System.Windows.Forms.PictureBox Buscar;
        private System.Windows.Forms.TextBox busqueda_txt;
        private System.Windows.Forms.Label label5;
    }
}