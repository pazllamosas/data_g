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
    public partial class VerRutas : Form
    {
        public VerRutas()
        {
            InitializeComponent();
            Shown += VerRutas_Shown;
        }

        public void mostrarSeleccionar()
        {
            btnSeleccionar.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (btnSeleccionar.Visible == true)
            {
                FormProvider.GenerarViaje.Show();
            }
            else
            {
                FormProvider.MainMenu.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.AgregarRuta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow d = null;
            string codigo = d.Cells[1].ToString();
            string precioEncomienda = d.Cells[2].ToString();
            string precioPasaje = d.Cells[3].ToString();
            string servicio = d.Cells[4].ToString();
            string ciudadOrigen = d.Cells[5].ToString();
            string ciudadDestino = d.Cells[6].ToString();

            new AgregarRuta(codigo, precioEncomienda, precioPasaje, servicio, ciudadOrigen, ciudadDestino).Show(); //mandar todos los parametros.

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }

        private void VerRutas_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DATA_G.RUTA";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvRutas.Rows.Add(reader["Codigo"], reader["Precio_BaseKG"].ToString(), reader["Precio_BasePasaje"], reader["IdServicio"], reader["Origen"], reader["Destino"]);
            }
            reader.Close();

        }

        private void VerRutas_Shown(object sender, EventArgs e)
        {
            btnSeleccionar.Visible = false;

            string query = "SELECT * FROM DATA_G.RUTA";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvRutas.Rows.Add(reader["Codigo"], reader["Precio_BaseKG"].ToString(), reader["Precio_BasePasaje"], reader["idServicio"], reader["Origen"], reader["Destino"]);
            }
            reader.Close();
        }
    }
}
