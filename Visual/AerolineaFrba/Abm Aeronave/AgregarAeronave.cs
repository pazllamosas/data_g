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

        public void EditarAeronave(string matricula, string modelo, string espacioEncomienda, string fabricante, string servicio, string cantidadButacas, string ubicacion) //mandar todos los parametros para completar los texbox 
        {
            txtMatricula.Text = matricula; //asignar los parametros a los text
            txtModelo.Text = modelo;
            txtEspacioEncomienda.Text = espacioEncomienda;
            txtFabricante.Text = fabricante;
            txtCantButacas.Text = cantidadButacas;
            cmbTipoServicio.Text = servicio;
            cmbOrigen.Text = ubicacion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerAeronaves.Show();
        }

        private void AgregarAeronave_Load(object sender, EventArgs e)
        {
            //Conexion.cargarCmb("Nombre", "CIUDAD", cmbOrigen);
            //Conexion.cargarCmb("Descripcion", "TIPODESERVICIO", cmbTipoServicio);

            cmbOrigen.ValueMember = "CodigoCiudad";
            cmbOrigen.DisplayMember = "Nombre";
            cmbOrigen.DataSource = Conexion.cargarTablaConsulta("DATA_G.GET_CIUDADES");

            cmbTipoServicio.ValueMember = "IdServicio";
            cmbTipoServicio.DisplayMember = "Descripcion";
            cmbTipoServicio.DataSource = Conexion.cargarTablaConsulta("DATA_G.GET_SERVICIO");

            this.txtEspacioEncomienda.Clear();
            this.txtCantButacas.Clear();
            this.txtModelo.Clear();
            this.txtFabricante.Clear();
            this.txtMatricula.Clear();
            this.cmbTipoServicio.SelectedIndex = -1;
            this.cmbOrigen.SelectedIndex = -1;

        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validacion();
        }

        private void cmbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validacion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           if (this.validacion())
           {
            double kg_disponibles = double.Parse(txtEspacioEncomienda.Text);

            double cantButacas = double.Parse(txtCantButacas.Text);

            string modelo = txtModelo.Text;

            string fabricante = txtFabricante.Text;

            string matricula = txtMatricula.Text;

            Int32 descripcionServicio = Convert.ToInt32(cmbTipoServicio.SelectedValue);

            Int32 origen = Convert.ToInt32(cmbOrigen.SelectedValue);

            if (this.validacionDatos(matricula, modelo, kg_disponibles, fabricante, descripcionServicio, cantButacas))
            {


                bool resultado = Conexion.executeProcedure("DATA_G.CREAR_AERONAVE", Conexion.generarArgumentos("@MATRICULA", "@MODELO", "@KGDISP",
                 "@FABRICANTE", "@IDSERV", "@CANTBUTACAS", "@UBICACION"), matricula, modelo, kg_disponibles, fabricante, descripcionServicio, cantButacas, origen);


                if (resultado)
                {
                    MessageBox.Show("Aeronave creada exitosamente");

                    this.txtEspacioEncomienda.Clear();
                    this.txtCantButacas.Clear();
                    this.txtModelo.Clear();
                    this.txtFabricante.Clear();
                    this.txtMatricula.Clear();
                    this.cmbTipoServicio.SelectedIndex = -1;
                    this.cmbOrigen.SelectedIndex = -1;
                }
            }
        }
           else
            {
                MessageBox.Show("Completar todos los campos");
            }
        }



          

        private void txtCantButacasPasillo_TextChanged(object sender, EventArgs e)
        {
            bool resultado = funciones.permiteNumeros(txtCantButacas.Text);
            if (!resultado)
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnGuardar.Enabled = validacion(); 
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validacion();
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validacion();
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
            if (this.cmbOrigen.SelectedIndex == -1)
                return false;
           return true;
             }

        private bool validacionDatos(string matricula, string modelo, double kg_disponibles, string fabricante, Int32 descripcionServicio, double cantButacas)
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
            if (!matriculaValida(matricula))
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

        private void txtEspacioEncomienda_TextChanged(object sender, EventArgs e)
        {
            bool resultado = funciones.permiteNumeros(txtEspacioEncomienda.Text);
            if (!resultado)
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            btnGuardar.Enabled = validacion();
        }

        private void txtFabricante_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validacion();
        }

    }
}
