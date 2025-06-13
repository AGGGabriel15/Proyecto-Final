namespace Proyecto_Final
{
    partial class Frm_NuevoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NuevoPaciente));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Cedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComBox_Sexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Date_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.ComBox_TipSangre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Enfermedades = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txt_Busqueda = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Txt_Email);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Txt_Enfermedades);
            this.groupBox2.Controls.Add(this.ComBox_TipSangre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Date_Nacimiento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ComBox_Sexo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Txt_Cedula);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Txt_Apellido);
            this.groupBox2.Controls.Add(this.Txt_Nombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 250);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Paciente";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Nombre.Location = new System.Drawing.Point(140, 30);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(514, 20);
            this.Txt_Nombre.TabIndex = 3;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Apellido.Location = new System.Drawing.Point(140, 65);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(514, 20);
            this.Txt_Apellido.TabIndex = 4;
            this.Txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Apellido_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cedula";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Cedula.Location = new System.Drawing.Point(140, 100);
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(179, 20);
            this.Txt_Cedula.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComBox_Sexo
            // 
            this.ComBox_Sexo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComBox_Sexo.FormattingEnabled = true;
            this.ComBox_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.ComBox_Sexo.Location = new System.Drawing.Point(140, 135);
            this.ComBox_Sexo.Name = "ComBox_Sexo";
            this.ComBox_Sexo.Size = new System.Drawing.Size(179, 23);
            this.ComBox_Sexo.TabIndex = 10;
            this.ComBox_Sexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComBox_Sexo_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de Nacimiento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Date_Nacimiento
            // 
            this.Date_Nacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date_Nacimiento.CustomFormat = "dd/MM/yyyy";
            this.Date_Nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Date_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Nacimiento.Location = new System.Drawing.Point(533, 104);
            this.Date_Nacimiento.Name = "Date_Nacimiento";
            this.Date_Nacimiento.Size = new System.Drawing.Size(120, 20);
            this.Date_Nacimiento.TabIndex = 14;
            this.Date_Nacimiento.Value = new System.DateTime(2025, 6, 12, 0, 0, 0, 0);
            // 
            // ComBox_TipSangre
            // 
            this.ComBox_TipSangre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComBox_TipSangre.FormattingEnabled = true;
            this.ComBox_TipSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.ComBox_TipSangre.Location = new System.Drawing.Point(474, 135);
            this.ComBox_TipSangre.Name = "ComBox_TipSangre";
            this.ComBox_TipSangre.Size = new System.Drawing.Size(179, 23);
            this.ComBox_TipSangre.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tipo de sangre";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Enfermedades";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Enfermedades
            // 
            this.Txt_Enfermedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Enfermedades.Location = new System.Drawing.Point(140, 170);
            this.Txt_Enfermedades.Name = "Txt_Enfermedades";
            this.Txt_Enfermedades.Size = new System.Drawing.Size(514, 20);
            this.Txt_Enfermedades.TabIndex = 17;
            this.Txt_Enfermedades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Enfermedades_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Email.Location = new System.Drawing.Point(140, 205);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(259, 20);
            this.Txt_Email.TabIndex = 19;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Btn_Limpiar);
            this.groupBox7.Controls.Add(this.Btn_Eliminar);
            this.groupBox7.Controls.Add(this.Btn_Editar);
            this.groupBox7.Controls.Add(this.Btn_Cancelar);
            this.groupBox7.Controls.Add(this.Btn_Guardar);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(12, 265);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(660, 70);
            this.groupBox7.TabIndex = 33;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Opciones";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Cancelar.Location = new System.Drawing.Point(553, 26);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(100, 31);
            this.Btn_Cancelar.TabIndex = 32;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Guardar.Location = new System.Drawing.Point(7, 26);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(100, 31);
            this.Btn_Guardar.TabIndex = 30;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Editar.Location = new System.Drawing.Point(140, 26);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(100, 31);
            this.Btn_Editar.TabIndex = 33;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Eliminar.Location = new System.Drawing.Point(278, 26);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(100, 31);
            this.Btn_Eliminar.TabIndex = 34;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Limpiar.Location = new System.Drawing.Point(416, 26);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(100, 31);
            this.Btn_Limpiar.TabIndex = 35;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 425);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(660, 200);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Txt_Busqueda
            // 
            this.Txt_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Busqueda.Location = new System.Drawing.Point(7, 33);
            this.Txt_Busqueda.Name = "Txt_Busqueda";
            this.Txt_Busqueda.Size = new System.Drawing.Size(417, 20);
            this.Txt_Busqueda.TabIndex = 36;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Buscar.Location = new System.Drawing.Point(430, 26);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(100, 31);
            this.Btn_Buscar.TabIndex = 35;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Txt_Busqueda);
            this.groupBox8.Controls.Add(this.Btn_Buscar);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox8.Location = new System.Drawing.Point(12, 340);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(660, 70);
            this.groupBox8.TabIndex = 37;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Busqueda";
            // 
            // Frm_NuevoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 636);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_NuevoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.Frm_NuevoPaciente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Cedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComBox_Sexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Date_Nacimiento;
        private System.Windows.Forms.ComboBox ComBox_TipSangre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Enfermedades;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Txt_Busqueda;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}