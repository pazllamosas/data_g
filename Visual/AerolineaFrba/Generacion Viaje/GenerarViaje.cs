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
            FormProvider.AgregarRuta.Show();
            //entro desde acá puede tocar boton seleccionar
        }

        private void btnAgregarAeronave_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerAeronaves.Show();
            //entro desde acá puede tocar boton seleccionar
        }
    }
}
