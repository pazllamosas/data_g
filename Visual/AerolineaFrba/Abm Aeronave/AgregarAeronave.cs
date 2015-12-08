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

        public AgregarAeronave(string matricula, string modelo, string espacioEncomienda, string fabricante, string servicio, string cantidadButacas) //mandar todos los parametros para completar los texbox 
        {
            InitializeComponent();
            this.txtMatricula.Text = matricula; //asignar los parametros a los text
            this.txtModelo.Text = modelo;
            this.txtEspacioEncomienda.Text = espacioEncomienda;
            this.txtFabricante.Text = fabricante;
            this.txtCantButacas.Text = cantidadButacas;

            int i;                                 //buscar como comparar el parametro con el combo box
            int cantidad = int.Parse(cmbOrigen.Size.ToString());
            for (i = 0; i < cantidad; i++)    
            {
                cmbOrigen.SelectedIndex = i;
             //   if (cmbOrigen.Text == nombre) //nombre es el parametro
                    break;
            }

            int j;
            int cantidad2 = int.Parse(this.cmbTipoServicio.Size.ToString());
            for (j = 0; j < cantidad2; j++)
            {
                this.cmbTipoServicio.SelectedIndex = j;
                if (cmbTipoServicio.Text == servicio)
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

            double kg_disponibles = double.Parse(txtEspacioEncomienda.Text);

            string fabricante = txtFabricante.Text;

            Int32 descripcionServicio = (Int32)cmbTipoServicio.SelectedValue;

            double cantButacas = double.Parse(txtCantButacas.Text);
            
            string query = "SELECT DATA_G.GET_ID_SERVICIO ('" + descripcionServicio + "')";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            string idServicio = reader["id"].ToString();
            reader.Close();
            query = "DATA_G.CREAR_AERONAVE ('" + matricula + "', " + "'" + modelo + "', " + kg_disponibles + ", '" +
                                             fabricante + "', '" + idServicio + "', " + cantButacas + ")";
            
            reader = Conexion.ejecutarQuery(query);
            reader.Close();

            if (this.validacionDatos(matricula, modelo, kg_disponibles, fabricante, descripcionServicio, cantButacas))
            {
                bool resultado = Conexion.executeProcedure("DATA_G.CREAR_AERONAVE", Conexion.generarArgumentos("@matricula", "@modelo", "@kg_disponibles",
                    "@fabricante", "@descripcionServicio", "@cantButacas"), matricula, modelo, kg_disponibles, fabricante, descripcionServicio, cantButacas);

                if (resultado)
                {
                    MessageBox.Show("Ruta creada exitosamente");

                    this.txtMatricula.Clear();
                    this.txtModelo.Clear();
                    this.txtEspacioEncomienda.Clear();
                    this.txtFabricante.Clear();
                    this.txtCantButacas.Clear();
                    this.cmbTipoServicio.SelectedIndex = -1;
                   
                }

            }

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


        private void txtEspacioEncomienda_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool resultado = funciones.permiteNumeros(txtEspacioEncomienda.Text);
            if (!resultado)
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCantButacas_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool resultado = funciones.permiteNumeros(txtCantButacas.Text);
            if (!resultado)
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool validacion()
        {
            if (this.txtMatricula.Text.Trim() == "")
                return false;
            if (this.txtModelo.Text.Trim() == "")
                return false;
            if (this.txtEspacioEncomienda.Text.Trim() == "")
                return false;
            if (this.txtFabricante.Text.Trim() == "")
                return false;
            if (this.txtCantButacas.Text.Trim() == "")
                return false;
            if (this.cmbTipoServicio.SelectedIndex == -1)
                return false;
            return true;
             }

        private bool validacionDatos(string matricula, string modelo, double kg_disponibles, string fabricante, int descripcionServicio, double cantButacas)
        {
            if (kg_disponibles == 0)
            {
                MessageBox.Show("El el espacio para las encomiendas no puede ser 0");
                this.txtEspacioEncomienda.Clear();
                return false;
            }
            if (cantButacas == 0)
            {
                MessageBox.Show("La cantidad de butacas no puede ser 0");
                this.txtCantButacas.Clear();
                return false;
            }
            if (matriculaValida(matricula))
            {
                this.txtMatricula.Clear();
                return false;
            }
            return true;
        }

        public Boolean matriculaValida(string matricula)
        {
            string query = "SELECT DATA_G.EXISTE_MATRICULA ('" + matricula + "' ) AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta == 0)
            {

                return true;
            }
            else
            {
                MessageBox.Show("La matricula ya existe");
                return false;
            }
        }

    }
}
