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
    public partial class Frm_NuevoPaciente : Form
    {
        Usuario sql = new Usuario();
        private SqlConnection conexion = new SqlConnection("Data Source = SERVIDOR\\SQLDATABASE; initial catalog = SISTEMA_MEDICO; integrated security = true");
        private DataSet ds;

        public DataTable mostrarDatos()
        {
            DataTable dt = new DataTable();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlCommand cmd = new SqlCommand("Select * from Pacientes WHERE Estado = 1", conexion);
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

        private bool validacionTxtBox()
        {
            string Nombre = Txt_Nombre.Text;
            string Apellido = Txt_Apellido.Text;
            string Cedula = Txt_Cedula.Text;
            string Email = Txt_Email.Text;
            string Enfermedades = Txt_Enfermedades.Text;

            if (ComBox_Sexo.SelectedIndex == -1 || ComBox_TipSangre.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }

            string Sexo = ComBox_Sexo.SelectedItem.ToString();
            string TipoSangre = ComBox_TipSangre.SelectedItem.ToString();

            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido) ||
                string.IsNullOrEmpty(Cedula) || string.IsNullOrEmpty(Email) ||
                string.IsNullOrEmpty(Enfermedades))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            return true;
        }

        public Frm_NuevoPaciente()
        {
            InitializeComponent();
        }

        private void Frm_NuevoPaciente_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = mostrarDatos();
            dataGridView1.Columns["ID"].Visible = false;

            Txt_Nombre.Text = string.Empty;
            Txt_Apellido.Text = string.Empty;
            Txt_Cedula.Text = string.Empty;
            Txt_Enfermedades.Text = string.Empty;
            Txt_Email.Text = string.Empty;

            ComBox_Sexo.Text = string.Empty;
            ComBox_Sexo.SelectedItem = null;
            ComBox_TipSangre.Text = string.Empty;
            ComBox_TipSangre.SelectedItem = null;

            Date_Nacimiento.Value = DateTime.Now;

            Txt_Busqueda.Text = string.Empty;

            Btn_Guardar.Enabled = true;
            Btn_Editar.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Btn_Guardar.Enabled = true;
            Btn_Buscar.Enabled = true;
            Btn_Cancelar.Enabled = true;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow fila = dataGridView1.CurrentRow;

                Txt_Nombre.Text = Convert.ToString(fila.Cells[1].Value);
                Txt_Apellido.Text = Convert.ToString(fila.Cells[2].Value);
                Txt_Cedula.Text = Convert.ToString(fila.Cells[3].Value);
                Txt_Email.Text = Convert.ToString(fila.Cells[4].Value);
                Date_Nacimiento.Value = Convert.ToDateTime(fila.Cells[5].Value);
                ComBox_Sexo.SelectedItem = Convert.ToString(fila.Cells[6].Value);
                ComBox_TipSangre.SelectedItem = Convert.ToString(fila.Cells[7].Value);
                Txt_Enfermedades.Text = Convert.ToString(fila.Cells[8].Value);
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!validacionTxtBox())
            {
                return;
            }

            string Nombre = Txt_Nombre.Text;
            string Apellido = Txt_Apellido.Text;
            string Cedula = Txt_Cedula.Text;
            string Email = Txt_Email.Text;
            string Enfermedades = Txt_Enfermedades.Text;

            string Sexo = ComBox_Sexo.SelectedItem.ToString();
            string TipoSangre = ComBox_TipSangre.SelectedItem.ToString();

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                string query = "INSERT INTO Pacientes (FirstName, LastName, Cedula, Correo, FechaNaci, Sexo, TipoSangre, Enfermedades, Estado) " +
                               "VALUES (@Nombre, @Apellido, @Cedula, @Correo, @Nacimiento, @Sexo, @Sangre, @Enfermedades, 1)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido", Apellido);
                    command.Parameters.AddWithValue("@Cedula", Cedula);
                    command.Parameters.AddWithValue("@Correo", Email);
                    command.Parameters.AddWithValue("@Nacimiento", Date_Nacimiento.Value);
                    command.Parameters.AddWithValue("@Sexo", Sexo);
                    command.Parameters.AddWithValue("@Sangre", TipoSangre);
                    command.Parameters.AddWithValue("@Enfermedades", Enfermedades);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Paciente registrado correctamente.", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = mostrarDatos();
                        Frm_NuevoPaciente_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el paciente.", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.DataSource = mostrarDatos();
                        Frm_NuevoPaciente_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.DataSource = mostrarDatos();
                Frm_NuevoPaciente_Load(sender, e);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
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

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Busqueda.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre del usuario a buscar.");
                    return;
                }

                string filtro = Txt_Busqueda.Text;

                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Pacientes WHERE FirstName LIKE @filtro", conexion);
                datos.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                DataSet ds = new DataSet();
                datos.Fill(ds, "Pacientes");
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message, "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (!validacionTxtBox()) {
                return;
            }

            string Nombre = Txt_Nombre.Text;
            string Apellido = Txt_Apellido.Text;
            string Cedula = Txt_Cedula.Text;
            string Email = Txt_Email.Text;
            string Enfermedades = Txt_Enfermedades.Text;
                        
            string Sexo = ComBox_Sexo.SelectedItem.ToString();
            string TipoSangre = ComBox_TipSangre.SelectedItem.ToString();

            int PacienteID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            string query = "UPDATE Pacientes Set FirstName = @Nombre, LastName = @Apellido, Cedula = @Cedula, Correo = @Correo, FechaNaci = @Nacimiento, Sexo = @Sexo, TipoSangre = @Sangre, Enfermedades = @Enfermedades where ID = @ID";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Cedula", Cedula);
            comando.Parameters.AddWithValue("@Correo", Email);
            comando.Parameters.AddWithValue("@Nacimiento", Date_Nacimiento.Value);
            comando.Parameters.AddWithValue("@Sexo", Sexo);
            comando.Parameters.AddWithValue("@Sangre", TipoSangre);
            comando.Parameters.AddWithValue("@Enfermedades", Enfermedades);
            comando.Parameters.AddWithValue("@ID", PacienteID);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se actualizo el Paciente correctamente", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = mostrarDatos();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un Paciente de la tabla.", "Eliminar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este Paciente del sistema?", "Eliminar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (conexion.State != ConnectionState.Open)
                        conexion.Open();

                    int pacienteID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    SqlCommand cmd = new SqlCommand("UPDATE Pacientes SET Estado = 0 WHERE ID = @ID", conexion);
                    cmd.Parameters.AddWithValue("@ID", pacienteID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Se ha eliminado el Paciente de manera correcta", "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_NuevoPaciente_Load(sender, e); // Refrescar los datos mostrados
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el Paciente: " + ex.Message, "Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Frm_NuevoPaciente_Load(sender, e);
        }
    }
}
