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
            string query = "SELECT * FROM DATA_G.BUTACA";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvSeleccionButaca.Rows.Add(reader["NroButaca"], reader["Tipo"].ToString(), reader["Piso"], reader["Estado"]); //hacerlo sobre la aeronave seleccionada de antemano.
            }
            reader.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void dgvSeleccionButaca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
