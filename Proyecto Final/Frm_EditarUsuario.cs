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
    public partial class Frm_EditarUsuario : Form
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

                SqlCommand cmd = new SqlCommand("Select * from USUARIOS", conexion);
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

        public Frm_EditarUsuario()
        {
            InitializeComponent();
        }

        private void Frm_EditarUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = mostrarDatos();
            dataGridView1.Columns["id"].Visible = false;

            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_Correo.Text = "";
            Txt_Usuario.Text = "";
            Txt_Password.Text = "";;
            Txt_Sexo.Text = "";
            Txt_Sexo.SelectedItem = -1;
            Check_Admin.Checked = false;

            Btn_Nuevo.Enabled = true;
            Btn_Editar.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Btn_Guardar.Enabled = true;
            Btn_Buscar.Enabled = true;
            Btn_Salir.Enabled = true;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            string nombre = Txt_Nombre.Text.Trim();
            string apellido = Txt_Apellido.Text.Trim();
            string correo = Txt_Correo.Text.Trim();
            string usuario = Txt_Usuario.Text.Trim();
            string contraseña = Txt_Password.Text.Trim();
            string sexo = Txt_Sexo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(sexo))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar formato de correo
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.(com|net|org|edu|gob|mx|es|co|us)$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(correo, patronCorreo))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Verificar si el usuario o correo ya están en otro registro
                string verificacionQuery = "SELECT COUNT(*) FROM Usuarios WHERE (Userd = @Usuario OR email = @Correo) AND Userd != @UsuarioOriginal";

                using (SqlCommand verificarCmd = new SqlCommand(verificacionQuery, conexion))
                {
                    verificarCmd.Parameters.AddWithValue("@Usuario", usuario);
                    verificarCmd.Parameters.AddWithValue("@Correo", correo);
                    verificarCmd.Parameters.AddWithValue("@UsuarioOriginal", dataGridView1.CurrentRow.Cells["Userd"].Value.ToString());

                    int existe = (int)verificarCmd.ExecuteScalar();

                    if (existe > 0)
                    {
                        MessageBox.Show("Ya existe otro usuario o correo con esos datos.");
                        return;
                    }
                }

                // Actualizar datos
                string query = "UPDATE Usuarios SET " +
                               "Userd = @usuario, Pass = @contraseña, email = @correo, " +
                               "First_name = @nombre, Last_name = @apellido, sexo = @sexo, issuperuser = @issuperuser " +
                               "WHERE Userd = @usuarioOriginal";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    comando.Parameters.AddWithValue("@correo", correo);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);
                    comando.Parameters.AddWithValue("@sexo", sexo);
                    comando.Parameters.AddWithValue("@issuperuser", Check_Admin.Checked);
                    comando.Parameters.AddWithValue("@usuarioOriginal", dataGridView1.CurrentRow.Cells["Userd"].Value.ToString());

                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Se actualizó el usuario correctamente.");
                dataGridView1.DataSource = sql.mostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {

            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_Correo.Text = "";
            Txt_Usuario.Text = "";
            Txt_Password.Text = "";
            Txt_Sexo.SelectedIndex = -1;
            Txt_Sexo.Text = "";
            Check_Admin.Checked = false;

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un Usuario de la tabla.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este Usuario del sistema?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (conexion.State != ConnectionState.Open)
                        conexion.Open();

                    int usuarioID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET Estado = 0 WHERE ID = @ID", conexion);
                    cmd.Parameters.AddWithValue("@ID", usuarioID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Se ha eliminado el Usuario de manera correcta", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_EditarUsuario_Load(sender, e); // Refrescar los datos mostrados
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el Usuario: " + ex.Message, "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                        conexion.Close();
                }
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string nombre = Txt_Nombre.Text;
            string apellido = Txt_Apellido.Text;
            string correo = Txt_Correo.Text;
            string usuario = Txt_Usuario.Text;
            string contraseña = Txt_Password.Text;

            if (Txt_Sexo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            string sexo = Txt_Sexo.SelectedItem.ToString();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(sexo))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            string patronCorreo = @"^[^@\s]+@[^@\s]+\.(com|net|org|edu|gob|mx|es|co|us)$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(correo, patronCorreo))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Usuario",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                string verificacionQuery = "SELECT COUNT(*) FROM Usuarios WHERE Userd = @Usuario OR email = @Correo";

                using (SqlCommand verificarCmd = new SqlCommand(verificacionQuery, conexion))
                {
                    verificarCmd.Parameters.AddWithValue("@Usuario", usuario);
                    verificarCmd.Parameters.AddWithValue("@Correo", correo);

                    int existe = (int)verificarCmd.ExecuteScalar();

                    if (existe > 0)
                    {
                        MessageBox.Show("El nombre de usuario o el correo ya están registrados.");
                        return;
                    }
                }

                string query = "INSERT INTO USUARIOS (Userd, Pass, First_name, Last_name, email, sexo, issuperuser, Estado) " +
                               "VALUES (@Usuario, @pass, @Nombre, @Apellido, @Correo, @Sexo, @issuperuser, 1)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@pass", contraseña);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Sexo", sexo);
                    command.Parameters.AddWithValue("@issuperuser", Check_Admin.Checked);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuario registrado correctamente.");
                        dataGridView1.DataSource = sql.mostrarDatos();
                        Frm_EditarUsuario_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el usuario.");
                        dataGridView1.DataSource = sql.mostrarDatos();
                        Frm_EditarUsuario_Load(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
                dataGridView1.DataSource = sql.mostrarDatos();
                Frm_EditarUsuario_Load(sender, e);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void Txt_Sexo_KeyPress(object sender, KeyPressEventArgs e)
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
                if(string.IsNullOrEmpty(Txt_Busqueda.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre del usuario a buscar.");
                    return;
                }

                string filtro = Txt_Busqueda.Text;

                SqlDataAdapter datos = new SqlDataAdapter("SELECT * FROM Usuarios WHERE First_name LIKE @filtro OR Userd LIKE @filtro", conexion);
                datos.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                DataSet ds = new DataSet();
                datos.Fill(ds, "Usuarios");
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex) {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Txt_Password.PasswordChar = '\0';
                checkBox1.Image = Properties.Resources.ojo;
            }
            else
            {
                Txt_Password.PasswordChar = '*';
                checkBox1.Image = Properties.Resources.ojos_cruzados;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow fila = dataGridView1.CurrentRow;

                Txt_Usuario.Text = Convert.ToString(fila.Cells[1].Value);
                Txt_Password.Text = Convert.ToString(fila.Cells[2].Value);
                Txt_Correo.Text = Convert.ToString(fila.Cells[3].Value);
                Txt_Nombre.Text = Convert.ToString(fila.Cells[4].Value);
                Txt_Apellido.Text = Convert.ToString(fila.Cells[5].Value);
                Txt_Sexo.SelectedItem = Convert.ToString(fila.Cells[6].Value);
                Check_Admin.Checked = Convert.ToBoolean(fila.Cells[7].Value);
            }
        }
    }
}
