using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Inicio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void deslogearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Comprar = new Compra.IngresarDatosCompra();
            Comprar.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ConsultaMillas = new Consulta_Millas.ConsultaMillas();
            ConsultaMillas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var CanjearMillas = new Canje_Millas.CanjeMillas();
            CanjearMillas.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RegistroLlegada = new Registro_Llegada_Destino.RegistroLlegadaDestino();
            RegistroLlegada.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Devolucion = new Devolucion.Devolucion();
            Devolucion.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Listado_Estadistico.ListadoEstadistico().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Generacion_Viaje.GenerarViaje().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var abmRutas = new Abm_Ruta.VerRutas();
            abmRutas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var abmAeronave = new Abm_Aeronave.VerAeronaves();
            abmAeronave.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var abmRoles = new Abm_Rol.VerRoles();
            abmRoles.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var abmCiudades = new Abm_Ciudad.VerCiudades();
            abmCiudades.Show();
        }
    }
}
