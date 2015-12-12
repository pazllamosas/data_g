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
            if (radioButton1.Checked == true)
            {
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox10.Enabled = true;
                label11.Enabled = true;
                label8.Enabled = true;
                label9.Enabled = true;
                label10.Enabled = true;
            }
            else
            {
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                label11.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                label10.Enabled = false;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private static bool ElClienteExistia = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DATA_G.CLIENTE WHERE Dni = " + textBox1.Text;
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            if (reader.Read())
            {
                textBox2.Text = reader["Nombre"].ToString();
                textBox3.Text = reader["Apellido"].ToString();
                textBox4.Text = reader["Direccion"].ToString();
                textBox5.Text = reader["Telefono"].ToString();
                textBox6.Text = reader["Mail"].ToString();
                dateTimePicker1.Value = (DateTime)reader["Fecha_Nac"];
                ElClienteExistia = true;
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (int.Parse(pesoEncomienda) > 0 && !string.IsNullOrEmpty(pesoEncomienda))
            //{
            //    string query = "SELECT DATA_G.PRECIO_PASAJE (" + +" ) AS codigo";

            //    SqlDataReader reader = Conexion.ejecutarQuery(query);
            //    reader.Read();
            //    int respuesta = int.Parse(reader["id"].ToString());
            //    reader.Close();
            //}
            

            MessageBox.Show("Compra exitosa!\nPrecio final: $xxxx\nPNR: código acá");
            if (!ElClienteExistia)
            {
                bool resultado = Conexion.executeProcedure("DATA_G.ALTA_CLIENTE", Conexion.generarArgumentos("@nombre", "@apellido", "@dni", "@direccion", "@telefono", "@mail", "@fechaNac"), textBox2.Text, textBox3.Text, int.Parse(textBox1.Text), textBox4.Text, int.Parse(textBox5.Text), textBox6.Text, DateTime.Parse(dateTimePicker1.Text));
                if (!resultado)
                {
                    MessageBox.Show("Hubo un fallo al registrarte como cliente. ¡Perdón! Igual tu compra fue registrada.");
                }
            }

            //limpiar variables de clase
            pesoEncomienda = "";
            idButacasOcupadas = null;
            ElClienteExistia = false;
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private static string pesoEncomienda = "";
        private static List<string> idButacasOcupadas = null;

        public void MostrarFormaDeCompra(string encomienda, List<string> idButacas)
        {
            pesoEncomienda = encomienda;
            idButacasOcupadas = idButacas;

            if (FormProvider.Login.loginMode == "invitado")
            {
                this.deshabilitarEfectivo();
            }
            else
            {
                this.habilitarEfectivo();
            }

        }
    }
}
