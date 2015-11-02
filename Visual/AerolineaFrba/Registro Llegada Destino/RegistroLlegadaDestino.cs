using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
