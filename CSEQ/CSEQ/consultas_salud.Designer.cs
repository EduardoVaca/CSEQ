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
            this.Reporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.auxiliarAuditivo_combo = new System.Windows.Forms.ComboBox();
            this.back_picture = new System.Windows.Forms.PictureBox();
            this.x_picture = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.titulo = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.dataTable1TableAdapter1 = new CSEQ.DataSet1TableAdapters.DataTable1TableAdapter();
            this.AuxiliaresAuditivos_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AuxiliaresAuditivos_grp
            // 
            this.AuxiliaresAuditivos_grp.BackColor = System.Drawing.Color.Transparent;
            this.AuxiliaresAuditivos_grp.Controls.Add(this.Reporte);
            this.AuxiliaresAuditivos_grp.Controls.Add(this.label1);
            this.AuxiliaresAuditivos_grp.Controls.Add(this.auxiliarAuditivo_combo);
            this.AuxiliaresAuditivos_grp.Location = new System.Drawing.Point(12, 73);
            this.AuxiliaresAuditivos_grp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuxiliaresAuditivos_grp.Name = "AuxiliaresAuditivos_grp";
            this.AuxiliaresAuditivos_grp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuxiliaresAuditivos_grp.Size = new System.Drawing.Size(1550, 313);
            this.AuxiliaresAuditivos_grp.TabIndex = 0;
            this.AuxiliaresAuditivos_grp.TabStop = false;
            this.AuxiliaresAuditivos_grp.Visible = false;
            // 
            // Reporte
            // 
            this.Reporte.Location = new System.Drawing.Point(1368, 108);
            this.Reporte.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(150, 100);
            this.Reporte.TabIndex = 18;
            this.Reporte.Text = "Crear Reporte";
            this.Reporte.UseVisualStyleBackColor = true;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 13.875F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Consulta";
            // 
            // auxiliarAuditivo_combo
            // 
            this.auxiliarAuditivo_combo.Font = new System.Drawing.Font("Candara", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auxiliarAuditivo_combo.FormattingEnabled = true;
            this.auxiliarAuditivo_combo.Items.AddRange(new object[] {
            "Auxiliares auditivos por marca",
            "Personas que no tienen aparato auditivo",
            "Personas con implante coclear"});
            this.auxiliarAuditivo_combo.Location = new System.Drawing.Point(172, 139);
            this.auxiliarAuditivo_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.auxiliarAuditivo_combo.Name = "auxiliarAuditivo_combo";
            this.auxiliarAuditivo_combo.Size = new System.Drawing.Size(592, 44);
            this.auxiliarAuditivo_combo.TabIndex = 0;
            this.auxiliarAuditivo_combo.SelectionChangeCommitted += new System.EventHandler(this.auxiliarAuditivo_combo_SelectionChangeCommitted);
            // 
            // back_picture
            // 
            this.back_picture.BackColor = System.Drawing.Color.Transparent;
            this.back_picture.Image = ((System.Drawing.Image)(resources.GetObject("back_picture.Image")));
            this.back_picture.Location = new System.Drawing.Point(-4, 944);
            this.back_picture.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.x_picture.Location = new System.Drawing.Point(1516, 19);
            this.x_picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(60, 56);
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
            this.titulo.Location = new System.Drawing.Point(604, 19);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(0, 53);
            this.titulo.TabIndex = 16;
            // 
            // zedGraph
            // 
            this.zedGraph.BackColor = System.Drawing.Color.Transparent;
            this.zedGraph.Location = new System.Drawing.Point(226, 310);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
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
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // consultas_salud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CSEQ.Properties.Resources.fondonopesado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1574, 965);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.back_picture);
            this.Controls.Add(this.x_picture);
            this.Controls.Add(this.AuxiliaresAuditivos_grp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "consultas_salud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultas_salud";
            this.Load += new System.EventHandler(this.consultas_salud_Load);
            this.AuxiliaresAuditivos_grp.ResumeLayout(false);
            this.AuxiliaresAuditivos_grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.Label titulo;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button Reporte;
    }
}