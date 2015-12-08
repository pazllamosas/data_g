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

namespace AerolineaFrba.Consulta_Millas
{
    public partial class ConsultaMillas : Form
    {
        

        public ConsultaMillas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            btnConsultar.Enabled = !string.IsNullOrEmpty(txtDni.Text);

        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string query = "SELECT IdCli FROM DATA_G.CLIENTE WHERE DNI = '" + txtDni.Text + "'";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int idCliente = int.Parse(reader["IdCli"].ToString());
            reader.Close();

            if (idCliente > 0)
            {

                query = "SELECT * FROM DATA_G.MILLAS WHERE IdCliente = " + idCliente.ToString() ;
                reader = Conexion.ejecutarQuery(query);
                while(reader.Read()) {
                    dgvDetalle.Rows.Add(reader["Fecha"].ToString(), reader["Descripcion"].ToString(), reader["HistorialMillas"].ToString());
                }
                
                reader.Close();

            }
            else
            {
                MessageBox.Show("DNI incorrecto");
            }
        }

    }
}
