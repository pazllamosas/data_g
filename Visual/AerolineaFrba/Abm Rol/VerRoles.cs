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
            Int32 selectedRowCount = dgvRoles.Rows.GetRowCount(DataGridViewElementStates.Selected);
           if (selectedRowCount > 0 && selectedRowCount < 2)
           {
                DataGridViewRow d = dgvRoles.SelectedRows[0];
                string rol = d.Cells[0].Value.ToString();
                string rolDesc = d.Cells[1].Value.ToString();
                if (rolHabilitado(rolDesc))
                {
                    bool resultado = Conexion.executeProcedure("DATA_G.BAJA_ROL", Conexion.generarArgumentos("@NOMBRE"), rolDesc);
                    if (resultado)
                    {
                        MessageBox.Show("Rol Inhabilitado");
                    }
                }
                else {
                    MessageBox.Show("El rol ya esta inhabilitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
                else
                {
                    MessageBox.Show("No podés inhabilitar si no elegís un rol y sólo un rol");
                }
            
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

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            this.Hide();
            FormProvider.AgregarRol.Show();
        }

        private void buttonHab_Click(object sender, EventArgs e)
        {
           Int32 selectedRowCount = dgvRoles.Rows.GetRowCount(DataGridViewElementStates.Selected);
           if (selectedRowCount > 0 && selectedRowCount < 2)
           {
                DataGridViewRow d = dgvRoles.SelectedRows[0];
                string rol = d.Cells[0].Value.ToString();
                string rolDesc = d.Cells[1].Value.ToString();
                if (!rolHabilitado(rolDesc))
                {
                    bool resultado = Conexion.executeProcedure("DATA_G.ACTIVAR_ROL", Conexion.generarArgumentos("@NOMBRE"), rolDesc);
                    if (resultado)
                    {
                        MessageBox.Show("Rol Habilitado");
                    }
                }
                else
                {
                    MessageBox.Show("El rol ya esta habilitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
                else
                {
                    MessageBox.Show("No podés habilitar si no elegís un rol y sólo un rol");
                }
            
        }

        public Boolean rolHabilitado(string rol)
        {
            string query = "SELECT DATA_G.ROL_HABILITADO ('" + rol + "') AS id"; 
                

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

