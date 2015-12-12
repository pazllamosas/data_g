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
                textBox11.Text = reader["IdCli"].ToString();
                dateTimePicker1.Value = (DateTime)reader["Fecha_Nac"];
                ElClienteExistia = true;
            }
            reader.Close();
        }

        private void generarCompra(int idComprador)
        {
            string medio;
            if (radioButton1.Checked)
            {
                medio = "Tarjeta";
            }
            else
            {
                medio = "Efectivo";
            }

            bool resultadoGenerarCompra = Conexion.executeProcedure("DATA_G.ALTA_COMPRA", Conexion.generarArgumentos("@monto", "@medio", "@idComprador", "@idVuelo"), 0, medio, idComprador, int.Parse(idVuelo));
            if (resultadoGenerarCompra)
            {

                string query = "SELECT * FROM DATA_G.COMPRA WHERE IdComprador = " + idComprador + " AND Monto = 0 AND NroVuelo = " + idVuelo + " AND MedioPago = '" + medio + "'";
                SqlDataReader reader = Conexion.ejecutarQuery(query);

                string idCompra;
                if (reader.Read())
                {
                    idCompra = reader["NroCompra"].ToString();
                }
                else
                {
                    MessageBox.Show("Hubo un fallo al generar tu compra.");
                    return;
                }
                reader.Close();


                if (idButacasOcupadas != null)
                {
                    foreach (string butaca in idButacasOcupadas) {
                        bool resultadoGenerarPasaje = Conexion.executeProcedure("DATA_G.ALTA_PASAJE", Conexion.generarArgumentos("@idCliente", "@idButaca", "@nroCompra", "@precio"), idComprador, int.Parse(butaca), int.Parse(idCompra), 100);
                        if (resultadoGenerarPasaje) {

                            string conseguirIdPasaje = "SELECT * FROM DATA_G.PASAJE WHERE IdButaca = " + butaca +" and NroCompra = " + idCompra + " and IdCli =" + idComprador+ " and NroVuelo = " + idVuelo;
                            SqlDataReader pasaje = Conexion.ejecutarQuery(conseguirIdPasaje);
                            
                            if (pasaje.Read()) {
                                string actualizarPrecioPasaje = "SELECT DATA_G.PRECIO_PASAJE (" + pasaje["Pasaje_Codigo"].ToString() +" ) AS codigo";
                                SqlDataReader pasajeActualizado = Conexion.ejecutarQuery(actualizarPrecioPasaje);
                                pasajeActualizado.Read();
                                pasajeActualizado.Close();
                            }
                            pasaje.Close();

                        } else
                        {
                            MessageBox.Show("Hubo un fallo al generar tu pasaje.");
                        }
                    }
                    
                }

                if (!string.IsNullOrEmpty(pesoEncomienda))
                {
                    bool resultadoGenerarEncomienda = Conexion.executeProcedure("DATA_G.ALTA_PAQUETE", Conexion.generarArgumentos("@nroCompra", "@kg", "@precio"), int.Parse(idCompra), int.Parse(pesoEncomienda), 100);
                    if (resultadoGenerarEncomienda) {
                        string conseguirIdPaquete = "SELECT * FROM DATA_G.PASAJE WHERE KG = " + pesoEncomienda + " and NroCompra = " + idCompra;
                        SqlDataReader paquete = Conexion.ejecutarQuery(conseguirIdPaquete);

                        if (paquete.Read())
                        {
                            string actualizarPrecioPaquete = "SELECT DATA_G.PRECIO_PAQUETE (" + paquete["IdPaquete"].ToString() + " ) AS id";
                            SqlDataReader paqueteActualizado = Conexion.ejecutarQuery(actualizarPrecioPaquete);
                            paqueteActualizado.Read();
                            paqueteActualizado.Close();
                        }
                        paquete.Close();
                    } else
                    {
                        MessageBox.Show("Hubo un fallo al generar tu encomienda.");
                    }
                }

                string conseguirCompraActualizada = "SELECT * FROM DATA_G.COMPRA WHERE NroCompra = " + idCompra;
                SqlDataReader compra = Conexion.ejecutarQuery(conseguirCompraActualizada);

                if (compra.Read())
                {
                    MessageBox.Show("Compra exitosa!\nPrecio final: $" + compra["Monto"] + "\nPNR: código acá");
                }
                compra.Close();


            } else {
                MessageBox.Show("Hubo un fallo al generar tu compra.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ElClienteExistia)
            {
                bool resultado = Conexion.executeProcedure("DATA_G.ALTA_CLIENTE", Conexion.generarArgumentos("@nombre", "@apellido", "@dni", "@direccion", "@telefono", "@mail", "@fechaNac"), textBox2.Text, textBox3.Text, int.Parse(textBox1.Text), textBox4.Text, int.Parse(textBox5.Text), textBox6.Text, DateTime.Parse(dateTimePicker1.Text));
                if (resultado)
                {
                    string query = "SELECT * FROM DATA_G.CLIENTE WHERE Dni = " + textBox1.Text + " AND Nombre = '" + textBox2.Text +"' AND Apellido = '"+textBox3.Text+ "' AND Direccion = '"+textBox4.Text+"' AND Telefono = "+textBox5.Text+" AND Mail ='" +textBox6.Text+ "'";
                    SqlDataReader reader = Conexion.ejecutarQuery(query);

                    if (reader.Read())
                    {
                        textBox11.Text = reader["IdCli"].ToString();
                        ElClienteExistia = true;
                        this.generarCompra(int.Parse(reader["IdCli"].ToString()));
                    }
                    reader.Close();

                }
                else
                {
                    MessageBox.Show("Hubo un fallo al registrarte como cliente y no se pudo guardar tu compra.");
                }
            }
            else
            {
                this.generarCompra(int.Parse(textBox11.Text));
            }
            
            //limpiar variables de clase
            pesoEncomienda = "";
            idButacasOcupadas = null;
            idVuelo = "";
            ElClienteExistia = false;
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private static string pesoEncomienda = "";
        private static List<string> idButacasOcupadas;
        private static string idVuelo ="";

        public void MostrarFormaDeCompra(string encomienda, List<string> idButacas, string IdVuelo)
        {
            pesoEncomienda = encomienda;
            idButacasOcupadas = idButacas;
            idVuelo = IdVuelo;

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
