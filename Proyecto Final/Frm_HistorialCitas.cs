using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final
{
    public partial class Frm_HistorialCitas : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = SERVIDOR\\SQLDATABASE; initial catalog = SISTEMA_MEDICO; integrated security = true");
        DataSet dsCitas = new DataSet();
        int Lista = 0;
        int Posicion = 0;
        int progress;

        public Frm_HistorialCitas()
        {
            InitializeComponent();
            progress = 0;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_HistorialCitas_Load(object sender, EventArgs e)
        {
            Txt_Hospital.Clear();
            Txt_Especialidad.Clear();
            Txt_Medico.Clear();
            Txt_Paciente.Clear();
            Txt_Cedula.Clear();
            Time_Nacimiento.Value = DateTime.Now;
            Txt_Sexo.Clear();
            Txt_Correo.Clear();
            Txt_Sangre.Clear();
            Txt_Enfermedades.Clear();
            Txt_Motivo.Clear();
            Time_Fecha.Value = DateTime.Now;
            Time_Hora.Value = DateTime.Now;

            try
            {
                if (conexion.State != ConnectionState.Open) conexion.Open();

                string query = @"SELECT c.*, p.FirstName, p.LastName, p.Cedula, p.FechaNaci, p.Sexo, p.Correo, 
                        p.TipoSangre, p.Enfermedades 
                 FROM Citas c
                 JOIN Pacientes p ON c.PacienteID = p.ID
                 ORDER BY c.ID";


                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter daCitas = new SqlDataAdapter(cmd);
                daCitas.Fill(dsCitas, "citas");
 
                Lista = dsCitas.Tables[0].Rows.Count;
 
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la Agenda de Citas: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        public void Cargar()
        {
            if (Lista != 0)
            {
                IniciarProgreso();

                Txt_Hospital.Text = TraerHospital(Convert.ToInt32(dsCitas.Tables[0].Rows[Posicion]["HospitalID"]));
                Txt_Especialidad.Text = TraerEspecialidad(Convert.ToInt32(dsCitas.Tables[0].Rows[Posicion]["EspecialidadID"].ToString()));
                Txt_Medico.Text = TraerMedico(Convert.ToInt32(dsCitas.Tables[0].Rows[Posicion]["MedicoID"].ToString()));
                Txt_Motivo.Text = dsCitas.Tables[0].Rows[Posicion]["Motivo"].ToString();
                Time_Fecha.Value = Convert.ToDateTime(dsCitas.Tables[0].Rows[Posicion]["Fecha"].ToString());

                Txt_Paciente.Text = dsCitas.Tables[0].Rows[Posicion]["FirstName"].ToString() + " " + dsCitas.Tables[0].Rows[Posicion]["LastName"].ToString();
                Txt_Cedula.Text = dsCitas.Tables[0].Rows[Posicion]["Cedula"].ToString();
                Time_Nacimiento.Value = Convert.ToDateTime(dsCitas.Tables[0].Rows[Posicion]["FechaNaci"]);
                Txt_Sexo.Text = dsCitas.Tables[0].Rows[Posicion]["Sexo"].ToString();
                Txt_Correo.Text = dsCitas.Tables[0].Rows[Posicion]["Correo"].ToString();
                Txt_Sangre.Text = dsCitas.Tables[0].Rows[Posicion]["TipoSangre"].ToString();
                Txt_Enfermedades.Text = dsCitas.Tables[0].Rows[Posicion]["Enfermedades"].ToString();

                TimeSpan hora = (TimeSpan)dsCitas.Tables[0].Rows[Posicion]["Hour"];
                Time_Hora.Value = DateTime.Today.Add(hora);
            }
        }

        private string TraerHospital(int IDHospital)
        {
            string Hospital = "";

            try
            {
                if (conexion.State != ConnectionState.Open) conexion.Open();

                string query = "SELECT Name FROM Hospitales WHERE ID = " + IDHospital;

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter daCitas = new SqlDataAdapter(cmd);
                DataSet dsHosp = new DataSet();
                daCitas.Fill(dsHosp, "hospitales");

                Hospital = dsHosp.Tables[0].Rows[0]["Name"].ToString().Trim();
            }
            catch (Exception ex)
            {
                Hospital = "";
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }

            return Hospital;
        }

        private string TraerEspecialidad(int IDEspecialidad)
        {
            string Especialidad = "";

            try
            {
                if (conexion.State != ConnectionState.Open) conexion.Open();

                string query = "SELECT NameEspecialidad FROM Especialidades WHERE ID = " + IDEspecialidad;

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter daCitas = new SqlDataAdapter(cmd);
                DataSet dsEsp = new DataSet();
                daCitas.Fill(dsEsp, "especialidades");

                Especialidad = dsEsp.Tables[0].Rows[0]["NameEspecialidad"].ToString().Trim();
            }
            catch (Exception ex)
            {
                Especialidad = "";
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }

            return Especialidad;
        }

        private string TraerMedico(int IDMedico)
        {
            string Medico = "";

            try
            {
                if (conexion.State != ConnectionState.Open) conexion.Open();

                string query = "SELECT First_name, Last_name FROM Medicos WHERE ID = " + IDMedico;

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter daCitas = new SqlDataAdapter(cmd);
                DataSet dsMed = new DataSet();
                daCitas.Fill(dsMed, "medicos");

                Medico = string.Format("{0} {1}", dsMed.Tables[0].Rows[0]["First_name"], dsMed.Tables[0].Rows[0]["Last_name"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
                Medico = "";
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }

            return Medico;
        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            Posicion = Posicion + 1;

            if (Posicion < dsCitas.Tables[0].Rows.Count)
            {
                Cargar();
            }
            else
            {
                Posicion -= 1;
                MessageBox.Show("Llegó al Ultimo Registro","Agenda de Citas");
            }
        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            Posicion -= 1;

            if (Posicion > -1)
            {
                Cargar();
            }
            else
            {
                MessageBox.Show("Llegó al Primer Registro","Agenda de Citas");
                Posicion = 0;
            }
        }

        private void IniciarProgreso()
        {
            progressBar1.Visible = true;
            for (int i = 1; i <= 100; i++)
            {
                progress = i;
                progressBar1.Value = progress;
            }
         }
    }
}
