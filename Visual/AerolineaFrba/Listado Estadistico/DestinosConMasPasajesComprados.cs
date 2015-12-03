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
    public partial class DestinosConMasPasajesComprados : Form
    {
        public DestinosConMasPasajesComprados()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.ListadoEstadistico.Show();
        }

        private void DestinosConMasPasajesComprados_Load(object sender, EventArgs e)
        {
            cmbSemestre.Items.Add(1);
            cmbSemestre.Items.Add(2);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbSemestre.Text == "1")
            {
                string fecha = txtAnioAConsultar.Text;

                string query = " SELECT * FROM DATA_G.TOP5_DESTINOS_PASAJES(" + "00/06/" + fecha + ")"; //ver si es query o procedure
                SqlDataReader reader = Conexion.ejecutarQuery(query);

                while (reader.Read())
                {
                    dgvListado.Rows.Add(reader["nombre"], reader["apellido"], reader["cantidad"]);
                }
                reader.Close();
            }
            else if (cmbSemestre.Text == "2")
            {
                string fecha = txtAnioAConsultar.Text;

                string query = " SELECT * FROM DATA_G.TOP5_DESTINOS_PASAJES(" + "00/12/" + fecha + ")"; //ver si es query o procedure
                SqlDataReader reader = Conexion.ejecutarQuery(query);

                while (reader.Read())
                {
                    dgvListado.Rows.Add(reader["nombre"], reader["cantidad"]);
                }
                reader.Close();
            }
            else MessageBox.Show("ERROR debe elegir semestre 1 o 2");
        }
    }
}
