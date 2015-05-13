namespace CSEQ
{
    partial class consulta_educacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consulta_educacion));
            this.logout = new System.Windows.Forms.PictureBox();
            this.back_picture = new System.Windows.Forms.PictureBox();
            this.close_picture = new System.Windows.Forms.PictureBox();
            this.salir_tt = new System.Windows.Forms.ToolTip(this.components);
            this.titulo = new System.Windows.Forms.Label();
            this.nivelesEducativos_gp = new System.Windows.Forms.GroupBox();
            this.doctorado_check = new System.Windows.Forms.CheckBox();
            this.maestria_check = new System.Windows.Forms.CheckBox();
            this.especialidad_check = new System.Windows.Forms.CheckBox();
            this.licenciatura_check = new System.Windows.Forms.CheckBox();
            this.carreraTecnica_check = new System.Windows.Forms.CheckBox();
            this.preparatoria_check = new System.Windows.Forms.CheckBox();
            this.secundaria_check = new System.Windows.Forms.CheckBox();
            this.primaria_check = new System.Windows.Forms.CheckBox();
            this.prescolar_check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comunicacion_combo = new System.Windows.Forms.ComboBox();
            this.eleccion_gp = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_censo = new System.Windows.Forms.ComboBox();
            this.todoscensos_radio = new System.Windows.Forms.RadioButton();
            this.Reporte = new System.Windows.Forms.Button();
            this.nivelEducativo_combo = new System.Windows.Forms.ComboBox();
            this.privada_radio = new System.Windows.Forms.RadioButton();
            this.publica_radio = new System.Windows.Forms.RadioButton();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.noHanEstudiado_radio = new System.Windows.Forms.RadioButton();
            this.hanEstudiado_radio = new System.Windows.Forms.RadioButton();
            this.normal_radio = new System.Windows.Forms.RadioButton();
            this.especial_radio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_picture)).BeginInit();
            this.nivelesEducativos_gp.SuspendLayout();
            this.eleccion_gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Image = global::CSEQ.Properties.Resources.logout;
            this.logout.Location = new System.Drawing.Point(765, 47);
            this.logout.Margin = new System.Windows.Forms.Padding(2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(30, 29);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 69;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseHover += new System.EventHandler(this.logout_MouseHover);
            // 
            // back_picture
            // 
            this.back_picture.BackColor = System.Drawing.Color.Transparent;
            this.back_picture.Image = ((System.Drawing.Image)(resources.GetObject("back_picture.Image")));
            this.back_picture.Location = new System.Drawing.Point(6, 14);
            this.back_picture.Margin = new System.Windows.Forms.Padding(2);
            this.back_picture.Name = "back_picture";
            this.back_picture.Size = new System.Drawing.Size(30, 29);
            this.back_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_picture.TabIndex = 68;
            this.back_picture.TabStop = false;
            this.back_picture.Click += new System.EventHandler(this.back_picture_Click);
            this.back_picture.MouseLeave += new System.EventHandler(this.back_picture_MouseLeave);
            this.back_picture.MouseHover += new System.EventHandler(this.back_picture_MouseHover);
            // 
            // close_picture
            // 
            this.close_picture.BackColor = System.Drawing.Color.Transparent;
            this.close_picture.Image = ((System.Drawing.Image)(resources.GetObject("close_picture.Image")));
            this.close_picture.Location = new System.Drawing.Point(765, 14);
            this.close_picture.Margin = new System.Windows.Forms.Padding(2);
            this.close_picture.Name = "close_picture";
            this.close_picture.Size = new System.Drawing.Size(30, 29);
            this.close_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_picture.TabIndex = 67;
            this.close_picture.TabStop = false;
            this.close_picture.Click += new System.EventHandler(this.pictureBox2_Click);
            this.close_picture.MouseHover += new System.EventHandler(this.close_picture_MouseHover);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft MHei", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo.Location = new System.Drawing.Point(270, 27);
            this.titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(0, 30);
            this.titulo.TabIndex = 80;
            // 
            // nivelesEducativos_gp
            // 
            this.nivelesEducativos_gp.BackColor = System.Drawing.Color.Transparent;
            this.nivelesEducativos_gp.Controls.Add(this.doctorado_check);
            this.nivelesEducativos_gp.Controls.Add(this.maestria_check);
            this.nivelesEducativos_gp.Controls.Add(this.especialidad_check);
            this.nivelesEducativos_gp.Controls.Add(this.licenciatura_check);
            this.nivelesEducativos_gp.Controls.Add(this.carreraTecnica_check);
            this.nivelesEducativos_gp.Controls.Add(this.preparatoria_check);
            this.nivelesEducativos_gp.Controls.Add(this.secundaria_check);
            this.nivelesEducativos_gp.Controls.Add(this.primaria_check);
            this.nivelesEducativos_gp.Controls.Add(this.prescolar_check);
            this.nivelesEducativos_gp.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelesEducativos_gp.ForeColor = System.Drawing.Color.White;
            this.nivelesEducativos_gp.Location = new System.Drawing.Point(404, 59);
            this.nivelesEducativos_gp.Margin = new System.Windows.Forms.Padding(2);
            this.nivelesEducativos_gp.Name = "nivelesEducativos_gp";
            this.nivelesEducativos_gp.Padding = new System.Windows.Forms.Padding(2);
            this.nivelesEducativos_gp.Size = new System.Drawing.Size(248, 135);
            this.nivelesEducativos_gp.TabIndex = 89;
            this.nivelesEducativos_gp.TabStop = false;
            this.nivelesEducativos_gp.Text = "Nivel Educativo";
            this.nivelesEducativos_gp.Visible = false;
            // 
            // doctorado_check
            // 
            this.doctorado_check.AutoSize = true;
            this.doctorado_check.BackColor = System.Drawing.Color.Transparent;
            this.doctorado_check.Checked = true;
            this.doctorado_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doctorado_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorado_check.ForeColor = System.Drawing.Color.White;
            this.doctorado_check.Location = new System.Drawing.Point(123, 90);
            this.doctorado_check.Margin = new System.Windows.Forms.Padding(2);
            this.doctorado_check.Name = "doctorado_check";
            this.doctorado_check.Size = new System.Drawing.Size(82, 20);
            this.doctorado_check.TabIndex = 96;
            this.doctorado_check.Text = "Doctorado";
            this.doctorado_check.UseVisualStyleBackColor = false;
            this.doctorado_check.CheckedChanged += new System.EventHandler(this.doctorado_check_CheckedChanged);
            // 
            // maestria_check
            // 
            this.maestria_check.AutoSize = true;
            this.maestria_check.BackColor = System.Drawing.Color.Transparent;
            this.maestria_check.Checked = true;
            this.maestria_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.maestria_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maestria_check.ForeColor = System.Drawing.Color.White;
            this.maestria_check.Location = new System.Drawing.Point(123, 67);
            this.maestria_check.Margin = new System.Windows.Forms.Padding(2);
            this.maestria_check.Name = "maestria_check";
            this.maestria_check.Size = new System.Drawing.Size(71, 20);
            this.maestria_check.TabIndex = 95;
            this.maestria_check.Text = "Maestría";
            this.maestria_check.UseVisualStyleBackColor = false;
            this.maestria_check.CheckedChanged += new System.EventHandler(this.maestria_check_CheckedChanged);
            // 
            // especialidad_check
            // 
            this.especialidad_check.AutoSize = true;
            this.especialidad_check.BackColor = System.Drawing.Color.Transparent;
            this.especialidad_check.Checked = true;
            this.especialidad_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.especialidad_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especialidad_check.ForeColor = System.Drawing.Color.White;
            this.especialidad_check.Location = new System.Drawing.Point(123, 43);
            this.especialidad_check.Margin = new System.Windows.Forms.Padding(2);
            this.especialidad_check.Name = "especialidad_check";
            this.especialidad_check.Size = new System.Drawing.Size(91, 20);
            this.especialidad_check.TabIndex = 94;
            this.especialidad_check.Text = "Especialidad";
            this.especialidad_check.UseVisualStyleBackColor = false;
            this.especialidad_check.CheckedChanged += new System.EventHandler(this.especialidad_check_CheckedChanged);
            // 
            // licenciatura_check
            // 
            this.licenciatura_check.AutoSize = true;
            this.licenciatura_check.BackColor = System.Drawing.Color.Transparent;
            this.licenciatura_check.Checked = true;
            this.licenciatura_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.licenciatura_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenciatura_check.ForeColor = System.Drawing.Color.White;
            this.licenciatura_check.Location = new System.Drawing.Point(123, 19);
            this.licenciatura_check.Margin = new System.Windows.Forms.Padding(2);
            this.licenciatura_check.Name = "licenciatura_check";
            this.licenciatura_check.Size = new System.Drawing.Size(89, 20);
            this.licenciatura_check.TabIndex = 93;
            this.licenciatura_check.Text = "Licenciatura";
            this.licenciatura_check.UseVisualStyleBackColor = false;
            this.licenciatura_check.CheckedChanged += new System.EventHandler(this.licenciatura_check_CheckedChanged);
            // 
            // carreraTecnica_check
            // 
            this.carreraTecnica_check.AutoSize = true;
            this.carreraTecnica_check.BackColor = System.Drawing.Color.Transparent;
            this.carreraTecnica_check.Checked = true;
            this.carreraTecnica_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.carreraTecnica_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carreraTecnica_check.ForeColor = System.Drawing.Color.White;
            this.carreraTecnica_check.Location = new System.Drawing.Point(4, 112);
            this.carreraTecnica_check.Margin = new System.Windows.Forms.Padding(2);
            this.carreraTecnica_check.Name = "carreraTecnica_check";
            this.carreraTecnica_check.Size = new System.Drawing.Size(105, 20);
            this.carreraTecnica_check.TabIndex = 92;
            this.carreraTecnica_check.Text = "Carrera Técnica";
            this.carreraTecnica_check.UseVisualStyleBackColor = false;
            this.carreraTecnica_check.CheckedChanged += new System.EventHandler(this.carreraTecnica_check_CheckedChanged);
            // 
            // preparatoria_check
            // 
            this.preparatoria_check.AutoSize = true;
            this.preparatoria_check.BackColor = System.Drawing.Color.Transparent;
            this.preparatoria_check.Checked = true;
            this.preparatoria_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preparatoria_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preparatoria_check.ForeColor = System.Drawing.Color.White;
            this.preparatoria_check.Location = new System.Drawing.Point(4, 90);
            this.preparatoria_check.Margin = new System.Windows.Forms.Padding(2);
            this.preparatoria_check.Name = "preparatoria_check";
            this.preparatoria_check.Size = new System.Drawing.Size(91, 20);
            this.preparatoria_check.TabIndex = 91;
            this.preparatoria_check.Text = "Preparatoria";
            this.preparatoria_check.UseVisualStyleBackColor = false;
            this.preparatoria_check.CheckedChanged += new System.EventHandler(this.preparatoria_check_CheckedChanged);
            // 
            // secundaria_check
            // 
            this.secundaria_check.AutoSize = true;
            this.secundaria_check.BackColor = System.Drawing.Color.Transparent;
            this.secundaria_check.Checked = true;
            this.secundaria_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.secundaria_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secundaria_check.ForeColor = System.Drawing.Color.White;
            this.secundaria_check.Location = new System.Drawing.Point(4, 67);
            this.secundaria_check.Margin = new System.Windows.Forms.Padding(2);
            this.secundaria_check.Name = "secundaria_check";
            this.secundaria_check.Size = new System.Drawing.Size(84, 20);
            this.secundaria_check.TabIndex = 90;
            this.secundaria_check.Text = "Secundaria";
            this.secundaria_check.UseVisualStyleBackColor = false;
            this.secundaria_check.CheckedChanged += new System.EventHandler(this.secundaria_check_CheckedChanged);
            // 
            // primaria_check
            // 
            this.primaria_check.AutoSize = true;
            this.primaria_check.BackColor = System.Drawing.Color.Transparent;
            this.primaria_check.Checked = true;
            this.primaria_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.primaria_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primaria_check.ForeColor = System.Drawing.Color.White;
            this.primaria_check.Location = new System.Drawing.Point(4, 43);
            this.primaria_check.Margin = new System.Windows.Forms.Padding(2);
            this.primaria_check.Name = "primaria_check";
            this.primaria_check.Size = new System.Drawing.Size(70, 20);
            this.primaria_check.TabIndex = 90;
            this.primaria_check.Text = "Primaria";
            this.primaria_check.UseVisualStyleBackColor = false;
            this.primaria_check.CheckedChanged += new System.EventHandler(this.primaria_check_CheckedChanged);
            // 
            // prescolar_check
            // 
            this.prescolar_check.AutoSize = true;
            this.prescolar_check.BackColor = System.Drawing.Color.Transparent;
            this.prescolar_check.Checked = true;
            this.prescolar_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.prescolar_check.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescolar_check.ForeColor = System.Drawing.Color.White;
            this.prescolar_check.Location = new System.Drawing.Point(4, 19);
            this.prescolar_check.Margin = new System.Windows.Forms.Padding(2);
            this.prescolar_check.Name = "prescolar_check";
            this.prescolar_check.Size = new System.Drawing.Size(74, 20);
            this.prescolar_check.TabIndex = 89;
            this.prescolar_check.Text = "Prescolar";
            this.prescolar_check.UseVisualStyleBackColor = false;
            this.prescolar_check.CheckedChanged += new System.EventHandler(this.prescolar_check_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft MHei", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(20, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 90;
            this.label3.Text = "Consulta";
            // 
            // comunicacion_combo
            // 
            this.comunicacion_combo.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comunicacion_combo.FormattingEnabled = true;
            this.comunicacion_combo.Items.AddRange(new object[] {
            "Por dominio del Español",
            "Por dominio del Inglés",
            "Por dominio de LSM"});
            this.comunicacion_combo.Location = new System.Drawing.Point(102, 83);
            this.comunicacion_combo.Margin = new System.Windows.Forms.Padding(2);
            this.comunicacion_combo.Name = "comunicacion_combo";
            this.comunicacion_combo.Size = new System.Drawing.Size(250, 29);
            this.comunicacion_combo.TabIndex = 106;
            this.comunicacion_combo.Visible = false;
            this.comunicacion_combo.SelectionChangeCommitted += new System.EventHandler(this.comunicacion_combo_SelectionChangeCommitted);
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
            this.eleccion_gp.Location = new System.Drawing.Point(16, 245);
            this.eleccion_gp.Margin = new System.Windows.Forms.Padding(2);
            this.eleccion_gp.Name = "eleccion_gp";
            this.eleccion_gp.Padding = new System.Windows.Forms.Padding(2);
            this.eleccion_gp.Size = new System.Drawing.Size(156, 86);
            this.eleccion_gp.TabIndex = 108;
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
            // Reporte
            // 
            this.Reporte.BackColor = System.Drawing.Color.White;
            this.Reporte.Enabled = false;
            this.Reporte.Font = new System.Drawing.Font("Microsoft MHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte.Location = new System.Drawing.Point(49, 368);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(92, 37);
            this.Reporte.TabIndex = 107;
            this.Reporte.Text = "Crear Reporte";
            this.Reporte.UseVisualStyleBackColor = false;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // nivelEducativo_combo
            // 
            this.nivelEducativo_combo.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelEducativo_combo.FormattingEnabled = true;
            this.nivelEducativo_combo.Items.AddRange(new object[] {
            "Con Educación",
            "Con Atención Educativa Espacializada",
            "Por Nivel Educativo",
            "Por Tipo de Educación"});
            this.nivelEducativo_combo.Location = new System.Drawing.Point(100, 83);
            this.nivelEducativo_combo.Margin = new System.Windows.Forms.Padding(2);
            this.nivelEducativo_combo.Name = "nivelEducativo_combo";
            this.nivelEducativo_combo.Size = new System.Drawing.Size(292, 29);
            this.nivelEducativo_combo.TabIndex = 109;
            this.nivelEducativo_combo.Visible = false;
            this.nivelEducativo_combo.SelectionChangeCommitted += new System.EventHandler(this.nivelEducativo_combo_SelectionChangeCommitted);
            // 
            // privada_radio
            // 
            this.privada_radio.AutoSize = true;
            this.privada_radio.BackColor = System.Drawing.Color.Transparent;
            this.privada_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privada_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.privada_radio.Location = new System.Drawing.Point(402, 74);
            this.privada_radio.Margin = new System.Windows.Forms.Padding(2);
            this.privada_radio.Name = "privada_radio";
            this.privada_radio.Size = new System.Drawing.Size(72, 23);
            this.privada_radio.TabIndex = 22;
            this.privada_radio.TabStop = true;
            this.privada_radio.Text = "Privada";
            this.privada_radio.UseVisualStyleBackColor = false;
            this.privada_radio.Visible = false;
            this.privada_radio.CheckedChanged += new System.EventHandler(this.privada_radio_CheckedChanged);
            // 
            // publica_radio
            // 
            this.publica_radio.AutoSize = true;
            this.publica_radio.BackColor = System.Drawing.Color.Transparent;
            this.publica_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publica_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.publica_radio.Location = new System.Drawing.Point(402, 99);
            this.publica_radio.Margin = new System.Windows.Forms.Padding(2);
            this.publica_radio.Name = "publica_radio";
            this.publica_radio.Size = new System.Drawing.Size(70, 23);
            this.publica_radio.TabIndex = 110;
            this.publica_radio.TabStop = true;
            this.publica_radio.Text = "Pública";
            this.publica_radio.UseVisualStyleBackColor = false;
            this.publica_radio.Visible = false;
            this.publica_radio.CheckedChanged += new System.EventHandler(this.publica_radio_CheckedChanged);
            // 
            // zedGraph
            // 
            this.zedGraph.AutoSize = true;
            this.zedGraph.BackColor = System.Drawing.Color.Transparent;
            this.zedGraph.Location = new System.Drawing.Point(174, 207);
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
            this.zedGraph.TabIndex = 111;
            this.zedGraph.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraph.ZoomStepFraction = 0D;
            // 
            // noHanEstudiado_radio
            // 
            this.noHanEstudiado_radio.AutoSize = true;
            this.noHanEstudiado_radio.BackColor = System.Drawing.Color.Transparent;
            this.noHanEstudiado_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noHanEstudiado_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.noHanEstudiado_radio.Location = new System.Drawing.Point(402, 100);
            this.noHanEstudiado_radio.Margin = new System.Windows.Forms.Padding(2);
            this.noHanEstudiado_radio.Name = "noHanEstudiado_radio";
            this.noHanEstudiado_radio.Size = new System.Drawing.Size(135, 23);
            this.noHanEstudiado_radio.TabIndex = 113;
            this.noHanEstudiado_radio.TabStop = true;
            this.noHanEstudiado_radio.Text = "No han estudiado";
            this.noHanEstudiado_radio.UseVisualStyleBackColor = false;
            this.noHanEstudiado_radio.Visible = false;
            this.noHanEstudiado_radio.CheckedChanged += new System.EventHandler(this.noHanEstudiado_radio_CheckedChanged);
            // 
            // hanEstudiado_radio
            // 
            this.hanEstudiado_radio.AutoSize = true;
            this.hanEstudiado_radio.BackColor = System.Drawing.Color.Transparent;
            this.hanEstudiado_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hanEstudiado_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.hanEstudiado_radio.Location = new System.Drawing.Point(402, 75);
            this.hanEstudiado_radio.Margin = new System.Windows.Forms.Padding(2);
            this.hanEstudiado_radio.Name = "hanEstudiado_radio";
            this.hanEstudiado_radio.Size = new System.Drawing.Size(115, 23);
            this.hanEstudiado_radio.TabIndex = 112;
            this.hanEstudiado_radio.TabStop = true;
            this.hanEstudiado_radio.Text = "Han estudiado";
            this.hanEstudiado_radio.UseVisualStyleBackColor = false;
            this.hanEstudiado_radio.Visible = false;
            this.hanEstudiado_radio.CheckedChanged += new System.EventHandler(this.hanEstudiado_radio_CheckedChanged);
            // 
            // normal_radio
            // 
            this.normal_radio.AutoSize = true;
            this.normal_radio.BackColor = System.Drawing.Color.Transparent;
            this.normal_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normal_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.normal_radio.Location = new System.Drawing.Point(403, 101);
            this.normal_radio.Margin = new System.Windows.Forms.Padding(2);
            this.normal_radio.Name = "normal_radio";
            this.normal_radio.Size = new System.Drawing.Size(72, 23);
            this.normal_radio.TabIndex = 115;
            this.normal_radio.TabStop = true;
            this.normal_radio.Text = "Normal";
            this.normal_radio.UseVisualStyleBackColor = false;
            this.normal_radio.Visible = false;
            this.normal_radio.CheckedChanged += new System.EventHandler(this.normal_radio_CheckedChanged);
            // 
            // especial_radio
            // 
            this.especial_radio.AutoSize = true;
            this.especial_radio.BackColor = System.Drawing.Color.Transparent;
            this.especial_radio.Font = new System.Drawing.Font("Microsoft MHei", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especial_radio.ForeColor = System.Drawing.SystemColors.Control;
            this.especial_radio.Location = new System.Drawing.Point(403, 75);
            this.especial_radio.Margin = new System.Windows.Forms.Padding(2);
            this.especial_radio.Name = "especial_radio";
            this.especial_radio.Size = new System.Drawing.Size(74, 23);
            this.especial_radio.TabIndex = 114;
            this.especial_radio.TabStop = true;
            this.especial_radio.Text = "Especial";
            this.especial_radio.UseVisualStyleBackColor = false;
            this.especial_radio.Visible = false;
            this.especial_radio.CheckedChanged += new System.EventHandler(this.especial_radio_CheckedChanged);
            // 
            // consulta_educacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CSEQ.Properties.Resources.fondonopesado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.normal_radio);
            this.Controls.Add(this.especial_radio);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.nivelEducativo_combo);
            this.Controls.Add(this.eleccion_gp);
            this.Controls.Add(this.Reporte);
            this.Controls.Add(this.comunicacion_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.back_picture);
            this.Controls.Add(this.close_picture);
            this.Controls.Add(this.noHanEstudiado_radio);
            this.Controls.Add(this.hanEstudiado_radio);
            this.Controls.Add(this.nivelesEducativos_gp);
            this.Controls.Add(this.publica_radio);
            this.Controls.Add(this.privada_radio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "consulta_educacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta_educacion";
            this.Load += new System.EventHandler(this.consulta_educacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_picture)).EndInit();
            this.nivelesEducativos_gp.ResumeLayout(false);
            this.nivelesEducativos_gp.PerformLayout();
            this.eleccion_gp.ResumeLayout(false);
            this.eleccion_gp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox back_picture;
        private System.Windows.Forms.PictureBox close_picture;
        private System.Windows.Forms.ToolTip salir_tt;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.GroupBox nivelesEducativos_gp;
        private System.Windows.Forms.CheckBox doctorado_check;
        private System.Windows.Forms.CheckBox maestria_check;
        private System.Windows.Forms.CheckBox especialidad_check;
        private System.Windows.Forms.CheckBox licenciatura_check;
        private System.Windows.Forms.CheckBox carreraTecnica_check;
        private System.Windows.Forms.CheckBox preparatoria_check;
        private System.Windows.Forms.CheckBox secundaria_check;
        private System.Windows.Forms.CheckBox primaria_check;
        private System.Windows.Forms.CheckBox prescolar_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comunicacion_combo;
        private System.Windows.Forms.GroupBox eleccion_gp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ID_censo;
        private System.Windows.Forms.RadioButton todoscensos_radio;
        private System.Windows.Forms.Button Reporte;
        private System.Windows.Forms.ComboBox nivelEducativo_combo;
        private System.Windows.Forms.RadioButton privada_radio;
        private System.Windows.Forms.RadioButton publica_radio;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.RadioButton noHanEstudiado_radio;
        private System.Windows.Forms.RadioButton hanEstudiado_radio;
        private System.Windows.Forms.RadioButton normal_radio;
        private System.Windows.Forms.RadioButton especial_radio;
    }
}