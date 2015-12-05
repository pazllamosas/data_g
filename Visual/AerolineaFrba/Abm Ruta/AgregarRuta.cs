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

            double precio_kg = double.Parse(txtPrecioEncomienda.Text);

            double precio_pasaje = double.Parse(txtPrecioPasaje.Text);

            Int32 descripcionServicio = (Int32)cmbTipoServicio.SelectedValue;

            Int32 origen = (Int32)cmbCiudadOrigen.SelectedValue;

            Int32 destino = (Int32)cmbCiudadDestino.SelectedValue;

            string query = "SELECT DATA_G.GET_ID_SERVICIO ('" + descripcionServicio + "')";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            string idServicio = reader["id"].ToString();
            reader.Close();
            query = "DATA_G.CREAR_RUTA ('" + codigo + "', " + "'" + precio_kg + "', " + precio_pasaje + ", '" +
                                             idServicio + "', '" + origen + "', " + destino + ")";

            reader = Conexion.ejecutarQuery(query);
            reader.Close();

            if (this.validacionDatos(codigo, precio_kg, precio_pasaje, origen, destino))
            {
                bool resultado = Conexion.executeProcedure("DATA_G.CREAR_RUTA", Conexion.generarArgumentos("@codigo", "@precio_Kg", "@precio_Pasaje",
                    "@origen", "@destino", "@servicio"), codigo, precio_kg, precio_pasaje, origen, destino, descripcionServicio);

                if (resultado)
                {
                    MessageBox.Show("Ruta creada exitosamente");

                    this.txtCodigo.Clear();
                    this.txtPrecioEncomienda.Clear();
                    this.txtPrecioPasaje.Clear();
                    this.cmbTipoServicio.SelectedIndex = -1;
                    this.cmbCiudadOrigen.SelectedIndex = -1;
                    this.cmbCiudadDestino.SelectedIndex = -1;

                }

            }
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

        private void txtPrecioEncomienda_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.permiteNumeros(e);
        }

        private void txtPrecioPasaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            funciones.permiteNumeros(e);
        }

        private bool validacion()
        {
            if (this.txtCodigo.Text.Trim() == "")
                return false;
            if (this.txtPrecioEncomienda.Text.Trim() == "")
                return false;
            if (this.txtPrecioPasaje.Text.Trim() == "")
                return false;
            if (this.cmbTipoServicio.SelectedIndex == -1)
                return false;
            if (this.cmbCiudadOrigen.SelectedIndex == -1)
                return false;
            if (this.cmbCiudadDestino.SelectedIndex == -1)
                return false;
            return true;
        }

        private bool validacionDatos(string codigo, double precio_kg, double precio_pasaje, int origen, int destino)
        {
            if (origen == destino)
            {
                MessageBox.Show("La ruta no puede tener una misma ciudad como origen y destino");
                this.cmbCiudadDestino.SelectedIndex = -1;
                return false;
            }
            if (precio_kg == 0) 
            {
                MessageBox.Show("El precio de los kg no puede ser 0");
                this.txtPrecioEncomienda.Clear();
                return false;
            }
            if (precio_pasaje == 0)
            {
                MessageBox.Show("El precio del pasaje no puede ser 0");
                this.txtPrecioPasaje.Clear();
                return false;
            }
            if (codigoValido(codigo))
            {
                this.txtCodigo.Clear();
               return false;
            }
            return true;
        }

        public Boolean codigoValido(string codigo)
        {
            string query = "SELECT DATA_G.EXISTE_CODIGO_RUTA ('" + codigo + "' ) AS id";

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
                MessageBox.Show("El codigo ya existe");
                return false;
            }
        }

    }

}
