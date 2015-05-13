namespace CSEQ
{
    partial class consultas_demografia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultas_demografia));
            this.logout = new System.Windows.Forms.PictureBox();
            this.back_picture = new System.Windows.Forms.PictureBox();
            this.close_picture = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generales_combo = new System.Windows.Forms.ComboBox();
            this.eleccion_gp = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_censo = new System.Windows.Forms.ComboBox();
            this.todoscensos_radio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Reporte = new System.Windows.Forms.Button();
            this.edades_gp = new System.Windows.Forms.GroupBox();
            this.anciano_radio = new System.Windows.Forms.RadioButton();
            this.adultoMayor_radio = new System.Windows.Forms.RadioButton();
            this.adulto_mayor_radio = new System.Windows.Forms.RadioButton();
            this.adolescentes_radio = new System.Windows.Forms.RadioButton();
            this.ninos_radio = new System.Windows.Forms.RadioButton();
            this.sinEducacion_radio = new System.Windows.Forms.RadioButton();
            this.conEducacion_radio = new System.Windows.Forms.RadioButton();
            this.lenguaDom_gp = new System.Windows.Forms.GroupBox();
            this.LSEUA_check = new System.Windows.Forms.CheckBox();
            this.LSM_check = new System.Windows.Forms.CheckBox();
            this.ingles_check = new System.Windows.Forms.CheckBox();
            this.espanol_check = new System.Windows.Forms.CheckBox();
            this.estadoCivil_combo = new System.Windows.Forms.ComboBox();
            this.estadoCivil_gp = new System.Windows.Forms.GroupBox();
            this.viudo_check = new System.Windows.Forms.CheckBox();
            this.divorciado_check = new System.Windows.Forms.CheckBox();
            this.casado_check = new System.Windows.Forms.CheckBox();
            this.soltero_check = new System.Windows.Forms.CheckBox();
            this.sinHijos_radio = new System.Windows.Forms.RadioButton();
            this.conHijos_radio = new System.Windows.Forms.RadioButton();
            this.hijos_gp = new System.Windows.Forms.GroupBox();
            this.hijos_noSordos_radio = new System.Windows.Forms.RadioButton();
            this.hijos_sordos_radio = new System.Windows.Forms.RadioButton();
            this.migracion_combo = new System.Windows.Forms.ComboBox();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_picture)).BeginInit();
            this.eleccion_gp.SuspendLayout();
            this.edades_gp.SuspendLayout();
            this.lenguaDom_gp.SuspendLayout();
            this.estadoCivil_gp.SuspendLayout();
            this.hijos_gp.SuspendLayout();
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
            this.titulo.Location = new System.Drawing.Point(306, 22);
            this.titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(0, 30);
            this.titulo.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 80;
            this.label1.Text = "Consulta";
            // 
            // generales_combo
            // 
            this.generales_combo.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generales_combo.FormattingEnabled = true;
            this.generales_combo.Items.AddRange(new object[] {
            "Por Estado",
            "Por Municipio",
            "Por Sexo",
            "Por Edad",
            "Por Lengua",
            "Por Empleo",
            "Tasa de Crecimiento de Personas Sordas"});
            this.generales_combo.Location = new System.Drawing.Point(89, 98);
            this.generales_combo.Margin = new System.Windows.Forms.Padding(2);
            this.generales_combo.Name = "generales_combo";
            this.generales_combo.Size = new System.Drawing.Size(250, 29);
            this.generales_combo.TabIndex = 81;
            this.generales_combo.Visible = false;
            this.generales_combo.SelectionChangeCommitted += new System.EventHandler(this.generales_combo_SelectionChangeCommitted);
            // 
            // eleccion_gp
            // 
            this.eleccion_gp.BackColor = System.Drawing.Color.Transparent;
            this.eleccion_gp.Controls.Add(this.label2);
            this.eleccion_gp.Controls.Add(this.ID_censo);
            this.eleccion_gp.Controls.Add(this.todoscensos_radio);
            this.eleccion_gp.Enabled = false;
            this.eleccion_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleccion_gp.ForeColor = System.Drawing.Color.White;
            this.eleccion_gp.Location = new System.Drawing.Point(6, 238);
            this.eleccion_gp.Margin = new System.Windows.Forms.Padding(2);
            this.eleccion_gp.Name = "eleccion_gp";
            this.eleccion_gp.Padding = new System.Windows.Forms.Padding(2);
            this.eleccion_gp.Size = new System.Drawing.Size(156, 86);
            this.eleccion_gp.TabIndex = 84;
            this.eleccion_gp.TabStop = false;
            this.eleccion_gp.Text = "Elección Censo";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft MHei", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 82;
            this.label3.Text = "Consulta";
            // 
            // Reporte
            // 
            this.Reporte.BackColor = System.Drawing.Color.White;
            this.Reporte.Enabled = false;
            this.Reporte.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte.Location = new System.Drawing.Point(40, 360);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(92, 37);
            this.Reporte.TabIndex = 83;
            this.Reporte.Text = "Crear Reporte";
            this.Reporte.UseVisualStyleBackColor = false;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // edades_gp
            // 
            this.edades_gp.BackColor = System.Drawing.Color.Transparent;
            this.edades_gp.Controls.Add(this.anciano_radio);
            this.edades_gp.Controls.Add(this.adultoMayor_radio);
            this.edades_gp.Controls.Add(this.adulto_mayor_radio);
            this.edades_gp.Controls.Add(this.adolescentes_radio);
            this.edades_gp.Controls.Add(this.ninos_radio);
            this.edades_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edades_gp.ForeColor = System.Drawing.Color.White;
            this.edades_gp.Location = new System.Drawing.Point(382, 64);
            this.edades_gp.Margin = new System.Windows.Forms.Padding(2);
            this.edades_gp.Name = "edades_gp";
            this.edades_gp.Padding = new System.Windows.Forms.Padding(2);
            this.edades_gp.Size = new System.Drawing.Size(156, 132);
            this.edades_gp.TabIndex = 85;
            this.edades_gp.TabStop = false;
            this.edades_gp.Text = "Rangos de Edad";
            this.edades_gp.Visible = false;
            // 
            // anciano_radio
            // 
            this.anciano_radio.AutoSize = true;
            this.anciano_radio.BackColor = System.Drawing.Color.Transparent;
            this.anciano_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anciano_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.anciano_radio.Location = new System.Drawing.Point(7, 104);
            this.anciano_radio.Margin = new System.Windows.Forms.Padding(4);
            this.anciano_radio.Name = "anciano_radio";
            this.anciano_radio.Size = new System.Drawing.Size(99, 20);
            this.anciano_radio.TabIndex = 24;
            this.anciano_radio.TabStop = true;
            this.anciano_radio.Text = "61 años o más";
            this.anciano_radio.UseVisualStyleBackColor = false;
            this.anciano_radio.CheckedChanged += new System.EventHandler(this.anciano_radio_CheckedChanged);
            // 
            // adultoMayor_radio
            // 
            this.adultoMayor_radio.AutoSize = true;
            this.adultoMayor_radio.BackColor = System.Drawing.Color.Transparent;
            this.adultoMayor_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultoMayor_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.adultoMayor_radio.Location = new System.Drawing.Point(7, 82);
            this.adultoMayor_radio.Margin = new System.Windows.Forms.Padding(4);
            this.adultoMayor_radio.Name = "adultoMayor_radio";
            this.adultoMayor_radio.Size = new System.Drawing.Size(107, 20);
            this.adultoMayor_radio.TabIndex = 23;
            this.adultoMayor_radio.TabStop = true;
            this.adultoMayor_radio.Text = "De 41 a 60 años";
            this.adultoMayor_radio.UseVisualStyleBackColor = false;
            this.adultoMayor_radio.CheckedChanged += new System.EventHandler(this.adultoMayor_radio_CheckedChanged);
            // 
            // adulto_mayor_radio
            // 
            this.adulto_mayor_radio.AutoSize = true;
            this.adulto_mayor_radio.BackColor = System.Drawing.Color.Transparent;
            this.adulto_mayor_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adulto_mayor_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.adulto_mayor_radio.Location = new System.Drawing.Point(7, 60);
            this.adulto_mayor_radio.Margin = new System.Windows.Forms.Padding(2);
            this.adulto_mayor_radio.Name = "adulto_mayor_radio";
            this.adulto_mayor_radio.Size = new System.Drawing.Size(107, 20);
            this.adulto_mayor_radio.TabIndex = 22;
            this.adulto_mayor_radio.TabStop = true;
            this.adulto_mayor_radio.Text = "De 21 a 40 años";
            this.adulto_mayor_radio.UseVisualStyleBackColor = false;
            this.adulto_mayor_radio.CheckedChanged += new System.EventHandler(this.adulto_mayor_radio_CheckedChanged);
            // 
            // adolescentes_radio
            // 
            this.adolescentes_radio.AutoSize = true;
            this.adolescentes_radio.BackColor = System.Drawing.Color.Transparent;
            this.adolescentes_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adolescentes_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.adolescentes_radio.Location = new System.Drawing.Point(7, 37);
            this.adolescentes_radio.Margin = new System.Windows.Forms.Padding(4);
            this.adolescentes_radio.Name = "adolescentes_radio";
            this.adolescentes_radio.Size = new System.Drawing.Size(105, 20);
            this.adolescentes_radio.TabIndex = 21;
            this.adolescentes_radio.TabStop = true;
            this.adolescentes_radio.Text = "De 11 a 20 años";
            this.adolescentes_radio.UseVisualStyleBackColor = false;
            this.adolescentes_radio.CheckedChanged += new System.EventHandler(this.adolescentes_radio_CheckedChanged);
            // 
            // ninos_radio
            // 
            this.ninos_radio.AutoSize = true;
            this.ninos_radio.BackColor = System.Drawing.Color.Transparent;
            this.ninos_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninos_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.ninos_radio.Location = new System.Drawing.Point(7, 17);
            this.ninos_radio.Margin = new System.Windows.Forms.Padding(4);
            this.ninos_radio.Name = "ninos_radio";
            this.ninos_radio.Size = new System.Drawing.Size(100, 20);
            this.ninos_radio.TabIndex = 20;
            this.ninos_radio.TabStop = true;
            this.ninos_radio.Text = "De 0 a 10 años";
            this.ninos_radio.UseVisualStyleBackColor = false;
            this.ninos_radio.CheckedChanged += new System.EventHandler(this.ninos_radio_CheckedChanged);
            // 
            // sinEducacion_radio
            // 
            this.sinEducacion_radio.AutoSize = true;
            this.sinEducacion_radio.BackColor = System.Drawing.Color.Transparent;
            this.sinEducacion_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinEducacion_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.sinEducacion_radio.Location = new System.Drawing.Point(350, 116);
            this.sinEducacion_radio.Margin = new System.Windows.Forms.Padding(2);
            this.sinEducacion_radio.Name = "sinEducacion_radio";
            this.sinEducacion_radio.Size = new System.Drawing.Size(98, 20);
            this.sinEducacion_radio.TabIndex = 26;
            this.sinEducacion_radio.TabStop = true;
            this.sinEducacion_radio.Text = "Sin Educación";
            this.sinEducacion_radio.UseVisualStyleBackColor = false;
            this.sinEducacion_radio.Visible = false;
            // 
            // conEducacion_radio
            // 
            this.conEducacion_radio.AutoSize = true;
            this.conEducacion_radio.BackColor = System.Drawing.Color.Transparent;
            this.conEducacion_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conEducacion_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.conEducacion_radio.Location = new System.Drawing.Point(350, 89);
            this.conEducacion_radio.Margin = new System.Windows.Forms.Padding(2);
            this.conEducacion_radio.Name = "conEducacion_radio";
            this.conEducacion_radio.Size = new System.Drawing.Size(103, 20);
            this.conEducacion_radio.TabIndex = 25;
            this.conEducacion_radio.TabStop = true;
            this.conEducacion_radio.Text = "Con Educación";
            this.conEducacion_radio.UseVisualStyleBackColor = false;
            this.conEducacion_radio.Visible = false;
            // 
            // lenguaDom_gp
            // 
            this.lenguaDom_gp.BackColor = System.Drawing.Color.Transparent;
            this.lenguaDom_gp.Controls.Add(this.LSEUA_check);
            this.lenguaDom_gp.Controls.Add(this.LSM_check);
            this.lenguaDom_gp.Controls.Add(this.ingles_check);
            this.lenguaDom_gp.Controls.Add(this.espanol_check);
            this.lenguaDom_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenguaDom_gp.ForeColor = System.Drawing.Color.White;
            this.lenguaDom_gp.Location = new System.Drawing.Point(364, 64);
            this.lenguaDom_gp.Margin = new System.Windows.Forms.Padding(2);
            this.lenguaDom_gp.Name = "lenguaDom_gp";
            this.lenguaDom_gp.Padding = new System.Windows.Forms.Padding(2);
            this.lenguaDom_gp.Size = new System.Drawing.Size(182, 130);
            this.lenguaDom_gp.TabIndex = 87;
            this.lenguaDom_gp.TabStop = false;
            this.lenguaDom_gp.Text = "Lengua Dominante";
            this.lenguaDom_gp.Visible = false;
            // 
            // LSEUA_check
            // 
            this.LSEUA_check.AutoSize = true;
            this.LSEUA_check.BackColor = System.Drawing.Color.Transparent;
            this.LSEUA_check.Checked = true;
            this.LSEUA_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LSEUA_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSEUA_check.ForeColor = System.Drawing.Color.White;
            this.LSEUA_check.Location = new System.Drawing.Point(6, 93);
            this.LSEUA_check.Name = "LSEUA_check";
            this.LSEUA_check.Size = new System.Drawing.Size(140, 20);
            this.LSEUA_check.TabIndex = 101;
            this.LSEUA_check.Text = "Lengua de Señas EUA";
            this.LSEUA_check.UseVisualStyleBackColor = false;
            this.LSEUA_check.CheckedChanged += new System.EventHandler(this.LSEUA_check_CheckedChanged);
            // 
            // LSM_check
            // 
            this.LSM_check.AutoSize = true;
            this.LSM_check.BackColor = System.Drawing.Color.Transparent;
            this.LSM_check.Checked = true;
            this.LSM_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LSM_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSM_check.ForeColor = System.Drawing.Color.White;
            this.LSM_check.Location = new System.Drawing.Point(6, 50);
            this.LSM_check.Margin = new System.Windows.Forms.Padding(2);
            this.LSM_check.Name = "LSM_check";
            this.LSM_check.Size = new System.Drawing.Size(166, 20);
            this.LSM_check.TabIndex = 100;
            this.LSM_check.Text = "Lengua de Señas Mexicana";
            this.LSM_check.UseVisualStyleBackColor = false;
            this.LSM_check.CheckedChanged += new System.EventHandler(this.LSM_check_CheckedChanged);
            // 
            // ingles_check
            // 
            this.ingles_check.AutoSize = true;
            this.ingles_check.BackColor = System.Drawing.Color.Transparent;
            this.ingles_check.Checked = true;
            this.ingles_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ingles_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingles_check.ForeColor = System.Drawing.Color.White;
            this.ingles_check.Location = new System.Drawing.Point(6, 70);
            this.ingles_check.Name = "ingles_check";
            this.ingles_check.Size = new System.Drawing.Size(58, 20);
            this.ingles_check.TabIndex = 99;
            this.ingles_check.Text = "Inglés";
            this.ingles_check.UseVisualStyleBackColor = false;
            this.ingles_check.CheckedChanged += new System.EventHandler(this.ingles_check_CheckedChanged);
            // 
            // espanol_check
            // 
            this.espanol_check.AutoSize = true;
            this.espanol_check.BackColor = System.Drawing.Color.Transparent;
            this.espanol_check.Checked = true;
            this.espanol_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.espanol_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.espanol_check.ForeColor = System.Drawing.Color.White;
            this.espanol_check.Location = new System.Drawing.Point(6, 25);
            this.espanol_check.Name = "espanol_check";
            this.espanol_check.Size = new System.Drawing.Size(68, 20);
            this.espanol_check.TabIndex = 98;
            this.espanol_check.Text = "Español";
            this.espanol_check.UseVisualStyleBackColor = false;
            this.espanol_check.CheckedChanged += new System.EventHandler(this.espanol_check_CheckedChanged);
            // 
            // estadoCivil_combo
            // 
            this.estadoCivil_combo.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCivil_combo.FormattingEnabled = true;
            this.estadoCivil_combo.Items.AddRange(new object[] {
            "Por Estado Civil",
            "Por Hijos"});
            this.estadoCivil_combo.Location = new System.Drawing.Point(89, 98);
            this.estadoCivil_combo.Margin = new System.Windows.Forms.Padding(2);
            this.estadoCivil_combo.Name = "estadoCivil_combo";
            this.estadoCivil_combo.Size = new System.Drawing.Size(250, 29);
            this.estadoCivil_combo.TabIndex = 89;
            this.estadoCivil_combo.Visible = false;
            this.estadoCivil_combo.SelectionChangeCommitted += new System.EventHandler(this.estadoCivil_combo_SelectionChangeCommitted);
            // 
            // estadoCivil_gp
            // 
            this.estadoCivil_gp.BackColor = System.Drawing.Color.Transparent;
            this.estadoCivil_gp.Controls.Add(this.viudo_check);
            this.estadoCivil_gp.Controls.Add(this.divorciado_check);
            this.estadoCivil_gp.Controls.Add(this.casado_check);
            this.estadoCivil_gp.Controls.Add(this.soltero_check);
            this.estadoCivil_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCivil_gp.ForeColor = System.Drawing.Color.White;
            this.estadoCivil_gp.Location = new System.Drawing.Point(356, 70);
            this.estadoCivil_gp.Margin = new System.Windows.Forms.Padding(2);
            this.estadoCivil_gp.Name = "estadoCivil_gp";
            this.estadoCivil_gp.Padding = new System.Windows.Forms.Padding(2);
            this.estadoCivil_gp.Size = new System.Drawing.Size(182, 121);
            this.estadoCivil_gp.TabIndex = 102;
            this.estadoCivil_gp.TabStop = false;
            this.estadoCivil_gp.Text = "Estado Civil";
            this.estadoCivil_gp.Visible = false;
            // 
            // viudo_check
            // 
            this.viudo_check.AutoSize = true;
            this.viudo_check.BackColor = System.Drawing.Color.Transparent;
            this.viudo_check.Checked = true;
            this.viudo_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viudo_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viudo_check.ForeColor = System.Drawing.Color.White;
            this.viudo_check.Location = new System.Drawing.Point(3, 90);
            this.viudo_check.Margin = new System.Windows.Forms.Padding(2);
            this.viudo_check.Name = "viudo_check";
            this.viudo_check.Size = new System.Drawing.Size(72, 20);
            this.viudo_check.TabIndex = 101;
            this.viudo_check.Text = "Viudo(a)";
            this.viudo_check.UseVisualStyleBackColor = false;
            this.viudo_check.CheckedChanged += new System.EventHandler(this.viudo_check_CheckedChanged);
            // 
            // divorciado_check
            // 
            this.divorciado_check.AutoSize = true;
            this.divorciado_check.BackColor = System.Drawing.Color.Transparent;
            this.divorciado_check.Checked = true;
            this.divorciado_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.divorciado_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divorciado_check.ForeColor = System.Drawing.Color.White;
            this.divorciado_check.Location = new System.Drawing.Point(3, 68);
            this.divorciado_check.Margin = new System.Windows.Forms.Padding(2);
            this.divorciado_check.Name = "divorciado_check";
            this.divorciado_check.Size = new System.Drawing.Size(97, 20);
            this.divorciado_check.TabIndex = 100;
            this.divorciado_check.Text = "Divorciado(a)";
            this.divorciado_check.UseVisualStyleBackColor = false;
            this.divorciado_check.CheckedChanged += new System.EventHandler(this.divorciado_check_CheckedChanged);
            // 
            // casado_check
            // 
            this.casado_check.AutoSize = true;
            this.casado_check.BackColor = System.Drawing.Color.Transparent;
            this.casado_check.Checked = true;
            this.casado_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.casado_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casado_check.ForeColor = System.Drawing.Color.White;
            this.casado_check.Location = new System.Drawing.Point(3, 46);
            this.casado_check.Margin = new System.Windows.Forms.Padding(2);
            this.casado_check.Name = "casado_check";
            this.casado_check.Size = new System.Drawing.Size(79, 20);
            this.casado_check.TabIndex = 99;
            this.casado_check.Text = "Casado(a)";
            this.casado_check.UseVisualStyleBackColor = false;
            this.casado_check.CheckedChanged += new System.EventHandler(this.casado_check_CheckedChanged);
            // 
            // soltero_check
            // 
            this.soltero_check.AutoSize = true;
            this.soltero_check.BackColor = System.Drawing.Color.Transparent;
            this.soltero_check.Checked = true;
            this.soltero_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soltero_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soltero_check.ForeColor = System.Drawing.Color.White;
            this.soltero_check.Location = new System.Drawing.Point(3, 23);
            this.soltero_check.Margin = new System.Windows.Forms.Padding(2);
            this.soltero_check.Name = "soltero_check";
            this.soltero_check.Size = new System.Drawing.Size(78, 20);
            this.soltero_check.TabIndex = 98;
            this.soltero_check.Text = "Soltero(a)";
            this.soltero_check.UseVisualStyleBackColor = false;
            this.soltero_check.CheckedChanged += new System.EventHandler(this.soltero_check_CheckedChanged);
            // 
            // sinHijos_radio
            // 
            this.sinHijos_radio.AutoSize = true;
            this.sinHijos_radio.BackColor = System.Drawing.Color.Transparent;
            this.sinHijos_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinHijos_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.sinHijos_radio.Location = new System.Drawing.Point(350, 118);
            this.sinHijos_radio.Margin = new System.Windows.Forms.Padding(2);
            this.sinHijos_radio.Name = "sinHijos_radio";
            this.sinHijos_radio.Size = new System.Drawing.Size(71, 20);
            this.sinHijos_radio.TabIndex = 104;
            this.sinHijos_radio.TabStop = true;
            this.sinHijos_radio.Text = "Sin Hijos";
            this.sinHijos_radio.UseVisualStyleBackColor = false;
            this.sinHijos_radio.Visible = false;
            this.sinHijos_radio.CheckedChanged += new System.EventHandler(this.sinHijos_radio_CheckedChanged);
            // 
            // conHijos_radio
            // 
            this.conHijos_radio.AutoSize = true;
            this.conHijos_radio.BackColor = System.Drawing.Color.Transparent;
            this.conHijos_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conHijos_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.conHijos_radio.Location = new System.Drawing.Point(350, 90);
            this.conHijos_radio.Margin = new System.Windows.Forms.Padding(2);
            this.conHijos_radio.Name = "conHijos_radio";
            this.conHijos_radio.Size = new System.Drawing.Size(76, 20);
            this.conHijos_radio.TabIndex = 103;
            this.conHijos_radio.TabStop = true;
            this.conHijos_radio.Text = "Con Hijos";
            this.conHijos_radio.UseVisualStyleBackColor = false;
            this.conHijos_radio.Visible = false;
            this.conHijos_radio.CheckedChanged += new System.EventHandler(this.conHijos_radio_CheckedChanged);
            // 
            // hijos_gp
            // 
            this.hijos_gp.BackColor = System.Drawing.Color.Transparent;
            this.hijos_gp.Controls.Add(this.hijos_noSordos_radio);
            this.hijos_gp.Controls.Add(this.hijos_sordos_radio);
            this.hijos_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hijos_gp.ForeColor = System.Drawing.Color.White;
            this.hijos_gp.Location = new System.Drawing.Point(449, 77);
            this.hijos_gp.Margin = new System.Windows.Forms.Padding(2);
            this.hijos_gp.Name = "hijos_gp";
            this.hijos_gp.Padding = new System.Windows.Forms.Padding(2);
            this.hijos_gp.Size = new System.Drawing.Size(154, 83);
            this.hijos_gp.TabIndex = 103;
            this.hijos_gp.TabStop = false;
            this.hijos_gp.Text = "Hijos";
            this.hijos_gp.Visible = false;
            // 
            // hijos_noSordos_radio
            // 
            this.hijos_noSordos_radio.AutoSize = true;
            this.hijos_noSordos_radio.BackColor = System.Drawing.Color.Transparent;
            this.hijos_noSordos_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hijos_noSordos_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.hijos_noSordos_radio.Location = new System.Drawing.Point(21, 55);
            this.hijos_noSordos_radio.Margin = new System.Windows.Forms.Padding(2);
            this.hijos_noSordos_radio.Name = "hijos_noSordos_radio";
            this.hijos_noSordos_radio.Size = new System.Drawing.Size(110, 20);
            this.hijos_noSordos_radio.TabIndex = 105;
            this.hijos_noSordos_radio.TabStop = true;
            this.hijos_noSordos_radio.Text = "Hijos No Sordos";
            this.hijos_noSordos_radio.UseVisualStyleBackColor = false;
            this.hijos_noSordos_radio.Visible = false;
            this.hijos_noSordos_radio.CheckedChanged += new System.EventHandler(this.hijos_noSordos_radio_CheckedChanged);
            // 
            // hijos_sordos_radio
            // 
            this.hijos_sordos_radio.AutoSize = true;
            this.hijos_sordos_radio.BackColor = System.Drawing.Color.Transparent;
            this.hijos_sordos_radio.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hijos_sordos_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.hijos_sordos_radio.Location = new System.Drawing.Point(21, 23);
            this.hijos_sordos_radio.Margin = new System.Windows.Forms.Padding(2);
            this.hijos_sordos_radio.Name = "hijos_sordos_radio";
            this.hijos_sordos_radio.Size = new System.Drawing.Size(91, 20);
            this.hijos_sordos_radio.TabIndex = 104;
            this.hijos_sordos_radio.TabStop = true;
            this.hijos_sordos_radio.Text = "Hijos Sordos";
            this.hijos_sordos_radio.UseVisualStyleBackColor = false;
            this.hijos_sordos_radio.Visible = false;
            this.hijos_sordos_radio.CheckedChanged += new System.EventHandler(this.hijos_sordos_radio_CheckedChanged);
            // 
            // migracion_combo
            // 
            this.migracion_combo.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.migracion_combo.FormattingEnabled = true;
            this.migracion_combo.Items.AddRange(new object[] {
            "Personas de otro estado",
            "Personas de otra nacionalidad"});
            this.migracion_combo.Location = new System.Drawing.Point(89, 98);
            this.migracion_combo.Margin = new System.Windows.Forms.Padding(2);
            this.migracion_combo.Name = "migracion_combo";
            this.migracion_combo.Size = new System.Drawing.Size(250, 29);
            this.migracion_combo.TabIndex = 105;
            this.migracion_combo.Visible = false;
            this.migracion_combo.SelectionChangeCommitted += new System.EventHandler(this.migracion_combo_SelectionChangeCommitted);
            // 
            // zedGraph
            // 
            this.zedGraph.AutoSize = true;
            this.zedGraph.BackColor = System.Drawing.Color.Transparent;
            this.zedGraph.Location = new System.Drawing.Point(170, 204);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(6);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(626, 328);
            this.zedGraph.TabIndex = 106;
            this.zedGraph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraph.ZoomStepFraction = 0D;
            // 
            // consultas_demografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CSEQ.Properties.Resources.fondonopesado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.eleccion_gp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Reporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.back_picture);
            this.Controls.Add(this.close_picture);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.estadoCivil_combo);
            this.Controls.Add(this.hijos_gp);
            this.Controls.Add(this.sinHijos_radio);
            this.Controls.Add(this.sinEducacion_radio);
            this.Controls.Add(this.conHijos_radio);
            this.Controls.Add(this.edades_gp);
            this.Controls.Add(this.estadoCivil_gp);
            this.Controls.Add(this.lenguaDom_gp);
            this.Controls.Add(this.conEducacion_radio);
            this.Controls.Add(this.generales_combo);
            this.Controls.Add(this.migracion_combo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "consultas_demografia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultas_demografia";
            this.Load += new System.EventHandler(this.consultas_demografia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_picture)).EndInit();
            this.eleccion_gp.ResumeLayout(false);
            this.eleccion_gp.PerformLayout();
            this.edades_gp.ResumeLayout(false);
            this.edades_gp.PerformLayout();
            this.lenguaDom_gp.ResumeLayout(false);
            this.lenguaDom_gp.PerformLayout();
            this.estadoCivil_gp.ResumeLayout(false);
            this.estadoCivil_gp.PerformLayout();
            this.hijos_gp.ResumeLayout(false);
            this.hijos_gp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox back_picture;
        private System.Windows.Forms.PictureBox close_picture;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox generales_combo;
        private System.Windows.Forms.GroupBox eleccion_gp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ID_censo;
        private System.Windows.Forms.RadioButton todoscensos_radio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Reporte;
        private System.Windows.Forms.GroupBox edades_gp;
        private System.Windows.Forms.RadioButton anciano_radio;
        private System.Windows.Forms.RadioButton adultoMayor_radio;
        private System.Windows.Forms.RadioButton adulto_mayor_radio;
        private System.Windows.Forms.RadioButton adolescentes_radio;
        private System.Windows.Forms.RadioButton ninos_radio;
        private System.Windows.Forms.RadioButton sinEducacion_radio;
        private System.Windows.Forms.RadioButton conEducacion_radio;
        private System.Windows.Forms.GroupBox lenguaDom_gp;
        private System.Windows.Forms.CheckBox LSEUA_check;
        private System.Windows.Forms.CheckBox LSM_check;
        private System.Windows.Forms.CheckBox ingles_check;
        private System.Windows.Forms.CheckBox espanol_check;
        private System.Windows.Forms.ComboBox estadoCivil_combo;
        private System.Windows.Forms.GroupBox estadoCivil_gp;
        private System.Windows.Forms.CheckBox viudo_check;
        private System.Windows.Forms.CheckBox divorciado_check;
        private System.Windows.Forms.CheckBox casado_check;
        private System.Windows.Forms.CheckBox soltero_check;
        private System.Windows.Forms.RadioButton sinHijos_radio;
        private System.Windows.Forms.RadioButton conHijos_radio;
        private System.Windows.Forms.GroupBox hijos_gp;
        private System.Windows.Forms.ComboBox migracion_combo;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.RadioButton hijos_noSordos_radio;
        private System.Windows.Forms.RadioButton hijos_sordos_radio;
    }
}