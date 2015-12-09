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

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class RegistroLlegadaDestino : Form
    {
        public RegistroLlegadaDestino()
        {
            InitializeComponent();
        }

        public bool validateArrival()
        {
            if (!string.IsNullOrEmpty(txtMatricula.Text) && !string.IsNullOrEmpty(cmbAeropuertoOrigen.Text) && !string.IsNullOrEmpty(cmbAeropuertoDestino.Text))
            {
                return true;
            }
            else {
                return false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validateArrival();
        }

        private void cmbAeropuertoOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validateArrival();
        }

        private void cmbAeropuertoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validateArrival();
        }

        private void RegistroLlegadaDestino_Load(object sender, EventArgs e)
        {
            Conexion.cargarCmb("Nombre", "CIUDAD", cmbAeropuertoOrigen);
            Conexion.cargarCmb("Nombre", "CIUDAD", cmbAeropuertoDestino);
            btnGuardar.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            
            int fallo = 0;

            string matricula = txtMatricula.Text;

            string ciudadOrigen = cmbAeropuertoOrigen.Text;

            string ciudadDestino = cmbAeropuertoDestino.Text;

            string fechaLlegada = txtFecha.Text;

            string[] componentesFecha = fechaLlegada.Split('/');

            if (componentesFecha.Length > 3) { MessageBox.Show("coloco mal la fecha, tiene más de dos /"); fallo = 1; }

            if (1 > int.Parse(componentesFecha[0]) || int.Parse(componentesFecha[0]) > 31) { MessageBox.Show("coloco mal la fecha, coloco mal el día"); fallo = 1; }

            if (1 > int.Parse(componentesFecha[1]) || int.Parse(componentesFecha[1]) > 12) { MessageBox.Show("coloco mal la fecha, coloco mal el mes"); fallo = 1; }

            if (1950 > int.Parse(componentesFecha[2]) || int.Parse(componentesFecha[2]) > DateTime.Today.Year) { MessageBox.Show("coloco mal la fecha, coloco mal el año"); fallo = 1; }

            string hora = txtHora.Text;
            string minutos = txtMinutos.Text;

            if (0 > int.Parse(hora) || int.Parse(hora) > 23) { MessageBox.Show("coloco mal la hora, debe estar entre 0 y 23"); fallo = 1; }
            if (0 > int.Parse(minutos) || int.Parse(minutos) > 59) { MessageBox.Show("coloco mal los minutos, debe estar entre 0 y 59"); fallo=1; }


            if (fallo == 1) { MessageBox.Show("cargo mal los datos, vuelva a intentarlo"); }
            else
            {
                //string query = ""; necesito querry para comparar si existio el vuelo (matricula correcta, ciudad origen y destino correcta y dia fecha estimada llegada = dia ingresado) 

                //SqlDataReader reader = Conexion.ejecutarQuery(query);
                //reader.Read();
                //bool existe = reader["bool"];
                //reader.Close();
                bool existe = true;
                if (!existe) { MessageBox.Show("No existe el vuelo ingresado"); }
                else 
                {

                    string query1 = "SELECT * FROM DATA_G.AERONAVE";

                    SqlDataReader reader1 = Conexion.ejecutarQuery(query1);

                    string idServicio = "fallo";
                    string fabricante = "fallo";
                    string cantidadButacas = "fallo";
                    string kgDisponibles = "fallo";

                    while (reader1.Read())
                    {
                        if (txtMatricula.Text == (reader1["Matricula"].ToString()))
                        {
                             idServicio = reader1["IdServicio"].ToString();
                             fabricante = reader1["Fabricante"].ToString();
                             cantidadButacas = reader1["CantButacas"].ToString();
                             kgDisponibles = reader1["KG_Disponibles"].ToString();

                        }
                    }
                    reader1.Close();

                    string query2 = "SELECT Descripcion FROM DATA_G.TIPODESERVICIO WHERE idServicio = '" + idServicio + "'";

                    SqlDataReader reader2 = Conexion.ejecutarQuery(query2);
                    reader2.Read();
                    string tipoServicio = reader2["Descripcion"].ToString();
                    reader2.Close();

                    txtTipoServicio.Text = tipoServicio;
                    txtFabricante.Text = fabricante;
                    txtCantButacas.Text = cantidadButacas;
                    txtCapacidadEncomienda.Text = kgDisponibles;

                    btnGuardar.Enabled = true;

                }
               
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            Int32 origen = Convert.ToInt32(cmbAeropuertoOrigen.SelectedValue);
            Int32 destino = Convert.ToInt32(cmbAeropuertoDestino.SelectedValue);
            string fabricante = txtFabricante.Text;
            string fechaLlegada = txtFecha.Text;
            string[] componentesFecha = fechaLlegada.Split('/');

            string query3 = "SELECT NroVuelo FROM DATA_G.VUELO AS vuelo, DATA_G.AERONAVE AS aeronave, DATA_G.RUTA AS ruta, DATA_G.CIUDAD AS ciudad, DATA_G.CIUDAD AS ciudad2 WHERE aeronave.matricula = '" + matricula + "' AND aeronave.Fabricante = '" + fabricante + "' AND vuelo.IdAeronave = aeronave.IdAeronave AND (ciudad.Nombre = ' " + origen + "' AND (ruta.Origen = ciudad.CodigoCiudad) ) AND (ciudad2.Nombre = ' " + destino + "' AND (ruta.Destino = ciudad2.codigoCiudad) ) AND ruta.IdRuta = vuelo.IdRuta AND aeronave.IdServicio = ruta.IdServicio";
            SqlDataReader reader3 = Conexion.ejecutarQuery(query3);
            reader3.Read();
            string NroVuelo = reader3["NroVuelo"].ToString();
            reader3.Close();
            string fechallegada = txtFecha.Text;
            string hora = txtHora.Text;
            string minutos = txtMinutos.Text;

            string timeofday = "am";
            if (int.Parse(hora) > 12)
            {
            timeofday = "pm";
            hora = (int.Parse(hora) - 12).ToString();
            }

            string query4 = "DATA_G.REGISTRO_LLEGADA('"+NroVuelo+"', '"+ fechallegada+" "+hora+":"+minutos+":00:000"+" "+timeofday+"', '" + destino +"')";
        
        }
    }
}
