using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class VerAeronaves : Form
    {
        public VerAeronaves()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.BajaAeronave.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.AgregarAeronave.Show();
        }
    }
}
