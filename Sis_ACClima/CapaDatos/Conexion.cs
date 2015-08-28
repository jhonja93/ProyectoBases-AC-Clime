using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        //public static String Cn = "Data Source=DNZ\\SQLDEVELOPER; Initial Catalog=acClimaDB; Integrated Security=True";
        public static String conexion = "Data Source=JHON-PC\\SQL2014; Initial Catalog=acClimaDB; Integrated Security=True";

        //public static string conexion = "server=10.0.10.1;uid=grupo6;"+"pwd=grupo6;database=grupo6;";

        //public string ProbarConexion()
        //{
        //    string rpta = "";
        //    MySqlConnection MySQLcon = new MySqlConnection();
        //    try
        //    {
        //        //abrir conexion
        //        MySQLcon.ConnectionString = Conexion.conexion;
        //        MySQLcon.Open();
        //    }
        //    catch (MySql.Data.MySqlClient.MySqlException ex)
        //    {
        //        rpta = ex.Message;
        //    }
        //    finally
        //    {
        //        if (MySQLcon.State == ConnectionState.Open) MySQLcon.Close();
        //    }
        //    return rpta;
        //}

        public string ProbarConexion()
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //abrir conexion
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        
    }
}
