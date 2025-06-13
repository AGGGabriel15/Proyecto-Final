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
using System.Reflection;

namespace Proyecto_Final
{
    public partial class Frm_NuevoHospital : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = SERVIDOR\\SQLDATABASE; initial catalog = SISTEMA_MEDICO; integrated security = true");
        private DataSet ds;
        int[] IDEspec; // Declaración de un array de enteros

        public Frm_NuevoHospital()
        {
            InitializeComponent();
        }

        public DataTable MostrarHospitales()
        {
            DataTable dt = new DataTable();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Solo hospitales activos
                string query = @"
            SELECT 
                h.ID AS HospitalID,
                h.Name AS 'Nombre Hospital',
                h.StarTime AS 'Hora Apertura',
                h.FinishTime AS 'Hora Cierre'
            FROM Hospitales h
            WHERE h.Estado = 1";  // Solo activos

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                dt = ds.Tables["tabla"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los hospitales: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return dt;
        }


        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_NuevoHospital_Load(object sender, EventArgs e)
        {
            CargarDatosHospitales();

            this.AcceptButton = Btn_Guardar;

            Txt_Hospital.ReadOnly = false;
            Txt_Hospital.Focus();
            Txt_Hospital.Text = "";

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
            Btn_Guardar.Enabled = true; //Nuevo Hospital
            Btn_Salir.Enabled = true;
        }

        private void LlenarEspecialidad()
        {
            ChkList_Especialidades.Items.Clear();

            string queryString = "SELECT ID, NameEspecialidad FROM Especialidades Order by ID";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, conexion);

            DataSet dsEspecialidades = new DataSet();
            adapter.Fill(dsEspecialidades, "Especialidades");

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

        private void EspecialidadSeleccionada(int IDHospital)
        {
            for (int i = 0; i < ChkList_Especialidades.Items.Count; i++)
            {
                ChkList_Especialidades.SetItemChecked(i, false);
            }

            string queryString = "SELECT EspecialidadID FROM HospitalEspecialidades Where HospitalID = " + IDHospital;
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, conexion);

            DataSet hospitalespecialidades = new DataSet();
            adapter.Fill(hospitalespecialidades, "HospitalEspecialidades");

            

            DataTable dtHospitalEspecialidades = hospitalespecialidades.Tables["HospitalEspecialidades"];

            int IDEspecialidad;

            for (int i = 0; i < dtHospitalEspecialidades.Rows.Count; i++)
            {
                IDEspecialidad = Convert.ToInt32(dtHospitalEspecialidades.Rows[i][0]);
                ChkList_Especialidades.SetItemChecked(IDEspecialidad - 1, true);
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e) //Boton de Limpiar
        {
            Frm_NuevoHospital_Load(sender, e);
        }

        private void Txt_Hospital_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Hospital.Text) || dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un hospital y asegúrese de que todos los campos están llenos.");
                return;
            }

            if (string.IsNullOrEmpty(Txt_Hospital.Text) || ChkList_Especialidades.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, rellene todos los campos.");
                return;
            }

            // Obtener el ID del hospital seleccionado
            int hospitalId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HospitalID"].Value);

            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                // Query para actualizar los datos del hospital
                string query = @"
                UPDATE Hospitales
                SET Name = @Nombre, StarTime = @HoraApertura, FinishTime = @HoraCierre
                WHERE ID = @HospitalID";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Nombre", Txt_Hospital.Text);
                comando.Parameters.AddWithValue("@HoraApertura", Time_Entrada.Value.TimeOfDay);
                comando.Parameters.AddWithValue("@HoraCierre", Time_Salida.Value.TimeOfDay);
                comando.Parameters.AddWithValue("@HospitalID", hospitalId);
                comando.ExecuteNonQuery();

                comando = new SqlCommand("Delete HospitalEspecialidades Where HospitalID = " + hospitalId, conexion);
                comando.ExecuteNonQuery();

                SqlCommand cmd;

                for (int i = 0; i <= (ChkList_Especialidades.Items.Count - 1); i++)
                {
                    if (ChkList_Especialidades.GetItemChecked(i))
                    {
                        query = "INSERT INTO HospitalEspecialidades (HospitalID, EspecialidadID) VALUES (@HospitalID, @EspecialidadID)";
                        cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@HospitalID", hospitalId);
                        cmd.Parameters.AddWithValue("@EspecialidadID", IDEspec[i]);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Se actualizó el Hospital correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos del hospital: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

                // Recargar los datos actualizados en el DataGridView
                dataGridView1.DataSource = MostrarHospitales(); // Asegúrate de que este método refresque los datos adecuadamente
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Hospital.Text) || ChkList_Especialidades.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, rellene todos los campos.");
                return;
            }

            SqlTransaction transaction = null;
            try
            {
                conexion.Open();

                transaction = conexion.BeginTransaction();

                SqlCommand cmdHospital = new SqlCommand("INSERT INTO Hospitales (Name, StarTime, FinishTime, Estado) VALUES (@Nombre, @HoraApertura, @HoraCierre, 1); SELECT SCOPE_IDENTITY();", conexion, transaction);
                cmdHospital.Parameters.AddWithValue("@Nombre", Txt_Hospital.Text);
                cmdHospital.Parameters.AddWithValue("@HoraApertura", Time_Entrada.Value.TimeOfDay);
                cmdHospital.Parameters.AddWithValue("@HoraCierre", Time_Salida.Value.TimeOfDay);
                int hospitalId = Convert.ToInt32(cmdHospital.ExecuteScalar());

                SqlCommand cmd;

                for (int i = 0; i <= (ChkList_Especialidades.Items.Count - 1); i++)
                {
                    if (ChkList_Especialidades.GetItemChecked(i))
                    {
                        cmd = new SqlCommand("INSERT INTO HospitalEspecialidades (HospitalID, EspecialidadID) VALUES (@HospitalID, @EspecialidadID);", conexion, transaction);
                        cmd.Parameters.AddWithValue("@HospitalID", hospitalId);
                        cmd.Parameters.AddWithValue("@EspecialidadID", IDEspec[i]);
                        cmd.ExecuteNonQuery();
                    }
                }

                transaction.Commit();

                MessageBox.Show("Se ha guardado los datos de manera correcta", "Sistema");
                Frm_NuevoHospital_Load(sender, e);
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Error al guardar el hospital: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void CargarDatosHospitales()
        {
            DataTable dt = MostrarHospitales();
            dataGridView1.DataSource = dt;
        }    

        private void ChkList_Especialidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                // Suponiendo que los campos y las columnas existen con estos nombres
                Txt_Hospital.Text = row.Cells["Nombre Hospital"].Value.ToString();
                Time_Entrada.Value = Convert.ToDateTime(row.Cells["Hora Apertura"].Value.ToString());
                Time_Salida.Value = Convert.ToDateTime(row.Cells["Hora Cierre"].Value.ToString());

                // Carga las especialidades del hospital
                int hospitalId = Convert.ToInt32(row.Cells["HospitalID"].Value);

                EspecialidadSeleccionada(hospitalId);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Elimiar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un hospital de la tabla.", "Eliminar Hospital", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este Hospital del sistema?", "Eliminar Hospital", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (conexion.State != ConnectionState.Open)
                        conexion.Open();

                    int hospitalId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HospitalID"].Value);

                    SqlCommand cmd = new SqlCommand("UPDATE Hospitales SET Estado = 0 WHERE ID = @ID", conexion);
                    cmd.Parameters.AddWithValue("@ID", hospitalId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Se ha eliminado el Hospital de manera correcta", "Sistema");
                    Frm_NuevoHospital_Load(sender, e); // Refrescar los datos mostrados
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
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Busqueda.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre hospital a buscar.", "Hospital", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string filtro = Txt_Busqueda.Text;

                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Hospitales WHERE Name LIKE @filtro", conexion);
                datos.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                DataSet ds = new DataSet();
                datos.Fill(ds, "Hospitales");
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Hospital", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
