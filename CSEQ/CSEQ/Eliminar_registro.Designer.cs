namespace CSEQ
{
    partial class Eliminar_registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar_registro));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Atras = new System.Windows.Forms.PictureBox();
            this.Busqueda = new System.Windows.Forms.TextBox();
            this.Receptor_Nombre = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(759, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Atras
            // 
            this.Atras.Image = ((System.Drawing.Image)(resources.GetObject("Atras.Image")));
            this.Atras.Location = new System.Drawing.Point(12, 542);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(47, 47);
            this.Atras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras.TabIndex = 11;
            this.Atras.TabStop = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Busqueda
            // 
            this.Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busqueda.Location = new System.Drawing.Point(173, 201);
            this.Busqueda.MaximumSize = new System.Drawing.Size(400, 40);
            this.Busqueda.MinimumSize = new System.Drawing.Size(400, 4);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(400, 30);
            this.Busqueda.TabIndex = 10;
            // 
            // Receptor_Nombre
            // 
            this.Receptor_Nombre.AutoSize = true;
            this.Receptor_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receptor_Nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.Receptor_Nombre.Location = new System.Drawing.Point(348, 111);
            this.Receptor_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Receptor_Nombre.Name = "Receptor_Nombre";
            this.Receptor_Nombre.Size = new System.Drawing.Size(0, 37);
            this.Receptor_Nombre.TabIndex = 9;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSize = true;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.Eliminar.Location = new System.Drawing.Point(215, 111);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(133, 37);
            this.Eliminar.TabIndex = 8;
            this.Eliminar.Text = "Eliminar";
            // 
            // Eliminar_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.Receptor_Nombre);
            this.Controls.Add(this.Eliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eliminar_registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar_registro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Atras;
        private System.Windows.Forms.TextBox Busqueda;
        private System.Windows.Forms.Label Receptor_Nombre;
        private System.Windows.Forms.Label Eliminar;
    }
}