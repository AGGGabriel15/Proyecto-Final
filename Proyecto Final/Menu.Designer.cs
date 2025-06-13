namespace Proyecto_Final
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historialDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EspecialidadesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeCitasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.EspecialidadesMenuItem,
            this.hospitalesToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historialDeCitasToolStripMenuItem
            // 
            this.historialDeCitasToolStripMenuItem.Image = global::Proyecto_Final.Properties.Resources.documento;
            this.historialDeCitasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.historialDeCitasToolStripMenuItem.Name = "historialDeCitasToolStripMenuItem";
            this.historialDeCitasToolStripMenuItem.Size = new System.Drawing.Size(138, 34);
            this.historialDeCitasToolStripMenuItem.Text = "&Historial de Citas";
            this.historialDeCitasToolStripMenuItem.Click += new System.EventHandler(this.historialDeCitasToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mpToolStripMenuItem,
            this.pacientesToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = global::Proyecto_Final.Properties.Resources.usuario1;
            this.usuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(97, 34);
            this.usuariosToolStripMenuItem.Text = "&Catálogo";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // mpToolStripMenuItem
            // 
            this.mpToolStripMenuItem.Image = global::Proyecto_Final.Properties.Resources.md_del_usuario;
            this.mpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mpToolStripMenuItem.Name = "mpToolStripMenuItem";
            this.mpToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.mpToolStripMenuItem.Text = "&Médicos";
            this.mpToolStripMenuItem.Click += new System.EventHandler(this.mpToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Image = global::Proyecto_Final.Properties.Resources.usuario1;
            this.pacientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.pacientesToolStripMenuItem.Text = "Usuarios";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // EspecialidadesMenuItem
            // 
            this.EspecialidadesMenuItem.Image = global::Proyecto_Final.Properties.Resources.especialidade;
            this.EspecialidadesMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EspecialidadesMenuItem.Name = "EspecialidadesMenuItem";
            this.EspecialidadesMenuItem.Size = new System.Drawing.Size(125, 34);
            this.EspecialidadesMenuItem.Text = "Especialidades";
            this.EspecialidadesMenuItem.Click += new System.EventHandler(this.EspecialidadesMenuItem_Click);
            // 
            // hospitalesToolStripMenuItem
            // 
            this.hospitalesToolStripMenuItem.Image = global::Proyecto_Final.Properties.Resources.hospital;
            this.hospitalesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hospitalesToolStripMenuItem.Name = "hospitalesToolStripMenuItem";
            this.hospitalesToolStripMenuItem.Size = new System.Drawing.Size(104, 34);
            this.hospitalesToolStripMenuItem.Text = "&Hospitales";
            this.hospitalesToolStripMenuItem.Click += new System.EventHandler(this.hospitalesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = global::Proyecto_Final.Properties.Resources.acercarse;
            this.acercaDeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(101, 34);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Proyecto_Final.Properties.Resources.salida;
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(71, 34);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources.Diseño_sin_título__12_;
            this.pictureBox1.Location = new System.Drawing.Point(245, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 311);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Sistema ";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EspecialidadesMenuItem;
    }
}