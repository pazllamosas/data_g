using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class GenerarViaje : Form
    {
        

        public GenerarViaje()
        {
            InitializeComponent();
        }

        public void EditarGenerarViaje(string matricula, string modelo, string espacioEncomienda, string fabricante, string servicio, string cantidadButacas, string ubicacion) //mandar todos los parametros para completar los texbox 
        {
          // dgvAeronave txtMatricula.Text = matricula; //asignar los parametros a los text
          // dgvAeronave txtModelo.Text = modelo;
          // dgvAeronave txtEspacioEncomienda.Text = espacioEncomienda;
          // dgvAeronave txtFabricante.Text = fabricante;
           //dgvAeronave txtCantButacas.Text = cantidadButacas;
           //dgvAeronave cmbTipoServicio.Text = servicio;
            dgvAeronave.Rows.Add(matricula, modelo, espacioEncomienda, fabricante, servicio, cantidadButacas, ubicacion);
        }

        public void EditarGenerarViaje2(string codigo, string precioEncomienda, string precioPasaje, string servicio, string ciudadOrigen, string ciudadDestino)
        { 
            dgvRuta.Rows.Add(codigo, precioEncomienda, precioPasaje, servicio, ciudadOrigen, ciudadDestino);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerRutas.Show();
            FormProvider.VerRutas.mostrarSeleccionar();
            //entro desde acá puede tocar boton seleccionar
        }

        private void btnAgregarAeronave_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerAeronaves.Show();
            FormProvider.VerAeronaves.mostrarSeleccionar();
            //entro desde acá puede tocar boton seleccionar
        }

        private DataTable filtrarAeronaves(string FechaSalida, string FechaLlegada)
        {
           
            //HAY ERROR
            FechaSalida = txtFechaSalida.Text;
            FechaLlegada = txtFechaLlegada.Text;
            string query = "SELECT  FROM DATA_G.AERONAVE WHERE (fecha >= " + FechaSalida + " AND fecha <= " + FechaLlegada + " ) AS id";
            DataTable tablaAeronaves = Conexion.cargarTablaConsulta(query);
            
            return tablaAeronaves;
           
        }

        private void GenerarViaje_Load(object sender, EventArgs e)
        {

        }

        private void dgvVerViaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataTable aeronaves = filtrarAeronaves(txtFechaSalida.Text, txtFechaLlegada.Text);
            this.dgvAeronave.DataSource = aeronaves;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string fechaSalida = txtFechaSalida.Text;

            string[] componentesFecha = fechaSalida.Split('-');

            if (componentesFecha.Length > 3) { MessageBox.Show("coloco mal la fecha de salida, tiene más de dos -"); }

            if (1 > int.Parse(componentesFecha[2]) || int.Parse(componentesFecha[2]) > 31) { MessageBox.Show("coloco mal la fecha de salida, coloco mal el día"); }

            if (1 > int.Parse(componentesFecha[1]) || int.Parse(componentesFecha[1]) > 12) { MessageBox.Show("coloco mal la fecha de salida, coloco mal el mes"); }

            if (1950 > int.Parse(componentesFecha[0]) || int.Parse(componentesFecha[0]) > DateTime.Today.Year) { MessageBox.Show("coloco mal la fecha de salida, coloco mal el año"); }

            string fechaLlegada = txtFechaLlegada.Text;

            string[] componentesFecha2 = fechaLlegada.Split('-');

            if (componentesFecha2.Length > 3) { MessageBox.Show("coloco mal la fecha de Llegada, tiene más de dos -"); }

            if (1 > int.Parse(componentesFecha2[2]) || int.Parse(componentesFecha2[2]) > 31) { MessageBox.Show("coloco mal la fecha de Llegada, coloco mal el día"); }

            if (1 > int.Parse(componentesFecha2[1]) || int.Parse(componentesFecha2[1]) > 12) { MessageBox.Show("coloco mal la fecha de Llegada, coloco mal el mes"); }

            if (1950 > int.Parse(componentesFecha2[0]) || int.Parse(componentesFecha2[0]) > DateTime.Today.Year) { MessageBox.Show("coloco mal la fecha de Llegada, coloco mal el año"); }


        }
        }

    }

