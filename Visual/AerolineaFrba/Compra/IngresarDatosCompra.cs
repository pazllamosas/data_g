using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (string.IsNullOrEmpty(cmbCiudadOrigen.Text) && string.IsNullOrEmpty(cmbCiudadDestino.Text) && (!string.IsNullOrEmpty(txtCantPasajes.Text) || !string.IsNullOrEmpty(txtPesoEncomienda.Text)))
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
            FormProvider.ElegirButaca.Show();
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
            Conexion.cargarCmb("Nombre", "CIUDAD", cmbCiudadOrigen);
        }
    }
}
