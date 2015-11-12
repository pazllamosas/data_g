using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AerolineaFrba
{
    class Conexion
    {
              
        public static SqlConnection conexionMaestra;

        public static SqlDataReader ejecutarQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, conexionMaestra);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        internal static void establecerConexionBD()
        {
            string datosConexion = "Data Source=localHost\\SQLSERVER2012;Initial Catalog= ;Persist Security Info=True;User ID= gd;Password= gd2015";
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = datosConexion;
            SqlCommand command;

                conexion.Open();
                conexionMaestra = conexion;
                command = new SqlCommand("select 1 from gd_esquema.Maestra", conexion);
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
            
        }

        internal static void cargarCmb(String nomColumna, String nomTabla, ComboBox cmbACargar)
        {
            string query = "SELECT " + nomColumna + " AS atributo FROM DATA_G." + nomTabla;
            SqlDataReader reader = Conexion.ejecutarQuery(query);


            try
            {

                while (reader.Read())
                {
                   cmbACargar.Items.Add(reader["atributo"]);
                }
                reader.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR Al Cargar COMBO BOX");
            }
        }


        internal static SqlConnection getSqlInstanceConnection()
        {
            return conexionMaestra;
        }
    }

}
