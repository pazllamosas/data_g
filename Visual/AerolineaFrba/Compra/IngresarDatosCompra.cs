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

namespace AerolineaFrba.Compra
{
    public partial class IngresarDatosCompra : Form
    {
        public IngresarDatosCompra()
        {
            InitializeComponent();
        }

        public bool ValidateFlightSearch() {
            if (!string.IsNullOrEmpty(cmbCiudadOrigen.Text) && !string.IsNullOrEmpty(cmbCiudadDestino.Text) && (!string.IsNullOrEmpty(txtCantPasajes.Text) || !string.IsNullOrEmpty(txtPesoEncomienda.Text)))
            {
                return true;
            } else {
                return false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            btnBuscarVuelos.Enabled = this.ValidateFlightSearch();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscarVuelos.Enabled = this.ValidateFlightSearch();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.FormaDeCompra.Show();
        }

        private void txtCantPasajes_TextChanged(object sender, EventArgs e)
        {
            btnBuscarVuelos.Enabled = this.ValidateFlightSearch();
        }

        private void txtPesoEncomienda_TextChanged(object sender, EventArgs e)
        {
            btnBuscarVuelos.Enabled = this.ValidateFlightSearch();
        }

        private void cmbCiudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscarVuelos.Enabled = this.ValidateFlightSearch();
        }

        private void IngresarDatosCompra_Load(object sender, EventArgs e)
        {
            Conexion.cargarCmb("Nombre", "CIUDAD", cmbCiudadOrigen);
            Conexion.cargarCmb("Nombre", "CIUDAD", cmbCiudadDestino);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.ElegirButaca.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void dgvPasajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarVuelos_Click(object sender, EventArgs e)
        {
            string query = "SELECT aeronave.IdAeronave as IdAeronave, aeronave.KG_Disponibles as Kg_Disponibles, aeronave.CantButacas as CantButacas, vuelos.NroVuelo as NroVuelo, vuelos.FechaSalida as FechaSalida FROM DATA_G.VUELO vuelos,DATA_G.RUTA rutas, DATA_G.CIUDAD ciudades1, DATA_G.CIUDAD ciudades2, DATA_G.AERONAVE aeronave WHERE vuelos.FechaSalida <= " + dtmVuelo.Text + " AND vuelos.IdRuta = rutas.idRuta AND vuelos.IdAeronave = aeronave.IdAeronave AND rutas.Origen = ciudades1.CodigoCiudad AND ciudades1.Nombre = '" + cmbCiudadOrigen.Text + "' AND rutas.Destino = ciudades2.CodigoCiudad AND ciudades2.Nombre = '" + cmbCiudadOrigen.Text + "'";

            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                bool seAgregaElVuelo = true;
                //si se pide enviar alguna encomienda en el vuelo
                if (!string.IsNullOrEmpty(txtPesoEncomienda.Text))
                {
                    string query2 = "SELECT SUM(PQ.KG) AS KgLibres FROM DATA_G.COMPRA C JOIN DATA_G.PAQUETE PQ on PQ.NroCompra = C.NroCompra WHERE C.NroVuelo = " + reader["NroVuelo"].ToString() +" and C.NroCompra not in (SELECT NroCompra FROM DATA_G.DEVOLUCION)";
                    SqlDataReader reader2 = Conexion.ejecutarQuery(query2);

                    // si hay encomiendas para el vuelo
                    if (reader2.Read())
                    {
                        //ver si hay espacio
                        if (int.Parse(reader2["KgLibres"].ToString()) >= int.Parse(txtPesoEncomienda.Text))
                        {
                            seAgregaElVuelo = true;
                        }
                        else
                        {
                            seAgregaElVuelo = false;
                        }
                    }
                    else if (int.Parse(reader["Kg_Disponibles"].ToString()) >= int.Parse(txtPesoEncomienda.Text))
                    {
                        seAgregaElVuelo = true;
                    }
                    else
                    {
                        seAgregaElVuelo = false;
                    }

                }

                //si se pide enviar alguna butaca en el vuelo
                if (!string.IsNullOrEmpty(txtCantPasajes.Text) && seAgregaElVuelo)
                {
                    string query3 = "SELECT count(B.IdButaca) as ButacasLibres FROM DATA_G.BUTACA B WHERE B.IdAeronave = " + reader["IdAeronave"].ToString() +" AND B.Estado = 'Libre'";
                    SqlDataReader reader3 = Conexion.ejecutarQuery(query3);

                    // si hay butacas para el vuelo
                    if (reader3.Read())
                    {
                        //ver si hay espacio
                        if (int.Parse(reader3["ButacasLibres"].ToString()) >= int.Parse(txtCantPasajes.Text))
                        {
                            seAgregaElVuelo = true;
                        }
                        else
                        {
                            seAgregaElVuelo = false;
                        }
                    }
                    else if (int.Parse(reader["CantButacas"].ToString()) >= int.Parse(txtCantPasajes.Text))
                    {
                        seAgregaElVuelo = true;
                    }
                    else
                    {
                        seAgregaElVuelo = false;
                    }

                }

                if (seAgregaElVuelo)
                {
                    dgvVuelos.Rows.Add(reader["NroVuelo"], reader["FechaSalida"]);
                }
                
            }
            reader.Close();

        }
    }
}
