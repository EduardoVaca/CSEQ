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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.tabControlGraficas = new System.Windows.Forms.TabControl();
            this.tabGraficaBarras = new System.Windows.Forms.TabPage();
            this.chartBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLlenarBarras = new System.Windows.Forms.Button();
            this.tabGraficaPay = new System.Windows.Forms.TabPage();
            this.btnLlenarPay = new System.Windows.Forms.Button();
            this.chartPay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControlGraficas.SuspendLayout();
            this.tabGraficaBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).BeginInit();
            this.tabGraficaPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlGraficas
            // 
            this.tabControlGraficas.Controls.Add(this.tabGraficaBarras);
            this.tabControlGraficas.Controls.Add(this.tabGraficaPay);
            this.tabControlGraficas.Location = new System.Drawing.Point(102, 83);
            this.tabControlGraficas.Name = "tabControlGraficas";
            this.tabControlGraficas.SelectedIndex = 0;
            this.tabControlGraficas.Size = new System.Drawing.Size(584, 367);
            this.tabControlGraficas.TabIndex = 0;
            // 
            // tabGraficaBarras
            // 
            this.tabGraficaBarras.Controls.Add(this.chartBarras);
            this.tabGraficaBarras.Controls.Add(this.btnLlenarBarras);
            this.tabGraficaBarras.Location = new System.Drawing.Point(4, 22);
            this.tabGraficaBarras.Name = "tabGraficaBarras";
            this.tabGraficaBarras.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraficaBarras.Size = new System.Drawing.Size(576, 341);
            this.tabGraficaBarras.TabIndex = 0;
            this.tabGraficaBarras.Text = "Gráfica de barras";
            this.tabGraficaBarras.UseVisualStyleBackColor = true;
            // 
            // chartBarras
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBarras.ChartAreas.Add(chartArea1);
            this.chartBarras.Location = new System.Drawing.Point(28, 6);
            this.chartBarras.Name = "chartBarras";
            this.chartBarras.Size = new System.Drawing.Size(521, 300);
            this.chartBarras.TabIndex = 1;
            this.chartBarras.Text = "chart1";
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
            // Graficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.tabControlGraficas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Graficas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráficas";
            this.Load += new System.EventHandler(this.Graficas_Load);
            this.tabControlGraficas.ResumeLayout(false);
            this.tabGraficaBarras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBarras)).EndInit();
            this.tabGraficaPay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGraficas;
        private System.Windows.Forms.TabPage tabGraficaBarras;
        private System.Windows.Forms.TabPage tabGraficaPay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBarras;
        private System.Windows.Forms.Button btnLlenarBarras;
        private System.Windows.Forms.Button btnLlenarPay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPay;
    }
}

