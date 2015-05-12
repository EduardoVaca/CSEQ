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
            this.eleccion_gp = new System.Windows.Forms.GroupBox();
            this.gradoPerdida_gp = new System.Windows.Forms.GroupBox();
            this.profunda_checkbox = new System.Windows.Forms.CheckBox();
            this.tipoPerdida_gp = new System.Windows.Forms.GroupBox();
            this.no_Sabe_checkbox = new System.Windows.Forms.CheckBox();
            this.noSabe_checkbox = new System.Windows.Forms.CheckBox();
            this.conductiva_checkbox = new System.Windows.Forms.CheckBox();
            this.neuro_checkbox = new System.Windows.Forms.CheckBox();
            this.mixta_checkbox = new System.Windows.Forms.CheckBox();
            this.retro_checkbox = new System.Windows.Forms.CheckBox();
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
            this.Reporte.Location = new System.Drawing.Point(42, 356);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(92, 37);
            this.Reporte.TabIndex = 18;
            this.Reporte.Text = "Crear Reporte";
            this.Reporte.UseVisualStyleBackColor = false;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // back_picture
            // 
            this.back_picture.BackColor = System.Drawing.Color.Transparent;
            this.back_picture.Image = ((System.Drawing.Image)(resources.GetObject("back_picture.Image")));
            this.back_picture.Location = new System.Drawing.Point(8, 8);
            this.back_picture.Name = "back_picture";
            this.back_picture.Size = new System.Drawing.Size(30, 29);
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
            this.x_picture.Location = new System.Drawing.Point(758, 10);
            this.x_picture.Margin = new System.Windows.Forms.Padding(2);
            this.x_picture.Name = "x_picture";
            this.x_picture.Size = new System.Drawing.Size(30, 29);
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
            this.titulo.Location = new System.Drawing.Point(302, 20);
            this.titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(0, 30);
            this.titulo.TabIndex = 16;
            // 
            // zedGraph
            // 
            this.zedGraph.AutoSize = true;
            this.zedGraph.BackColor = System.Drawing.Color.Transparent;
            this.zedGraph.Location = new System.Drawing.Point(172, 201);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(6);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(628, 328);
            this.zedGraph.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft MHei", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
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
            // ID_censo
            // 
            this.ID_censo.Enabled = false;
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
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Image = global::CSEQ.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(757, 40);
            this.logout.Margin = new System.Windows.Forms.Padding(4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(33, 31);
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
            this.auxiliarAuditivo_combo.Location = new System.Drawing.Point(86, 99);
            this.auxiliarAuditivo_combo.Margin = new System.Windows.Forms.Padding(2);
            this.auxiliarAuditivo_combo.Name = "auxiliarAuditivo_combo";
            this.auxiliarAuditivo_combo.Size = new System.Drawing.Size(298, 25);
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
            this.label1.Location = new System.Drawing.Point(9, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Consulta";
            // 
            // tienen_radio
            // 
            this.tienen_radio.AutoSize = true;
            this.tienen_radio.BackColor = System.Drawing.Color.Transparent;
            this.tienen_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienen_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.tienen_radio.Location = new System.Drawing.Point(395, 86);
            this.tienen_radio.Margin = new System.Windows.Forms.Padding(2);
            this.tienen_radio.Name = "tienen_radio";
            this.tienen_radio.Size = new System.Drawing.Size(82, 23);
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
            this.noTienen_radio.Location = new System.Drawing.Point(395, 116);
            this.noTienen_radio.Margin = new System.Windows.Forms.Padding(2);
            this.noTienen_radio.Name = "noTienen_radio";
            this.noTienen_radio.Size = new System.Drawing.Size(89, 23);
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
            this.estadoSalud_combo.Location = new System.Drawing.Point(86, 99);
            this.estadoSalud_combo.Margin = new System.Windows.Forms.Padding(2);
            this.estadoSalud_combo.Name = "estadoSalud_combo";
            this.estadoSalud_combo.Size = new System.Drawing.Size(298, 29);
            this.estadoSalud_combo.TabIndex = 24;
            this.estadoSalud_combo.Visible = false;
            this.estadoSalud_combo.SelectionChangeCommitted += new System.EventHandler(this.estadoSalud_combo_SelectionChangeCommitted);
            // 
            // leve_checkbox
            // 
            this.leve_checkbox.AutoSize = true;
            this.leve_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.leve_checkbox.Checked = true;
            this.leve_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leve_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leve_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.leve_checkbox.Location = new System.Drawing.Point(8, 13);
            this.leve_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.leve_checkbox.Name = "leve_checkbox";
            this.leve_checkbox.Size = new System.Drawing.Size(51, 20);
            this.leve_checkbox.TabIndex = 25;
            this.leve_checkbox.Text = "Leve";
            this.leve_checkbox.UseVisualStyleBackColor = false;
            this.leve_checkbox.CheckedChanged += new System.EventHandler(this.leve_checkbox_CheckedChanged);
            // 
            // media_checkbox
            // 
            this.media_checkbox.AutoSize = true;
            this.media_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.media_checkbox.Checked = true;
            this.media_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.media_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.media_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.media_checkbox.Location = new System.Drawing.Point(8, 35);
            this.media_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.media_checkbox.Name = "media_checkbox";
            this.media_checkbox.Size = new System.Drawing.Size(59, 20);
            this.media_checkbox.TabIndex = 26;
            this.media_checkbox.Text = "Media";
            this.media_checkbox.UseVisualStyleBackColor = false;
            this.media_checkbox.CheckedChanged += new System.EventHandler(this.media_checkbox_CheckedChanged);
            // 
            // severa_checkbox
            // 
            this.severa_checkbox.AutoSize = true;
            this.severa_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.severa_checkbox.Checked = true;
            this.severa_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.severa_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.severa_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.severa_checkbox.Location = new System.Drawing.Point(8, 57);
            this.severa_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.severa_checkbox.Name = "severa_checkbox";
            this.severa_checkbox.Size = new System.Drawing.Size(61, 20);
            this.severa_checkbox.TabIndex = 27;
            this.severa_checkbox.Text = "Severa";
            this.severa_checkbox.UseVisualStyleBackColor = false;
            this.severa_checkbox.CheckedChanged += new System.EventHandler(this.severa_checkbox_CheckedChanged);
            // 
            // total_checkbox
            // 
            this.total_checkbox.AutoSize = true;
            this.total_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.total_checkbox.Checked = true;
            this.total_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.total_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.total_checkbox.Location = new System.Drawing.Point(8, 103);
            this.total_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.total_checkbox.Name = "total_checkbox";
            this.total_checkbox.Size = new System.Drawing.Size(53, 20);
            this.total_checkbox.TabIndex = 28;
            this.total_checkbox.Text = "Total";
            this.total_checkbox.UseVisualStyleBackColor = false;
            this.total_checkbox.CheckedChanged += new System.EventHandler(this.total_checkbox_CheckedChanged);
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
            this.tipologia_combo.Location = new System.Drawing.Point(86, 99);
            this.tipologia_combo.Margin = new System.Windows.Forms.Padding(2);
            this.tipologia_combo.Name = "tipologia_combo";
            this.tipologia_combo.Size = new System.Drawing.Size(298, 29);
            this.tipologia_combo.TabIndex = 30;
            this.tipologia_combo.Visible = false;
            this.tipologia_combo.SelectionChangeCommitted += new System.EventHandler(this.tipologia_combo_SelectionChangeCommitted);
            // 
            // eleccion_gp
            // 
            this.eleccion_gp.BackColor = System.Drawing.Color.Transparent;
            this.eleccion_gp.Controls.Add(this.label2);
            this.eleccion_gp.Controls.Add(this.ID_censo);
            this.eleccion_gp.Controls.Add(this.todoscensos_radio);
            this.eleccion_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleccion_gp.ForeColor = System.Drawing.Color.White;
            this.eleccion_gp.Location = new System.Drawing.Point(8, 234);
            this.eleccion_gp.Margin = new System.Windows.Forms.Padding(2);
            this.eleccion_gp.Name = "eleccion_gp";
            this.eleccion_gp.Padding = new System.Windows.Forms.Padding(2);
            this.eleccion_gp.Size = new System.Drawing.Size(156, 86);
            this.eleccion_gp.TabIndex = 33;
            this.eleccion_gp.TabStop = false;
            this.eleccion_gp.Text = "Elección Censo";
            // 
            // gradoPerdida_gp
            // 
            this.gradoPerdida_gp.BackColor = System.Drawing.Color.Transparent;
            this.gradoPerdida_gp.Controls.Add(this.profunda_checkbox);
            this.gradoPerdida_gp.Controls.Add(this.leve_checkbox);
            this.gradoPerdida_gp.Controls.Add(this.media_checkbox);
            this.gradoPerdida_gp.Controls.Add(this.severa_checkbox);
            this.gradoPerdida_gp.Controls.Add(this.total_checkbox);
            this.gradoPerdida_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradoPerdida_gp.ForeColor = System.Drawing.Color.White;
            this.gradoPerdida_gp.Location = new System.Drawing.Point(446, 55);
            this.gradoPerdida_gp.Margin = new System.Windows.Forms.Padding(2);
            this.gradoPerdida_gp.Name = "gradoPerdida_gp";
            this.gradoPerdida_gp.Padding = new System.Windows.Forms.Padding(2);
            this.gradoPerdida_gp.Size = new System.Drawing.Size(127, 128);
            this.gradoPerdida_gp.TabIndex = 34;
            this.gradoPerdida_gp.TabStop = false;
            this.gradoPerdida_gp.Text = "Grado de Pérdida";
            this.gradoPerdida_gp.Visible = false;
            // 
            // profunda_checkbox
            // 
            this.profunda_checkbox.AutoSize = true;
            this.profunda_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.profunda_checkbox.Checked = true;
            this.profunda_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.profunda_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profunda_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.profunda_checkbox.Location = new System.Drawing.Point(8, 79);
            this.profunda_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.profunda_checkbox.Name = "profunda_checkbox";
            this.profunda_checkbox.Size = new System.Drawing.Size(76, 20);
            this.profunda_checkbox.TabIndex = 29;
            this.profunda_checkbox.Text = "Profunda";
            this.profunda_checkbox.UseVisualStyleBackColor = false;
            this.profunda_checkbox.CheckedChanged += new System.EventHandler(this.profunda_checkbox_CheckedChanged);
            // 
            // tipoPerdida_gp
            // 
            this.tipoPerdida_gp.BackColor = System.Drawing.Color.Transparent;
            this.tipoPerdida_gp.Controls.Add(this.no_Sabe_checkbox);
            this.tipoPerdida_gp.Controls.Add(this.noSabe_checkbox);
            this.tipoPerdida_gp.Controls.Add(this.conductiva_checkbox);
            this.tipoPerdida_gp.Controls.Add(this.neuro_checkbox);
            this.tipoPerdida_gp.Controls.Add(this.mixta_checkbox);
            this.tipoPerdida_gp.Controls.Add(this.retro_checkbox);
            this.tipoPerdida_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPerdida_gp.ForeColor = System.Drawing.Color.White;
            this.tipoPerdida_gp.Location = new System.Drawing.Point(446, 50);
            this.tipoPerdida_gp.Margin = new System.Windows.Forms.Padding(2);
            this.tipoPerdida_gp.Name = "tipoPerdida_gp";
            this.tipoPerdida_gp.Padding = new System.Windows.Forms.Padding(2);
            this.tipoPerdida_gp.Size = new System.Drawing.Size(130, 143);
            this.tipoPerdida_gp.TabIndex = 35;
            this.tipoPerdida_gp.TabStop = false;
            this.tipoPerdida_gp.Text = "Tipo de Pérdida";
            this.tipoPerdida_gp.Visible = false;
            // 
            // no_Sabe_checkbox
            // 
            this.no_Sabe_checkbox.AutoSize = true;
            this.no_Sabe_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.no_Sabe_checkbox.Checked = true;
            this.no_Sabe_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.no_Sabe_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_Sabe_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.no_Sabe_checkbox.Location = new System.Drawing.Point(8, 119);
            this.no_Sabe_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.no_Sabe_checkbox.Name = "no_Sabe_checkbox";
            this.no_Sabe_checkbox.Size = new System.Drawing.Size(70, 20);
            this.no_Sabe_checkbox.TabIndex = 30;
            this.no_Sabe_checkbox.Text = "No sabe";
            this.no_Sabe_checkbox.UseVisualStyleBackColor = false;
            this.no_Sabe_checkbox.CheckedChanged += new System.EventHandler(this.no_Sabe_checkbox_CheckedChanged);
            // 
            // noSabe_checkbox
            // 
            this.noSabe_checkbox.AutoSize = true;
            this.noSabe_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.noSabe_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noSabe_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.noSabe_checkbox.Location = new System.Drawing.Point(15, 230);
            this.noSabe_checkbox.Name = "noSabe_checkbox";
            this.noSabe_checkbox.Size = new System.Drawing.Size(70, 20);
            this.noSabe_checkbox.TabIndex = 29;
            this.noSabe_checkbox.Text = "No sabe";
            this.noSabe_checkbox.UseVisualStyleBackColor = false;
            // 
            // conductiva_checkbox
            // 
            this.conductiva_checkbox.AutoSize = true;
            this.conductiva_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.conductiva_checkbox.Checked = true;
            this.conductiva_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.conductiva_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conductiva_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.conductiva_checkbox.Location = new System.Drawing.Point(8, 19);
            this.conductiva_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.conductiva_checkbox.Name = "conductiva_checkbox";
            this.conductiva_checkbox.Size = new System.Drawing.Size(86, 20);
            this.conductiva_checkbox.TabIndex = 25;
            this.conductiva_checkbox.Text = "Conductiva";
            this.conductiva_checkbox.UseVisualStyleBackColor = false;
            this.conductiva_checkbox.CheckedChanged += new System.EventHandler(this.conductiva_checkbox_CheckedChanged);
            // 
            // neuro_checkbox
            // 
            this.neuro_checkbox.AutoSize = true;
            this.neuro_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.neuro_checkbox.Checked = true;
            this.neuro_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.neuro_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neuro_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.neuro_checkbox.Location = new System.Drawing.Point(8, 44);
            this.neuro_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.neuro_checkbox.Name = "neuro_checkbox";
            this.neuro_checkbox.Size = new System.Drawing.Size(106, 20);
            this.neuro_checkbox.TabIndex = 26;
            this.neuro_checkbox.Text = "Neurosensorial";
            this.neuro_checkbox.UseVisualStyleBackColor = false;
            this.neuro_checkbox.CheckedChanged += new System.EventHandler(this.neuro_checkbox_CheckedChanged);
            // 
            // mixta_checkbox
            // 
            this.mixta_checkbox.AutoSize = true;
            this.mixta_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.mixta_checkbox.Checked = true;
            this.mixta_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mixta_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mixta_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.mixta_checkbox.Location = new System.Drawing.Point(8, 70);
            this.mixta_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.mixta_checkbox.Name = "mixta_checkbox";
            this.mixta_checkbox.Size = new System.Drawing.Size(55, 20);
            this.mixta_checkbox.TabIndex = 27;
            this.mixta_checkbox.Text = "Mixta";
            this.mixta_checkbox.UseVisualStyleBackColor = false;
            this.mixta_checkbox.CheckedChanged += new System.EventHandler(this.mixta_checkbox_CheckedChanged);
            // 
            // retro_checkbox
            // 
            this.retro_checkbox.AutoSize = true;
            this.retro_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.retro_checkbox.Checked = true;
            this.retro_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.retro_checkbox.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retro_checkbox.ForeColor = System.Drawing.SystemColors.Control;
            this.retro_checkbox.Location = new System.Drawing.Point(8, 96);
            this.retro_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.retro_checkbox.Name = "retro_checkbox";
            this.retro_checkbox.Size = new System.Drawing.Size(91, 20);
            this.retro_checkbox.TabIndex = 28;
            this.retro_checkbox.Text = "Retrococlear";
            this.retro_checkbox.UseVisualStyleBackColor = false;
            this.retro_checkbox.CheckedChanged += new System.EventHandler(this.retro_checkbox_CheckedChanged);
            // 
            // consultas_salud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CSEQ.Properties.Resources.fondonopesado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.tipoPerdida_gp);
            this.Controls.Add(this.eleccion_gp);
            this.Controls.Add(this.tipologia_combo);
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
            this.Controls.Add(this.noTienen_radio);
            this.Controls.Add(this.gradoPerdida_gp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.GroupBox eleccion_gp;
        private System.Windows.Forms.GroupBox gradoPerdida_gp;
        private System.Windows.Forms.GroupBox tipoPerdida_gp;
        private System.Windows.Forms.CheckBox noSabe_checkbox;
        private System.Windows.Forms.CheckBox conductiva_checkbox;
        private System.Windows.Forms.CheckBox neuro_checkbox;
        private System.Windows.Forms.CheckBox mixta_checkbox;
        private System.Windows.Forms.CheckBox retro_checkbox;
        private System.Windows.Forms.CheckBox profunda_checkbox;
        private System.Windows.Forms.CheckBox no_Sabe_checkbox;
    }
}