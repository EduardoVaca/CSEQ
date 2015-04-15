namespace CSEQ
{
    partial class consultas_salud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultas_salud));
            this.AuxiliaresAuditivos_grp = new System.Windows.Forms.GroupBox();
            this.back_picture = new System.Windows.Forms.PictureBox();
            this.x_picture = new System.Windows.Forms.PictureBox();
            this.auxiliarAuditivo_combo = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.AuxiliaresAuditivos_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AuxiliaresAuditivos_grp
            // 
            this.AuxiliaresAuditivos_grp.BackColor = System.Drawing.Color.Transparent;
            this.AuxiliaresAuditivos_grp.Controls.Add(this.label1);
            this.AuxiliaresAuditivos_grp.Controls.Add(this.auxiliarAuditivo_combo);
            this.AuxiliaresAuditivos_grp.Location = new System.Drawing.Point(12, 74);
            this.AuxiliaresAuditivos_grp.Name = "AuxiliaresAuditivos_grp";
            this.AuxiliaresAuditivos_grp.Size = new System.Drawing.Size(1550, 313);
            this.AuxiliaresAuditivos_grp.TabIndex = 0;
            this.AuxiliaresAuditivos_grp.TabStop = false;
            // 
            // back_picture
            // 
            this.back_picture.BackColor = System.Drawing.Color.Transparent;
            this.back_picture.Image = ((System.Drawing.Image)(resources.GetObject("back_picture.Image")));
            this.back_picture.Location = new System.Drawing.Point(-3, 944);
            this.back_picture.Margin = new System.Windows.Forms.Padding(6);
            this.back_picture.Name = "back_picture";
            this.back_picture.Size = new System.Drawing.Size(60, 56);
            this.back_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_picture.TabIndex = 14;
            this.back_picture.TabStop = false;
            this.back_picture.Click += new System.EventHandler(this.back_picture_Click);
            // 
            // x_picture
            // 
            this.x_picture.BackColor = System.Drawing.Color.Transparent;
            this.x_picture.Image = ((System.Drawing.Image)(resources.GetObject("x_picture.Image")));
            this.x_picture.Location = new System.Drawing.Point(1517, 20);
            this.x_picture.Margin = new System.Windows.Forms.Padding(4);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(60, 56);
            this.x_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.x_picture.TabIndex = 13;
            this.x_picture.TabStop = false;
            this.x_picture.Click += new System.EventHandler(this.x_picture_Click);
            // 
            // auxiliarAuditivo_combo
            // 
            this.auxiliarAuditivo_combo.FormattingEnabled = true;
            this.auxiliarAuditivo_combo.Location = new System.Drawing.Point(329, 158);
            this.auxiliarAuditivo_combo.Name = "auxiliarAuditivo_combo";
            this.auxiliarAuditivo_combo.Size = new System.Drawing.Size(424, 33);
            this.auxiliarAuditivo_combo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 13.875F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selecciona consulta";
            // 
            // consultas_salud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CSEQ.Properties.Resources.fondonopesado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1574, 1021);
            this.Controls.Add(this.back_picture);
            this.Controls.Add(this.x_picture);
            this.Controls.Add(this.AuxiliaresAuditivos_grp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consultas_salud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultas_salud";
            this.AuxiliaresAuditivos_grp.ResumeLayout(false);
            this.AuxiliaresAuditivos_grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AuxiliaresAuditivos_grp;
        private System.Windows.Forms.PictureBox back_picture;
        private System.Windows.Forms.PictureBox x_picture;
        private System.Windows.Forms.ComboBox auxiliarAuditivo_combo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
    }
}