using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.Configuration;

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


        public SqlConnection conectar()
        {
            try
            {
                conexionMaestra.Open();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return conexionMaestra;

        }

        public DataTable cargarTabla(SqlCommand command)
        {
            DataTable ds = new DataTable();
           
            this.conectar();
           
            command.Connection = conexionMaestra;
            command.CommandType = CommandType.Text;

            
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(ds);
            conexionMaestra.Close();
            return ds;
        }

        public static DataTable cargarTablaConsulta(string consulta)
        {
            DataTable dt = new DataTable();
            try
            { 
           SqlConnection cn = getSqlInstanceConnection();
           SqlCommand cm = new SqlCommand(consulta, cn);
           cm.CommandTimeout = 1000;
           SqlDataAdapter adap = new SqlDataAdapter(cm);
           adap.Fill(dt);
           return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        

        public static DataTable obtenerTablaProcedure(string procedure, List<string> args, params object[] values)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = getSqlInstanceConnection();
                SqlCommand cm = new SqlCommand(procedure, cn);
                cm.CommandTimeout = 1000;
                cm.CommandType = CommandType.StoredProcedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, cm, values);
                }
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
            

        public static bool executeProcedure(string procedure, List<string> args, params object[] values)
        {
            try
            {
                SqlDataReader dr;
                SqlConnection cn = getSqlInstanceConnection() ;
                SqlCommand cm = new SqlCommand(procedure, cn);
                cm.CommandType = CommandType.StoredProcedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, cm, values);
                }
                dr = cm.ExecuteReader();
                dr.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
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

         public static List<string> generarArgumentos(params Object[] parametros)
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < parametros.Length; i++ )
            {
                lista.Add(parametros[i].ToString());
            }            
            return lista;

             
             
              }
              
                 
          }

        }

         










    
        
    
    
	



    








 