namespace Proyecto_Final
{
    partial class Frm_NuevoHospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NuevoHospital));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChkList_Especialidades = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Time_Salida = new System.Windows.Forms.DateTimePicker();
            this.Time_Entrada = new System.Windows.Forms.DateTimePicker();
            this.Txt_Hospital = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Txt_Busqueda = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Eliminar);
            this.groupBox1.Controls.Add(this.Btn_Editar);
            this.groupBox1.Controls.Add(this.Btn_Guardar);
            this.groupBox1.Controls.Add(this.Btn_Salir);
            this.groupBox1.Controls.Add(this.Btn_Nuevo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(622, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones:";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(22, 136);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(100, 30);
            this.Btn_Eliminar.TabIndex = 5;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Elimiar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Location = new System.Drawing.Point(22, 81);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(100, 30);
            this.Btn_Editar.TabIndex = 4;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(22, 26);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(100, 30);
            this.Btn_Guardar.TabIndex = 3;
            this.Btn_Guardar.Text = "Nuevo";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(22, 246);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(100, 30);
            this.Btn_Salir.TabIndex = 2;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(22, 191);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(100, 30);
            this.Btn_Nuevo.TabIndex = 0;
            this.Btn_Nuevo.Text = "Limpiar";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChkList_Especialidades);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Time_Salida);
            this.groupBox2.Controls.Add(this.Time_Entrada);
            this.groupBox2.Controls.Add(this.Txt_Hospital);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 290);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Hospital";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ChkList_Especialidades
            // 
            this.ChkList_Especialidades.AllowDrop = true;
            this.ChkList_Especialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkList_Especialidades.CausesValidation = false;
            this.ChkList_Especialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ChkList_Especialidades.FormattingEnabled = true;
            this.ChkList_Especialidades.Items.AddRange(new object[] {
            "Cardiología",
            "Cirugía General",
            "Dermatología",
            "Gastroenterología",
            "Ginecología",
            "Hematología",
            "Oftalmología",
            "Ortopedia",
            "Otorrinolaringología",
            "Pediatría",
            "Psiquiatría",
            "Urología"});
            this.ChkList_Especialidades.Location = new System.Drawing.Point(160, 99);
            this.ChkList_Especialidades.Margin = new System.Windows.Forms.Padding(15);
            this.ChkList_Especialidades.Name = "ChkList_Especialidades";
            this.ChkList_Especialidades.ScrollAlwaysVisible = true;
            this.ChkList_Especialidades.Size = new System.Drawing.Size(156, 180);
            this.ChkList_Especialidades.TabIndex = 21;
            this.ChkList_Especialidades.SelectedIndexChanged += new System.EventHandler(this.ChkList_Especialidades_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(290, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(158, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "De";
            // 
            // Time_Salida
            // 
            this.Time_Salida.CustomFormat = "hh:mm  tt";
            this.Time_Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Time_Salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time_Salida.Location = new System.Drawing.Point(339, 63);
            this.Time_Salida.Name = "Time_Salida";
            this.Time_Salida.Size = new System.Drawing.Size(96, 20);
            this.Time_Salida.TabIndex = 5;
            this.Time_Salida.Value = new System.DateTime(2024, 4, 4, 22, 0, 0, 0);
            // 
            // Time_Entrada
            // 
            this.Time_Entrada.CustomFormat = "hh:mm  tt";
            this.Time_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Time_Entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time_Entrada.Location = new System.Drawing.Point(190, 63);
            this.Time_Entrada.Name = "Time_Entrada";
            this.Time_Entrada.Size = new System.Drawing.Size(94, 20);
            this.Time_Entrada.TabIndex = 4;
            this.Time_Entrada.Value = new System.DateTime(2024, 4, 4, 7, 0, 0, 0);
            // 
            // Txt_Hospital
            // 
            this.Txt_Hospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Hospital.Location = new System.Drawing.Point(160, 31);
            this.Txt_Hospital.Name = "Txt_Hospital";
            this.Txt_Hospital.Size = new System.Drawing.Size(430, 20);
            this.Txt_Hospital.TabIndex = 3;
            this.Txt_Hospital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Hospital_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especialidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horario de Atención";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 200);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Txt_Busqueda);
            this.groupBox8.Controls.Add(this.Btn_Buscar);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox8.Location = new System.Drawing.Point(12, 309);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(760, 68);
            this.groupBox8.TabIndex = 38;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Busqueda";
            // 
            // Txt_Busqueda
            // 
            this.Txt_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Txt_Busqueda.Location = new System.Drawing.Point(7, 33);
            this.Txt_Busqueda.Name = "Txt_Busqueda";
            this.Txt_Busqueda.Size = new System.Drawing.Size(594, 20);
            this.Txt_Busqueda.TabIndex = 36;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Buscar.Location = new System.Drawing.Point(635, 26);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(100, 31);
            this.Btn_Buscar.TabIndex = 35;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Frm_NuevoHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_NuevoHospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo - Hospital";
            this.Load += new System.EventHandler(this.Frm_NuevoHospital_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.TextBox Txt_Hospital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Time_Salida;
        private System.Windows.Forms.DateTimePicker Time_Entrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.CheckedListBox ChkList_Especialidades;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox Txt_Busqueda;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}