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
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void btnDestMasPasajesComprados_Click(object sender, EventArgs e)
        {
            new Listado_Estadistico.DestinosConMasPasajesComprados ().Show();
        }
        
        private void btnDestAeronavesMasVacias_Click(object sender, EventArgs e)
        {
            new Listado_Estadistico.DestinosConAeronavesMasVacias ().Show();
        }

        private void btnDestMasPasajesCancelados_Click(object sender, EventArgs e)
        {
            new Listado_Estadistico.DestinosConPasajesCancelados().Show();
        }

        private void btnCliMasPuntosAcumulados_Click(object sender, EventArgs e)
        {
            new Listado_Estadistico.ClientesConMasPuntosAcumuladosALaFecha().Show();
        }

        private void btnAeronavesMasDiasFueraServicio_Click(object sender, EventArgs e)
        {
            new Listado_Estadistico.AeronavesConMayorCantidadDeDiasFueraDeServicio().Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio.Menu().Show();
        }

        private void cmbAnioAConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
