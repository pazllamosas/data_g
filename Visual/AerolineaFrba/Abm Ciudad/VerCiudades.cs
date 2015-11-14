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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class VerCiudades : Form
    {
        public VerCiudades()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.AgregarCiudad.Show();
        }

        private void Botton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void button2_Click(object sender, EventArgs es)
        {
        }
        private void button3_Click(object sender, EventArgs es)
        {
        }
        private void label1_Click(object sender, EventArgs es)
        {
        }
        private void Form1_Load(object sender, EventArgs es)
        {
            string query = "SELECT * FROM DATA_G.CIUDAD";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvCiudades.Rows.Add(reader["Nombre"]);
            }
            reader.Close();


        }
        private void menuStrip1_ItemClicked(object sender, EventArgs es)
        {
        }

        private void dgvCiudades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
