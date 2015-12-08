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

namespace AerolineaFrba.Canje_Millas
{
    public partial class CanjeMillas : Form
    {
        public CanjeMillas()
        {
            InitializeComponent();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool resultado = funciones.permiteNumeros(txtDni.Text);
            if (!resultado)
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool resultado = funciones.permiteNumeros(txtCantidad.Text);
            if (!resultado)
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Int32 dni = Convert.ToInt32(txtDni.Text);
            getMillas(dni);
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CanjeMillas_Load(object sender, EventArgs e)
        {
           // Conexion.cargarCmb("Descripcion", "PRODUCTO", cmbProducto);
            cmbProducto.ValueMember = "IdProducto";
            cmbProducto.DisplayMember = "Descripcion";
            cmbProducto.DataSource = Conexion.cargarTablaConsulta("DATA_G.GET_PRODUCTOS");

            this.txtDni.Clear();
            this.txtCantidad.Clear();
            this.cmbProducto.SelectedIndex = -1;
            

        }


        public Boolean clienteValido(Int32 dni)
        {
            string query = "SELECT DATA_G.GET_CLIENTE_DNI ('" + dni + "' ) AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta >= 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("El cliente no se encuentra en la base");
                return false;
            }
        }

        private bool validacion()
        {
            if (this.txtDni.Text.Trim() == "")
                return false;
            if (this.txtCantidad.Text.Trim() == "")
                return false;
            if (this.cmbProducto.SelectedIndex == -1)
                return false;
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.validacion())
            {
                Int32 dni = Convert.ToInt32(txtDni.Text);

                Int32 cantidad = Convert.ToInt32(txtCantidad.Text);

                Int32 producto = Convert.ToInt32(cmbProducto.SelectedValue);

                if (this.validacionDatos(dni, cantidad))
                {
                    Conexion.executeProcedure("DATA_G.MILLAS_GANADAS", Conexion.generarArgumentos("@dni"), dni);
                    Conexion.executeProcedure("DATA_G.MILLAS_CANJEADAS", Conexion.generarArgumentos("@dni"), dni);
                    Conexion.executeProcedure("DATA_G.AFTER_MILLAS", Conexion.generarArgumentos("@dni"), dni);
                    string query = "SELECT DATA_G.GET_CLIENTE_DNI ('" + dni + "') AS id";

                    SqlDataReader reader = Conexion.ejecutarQuery(query);
                    reader.Read();
                    string idCliente = reader["id"].ToString();
                    reader.Close();
                if( cantidadValida(cantidad, producto))
                {
                    if(millasValidas (idCliente, producto, cantidad))
                    {
                        bool resultado = Conexion.executeProcedure("DATA_G.ALTA_CANJE", Conexion.generarArgumentos("@idCliente", "@idProducto", "@cantidad"),
                        idCliente, producto, cantidad);

                        if (resultado)
                        {
                            MessageBox.Show("Canje realizado");
                         deleteMillasAcum();
                        this.txtDni.Clear();
                        this.txtCantidad.Clear();
                        this.cmbProducto.SelectedIndex = -1;

                        }
                    }
                }

                }
            }
            else
            {
                MessageBox.Show("Completar todos los campos");
                deleteMillasAcum();
            }
        }

        public static object getMillas(Int32 dni)
        {
            DataTable tablaMillas = Conexion.cargarTablaConsulta("DATA_G.GET_MILLASACUMULADAS m WHERE m.Dni=" + dni );
            return tablaMillas;
         }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private bool validacionDatos(int dni, int cantidad)
        {
           if (dni == 0)
            {
                MessageBox.Show("El dni no puede ser 0");
                this.txtDni.Clear();
                return false;
            }
            if (cantidad == 0)
            {
                MessageBox.Show("La cantidad no puede ser 0");
                this.txtCantidad.Clear();
                return false;
            }
            if (!clienteValido(dni))
            {
                MessageBox.Show("El cliente no se encuentra en la base");
                this.txtDni.Clear();
                return false;
            }
            return true;
        }

        public Boolean cantidadValida(Int32 cantidad, Int32 producto)
        {
            string query = "SELECT DATA_G.MAYOR_CANTIDAD ('" + cantidad + "', '" + producto + "') AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No hay suficiente stock");
                deleteMillasAcum();
                return false;
            }
        }

        public Boolean millasValidas(string cliente, Int32 producto, Int32 cantidad)
        {
            
            string query = "SELECT DATA_G.MAS_MILLAS ('" + cliente + "', '" + producto + "', '" + cantidad + "') AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No tienes suficientes millas");
                deleteMillasAcum();
                return false;
            }
        }

        public void deleteMillasAcum()
        {
            SqlCommand cmd = new SqlCommand("DATA_G.DELETE_MILLASACUMULADAS", Conexion.getSqlInstanceConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
        }
    }

}
