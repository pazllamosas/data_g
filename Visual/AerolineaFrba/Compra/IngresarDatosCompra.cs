﻿using System;
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

            List<string> idButacasOcupadas = new List<string>();
            if (int.Parse(txtCantPasajes.Text) > 0 && !string.IsNullOrEmpty(txtCantPasajes.Text)) {
                
                int cantidadDePasajes = dgvPasajes.Rows.Count;

                for (int i = 0; i < cantidadDePasajes; i++ )
                {
                    idButacasOcupadas.Add(dgvPasajes.Rows[i].Cells[5].Value.ToString());
                }

            }

            DataGridViewRow d = dgvVuelos.SelectedRows[0];

            FormProvider.FormaDeCompra.MostrarFormaDeCompra(txtPesoEncomienda.Text, idButacasOcupadas, d.Cells[2].Value.ToString(), compraEnEfectivo);
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

            DataGridViewRow d = dgvVuelos.SelectedRows[0];
            
            int cantidadDePasajes = dgvPasajes.Rows.Count;
            if (cantidadDePasajes == 0)
            {
                FormProvider.ElegirButaca.CargarButacas(d.Cells[2].Value.ToString());
            }
            else
            {
                string idButacasOcupadas = "";
                for (int i = 0; i < cantidadDePasajes; i++ )
                {
                    if (i < (cantidadDePasajes - 1))
                    {
                        idButacasOcupadas = idButacasOcupadas + dgvPasajes.Rows[i].Cells[5].Value.ToString() + ", ";
                    }
                    else
                    {
                        idButacasOcupadas = idButacasOcupadas + dgvPasajes.Rows[i].Cells[5].Value.ToString();
                    }
                }

                FormProvider.ElegirButaca.CargarButacas(d.Cells[2].Value.ToString(), idButacasOcupadas);
            }
        }

        public void AgregarButacaADgv(string dni, string nombre, string numerobutaca, string tipobutaca, string piso, string id) {
            dgvPasajes.Rows.Add(dni, nombre, numerobutaca, tipobutaca, piso, id);
            int cantidadDePasajes = dgvPasajes.RowCount;
            if (cantidadDePasajes == int.Parse(txtCantPasajes.Text))
            {
                btnAgregar.Enabled = false;
                btnSiguiente.Enabled = true;
            }
        }

        public void EditarButacaEnDgv(string dni, string nombre, string numerobutaca, string tipobutaca, string piso, string id)
        {
            dgvPasajes.Rows[editandoPasaje].Cells[0].Value = dni;
            dgvPasajes.Rows[editandoPasaje].Cells[1].Value = nombre;
            dgvPasajes.Rows[editandoPasaje].Cells[2].Value = numerobutaca;
            dgvPasajes.Rows[editandoPasaje].Cells[3].Value = tipobutaca;
            dgvPasajes.Rows[editandoPasaje].Cells[4].Value = piso;
            dgvPasajes.Rows[editandoPasaje].Cells[5].Value = id;

            int cantidadDePasajes = dgvPasajes.Rows.Count;
            if (cantidadDePasajes == int.Parse(txtCantPasajes.Text))
            {
                btnAgregar.Enabled = false;
                btnSiguiente.Enabled = true;
            }

            editandoPasaje = -1;
        }

        private static int editandoPasaje = -1;


        private void btnEditar_Click(object sender, EventArgs e)
        {

            //me guarda local los datos de la linea seleccionada para estar segura de que lo tengo a mano
            DataGridViewRow pasajes = dgvPasajes.SelectedRows[0];
            editandoPasaje = dgvPasajes.CurrentCell.RowIndex;

            this.Hide();
            
            //busco las butacas que ya fueron ocupadas en esta compra para evitarlas
            int cantidadDePasajes = dgvPasajes.Rows.Count;
            
                string idButacasOcupadas = "";
                for (int i = 0; i < cantidadDePasajes; i++)
                {
                    if (i < (cantidadDePasajes - 1))
                    {
                        idButacasOcupadas = idButacasOcupadas + dgvPasajes.Rows[i].Cells[5].Value.ToString() + ", ";
                    }
                    else
                    {
                        idButacasOcupadas = idButacasOcupadas + dgvPasajes.Rows[i].Cells[5].Value.ToString();
                    }
                }


            // muestro la otra pantalla
                DataGridViewRow vuelos = dgvVuelos.SelectedRows[0];
                FormProvider.ElegirButaca.CargarButacas(vuelos.Cells[2].Value.ToString(), idButacasOcupadas);
                FormProvider.ElegirButaca.EditarButaca(pasajes.Cells[1].Value.ToString(), pasajes.Cells[0].Value.ToString());
                FormProvider.ElegirButaca.Show();

        }

        private void btnBuscarVuelos_Click(object sender, EventArgs e)
        {
            string origen = cmbCiudadOrigen.Text;
            string destino = cmbCiudadDestino.Text;
            string fecha = dtmVuelo.Value.ToString("yyyy-MM-dd");
           // DateTime dt = DateTime.ParseExact(dateString, "ddMMyyyy", CultureInfo.InvariantCulture);
            //dt.ToString("yyyyMMdd");

            string query = "SELECT aeronave.IdAeronave as IdAeronave, aeronave.KG_Disponibles as Kg_Disponibles, aeronave.CantButacas as CantButacas, vuelos.NroVuelo as NroVuelo, vuelos.FechaSalida as FechaSalida FROM DATA_G.VUELO vuelos,DATA_G.RUTA rutas, DATA_G.CIUDAD ciudades1, DATA_G.CIUDAD ciudades2, DATA_G.AERONAVE aeronave WHERE vuelos.FechaSalida <= '" + fecha + "' AND vuelos.IdRuta = rutas.idRuta AND vuelos.IdAeronave = aeronave.IdAeronave AND rutas.Origen = ciudades1.CodigoCiudad AND ciudades1.Nombre = '" + origen + "' AND rutas.Destino = ciudades2.CodigoCiudad AND ciudades2.Nombre = '" + destino + "' ";

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
                    reader2.Close();
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
                    reader3.Close();
                }

                
                if (seAgregaElVuelo)
                {
                    dgvVuelos.Rows.Add(reader["NroVuelo"], reader["FechaSalida"], reader["IdAeronave"]);
                }
                
            }
            reader.Close();

        }
        
        private void dgvVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = dgvVuelos;

            if (dgv.CurrentRow.Selected)
            {
                Int32 selectedRowCount = dgvVuelos.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0 && selectedRowCount < 2)
                {
                    if (txtCantPasajes.Text == "") txtCantPasajes.Text = "0";
                    Int32 pasajesRowCount = dgvPasajes.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (pasajesRowCount > 0) dgvPasajes.Rows.Clear();

                    if (int.Parse(txtCantPasajes.Text) > 0)
                    {
                        btnAgregar.Enabled = true;
                        dgvPasajes.Enabled = true;
                        btnSiguiente.Enabled = false;
                    }
                    else
                    {
                        btnAgregar.Enabled = false;
                        dgvPasajes.Enabled = false;
                        btnSiguiente.Enabled = true;
                    }
                }
            }
        }

        public void LimpiarFormulario()
        {
            dgvPasajes.Rows.Clear();
            dgvVuelos.Rows.Clear();
            txtCantPasajes.Clear();
            txtPesoEncomienda.Clear();
            dtmVuelo.Text = new DateTime().ToString();
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnBuscarVuelos.Enabled = false;
            btnSiguiente.Enabled = false;
        }

        public void mostrarFormulario(bool estado)
        {
            compraEnEfectivo = estado;
        }

        private static bool compraEnEfectivo;
        private void dgvPasajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvPasajes.Rows[index].Selected = true;

            Int32 selectedRowCount = dgvPasajes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                btnEditar.Enabled = true;
            }
        }
    }
}
