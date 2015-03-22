namespace CSEQ
{
    partial class ConsultaRedactada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaRedactada));
            this.ConsultaRedactada_label = new System.Windows.Forms.Label();
            this.PersonasDisAud_combo = new System.Windows.Forms.ComboBox();
            this.Empleabilidad_combo = new System.Windows.Forms.ComboBox();
            this.De_label = new System.Windows.Forms.Label();
            this.Ver_label = new System.Windows.Forms.Label();
            this.conEmpleo_dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEmpleo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConEm_radioBtn = new System.Windows.Forms.RadioButton();
            this.SinEm_radioBtn = new System.Windows.Forms.RadioButton();
            this.PersonasEmpleo_label = new System.Windows.Forms.Label();
            this.NumPersonas_label = new System.Windows.Forms.Label();
            this.Porcentaje_label = new System.Windows.Forms.Label();
            this.NumPorcentaje_label = new System.Windows.Forms.Label();
            this.x_picture = new System.Windows.Forms.PictureBox();
            this.Atras_picture = new System.Windows.Forms.PictureBox();
            this.ImprimirConsulta_btn = new System.Windows.Forms.Button();
            this.GuardarConsulta_txt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.conEmpleo_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaRedactada_label
            // 
            this.ConsultaRedactada_label.AutoSize = true;
            this.ConsultaRedactada_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaRedactada_label.ForeColor = System.Drawing.Color.White;
            this.ConsultaRedactada_label.Location = new System.Drawing.Point(255, 18);
            this.ConsultaRedactada_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConsultaRedactada_label.Name = "ConsultaRedactada_label";
            this.ConsultaRedactada_label.Size = new System.Drawing.Size(307, 37);
            this.ConsultaRedactada_label.TabIndex = 32;
            this.ConsultaRedactada_label.Text = "Consulta Redactada";
            // 
            // PersonasDisAud_combo
            // 
            this.PersonasDisAud_combo.FormattingEnabled = true;
            this.PersonasDisAud_combo.Location = new System.Drawing.Point(475, 78);
            this.PersonasDisAud_combo.Name = "PersonasDisAud_combo";
            this.PersonasDisAud_combo.Size = new System.Drawing.Size(200, 21);
            this.PersonasDisAud_combo.TabIndex = 39;
            this.PersonasDisAud_combo.Text = "Personas con discapacidad auditiva";
            // 
            // Empleabilidad_combo
            // 
            this.Empleabilidad_combo.FormattingEnabled = true;
            this.Empleabilidad_combo.Location = new System.Drawing.Point(193, 78);
            this.Empleabilidad_combo.Name = "Empleabilidad_combo";
            this.Empleabilidad_combo.Size = new System.Drawing.Size(121, 21);
            this.Empleabilidad_combo.TabIndex = 38;
            this.Empleabilidad_combo.Text = "Empleabilidad";
            // 
            // De_label
            // 
            this.De_label.AutoSize = true;
            this.De_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.De_label.ForeColor = System.Drawing.Color.White;
            this.De_label.Location = new System.Drawing.Point(414, 75);
            this.De_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.De_label.Name = "De_label";
            this.De_label.Size = new System.Drawing.Size(39, 24);
            this.De_label.TabIndex = 37;
            this.De_label.Text = "De:";
            // 
            // Ver_label
            // 
            this.Ver_label.AutoSize = true;
            this.Ver_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Ver_label.ForeColor = System.Drawing.Color.White;
            this.Ver_label.Location = new System.Drawing.Point(121, 75);
            this.Ver_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ver_label.Name = "Ver_label";
            this.Ver_label.Size = new System.Drawing.Size(45, 24);
            this.Ver_label.TabIndex = 36;
            this.Ver_label.Text = "Ver:";
            // 
            // conEmpleo_dataGrid
            // 
            this.conEmpleo_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conEmpleo_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.DescripcionEmpleo});
            this.conEmpleo_dataGrid.Location = new System.Drawing.Point(129, 182);
            this.conEmpleo_dataGrid.Name = "conEmpleo_dataGrid";
            this.conEmpleo_dataGrid.Size = new System.Drawing.Size(543, 154);
            this.conEmpleo_dataGrid.TabIndex = 42;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // DescripcionEmpleo
            // 
            this.DescripcionEmpleo.HeaderText = "Descripción del empleo";
            this.DescripcionEmpleo.Name = "DescripcionEmpleo";
            this.DescripcionEmpleo.Width = 250;
            // 
            // ConEm_radioBtn
            // 
            this.ConEm_radioBtn.AutoSize = true;
            this.ConEm_radioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ConEm_radioBtn.ForeColor = System.Drawing.Color.White;
            this.ConEm_radioBtn.Location = new System.Drawing.Point(193, 133);
            this.ConEm_radioBtn.Name = "ConEm_radioBtn";
            this.ConEm_radioBtn.Size = new System.Drawing.Size(132, 28);
            this.ConEm_radioBtn.TabIndex = 43;
            this.ConEm_radioBtn.TabStop = true;
            this.ConEm_radioBtn.Text = "Con empleo";
            this.ConEm_radioBtn.UseVisualStyleBackColor = true;
            this.ConEm_radioBtn.CheckedChanged += new System.EventHandler(this.ConEm_radioBtn_CheckedChanged);
            // 
            // SinEm_radioBtn
            // 
            this.SinEm_radioBtn.AutoSize = true;
            this.SinEm_radioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SinEm_radioBtn.ForeColor = System.Drawing.Color.White;
            this.SinEm_radioBtn.Location = new System.Drawing.Point(430, 133);
            this.SinEm_radioBtn.Name = "SinEm_radioBtn";
            this.SinEm_radioBtn.Size = new System.Drawing.Size(124, 28);
            this.SinEm_radioBtn.TabIndex = 44;
            this.SinEm_radioBtn.TabStop = true;
            this.SinEm_radioBtn.Text = "Sin empleo";
            this.SinEm_radioBtn.UseVisualStyleBackColor = true;
            this.SinEm_radioBtn.CheckedChanged += new System.EventHandler(this.SinEm_radioBtn_CheckedChanged);
            // 
            // PersonasEmpleo_label
            // 
            this.PersonasEmpleo_label.AutoSize = true;
            this.PersonasEmpleo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PersonasEmpleo_label.ForeColor = System.Drawing.Color.White;
            this.PersonasEmpleo_label.Location = new System.Drawing.Point(269, 356);
            this.PersonasEmpleo_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PersonasEmpleo_label.Name = "PersonasEmpleo_label";
            this.PersonasEmpleo_label.Size = new System.Drawing.Size(200, 24);
            this.PersonasEmpleo_label.TabIndex = 45;
            this.PersonasEmpleo_label.Text = "Personas con empleo:";
            // 
            // NumPersonas_label
            // 
            this.NumPersonas_label.AutoSize = true;
            this.NumPersonas_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumPersonas_label.ForeColor = System.Drawing.Color.White;
            this.NumPersonas_label.Location = new System.Drawing.Point(486, 356);
            this.NumPersonas_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumPersonas_label.Name = "NumPersonas_label";
            this.NumPersonas_label.Size = new System.Drawing.Size(30, 24);
            this.NumPersonas_label.TabIndex = 46;
            this.NumPersonas_label.Text = "55";
            // 
            // Porcentaje_label
            // 
            this.Porcentaje_label.AutoSize = true;
            this.Porcentaje_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Porcentaje_label.ForeColor = System.Drawing.Color.White;
            this.Porcentaje_label.Location = new System.Drawing.Point(269, 394);
            this.Porcentaje_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Porcentaje_label.Name = "Porcentaje_label";
            this.Porcentaje_label.Size = new System.Drawing.Size(105, 24);
            this.Porcentaje_label.TabIndex = 47;
            this.Porcentaje_label.Text = "Porcentaje:";
            // 
            // NumPorcentaje_label
            // 
            this.NumPorcentaje_label.AutoSize = true;
            this.NumPorcentaje_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumPorcentaje_label.ForeColor = System.Drawing.Color.White;
            this.NumPorcentaje_label.Location = new System.Drawing.Point(486, 394);
            this.NumPorcentaje_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumPorcentaje_label.Name = "NumPorcentaje_label";
            this.NumPorcentaje_label.Size = new System.Drawing.Size(45, 24);
            this.NumPorcentaje_label.TabIndex = 48;
            this.NumPorcentaje_label.Text = "55%";
            // 
            // x_picture
            // 
            this.x_picture.Image = ((System.Drawing.Image)(resources.GetObject("x_picture.Image")));
            this.x_picture.Location = new System.Drawing.Point(770, 2);
            this.x_picture.Margin = new System.Windows.Forms.Padding(2);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(30, 29);
            this.x_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.x_picture.TabIndex = 49;
            this.x_picture.TabStop = false;
            this.x_picture.Click += new System.EventHandler(this.x_picture_Click);
            // 
            // Atras_picture
            // 
            this.Atras_picture.Image = ((System.Drawing.Image)(resources.GetObject("Atras_picture.Image")));
            this.Atras_picture.Location = new System.Drawing.Point(1, 521);
            this.Atras_picture.Name = "Atras_picture";
            this.Atras_picture.Size = new System.Drawing.Size(47, 47);
            this.Atras_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Atras_picture.TabIndex = 50;
            this.Atras_picture.TabStop = false;
            // 
            // ImprimirConsulta_btn
            // 
            this.ImprimirConsulta_btn.ForeColor = System.Drawing.Color.Black;
            this.ImprimirConsulta_btn.Location = new System.Drawing.Point(492, 441);
            this.ImprimirConsulta_btn.Name = "ImprimirConsulta_btn";
            this.ImprimirConsulta_btn.Size = new System.Drawing.Size(96, 40);
            this.ImprimirConsulta_btn.TabIndex = 52;
            this.ImprimirConsulta_btn.Text = "Imprimir consulta";
            this.ImprimirConsulta_btn.UseVisualStyleBackColor = true;
            // 
            // GuardarConsulta_txt
            // 
            this.GuardarConsulta_txt.ForeColor = System.Drawing.Color.Black;
            this.GuardarConsulta_txt.Location = new System.Drawing.Point(213, 441);
            this.GuardarConsulta_txt.Name = "GuardarConsulta_txt";
            this.GuardarConsulta_txt.Size = new System.Drawing.Size(96, 40);
            this.GuardarConsulta_txt.TabIndex = 51;
            this.GuardarConsulta_txt.Text = "Guardar consulta";
            this.GuardarConsulta_txt.UseVisualStyleBackColor = true;
            // 
            // ConsultaRedactada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.ImprimirConsulta_btn);
            this.Controls.Add(this.GuardarConsulta_txt);
            this.Controls.Add(this.Atras_picture);
            this.Controls.Add(this.x_picture);
            this.Controls.Add(this.NumPorcentaje_label);
            this.Controls.Add(this.Porcentaje_label);
            this.Controls.Add(this.NumPersonas_label);
            this.Controls.Add(this.PersonasEmpleo_label);
            this.Controls.Add(this.SinEm_radioBtn);
            this.Controls.Add(this.ConEm_radioBtn);
            this.Controls.Add(this.conEmpleo_dataGrid);
            this.Controls.Add(this.PersonasDisAud_combo);
            this.Controls.Add(this.Empleabilidad_combo);
            this.Controls.Add(this.De_label);
            this.Controls.Add(this.Ver_label);
            this.Controls.Add(this.ConsultaRedactada_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaRedactada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaRedactada";
            ((System.ComponentModel.ISupportInitialize)(this.conEmpleo_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Atras_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConsultaRedactada_label;
        private System.Windows.Forms.ComboBox PersonasDisAud_combo;
        private System.Windows.Forms.ComboBox Empleabilidad_combo;
        private System.Windows.Forms.Label De_label;
        private System.Windows.Forms.Label Ver_label;
        private System.Windows.Forms.DataGridView conEmpleo_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEmpleo;
        private System.Windows.Forms.RadioButton ConEm_radioBtn;
        private System.Windows.Forms.RadioButton SinEm_radioBtn;
        private System.Windows.Forms.Label PersonasEmpleo_label;
        private System.Windows.Forms.Label NumPersonas_label;
        private System.Windows.Forms.Label Porcentaje_label;
        private System.Windows.Forms.Label NumPorcentaje_label;
        private System.Windows.Forms.PictureBox x_picture;
        private System.Windows.Forms.PictureBox Atras_picture;
        private System.Windows.Forms.Button ImprimirConsulta_btn;
        private System.Windows.Forms.Button GuardarConsulta_txt;
    }
}