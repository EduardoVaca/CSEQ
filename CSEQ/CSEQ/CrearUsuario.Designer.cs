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
            this.x_picture = new System.Windows.Forms.PictureBox();
            this.Atras_picture = new System.Windows.Forms.PictureBox();
            this.Usuario_label = new System.Windows.Forms.Label();
            this.Nombre_label = new System.Windows.Forms.Label();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.Guardar_txt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // x_picture
            // 
            this.x_picture.Image = ((System.Drawing.Image)(resources.GetObject("x_picture.Image")));
            this.x_picture.Location = new System.Drawing.Point(1502, 6);
            this.x_picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(60, 56);
            this.x_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.x_picture.TabIndex = 22;
            this.x_picture.TabStop = false;
            this.x_picture.Click += new System.EventHandler(this.x_picture_Click);
            // 
            // Atras_picture
            // 
            this.Atras_picture.Image = ((System.Drawing.Image)(resources.GetObject("Atras_picture.Image")));
            this.Atras_picture.Location = new System.Drawing.Point(6, 919);
            this.Atras_picture.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Atras_picture.Name = "Atras_picture";
            this.Atras_picture.Size = new System.Drawing.Size(94, 90);
            this.Atras_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras_picture.TabIndex = 24;
            this.Atras_picture.TabStop = false;
            this.Atras_picture.Click += new System.EventHandler(this.Atras_picture_Click);
            // 
            // Usuario_label
            // 
            this.Usuario_label.AutoSize = true;
            this.Usuario_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_label.ForeColor = System.Drawing.Color.White;
            this.Usuario_label.Location = new System.Drawing.Point(656, 146);
            this.Usuario_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Usuario_label.Name = "Usuario_label";
            this.Usuario_label.Size = new System.Drawing.Size(253, 73);
            this.Usuario_label.TabIndex = 25;
            this.Usuario_label.Text = "Usuario";
            // 
            // Nombre_label
            // 
            this.Nombre_label.AutoSize = true;
            this.Nombre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_label.ForeColor = System.Drawing.Color.White;
            this.Nombre_label.Location = new System.Drawing.Point(396, 363);
            this.Nombre_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Nombre_label.Name = "Nombre_label";
            this.Nombre_label.Size = new System.Drawing.Size(260, 73);
            this.Nombre_label.TabIndex = 26;
            this.Nombre_label.Text = "Nombre";
            // 
            // usuario_txt
            // 
            this.usuario_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_txt.Location = new System.Drawing.Point(680, 363);
            this.usuario_txt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.Size = new System.Drawing.Size(490, 53);
            this.usuario_txt.TabIndex = 27;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(291, 542);
            this.password_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(365, 73);
            this.password_label.TabIndex = 28;
            this.password_label.Text = "Contraseña";
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(680, 561);
            this.password_txt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(490, 53);
            this.password_txt.TabIndex = 29;
            // 
            // Guardar_txt
            // 
            this.Guardar_txt.Location = new System.Drawing.Point(688, 763);
            this.Guardar_txt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Guardar_txt.Name = "Guardar_txt";
            this.Guardar_txt.Size = new System.Drawing.Size(192, 77);
            this.Guardar_txt.TabIndex = 30;
            this.Guardar_txt.Text = "Guardar";
            this.Guardar_txt.UseVisualStyleBackColor = true;
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1568, 1017);
            this.Controls.Add(this.Guardar_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.usuario_txt);
            this.Controls.Add(this.Nombre_label);
            this.Controls.Add(this.Usuario_label);
            this.Controls.Add(this.Atras_picture);
            this.Controls.Add(this.x_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox x_picture;
        private System.Windows.Forms.PictureBox Atras_picture;
        private System.Windows.Forms.Label Usuario_label;
        private System.Windows.Forms.Label Nombre_label;
        private System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button Guardar_txt;
    }
}