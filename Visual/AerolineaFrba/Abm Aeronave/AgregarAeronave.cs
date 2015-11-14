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
    public partial class AgregarAeronave : Form
    {

        public AgregarAeronave()
        {
            InitializeComponent();
        }

        public AgregarAeronave(string matricula, string modelo) //mandar todos los parametros para completar los texbox 
        {
            InitializeComponent();
            this.txtMatricula.Text = matricula; //asignar los parametros a los text
            
            int i;                                 //buscar como comparar el parametro con el combo box
            int cantidad = int.Parse(cmbOrigen.Size.ToString());
            for (i = 0; i < cantidad; i++)    
            {
                cmbOrigen.SelectedIndex = i;
                if (cmbOrigen.Text == nombre) //nombre es el parametro
                    break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerAeronaves.Show();
        }

        private void AgregarAeronave_Load(object sender, EventArgs e)
        {
            Conexion.cargarCmb("Nombre", "CIUDAD", cmbOrigen);
            Conexion.cargarCmb("Descripcion", "TIPODESERVICIO", cmbTipoServicio);
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string matricula = txtMatricula.Text;

            string modelo = txtModelo.Text;

            string kg_disponibles = txtEspacioEncomienda.Text;

            string fabricante = txtFabricante.Text;

            string descripcionServicio = cmbTipoServicio.Text;

            string cantButacas = txtCantButacas.Text;
            
            string query = "SELECT DATA_G.GET_ID_SERVICIO ('" + descripcionServicio + "')";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            string idServicio = reader["id"].ToString();
            reader.Close();
            query = "DATA_G.CREAR_AERONAVE ('" + matricula + "', " + "'" + modelo + "', " + kg_disponibles + ", '" +
                                             fabricante + "', '" + idServicio + "', " + cantButacas + ")";
            
            reader = Conexion.ejecutarQuery(query);
            reader.Close();
        }

        private void txtCantButacasPasillo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
