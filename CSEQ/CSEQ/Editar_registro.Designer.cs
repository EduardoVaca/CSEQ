namespace CSEQ
{
    partial class Editar_registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_registro));
            this.Editar = new System.Windows.Forms.Label();
            this.Receptor_Nombre = new System.Windows.Forms.Label();
            this.Busqueda = new System.Windows.Forms.TextBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.Atras = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Editar
            // 
            this.Editar.AutoSize = true;
            this.Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.ForeColor = System.Drawing.SystemColors.Control;
            this.Editar.Location = new System.Drawing.Point(426, 223);
            this.Editar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(200, 73);
            this.Editar.TabIndex = 3;
            this.Editar.Text = "Editar";
            // 
            // Receptor_Nombre
            // 
            this.Receptor_Nombre.AutoSize = true;
            this.Receptor_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receptor_Nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.Receptor_Nombre.Location = new System.Drawing.Point(628, 223);
            this.Receptor_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Receptor_Nombre.Name = "Receptor_Nombre";
            this.Receptor_Nombre.Size = new System.Drawing.Size(0, 73);
            this.Receptor_Nombre.TabIndex = 4;
            // 
            // Busqueda
            // 
            this.Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busqueda.Location = new System.Drawing.Point(346, 385);
            this.Busqueda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Busqueda.MaximumSize = new System.Drawing.Size(796, 40);
            this.Busqueda.MinimumSize = new System.Drawing.Size(796, 4);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(796, 53);
            this.Busqueda.TabIndex = 5;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Atras
            // 
            this.Atras.Image = ((System.Drawing.Image)(resources.GetObject("Atras.Image")));
            this.Atras.Location = new System.Drawing.Point(24, 1040);
            this.Atras.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(94, 90);
            this.Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras.TabIndex = 6;
            this.Atras.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1518, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Editar_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1600, 1154);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.Receptor_Nombre);
            this.Controls.Add(this.Editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Editar_registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar_registro";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Editar;
        private System.Windows.Forms.Label Receptor_Nombre;
        private System.Windows.Forms.TextBox Busqueda;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.PictureBox Atras;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}