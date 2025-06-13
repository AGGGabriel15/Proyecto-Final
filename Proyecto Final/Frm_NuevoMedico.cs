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
    public partial class Frm_NuevoMedico : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = SERVIDOR\\SQLDATABASE; initial catalog = SISTEMA_MEDICO; integrated security = true");
        int[] IDEspec; // Declaración de un array de enteros

        public Frm_NuevoMedico()
        {
            InitializeComponent();
        }

        private void CargarDatosMedicos()
        {
            try
            {
                if (conexion.State != ConnectionState.Open) conexion.Open();

                SqlCommand cmd = new SqlCommand("SELECT m.ID AS 'MedicoID', m.First_name AS 'Nombre', m.Last_name AS 'Apellido', m.Cedula, h.Name as Hospital, m.StarTime AS 'Hora Inicio', m.FinishTime AS 'Hora Cierre', m.HospitalID FROM Medicos m JOIN Hospitales h ON m.HospitalID = h.ID WHERE m.Estado = 1", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                // Oculta la columna 'MedicoID' y 'HospitalID' en el DataGridView
                if (dataGridView1.Columns.Contains("MedicoID"))
                    dataGridView1.Columns["MedicoID"].Visible = false;

                if (dataGridView1.Columns.Contains("HospitalID"))
                    dataGridView1.Columns["HospitalID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los médicos (Cargar Datos Medicos): " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        private void CargarHospitales()
        {
            try
            {
                if (conexion.State != ConnectionState.Open) conexion.Open();

                SqlCommand cmd = new SqlCommand("SELECT ID, Name FROM HOSPITALES WHERE Estado = 1", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ComBox_Laboral.DataSource = dt;
                ComBox_Laboral.DisplayMember = "Name";
                ComBox_Laboral.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar Hospitales: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_NuevoMedico_Load(object sender, EventArgs e)
        {
            CargarHospitales();
            CargarDatosMedicos();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Txt_Nombre.ReadOnly = false;
            Txt_Apellido.ReadOnly = false;
            Txt_Cedula.ReadOnly = false;
            ComBox_Laboral.Enabled = true;
            Txt_Nombre.Focus();

            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_Cedula.Text = "";
            ComBox_Laboral.Text = "";
            ComBox_Laboral.SelectedIndex = -1;

            Time_Entrada.Enabled = true;
            Time_Salida.Enabled = true;
            Time_Entrada.Value = new DateTime(2024, 04, 04, 07, 00, 0);
            Time_Salida.Value = new DateTime(2024, 04, 04, 22, 00, 0);

            ChkList_Especialidades.Enabled = true;

            conexion.Open();

            int NroID = 0;
            SqlCommand com = new SqlCommand("select max(ID) from Especialidades", conexion);
            SqlDataReader nro = com.ExecuteReader();
            if (nro.Read())
            {
                NroID = nro.GetInt32(0);
            }
            IDEspec = new int[NroID];

            conexion.Close();

            LlenarEspecialidad();

            Btn_Nuevo.Enabled = true; //Limpiar
            Btn_Editar.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Btn_Guardar.Enabled = true; //Nuevo
            Btn_Salir.Enabled = true;
        }

        private void LlenarEspecialidad()
        {
            ChkList_Especialidades.Items.Clear();

            string queryString = "SELECT ID, NameEspecialidad FROM Especialidades Order by ID";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, conexion);

            DataSet dsEspecialidades = new DataSet();
            adapter.Fill(dsEspecialidades, "NameEspecialidad");

            string datoEspecialidad;
            int i = 0;

            foreach (DataRow drE in dsEspecialidades.Tables[0].Rows)
            {
                datoEspecialidad = drE["NameEspecialidad"].ToString();
                ChkList_Especialidades.Items.Add(datoEspecialidad);
                IDEspec[i] = Convert.ToInt32(drE["ID"]);
                i++;
            }
        }

        private void EspecialidadSeleccionada(int IDMedico)
        {
            for (int i = 0; i < ChkList_Especialidades.Items.Count; i++)
            {
                ChkList_Especialidades.SetItemChecked(i, false);
            }

            string queryString = "SELECT EspecialidadID FROM MedicoEspecialidades Where MedicoID = " + IDMedico;
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, conexion);

            DataSet medicoespecialidades = new DataSet();
            adapter.Fill(medicoespecialidades, "MedicoEspecialidades");

            

            DataTable dtMedicoEspecialidades = medicoespecialidades.Tables["MedicoEspecialidades"];

            int IDEspecialidad;

            for (int i = 0; i < dtMedicoEspecialidades.Rows.Count; i++)
            {
                IDEspecialidad = Convert.ToInt32(dtMedicoEspecialidades.Rows[i][0]);
                ChkList_Especialidades.SetItemChecked(IDEspecialidad - 1 , true);
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e) //Boton Limpiar
        {
            Frm_NuevoMedico_Load(sender, e);
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Nombre.Text) || string.IsNullOrEmpty(Txt_Apellido.Text) || string.IsNullOrEmpty(Txt_Cedula.Text) || ComBox_Laboral.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, asegúrese de que todos los campos están llenos.");
                return;
            }

            // Obtener el ID del médico seleccionado
            int medicoId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MedicoID"].Value);

            try
            {
                if (conexion.State != ConnectionState.Open) conexion.Open();

                // Query para actualizar los datos del médico
                string query = @"UPDATE Medicos
                SET First_name = @Nombre, Last_name = @Apellido, Cedula = @Cedula, HospitalID = @HospitalID, StarTime = @HoraInicio, FinishTime = @HoraFin
                WHERE ID = @MedicoID";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Nombre", Txt_Nombre.Text);
                comando.Parameters.AddWithValue("@Apellido", Txt_Apellido.Text);
                comando.Parameters.AddWithValue("@Cedula", Txt_Cedula.Text);
                comando.Parameters.AddWithValue("@HospitalID", Convert.ToInt32(ComBox_Laboral.SelectedValue));
                comando.Parameters.AddWithValue("@HoraInicio", Time_Entrada.Value.TimeOfDay);
                comando.Parameters.AddWithValue("@HoraFin", Time_Salida.Value.TimeOfDay);
                comando.Parameters.AddWithValue("@MedicoID", medicoId);
                comando.ExecuteNonQuery();

                // Query para Insertar datos de Especialidades Medico
                comando = new SqlCommand("Delete MedicoEspecialidades Where MedicoID = " + medicoId, conexion);
                comando.ExecuteNonQuery();

                SqlCommand cmd;

                for (int i = 0; i <= (ChkList_Especialidades.Items.Count - 1); i++)
                {
                    if (ChkList_Especialidades.GetItemChecked(i))
                    {
                        query = "INSERT INTO MEDICOESPECIALIDADES (MedicoID, EspecialidadID) VALUES (@MedicoID, @EspecialidadID)";
                        cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@MedicoID", medicoId);
                        cmd.Parameters.AddWithValue("@EspecialidadID", IDEspec[i]);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Se actualizó el Médico correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos del médico: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

                // Recargar los datos actualizados en el DataGridView
                CargarDatosMedicos();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) {
                MessageBox.Show("Por favor, seleccione un médico para eliminar.", "Médico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este Médico del sistema?", "Eliminar Médico", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (conexion.State != ConnectionState.Open)
                        conexion.Open();

                    int medicoId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MedicoID"].Value);

                    SqlCommand cmd = new SqlCommand("UPDATE Medicos SET Estado = 0 WHERE ID = @ID", conexion);
                    cmd.Parameters.AddWithValue("@ID", medicoId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Se ha eliminado el Médico de manera correcta", "Sistema");
                    Frm_NuevoMedico_Load(sender, e); // Refrescar los datos mostrados
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el hospital: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }

                Frm_NuevoMedico_Load(sender, e);
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e) //Boton nuevo Médico
        {
            if (string.IsNullOrEmpty(Txt_Nombre.Text) || string.IsNullOrEmpty(Txt_Apellido.Text) || string.IsNullOrEmpty(Txt_Cedula.Text) || ChkList_Especialidades.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, rellene todos los campos.");
                return;
            }

            SqlTransaction transaction = null;
            try
            {
                conexion.Open();

                transaction = conexion.BeginTransaction();

                SqlCommand cmdMedico = new SqlCommand("INSERT INTO Medicos (First_name, Last_name, Cedula, HospitalID, StarTime, FinishTime, Estado) VALUES (@Nombre, @Apellido, @Cedula, @HospitalID, @HoraInicio, @HoraFin, 1); SELECT SCOPE_IDENTITY();", conexion, transaction);
                cmdMedico.Parameters.AddWithValue("@Nombre", Txt_Nombre.Text);
                cmdMedico.Parameters.AddWithValue("@Apellido", Txt_Apellido.Text);
                cmdMedico.Parameters.AddWithValue("@Cedula", Txt_Cedula.Text);
                cmdMedico.Parameters.AddWithValue("@HospitalID", Convert.ToInt32(ComBox_Laboral.SelectedValue));
                cmdMedico.Parameters.AddWithValue("@HoraInicio", Time_Entrada.Value.TimeOfDay);
                cmdMedico.Parameters.AddWithValue("@HoraFin", Time_Salida.Value.TimeOfDay);
                int medicoId = Convert.ToInt32(cmdMedico.ExecuteScalar());

                SqlCommand cmd;

                for (int i = 0; i <= (ChkList_Especialidades.Items.Count - 1); i++)
                {
                    if (ChkList_Especialidades.GetItemChecked(i))
                    {
                        cmd = new SqlCommand("INSERT INTO MEDICOESPECIALIDADES (MedicoID, EspecialidadID) VALUES (@MedicoID, @EspecialidadID)", conexion, transaction);
                        cmd.Parameters.AddWithValue("@MedicoID", medicoId);
                        cmd.Parameters.AddWithValue("@EspecialidadID", IDEspec[i]);
                        cmd.ExecuteNonQuery();
                    }
                }

                transaction.Commit();

                MessageBox.Show("Médico guardado correctamente.");
                Frm_NuevoMedico_Load(sender, e); // Refrescar formulario o actualizar listado
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Error al guardar el médico: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ComBox_Laboral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                // Suponiendo que los campos y las columnas existen con estos nombres
                Txt_Nombre.Text = row.Cells["Nombre"].Value.ToString();
                Txt_Apellido.Text = row.Cells["Apellido"].Value.ToString();
                Txt_Cedula.Text = row.Cells["Cedula"].Value.ToString();
                ComBox_Laboral.SelectedValue = row.Cells["HospitalID"].Value; // Asegúrate de que HospitalID se carga en el DataGridView y es parte del DataSource de ComBox_Laboral

                // Convertir las horas de inicio y fin desde TimeOfDay a DateTime
                TimeSpan horaInicio = (TimeSpan)row.Cells["Hora Inicio"].Value;
                TimeSpan horaFin = (TimeSpan)row.Cells["Hora Cierre"].Value;
                Time_Entrada.Value = DateTime.Today.Add(horaInicio);
                Time_Salida.Value = DateTime.Today.Add(horaFin);

                // Carga las especialidades del médico
                int medicoId = Convert.ToInt32(row.Cells["MedicoID"].Value);


                EspecialidadSeleccionada(medicoId);
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Busqueda.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre o cedula del médico a buscar.", "Médico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string filtro = Txt_Busqueda.Text;

                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Medicos WHERE First_name LIKE @filtro OR Cedula LIKE @filtro", conexion);
                datos.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                DataSet ds = new DataSet();
                datos.Fill(ds, "Medicos");
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Médico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}