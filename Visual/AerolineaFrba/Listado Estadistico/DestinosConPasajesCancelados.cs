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
    public partial class DestinosConPasajesCancelados : Form
    {
        public DestinosConPasajesCancelados()
        {
            InitializeComponent();
        }

        private void DestinosConPasajesCancelados_Load(object sender, EventArgs e)
        {
            //Conexion.cargarCmb("Nombre", "CIUDAD", cmbSemestre);
            //Conexion.cargarCmb("FechaCompra", "PASAJE", cmbAnioAConsultar); //saber como poner fechas.
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.ListadoEstadistico.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string fecha = txtAnioAConsultar.Text;

            string query = " SELECT DATA_G.TOP5_DESTINOS_PASAJES_CANCELADOS(" + fecha + ")"; //ver si es query o procedure
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvListado.Rows.Add(reader["destino"], reader["cantidad"]);
            }
            reader.Close();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
