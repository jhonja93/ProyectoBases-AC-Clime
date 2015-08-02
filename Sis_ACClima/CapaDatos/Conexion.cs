using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public static String Cn = "Data Source=DNZ\\SQLDEVELOPER; Initial Catalog=acClimaDB; Integrated Security=True";
        //public static String Cn = "Data Source=JHON-PC\\SQL2014; Initial Catalog=acClimaDB; Integrated Security=True";

        public string ProbarConexion() {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //abrir conexino
                SqlCon.ConnectionString = Conexion.Cn;
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
