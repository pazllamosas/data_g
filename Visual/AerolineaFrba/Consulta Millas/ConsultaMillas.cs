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

namespace AerolineaFrba.Consulta_Millas
{
    public partial class ConsultaMillas : Form
    {
        

        public ConsultaMillas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;

            string query = "SELECT DATA_G.GET_CLIENTE_DNI ('" + dni + "') AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta > 0)
            {
                dgvDetalle.DataSource = getMillasGanadas(dni);
                dgvDetalle.DataSource = getMillasCanjeadas(dni);
            }
            else
            {
                MessageBox.Show("DNI incorrecto");
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            btnConsultar.Enabled = !string.IsNullOrEmpty(txtDni.Text);

        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            
            
        }

        public static DataTable getMillasGanadas(String dni)
        {
            return Conexion.obtenerTablaProcedure("DATA_G.MILLAS_GANADAS", Conexion.generarArgumentos("@dni"), Int32.Parse(dni));
        }

        public static DataTable getMillasCanjeadas(String dni)
        {
            return Conexion.obtenerTablaProcedure("DATA_G.MILLAS_CANJEADAS", Conexion.generarArgumentos("@dni"), Int32.Parse(dni));
        }

    }
}
