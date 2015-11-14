using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

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








        public static DataTable retrieveDataTable(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            return _retrieveDataTable(procedure, argumentos, values);
        }

        /// <summary>
        /// Ejecuta un stored procedure y devuelve un datatable con el resultado del mismo.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <returns></returns>
        public static DataTable retrieveDataTable(string procedure)
        {
            return _retrieveDataTable(procedure, null, null);
        }

        /// <summary>
        /// Ejecuta un stored procedure.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <param name="values">Argumentos que recibe el stored procedure.</param>
        public static void executeProcedure(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            _executeProcedure(procedure, argumentos, values);
        }

        /// <summary>
        /// Ejecuta un stored procedure.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        public static void executeProcedure(string procedure)
        {
            _executeProcedure(procedure, null, null);
        }

        /// <summary>
        /// Ejecuta una consulta (a partir de un stored procedure) y devuelve si encontró datos o no.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <param name="values">Argumentos que recibe el stored procedure.</param>
        /// <returns> True: la consulta devolvió alguna fila. False: no devolvió filas.</returns>
        public static bool checkIfExists(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            return _checkIfExists(procedure, argumentos, values);
        }
        /// <summary>
        /// Ejecuta una consulta (a partir de un stored procedure) y devuelve si encontró datos o no.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <returns> True: la consulta devolvió alguna fila. False: no devolvió filas.</returns>
        public static bool checkIfExists(string procedure)
        {
            return _checkIfExists(procedure, null, null);
        }
        /// <summary>
        /// Ejecuta un stored procedure que devuelve un valor númerico y retorna dicho valor.
        /// </summary>
        /// <param name="procedure">Nombre del stored procedure almacenado en la BDD sin el nombre del esquema delante.</param>
        /// <param name="values">Argumentos que recibe el stored procedure.</param>
        /// <returns> Valor de retorno del stored procedure.</returns>
        public static int executeProcedureWithReturnValue(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            return _executeProcedureWithReturnValue(procedure, argumentos, values);
        }

        public static long executeProcedureWithLongReturnValue(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            DataTable data = _retrieveDataTable(procedure, argumentos, values);
            return Convert.ToInt64(data.Rows[0][0]);
        }

        private static void _executeProcedure(string procedure, List<string> args, params object[] values)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand command = new SqlCommand();

            
            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DATA_G." + procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, command, values);
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
        }
        private static bool _checkIfExists(string procedure, List<string> args, params object[] values)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DATA_G." + procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, command, values);
                }
                dr = command.ExecuteReader();
                return dr.HasRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
        }
        private static int _executeProcedureWithReturnValue(string procedure, List<string> args, params object[] values)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand command = new SqlCommand();

            try
            {
                
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DATA_G." + procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, command, values);
                }
                command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                return (int)command.Parameters["@RETURN_VALUE"].Value;
            }
            catch (Exception)
            {
                return -1;
            }

            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
        }
        private static DataTable _retrieveDataTable(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();

            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "DATA_G." + procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, cm, values);
                }
                dr = cm.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static List<string> _generateArguments(string procedure)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            List<string> args = new List<string>();
            try
            {
                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT PARAMETER_NAME FROM information_schema.parameters WHERE SPECIFIC_SCHEMA='DATA_G' AND SPECIFIC_NAME='" + procedure + "'";
                dr = cm.ExecuteReader();
                dt.Load(dr);
                foreach (DataRow d in dt.Rows)
                {
                    args.Add(d[0].ToString());
                }
                return args;
            }
            catch (Exception)
            {
                return null;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static bool _validateArgumentsAndParameters(List<string> args, params object[] values)
        {
            if (args != null && values != null)
            {
                if (args.Count != values.Length)
                {
                    throw new ApplicationException();
                }
                return true;
            }
            return false;
        }
        private static void _loadSqlCommand(List<string> args, SqlCommand cm, params object[] values)
        {
            for (int i = 0; i < args.Count; i++)
            {
                cm.Parameters.AddWithValue(args[i], values[i]);
            }
        }
    }

}
