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
            cmbSemestre.Items.Add(1);
            cmbSemestre.Items.Add(2);
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

           if (cmbSemestre.Text == "1")
            {
                string fecha = txtAnioAConsultar.Text;

                string query = " SELECT * FROM DATA_G.TOP5_DESTINOS_PASAJES_CANCELADOS(" + "00/06/" + fecha + ")"; //ver si es query o procedure
                SqlDataReader reader = Conexion.ejecutarQuery(query);

                while (reader.Read())
                {
                    dgvListado.Rows.Add(reader["destino"], reader["cantidad"]);
                }
                reader.Close();
           }
            else if (cmbSemestre.Text == "2")
            {
                string fecha = txtAnioAConsultar.Text;

                string query = " SELECT * FROM DATA_G.TOP5_DESTINOS_PASAJES_CANCELADOS(" + "00/12/" + fecha + ")"; //ver si es query o procedure
                SqlDataReader reader = Conexion.ejecutarQuery(query);

                while (reader.Read())
                {
                    dgvListado.Rows.Add(reader["destino"], reader["cantidad"]);
                }
                reader.Close();
            }
               else MessageBox.Show("ERROR debe elegir semestre 1 o 2");
           
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
