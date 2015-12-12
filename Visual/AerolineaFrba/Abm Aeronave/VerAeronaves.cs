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

            Int32 selectedRowCount = dgvAeronaves.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvAeronaves.SelectedRows[0];
                string matricula = d.Cells[1].Value.ToString();
                string fabricante = d.Cells[4].Value.ToString();
                this.Hide();
                FormProvider.BajaAeronave.Show(); 
                FormProvider.BajaAeronave.bajaAeronave(matricula, fabricante);
            }
            else {
                MessageBox.Show("No podés cambiar estado si no elegís una aeronave y sólo una aeronave.");
            }

            
            
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

        }

        public void CargarAeronave()
        {
            dgvAeronaves.Rows.Clear();
            string query = " SELECT FechaDeAlta, matricula, Modelo, kg_disponibles, Fabricante, servicio.Descripcion AS servi, cantButacas, estado.Descripcion AS estadi, BajaPorFueraDeServicio, FechaDeFueraDeServicio, FechaReinicioDeServicio, ciudad.Nombre AS Ubicacion, aeronave.BajaPorVidaUtil FROM DATA_G.AERONAVE AS aeronave, DATA_G.TIPODESERVICIO AS servicio, DATA_G.ESTADO AS estado, DATA_G.CIUDAD AS ciudad WHERE aeronave.IdServicio = servicio.IdServicio AND aeronave.IdEstado = estado.IdEstado AND aeronave.Ubicacion = ciudad.CodigoCiudad";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvAeronaves.Rows.Add(reader["FechaDeAlta"], reader["matricula"].ToString(), reader["Modelo"], reader["kg_disponibles"], reader["Fabricante"], reader["servi"], reader["cantButacas"], reader["estadi"], reader["BajaPorFueraDeServicio"], reader["FechaDeFueraDeServicio"], reader["FechaReinicioDeServicio"], reader["Ubicacion"], reader["BajaPorVidaUtil"]);
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
                string ubicacion = d.Cells[11].Value.ToString();
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
                string bajaVidaUtil = d.Cells[12].Value.ToString();

                if (bajaVidaUtil == "0")
                {
                    string matricula = d.Cells[1].Value.ToString();
                    string modelo = d.Cells[2].Value.ToString();
                    string espacioEncomienda = d.Cells[3].Value.ToString();
                    string fabricante = d.Cells[4].Value.ToString();
                    string servicio = d.Cells[5].Value.ToString();
                    string cantidadButacas = d.Cells[6].Value.ToString();
                    string ubicacion = d.Cells[11].Value.ToString();
                    string bajaFueraServ = d.Cells[8].Value.ToString();
                    string fechaReinicioServ = d.Cells[10].Value.ToString();
                    FormProvider.GenerarViaje.Show(); //mandar todos los parametros.
                    FormProvider.GenerarViaje.EditarGenerarViaje(matricula, modelo, espacioEncomienda, fabricante, servicio, cantidadButacas, ubicacion, bajaFueraServ, fechaReinicioServ);
                }
                else { MessageBox.Show("No se puede elegir una aeronave con baja por vida útil (vida util = 1)"); }
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
