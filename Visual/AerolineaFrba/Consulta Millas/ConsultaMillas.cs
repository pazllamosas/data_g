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
            dgvDetalle.Rows.Clear();

            if (txtDni.Text.Length < 1) {
                MessageBox.Show("Por favor, completá el DNI.");
            }
            else if (txtDni.Text.Length == 1) {
                txtDni.Text = txtDni.Text.ToString();
            }
            string query = "SELECT IdCli FROM DATA_G.CLIENTE WHERE DNI = '" + txtDni.Text + "'";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            if (reader.Read())
            {
                string idCliente = reader["IdCli"].ToString();
                reader.Close();

                    query = "SELECT * FROM DATA_G.MILLAS WHERE IdCliente = " + idCliente.ToString();
                    reader = Conexion.ejecutarQuery(query);

                    if (reader.Read())
                    {
                        int total = (int)reader["HistorialMillas"];
                        dgvDetalle.Rows.Add(reader["Fecha"].ToString(), reader["Descripcion"].ToString(), reader["HistorialMillas"].ToString());

                        while (reader.Read())
                        {
                            total = total + (int)reader["HistorialMillas"];
                            dgvDetalle.Rows.Add(reader["Fecha"].ToString(), reader["Descripcion"].ToString(), reader["HistorialMillas"].ToString());
                        }

                        textBox1.Text = total.ToString();
                    }
                    else {
                        MessageBox.Show("¡El cliente no tiene millas acumuladas!");
                    }
                    reader.Close();
            }
            else
            {
                reader.Close();
                MessageBox.Show("Ese DNI no corresponde a ningún cliente. Intentá de nuevo, pero ahora tipeando bien.");
            }
        }

    }
}
