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



namespace AerolineaFrba.Inicio
{
    public partial class Login : Form
    {
        private string password = "";
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Enabled = !chkInvitado.Checked;
            txtContrasenia.Enabled = !chkInvitado.Checked;
            if (!chkInvitado.Checked && !string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContrasenia.Text))
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = chkInvitado.Checked;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkInvitado.Checked)
            {
                this.Hide();
                FormProvider.MainMenu.Show();
            }
            else
            {
                string usuario = txtUsuario.Text;
                string password =  txtContrasenia.Text;
                string contrasenia = funciones.SHA256Encripta(this.password);
                if (usuarioValido(usuario) )
                {
                    if (passwordValida(usuario, password))
                    {
                        loginCorrecto(usuario);
                        this.Hide();
                        FormProvider.MainMenu.Show();
                    }
                }
            
                

                // TODO logear usuario contra DB
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContrasenia.Text))
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContrasenia.Text) && !string.IsNullOrEmpty(txtUsuario.Text))
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Conexion.establecerConexionBD();
        }


        public Boolean usuarioValido(string usuario)
        {
            string query = "SELECT DATA_G.EXISTE_USUARIO ('" + usuario + "' ) AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta >= 1)
            {
                               
                return true;
            }
            else
            {
                MessageBox.Show("El usuario es invalido");
                return false;
            }
        }

        public Boolean passwordValida(string usuario, string password)
        {
            
            string contrasenia = funciones.SHA256Encripta(password);
            string query = "SELECT DATA_G.PASSWORD_CORRECTA ('" + usuario + "', '" + contrasenia + "') AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta >= 1)
            {
                
                return true;
            }
            else
            {
                MessageBox.Show("La contraseña es invalida");
                loginIncorrecto(usuario);
               
                return false;
            }
        }

        private static void loginCorrecto(string usuario)
        {
            intentos(usuario, 1);
        }

        private static void loginIncorrecto(string usuario)
        {
            intentos(usuario, 0);
        }


        private static void intentos(string usuario, int acceso)
        {
           Conexion.executeProcedure("INTENTO_LOGIN", usuario, acceso);

        }

               

    
    }
}
