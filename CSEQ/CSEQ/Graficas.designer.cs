namespace CSEQ
{
    partial class Graficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graficas));
            this.tabControlGraficas = new System.Windows.Forms.TabControl();
            this.tabGraficaBarras = new System.Windows.Forms.TabPage();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.btnLlenarBarras = new System.Windows.Forms.Button();
            this.tabGraficaPay = new System.Windows.Forms.TabPage();
            this.btnLlenarPay = new System.Windows.Forms.Button();
            this.chartPay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.x_picture = new System.Windows.Forms.PictureBox();
            this.Atras_picture = new System.Windows.Forms.PictureBox();
            this.PersonasDisAud_combo = new System.Windows.Forms.ComboBox();
            this.Empleabilidad_combo = new System.Windows.Forms.ComboBox();
            this.De_label = new System.Windows.Forms.Label();
            this.Ver_label = new System.Windows.Forms.Label();
            this.ConsultaGrafica_label = new System.Windows.Forms.Label();
            this.tabControlGraficas.SuspendLayout();
            this.tabGraficaBarras.SuspendLayout();
            this.tabGraficaPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlGraficas
            // 
            this.tabControlGraficas.Controls.Add(this.tabGraficaBarras);
            this.tabControlGraficas.Controls.Add(this.tabGraficaPay);
            this.tabControlGraficas.Location = new System.Drawing.Point(104, 100);
            this.tabControlGraficas.Name = "tabControlGraficas";
            this.tabControlGraficas.SelectedIndex = 0;
            this.tabControlGraficas.Size = new System.Drawing.Size(584, 367);
            this.tabControlGraficas.TabIndex = 0;
            // 
            // tabGraficaBarras
            // 
            this.tabGraficaBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.tabGraficaBarras.Controls.Add(this.zedGraph);
            this.tabGraficaBarras.Controls.Add(this.btnLlenarBarras);
            this.tabGraficaBarras.Location = new System.Drawing.Point(4, 22);
            this.tabGraficaBarras.Name = "tabGraficaBarras";
            this.tabGraficaBarras.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraficaBarras.Size = new System.Drawing.Size(576, 341);
            this.tabGraficaBarras.TabIndex = 0;
            this.tabGraficaBarras.Text = "Gráfica de barras";
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(11, 6);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(559, 299);
            this.zedGraph.TabIndex = 1;
            // 
            // btnLlenarBarras
            // 
            this.btnLlenarBarras.Location = new System.Drawing.Point(251, 311);
            this.btnLlenarBarras.Name = "btnLlenarBarras";
            this.btnLlenarBarras.Size = new System.Drawing.Size(75, 23);
            this.btnLlenarBarras.TabIndex = 0;
            this.btnLlenarBarras.Text = "Llenar";
            this.btnLlenarBarras.UseVisualStyleBackColor = true;
            this.btnLlenarBarras.Click += new System.EventHandler(this.btnLlenarBarras_Click);
            // 
            // tabGraficaPay
            // 
            this.tabGraficaPay.Controls.Add(this.btnLlenarPay);
            this.tabGraficaPay.Controls.Add(this.chartPay);
            this.tabGraficaPay.Location = new System.Drawing.Point(4, 22);
            this.tabGraficaPay.Name = "tabGraficaPay";
            this.tabGraficaPay.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraficaPay.Size = new System.Drawing.Size(576, 341);
            this.tabGraficaPay.TabIndex = 1;
            this.tabGraficaPay.Text = "Gráfica de pay";
            this.tabGraficaPay.UseVisualStyleBackColor = true;
            // 
            // btnLlenarPay
            // 
            this.btnLlenarPay.Location = new System.Drawing.Point(251, 309);
            this.btnLlenarPay.Name = "btnLlenarPay";
            this.btnLlenarPay.Size = new System.Drawing.Size(75, 23);
            this.btnLlenarPay.TabIndex = 1;
            this.btnLlenarPay.Text = "Llenar";
            this.btnLlenarPay.UseVisualStyleBackColor = true;
            this.btnLlenarPay.Click += new System.EventHandler(this.btnLlenarPay_Click);
            // 
            // chartPay
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPay.ChartAreas.Add(chartArea2);
            this.chartPay.Location = new System.Drawing.Point(20, 6);
            this.chartPay.Name = "chartPay";
            this.chartPay.Size = new System.Drawing.Size(536, 300);
            this.chartPay.TabIndex = 0;
            this.chartPay.Text = "chartPay";
            // 
            // x_picture
            // 
            this.x_picture.Image = ((System.Drawing.Image)(resources.GetObject("x_picture.Image")));
            this.x_picture.Location = new System.Drawing.Point(759, 11);
            this.x_picture.Margin = new System.Windows.Forms.Padding(2);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(30, 29);
            this.x_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.x_picture.TabIndex = 50;
            this.x_picture.TabStop = false;
            this.x_picture.Click += new System.EventHandler(this.x_picture_Click);
            // 
            // Atras_picture
            // 
            this.Atras_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.Atras_picture.Image = ((System.Drawing.Image)(resources.GetObject("Atras_picture.Image")));
            this.Atras_picture.Location = new System.Drawing.Point(12, 489);
            this.Atras_picture.Name = "Atras_picture";
            this.Atras_picture.Size = new System.Drawing.Size(30, 29);
            this.Atras_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras_picture.TabIndex = 51;
            this.Atras_picture.TabStop = false;
            // 
            // PersonasDisAud_combo
            // 
            this.PersonasDisAud_combo.FormattingEnabled = true;
            this.PersonasDisAud_combo.Location = new System.Drawing.Point(468, 55);
            this.PersonasDisAud_combo.Name = "PersonasDisAud_combo";
            this.PersonasDisAud_combo.Size = new System.Drawing.Size(200, 21);
            this.PersonasDisAud_combo.TabIndex = 56;
            this.PersonasDisAud_combo.Text = "Personas con discapacidad auditiva";
            // 
            // Empleabilidad_combo
            // 
            this.Empleabilidad_combo.FormattingEnabled = true;
            this.Empleabilidad_combo.Location = new System.Drawing.Point(186, 55);
            this.Empleabilidad_combo.Name = "Empleabilidad_combo";
            this.Empleabilidad_combo.Size = new System.Drawing.Size(121, 21);
            this.Empleabilidad_combo.TabIndex = 55;
            this.Empleabilidad_combo.Text = "Empleabilidad";
            // 
            // De_label
            // 
            this.De_label.AutoSize = true;
            this.De_label.Font = new System.Drawing.Font("Candara", 18F);
            this.De_label.ForeColor = System.Drawing.Color.White;
            this.De_label.Location = new System.Drawing.Point(407, 52);
            this.De_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.De_label.Name = "De_label";
            this.De_label.Size = new System.Drawing.Size(46, 29);
            this.De_label.TabIndex = 54;
            this.De_label.Text = "De:";
            // 
            // Ver_label
            // 
            this.Ver_label.AutoSize = true;
            this.Ver_label.Font = new System.Drawing.Font("Candara", 18F);
            this.Ver_label.ForeColor = System.Drawing.Color.White;
            this.Ver_label.Location = new System.Drawing.Point(114, 52);
            this.Ver_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ver_label.Name = "Ver_label";
            this.Ver_label.Size = new System.Drawing.Size(52, 29);
            this.Ver_label.TabIndex = 53;
            this.Ver_label.Text = "Ver:";
            // 
            // ConsultaGrafica_label
            // 
            this.ConsultaGrafica_label.AutoSize = true;
            this.ConsultaGrafica_label.Font = new System.Drawing.Font("Candara", 18F);
            this.ConsultaGrafica_label.ForeColor = System.Drawing.Color.White;
            this.ConsultaGrafica_label.Location = new System.Drawing.Point(305, 9);
            this.ConsultaGrafica_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConsultaGrafica_label.Name = "ConsultaGrafica_label";
            this.ConsultaGrafica_label.Size = new System.Drawing.Size(179, 29);
            this.ConsultaGrafica_label.TabIndex = 52;
            this.ConsultaGrafica_label.Text = "Consulta Gráfica";
            // 
            // Graficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.PersonasDisAud_combo);
            this.Controls.Add(this.Empleabilidad_combo);
            this.Controls.Add(this.De_label);
            this.Controls.Add(this.Ver_label);
            this.Controls.Add(this.ConsultaGrafica_label);
            this.Controls.Add(this.Atras_picture);
            this.Controls.Add(this.x_picture);
            this.Controls.Add(this.tabControlGraficas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Graficas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráficas";
            this.Load += new System.EventHandler(this.Graficas_Load);
            this.tabControlGraficas.ResumeLayout(false);
            this.tabGraficaBarras.ResumeLayout(false);
            this.tabGraficaPay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGraficas;
        private System.Windows.Forms.TabPage tabGraficaPay;
        private System.Windows.Forms.Button btnLlenarPay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPay;
        private System.Windows.Forms.TabPage tabGraficaBarras;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button btnLlenarBarras;
        private System.Windows.Forms.PictureBox x_picture;
        private System.Windows.Forms.PictureBox Atras_picture;
        private System.Windows.Forms.ComboBox PersonasDisAud_combo;
        private System.Windows.Forms.ComboBox Empleabilidad_combo;
        private System.Windows.Forms.Label De_label;
        private System.Windows.Forms.Label Ver_label;
        private System.Windows.Forms.Label ConsultaGrafica_label;
    }
}

