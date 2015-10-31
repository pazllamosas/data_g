using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class ClientesConMasPuntosAcumuladosALaFecha : Form
    {
        public ClientesConMasPuntosAcumuladosALaFecha()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.ListadoEstadistico.Show();
        }
    }
}
