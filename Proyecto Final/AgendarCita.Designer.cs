namespace Proyecto_Final
{
    partial class Frm_AgendarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AgendarCita));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Enfermedades = new System.Windows.Forms.TextBox();
            this.Txt_Motivo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ComBox_Medico = new System.Windows.Forms.ComboBox();
            this.ComBox_Especialidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComBox_Hospital = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Sexo = new System.Windows.Forms.TextBox();
            this.Btn_NuevoPaciente = new System.Windows.Forms.Button();
            this.Btn_BuscarPaciente = new System.Windows.Forms.Button();
            this.Txt_Correo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Time_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.Txt_Cedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Time_SalidaMedico = new System.Windows.Forms.DateTimePicker();
            this.Time_EntradaMedico = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Time_Fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Time_Salida = new System.Windows.Forms.DateTimePicker();
            this.Time_Entrada = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Txt_TipoSangre = new System.Windows.Forms.TextBox();
            this.rb7am = new System.Windows.Forms.RadioButton();
            this.rb8am = new System.Windows.Forms.RadioButton();
            this.rb9am = new System.Windows.Forms.RadioButton();
            this.rb10am = new System.Windows.Forms.RadioButton();
            this.rb11am = new System.Windows.Forms.RadioButton();
            this.rb12pm = new System.Windows.Forms.RadioButton();
            this.rb1pm = new System.Windows.Forms.RadioButton();
            this.rb2pm = new System.Windows.Forms.RadioButton();
            this.rb3pm = new System.Windows.Forms.RadioButton();
            this.rb4pm = new System.Windows.Forms.RadioButton();
            this.rb5pm = new System.Windows.Forms.RadioButton();
            this.rb6pm = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_TipoSangre);
            this.groupBox1.Controls.Add(this.Txt_Enfermedades);
            this.groupBox1.Controls.Add(this.Txt_Motivo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(9, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Médicos";
            // 
            // Txt_Enfermedades
            // 
            this.Txt_Enfermedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Enfermedades.Location = new System.Drawing.Point(171, 78);
            this.Txt_Enfermedades.Name = "Txt_Enfermedades";
            this.Txt_Enfermedades.Size = new System.Drawing.Size(550, 20);
            this.Txt_Enfermedades.TabIndex = 5;
            this.Txt_Enfermedades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Enfermedades_KeyPress);
            // 
            // Txt_Motivo
            // 
            this.Txt_Motivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Motivo.Location = new System.Drawing.Point(171, 116);
            this.Txt_Motivo.Multiline = true;
            this.Txt_Motivo.Name = "Txt_Motivo";
            this.Txt_Motivo.Size = new System.Drawing.Size(550, 100);
            this.Txt_Motivo.TabIndex = 3;
            this.Txt_Motivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Motivo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Motivo de la cita";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(81, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Enfemades";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo de sangre";
            // 
            // ComBox_Medico
            // 
            this.ComBox_Medico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox_Medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ComBox_Medico.FormattingEnabled = true;
            this.ComBox_Medico.Location = new System.Drawing.Point(180, 75);
            this.ComBox_Medico.Name = "ComBox_Medico";
            this.ComBox_Medico.Size = new System.Drawing.Size(300, 21);
            this.ComBox_Medico.TabIndex = 11;
            this.ComBox_Medico.SelectedIndexChanged += new System.EventHandler(this.ComBox_Medico_SelectedIndexChanged);
            this.ComBox_Medico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComBox_Medico_KeyPress);
            // 
            // ComBox_Especialidad
            // 
            this.ComBox_Especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox_Especialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ComBox_Especialidad.FormattingEnabled = true;
            this.ComBox_Especialidad.Location = new System.Drawing.Point(180, 40);
            this.ComBox_Especialidad.Name = "ComBox_Especialidad";
            this.ComBox_Especialidad.Size = new System.Drawing.Size(300, 21);
            this.ComBox_Especialidad.TabIndex = 10;
            this.ComBox_Especialidad.SelectedIndexChanged += new System.EventHandler(this.ComBox_Especialidad_SelectedIndexChanged);
            this.ComBox_Especialidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComBox_Especialidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(114, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Médico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(81, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Especialidad";
            // 
            // ComBox_Hospital
            // 
            this.ComBox_Hospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox_Hospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ComBox_Hospital.FormattingEnabled = true;
            this.ComBox_Hospital.Location = new System.Drawing.Point(180, 9);
            this.ComBox_Hospital.Name = "ComBox_Hospital";
            this.ComBox_Hospital.Size = new System.Drawing.Size(550, 21);
            this.ComBox_Hospital.TabIndex = 7;
            this.ComBox_Hospital.SelectedIndexChanged += new System.EventHandler(this.ComBox_Hospital_SelectedIndexChanged);
            this.ComBox_Hospital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComBox_Hospital_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(108, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hospital";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Sexo);
            this.groupBox2.Controls.Add(this.Btn_NuevoPaciente);
            this.groupBox2.Controls.Add(this.Btn_BuscarPaciente);
            this.groupBox2.Controls.Add(this.Txt_Correo);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.Time_Nacimiento);
            this.groupBox2.Controls.Add(this.Txt_Cedula);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Txt_Nombre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(9, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Paciente";
            // 
            // Txt_Sexo
            // 
            this.Txt_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Sexo.Location = new System.Drawing.Point(171, 126);
            this.Txt_Sexo.Name = "Txt_Sexo";
            this.Txt_Sexo.Size = new System.Drawing.Size(121, 20);
            this.Txt_Sexo.TabIndex = 14;
            // 
            // Btn_NuevoPaciente
            // 
            this.Btn_NuevoPaciente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_NuevoPaciente.Location = new System.Drawing.Point(630, 20);
            this.Btn_NuevoPaciente.Name = "Btn_NuevoPaciente";
            this.Btn_NuevoPaciente.Size = new System.Drawing.Size(100, 28);
            this.Btn_NuevoPaciente.TabIndex = 13;
            this.Btn_NuevoPaciente.Text = "Nuevo";
            this.Btn_NuevoPaciente.UseVisualStyleBackColor = true;
            this.Btn_NuevoPaciente.Click += new System.EventHandler(this.Btn_NuevoPaciente_Click);
            // 
            // Btn_BuscarPaciente
            // 
            this.Btn_BuscarPaciente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_BuscarPaciente.Location = new System.Drawing.Point(501, 20);
            this.Btn_BuscarPaciente.Name = "Btn_BuscarPaciente";
            this.Btn_BuscarPaciente.Size = new System.Drawing.Size(100, 28);
            this.Btn_BuscarPaciente.TabIndex = 4;
            this.Btn_BuscarPaciente.Text = "Buscar";
            this.Btn_BuscarPaciente.UseVisualStyleBackColor = true;
            this.Btn_BuscarPaciente.Click += new System.EventHandler(this.Btn_BuscarPaciente_Click);
            // 
            // Txt_Correo
            // 
            this.Txt_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Correo.Location = new System.Drawing.Point(170, 155);
            this.Txt_Correo.Name = "Txt_Correo";
            this.Txt_Correo.Size = new System.Drawing.Size(250, 20);
            this.Txt_Correo.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(118, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Email";
            // 
            // Time_Nacimiento
            // 
            this.Time_Nacimiento.CustomFormat = "dd/MM/yyyy";
            this.Time_Nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Time_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time_Nacimiento.Location = new System.Drawing.Point(171, 96);
            this.Time_Nacimiento.Name = "Time_Nacimiento";
            this.Time_Nacimiento.Size = new System.Drawing.Size(121, 20);
            this.Time_Nacimiento.TabIndex = 10;
            this.Time_Nacimiento.Value = new System.DateTime(2024, 4, 3, 14, 23, 48, 0);
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Cedula.Location = new System.Drawing.Point(171, 26);
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(300, 20);
            this.Txt_Cedula.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cédula";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Nombre.Location = new System.Drawing.Point(171, 65);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(400, 20);
            this.Txt_Nombre.TabIndex = 4;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(795, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 386);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agendar Fecha";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.Time_SalidaMedico);
            this.groupBox7.Controls.Add(this.Time_EntradaMedico);
            this.groupBox7.Location = new System.Drawing.Point(6, 106);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(315, 72);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Horarios Disponibles Médico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(145, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "hasta";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(13, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 17);
            this.label17.TabIndex = 28;
            this.label17.Text = "De";
            // 
            // Time_SalidaMedico
            // 
            this.Time_SalidaMedico.CustomFormat = "hh:mm  tt";
            this.Time_SalidaMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Time_SalidaMedico.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time_SalidaMedico.Location = new System.Drawing.Point(194, 38);
            this.Time_SalidaMedico.Name = "Time_SalidaMedico";
            this.Time_SalidaMedico.Size = new System.Drawing.Size(96, 20);
            this.Time_SalidaMedico.TabIndex = 27;
            this.Time_SalidaMedico.Value = new System.DateTime(2024, 4, 4, 22, 0, 0, 0);
            // 
            // Time_EntradaMedico
            // 
            this.Time_EntradaMedico.CustomFormat = "hh:mm  tt";
            this.Time_EntradaMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Time_EntradaMedico.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time_EntradaMedico.Location = new System.Drawing.Point(45, 38);
            this.Time_EntradaMedico.Name = "Time_EntradaMedico";
            this.Time_EntradaMedico.Size = new System.Drawing.Size(94, 20);
            this.Time_EntradaMedico.TabIndex = 26;
            this.Time_EntradaMedico.Value = new System.DateTime(2024, 4, 4, 7, 0, 0, 0);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb6pm);
            this.groupBox5.Controls.Add(this.rb5pm);
            this.groupBox5.Controls.Add(this.rb4pm);
            this.groupBox5.Controls.Add(this.rb3pm);
            this.groupBox5.Controls.Add(this.rb2pm);
            this.groupBox5.Controls.Add(this.rb1pm);
            this.groupBox5.Controls.Add(this.rb12pm);
            this.groupBox5.Controls.Add(this.rb11am);
            this.groupBox5.Controls.Add(this.rb10am);
            this.groupBox5.Controls.Add(this.rb9am);
            this.groupBox5.Controls.Add(this.rb8am);
            this.groupBox5.Controls.Add(this.rb7am);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.Time_Fecha);
            this.groupBox5.Location = new System.Drawing.Point(6, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(315, 196);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fecha de Cita";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Hora";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Fecha";
            // 
            // Time_Fecha
            // 
            this.Time_Fecha.CustomFormat = "dd/MM/yyyy";
            this.Time_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Time_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time_Fecha.Location = new System.Drawing.Point(76, 25);
            this.Time_Fecha.Name = "Time_Fecha";
            this.Time_Fecha.Size = new System.Drawing.Size(100, 20);
            this.Time_Fecha.TabIndex = 0;
            this.Time_Fecha.Value = new System.DateTime(2024, 4, 3, 14, 23, 48, 0);
            this.Time_Fecha.ValueChanged += new System.EventHandler(this.Time_Fecha_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.Time_Salida);
            this.groupBox4.Controls.Add(this.Time_Entrada);
            this.groupBox4.Location = new System.Drawing.Point(6, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 72);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Horarios Disponibles Hospital";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(145, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "hasta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(13, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "De";
            // 
            // Time_Salida
            // 
            this.Time_Salida.CustomFormat = "hh:mm  tt";
            this.Time_Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Time_Salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time_Salida.Location = new System.Drawing.Point(194, 38);
            this.Time_Salida.Name = "Time_Salida";
            this.Time_Salida.Size = new System.Drawing.Size(96, 20);
            this.Time_Salida.TabIndex = 27;
            this.Time_Salida.Value = new System.DateTime(2024, 4, 4, 22, 0, 0, 0);
            // 
            // Time_Entrada
            // 
            this.Time_Entrada.CustomFormat = "hh:mm  tt";
            this.Time_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Time_Entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time_Entrada.Location = new System.Drawing.Point(45, 38);
            this.Time_Entrada.Name = "Time_Entrada";
            this.Time_Entrada.Size = new System.Drawing.Size(94, 20);
            this.Time_Entrada.TabIndex = 26;
            this.Time_Entrada.Value = new System.DateTime(2024, 4, 4, 7, 0, 0, 0);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Btn_Salir);
            this.groupBox6.Controls.Add(this.Btn_Cancelar);
            this.groupBox6.Controls.Add(this.Btn_Registrar);
            this.groupBox6.Controls.Add(this.Btn_Nuevo);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(795, 414);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(327, 108);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Opciones";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(171, 64);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(150, 30);
            this.Btn_Salir.TabIndex = 3;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(14, 64);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(150, 30);
            this.Btn_Cancelar.TabIndex = 2;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.Location = new System.Drawing.Point(170, 28);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(150, 30);
            this.Btn_Registrar.TabIndex = 1;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = true;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(14, 28);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(150, 30);
            this.Btn_Nuevo.TabIndex = 0;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(795, 528);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(327, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Txt_TipoSangre
            // 
            this.Txt_TipoSangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_TipoSangre.Location = new System.Drawing.Point(171, 40);
            this.Txt_TipoSangre.Name = "Txt_TipoSangre";
            this.Txt_TipoSangre.Size = new System.Drawing.Size(121, 20);
            this.Txt_TipoSangre.TabIndex = 15;
            // 
            // rb7am
            // 
            this.rb7am.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb7am.AutoSize = true;
            this.rb7am.BackColor = System.Drawing.Color.White;
            this.rb7am.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rb7am.Location = new System.Drawing.Point(17, 73);
            this.rb7am.Name = "rb7am";
            this.rb7am.Size = new System.Drawing.Size(66, 25);
            this.rb7am.TabIndex = 3;
            this.rb7am.TabStop = true;
            this.rb7am.Text = "7:00 a.m.";
            this.rb7am.UseVisualStyleBackColor = false;
            // 
            // rb8am
            // 
            this.rb8am.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb8am.AutoSize = true;
            this.rb8am.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rb8am.Location = new System.Drawing.Point(100, 73);
            this.rb8am.Name = "rb8am";
            this.rb8am.Size = new System.Drawing.Size(67, 25);
            this.rb8am.TabIndex = 4;
            this.rb8am.TabStop = true;
            this.rb8am.Text = "8:00 a.m.";
            this.rb8am.UseVisualStyleBackColor = true;
            // 
            // rb9am
            // 
            this.rb9am.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb9am.AutoSize = true;
            this.rb9am.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rb9am.Location = new System.Drawing.Point(190, 73);
            this.rb9am.Name = "rb9am";
            this.rb9am.Size = new System.Drawing.Size(67, 25);
            this.rb9am.TabIndex = 5;
            this.rb9am.TabStop = true;
            this.rb9am.Text = "9:00 a.m.";
            this.rb9am.UseVisualStyleBackColor = true;
            // 
            // rb10am
            // 
            this.rb10am.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb10am.AutoSize = true;
            this.rb10am.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rb10am.Location = new System.Drawing.Point(17, 104);
            this.rb10am.Name = "rb10am";
            this.rb10am.Size = new System.Drawing.Size(72, 25);
            this.rb10am.TabIndex = 6;
            this.rb10am.TabStop = true;
            this.rb10am.Text = "10:00 a.m.";
            this.rb10am.UseVisualStyleBackColor = true;
            // 
            // rb11am
            // 
            this.rb11am.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb11am.AutoSize = true;
            this.rb11am.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rb11am.Location = new System.Drawing.Point(100, 104);
            this.rb11am.Name = "rb11am";
            this.rb11am.Size = new System.Drawing.Size(70, 25);
            this.rb11am.TabIndex = 7;
            this.rb11am.TabStop = true;
            this.rb11am.Text = "11:00 a.m.";
            this.rb11am.UseVisualStyleBackColor = true;
            // 
            // rb12pm
            // 
            this.rb12pm.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb12pm.AutoSize = true;
            this.rb12pm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rb12pm.Location = new System.Drawing.Point(190, 104);
            this.rb12pm.Name = "rb12pm";
            this.rb12pm.Size = new System.Drawing.Size(73, 25);
            this.rb12pm.TabIndex = 8;
            this.rb12pm.TabStop = true;
            this.rb12pm.Text = "12:00 p.m.";
            this.rb12pm.UseVisualStyleBackColor = true;
            // 
            // rb1pm
            // 
            this.rb1pm.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb1pm.AutoSize = true;
            this.rb1pm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rb1pm.Location = new System.Drawing.Point(19, 135);
            this.rb1pm.Name = "rb1pm";
            this.rb1pm.Size = new System.Drawing.Size(66, 25);
            this.rb1pm.TabIndex = 9;
            this.rb1pm.TabStop = true;
            this.rb1pm.Text = "1:00 p.m.";
            this.rb1pm.UseVisualStyleBackColor = true;
            // 
            // rb2pm
            // 
            this.rb2pm.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb2pm.AutoSize = true;
            this.rb2pm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rb2pm.Location = new System.Drawing.Point(100, 135);
            this.rb2pm.Name = "rb2pm";
            this.rb2pm.Size = new System.Drawing.Size(68, 25);
            this.rb2pm.TabIndex = 10;
            this.rb2pm.TabStop = true;
            this.rb2pm.Text = "2:00 p.m.";
            this.rb2pm.UseVisualStyleBackColor = true;
            // 
            // rb3pm
            // 
            this.rb3pm.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb3pm.AutoSize = true;
            this.rb3pm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rb3pm.Location = new System.Drawing.Point(190, 135);
            this.rb3pm.Name = "rb3pm";
            this.rb3pm.Size = new System.Drawing.Size(68, 25);
            this.rb3pm.TabIndex = 11;
            this.rb3pm.TabStop = true;
            this.rb3pm.Text = "3:00 p.m.";
            this.rb3pm.UseVisualStyleBackColor = true;
            // 
            // rb4pm
            // 
            this.rb4pm.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb4pm.AutoSize = true;
            this.rb4pm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rb4pm.Location = new System.Drawing.Point(17, 165);
            this.rb4pm.Name = "rb4pm";
            this.rb4pm.Size = new System.Drawing.Size(68, 25);
            this.rb4pm.TabIndex = 12;
            this.rb4pm.TabStop = true;
            this.rb4pm.Text = "4:00 p.m.";
            this.rb4pm.UseVisualStyleBackColor = true;
            // 
            // rb5pm
            // 
            this.rb5pm.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb5pm.AutoSize = true;
            this.rb5pm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rb5pm.Location = new System.Drawing.Point(100, 165);
            this.rb5pm.Name = "rb5pm";
            this.rb5pm.Size = new System.Drawing.Size(68, 25);
            this.rb5pm.TabIndex = 13;
            this.rb5pm.TabStop = true;
            this.rb5pm.Text = "5:00 p.m.";
            this.rb5pm.UseVisualStyleBackColor = true;
            // 
            // rb6pm
            // 
            this.rb6pm.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb6pm.AutoSize = true;
            this.rb6pm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.rb6pm.Location = new System.Drawing.Point(190, 165);
            this.rb6pm.Name = "rb6pm";
            this.rb6pm.Size = new System.Drawing.Size(68, 25);
            this.rb6pm.TabIndex = 14;
            this.rb6pm.TabStop = true;
            this.rb6pm.Text = "6:00 p.m.";
            this.rb6pm.UseVisualStyleBackColor = true;
            // 
            // Frm_AgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 563);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ComBox_Medico);
            this.Controls.Add(this.ComBox_Especialidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComBox_Hospital);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AgendarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Cita";
            this.Load += new System.EventHandler(this.Frm_AgendarCita_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComBox_Medico;
        private System.Windows.Forms.ComboBox ComBox_Especialidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComBox_Hospital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Cedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Enfermedades;
        private System.Windows.Forms.TextBox Txt_Motivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker Time_Fecha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker Time_Salida;
        private System.Windows.Forms.DateTimePicker Time_Entrada;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Salir;
        protected System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker Time_Nacimiento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Txt_Correo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Txt_Sexo;
        private System.Windows.Forms.Button Btn_NuevoPaciente;
        private System.Windows.Forms.Button Btn_BuscarPaciente;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker Time_SalidaMedico;
        private System.Windows.Forms.DateTimePicker Time_EntradaMedico;
        private System.Windows.Forms.TextBox Txt_TipoSangre;
        private System.Windows.Forms.RadioButton rb7am;
        private System.Windows.Forms.RadioButton rb3pm;
        private System.Windows.Forms.RadioButton rb2pm;
        private System.Windows.Forms.RadioButton rb1pm;
        private System.Windows.Forms.RadioButton rb12pm;
        private System.Windows.Forms.RadioButton rb11am;
        private System.Windows.Forms.RadioButton rb10am;
        private System.Windows.Forms.RadioButton rb9am;
        private System.Windows.Forms.RadioButton rb8am;
        private System.Windows.Forms.RadioButton rb6pm;
        private System.Windows.Forms.RadioButton rb5pm;
        private System.Windows.Forms.RadioButton rb4pm;
    }
}