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
            this.back_picture = new System.Windows.Forms.PictureBox();
            this.x_picture = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.titulo = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.dataTable1TableAdapter1 = new CSEQ.DataSet1TableAdapters.DataTable1TableAdapter();
            this.Reporte = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Candara", 13.875F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selecciona consulta";
            // 
            // auxiliarAuditivo_combo
            // 
            this.auxiliarAuditivo_combo.Font = new System.Drawing.Font("Candara", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auxiliarAuditivo_combo.FormattingEnabled = true;
            this.auxiliarAuditivo_combo.Items.AddRange(new object[] {
            "Auxiliares auditivos por marca"});
            this.auxiliarAuditivo_combo.Location = new System.Drawing.Point(170, 72);
            this.auxiliarAuditivo_combo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.auxiliarAuditivo_combo.Name = "auxiliarAuditivo_combo";
            this.auxiliarAuditivo_combo.Size = new System.Drawing.Size(214, 25);
            this.auxiliarAuditivo_combo.TabIndex = 0;
            this.auxiliarAuditivo_combo.SelectionChangeCommitted += new System.EventHandler(this.auxiliarAuditivo_combo_SelectionChangeCommitted);
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
            this.zedGraph.Location = new System.Drawing.Point(113, 161);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(559, 299);
            this.zedGraph.TabIndex = 17;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.Reporte.Location = new System.Drawing.Point(684, 56);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(75, 52);
            this.Reporte.TabIndex = 18;
            this.Reporte.Text = "Crear Reporte";
            this.Reporte.UseVisualStyleBackColor = true;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // consultas_salud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CSEQ.Properties.Resources.fondonopesado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 502);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.back_picture);
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