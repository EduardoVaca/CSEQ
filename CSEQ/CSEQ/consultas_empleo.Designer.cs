﻿namespace CSEQ
{
    partial class consultas_empleo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultas_empleo));
            this.logout = new System.Windows.Forms.PictureBox();
            this.back_picture = new System.Windows.Forms.PictureBox();
            this.close_picture = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.titulo = new System.Windows.Forms.Label();
            this.areaTrabajo_gp = new System.Windows.Forms.GroupBox();
            this.todaslasAreas_radio = new System.Windows.Forms.RadioButton();
            this.areaTrabajo_radio = new System.Windows.Forms.RadioButton();
            this.generales_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sinEmpleo_radio = new System.Windows.Forms.RadioButton();
            this.conEmpleo_radio = new System.Windows.Forms.RadioButton();
            this.eleccion_gp = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_censo = new System.Windows.Forms.ComboBox();
            this.todoscensos_radio = new System.Windows.Forms.RadioButton();
            this.Reporte = new System.Windows.Forms.Button();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_picture)).BeginInit();
            this.areaTrabajo_gp.SuspendLayout();
            this.eleccion_gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Image = global::CSEQ.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(766, 42);
            this.logout.Margin = new System.Windows.Forms.Padding(2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(30, 29);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 75;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // back_picture
            // 
            this.back_picture.BackColor = System.Drawing.Color.Transparent;
            this.back_picture.Image = ((System.Drawing.Image)(resources.GetObject("back_picture.Image")));
            this.back_picture.Location = new System.Drawing.Point(6, 8);
            this.back_picture.Margin = new System.Windows.Forms.Padding(2);
            this.back_picture.Name = "back_picture";
            this.back_picture.Size = new System.Drawing.Size(30, 29);
            this.back_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_picture.TabIndex = 74;
            this.back_picture.TabStop = false;
            this.back_picture.Click += new System.EventHandler(this.back_picture_Click);
            this.back_picture.MouseLeave += new System.EventHandler(this.back_picture_MouseLeave);
            this.back_picture.MouseHover += new System.EventHandler(this.back_picture_MouseHover);
            // 
            // close_picture
            // 
            this.close_picture.BackColor = System.Drawing.Color.Transparent;
            this.close_picture.Image = ((System.Drawing.Image)(resources.GetObject("close_picture.Image")));
            this.close_picture.Location = new System.Drawing.Point(766, 8);
            this.close_picture.Margin = new System.Windows.Forms.Padding(2);
            this.close_picture.Name = "close_picture";
            this.close_picture.Size = new System.Drawing.Size(30, 29);
            this.close_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_picture.TabIndex = 73;
            this.close_picture.TabStop = false;
            this.close_picture.Click += new System.EventHandler(this.close_picture_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft MHei", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo.Location = new System.Drawing.Point(290, 23);
            this.titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(0, 30);
            this.titulo.TabIndex = 80;
            // 
            // areaTrabajo_gp
            // 
            this.areaTrabajo_gp.BackColor = System.Drawing.Color.Transparent;
            this.areaTrabajo_gp.Controls.Add(this.todaslasAreas_radio);
            this.areaTrabajo_gp.Controls.Add(this.areaTrabajo_radio);
            this.areaTrabajo_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTrabajo_gp.ForeColor = System.Drawing.Color.White;
            this.areaTrabajo_gp.Location = new System.Drawing.Point(464, 69);
            this.areaTrabajo_gp.Margin = new System.Windows.Forms.Padding(2);
            this.areaTrabajo_gp.Name = "areaTrabajo_gp";
            this.areaTrabajo_gp.Padding = new System.Windows.Forms.Padding(2);
            this.areaTrabajo_gp.Size = new System.Drawing.Size(144, 85);
            this.areaTrabajo_gp.TabIndex = 88;
            this.areaTrabajo_gp.TabStop = false;
            this.areaTrabajo_gp.Text = "Con Empleo";
            this.areaTrabajo_gp.Visible = false;
            // 
            // todaslasAreas_radio
            // 
            this.todaslasAreas_radio.AutoSize = true;
            this.todaslasAreas_radio.BackColor = System.Drawing.Color.Transparent;
            this.todaslasAreas_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaslasAreas_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.todaslasAreas_radio.Location = new System.Drawing.Point(4, 54);
            this.todaslasAreas_radio.Margin = new System.Windows.Forms.Padding(2);
            this.todaslasAreas_radio.Name = "todaslasAreas_radio";
            this.todaslasAreas_radio.Size = new System.Drawing.Size(106, 20);
            this.todaslasAreas_radio.TabIndex = 24;
            this.todaslasAreas_radio.TabStop = true;
            this.todaslasAreas_radio.Text = "Todas las Áreas";
            this.todaslasAreas_radio.UseVisualStyleBackColor = false;
            this.todaslasAreas_radio.CheckedChanged += new System.EventHandler(this.todaslasAreas_radio_CheckedChanged);
            // 
            // areaTrabajo_radio
            // 
            this.areaTrabajo_radio.AutoSize = true;
            this.areaTrabajo_radio.BackColor = System.Drawing.Color.Transparent;
            this.areaTrabajo_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTrabajo_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.areaTrabajo_radio.Location = new System.Drawing.Point(4, 26);
            this.areaTrabajo_radio.Margin = new System.Windows.Forms.Padding(2);
            this.areaTrabajo_radio.Name = "areaTrabajo_radio";
            this.areaTrabajo_radio.Size = new System.Drawing.Size(129, 20);
            this.areaTrabajo_radio.TabIndex = 22;
            this.areaTrabajo_radio.TabStop = true;
            this.areaTrabajo_radio.Text = "Por Área de Trabajo";
            this.areaTrabajo_radio.UseVisualStyleBackColor = false;
            this.areaTrabajo_radio.CheckedChanged += new System.EventHandler(this.areaTrabajo_radio_CheckedChanged);
            // 
            // generales_combo
            // 
            this.generales_combo.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generales_combo.FormattingEnabled = true;
            this.generales_combo.Items.AddRange(new object[] {
            "Por Área de Trabajo",
            "Por Ingresos",
            "Por Servicio de Interpretación LSM"});
            this.generales_combo.Location = new System.Drawing.Point(110, 100);
            this.generales_combo.Margin = new System.Windows.Forms.Padding(2);
            this.generales_combo.Name = "generales_combo";
            this.generales_combo.Size = new System.Drawing.Size(253, 29);
            this.generales_combo.TabIndex = 111;
            this.generales_combo.Visible = false;
            this.generales_combo.SelectionChangeCommitted += new System.EventHandler(this.generales_combo_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft MHei", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(30, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 110;
            this.label3.Text = "Consulta";
            // 
            // sinEmpleo_radio
            // 
            this.sinEmpleo_radio.AutoSize = true;
            this.sinEmpleo_radio.BackColor = System.Drawing.Color.Transparent;
            this.sinEmpleo_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinEmpleo_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.sinEmpleo_radio.Location = new System.Drawing.Point(374, 121);
            this.sinEmpleo_radio.Margin = new System.Windows.Forms.Padding(2);
            this.sinEmpleo_radio.Name = "sinEmpleo_radio";
            this.sinEmpleo_radio.Size = new System.Drawing.Size(84, 20);
            this.sinEmpleo_radio.TabIndex = 26;
            this.sinEmpleo_radio.TabStop = true;
            this.sinEmpleo_radio.Text = "Sin Empleo";
            this.sinEmpleo_radio.UseVisualStyleBackColor = false;
            this.sinEmpleo_radio.Visible = false;
            this.sinEmpleo_radio.CheckedChanged += new System.EventHandler(this.sinEmpleo_radio_CheckedChanged);
            // 
            // conEmpleo_radio
            // 
            this.conEmpleo_radio.AutoSize = true;
            this.conEmpleo_radio.BackColor = System.Drawing.Color.Transparent;
            this.conEmpleo_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conEmpleo_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.conEmpleo_radio.Location = new System.Drawing.Point(374, 93);
            this.conEmpleo_radio.Margin = new System.Windows.Forms.Padding(2);
            this.conEmpleo_radio.Name = "conEmpleo_radio";
            this.conEmpleo_radio.Size = new System.Drawing.Size(89, 20);
            this.conEmpleo_radio.TabIndex = 25;
            this.conEmpleo_radio.TabStop = true;
            this.conEmpleo_radio.Text = "Con Empleo";
            this.conEmpleo_radio.UseVisualStyleBackColor = false;
            this.conEmpleo_radio.Visible = false;
            this.conEmpleo_radio.CheckedChanged += new System.EventHandler(this.conEmpleo_radio_CheckedChanged);
            // 
            // eleccion_gp
            // 
            this.eleccion_gp.BackColor = System.Drawing.Color.Transparent;
            this.eleccion_gp.Controls.Add(this.label1);
            this.eleccion_gp.Controls.Add(this.ID_censo);
            this.eleccion_gp.Controls.Add(this.todoscensos_radio);
            this.eleccion_gp.Enabled = false;
            this.eleccion_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleccion_gp.ForeColor = System.Drawing.Color.White;
            this.eleccion_gp.Location = new System.Drawing.Point(13, 225);
            this.eleccion_gp.Margin = new System.Windows.Forms.Padding(2);
            this.eleccion_gp.Name = "eleccion_gp";
            this.eleccion_gp.Padding = new System.Windows.Forms.Padding(2);
            this.eleccion_gp.Size = new System.Drawing.Size(156, 86);
            this.eleccion_gp.TabIndex = 113;
            this.eleccion_gp.TabStop = false;
            this.eleccion_gp.Text = "Elección Censo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft MHei", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Censo";
            // 
            // ID_censo
            // 
            this.ID_censo.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_censo.FormattingEnabled = true;
            this.ID_censo.Items.AddRange(new object[] {
            "Auxiliares auditivos por marca",
            "Personas que no tienen aparato auditivo",
            "Personas con implante coclear"});
            this.ID_censo.Location = new System.Drawing.Point(59, 23);
            this.ID_censo.Margin = new System.Windows.Forms.Padding(2);
            this.ID_censo.Name = "ID_censo";
            this.ID_censo.Size = new System.Drawing.Size(82, 29);
            this.ID_censo.TabIndex = 21;
            this.ID_censo.SelectionChangeCommitted += new System.EventHandler(this.ID_censo_SelectionChangeCommitted);
            // 
            // todoscensos_radio
            // 
            this.todoscensos_radio.AutoSize = true;
            this.todoscensos_radio.BackColor = System.Drawing.Color.Transparent;
            this.todoscensos_radio.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoscensos_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.todoscensos_radio.Location = new System.Drawing.Point(6, 59);
            this.todoscensos_radio.Margin = new System.Windows.Forms.Padding(2);
            this.todoscensos_radio.Name = "todoscensos_radio";
            this.todoscensos_radio.Size = new System.Drawing.Size(112, 18);
            this.todoscensos_radio.TabIndex = 20;
            this.todoscensos_radio.TabStop = true;
            this.todoscensos_radio.Text = "Todos los censos";
            this.todoscensos_radio.UseVisualStyleBackColor = false;
            this.todoscensos_radio.CheckedChanged += new System.EventHandler(this.todoscensos_radio_CheckedChanged);
            // 
            // Reporte
            // 
            this.Reporte.BackColor = System.Drawing.Color.White;
            this.Reporte.Enabled = false;
            this.Reporte.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte.Location = new System.Drawing.Point(46, 347);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(92, 37);
            this.Reporte.TabIndex = 112;
            this.Reporte.Text = "Crear Reporte";
            this.Reporte.UseVisualStyleBackColor = false;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // zedGraph
            // 
            this.zedGraph.AutoSize = true;
            this.zedGraph.BackColor = System.Drawing.Color.Transparent;
            this.zedGraph.Location = new System.Drawing.Point(177, 177);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(6);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(626, 358);
            this.zedGraph.TabIndex = 114;
            this.zedGraph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraph.ZoomStepFraction = 0D;
            // 
            // consultas_empleo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CSEQ.Properties.Resources.fondonopesado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.eleccion_gp);
            this.Controls.Add(this.Reporte);
            this.Controls.Add(this.sinEmpleo_radio);
            this.Controls.Add(this.conEmpleo_radio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.areaTrabajo_gp);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.back_picture);
            this.Controls.Add(this.close_picture);
            this.Controls.Add(this.generales_combo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "consultas_empleo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultas_empleo";
            this.Load += new System.EventHandler(this.consultas_empleo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_picture)).EndInit();
            this.areaTrabajo_gp.ResumeLayout(false);
            this.areaTrabajo_gp.PerformLayout();
            this.eleccion_gp.ResumeLayout(false);
            this.eleccion_gp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox back_picture;
        private System.Windows.Forms.PictureBox close_picture;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.GroupBox areaTrabajo_gp;
        private System.Windows.Forms.RadioButton todaslasAreas_radio;
        private System.Windows.Forms.RadioButton areaTrabajo_radio;
        private System.Windows.Forms.ComboBox generales_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton sinEmpleo_radio;
        private System.Windows.Forms.RadioButton conEmpleo_radio;
        private System.Windows.Forms.GroupBox eleccion_gp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ID_censo;
        private System.Windows.Forms.RadioButton todoscensos_radio;
        private System.Windows.Forms.Button Reporte;
        private ZedGraph.ZedGraphControl zedGraph;
    }
}