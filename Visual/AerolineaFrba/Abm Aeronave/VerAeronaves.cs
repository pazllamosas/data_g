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
    public partial class VerAeronaves : Form
    {
        public VerAeronaves()
        {
            InitializeComponent();
        }

        public void mostrarSeleccionar() {
                btnSeleccionar.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (btnSeleccionar.Visible)
            {
                FormProvider.GenerarViaje.Show();
            }
            else
            {
                FormProvider.MainMenu.Show();
            }
            
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.BajaAeronave.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.AgregarAeronave.Show();
        }

        private void dgvAeronaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void VerAeronaves_Load(object sender, EventArgs e)
        {
            btnSeleccionar.Visible = false;
            
            string query = "SELECT * FROM DATA_G.AERONAVE";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
            dgvAeronaves.Rows.Add(reader["FechaDeAlta"], reader["matricula"].ToString(), reader["Modelo"], reader["kg_disponibles"], reader ["Fabricante"], reader ["IdServicio"], reader["cantButacas"], reader ["idEstado"] ,reader ["BajaPorFueraDeServicio"], reader ["FechaDeFueraDeServicio"], reader ["FechaReinicioDeServicio"]);
            }
            reader.Close();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount = dgvAeronaves.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvAeronaves.SelectedRows[0];
                string matricula = d.Cells[1].Value.ToString();
                string modelo = d.Cells[2].Value.ToString();
                string espacioEncomienda = d.Cells[3].Value.ToString();
                string fabricante = d.Cells[4].Value.ToString();
                string servicio = d.Cells[5].Value.ToString();
                string cantidadButacas = d.Cells[6].Value.ToString();
                string ubicacion = d.Cells[7].Value.ToString();
                FormProvider.AgregarAeronave.Show(); //mandar todos los parametros.
                FormProvider.AgregarAeronave.EditarAeronave(matricula, modelo, espacioEncomienda, fabricante, servicio, cantidadButacas, ubicacion);
            }
            else {
                MessageBox.Show("No podés editar si no elegís una aeronave y sólo una aeronave.");
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvAeronaves.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvAeronaves.SelectedRows[0];
                string matricula = d.Cells[1].Value.ToString();
                string modelo = d.Cells[2].Value.ToString();
                string espacioEncomienda = d.Cells[3].Value.ToString();
                string fabricante = d.Cells[4].Value.ToString();
                string servicio = d.Cells[5].Value.ToString();
                string cantidadButacas = d.Cells[6].Value.ToString();
                string ubicacion = d.Cells[7].Value.ToString();
                FormProvider.GenerarViaje.Show(); //mandar todos los parametros.
                FormProvider.GenerarViaje.EditarGenerarViaje(matricula, modelo, espacioEncomienda, fabricante, servicio, cantidadButacas, ubicacion);
            }
            else
            {
                MessageBox.Show("No podés editar si no elegís una aeronave y sólo una aeronave.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
