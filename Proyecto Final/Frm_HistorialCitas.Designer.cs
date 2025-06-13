namespace Proyecto_Final
{
    partial class Frm_HistorialCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HistorialCitas));
            this.gpoDatosPaciente = new System.Windows.Forms.GroupBox();
            this.Txt_Sexo = new System.Windows.Forms.TextBox();
            this.Txt_Correo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Time_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.Txt_Cedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Paciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpoDatosMedicos = new System.Windows.Forms.GroupBox();
            this.Txt_Sangre = new System.Windows.Forms.TextBox();
            this.Txt_Enfermedades = new System.Windows.Forms.TextBox();
            this.Txt_Motivo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gpoFechaHoraCita = new System.Windows.Forms.GroupBox();
            this.Time_Hora = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Time_Fecha = new System.Windows.Forms.DateTimePicker();
            this.gpoOpciones = new System.Windows.Forms.GroupBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Siguiente = new System.Windows.Forms.Button();
            this.Btn_Anterior = new System.Windows.Forms.Button();
            this.gpoHospital = new System.Windows.Forms.GroupBox();
            this.Txt_Medico = new System.Windows.Forms.TextBox();
            this.Txt_Especialidad = new System.Windows.Forms.TextBox();
            this.Txt_Hospital = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpoDatosPaciente.SuspendLayout();
            this.gpoDatosMedicos.SuspendLayout();
            this.gpoFechaHoraCita.SuspendLayout();
            this.gpoOpciones.SuspendLayout();
            this.gpoHospital.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpoDatosPaciente
            // 
            this.gpoDatosPaciente.Controls.Add(this.Txt_Sexo);
            this.gpoDatosPaciente.Controls.Add(this.Txt_Correo);
            this.gpoDatosPaciente.Controls.Add(this.label16);
            this.gpoDatosPaciente.Controls.Add(this.Time_Nacimiento);
            this.gpoDatosPaciente.Controls.Add(this.Txt_Cedula);
            this.gpoDatosPaciente.Controls.Add(this.label8);
            this.gpoDatosPaciente.Controls.Add(this.Txt_Paciente);
            this.gpoDatosPaciente.Controls.Add(this.label7);
            this.gpoDatosPaciente.Controls.Add(this.label5);
            this.gpoDatosPaciente.Controls.Add(this.label4);
            this.gpoDatosPaciente.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gpoDatosPaciente.Location = new System.Drawing.Point(10, 149);
            this.gpoDatosPaciente.Name = "gpoDatosPaciente";
            this.gpoDatosPaciente.Size = new System.Drawing.Size(590, 194);
            this.gpoDatosPaciente.TabIndex = 10;
            this.gpoDatosPaciente.TabStop = false;
            this.gpoDatosPaciente.Text = "Datos del Paciente";
            // 
            // Txt_Sexo
            // 
            this.Txt_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Sexo.Location = new System.Drawing.Point(171, 129);
            this.Txt_Sexo.Name = "Txt_Sexo";
            this.Txt_Sexo.ReadOnly = true;
            this.Txt_Sexo.Size = new System.Drawing.Size(121, 20);
            this.Txt_Sexo.TabIndex = 13;
            // 
            // Txt_Correo
            // 
            this.Txt_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Correo.Location = new System.Drawing.Point(171, 162);
            this.Txt_Correo.Name = "Txt_Correo";
            this.Txt_Correo.ReadOnly = true;
            this.Txt_Correo.Size = new System.Drawing.Size(200, 20);
            this.Txt_Correo.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(119, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Email";
            // 
            // Time_Nacimiento
            // 
            this.Time_Nacimiento.CustomFormat = "dd/MM/yyyy";
            this.Time_Nacimiento.Enabled = false;
            this.Time_Nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Time_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time_Nacimiento.Location = new System.Drawing.Point(171, 91);
            this.Time_Nacimiento.Name = "Time_Nacimiento";
            this.Time_Nacimiento.Size = new System.Drawing.Size(100, 20);
            this.Time_Nacimiento.TabIndex = 10;
            this.Time_Nacimiento.Value = new System.DateTime(2024, 4, 3, 14, 23, 48, 0);
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Cedula.Location = new System.Drawing.Point(171, 56);
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.ReadOnly = true;
            this.Txt_Cedula.Size = new System.Drawing.Size(200, 20);
            this.Txt_Cedula.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cédula";
            // 
            // Txt_Paciente
            // 
            this.Txt_Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Paciente.Location = new System.Drawing.Point(171, 23);
            this.Txt_Paciente.Name = "Txt_Paciente";
            this.Txt_Paciente.ReadOnly = true;
            this.Txt_Paciente.Size = new System.Drawing.Size(400, 20);
            this.Txt_Paciente.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre";
            // 
            // gpoDatosMedicos
            // 
            this.gpoDatosMedicos.Controls.Add(this.Txt_Sangre);
            this.gpoDatosMedicos.Controls.Add(this.Txt_Enfermedades);
            this.gpoDatosMedicos.Controls.Add(this.Txt_Motivo);
            this.gpoDatosMedicos.Controls.Add(this.label11);
            this.gpoDatosMedicos.Controls.Add(this.label10);
            this.gpoDatosMedicos.Controls.Add(this.label9);
            this.gpoDatosMedicos.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gpoDatosMedicos.Location = new System.Drawing.Point(10, 353);
            this.gpoDatosMedicos.Name = "gpoDatosMedicos";
            this.gpoDatosMedicos.Size = new System.Drawing.Size(590, 236);
            this.gpoDatosMedicos.TabIndex = 16;
            this.gpoDatosMedicos.TabStop = false;
            this.gpoDatosMedicos.Text = "Datos Médicos";
            // 
            // Txt_Sangre
            // 
            this.Txt_Sangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Sangre.Location = new System.Drawing.Point(171, 26);
            this.Txt_Sangre.Name = "Txt_Sangre";
            this.Txt_Sangre.ReadOnly = true;
            this.Txt_Sangre.Size = new System.Drawing.Size(121, 20);
            this.Txt_Sangre.TabIndex = 14;
            // 
            // Txt_Enfermedades
            // 
            this.Txt_Enfermedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Enfermedades.Location = new System.Drawing.Point(171, 61);
            this.Txt_Enfermedades.Name = "Txt_Enfermedades";
            this.Txt_Enfermedades.ReadOnly = true;
            this.Txt_Enfermedades.Size = new System.Drawing.Size(400, 20);
            this.Txt_Enfermedades.TabIndex = 5;
            // 
            // Txt_Motivo
            // 
            this.Txt_Motivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Motivo.Location = new System.Drawing.Point(171, 99);
            this.Txt_Motivo.Multiline = true;
            this.Txt_Motivo.Name = "Txt_Motivo";
            this.Txt_Motivo.ReadOnly = true;
            this.Txt_Motivo.Size = new System.Drawing.Size(400, 131);
            this.Txt_Motivo.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Motivo de Cita";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(82, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Enfemades";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo de Sangre";
            // 
            // gpoFechaHoraCita
            // 
            this.gpoFechaHoraCita.Controls.Add(this.Time_Hora);
            this.gpoFechaHoraCita.Controls.Add(this.label15);
            this.gpoFechaHoraCita.Controls.Add(this.label14);
            this.gpoFechaHoraCita.Controls.Add(this.Time_Fecha);
            this.gpoFechaHoraCita.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gpoFechaHoraCita.Location = new System.Drawing.Point(615, 9);
            this.gpoFechaHoraCita.Name = "gpoFechaHoraCita";
            this.gpoFechaHoraCita.Size = new System.Drawing.Size(207, 94);
            this.gpoFechaHoraCita.TabIndex = 17;
            this.gpoFechaHoraCita.TabStop = false;
            this.gpoFechaHoraCita.Text = "Fecha de Cita";
            // 
            // Time_Hora
            // 
            this.Time_Hora.CustomFormat = "hh:mm  tt";
            this.Time_Hora.Enabled = false;
            this.Time_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Time_Hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time_Hora.Location = new System.Drawing.Point(76, 59);
            this.Time_Hora.Name = "Time_Hora";
            this.Time_Hora.Size = new System.Drawing.Size(100, 20);
            this.Time_Hora.TabIndex = 27;
            this.Time_Hora.Value = new System.DateTime(2024, 4, 4, 7, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Hora";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Fecha";
            // 
            // Time_Fecha
            // 
            this.Time_Fecha.CustomFormat = "dd/MM/yyyy";
            this.Time_Fecha.Enabled = false;
            this.Time_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Time_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time_Fecha.Location = new System.Drawing.Point(76, 29);
            this.Time_Fecha.Name = "Time_Fecha";
            this.Time_Fecha.Size = new System.Drawing.Size(100, 20);
            this.Time_Fecha.TabIndex = 0;
            this.Time_Fecha.Value = new System.DateTime(2024, 4, 3, 14, 23, 48, 0);
            // 
            // gpoOpciones
            // 
            this.gpoOpciones.Controls.Add(this.Btn_Salir);
            this.gpoOpciones.Controls.Add(this.Btn_Siguiente);
            this.gpoOpciones.Controls.Add(this.Btn_Anterior);
            this.gpoOpciones.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gpoOpciones.Location = new System.Drawing.Point(615, 109);
            this.gpoOpciones.Name = "gpoOpciones";
            this.gpoOpciones.Size = new System.Drawing.Size(207, 213);
            this.gpoOpciones.TabIndex = 18;
            this.gpoOpciones.TabStop = false;
            this.gpoOpciones.Text = "Opciones";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(19, 169);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(150, 30);
            this.Btn_Salir.TabIndex = 3;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Siguiente
            // 
            this.Btn_Siguiente.Location = new System.Drawing.Point(19, 101);
            this.Btn_Siguiente.Name = "Btn_Siguiente";
            this.Btn_Siguiente.Size = new System.Drawing.Size(150, 30);
            this.Btn_Siguiente.TabIndex = 1;
            this.Btn_Siguiente.Text = "Siguiente";
            this.Btn_Siguiente.UseVisualStyleBackColor = true;
            this.Btn_Siguiente.Click += new System.EventHandler(this.Btn_Siguiente_Click);
            // 
            // Btn_Anterior
            // 
            this.Btn_Anterior.Location = new System.Drawing.Point(19, 39);
            this.Btn_Anterior.Name = "Btn_Anterior";
            this.Btn_Anterior.Size = new System.Drawing.Size(150, 30);
            this.Btn_Anterior.TabIndex = 0;
            this.Btn_Anterior.Text = "Anterior";
            this.Btn_Anterior.UseVisualStyleBackColor = true;
            this.Btn_Anterior.Click += new System.EventHandler(this.Btn_Anterior_Click);
            // 
            // gpoHospital
            // 
            this.gpoHospital.Controls.Add(this.Txt_Medico);
            this.gpoHospital.Controls.Add(this.Txt_Especialidad);
            this.gpoHospital.Controls.Add(this.Txt_Hospital);
            this.gpoHospital.Controls.Add(this.label3);
            this.gpoHospital.Controls.Add(this.label2);
            this.gpoHospital.Controls.Add(this.label1);
            this.gpoHospital.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpoHospital.Location = new System.Drawing.Point(10, 12);
            this.gpoHospital.Name = "gpoHospital";
            this.gpoHospital.Size = new System.Drawing.Size(590, 129);
            this.gpoHospital.TabIndex = 19;
            this.gpoHospital.TabStop = false;
            this.gpoHospital.Text = "Datos del Hospital";
            // 
            // Txt_Medico
            // 
            this.Txt_Medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Medico.Location = new System.Drawing.Point(181, 95);
            this.Txt_Medico.Name = "Txt_Medico";
            this.Txt_Medico.ReadOnly = true;
            this.Txt_Medico.Size = new System.Drawing.Size(400, 20);
            this.Txt_Medico.TabIndex = 21;
            // 
            // Txt_Especialidad
            // 
            this.Txt_Especialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Especialidad.Location = new System.Drawing.Point(181, 62);
            this.Txt_Especialidad.Name = "Txt_Especialidad";
            this.Txt_Especialidad.ReadOnly = true;
            this.Txt_Especialidad.Size = new System.Drawing.Size(400, 20);
            this.Txt_Especialidad.TabIndex = 20;
            // 
            // Txt_Hospital
            // 
            this.Txt_Hospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Hospital.Location = new System.Drawing.Point(181, 29);
            this.Txt_Hospital.Name = "Txt_Hospital";
            this.Txt_Hospital.ReadOnly = true;
            this.Txt_Hospital.Size = new System.Drawing.Size(400, 20);
            this.Txt_Hospital.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(115, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Médico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Especialidad de Médico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(110, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hospital";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(615, 344);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(207, 26);
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Visible = false;
            // 
            // Frm_HistorialCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 601);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gpoHospital);
            this.Controls.Add(this.gpoOpciones);
            this.Controls.Add(this.gpoFechaHoraCita);
            this.Controls.Add(this.gpoDatosMedicos);
            this.Controls.Add(this.gpoDatosPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HistorialCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Citas";
            this.Load += new System.EventHandler(this.Frm_HistorialCitas_Load);
            this.gpoDatosPaciente.ResumeLayout(false);
            this.gpoDatosPaciente.PerformLayout();
            this.gpoDatosMedicos.ResumeLayout(false);
            this.gpoDatosMedicos.PerformLayout();
            this.gpoFechaHoraCita.ResumeLayout(false);
            this.gpoFechaHoraCita.PerformLayout();
            this.gpoOpciones.ResumeLayout(false);
            this.gpoHospital.ResumeLayout(false);
            this.gpoHospital.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpoDatosPaciente;
        private System.Windows.Forms.TextBox Txt_Correo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker Time_Nacimiento;
        private System.Windows.Forms.TextBox Txt_Cedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Paciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpoDatosMedicos;
        private System.Windows.Forms.TextBox Txt_Enfermedades;
        private System.Windows.Forms.TextBox Txt_Motivo;
        protected System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Sexo;
        private System.Windows.Forms.TextBox Txt_Sangre;
        private System.Windows.Forms.GroupBox gpoFechaHoraCita;
        private System.Windows.Forms.DateTimePicker Time_Hora;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker Time_Fecha;
        private System.Windows.Forms.GroupBox gpoOpciones;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Siguiente;
        private System.Windows.Forms.Button Btn_Anterior;
        private System.Windows.Forms.GroupBox gpoHospital;
        private System.Windows.Forms.TextBox Txt_Medico;
        private System.Windows.Forms.TextBox Txt_Especialidad;
        private System.Windows.Forms.TextBox Txt_Hospital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}