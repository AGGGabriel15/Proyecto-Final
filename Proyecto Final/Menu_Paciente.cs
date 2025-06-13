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
    public partial class Frm_Menu_Paciente : Form
    {
        public Frm_Menu_Paciente()
        {
            InitializeComponent();
        }

        private void agendarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AgendarCita agendarCita = new Frm_AgendarCita();
            agendarCita.Show();
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

        private void historialDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HistorialCitas historial = new Frm_HistorialCitas();
            historial.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();
        }
    }
}
