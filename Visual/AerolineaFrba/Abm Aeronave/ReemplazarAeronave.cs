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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(this.cmbVuelo.SelectedIndex == -1))
            {
                Int32 selectedRowCount = dgvAeronaves.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0 && selectedRowCount < 2)
                {
                    //DataGridViewRow d = dgvAeronaves.SelectedRows[0];
                    //bool resultado = Conexion.executeProcedure("DATA_G.CAMBIO_AERONAVE", Conexion.generarArgumentos("@NOMBRE"), rolDesc);
                    //if (resultado)
                    //{
                    //    MessageBox.Show("Cambio de aeronave hecho");
                    //}
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Elegir un aeronave y sólo un aeronave");
                }

                this.Hide();
                FormProvider.VerAeronaves.Show();
            }
            else
            {
                MessageBox.Show("Seleccionar un vuelo");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerAeronaves.Show();
        }

        private void reemplazarAeronave_Load(object sender, EventArgs e)
        {
            string query = "SELECT DATA_G.GET_ID_AERONAVE ('" + txtMatri.Text + "', '" + txtFab.Text + "') AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            string idAeronave = (reader["id"].ToString());
            reader.Close();
            txtId.Text = idAeronave;

            cmbVuelo.ValueMember = "NroVuelo";
            cmbVuelo.DisplayMember = "NroVuelo";
            cmbVuelo.DataSource =("SELECT * DATA_G.VUELO WHERE IdAeronave = '" + idAeronave + "'").ToList();  
        }

        public void cargaAeronave(string matricula, string fabricante) 
        {
            
            txtMatri.Text = matricula;
            txtFab.Text = fabricante;
            
            string query = "SELECT DATA_G.GET_ID_AERONAVE ('" + matricula + "', '" + fabricante + "') AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            string idAeronave = (reader["id"].ToString());
            reader.Close();
            txtId.Text = idAeronave;

            
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
            dgvAeronaves.Enabled = true;
            Int32 vuelo = Convert.ToInt32(cmbVuelo.SelectedValue);
            string query = "SELECT A.Matricula, A.Fabricante, A.Modelo, T.Descripcion, C.Nombre, A.KG_Disponibles, A.CantButacas FROM DATA_G.AERONAVE A, DATA_G.CIUDAD C, DATA_G.TIPODESERVICIO T, DATA_G.VUELO V,  DATA_G.VUELO V2 WHERE ((SELECT V.FechaSalida WHERE '" + vuelo + "' = V.NroVuelo) > (SELECT V.FechaEstimadaLlegada WHERE V.IdAeronave = A.IdAeronave)) AND ((SELECT V.FechaEstimadaLlegada WHERE '" + vuelo + "' = V.NroVuelo) > (SELECT V2.FechaSalida WHERE V2.IdAeronave = A.IdAeronave)) AND A.IdEstado = 2 AND (select C.Nombre WHERE C.CodigoCiudad = A.Ubicacion) = '" + txtOrigen.Text + "' AND A.CantButacas >= '" + txtButacas.Text + "' AND A.KG_Disponibles >= '" + txtEncomienda.Text + "' AND (select T.Descripcion WHERE T.IdServicio = A.IdServicio) =  '" + txtServ.Text + "' AND A.Fabricante = '" + txtFab.Text + "' ";
            
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            while (reader.Read())
            {
                dgvAeronaves.Rows.Add(reader["Matricula"].ToString(), reader["Fabricante"].ToString(), reader["Modelo"].ToString(), reader["Descripcion"].ToString(), reader["Nombre"].ToString(), reader["KG_Disponibles"].ToString(), reader["CantButacas"].ToString());
            }
            //if( query == null)
            //{
            //    MessageBox.Show("No hay vuelos disponibles, vaya a alta de aeronave");
            //}
                 reader.Close();
        }

        private void dgvAeronaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
