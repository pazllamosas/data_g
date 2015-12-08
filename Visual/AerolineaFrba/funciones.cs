using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AerolineaFrba
{
    class funciones
    {
       
        internal static string SHA256Encripta(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());
            return output.ToString();
        }

        private static string connectionString = ConfigurationManager.ConnectionStrings["GD2C2015"].ConnectionString;

        
        public static string getConnectionString()
        {
            return connectionString;
        }

        public static string getFechaSistema()
        {
            return ConfigurationManager.AppSettings["fecha"];
        }

        public static DateTime getDateFechaSistema()
        {
            return Convert.ToDateTime(ConfigurationManager.AppSettings["fecha"]);
        }

        public static DateTime getFechaSistemaEnTipoDate()
        {
            return DateTime.Today;
        }

        //textBox solo permita numeros
        internal static bool permiteNumeros(KeyPressEventArgs e)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
            }
            return true;
        }

        //textBox solo permita letras
        internal static void permiteLetras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //fecha inicio sea menor a la fecha final
        internal static bool validarFechas(DateTimePicker dtpFechaDesde, DateTimePicker dtpFechaHasta)
        {
            if (dtpFechaDesde.Value < dtpFechaHasta.Value)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Fecha inicio debe ser menor a fecha final");
                return false;
            }
        }

        //ejemplo
        //private void fechaDeNac_ValueChanged(object sender, EventArgs e)
        //{
        //    fechaDeNac = dateTimePickFechaNac.Value;
        //}

    

    }
}
