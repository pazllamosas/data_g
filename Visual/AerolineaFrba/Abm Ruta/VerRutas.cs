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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class VerRutas : Form
    {
        public VerRutas()
        {
            InitializeComponent();
            Shown += VerRutas_Shown;
        }

        public void mostrarSeleccionar()
        {
            btnSeleccionar.Visible = true;
        }

        public void CargarRutas()
        {
            dgvRutas.Rows.Clear();
            string query = "SELECT Codigo, Precio_BaseKG, Precio_BasePasaje, servicio.Descripcion AS servi, ciudad1.Nombre AS origen, ciudad2.Nombre AS destino FROM DATA_G.RUTA AS ruta, DATA_G.TIPODESERVICIO AS servicio, DATA_G.CIUDAD AS ciudad1, DATA_G.CIUDAD AS ciudad2 WHERE ruta.IdServicio = servicio.IdServicio AND ruta.Origen = ciudad1.CodigoCiudad AND ruta.Destino = ciudad2.CodigoCiudad ";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvRutas.Rows.Add(reader["Codigo"], reader["Precio_BaseKG"].ToString(), reader["Precio_BasePasaje"], reader["servi"], reader["origen"], reader["destino"]);
            }
            reader.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (btnSeleccionar.Visible == true)
            {
                FormProvider.GenerarViaje.Show();
            }
            else
            {
                FormProvider.MainMenu.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.AgregarRuta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvRutas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
            DataGridViewRow d = dgvRutas.SelectedRows[0];
            string codigo = d.Cells[0].Value.ToString();
            string precioEncomienda = d.Cells[1].Value.ToString();
            string precioPasaje = d.Cells[2].Value.ToString();
            string servicio = d.Cells[3].Value.ToString();
            string ciudadOrigen = d.Cells[4].Value.ToString();
            string ciudadDestino = d.Cells[5].Value.ToString();
            FormProvider.AgregarRuta.Show();
           
            FormProvider.AgregarRuta.EditarRuta(codigo, precioEncomienda, precioPasaje, servicio, ciudadOrigen, ciudadDestino);
            this.Hide();
            }
            else
            {
                MessageBox.Show("No podés editar si no elegís una ruta y sólo una ruta.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvRutas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvRutas.SelectedRows[0];
                string codigo = (d.Cells[0].Value.ToString());
                string servicio = (d.Cells[3].Value.ToString());
                string ciudadOrigen = (d.Cells[4].Value.ToString());
                string ciudadDestino = (d.Cells[5].Value.ToString());
                
               
                string query = "SELECT DATA_G.GET_ID_RUTA('" + codigo + "', '" + ciudadOrigen + "', '" + ciudadDestino+ "', '" + servicio + "' ) AS id";

                SqlDataReader reader = Conexion.ejecutarQuery(query);
                reader.Read();
                int idRuta = int.Parse(reader["id"].ToString());
                reader.Close();

                if (rutaHabilitada(idRuta))
                {
                    bool resultado = Conexion.executeProcedure("DATA_G.BAJA_RUTA", Conexion.generarArgumentos("@ID"), idRuta );
                    if (resultado)
                    {
                      MessageBox.Show("Ruta inhabilitada");
                     }
                }
                else 
                {
                    MessageBox.Show("Ya se encuentra inhabilitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                }
           
            }
            else
            {
                MessageBox.Show("No podés dar de baja si no elegís una Ruta y sólo una ruta.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerRutas_Load(object sender, EventArgs e)
        {


        }

        private void VerRutas_Shown(object sender, EventArgs e)
        {
            btnSeleccionar.Visible = false;

            //string query = "SELECT * FROM DATA_G.RUTA";
            //SqlDataReader reader = Conexion.ejecutarQuery(query);

            //while (reader.Read())
            //{
             //   dgvRutas.Rows.Add(reader["Codigo"], reader["Precio_BaseKG"].ToString(), reader["Precio_BasePasaje"], reader["idServicio"], reader["Origen"], reader["Destino"]);
            //}
            //reader.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvRutas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvRutas.SelectedRows[0];
                string codigo = d.Cells[0].Value.ToString();
                string precioEncomienda = d.Cells[1].Value.ToString();
                string precioPasaje = d.Cells[2].Value.ToString();
                string servicio = d.Cells[3].Value.ToString();
                string ciudadOrigen = d.Cells[4].Value.ToString();
                string ciudadDestino = d.Cells[5].Value.ToString();
                FormProvider.GenerarViaje.Show(); //mandar todos los parametros.
                FormProvider.GenerarViaje.EditarGenerarViaje2(codigo, precioEncomienda, precioPasaje, servicio, ciudadOrigen, ciudadDestino);
            }
            else
            {
                MessageBox.Show("No podés editar si no elegís una Ruta y sólo una ruta.");
            }
        }

        public Boolean rutaHabilitada(Int32 ruta)
        {
            
            string query = "SELECT  DATA_G.RUTA_HABILITADA ('" + ruta + "') AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
