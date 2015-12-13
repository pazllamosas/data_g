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
            this.LimpiarFormulario();
            this.Hide();
            FormProvider.IngresarDatosCompra.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                label11.Enabled = true;
                label8.Enabled = true;
                label9.Enabled = true;
                dateTimePicker2.Enabled = true;
                comboBox1.Enabled = true;
                textBox9.Enabled = true;
            }
            else
            {
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                dateTimePicker2.Enabled = false;
                label11.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                comboBox1.Enabled = false;
                textBox9.Enabled = false;
            }
            validarCamposCompra();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private static bool ElClienteExistia = false;
        private static bool LaTarjetaExistia = false;

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

            validarCamposCompra();
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

                if (!LaTarjetaExistia && radioButton1.Checked)
                {
                    string fecha = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    DateTime dt = DateTime.Parse(fecha);

                    bool resultadoPagarConTarjeta = Conexion.executeProcedure(
                        "DATA_G.COMPRA_TARJETA", 
                        Conexion.generarArgumentos("@comprador", "@tarjetanumero", "@tarjetacodigo", "@tarjetavencimiento", "@tipotarjeta", "@cuotas", "@mediopago", "@nroCompra"),
                        int.Parse(textBox11.Text), int.Parse(textBox7.Text), textBox8.Text, dt, int.Parse(comboBox1.Text), int.Parse(textBox9.Text), "Tarjeta", int.Parse(idCompra));
                }

                string conseguirCompraActualizada = "SELECT * FROM DATA_G.COMPRA WHERE NroCompra = " + idCompra;
                SqlDataReader compra = Conexion.ejecutarQuery(conseguirCompraActualizada);

                if (compra.Read())
                {
                    MessageBox.Show("Compra exitosa!\nPrecio final: $" + compra["Monto"] + "\nPNR: código acá");

                    this.LimpiarFormulario();
                    FormProvider.IngresarDatosCompra.LimpiarFormulario();
                }
                compra.Close();


            } else {
                MessageBox.Show("Hubo un fallo al generar tu compra.");
            }

        }

        private void LimpiarFormulario()
        {
            //limpiar variables de clase
            pesoEncomienda = "";
            idButacasOcupadas = null;
            idVuelo = "";
            ElClienteExistia = false;
            LaTarjetaExistia = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
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

            
            
            
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private static string pesoEncomienda = "";
        private static List<string> idButacasOcupadas;
        private static string idVuelo ="";

        public void MostrarFormaDeCompra(string encomienda, List<string> idButacas, string IdVuelo, bool compraEnEfectivo)
        {
            pesoEncomienda = encomienda;
            idButacasOcupadas = idButacas;
            idVuelo = IdVuelo;

            if (!compraEnEfectivo)
            {
                radioButton2.Enabled = false;
            }
            else
            {
                radioButton2.Enabled = true;
            }

            comboBox1.ValueMember = "IdTarjeta";
            comboBox1.DisplayMember = "Descripcion";
            comboBox1.DataSource = Conexion.cargarTablaConsulta("DATA_G.GET_TIPO_TARJETA");


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DATA_G.TARJETA WHERE NroTarjeta = " + textBox7.Text;
            SqlDataReader tarjeta = Conexion.ejecutarQuery(query);

            if (tarjeta.Read())
            {
                textBox8.Text = tarjeta["CodSeguridad"].ToString();
                dateTimePicker2.Text = tarjeta["VencimientoTarjeta"].ToString();

                string query2 = "SELECT * FROM DATA_G.TIPODETARJETA WHERE NroTarjeta = " + tarjeta["TipoTarjeta"];
                SqlDataReader tipotarjeta = Conexion.ejecutarQuery(query2);
                if (tipotarjeta.Read())
                {
                    comboBox1.Text = tipotarjeta["Descripcion"].ToString();
                }
                tipotarjeta.Close();
                LaTarjetaExistia = true;
            }
            tarjeta.Close();
            validarCamposCompra();
        }

        private void validarCamposCompra() { 
        
            DateTime fechaNac = DateTime.Parse(dateTimePicker1.Text);

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrEmpty(textBox11.Text) && fechaNac < DateTime.Today)
            {

                if (radioButton1.Checked == true)
                {
                    DateTime fechaVenc = DateTime.Parse(dateTimePicker2.Text);
                    if (!string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrEmpty(dateTimePicker2.Text) && fechaVenc > DateTime.Today)
                    {
                        button1.Enabled = true;
                    }
                    else
                    {
                        button1.Enabled = false;
                    }
                }
                else
                {
                    button1.Enabled = true;
                }

            }
            else
            {
                button1.Enabled = false;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            validarCamposCompra();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            validarCamposCompra();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            validarCamposCompra();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            validarCamposCompra();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            validarCamposCompra();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            validarCamposCompra();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            validarCamposCompra();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            validarCamposCompra();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            validarCamposCompra();
        }

        private static int maxCuotas;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCamposCompra();

            string query = "SELECT * FROM DATA_G.TIPODETARJETA WHERE Descripcion = '" + comboBox1.Text + "'";
            SqlDataReader tipotarjeta = Conexion.ejecutarQuery(query);
            if (tipotarjeta.Read())
            {
                maxCuotas = int.Parse(tipotarjeta["cuotasMax"].ToString());
            }
            tipotarjeta.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            validarCamposCompra();
            if (string.IsNullOrEmpty(textBox9.Text)) textBox9.Text = "0";

            if (int.Parse(textBox9.Text) > maxCuotas || int.Parse(textBox9.Text) < 1)
            {
                MessageBox.Show("Cantidad de cuotas inválida. Por favor, modifique el valor.");
                button1.Enabled = false;
            }
        }
    }
}
