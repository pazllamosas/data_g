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
using System.Text.RegularExpressions;

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
        internal static bool permiteNumeros(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        //textBox solo permita letras
        internal static bool permiteLetras(string s)
        {

            foreach (char c in s)
            {
                 if (!Regex.IsMatch(s, @"^[a-zA-Z]+$"))
                        return false;
            }
            return true;
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
