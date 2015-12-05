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

        //public static SqlConnection getConexion()
        //{
        //    return conexion;
        //}

        //public static bool executeProcedure(string procedure, List<string> args, params object[] values)
        //{
        //    try
        //    {
        //        SqlDataReader dr;
        //        SqlConnection conexion = getConexion();
        //        SqlCommand cmd = new SqlCommand(procedure, conexion);
        //        cmd.CommandTimeout = 1000;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        if (_validateArgumentsAndParameters(args, values))
        //        {
        //            _loadSqlCommand(args, values, cmd);
        //        }
        //        dr = cmd.ExecuteReader();
        //        dr.Close();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //}

        //private static bool _validateArgumentsAndParameters(List<string> args, params object[] values)
        //{
        //    if (args != null && values != null)
        //    {
        //        if (args.Count != values.Length)
        //        {
        //            throw new ApplicationException();
        //        }
        //        return true;
        //    }
        //    return false;
        //}

        //private static void _loadSqlCommand(List<string> args, object[] values, SqlCommand cm)
        //{
        //    for (int i = 0; i < args.Count; i++)
        //    {
        //        cm.Parameters.AddWithValue(args[i], values[i]);
        //    }
        //}

    

    }
}
