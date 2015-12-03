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

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class AeronavesConMayorCantidadDeDiasFueraDeServicio : Form
    {
        public AeronavesConMayorCantidadDeDiasFueraDeServicio()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.ListadoEstadistico.Show();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string fecha = txtAnioAConsultar.Text;

            string query = " SELECT DATA_G.TOP5_AERONAVE_FUERA_SERVICIO('" + fecha + "')"; //ver si es query o procedure
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvListado.Rows.Add(reader["Aeronave"], reader["Cantidad días fuera de servicio"]);
            }
            reader.Close();
        }

        private void AeronavesConMayorCantidadDeDiasFueraDeServicio_Load(object sender, EventArgs e)
        {

        }
    }
}
