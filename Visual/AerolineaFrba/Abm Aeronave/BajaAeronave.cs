using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class BajaAeronave : Form
    {
        public BajaAeronave()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cmbFueraServicio.SelectedIndex = -1;
            this.Hide();
            FormProvider.VerAeronaves.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(this.cmbFueraServicio.SelectedIndex == -1))
            {
                string matricula = txtMatricula.Text;
                string fabricante = txtFabricante.Text;
                Int32 estado = Convert.ToInt32(cmbFueraServicio.SelectedValue);

                string query = "SELECT DATA_G.GET_ID_AERONAVE ('" + matricula + "', '" + fabricante + "' ) AS id";

                SqlDataReader reader = Conexion.ejecutarQuery(query);
                reader.Read();
                Int32 idAeronave = Convert.ToInt32(reader["id"]);
                reader.Close();

                if (!(mismoEstado(idAeronave, estado)))
                {
                    bool resultado = Conexion.executeProcedure("DATA_G.CAMBIO_ESTADO", Conexion.generarArgumentos("@IDAERONAVE", "@IDESTADO"), idAeronave, estado);
                    if (resultado)
                    {
                        this.cmbFueraServicio.SelectedIndex = -1;
                        MessageBox.Show("Estado Cambiado");
                        FormProvider.VerAeronaves.CargarAeronave();
                    }
                }
                else 
                {
                    MessageBox.Show("Ya se encuentra en ese estado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccionar un estado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbFueraServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BajaAeronave_Load(object sender, EventArgs e)
        {
            cmbFueraServicio.ValueMember = "IdEstado";
            cmbFueraServicio.DisplayMember = "Descripcion";
            cmbFueraServicio.DataSource = Conexion.cargarTablaConsulta("DATA_G.GET_ESTADOS");
            this.cmbFueraServicio.SelectedIndex = -1;
        }

        public Boolean mismoEstado(Int32 aeronave, Int32 estado)
        {
            string query = "SELECT DATA_G.EXISTE_AERONAVE_ESTADO ('" + aeronave + "', '" + estado + "') AS id";
            
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void bajaAeronave(string matricula, string fabricante) 
        {
            txtMatricula.Text = matricula; 
            txtFabricante.Text = fabricante;
           
        }

        private void BajaAeronave_Load_1(object sender, EventArgs e)
        {
            cmbFueraServicio.ValueMember = "IdEstado";
            cmbFueraServicio.DisplayMember = "Descripcion";
            cmbFueraServicio.DataSource = Conexion.cargarTablaConsulta("DATA_G.GET_ESTADOS");
            this.cmbFueraServicio.SelectedIndex = -1;
        }

    }
}
