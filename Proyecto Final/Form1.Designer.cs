namespace Proyecto_Final
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_InicioSesion = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.Txt_Usuario, "Txt_Usuario");
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.TextChanged += new System.EventHandler(this.Txt_Usuario_TextChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Password);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.Txt_Password, "Txt_Password");
            this.Txt_Password.Name = "Txt_Password";
            // 
            // Btn_InicioSesion
            // 
            resources.ApplyResources(this.Btn_InicioSesion, "Btn_InicioSesion");
            this.Btn_InicioSesion.Name = "Btn_InicioSesion";
            this.Btn_InicioSesion.UseVisualStyleBackColor = true;
            this.Btn_InicioSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Btn_Salir, "Btn_Salir");
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Image = global::Proyecto_Final.Properties.Resources.ojos_cruzados;
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Frm_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_InicioSesion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_InicioSesion;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

