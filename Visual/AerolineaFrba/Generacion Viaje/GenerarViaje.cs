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
            new Inicio.Menu().Show();
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            new Abm_Ruta.VerRutas().Show();
            //entro desde acá puede tocar boton seleccionar
        }

        private void btnAgregarAeronave_Click(object sender, EventArgs e)
        {
             new Abm_Aeronave.VerAeronaves().Show();
            //entro desde acá puede tocar boton seleccionar
        }
    }
}
