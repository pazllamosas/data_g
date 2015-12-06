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
        DataTable aeronaves;

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

        private DataTable filtrarAeronaves(string matricula)
        {
           
            DataTable tablaAeronaves = aeronaves;
            string FechaSalida = dtmFechaSalida.Text;
            string FechaLlegada = dtmFechaLlegada.Text;
            string query = "SELECT COUNT (*) FROM DATA_G.AERONAVE WHERE (fecha >= #" + FechaSalida + "# AND fecha <= #" + FechaLlegada + " ) AS id";
            //DataTable tablaAeronaves = Conexion.cargarTablaConsulta(query);
            
            return tablaAeronaves;
           
        }

    }
}
