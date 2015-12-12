using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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

        public void EditarGenerarViaje(string matricula, string modelo, string espacioEncomienda, string fabricante, string servicio, string cantidadButacas, string ubicacion, string bajaFueraServ, string fechaReinicioServ) //mandar todos los parametros para completar los texbox 
        {
          // dgvAeronave txtMatricula.Text = matricula; //asignar los parametros a los text
          // dgvAeronave txtModelo.Text = modelo;
          // dgvAeronave txtEspacioEncomienda.Text = espacioEncomienda;
          // dgvAeronave txtFabricante.Text = fabricante;
           //dgvAeronave txtCantButacas.Text = cantidadButacas;
           //dgvAeronave cmbTipoServicio.Text = servicio;
            dgvAeronave.Rows.Add(matricula, modelo, espacioEncomienda, fabricante, servicio, cantidadButacas, ubicacion, bajaFueraServ, fechaReinicioServ);
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

        public void VaciardgvAeronave()
        {
            dgvAeronave.Rows.Clear();
        }

        public void VaciardgvRuta()
        {
            dgvRuta.Rows.Clear();
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.VaciardgvRuta();
            FormProvider.VerRutas.Show();
            FormProvider.VerRutas.CargarRutas();
            FormProvider.VerRutas.mostrarSeleccionar();
            //entro desde acá puede tocar boton seleccionar
        }

        private void btnAgregarAeronave_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.VaciardgvAeronave();
            FormProvider.VerAeronaves.Show();
            FormProvider.VerAeronaves.CargarAeronave();
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
            int fallo = 0;
            string fechaSalida = txtFechaSalida.Text;

            string[] componentesFecha = fechaSalida.Split('-');

            if (componentesFecha.Length > 3) { MessageBox.Show("coloco mal la fecha de salida, tiene más de dos -"); fallo = 1; }
            if (componentesFecha.Length < 3) { MessageBox.Show("coloco mal la fecha de salida, tiene menos de dos -"); fallo = 1; }
            else
            {
                if (1 > int.Parse(componentesFecha[2]) || int.Parse(componentesFecha[2]) > 31) { MessageBox.Show("coloco mal la fecha de salida, coloco mal el día"); fallo = 1; }

                if (1 > int.Parse(componentesFecha[1]) || int.Parse(componentesFecha[1]) > 12) { MessageBox.Show("coloco mal la fecha de salida, coloco mal el mes"); fallo = 1; }

                if (1950 > int.Parse(componentesFecha[0]) || int.Parse(componentesFecha[0]) < DateTime.Today.Year) { MessageBox.Show("coloco mal la fecha de salida, coloco mal el año"); fallo = 1; }
            }
                string fechaLlegada = txtFechaLlegada.Text;

                string[] componentesFecha2 = fechaLlegada.Split('-');
            
             if (componentesFecha2.Length > 3) { MessageBox.Show("coloco mal la fecha de Llegada, tiene más de dos -"); fallo = 1; }
             if (componentesFecha.Length < 3) { MessageBox.Show("coloco mal la fecha de salida, tiene menos de dos -"); fallo = 1; }
             else
             {
                if (1 > int.Parse(componentesFecha2[2]) || int.Parse(componentesFecha2[2]) > 31 || int.Parse(componentesFecha2[2]) <= int.Parse(componentesFecha[2]) || (int.Parse(componentesFecha2[2]) - int.Parse(componentesFecha[2])) != 1) { MessageBox.Show("coloco mal la fecha de Llegada, coloco mal el día"); fallo = 1; }

                if (1 > int.Parse(componentesFecha2[1]) || int.Parse(componentesFecha2[1]) > 12 || int.Parse(componentesFecha2[1]) < int.Parse(componentesFecha[1]) || int.Parse(componentesFecha2[1]) < int.Parse(componentesFecha[1]) || int.Parse(componentesFecha2[1]) > int.Parse(componentesFecha[1])) { MessageBox.Show("coloco mal la fecha de Llegada, coloco mal el mes"); fallo = 1; }

                if (1950 > int.Parse(componentesFecha2[0]) || int.Parse(componentesFecha2[0]) < DateTime.Today.Year || int.Parse(componentesFecha2[0]) < int.Parse(componentesFecha[0]) || int.Parse(componentesFecha2[0]) > int.Parse(componentesFecha[0])) { MessageBox.Show("coloco mal la fecha de Llegada, coloco mal el año"); fallo = 1; }
             }

            string servicioAeronave = "fallo";
            string servicioRuta = "fallo2";
            string bajaFueraServ = "True";
            string fechaReinicioServ = "fallo";
            string matricula = "null";
            string codigoRuta = "fallo2";

            Int32 selectedRowCount = dgvAeronave.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvAeronave.SelectedRows[0];
                servicioAeronave = d.Cells[4].Value.ToString();
                bajaFueraServ = d.Cells[7].Value.ToString();
                fechaReinicioServ = d.Cells[8].Value.ToString();
                matricula = d.Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("No podés editar si no elegís una aeronave y sólo una aeronave.");
                fallo = 1;
            }
            Int32 selectedRowCount2 = dgvRuta.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount2 > 0 && selectedRowCount2 < 2)
            {
                DataGridViewRow d = dgvRuta.SelectedRows[0];
                servicioRuta = d.Cells[3].Value.ToString();
                codigoRuta = d.Cells[0].Value.ToString();

            }
            else
            {
                MessageBox.Show("No podés editar si no elegís una ruta y sólo una ruta.");
                fallo = 1;
            }

            if (!(servicioRuta == servicioAeronave)) { MessageBox.Show("El servicio de ruta y de aeronave deben ser iguales"); fallo = 1; }

            DateTime fechaVueloSalida = DateTime.ParseExact(fechaSalida, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            if (fechaReinicioServ != "")
            {
                DateTime fechaaeronaveReinicioServ = DateTime.ParseExact(fechaReinicioServ, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                if (bajaFueraServ == "True" && fechaaeronaveReinicioServ >= fechaVueloSalida) { MessageBox.Show("la aeronave se encuentra fuera de servicio en esa fecha"); fallo = 1; }
            }
            if (fallo != 1)
            {
                DateTime fechaVueloAnterior1 = DateTime.ParseExact(fechaLlegada, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                fechaVueloAnterior1 = fechaVueloAnterior1.AddDays(3);
                DateTime fechaVueloAnterior2 = DateTime.ParseExact(fechaLlegada, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                fechaVueloAnterior2 = fechaVueloAnterior2.AddDays(-3);
                string fechaVueloAnteriorS1 = fechaVueloAnterior1.ToString("yyyy-MM-dd");
                string fechaVueloAnteriorS2 = fechaVueloAnterior2.ToString("yyyy-MM-dd");

                string query = "SELECT TOP 1 fechallegada FROM DATA_G.AERONAVE aeronave, DATA_G.VUELO vuelo WHERE (aeronave.Matricula = '" + matricula + "') AND (aeronave.IdAeronave = vuelo.IdAeronave) AND (vuelo.FechaEstimadaLlegada < '" + fechaLlegada + "')  AND  (vuelo.FechaEstimadaLlegada > '" + fechaVueloAnteriorS2 + "') OR ( (vuelo.FechaEstimadaLlegada > '" + fechaLlegada + "') AND (vuelo.FechaEstimadaLlegada < '" + fechaVueloAnteriorS1 + "') ) ORDER BY fechallegada desc";
                SqlDataReader reader = Conexion.ejecutarQuery(query);
                if (reader.Read())
                {
                    MessageBox.Show("No hay dos días de diferencias entre la llegada del vuelo anterior y la salida del elegido o viceversa"); fallo = 1;
                }
                reader.Close();
            }

            if (fallo == 1) { MessageBox.Show("cargo mal los datos y/o no son compatibles aeronave y ruta, vuelva a intentarlo"); }
            else
            {
                string query2 = "SELECT  aeronave.IdAeronave, ruta.IdRuta FROM DATA_G.AERONAVE aeronave, DATA_G.RUTA ruta WHERE aeronave.Matricula = '" + matricula + "' AND ruta.Codigo = '" + codigoRuta + "' AND ruta.IdServicio = aeronave.IdServicio";
                SqlDataReader reader2 = Conexion.ejecutarQuery(query2);
                if (reader2.Read())
                {
                    string IdAeronave = reader2["IdAeronave"].ToString();
                    string IdRuta = reader2["IdRuta"].ToString();

                    //string query3 = "DATA_G.CREAR_VUELO('', '"+fechaLlegada+"', '"+fechaSalida+"', '"+IdRuta+"', '"+IdAeronave+"')";
                    //SqlDataReader reader3 = Conexion.ejecutarQuery(query3);
                    //En teoria lo de arriba no es, tendría que ser lo de abajo por ser un procedure
                    
                    bool resultadoGenerarvuelo = Conexion.executeProcedure("DATA_G.CREAR_VUELO", Conexion.generarArgumentos("@FECHALLEGADAESTIMADA", "@FECHALLEGADA", "@FECHASALIDA", "@RUTA", "@AERONAVE"), fechaLlegada, "" , fechaSalida, int.Parse(IdRuta), int.Parse(IdAeronave));
                    if (resultadoGenerarvuelo) { MessageBox.Show("Se generó el vuelo correctamente"); }
                    else { MessageBox.Show("no se ejecuto la operación de generar la aeronave"); }
                }
                else { MessageBox.Show("no se encontro una Aeronave y Ruta compatible"); }
                //generar query para agregar el vuelo
                reader2.Close();
                
            }
        }
        }

    }

