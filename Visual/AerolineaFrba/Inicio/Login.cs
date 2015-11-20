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

                string contrasenia = txtContrasenia.Text;

                List<String> parametros = new List<String>();
                parametros.Add(usuario);
                parametros.Add(contrasenia);

                int respuesta = Conexion.executeProcedureWithReturnValue("PASSWORD_CORRECTA", parametros);

                if (respuesta == 1) 
                {
                    this.Hide();
                    FormProvider.MainMenu.Show();                
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

    }
}
