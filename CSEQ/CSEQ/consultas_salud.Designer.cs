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
            this.label1 = new System.Windows.Forms.Label();
            this.auxiliarAuditivo_combo = new System.Windows.Forms.ComboBox();
            this.Reporte = new System.Windows.Forms.Button();
            this.back_picture = new System.Windows.Forms.PictureBox();
            this.x_picture = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.titulo = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.label2 = new System.Windows.Forms.Label();
            this.todoscensos_radio = new System.Windows.Forms.RadioButton();
            this.ID_censo = new System.Windows.Forms.ComboBox();
            this.tienen_radio = new System.Windows.Forms.RadioButton();
            this.noTienen_radio = new System.Windows.Forms.RadioButton();
            this.logout = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.AuxiliaresAuditivos_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.SuspendLayout();
            // 
            // AuxiliaresAuditivos_grp
            // 
            this.AuxiliaresAuditivos_grp.BackColor = System.Drawing.Color.Transparent;
            this.AuxiliaresAuditivos_grp.Controls.Add(this.noTienen_radio);
            this.AuxiliaresAuditivos_grp.Controls.Add(this.tienen_radio);
            this.AuxiliaresAuditivos_grp.Controls.Add(this.radioButton1);
            this.AuxiliaresAuditivos_grp.Controls.Add(this.label1);
            this.AuxiliaresAuditivos_grp.Controls.Add(this.auxiliarAuditivo_combo);
            this.AuxiliaresAuditivos_grp.Location = new System.Drawing.Point(6, 38);
            this.AuxiliaresAuditivos_grp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuxiliaresAuditivos_grp.Name = "AuxiliaresAuditivos_grp";
            this.AuxiliaresAuditivos_grp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuxiliaresAuditivos_grp.Size = new System.Drawing.Size(775, 163);
            this.AuxiliaresAuditivos_grp.TabIndex = 0;
            this.AuxiliaresAuditivos_grp.TabStop = false;
            this.AuxiliaresAuditivos_grp.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Consulta";
            // 
            // auxiliarAuditivo_combo
            // 
            this.auxiliarAuditivo_combo.Font = new System.Drawing.Font("Candara", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auxiliarAuditivo_combo.FormattingEnabled = true;
            this.auxiliarAuditivo_combo.Items.AddRange(new object[] {
            "Auxiliares auditivos por marca",
            "Personas con y sin aparato auditivo",
            "Personas con implante coclear"});
            this.auxiliarAuditivo_combo.Location = new System.Drawing.Point(76, 70);
            this.auxiliarAuditivo_combo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.auxiliarAuditivo_combo.Name = "auxiliarAuditivo_combo";
            this.auxiliarAuditivo_combo.Size = new System.Drawing.Size(298, 25);
            this.auxiliarAuditivo_combo.TabIndex = 0;
            this.auxiliarAuditivo_combo.SelectionChangeCommitted += new System.EventHandler(this.auxiliarAuditivo_combo_SelectionChangeCommitted);
            // 
            // Reporte
            // 
            this.Reporte.Enabled = false;
            this.Reporte.Location = new System.Drawing.Point(54, 357);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(66, 37);
            this.Reporte.TabIndex = 18;
            this.Reporte.Text = "Crear Reporte";
            this.Reporte.UseVisualStyleBackColor = true;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // back_picture
            // 
            this.back_picture.BackColor = System.Drawing.Color.Transparent;
            this.back_picture.Image = ((System.Drawing.Image)(resources.GetObject("back_picture.Image")));
            this.back_picture.Location = new System.Drawing.Point(-2, 491);
            this.back_picture.Name = "back_picture";
            this.back_picture.Size = new System.Drawing.Size(30, 29);
            this.back_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_picture.TabIndex = 14;
            this.back_picture.TabStop = false;
            this.back_picture.Click += new System.EventHandler(this.back_picture_Click);
            // 
            // x_picture
            // 
            this.x_picture.BackColor = System.Drawing.Color.Transparent;
            this.x_picture.Image = ((System.Drawing.Image)(resources.GetObject("x_picture.Image")));
            this.x_picture.Location = new System.Drawing.Point(758, 10);
            this.x_picture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(30, 29);
            this.x_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.x_picture.TabIndex = 13;
            this.x_picture.TabStop = false;
            this.x_picture.Click += new System.EventHandler(this.x_picture_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Candara", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo.Location = new System.Drawing.Point(302, 10);
            this.titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(0, 27);
            this.titulo.TabIndex = 16;
            // 
            // zedGraph
            // 
            this.zedGraph.BackColor = System.Drawing.Color.Transparent;
            this.zedGraph.Location = new System.Drawing.Point(187, 209);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(1118, 575);
            this.zedGraph.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Censo";
            // 
            // todoscensos_radio
            // 
            this.todoscensos_radio.AutoSize = true;
            this.todoscensos_radio.BackColor = System.Drawing.Color.Transparent;
            this.todoscensos_radio.Enabled = false;
            this.todoscensos_radio.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoscensos_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.todoscensos_radio.Location = new System.Drawing.Point(7, 245);
            this.todoscensos_radio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.todoscensos_radio.Name = "todoscensos_radio";
            this.todoscensos_radio.Size = new System.Drawing.Size(112, 18);
            this.todoscensos_radio.TabIndex = 20;
            this.todoscensos_radio.TabStop = true;
            this.todoscensos_radio.Text = "Todos los censos";
            this.todoscensos_radio.UseVisualStyleBackColor = false;
            this.todoscensos_radio.CheckedChanged += new System.EventHandler(this.todoscensos_radio_CheckedChanged);
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
            this.ID_censo.Location = new System.Drawing.Point(82, 218);
            this.ID_censo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID_censo.Name = "ID_censo";
            this.ID_censo.Size = new System.Drawing.Size(82, 25);
            this.ID_censo.TabIndex = 21;
            this.ID_censo.SelectionChangeCommitted += new System.EventHandler(this.ID_censo_SelectionChangeCommitted);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(54, 300);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // tienen_radio
            // 
            this.tienen_radio.AutoSize = true;
            this.tienen_radio.BackColor = System.Drawing.Color.Transparent;
            this.tienen_radio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienen_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.tienen_radio.Location = new System.Drawing.Point(385, 58);
            this.tienen_radio.Margin = new System.Windows.Forms.Padding(2);
            this.tienen_radio.Name = "tienen_radio";
            this.tienen_radio.Size = new System.Drawing.Size(74, 19);
            this.tienen_radio.TabIndex = 22;
            this.tienen_radio.TabStop = true;
            this.tienen_radio.Text = "Si tienen";
            this.tienen_radio.UseVisualStyleBackColor = false;
            this.tienen_radio.Visible = false;
            this.tienen_radio.CheckedChanged += new System.EventHandler(this.tienen_radio_CheckedChanged);
            // 
            // noTienen_radio
            // 
            this.noTienen_radio.AutoSize = true;
            this.noTienen_radio.BackColor = System.Drawing.Color.Transparent;
            this.noTienen_radio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTienen_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.noTienen_radio.Location = new System.Drawing.Point(385, 89);
            this.noTienen_radio.Margin = new System.Windows.Forms.Padding(2);
            this.noTienen_radio.Name = "noTienen_radio";
            this.noTienen_radio.Size = new System.Drawing.Size(80, 19);
            this.noTienen_radio.TabIndex = 23;
            this.noTienen_radio.TabStop = true;
            this.noTienen_radio.Text = "No tienen";
            this.noTienen_radio.UseVisualStyleBackColor = false;
            this.noTienen_radio.Visible = false;
            this.noTienen_radio.CheckedChanged += new System.EventHandler(this.noTienen_radio_CheckedChanged);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Image = global::CSEQ.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(1517, 87);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(60, 56);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 22;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // consultas_salud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CSEQ.Properties.Resources.fondonopesado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.radioButton1);
            this.ClientSize = new System.Drawing.Size(1574, 965);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.ID_censo);
            this.Controls.Add(this.todoscensos_radio);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.back_picture);
            this.Controls.Add(this.Reporte);
            this.Controls.Add(this.x_picture);
            this.Controls.Add(this.AuxiliaresAuditivos_grp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "consultas_salud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultas_salud";
            this.Load += new System.EventHandler(this.consultas_salud_Load);
            this.AuxiliaresAuditivos_grp.ResumeLayout(false);
            this.AuxiliaresAuditivos_grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AuxiliaresAuditivos_grp;
        private System.Windows.Forms.PictureBox back_picture;
        private System.Windows.Forms.PictureBox x_picture;
        private System.Windows.Forms.ComboBox auxiliarAuditivo_combo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titulo;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button Reporte;
        private System.Windows.Forms.RadioButton todoscensos_radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ID_censo;
        private System.Windows.Forms.RadioButton noTienen_radio;
        private System.Windows.Forms.RadioButton tienen_radio;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}