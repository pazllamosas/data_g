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
    public partial class ElegirButaca : Form
    {
        public ElegirButaca()
        {
            InitializeComponent();
        }

        private void ElegirButaca_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void CargarButacas(string IdAeronave) {
            dgvSeleccionButaca.Rows.Clear();
            string query = "SELECT * FROM DATA_G.BUTACA WHERE Estado = 'Libre' and IdAeronave = " + IdAeronave;
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvSeleccionButaca.Rows.Add(reader["NroButaca"], reader["Tipo"].ToString(), reader["Piso"], reader["Estado"], reader["IdButaca"]);
            }
            reader.Close();
        }

        public void CargarButacas(string IdAeronave, string ButacasOcupadas)
        {
            dgvSeleccionButaca.Rows.Clear();

            string query = "SELECT * FROM DATA_G.BUTACA WHERE Estado = 'Libre' and IdAeronave = " + IdAeronave + " AND IdButaca NOT IN(" + ButacasOcupadas + ")";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvSeleccionButaca.Rows.Add(reader["NroButaca"], reader["Tipo"].ToString(), reader["Piso"], reader["Estado"], reader["IdButaca"]);
            }
            reader.Close();
        }

        public void EditarButaca(string nombre, string dni)
        {
            txtNombre.Text = nombre;
            txtDni.Text = dni;
            editando = true;
        }

        private static bool editando = false;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.IngresarDatosCompra.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editando)
            {
                FormProvider.IngresarDatosCompra.EditarButacaEnDgv(txtDni.Text, txtNombre.Text, dgvSeleccionButaca.SelectedRows[0].Cells[0].Value.ToString(), dgvSeleccionButaca.SelectedRows[0].Cells[1].Value.ToString(), dgvSeleccionButaca.SelectedRows[0].Cells[2].Value.ToString(), dgvSeleccionButaca.SelectedRows[0].Cells[4].Value.ToString());
            }
            else
            {
                FormProvider.IngresarDatosCompra.AgregarButacaADgv(txtDni.Text, txtNombre.Text, dgvSeleccionButaca.SelectedRows[0].Cells[0].Value.ToString(), dgvSeleccionButaca.SelectedRows[0].Cells[1].Value.ToString(), dgvSeleccionButaca.SelectedRows[0].Cells[2].Value.ToString(), dgvSeleccionButaca.SelectedRows[0].Cells[4].Value.ToString());
            }

            txtDni.Clear();
            txtNombre.Clear();
            editando = false;
            this.Hide();
            FormProvider.IngresarDatosCompra.Show();
        }

        private void ValidarBotonGuardar()
        {

            if (!string.IsNullOrEmpty(txtDni.Text) && !string.IsNullOrEmpty(txtNombre.Text) && dgvSeleccionButaca.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 && dgvSeleccionButaca.Rows.GetRowCount(DataGridViewElementStates.Selected) < 2)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            this.ValidarBotonGuardar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.ValidarBotonGuardar();
        }

        private void dgvSeleccionButaca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ValidarBotonGuardar();
        }
    }
}
