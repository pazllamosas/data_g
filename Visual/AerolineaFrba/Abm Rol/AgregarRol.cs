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
        }

        private void label1_Click(object sender, EventArgs e)
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
            FormProvider.VerRoles.Show();
        }

        private void AgregarRol_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DATA_G.FUNCIONALIDADES";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvElegirFuncionalidad.Rows.Add(reader["DescripcionFunc"]);
            }
            reader.Close();


        }

        private void dgvElegirFuncionalidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
