namespace CSEQ
{
    partial class consulta_educacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consulta_educacion));
            this.label12 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.PictureBox();
            this.back_picture = new System.Windows.Forms.PictureBox();
            this.close_picture = new System.Windows.Forms.PictureBox();
            this.salir_tt = new System.Windows.Forms.ToolTip(this.components);
            this.ID_censo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(1076, 994);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(517, 29);
            this.label12.TabIndex = 70;
            this.label12.Text = "FORTALECIENDO A LA PERSONA SORDA";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Image = global::CSEQ.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(1530, 91);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(60, 56);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 69;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseHover += new System.EventHandler(this.logout_MouseHover);
            // 
            // back_picture
            // 
            this.back_picture.BackColor = System.Drawing.Color.Transparent;
            this.back_picture.Image = ((System.Drawing.Image)(resources.GetObject("back_picture.Image")));
            this.back_picture.Location = new System.Drawing.Point(11, 27);
            this.back_picture.Margin = new System.Windows.Forms.Padding(4);
            this.back_picture.Name = "back_picture";
            this.back_picture.Size = new System.Drawing.Size(60, 56);
            this.back_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_picture.TabIndex = 68;
            this.back_picture.TabStop = false;
            this.back_picture.Click += new System.EventHandler(this.back_picture_Click);
            this.back_picture.MouseLeave += new System.EventHandler(this.back_picture_MouseLeave);
            this.back_picture.MouseHover += new System.EventHandler(this.back_picture_MouseHover);
            // 
            // close_picture
            // 
            this.close_picture.BackColor = System.Drawing.Color.Transparent;
            this.close_picture.Image = ((System.Drawing.Image)(resources.GetObject("close_picture.Image")));
            this.close_picture.Location = new System.Drawing.Point(1530, 27);
            this.close_picture.Margin = new System.Windows.Forms.Padding(4);
            this.close_picture.Name = "close_picture";
            this.close_picture.Size = new System.Drawing.Size(60, 56);
            this.close_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_picture.TabIndex = 67;
            this.close_picture.TabStop = false;
            this.close_picture.Click += new System.EventHandler(this.pictureBox2_Click);
            this.close_picture.MouseHover += new System.EventHandler(this.close_picture_MouseHover);
            // 
            // ID_censo
            // 
            this.ID_censo.Enabled = false;
            this.ID_censo.Font = new System.Drawing.Font("Candara", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_censo.FormattingEnabled = true;
            this.ID_censo.Items.AddRange(new object[] {
            "Auxiliares auditivos por marca",
            "Personas que no tienen aparato auditivo",
            "Personas con implante coclear"});
            this.ID_censo.Location = new System.Drawing.Point(149, 480);
            this.ID_censo.Margin = new System.Windows.Forms.Padding(4);
            this.ID_censo.Name = "ID_censo";
            this.ID_censo.Size = new System.Drawing.Size(160, 44);
            this.ID_censo.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(5, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 36);
            this.label2.TabIndex = 71;
            this.label2.Text = "Censo";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Candara", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo.Location = new System.Drawing.Point(541, 51);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(0, 53);
            this.titulo.TabIndex = 80;
            // 
            // consulta_educacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CSEQ.Properties.Resources.fondonopesado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 1028);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.ID_censo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.back_picture);
            this.Controls.Add(this.close_picture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consulta_educacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta_educacion";
            this.Load += new System.EventHandler(this.consulta_educacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox back_picture;
        private System.Windows.Forms.PictureBox close_picture;
        private System.Windows.Forms.ToolTip salir_tt;
        private System.Windows.Forms.ComboBox ID_censo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titulo;
    }
}