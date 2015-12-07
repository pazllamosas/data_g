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

namespace AerolineaFrba.Devolucion
{
    public partial class Devolucion : Form
    {
        
        public Devolucion()
        {
            InitializeComponent();
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            btnDevolver.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void rdbPasaje_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
          Int32 codigo = Convert.ToInt32(txtCodItem.Text);
         if (this.txtCodItem.Text.Trim() == "")
         {
             MessageBox.Show("Completar codigo");
         }
         else
         {
             if (rdbPasaje.Checked)
             {

                 if (pasajeValido(codigo))
                 {
                     bool resultado = Conexion.executeProcedure("DATA_G.CANCELAR_PASAJE", Conexion.generarArgumentos("@pasaje"), codigo);
                     if (resultado)
                     {
                         MessageBox.Show("Pasaje devuelto");
                         this.txtCodItem.Clear();
                     }
                 }
             }
             else
             {
                 if (rdbEncomienda.Checked)
                 {
                     if (paqueteValido(codigo))
                     {
                         bool resultado = Conexion.executeProcedure("DATA_G.CANCELAR_PAQUETE", Conexion.generarArgumentos("@paquete"), codigo);
                         if (resultado)
                         {
                             MessageBox.Show("Paquete devuelto");
                             this.txtCodItem.Clear();
                         }
                     }
                 }
                 else
                 {
                     if (radioButton1.Checked)
                     {
                         if (compraValida(codigo))
                         {
                             bool resultado = Conexion.executeProcedure("DATA_G.CANCELAR_COMPRA", Conexion.generarArgumentos("@nrocompra"), codigo);
                             if (resultado)
                             {
                                 MessageBox.Show("Compra devuelto");
                                 this.txtCodItem.Clear();
                             }
                         }

                     }
                     else
                     {
                         MessageBox.Show("Seleccionar un tipo de devolucion");
                     }
                 }
             }
         }
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }



        public Boolean pasajeValido(Int32 codigo)
        {
            string query = "SELECT DATA_G.EXISTE_PASAJE ('" + codigo + "' ) AS id";
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
                MessageBox.Show("El codigo del pasaje no existe");
                return false;
            }
        }

        public Boolean paqueteValido(Int32 codigo)
        {
            string query = "SELECT DATA_G.EXISTE_PAQUETE ('" + codigo + "' ) AS id";
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
                MessageBox.Show("El codigo del paquete no existe");
                return false;
            }
        }

        public Boolean compraValida(Int32 codigo)
        {
            string query = "SELECT DATA_G.EXISTE_COMPRA ('" + codigo + "' ) AS id";
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
                MessageBox.Show("El numero de compra no existe");
                return false;
            }
        }




    }
}
