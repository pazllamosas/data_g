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
            FormProvider.IngresarDatosCompra.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.ConsultaMillas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.CanjeMillas.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.RegistroLlegadaDestino.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Devolucion.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.ListadoEstadistico.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.GenerarViaje.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerRutas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerAeronaves.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerRoles.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerCiudades.Show();
        }
    }
}
