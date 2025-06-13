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

namespace Proyecto_Final
{
    public partial class Form_Especialidades : Form
    {
        Usuario sql = new Usuario();
        private SqlConnection conexion = new SqlConnection("Data Source = SERVIDOR\\SQLDATABASE; initial catalog = SISTEMA_MEDICO; integrated security = true");
        private DataSet ds;

        //Funcion para mostrar los datos en el DataGridView
        public DataTable mostrarDatos()
        {
            DataTable dt = new DataTable();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlCommand cmd = new SqlCommand("Select * from Especialidades", conexion);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                dt = ds.Tables["tabla"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
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

        private bool ExisteEspecialidad(string nombre, int? excluirId = null)
        {
            bool existe = false;

            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                string query = "SELECT COUNT(*) FROM Especialidades WHERE NameEspecialidad = @nombre";
                if (excluirId != null)
                {
                    query += " AND id != @id";
                }

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                if (excluirId != null)
                {
                    cmd.Parameters.AddWithValue("@id", excluirId);
                }

                int count = (int)cmd.ExecuteScalar();
                existe = count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar duplicados: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return existe;
        }

        public Form_Especialidades()
        {
            InitializeComponent();
            this.AcceptButton = Btn_Nuevo;
            Txt_Especialidad.Focus();
        }

        private void Form_Especialidades_Load(object sender, EventArgs e)
        {
            dataGridViewEspecialidad.AllowUserToAddRows = false;
            dataGridViewEspecialidad.DataSource = mostrarDatos();
            dataGridViewEspecialidad.Columns["id"].Visible = false;

            Txt_Especialidad.Text = "";

            Btn_Nuevo.Enabled = true;
            Btn_Editar.Enabled = true;
            Btn_Salir.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEspecialidad.CurrentRow != null)
            {
                DataGridViewRow fila = dataGridViewEspecialidad.CurrentRow;
                Txt_Especialidad.Text = Convert.ToString(fila.Cells[1].Value);
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            string nameEspecialidad = Txt_Especialidad.Text;
            if (string.IsNullOrEmpty(nameEspecialidad))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Especialidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ExisteEspecialidad(nameEspecialidad))
            {
                MessageBox.Show("Ya existe una especialidad con ese nombre.", "Especialidades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                string query = "INSERT INTO Especialidades (NameEspecialidad) " + "VALUES (@name)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@name", nameEspecialidad);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("La especialidad ha sido registrada correctamente.", "Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewEspecialidad.DataSource = sql.mostrarDatos();
                        Form_Especialidades_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar la especialidad.", "Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridViewEspecialidad.DataSource = sql.mostrarDatos();
                        Form_Especialidades_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la especialidad: " + ex.Message);
                dataGridViewEspecialidad.DataSource = sql.mostrarDatos();
                Form_Especialidades_Load(sender, e);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEspecialidad.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una especialidad de la tabla.");
                return;
            }

            string nameEspecialidad = Txt_Especialidad.Text;
            if (string.IsNullOrEmpty(nameEspecialidad))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Especialidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(dataGridViewEspecialidad.CurrentRow.Cells["id"].Value);

            if (ExisteEspecialidad(nameEspecialidad, id))
            {
                MessageBox.Show("Ya existe otra especialidad con ese nombre.", "Especialidades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Especialidades Set NameEspecialidad = @especialidad WHERE id = @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@especialidad", nameEspecialidad);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se actualizo la Especialidad correctamente", "Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            dataGridViewEspecialidad.DataSource = mostrarDatos();
        }
    }
}
