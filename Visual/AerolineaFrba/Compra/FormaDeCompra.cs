using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class FormaDeCompra : Form
    {
        public FormaDeCompra()
        {
            InitializeComponent();
        }

        public void deshabilitarEfectivo()
        {
            radioButton2.Enabled = false;
        }

        public void habilitarEfectivo()
        {
            radioButton2.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.IngresarDatosCompra.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) { 
                
            }
        }
    }
}
