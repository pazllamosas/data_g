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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class AgregarRuta : Form
    {
        public AgregarRuta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            string precio_kg = txtPrecioEncomienda.Text;

            string precio_pasaje = txtPrecioPasaje.Text;

            string descripcionServicio = cmbTipoServicio.Text;

            string origen = cmbCiudadOrigen.Text;

            string destino = cmbCiudadDestino.Text;

            string query = "SELECT DATA_G.GET_ID_SERVICIO ('" + descripcionServicio + "')";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            string idServicio = reader["id"].ToString();
            reader.Close();
            query = "DATA_G.CREAR_RUTA ('" + codigo + "', " + "'" + precio_kg + "', " + precio_pasaje + ", '" +
                                             idServicio + "', '" + origen + "', " + destino + ")";

            reader = Conexion.ejecutarQuery(query);
            reader.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerRutas.Show();
        }

        private void cmbCiudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*
            string Sql = "select Nombre from CIUDAD";
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2015;Persist Security Info=True;User ID=gd"].ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                cmbCiudadOrigen.Items.Add(DR[0]);

            }
            conn.Close();
 */
        }

        private void cmbCiudadDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarRuta_Load(object sender, EventArgs e)
        {
            Conexion.cargarCmb( "Nombre", "CIUDAD", cmbCiudadOrigen);
            Conexion.cargarCmb("Nombre", "CIUDAD", cmbCiudadDestino);
            Conexion.cargarCmb("Descripcion", "TIPODESERVICIO", cmbTipoServicio);
        }
    }
}
