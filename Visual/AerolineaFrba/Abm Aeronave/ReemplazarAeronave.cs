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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class reemplazarAeronave : Form
    {
        public reemplazarAeronave()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvAeronaves.DataSource = null;
            dgvAeronaves.Rows.Clear();
            FormProvider.VerAeronaves.Show();
            this.Hide();

        }

        private void reemplazarAeronave_Load(object sender, EventArgs e)
        {
            //string query = "SELECT DATA_G.GET_ID_AERONAVE ('" + txtMatri.Text + "', '" + txtFab.Text + "') AS id";

            //SqlDataReader reader = Conexion.ejecutarQuery(query);
            //reader.Read();
            //string idAeronave = (reader["id"].ToString());
            //reader.Close();
            //txtId.Text = idAeronave;

        }

        public void cargaAeronave(string matricula, string fabricante)
        {

            txtMatri.Text = matricula;
            txtFab.Text = fabricante;

            dgvAeronaves.DataSource = null;

            string query = "SELECT DATA_G.GET_ID_AERONAVE ('" + matricula + "', '" + fabricante + "') AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            string idAeronave = (reader["id"].ToString());
            reader.Close();
            txtId.Text = idAeronave;

            dgvVuelo.Rows.Clear();
            dgvAeronaves.Rows.Clear();
            string query2 = "SELECT NroVuelo FROM DATA_G.VUELO WHERE IdAeronave = '" + idAeronave + "'";
            SqlDataReader reader2 = Conexion.ejecutarQuery(query2);

            while (reader2.Read())
            {
                dgvVuelo.Rows.Add(reader2["NroVuelo"]);
            }
            reader2.Close();


        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT A.CantButacas, A.KG_Disponibles, A.Modelo, C.Nombre, T.Descripcion FROM DATA_G.AERONAVE A, DATA_G.CIUDAD C, DATA_G.TIPODESERVICIO T WHERE A.Ubicacion = C.CodigoCiudad AND A.IdServicio = T.IdServicio AND IdAeronave = " + txtId.Text;
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            if (reader.Read())
            {
                txtButacas.Text = reader["CantButacas"].ToString();
                txtEncomienda.Text = reader["KG_Disponibles"].ToString();
                txtModelo.Text = reader["Modelo"].ToString();
                txtOrigen.Text = reader["Nombre"].ToString();
                txtServ.Text = reader["Descripcion"].ToString();

            }
            reader.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvVuelo.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvVuelo.SelectedRows[0];
                string vuelo = d.Cells[0].Value.ToString();

                string query = "SELECT DISTINCT A.Matricula, A.Fabricante, A.Modelo, T.Descripcion, V3.FechaSalida, C.Nombre, A.KG_Disponibles, A.CantButacas FROM DATA_G.AERONAVE A, DATA_G.CIUDAD C, DATA_G.TIPODESERVICIO T, DATA_G.VUELO V,  DATA_G.VUELO V2,  DATA_G.VUELO V3 WHERE ((SELECT V.FechaSalida WHERE '" + vuelo + "' = V.NroVuelo) > (SELECT V2.FechaEstimadaLlegada WHERE V2.IdAeronave = A.IdAeronave)) AND ((SELECT V.FechaEstimadaLlegada WHERE '" + vuelo + "' = V.NroVuelo) > (SELECT V3.FechaSalida WHERE V3.IdAeronave = A.IdAeronave)) AND A.IdEstado = 2 AND (select C.Nombre WHERE C.CodigoCiudad = A.Ubicacion) = '" + txtOrigen.Text + "' AND A.CantButacas >= '" + txtButacas.Text + "' AND A.KG_Disponibles >= '" + txtEncomienda.Text + "' AND (select T.Descripcion WHERE T.IdServicio = A.IdServicio) =  '" + txtServ.Text + "' AND A.Fabricante = '" + txtFab.Text + "' ";

                SqlDataReader reader = Conexion.ejecutarQuery(query);
                if (reader.Read())
                {
                    while (reader.Read())
                    {

                        dgvAeronaves.Rows.Add(reader["Matricula"].ToString(), reader["Fabricante"].ToString(), reader["Modelo"].ToString(), reader["Descripcion"].ToString(), reader["FechaSalida"].ToString(), reader["Nombre"].ToString(), reader["KG_Disponibles"].ToString(), reader["CantButacas"].ToString());
                    }

                    btnGuardar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No hay vuelos disponibles, vaya a alta de aeronave");
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("Marcar un vuelo");
            }
        }

        private void dgvAeronaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvAeronaves.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvAeronaves.SelectedRows[0];
                string matricula = d.Cells[0].Value.ToString();
                string fabricante = d.Cells[1].Value.ToString();

                string query = "SELECT DATA_G.GET_ID_AERONAVE ('" + matricula + "', '" + fabricante + "') AS id";

                SqlDataReader reader = Conexion.ejecutarQuery(query);
                reader.Read();
                string idAeronave = (reader["id"].ToString());
                reader.Close();
                txtId.Text = idAeronave;

                DataGridViewRow dV = dgvVuelo.SelectedRows[0];
                string vuelo = dV.Cells[0].Value.ToString();

                bool resultado = Conexion.executeProcedure("DATA_G.CAMBIO_AERONAVE", Conexion.generarArgumentos("@nrovuelo", "@nuevaaeronave"), vuelo, idAeronave);
                if (resultado)
                {
                    MessageBox.Show("Cambio de aeronave hecho");
                }

            }
            else
            {
                MessageBox.Show("Elegir un aeronave y sólo un aeronave");
            }
            dgvAeronaves.DataSource = null;
            this.Hide();
            FormProvider.VerAeronaves.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvVuelo.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvVuelo.SelectedRows[0];
                string vuelo = d.Cells[0].Value.ToString();
                bool resultado = Conexion.executeProcedure("DATA_G.BAJA_VUELO", Conexion.generarArgumentos("@nrovuelo"), vuelo);
                if (resultado)
                {
                    MessageBox.Show("Pasajes Y Encomiendas Canceladas");
                    this.Hide();
                    FormProvider.VerAeronaves.Show();
                }
                else
                {
                    MessageBox.Show("ERROR al cancelar");
                }
            }
                else
                {
                    MessageBox.Show("Marcar un vuelo");
                }
            

        }
    }
}
