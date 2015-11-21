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

namespace AerolineaFrba.Registro_de_Usuario
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio.Menu().Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;   
                
            string query = "DATA_G.CREAR_USUARIO ('" + usuario + "', " + "'" + pass + "')";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Close();
        }
    }
}
