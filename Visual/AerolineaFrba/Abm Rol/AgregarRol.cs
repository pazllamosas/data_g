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

namespace AerolineaFrba.Abm_Rol
{
    public partial class AgregarRol : Form
    {
        public AgregarRol()
        {
            InitializeComponent();
            string query = "SELECT * FROM DATA_G.FUNCIONALIDADES order by IdFuncionalidad";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvElegirFuncionalidad.Rows.Add(reader["IdFuncionalidad"], reader["DescripcionFunc"]);
            }
            reader.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.validacion())
            {
                string nombre = txtNombre.Text;
                string idRol = txtidRol.Text;

                bool resultado = Conexion.executeProcedure("DATA_G.CREAR_ROL", Conexion.generarArgumentos("@NOMBRE"), nombre);
                if (resultado)
                {
                    MessageBox.Show("Rol creado");
                }

                //if (existeRol(nombre))
                //{
                //bool resultado = Conexion.executeProcedure("DATA_G.MODIFICAR_NOMBRE_ROL", Conexion.generarArgumentos("@NOMBRE", "@ROL "), nombre, idRol);
                //if (resultado)
                //{
                //    MessageBox.Show("Rol modificado");
                //}
                // }
                //else
                // {
                //    MessageBox.Show("Ese nombre de rol ya existe");
                // }
            }
            else
            {
                MessageBox.Show("Completar todos los campos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerRoles.Show();
        }

        private void AgregarRol_Load(object sender, EventArgs e)
        {
            //string query = "SELECT * FROM DATA_G.FUNCIONALIDADES";
            //SqlDataReader reader = Conexion.ejecutarQuery(query);

            //while (reader.Read())
            //{
            //    dgvElegirFuncionalidad.Rows.Add(reader["DescripcionFunc"]);
            //}
            //reader.Close();

            cmbUsuario.ValueMember = "IdUsuario";
            cmbUsuario.DisplayMember = "Username";
            cmbUsuario.DataSource = Conexion.cargarTablaConsulta("DATA_G.GET_USUARIOS");

            this.txtNombre.Clear();
            this.txtidRol.Clear();
            this.cmbUsuario.SelectedIndex = -1;


        }

        private void dgvElegirFuncionalidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
       }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }


        public void EditarRol(string rol, string rolDesc) 
        {
            txtidRol.Text = rol;
            txtNombre.Text = rolDesc; 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtNombre.Clear();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtNombre.Clear();

        }

        public Boolean existeRol(string nombre)
        {
            string query = "SELECT DATA_G.EXISTE_ROL ('" + nombre + "' ) AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private bool validacion()
        {
            if (this.txtNombre.Text.Trim() == "")
                return false;
           if (this.cmbUsuario.SelectedIndex == -1)
                return false;
            return true;
        }

    }
}
