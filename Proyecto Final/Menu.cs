using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Sistema Medico", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Frm_Login login = new Frm_Login();
                this.Close();
                login.Show();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void hospitalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NuevoHospital hospital = new Frm_NuevoHospital();
            hospital.Show();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Especialidades especialidades = new Form_Especialidades();
            especialidades.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EditarUsuario usuario = new Frm_EditarUsuario();
            usuario.Show();
        }

        private void mpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NuevoMedico medico = new Frm_NuevoMedico();
            medico.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe();
            acerca.Show();
        }

        private void historialDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HistorialCitas historial = new Frm_HistorialCitas();
            historial.Show();
        }

        private void EspecialidadesMenuItem_Click(object sender, EventArgs e)
        {
            Form_Especialidades especialidades = new Form_Especialidades();
            especialidades.Show();
        }
    }
}
