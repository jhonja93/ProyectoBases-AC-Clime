using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DVehiculo
    {
        private string _PlacaVeh;
        private string _NChasis;
        private string _Marca;
        private string _Modelo;
        private int _IdCliente;
        private string _TextoBuscar;



        public string PlacaVeh
        {
            get { return _PlacaVeh; }
            set { _PlacaVeh = value; }
        }
        public string NChasis
        {
            get { return _NChasis; }
            set { _NChasis = value; }
        }
        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }
        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }
        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }
        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public DVehiculo() { }

        public DVehiculo(string placaVeh, string nChasis, string marca, string modelo, int idCliente, string textoBuscar) {
            this.PlacaVeh = placaVeh;
            this.NChasis = nChasis;
            this.Modelo = modelo;
            this.Marca = marca;
            this.IdCliente = idCliente;
            this.TextoBuscar = textoBuscar;
        }

        //metodo insertar vehiculo
        public string Insertar(DVehiculo Vehiculo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_vehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPlacaVeh = new SqlParameter();
                ParPlacaVeh.ParameterName = "@placa_veh";
                ParPlacaVeh.SqlDbType = SqlDbType.VarChar;
                ParPlacaVeh.Size = 7;
                ParPlacaVeh.Value = Vehiculo.PlacaVeh;
                SqlCmd.Parameters.Add(ParPlacaVeh);

                SqlParameter ParNChasis = new SqlParameter();
                ParNChasis.ParameterName = "@num_chasis";
                ParNChasis.SqlDbType = SqlDbType.VarChar;
                ParNChasis.Size = 17;
                ParNChasis.Value = Vehiculo.NChasis;
                SqlCmd.Parameters.Add(ParNChasis);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 10;
                ParMarca.Value = Vehiculo.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 10;
                ParModelo.Value = Vehiculo.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdCliente);

                //ejecutar comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

                
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

        //metodo editar vehiculo

        public string Editar(DVehiculo Vehiculo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_vehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPlacaVeh = new SqlParameter();
                ParPlacaVeh.ParameterName = "@placa_veh";
                ParPlacaVeh.SqlDbType = SqlDbType.VarChar;
                ParPlacaVeh.Size = 7;
                ParPlacaVeh.Value = Vehiculo.PlacaVeh;
                SqlCmd.Parameters.Add(ParPlacaVeh);

                SqlParameter ParNChasis = new SqlParameter();
                ParNChasis.ParameterName = "@num_chasis";
                ParNChasis.SqlDbType = SqlDbType.VarChar;
                ParNChasis.Size = 17;
                ParNChasis.Value = Vehiculo.NChasis;
                SqlCmd.Parameters.Add(ParNChasis);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 10;
                ParMarca.Value = Vehiculo.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 10;
                ParModelo.Value = Vehiculo.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Vehiculo.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                //ejecutar comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Edito el Registro";


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


        //metodo Eliminar
        public string Eliminar(DVehiculo Vehiculo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_vehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPlacaVeh = new SqlParameter();
                ParPlacaVeh.ParameterName = "@placa_veh";
                ParPlacaVeh.SqlDbType = SqlDbType.VarChar;
                ParPlacaVeh.Size = 7;
                ParPlacaVeh.Value = Vehiculo.PlacaVeh;
                SqlCmd.Parameters.Add(ParPlacaVeh);

                //ejecutamos nuestor comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Eliminó el Registro";
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

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("vehiculo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_vehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;

        }


        public DataTable BuscarPlaca(DVehiculo Vehiculo)
        {
            DataTable DtResultado = new DataTable("vehiculo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_vehiculo_placa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Vehiculo.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;
        }

        public DataTable BuscarChasis(DVehiculo Vehiculo)
        {
            DataTable DtResultado = new DataTable("vehiculo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_vehiculo_chasis";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Vehiculo.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;
        }

        public DataTable BuscarCedula(DVehiculo Vehiculo)
        {
            DataTable DtResultado = new DataTable("vehiculo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_vehiculo_cedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
                ParTextoBuscar.Value = Vehiculo.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;
        }

    }
}
