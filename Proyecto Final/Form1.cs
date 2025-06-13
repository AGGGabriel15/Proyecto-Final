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


namespace Proyecto_Final
{
    public partial class Frm_Login : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = SERVIDOR\\SQLDATABASE; initial catalog = SISTEMA_MEDICO; integrated security = true");

        public Frm_Login()
        {
            InitializeComponent();
            this.AcceptButton = Btn_InicioSesion;
            Txt_Usuario.Focus();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del Sistema?", "Sistema Medico", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = Txt_Usuario.Text;
            string contraseña = Txt_Password.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese nombre de usuario y contraseñas", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT Userd, Pass, issuperuser FROM Usuarios WHERE Userd = @vusuario AND Pass = @vcontraseña", conexion);
                cmd.Parameters.AddWithValue("@vusuario", usuario);
                cmd.Parameters.AddWithValue("@vcontraseña", contraseña);

                SqlDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    bool esSuperUsuario = Convert.ToBoolean(lector["issuperuser"]);

                    MessageBox.Show("Inicio de sesión exitoso", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (esSuperUsuario)
                    {
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        Frm_Menu_Paciente menupaciente = new Frm_Menu_Paciente();
                        menupaciente.Show();
                        this.Hide(); 
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Inicio de sesión fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
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
    }
}
