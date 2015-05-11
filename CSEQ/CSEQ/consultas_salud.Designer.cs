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
            this.Reporte = new System.Windows.Forms.Button();
            this.back_picture = new System.Windows.Forms.PictureBox();
            this.x_picture = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.titulo = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.label2 = new System.Windows.Forms.Label();
            this.todoscensos_radio = new System.Windows.Forms.RadioButton();
            this.ID_censo = new System.Windows.Forms.ComboBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.auxiliarAuditivo_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tienen_radio = new System.Windows.Forms.RadioButton();
            this.noTienen_radio = new System.Windows.Forms.RadioButton();
            this.estadoSalud_combo = new System.Windows.Forms.ComboBox();
            this.salir_tt = new System.Windows.Forms.ToolTip(this.components);
            this.cerrarSesion_tt = new System.Windows.Forms.ToolTip(this.components);
            this.leve_checkbox = new System.Windows.Forms.CheckBox();
            this.media_checkbox = new System.Windows.Forms.CheckBox();
            this.severa_checkbox = new System.Windows.Forms.CheckBox();
            this.total_checkbox = new System.Windows.Forms.CheckBox();
            this.tipologia_combo = new System.Windows.Forms.ComboBox();
            this.bilateral_radio = new System.Windows.Forms.RadioButton();
            this.unilateral_radio = new System.Windows.Forms.RadioButton();
            this.eleccion_gp = new System.Windows.Forms.GroupBox();
            this.gradoPerdida_gp = new System.Windows.Forms.GroupBox();
            this.tipoPerdida_gp = new System.Windows.Forms.GroupBox();
            this.conductiva_checkbox = new System.Windows.Forms.CheckBox();
            this.neuro_checkbox = new System.Windows.Forms.CheckBox();
            this.mixta_checkbox = new System.Windows.Forms.CheckBox();
            this.retro_checkbox = new System.Windows.Forms.CheckBox();
            this.noSabe_checkbox = new System.Windows.Forms.CheckBox();
            this.postlingual_radio = new System.Windows.Forms.RadioButton();
            this.prelingual_radio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            this.eleccion_gp.SuspendLayout();
            this.gradoPerdida_gp.SuspendLayout();
            this.tipoPerdida_gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reporte
            // 
            this.Reporte.BackColor = System.Drawing.Color.White;
            this.Reporte.Enabled = false;
            this.Reporte.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte.Location = new System.Drawing.Point(83, 685);
            this.Reporte.Margin = new System.Windows.Forms.Padding(6);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(183, 71);
            this.Reporte.TabIndex = 18;
            this.Reporte.Text = "Crear Reporte";
            this.Reporte.UseVisualStyleBackColor = false;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // back_picture
            // 
            this.back_picture.BackColor = System.Drawing.Color.Transparent;
            this.back_picture.Image = ((System.Drawing.Image)(resources.GetObject("back_picture.Image")));
            this.back_picture.Location = new System.Drawing.Point(16, 15);
            this.back_picture.Margin = new System.Windows.Forms.Padding(6);
            this.back_picture.Name = "back_picture";
            this.back_picture.Size = new System.Drawing.Size(60, 56);
            this.back_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_picture.TabIndex = 14;
            this.back_picture.TabStop = false;
            this.back_picture.Click += new System.EventHandler(this.back_picture_Click);
            this.back_picture.MouseLeave += new System.EventHandler(this.back_picture_MouseLeave);
            this.back_picture.MouseHover += new System.EventHandler(this.back_picture_MouseHover);
            // 
            // x_picture
            // 
            this.x_picture.BackColor = System.Drawing.Color.Transparent;
            this.x_picture.Image = ((System.Drawing.Image)(resources.GetObject("x_picture.Image")));
            this.x_picture.Location = new System.Drawing.Point(1516, 19);
            this.x_picture.Margin = new System.Windows.Forms.Padding(4);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(60, 56);
            this.x_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.x_picture.TabIndex = 13;
            this.x_picture.TabStop = false;
            this.x_picture.Click += new System.EventHandler(this.x_picture_Click);
            this.x_picture.MouseHover += new System.EventHandler(this.x_picture_MouseHover);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft MHei", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo.Location = new System.Drawing.Point(604, 39);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(0, 57);
            this.titulo.TabIndex = 16;
            // 
            // zedGraph
            // 
            this.zedGraph.AutoSize = true;
            this.zedGraph.BackColor = System.Drawing.Color.Transparent;
            this.zedGraph.Location = new System.Drawing.Point(344, 387);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(12);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(1218, 613);
            this.zedGraph.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft MHei", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 38);
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
            this.todoscensos_radio.Location = new System.Drawing.Point(13, 114);
            this.todoscensos_radio.Margin = new System.Windows.Forms.Padding(4);
            this.todoscensos_radio.Name = "todoscensos_radio";
            this.todoscensos_radio.Size = new System.Drawing.Size(213, 33);
            this.todoscensos_radio.TabIndex = 20;
            this.todoscensos_radio.TabStop = true;
            this.todoscensos_radio.Text = "Todos los censos";
            this.todoscensos_radio.UseVisualStyleBackColor = false;
            this.todoscensos_radio.CheckedChanged += new System.EventHandler(this.todoscensos_radio_CheckedChanged);
            // 
            // ID_censo
            // 
            this.ID_censo.Enabled = false;
            this.ID_censo.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_censo.FormattingEnabled = true;
            this.ID_censo.Items.AddRange(new object[] {
            "Auxiliares auditivos por marca",
            "Personas que no tienen aparato auditivo",
            "Personas con implante coclear"});
            this.ID_censo.Location = new System.Drawing.Point(118, 45);
            this.ID_censo.Margin = new System.Windows.Forms.Padding(4);
            this.ID_censo.Name = "ID_censo";
            this.ID_censo.Size = new System.Drawing.Size(160, 51);
            this.ID_censo.TabIndex = 21;
            this.ID_censo.SelectionChangeCommitted += new System.EventHandler(this.ID_censo_SelectionChangeCommitted);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Image = global::CSEQ.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(1514, 77);
            this.logout.Margin = new System.Windows.Forms.Padding(8);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(66, 60);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 22;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseHover += new System.EventHandler(this.logout_MouseHover);
            // 
            // auxiliarAuditivo_combo
            // 
            this.auxiliarAuditivo_combo.Font = new System.Drawing.Font("Candara", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auxiliarAuditivo_combo.FormattingEnabled = true;
            this.auxiliarAuditivo_combo.Items.AddRange(new object[] {
            "Auxiliares auditivos por marca",
            "Personas con y sin aparato auditivo",
            "Personas con implante coclear"});
            this.auxiliarAuditivo_combo.Location = new System.Drawing.Point(172, 190);
            this.auxiliarAuditivo_combo.Margin = new System.Windows.Forms.Padding(4);
            this.auxiliarAuditivo_combo.Name = "auxiliarAuditivo_combo";
            this.auxiliarAuditivo_combo.Size = new System.Drawing.Size(592, 44);
            this.auxiliarAuditivo_combo.TabIndex = 0;
            this.auxiliarAuditivo_combo.Visible = false;
            this.auxiliarAuditivo_combo.SelectionChangeCommitted += new System.EventHandler(this.auxiliarAuditivo_combo_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft MHei", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Consulta";
            // 
            // tienen_radio
            // 
            this.tienen_radio.AutoSize = true;
            this.tienen_radio.BackColor = System.Drawing.Color.Transparent;
            this.tienen_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienen_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.tienen_radio.Location = new System.Drawing.Point(790, 165);
            this.tienen_radio.Margin = new System.Windows.Forms.Padding(4);
            this.tienen_radio.Name = "tienen_radio";
            this.tienen_radio.Size = new System.Drawing.Size(152, 40);
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
            this.noTienen_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTienen_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.noTienen_radio.Location = new System.Drawing.Point(790, 223);
            this.noTienen_radio.Margin = new System.Windows.Forms.Padding(4);
            this.noTienen_radio.Name = "noTienen_radio";
            this.noTienen_radio.Size = new System.Drawing.Size(167, 40);
            this.noTienen_radio.TabIndex = 23;
            this.noTienen_radio.TabStop = true;
            this.noTienen_radio.Text = "No tienen";
            this.noTienen_radio.UseVisualStyleBackColor = false;
            this.noTienen_radio.Visible = false;
            this.noTienen_radio.CheckedChanged += new System.EventHandler(this.noTienen_radio_CheckedChanged);
            // 
            // estadoSalud_combo
            // 
            this.estadoSalud_combo.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoSalud_combo.FormattingEnabled = true;
            this.estadoSalud_combo.Items.AddRange(new object[] {
            "Personas con alergia",
            "Personas con enfermedad"});
            this.estadoSalud_combo.Location = new System.Drawing.Point(172, 190);
            this.estadoSalud_combo.Margin = new System.Windows.Forms.Padding(4);
            this.estadoSalud_combo.Name = "estadoSalud_combo";
            this.estadoSalud_combo.Size = new System.Drawing.Size(592, 51);
            this.estadoSalud_combo.TabIndex = 24;
            this.estadoSalud_combo.Visible = false;
            this.estadoSalud_combo.SelectionChangeCommitted += new System.EventHandler(this.estadoSalud_combo_SelectionChangeCommitted);
            // 
            // leve_checkbox
            // 
            this.leve_checkbox.AutoSize = true;
            this.leve_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.leve_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leve_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.leve_checkbox.Location = new System.Drawing.Point(15, 44);
            this.leve_checkbox.Name = "leve_checkbox";
            this.leve_checkbox.Size = new System.Drawing.Size(93, 36);
            this.leve_checkbox.TabIndex = 25;
            this.leve_checkbox.Text = "Leve";
            this.leve_checkbox.UseVisualStyleBackColor = false;
            // 
            // media_checkbox
            // 
            this.media_checkbox.AutoSize = true;
            this.media_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.media_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.media_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.media_checkbox.Location = new System.Drawing.Point(15, 92);
            this.media_checkbox.Name = "media_checkbox";
            this.media_checkbox.Size = new System.Drawing.Size(111, 36);
            this.media_checkbox.TabIndex = 26;
            this.media_checkbox.Text = "Media";
            this.media_checkbox.UseVisualStyleBackColor = false;
            // 
            // severa_checkbox
            // 
            this.severa_checkbox.AutoSize = true;
            this.severa_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.severa_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.severa_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.severa_checkbox.Location = new System.Drawing.Point(15, 143);
            this.severa_checkbox.Name = "severa_checkbox";
            this.severa_checkbox.Size = new System.Drawing.Size(114, 36);
            this.severa_checkbox.TabIndex = 27;
            this.severa_checkbox.Text = "Severa";
            this.severa_checkbox.UseVisualStyleBackColor = false;
            // 
            // total_checkbox
            // 
            this.total_checkbox.AutoSize = true;
            this.total_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.total_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.total_checkbox.Location = new System.Drawing.Point(15, 192);
            this.total_checkbox.Name = "total_checkbox";
            this.total_checkbox.Size = new System.Drawing.Size(98, 36);
            this.total_checkbox.TabIndex = 28;
            this.total_checkbox.Text = "Total";
            this.total_checkbox.UseVisualStyleBackColor = false;
            // 
            // tipologia_combo
            // 
            this.tipologia_combo.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipologia_combo.FormattingEnabled = true;
            this.tipologia_combo.Items.AddRange(new object[] {
            "Grados de Pérdida Auditiva",
            "Pérdida Bilateral/Unilateral",
            "Causas de Pérdida Auditiva",
            "Tipos de Pérdida Auditiva",
            "Sordera Prolingual/Prelingual"});
            this.tipologia_combo.Location = new System.Drawing.Point(172, 191);
            this.tipologia_combo.Margin = new System.Windows.Forms.Padding(4);
            this.tipologia_combo.Name = "tipologia_combo";
            this.tipologia_combo.Size = new System.Drawing.Size(592, 51);
            this.tipologia_combo.TabIndex = 30;
            this.tipologia_combo.Visible = false;
            this.tipologia_combo.SelectionChangeCommitted += new System.EventHandler(this.tipologia_combo_SelectionChangeCommitted);
            // 
            // bilateral_radio
            // 
            this.bilateral_radio.AutoSize = true;
            this.bilateral_radio.BackColor = System.Drawing.Color.Transparent;
            this.bilateral_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilateral_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.bilateral_radio.Location = new System.Drawing.Point(790, 169);
            this.bilateral_radio.Margin = new System.Windows.Forms.Padding(4);
            this.bilateral_radio.Name = "bilateral_radio";
            this.bilateral_radio.Size = new System.Drawing.Size(145, 40);
            this.bilateral_radio.TabIndex = 31;
            this.bilateral_radio.TabStop = true;
            this.bilateral_radio.Text = "Bilateral";
            this.bilateral_radio.UseVisualStyleBackColor = false;
            this.bilateral_radio.Visible = false;
            // 
            // unilateral_radio
            // 
            this.unilateral_radio.AutoSize = true;
            this.unilateral_radio.BackColor = System.Drawing.Color.Transparent;
            this.unilateral_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unilateral_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.unilateral_radio.Location = new System.Drawing.Point(790, 217);
            this.unilateral_radio.Margin = new System.Windows.Forms.Padding(4);
            this.unilateral_radio.Name = "unilateral_radio";
            this.unilateral_radio.Size = new System.Drawing.Size(164, 40);
            this.unilateral_radio.TabIndex = 32;
            this.unilateral_radio.TabStop = true;
            this.unilateral_radio.Text = "Unilateral";
            this.unilateral_radio.UseVisualStyleBackColor = false;
            this.unilateral_radio.Visible = false;
            // 
            // eleccion_gp
            // 
            this.eleccion_gp.BackColor = System.Drawing.Color.Transparent;
            this.eleccion_gp.Controls.Add(this.label2);
            this.eleccion_gp.Controls.Add(this.ID_censo);
            this.eleccion_gp.Controls.Add(this.todoscensos_radio);
            this.eleccion_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleccion_gp.ForeColor = System.Drawing.Color.White;
            this.eleccion_gp.Location = new System.Drawing.Point(16, 450);
            this.eleccion_gp.Name = "eleccion_gp";
            this.eleccion_gp.Size = new System.Drawing.Size(313, 165);
            this.eleccion_gp.TabIndex = 33;
            this.eleccion_gp.TabStop = false;
            this.eleccion_gp.Text = "Elección Censo";
            // 
            // gradoPerdida_gp
            // 
            this.gradoPerdida_gp.BackColor = System.Drawing.Color.Transparent;
            this.gradoPerdida_gp.Controls.Add(this.leve_checkbox);
            this.gradoPerdida_gp.Controls.Add(this.media_checkbox);
            this.gradoPerdida_gp.Controls.Add(this.severa_checkbox);
            this.gradoPerdida_gp.Controls.Add(this.total_checkbox);
            this.gradoPerdida_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradoPerdida_gp.ForeColor = System.Drawing.Color.White;
            this.gradoPerdida_gp.Location = new System.Drawing.Point(892, 105);
            this.gradoPerdida_gp.Name = "gradoPerdida_gp";
            this.gradoPerdida_gp.Size = new System.Drawing.Size(254, 247);
            this.gradoPerdida_gp.TabIndex = 34;
            this.gradoPerdida_gp.TabStop = false;
            this.gradoPerdida_gp.Text = "Grado de Pérdida";
            this.gradoPerdida_gp.Visible = false;
            // 
            // tipoPerdida_gp
            // 
            this.tipoPerdida_gp.BackColor = System.Drawing.Color.Transparent;
            this.tipoPerdida_gp.Controls.Add(this.noSabe_checkbox);
            this.tipoPerdida_gp.Controls.Add(this.conductiva_checkbox);
            this.tipoPerdida_gp.Controls.Add(this.neuro_checkbox);
            this.tipoPerdida_gp.Controls.Add(this.mixta_checkbox);
            this.tipoPerdida_gp.Controls.Add(this.retro_checkbox);
            this.tipoPerdida_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPerdida_gp.ForeColor = System.Drawing.Color.White;
            this.tipoPerdida_gp.Location = new System.Drawing.Point(892, 97);
            this.tipoPerdida_gp.Name = "tipoPerdida_gp";
            this.tipoPerdida_gp.Size = new System.Drawing.Size(260, 275);
            this.tipoPerdida_gp.TabIndex = 35;
            this.tipoPerdida_gp.TabStop = false;
            this.tipoPerdida_gp.Text = "Tipo de Pérdida";
            this.tipoPerdida_gp.Visible = false;
            // 
            // conductiva_checkbox
            // 
            this.conductiva_checkbox.AutoSize = true;
            this.conductiva_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.conductiva_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conductiva_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.conductiva_checkbox.Location = new System.Drawing.Point(15, 36);
            this.conductiva_checkbox.Name = "conductiva_checkbox";
            this.conductiva_checkbox.Size = new System.Drawing.Size(163, 36);
            this.conductiva_checkbox.TabIndex = 25;
            this.conductiva_checkbox.Text = "Conductiva";
            this.conductiva_checkbox.UseVisualStyleBackColor = false;
            // 
            // neuro_checkbox
            // 
            this.neuro_checkbox.AutoSize = true;
            this.neuro_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.neuro_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neuro_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.neuro_checkbox.Location = new System.Drawing.Point(15, 84);
            this.neuro_checkbox.Name = "neuro_checkbox";
            this.neuro_checkbox.Size = new System.Drawing.Size(200, 36);
            this.neuro_checkbox.TabIndex = 26;
            this.neuro_checkbox.Text = "Neurosensorial";
            this.neuro_checkbox.UseVisualStyleBackColor = false;
            // 
            // mixta_checkbox
            // 
            this.mixta_checkbox.AutoSize = true;
            this.mixta_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.mixta_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mixta_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.mixta_checkbox.Location = new System.Drawing.Point(15, 135);
            this.mixta_checkbox.Name = "mixta_checkbox";
            this.mixta_checkbox.Size = new System.Drawing.Size(104, 36);
            this.mixta_checkbox.TabIndex = 27;
            this.mixta_checkbox.Text = "Mixta";
            this.mixta_checkbox.UseVisualStyleBackColor = false;
            // 
            // retro_checkbox
            // 
            this.retro_checkbox.AutoSize = true;
            this.retro_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.retro_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retro_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.retro_checkbox.Location = new System.Drawing.Point(15, 184);
            this.retro_checkbox.Name = "retro_checkbox";
            this.retro_checkbox.Size = new System.Drawing.Size(176, 36);
            this.retro_checkbox.TabIndex = 28;
            this.retro_checkbox.Text = "Retrococlear";
            this.retro_checkbox.UseVisualStyleBackColor = false;
            // 
            // noSabe_checkbox
            // 
            this.noSabe_checkbox.AutoSize = true;
            this.noSabe_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.noSabe_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noSabe_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.noSabe_checkbox.Location = new System.Drawing.Point(15, 230);
            this.noSabe_checkbox.Name = "noSabe_checkbox";
            this.noSabe_checkbox.Size = new System.Drawing.Size(133, 36);
            this.noSabe_checkbox.TabIndex = 29;
            this.noSabe_checkbox.Text = "No sabe";
            this.noSabe_checkbox.UseVisualStyleBackColor = false;
            // 
            // postlingual_radio
            // 
            this.postlingual_radio.AutoSize = true;
            this.postlingual_radio.BackColor = System.Drawing.Color.Transparent;
            this.postlingual_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postlingual_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.postlingual_radio.Location = new System.Drawing.Point(790, 217);
            this.postlingual_radio.Margin = new System.Windows.Forms.Padding(4);
            this.postlingual_radio.Name = "postlingual_radio";
            this.postlingual_radio.Size = new System.Drawing.Size(183, 40);
            this.postlingual_radio.TabIndex = 37;
            this.postlingual_radio.TabStop = true;
            this.postlingual_radio.Text = "Postlingual";
            this.postlingual_radio.UseVisualStyleBackColor = false;
            this.postlingual_radio.Visible = false;
            // 
            // prelingual_radio
            // 
            this.prelingual_radio.AutoSize = true;
            this.prelingual_radio.BackColor = System.Drawing.Color.Transparent;
            this.prelingual_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prelingual_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.prelingual_radio.Location = new System.Drawing.Point(790, 169);
            this.prelingual_radio.Margin = new System.Windows.Forms.Padding(4);
            this.prelingual_radio.Name = "prelingual_radio";
            this.prelingual_radio.Size = new System.Drawing.Size(169, 40);
            this.prelingual_radio.TabIndex = 36;
            this.prelingual_radio.TabStop = true;
            this.prelingual_radio.Text = "Prelingual";
            this.prelingual_radio.UseVisualStyleBackColor = false;
            this.prelingual_radio.Visible = false;
            // 
            // consultas_salud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CSEQ.Properties.Resources.fondonopesado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 1019);
            this.Controls.Add(this.postlingual_radio);
            this.Controls.Add(this.prelingual_radio);
            this.Controls.Add(this.tipoPerdida_gp);
            this.Controls.Add(this.gradoPerdida_gp);
            this.Controls.Add(this.eleccion_gp);
            this.Controls.Add(this.unilateral_radio);
            this.Controls.Add(this.bilateral_radio);
            this.Controls.Add(this.tipologia_combo);
            this.Controls.Add(this.noTienen_radio);
            this.Controls.Add(this.tienen_radio);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.back_picture);
            this.Controls.Add(this.Reporte);
            this.Controls.Add(this.x_picture);
            this.Controls.Add(this.estadoSalud_combo);
            this.Controls.Add(this.auxiliarAuditivo_combo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "consultas_salud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultas_salud";
            this.Load += new System.EventHandler(this.consultas_salud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            this.eleccion_gp.ResumeLayout(false);
            this.eleccion_gp.PerformLayout();
            this.gradoPerdida_gp.ResumeLayout(false);
            this.gradoPerdida_gp.PerformLayout();
            this.tipoPerdida_gp.ResumeLayout(false);
            this.tipoPerdida_gp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back_picture;
        private System.Windows.Forms.PictureBox x_picture;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label titulo;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button Reporte;
        private System.Windows.Forms.RadioButton todoscensos_radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ID_censo;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.ComboBox auxiliarAuditivo_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton tienen_radio;
        private System.Windows.Forms.RadioButton noTienen_radio;
        private System.Windows.Forms.ComboBox estadoSalud_combo;
        private System.Windows.Forms.ToolTip salir_tt;
        private System.Windows.Forms.ToolTip cerrarSesion_tt;
        private System.Windows.Forms.CheckBox leve_checkbox;
        private System.Windows.Forms.CheckBox media_checkbox;
        private System.Windows.Forms.CheckBox severa_checkbox;
        private System.Windows.Forms.CheckBox total_checkbox;
        private System.Windows.Forms.ComboBox tipologia_combo;
        private System.Windows.Forms.RadioButton bilateral_radio;
        private System.Windows.Forms.RadioButton unilateral_radio;
        private System.Windows.Forms.GroupBox eleccion_gp;
        private System.Windows.Forms.GroupBox gradoPerdida_gp;
        private System.Windows.Forms.GroupBox tipoPerdida_gp;
        private System.Windows.Forms.CheckBox noSabe_checkbox;
        private System.Windows.Forms.CheckBox conductiva_checkbox;
        private System.Windows.Forms.CheckBox neuro_checkbox;
        private System.Windows.Forms.CheckBox mixta_checkbox;
        private System.Windows.Forms.CheckBox retro_checkbox;
        private System.Windows.Forms.RadioButton postlingual_radio;
        private System.Windows.Forms.RadioButton prelingual_radio;
    }
}