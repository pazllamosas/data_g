using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
