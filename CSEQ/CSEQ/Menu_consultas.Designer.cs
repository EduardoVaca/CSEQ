namespace CSEQ
{
    partial class Menu_consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_consultas));
            this.x_picture = new System.Windows.Forms.PictureBox();
            this.ConsultaRedactada_label = new System.Windows.Forms.Label();
            this.ConsultaGrafica_label = new System.Windows.Forms.Label();
            this.ConsultaGrafica_btn = new System.Windows.Forms.Button();
            this.ConsultaRedactada_btn = new System.Windows.Forms.Button();
            this.back_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // x_picture
            // 
            this.x_picture.Image = ((System.Drawing.Image)(resources.GetObject("x_picture.Image")));
            this.x_picture.Location = new System.Drawing.Point(766, 7);
            this.x_picture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(30, 29);
            this.x_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.x_picture.TabIndex = 7;
            this.x_picture.TabStop = false;
            this.x_picture.Click += new System.EventHandler(this.x_picture_Click);
            // 
            // ConsultaRedactada_label
            // 
            this.ConsultaRedactada_label.AutoSize = true;
            this.ConsultaRedactada_label.Font = new System.Drawing.Font("Candara", 24F);
            this.ConsultaRedactada_label.ForeColor = System.Drawing.Color.White;
            this.ConsultaRedactada_label.Location = new System.Drawing.Point(213, 330);
            this.ConsultaRedactada_label.Name = "ConsultaRedactada_label";
            this.ConsultaRedactada_label.Size = new System.Drawing.Size(277, 39);
            this.ConsultaRedactada_label.TabIndex = 8;
            this.ConsultaRedactada_label.Text = "Consulta redactada";
            // 
            // ConsultaGrafica_label
            // 
            this.ConsultaGrafica_label.AutoSize = true;
            this.ConsultaGrafica_label.Font = new System.Drawing.Font("Candara", 24F);
            this.ConsultaGrafica_label.ForeColor = System.Drawing.Color.White;
            this.ConsultaGrafica_label.Location = new System.Drawing.Point(228, 234);
            this.ConsultaGrafica_label.Name = "ConsultaGrafica_label";
            this.ConsultaGrafica_label.Size = new System.Drawing.Size(232, 39);
            this.ConsultaGrafica_label.TabIndex = 9;
            this.ConsultaGrafica_label.Text = "Consulta gráfica";
            // 
            // ConsultaGrafica_btn
            // 
            this.ConsultaGrafica_btn.Font = new System.Drawing.Font("Candara", 24F);
            this.ConsultaGrafica_btn.Location = new System.Drawing.Point(515, 234);
            this.ConsultaGrafica_btn.Name = "ConsultaGrafica_btn";
            this.ConsultaGrafica_btn.Size = new System.Drawing.Size(75, 36);
            this.ConsultaGrafica_btn.TabIndex = 10;
            this.ConsultaGrafica_btn.Text = "Ir";
            this.ConsultaGrafica_btn.UseVisualStyleBackColor = true;
            this.ConsultaGrafica_btn.Click += new System.EventHandler(this.ConsultaGrafica_btn_Click);
            // 
            // ConsultaRedactada_btn
            // 
            this.ConsultaRedactada_btn.AutoSize = true;
            this.ConsultaRedactada_btn.Font = new System.Drawing.Font("Candara", 24F);
            this.ConsultaRedactada_btn.Location = new System.Drawing.Point(515, 325);
            this.ConsultaRedactada_btn.Name = "ConsultaRedactada_btn";
            this.ConsultaRedactada_btn.Size = new System.Drawing.Size(75, 49);
            this.ConsultaRedactada_btn.TabIndex = 11;
            this.ConsultaRedactada_btn.Text = "Ir";
            this.ConsultaRedactada_btn.UseVisualStyleBackColor = true;
            this.ConsultaRedactada_btn.Click += new System.EventHandler(this.ConsultaRedactada_btn_Click);
            // 
            // back_picture
            // 
            this.back_picture.Image = ((System.Drawing.Image)(resources.GetObject("back_picture.Image")));
            this.back_picture.Location = new System.Drawing.Point(6, 487);
            this.back_picture.Name = "back_picture";
            this.back_picture.Size = new System.Drawing.Size(30, 29);
            this.back_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_picture.TabIndex = 12;
            this.back_picture.TabStop = false;
            this.back_picture.Click += new System.EventHandler(this.back_picture_Click);
            // 
            // Menu_consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(689, 406);
            this.Controls.Add(this.back_picture);
            this.Controls.Add(this.ConsultaRedactada_btn);
            this.Controls.Add(this.ConsultaGrafica_btn);
            this.Controls.Add(this.ConsultaGrafica_label);
            this.Controls.Add(this.ConsultaRedactada_label);
            this.Controls.Add(this.x_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_consultas";
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox x_picture;
        private System.Windows.Forms.Label ConsultaRedactada_label;
        private System.Windows.Forms.Label ConsultaGrafica_label;
        private System.Windows.Forms.Button ConsultaGrafica_btn;
        private System.Windows.Forms.Button ConsultaRedactada_btn;
        private System.Windows.Forms.PictureBox back_picture;
    }
}