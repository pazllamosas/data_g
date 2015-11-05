using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AerolineaFrba
{
    class conexion
    {
              
        static SqlConnection conexionMaestra;

        internal static void establecerConexionBD()
        {
            string datosConexion = "Data Source=localHost\\SQLSERVER2012;Initial Catalog= ;Persist Security Info=True;User ID= gd;Password= gd2015";
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = datosConexion;
            SqlCommand command;

            try
            {
                conexion.Open();
                conexionMaestra = conexion;
                command = new SqlCommand("select 1 from gd_esquema.Maestra", conexion);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                }
                reader.Close();
                MessageBox.Show("hola");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        internal static SqlConnection getSqlInstanceConnection()
        {
            return conexionMaestra;
        }
    }
}
