﻿using System;
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
    public partial class VerAeronaves : Form
    {
        public VerAeronaves()
        {
            InitializeComponent();
        }

        public void mostrarSeleccionar() {
                btnSeleccionar.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (btnSeleccionar.Visible)
            {
                FormProvider.GenerarViaje.Show();
            }
            else
            {
                FormProvider.MainMenu.Show();
            }
            
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

        private void dgvAeronaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void VerAeronaves_Load(object sender, EventArgs e)
        {
            btnSeleccionar.Visible = false;
            
            string query = "SELECT * FROM DATA_G.AERONAVE";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
            dgvAeronaves.Rows.Add(reader["FechaDeAlta"], reader["matricula"].ToString(), reader["Modelo"], reader["kg_disponibles"], reader ["Fabricante"], reader ["IdServicio"], reader["cantButacas"], reader ["idEstado"] ,reader ["BajaPorFueraDeServicio"], reader ["FechaDeFueraDeServicio"], reader ["FechaReinicioDeServicio"]);
            }
            reader.Close();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow d = null;
            string id = d.Cells[1].ToString();
            new AgregarAeronave(id, id).Show(); //mandar todos los parametros.

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
