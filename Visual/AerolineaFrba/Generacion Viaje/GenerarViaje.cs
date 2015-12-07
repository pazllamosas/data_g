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
            FechaSalida = dtmFechaSalida.Text;
            FechaLlegada = dtmFechaLlegada.Text;
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
            
            DataTable aeronaves = filtrarAeronaves(dtmFechaSalida.Text, dtmFechaLlegada.Text);
            this.dgvVerViaje.DataSource = aeronaves;
        }
        }

    }

