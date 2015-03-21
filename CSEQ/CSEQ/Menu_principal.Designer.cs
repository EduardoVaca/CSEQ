namespace CSEQ
{
    partial class Menu_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_principal));
            this.x_picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registros_btn = new System.Windows.Forms.Button();
            this.consultas_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // x_picture
            // 
            this.x_picture.Image = ((System.Drawing.Image)(resources.GetObject("x_picture.Image")));
            this.x_picture.Location = new System.Drawing.Point(1112, -2);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(61, 55);
            this.x_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.x_picture.TabIndex = 7;
            this.x_picture.TabStop = false;
            this.x_picture.Click += new System.EventHandler(this.x_picture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Ming Std L", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(232, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Ming Std L", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(232, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 66);
            this.label2.TabIndex = 9;
            this.label2.Text = "Consultas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(856, 690);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "ROMPIENDO PARADIGMAS";
            // 
            // registros_btn
            // 
            this.registros_btn.Location = new System.Drawing.Point(549, 317);
            this.registros_btn.Name = "registros_btn";
            this.registros_btn.Size = new System.Drawing.Size(83, 42);
            this.registros_btn.TabIndex = 11;
            this.registros_btn.Text = "Ir";
            this.registros_btn.UseVisualStyleBackColor = true;
            this.registros_btn.Click += new System.EventHandler(this.registros_btn_Click);
            // 
            // consultas_btn
            // 
            this.consultas_btn.Location = new System.Drawing.Point(549, 448);
            this.consultas_btn.Name = "consultas_btn";
            this.consultas_btn.Size = new System.Drawing.Size(83, 42);
            this.consultas_btn.TabIndex = 12;
            this.consultas_btn.Text = "Ir";
            this.consultas_btn.UseVisualStyleBackColor = true;
            this.consultas_btn.Click += new System.EventHandler(this.consultas_btn_Click);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.consultas_btn);
            this.Controls.Add(this.registros_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_principal";
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox x_picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registros_btn;
        private System.Windows.Forms.Button consultas_btn;
    }
}