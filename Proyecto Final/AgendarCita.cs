using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;

namespace Proyecto_Final
{
    public partial class Frm_AgendarCita : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = SERVIDOR\\SQLDATABASE; initial catalog = SISTEMA_MEDICO; integrated security = true");
        private bool hospitalSeleccionado = false;
        private bool especialidadSeleccionada = false;
        private Timer timer;
        private int progressValue;
        private string horaSeleccionadaTexto = "";

        DateTime fechaActual = DateTime.Now;

        public Frm_AgendarCita()
        {
            InitializeComponent();
            CargarHospitales();
        }

        private void Frm_AgendarCita_Load(object sender, EventArgs e)
        {
            //Datos del Hospital
            ComBox_Hospital.Enabled = false;
            ComBox_Hospital.Focus();
            ComBox_Especialidad.Enabled = false;
            ComBox_Medico.Enabled = false;

            ComBox_Hospital.Text = "";
            ComBox_Especialidad.Text = "";
            ComBox_Medico.Text = "";
            ComBox_Hospital.SelectedIndex = -1;
            ComBox_Especialidad.SelectedIndex = -1;
            ComBox_Medico.SelectedIndex = -1;

            //Datos Personales del Paciente
            Txt_Nombre.ReadOnly = true;
            Txt_Cedula.ReadOnly = true;
            Txt_Sexo.ReadOnly = true;
            Time_Nacimiento.Enabled = false;
            Txt_Correo.ReadOnly = true;

            Txt_Nombre.Text = "";
            Txt_Cedula.Text = "";
            Txt_Sexo.Text = "";
            
            Time_Nacimiento.Value = fechaActual;
            Txt_Correo.Text = "";

            //Datos Médicos
            Txt_TipoSangre.ReadOnly = true;
            Txt_Enfermedades.Enabled = false;
            Txt_Motivo.Enabled = false;

            Txt_TipoSangre.Text = string.Empty;
            Txt_Enfermedades.Text = "";
            Txt_Motivo.Text = "";

            //Agendar Fecha
            Time_Entrada.Enabled = false;
            Time_Salida.Enabled = false;
            Time_Fecha.Enabled = false;
            Time_EntradaMedico.Enabled = false;
            Time_SalidaMedico.Enabled = false; 

            int hora7am = 07;
            int hora10pm = 22;
            int minutos = 0;
            int segundos = 0;

            DateTime Fecha7am = new DateTime(
                fechaActual.Year,
                fechaActual.Month,
                fechaActual.Day,
                hora7am,
                minutos,
                segundos
            );

            DateTime Fecha10pm = new DateTime(
                fechaActual.Year,
                fechaActual.Month,
                fechaActual.Day,
                hora10pm,
                minutos,
                segundos
            );

            Time_Entrada.Value = Fecha7am;
            Time_Salida.Value = Fecha10pm;
            Time_Fecha.Value = fechaActual;
            Time_EntradaMedico.Value = Fecha7am;
            Time_SalidaMedico.Value = Fecha10pm;

            //RadioButtons
            rb7am.Enabled = false;
            rb8am.Enabled = false;
            rb9am.Enabled = false;
            rb10am.Enabled = false;
            rb11am.Enabled = false;
            rb12pm.Enabled = false;
            rb1pm.Enabled = false;
            rb2pm.Enabled = false;
            rb3pm.Enabled = false;
            rb4pm.Enabled = false;
            rb5pm.Enabled = false;
            rb6pm.Enabled = false;

            rb7am.Checked = false;
            rb8am.Checked = false;
            rb9am.Checked = false;
            rb10am.Checked = false;
            rb11am.Checked = false;
            rb12pm.Checked = false;
            rb1pm.Checked = false;
            rb2pm.Checked = false;
            rb3pm.Checked = false;
            rb4pm.Checked = false;
            rb5pm.Checked = false;
            rb6pm.Checked = false;

            //Opciones
            Btn_Nuevo.Enabled = true;
            Btn_Registrar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Btn_Salir.Enabled = true;

            Btn_BuscarPaciente.Enabled = false;
            Btn_NuevoPaciente.Enabled = false;

            progressValue = 0;
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            //Datos del Hospital
            ComBox_Hospital.Enabled = true;

            ComBox_Hospital.Text = "";
            ComBox_Especialidad.Text = "";
            ComBox_Medico.Text = "";
            ComBox_Hospital.SelectedIndex = -1;
            ComBox_Especialidad.SelectedIndex = -1;
            ComBox_Medico.SelectedIndex = -1;

            //Datos Personales del Paciente
            Txt_Nombre.ReadOnly = true;
            Txt_Cedula.ReadOnly = false;
            Txt_Sexo.ReadOnly = true;
            Time_Nacimiento.Enabled = false;
            Txt_Correo.ReadOnly = true;

            Txt_Nombre.Text = "";
            Txt_Cedula.Text = "";
            Txt_Sexo.Text = "";
            Time_Nacimiento.Value = fechaActual;
            Txt_Correo.Text = "";

            //Datos Médicos
            Txt_TipoSangre.ReadOnly = true;
            Txt_Enfermedades.Enabled = false;
            Txt_Motivo.Enabled = true;

            Txt_TipoSangre.Text = string.Empty;
            Txt_Enfermedades.Text = "";
            Txt_Motivo.Text = "";

            //Agendar Fecha
            Time_Fecha.Enabled = true;

            int hora7am = 07;
            int hora10pm = 22;
            int minutos = 0;
            int segundos = 0;

            DateTime Fecha7am = new DateTime(
                fechaActual.Year,
                fechaActual.Month,
                fechaActual.Day,
                hora7am,
                minutos,
                segundos
            );

            DateTime Fecha10pm = new DateTime(
                fechaActual.Year,
                fechaActual.Month,
                fechaActual.Day,
                hora10pm,
                minutos,
                segundos
            );

            Time_Entrada.Value = Fecha7am;
            Time_Salida.Value = Fecha10pm;
            Time_Fecha.Value = fechaActual;
            Time_EntradaMedico.Value = Fecha7am;
            Time_SalidaMedico.Value = Fecha10pm;

            //RadioButtons
            rb7am.Enabled = true;
            rb8am.Enabled = true;
            rb9am.Enabled = true;
            rb10am.Enabled = true;
            rb11am.Enabled = true;
            rb12pm.Enabled = true;
            rb1pm.Enabled = true;
            rb2pm.Enabled = true;
            rb3pm.Enabled = true;
            rb4pm.Enabled = true;
            rb5pm.Enabled = true;
            rb6pm.Enabled = true;

            rb7am.Checked = false;
            rb8am.Checked = false;
            rb9am.Checked = false;
            rb10am.Checked = false;
            rb11am.Checked = false;
            rb12pm.Checked = false;
            rb1pm.Checked = false;
            rb2pm.Checked = false;
            rb3pm.Checked = false;
            rb4pm.Checked = false;
            rb5pm.Checked = false;
            rb6pm.Checked = false;

            //Opciones
            Btn_Nuevo.Enabled = false;
            Btn_Registrar.Enabled = true;
            Btn_Cancelar.Enabled = true;
            Btn_Salir.Enabled = false;

            Btn_BuscarPaciente.Enabled = true;
            Btn_NuevoPaciente.Enabled = true;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cancelo el proceso con exito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Frm_AgendarCita_Load(sender, e);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComBox_Hospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComBox_Hospital.SelectedValue != null)
            {
                int hospitalId;
                if (int.TryParse(ComBox_Hospital.SelectedValue.ToString(), out hospitalId))
                {
                    CargarEspecialidades(hospitalId);
                    hospitalSeleccionado = true;

                    if (conexion.State != ConnectionState.Open) conexion.Open();
                    string query = "SELECT StarTime, FinishTime FROM Hospitales where ID = " + hospitalId;
                    SqlCommand command = new SqlCommand(query, conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        DateTime horaInicio = Convert.ToDateTime(table.Rows[i]["StarTime"]);
                        DateTime horaFin = Convert.ToDateTime(table.Rows[i]["FinishTime"]);
                        Time_Entrada.Value = horaInicio;
                        Time_Salida.Value = horaFin;
                        ActualizarDisponibilidadHorarios();
                    }

                    conexion.Close();

                    HabilitarControles();

                }
            }
        }

        private void ComBox_Especialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComBox_Hospital.SelectedValue != null && ComBox_Especialidad.SelectedValue != null)
            {
                int hospitalId, especialidadId;
                if (int.TryParse(ComBox_Hospital.SelectedValue.ToString(), out hospitalId) &&
                    int.TryParse(ComBox_Especialidad.SelectedValue.ToString(), out especialidadId))
                {
                    CargarMedicos(hospitalId, especialidadId);
                    especialidadSeleccionada = true;
                    HabilitarControles();
                }
            }
        }

        private void HabilitarControles()
        {
            ComBox_Especialidad.Enabled = hospitalSeleccionado;
            ComBox_Medico.Enabled = hospitalSeleccionado && especialidadSeleccionada;
        }

        private void CargarHospitales()
        {
            if (conexion.State != ConnectionState.Open) conexion.Open();

            string query = "SELECT ID, Name FROM Hospitales";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            ComBox_Hospital.DataSource = table;
            ComBox_Hospital.DisplayMember = "Name";
            ComBox_Hospital.ValueMember = "ID";

            conexion.Close();
        }

        private void CargarEspecialidades(int hospitalId)
        {
            if (conexion.State != ConnectionState.Open) conexion.Open();

            string query = "select h.EspecialidadID, e.NameEspecialidad from HospitalEspecialidades as h inner join Especialidades as e on h.EspecialidadID = e.ID where h.HospitalID = @HospitalID";

            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@HospitalID", hospitalId);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            ComBox_Especialidad.DataSource = table;
            ComBox_Especialidad.DisplayMember = "NameEspecialidad";
            ComBox_Especialidad.ValueMember = "EspecialidadID";

            conexion.Close();
        }

        private void CargarMedicos(int hospitalId, int especialidadId)
        {
            if (conexion.State != ConnectionState.Open) conexion.Open();

            string query = "SELECT m.ID, m.First_name FROM Medicos m " +
                           "INNER JOIN MEDICOESPECIALIDADES em ON m.ID = em.MedicoID " +
                           "WHERE m.HospitalID = @HospitalId AND em.EspecialidadId = @EspecialidadId";

            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@HospitalID", hospitalId);
            command.Parameters.AddWithValue("@EspecialidadId", especialidadId);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            ComBox_Medico.DataSource = table;
            ComBox_Medico.DisplayMember = "First_name";
            ComBox_Medico.ValueMember = "ID";

            conexion.Close();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            if (ComBox_Hospital.SelectedIndex == -1 || ComBox_Especialidad.SelectedIndex == -1 ||
                ComBox_Medico.SelectedIndex == -1 || string.IsNullOrEmpty(Txt_Nombre.Text) ||
                string.IsNullOrEmpty(Txt_Cedula.Text) || string.IsNullOrEmpty(Txt_Sexo.Text) ||
                string.IsNullOrEmpty(Txt_Correo.Text) || string.IsNullOrEmpty(Txt_TipoSangre.Text) ||
                string.IsNullOrEmpty(Txt_Enfermedades.Text) || string.IsNullOrEmpty(Txt_Motivo.Text) )
            {
                MessageBox.Show("Ingrese todos los datos que se solicitan", "Rellene los campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeSpan horaSeleccionada = TimeSpan.Zero;
            foreach (Control control in groupBox5.Controls) // Asume que los RadioButtons están en un GroupBox
            {
                if (control is RadioButton radio && radio.Checked)
                {
                    string texto = radio.Text.Replace("am", "").Replace("pm", "").Trim();
                    if (int.TryParse(texto.Split(':')[0], out int hora))
                    {
                        if (radio.Text.Contains("pm") && hora != 12) hora += 12;
                        horaSeleccionada = new TimeSpan(hora, 0, 0);
                        horaSeleccionadaTexto = radio.Text;
                        break;
                    }
                }
            }

            if (horaSeleccionada == TimeSpan.Zero)
            {
                MessageBox.Show("Seleccione una hora disponible para la cita", "Hora no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conexion.Open();

                SqlCommand verificarPaciente = new SqlCommand("SELECT ID FROM Pacientes WHERE Cedula = @Cedula", conexion);
                verificarPaciente.Parameters.AddWithValue("@Cedula", Txt_Cedula.Text);
                object pacienteExistente = verificarPaciente.ExecuteScalar();

                int pacienteID;

                if (pacienteExistente != null)
                {
                    // El paciente ya existe, usar su ID
                    pacienteID = Convert.ToInt32(pacienteExistente);
                }
                else
                {
                    pacienteID = Convert.ToInt32(pacienteExistente);
                }

                SqlCommand cmdCita = new SqlCommand("INSERT INTO Citas (PacienteID, HospitalID, EspecialidadID, MedicoID, Fecha, Hour, Motivo, StatusCita)" +
                                                    "VALUES (@PacienteID, @HospitalID, @EspecialidadID, @MedicoID, @Fecha, @Hora, @Motivo, @StatusCita);", conexion);
                
                cmdCita.Parameters.AddWithValue("@PacienteID", pacienteID);
                cmdCita.Parameters.AddWithValue("@HospitalID", Convert.ToInt32(ComBox_Hospital.SelectedValue));
                cmdCita.Parameters.AddWithValue("@EspecialidadID", Convert.ToInt32(ComBox_Especialidad.SelectedValue));
                cmdCita.Parameters.AddWithValue("@MedicoID", Convert.ToInt32(ComBox_Medico.SelectedValue));
                cmdCita.Parameters.AddWithValue("@Fecha", Time_Fecha.Value.Date);
                cmdCita.Parameters.AddWithValue("@Hora", horaSeleccionada);
                cmdCita.Parameters.AddWithValue("@Correo", Txt_Correo.Text);
                cmdCita.Parameters.AddWithValue("@Enfermedades", Txt_Enfermedades.Text);
                cmdCita.Parameters.AddWithValue("@Motivo", Txt_Motivo.Text);
                cmdCita.Parameters.AddWithValue("@StatusCita", "Pendiente");
                cmdCita.ExecuteNonQuery();

                progressBar1.Maximum = 100;
                progressValue = 0;
                progressBar1.Value = progressValue;
                timer1.Start();

                MessageBox.Show("Se agendo la cita de manera correcta", "Agendar Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EnviarCorreo(Txt_Correo.Text);

                Frm_AgendarCita_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agendar cita médica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }

            
        }

        private void EnviarCorreo(string correo)
        {
            string Notificacion = "";

            Notificacion += "--------------- Registro de Cita Médica ---------------" + Environment.NewLine;
            Notificacion += "Hospital: " + ComBox_Hospital.Text + Environment.NewLine;
            Notificacion += "Especialidad: " + ComBox_Especialidad.Text + Environment.NewLine;
            Notificacion += "Médico: " + ComBox_Medico.Text + Environment.NewLine;
            Notificacion += "Nombre: " + Txt_Nombre.Text + Environment.NewLine;
            Notificacion += "Cedula: " + Txt_Cedula.Text + Environment.NewLine;
            Notificacion += "Fecha de Nacimiento: " + Time_Nacimiento.Value.ToShortDateString() + Environment.NewLine;
            Notificacion += "Sexo: " + Txt_Sexo.Text + Environment.NewLine;
            Notificacion += "Correo: " + Txt_Correo.Text + Environment.NewLine;
            Notificacion += "Tipo de sangre: " + Txt_TipoSangre.Text + Environment.NewLine;
            Notificacion += "Enfermedades: " + Txt_Enfermedades.Text + Environment.NewLine;
            Notificacion += "Motivo de la cita: " + Txt_Motivo.Text + Environment.NewLine;
            Notificacion += "Fecha de la cita: " + Time_Fecha.Value.ToShortDateString() + Environment.NewLine;
            Notificacion += "Hora de la cita: " + horaSeleccionadaTexto + Environment.NewLine;

            MailMessage msg = new MailMessage();

            msg.To.Add(new MailAddress(correo));

            msg.From = new MailAddress("aggranadosgarcia@gmail.com");

            msg.Subject = "Cita Médica";

            msg.Body = Notificacion;

            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587);
            clienteSmtp.Host = "smtp.gmail.com";
            clienteSmtp.Port = 587;

            clienteSmtp.EnableSsl = true;
            clienteSmtp.UseDefaultCredentials = false;
            clienteSmtp.Credentials = new NetworkCredential("aggranadosgarcia@gmail.com", "dmvqcdhfjrniwity");

            try
            {
                clienteSmtp.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }

        private void ComBox_Medico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComBox_Hospital.SelectedValue != null && ComBox_Especialidad.SelectedValue != null && ComBox_Medico.SelectedValue != null)
            {
                int hospitalId, especialidadId, medicoId;
                if (int.TryParse(ComBox_Hospital.SelectedValue.ToString(), out hospitalId) &&
                    int.TryParse(ComBox_Especialidad.SelectedValue.ToString(), out especialidadId) &&
                    int.TryParse(ComBox_Medico.SelectedValue.ToString(), out medicoId))
                {
                    if (conexion.State != ConnectionState.Open) conexion.Open();

                    string query = "SELECT StarTime, FinishTime FROM Medicos where ID = " + medicoId;
                    SqlCommand command = new SqlCommand(query, conexion);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        TimeSpan horaInicio = (TimeSpan)table.Rows[i]["StarTime"];
                        TimeSpan horaFin = (TimeSpan)table.Rows[i]["FinishTime"];
                        Time_EntradaMedico.Value = DateTime.Today.Add(horaInicio);
                        Time_SalidaMedico.Value = DateTime.Today.Add(horaFin);
                        ActualizarDisponibilidadHorarios();
                    }

                    conexion.Close();

                    HabilitarControles();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressValue += 5;
            progressBar1.Value = progressValue;
            if (progressValue >= progressBar1.Maximum)
            {
                timer1.Stop();
            }
        }

        private void ComBox_Hospital_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ComBox_Especialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ComBox_Medico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ComBox_Sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Txt_Enfermedades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Txt_Motivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Btn_NuevoPaciente_Click(object sender, EventArgs e)
        {
            Frm_NuevoPaciente paciente = new Frm_NuevoPaciente();
            paciente.Show();
        }

        private void Btn_BuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Cedula.Text))
                {
                    MessageBox.Show("Por favor, ingrese la cedula del paciente a buscar.", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string filtro = Txt_Cedula.Text;

                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Pacientes WHERE Cedula LIKE @filtro", conexion);
                datos.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                DataTable dt = new DataTable();
                datos.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún paciente con esa cédula.", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow row = dt.Rows[0];

                Txt_Nombre.Text = $"{row["FirstName"]} {row["LastName"]}".Trim();
                Time_Nacimiento.Value = Convert.ToDateTime(row["FechaNaci"]);
                Txt_Sexo.Text = row["Sexo"].ToString();
                Txt_Correo.Text = row["Correo"].ToString();
                Txt_TipoSangre.Text = row["TipoSangre"].ToString();
                Txt_Enfermedades.Text = row["Enfermedades"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
            }
        }

        private void ActualizarDisponibilidadHorarios()
        {
            // Obtener horas de atención del hospital y médico
            TimeSpan horaInicioHospital = Time_Entrada.Value.TimeOfDay;
            TimeSpan horaFinHospital = Time_Salida.Value.TimeOfDay;

            TimeSpan horaInicioMedico = Time_EntradaMedico.Value.TimeOfDay;
            TimeSpan horaFinMedico = Time_SalidaMedico.Value.TimeOfDay;

            // Rango común
            TimeSpan horaInicio = (horaInicioHospital > horaInicioMedico) ? horaInicioHospital : horaInicioMedico;
            TimeSpan horaFin = (horaFinHospital < horaFinMedico) ? horaFinHospital : horaFinMedico;

            // Verifica que el médico esté seleccionado
            if (ComBox_Medico.SelectedValue == null || !int.TryParse(ComBox_Medico.SelectedValue.ToString(), out int medicoId)) return;

            // Obtener fecha seleccionada
            DateTime fechaSeleccionada = Time_Fecha.Value.Date;

            // Horas ya ocupadas en citas
            List<TimeSpan> horasOcupadas = ObtenerHorasCitasOcupadas(medicoId, fechaSeleccionada);

            // Lista de radios con su hora correspondiente
            Dictionary<RadioButton, TimeSpan> radios = new Dictionary<RadioButton, TimeSpan>()
            {
                { rb7am, new TimeSpan(7, 0, 0) },
                { rb8am, new TimeSpan(8, 0, 0) },
                { rb9am, new TimeSpan(9, 0, 0) },
                { rb10am, new TimeSpan(10, 0, 0) },
                { rb11am, new TimeSpan(11, 0, 0) },
                { rb12pm, new TimeSpan(12, 0, 0) },
                { rb1pm, new TimeSpan(13, 0, 0) },
                { rb2pm, new TimeSpan(14, 0, 0) },
                { rb3pm, new TimeSpan(15, 0, 0) },
                { rb4pm, new TimeSpan(16, 0, 0) },
                { rb5pm, new TimeSpan(17, 0, 0) },
                { rb6pm, new TimeSpan(18, 0, 0) },
            };

            // Activar o desactivar según horario y ocupación
            foreach (var par in radios)
            {
                bool dentroHorario = par.Value >= horaInicio && par.Value < horaFin;
                bool ocupado = horasOcupadas.Contains(par.Value);

                if (dentroHorario && !ocupado)
                {
                    par.Key.Enabled = true;
                }
                else
                {
                    par.Key.Enabled = false;
                    par.Key.Checked = false;
                }
            }
        }

        private List<TimeSpan> ObtenerHorasCitasOcupadas(int medicoId, DateTime fechaSeleccionada)
        {
            List<TimeSpan> horasOcupadas = new List<TimeSpan>();

            if (conexion.State != ConnectionState.Open) conexion.Open();

            string query = "SELECT Hour FROM Citas WHERE MedicoID = @medicoId AND Fecha = @fecha";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@medicoId", medicoId);
            cmd.Parameters.AddWithValue("@fecha", fechaSeleccionada.Date);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                TimeSpan hora = (TimeSpan)reader["Hour"];
                horasOcupadas.Add(hora);
            }

            reader.Close();
            conexion.Close();

            return horasOcupadas;
        }

        private void Time_Fecha_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDisponibilidadHorarios();
        }
    }
}
