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

namespace AerolineaFrba.Abm_Rol
{
    public partial class VerRoles : Form
    {
        public VerRoles()
        {
            InitializeComponent();
        }

        public void CargarRoles()
        {
            dgvRoles.Rows.Clear();
            string query = "SELECT IdRol, Descripcion FROM DATA_G.ROL";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvRoles.Rows.Add(reader["IdRol"], reader["Descripcion"]);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnEditar.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Int32 selectedRowCount = dgvRoles.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvRoles.SelectedRows[0];
                string rol = d.Cells[0].Value.ToString();
                string rolDesc = d.Cells[1].Value.ToString();
                FormProvider.AgregarRol.Show(); //mandar todos los parametros.
                FormProvider.AgregarRol.EditarRol(rol, rolDesc);

                this.Hide();
            }
            else
            {
                MessageBox.Show("No podés editar si no elegís un rol y sólo un rol");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //    string query = "SELECT * FROM DATA_G.ROL";
            //    SqlDataReader reader = Conexion.ejecutarQuery(query);

            //    while (reader.Read())
            //    {
            //        dgvRoles.Rows.Add(reader["IdRol"], reader["Descripcion"]);
            //    }
            //    reader.Close();
            //    btnEditar.Enabled = true;
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

