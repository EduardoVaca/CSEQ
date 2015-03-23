namespace CSEQ
{
    partial class CrearEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearEstado));
            this.Mun = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.estado_txt = new System.Windows.Forms.TextBox();
            this.Guardar_txt = new System.Windows.Forms.Button();
            this.Atras_picture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.x_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Atras_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Mun
            // 
            this.Mun.AutoSize = true;
            this.Mun.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mun.ForeColor = System.Drawing.Color.White;
            this.Mun.Location = new System.Drawing.Point(325, 119);
            this.Mun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mun.Name = "Mun";
            this.Mun.Size = new System.Drawing.Size(117, 37);
            this.Mun.TabIndex = 25;
            this.Mun.Text = "Estado";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.White;
            this.Nombre.Location = new System.Drawing.Point(181, 244);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(132, 37);
            this.Nombre.TabIndex = 28;
            this.Nombre.Text = "Nombre";
            // 
            // estado_txt
            // 
            this.estado_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_txt.Location = new System.Drawing.Point(318, 251);
            this.estado_txt.Name = "estado_txt";
            this.estado_txt.Size = new System.Drawing.Size(247, 30);
            this.estado_txt.TabIndex = 27;
            // 
            // Guardar_txt
            // 
            this.Guardar_txt.Location = new System.Drawing.Point(334, 432);
            this.Guardar_txt.Name = "Guardar_txt";
            this.Guardar_txt.Size = new System.Drawing.Size(96, 40);
            this.Guardar_txt.TabIndex = 30;
            this.Guardar_txt.Text = "Guardar";
            this.Guardar_txt.UseVisualStyleBackColor = true;
            // 
            // Atras_picture
            // 
            this.Atras_picture.Image = ((System.Drawing.Image)(resources.GetObject("Atras_picture.Image")));
            this.Atras_picture.Location = new System.Drawing.Point(12, 509);
            this.Atras_picture.Name = "Atras_picture";
            this.Atras_picture.Size = new System.Drawing.Size(47, 47);
            this.Atras_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras_picture.TabIndex = 31;
            this.Atras_picture.TabStop = false;
            this.Atras_picture.Click += new System.EventHandler(this.Atras_picture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(606, 544);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "ROMPIENDO PARADIGMAS";
            // 
            // x_picture
            // 
            this.x_picture.Image = ((System.Drawing.Image)(resources.GetObject("x_picture.Image")));
            this.x_picture.Location = new System.Drawing.Point(759, 11);
            this.x_picture.Margin = new System.Windows.Forms.Padding(2);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(30, 29);
            this.x_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.x_picture.TabIndex = 33;
            this.x_picture.TabStop = false;
            this.x_picture.Click += new System.EventHandler(this.x_picture_Click);
            // 
            // CrearEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.x_picture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Atras_picture);
            this.Controls.Add(this.Guardar_txt);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.estado_txt);
            this.Controls.Add(this.Mun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearEstado";
            this.Text = "CrearEstado";
            ((System.ComponentModel.ISupportInitialize)(this.Atras_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mun;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox estado_txt;
        private System.Windows.Forms.Button Guardar_txt;
        private System.Windows.Forms.PictureBox Atras_picture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox x_picture;
    }
}