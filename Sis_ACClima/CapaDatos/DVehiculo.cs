using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;


namespace CapaDatos
{
    public class DVehiculo
    {
        private string _PlacaVeh;
        private string _NChasis;
        private string _Marca;
        private string _Modelo;
        private Int32 _IdCliente;
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
        public Int32 IdCliente
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

        public DVehiculo(string placaVeh, string nChasis, string marca, string modelo, Int32 idCliente, string textoBuscar) {
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
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();

                //Establecer el comando
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_vehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParPlacaVeh = new MySqlParameter();
                ParPlacaVeh.ParameterName = "@placa_veh";
                ParPlacaVeh.MySqlDbType = MySqlDbType.VarChar;
                ParPlacaVeh.Size = 7;
                ParPlacaVeh.Value = Vehiculo.PlacaVeh;
                SqlCmd.Parameters.Add(ParPlacaVeh);

                MySqlParameter ParNChasis = new MySqlParameter();
                ParNChasis.ParameterName = "@num_chasis";
                ParNChasis.MySqlDbType = MySqlDbType.VarChar;
                ParNChasis.Size = 17;
                ParNChasis.Value = Vehiculo.NChasis;
                SqlCmd.Parameters.Add(ParNChasis);

                MySqlParameter ParMarca = new MySqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.MySqlDbType = MySqlDbType.VarChar;
                ParMarca.Size = 10;
                ParMarca.Value = Vehiculo.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                MySqlParameter ParModelo = new MySqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.MySqlDbType = MySqlDbType.VarChar;
                ParModelo.Size = 10;
                ParModelo.Value = Vehiculo.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                MySqlParameter ParIdCliente = new MySqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.MySqlDbType = MySqlDbType.Int32;
                ParIdCliente.Value = Vehiculo.IdCliente;
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
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();

                //Establecer el comando
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_vehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParPlacaVeh = new MySqlParameter();
                ParPlacaVeh.ParameterName = "@placa_veh";
                ParPlacaVeh.MySqlDbType = MySqlDbType.VarChar;
                ParPlacaVeh.Size = 7;
                ParPlacaVeh.Value = Vehiculo.PlacaVeh;
                SqlCmd.Parameters.Add(ParPlacaVeh);

                MySqlParameter ParNChasis = new MySqlParameter();
                ParNChasis.ParameterName = "@num_chasis";
                ParNChasis.MySqlDbType = MySqlDbType.VarChar;
                ParNChasis.Size = 17;
                ParNChasis.Value = Vehiculo.NChasis;
                SqlCmd.Parameters.Add(ParNChasis);

                MySqlParameter ParMarca = new MySqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.MySqlDbType = MySqlDbType.VarChar;
                ParMarca.Size = 10;
                ParMarca.Value = Vehiculo.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                MySqlParameter ParModelo = new MySqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.MySqlDbType = MySqlDbType.VarChar;
                ParModelo.Size = 10;
                ParModelo.Value = Vehiculo.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                MySqlParameter ParIdCliente = new MySqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.MySqlDbType = MySqlDbType.Int32;
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
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();

                //Establecer el comando
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_vehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParPlacaVeh = new MySqlParameter();
                ParPlacaVeh.ParameterName = "@placa_veh";
                ParPlacaVeh.MySqlDbType = MySqlDbType.VarChar;
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
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_vehiculo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;

        }


        public DataTable BuscarPlaca(DVehiculo Vehiculo)
        {
            DataTable DtResultado = new DataTable("vehiculo");
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_vehiculo_placa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Vehiculo.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;
        }

        public DataTable BuscarChasis(DVehiculo Vehiculo)
        {
            DataTable DtResultado = new DataTable("vehiculo");
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_vehiculo_chasis";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Vehiculo.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;
        }

        public DataTable BuscarCedula(DVehiculo Vehiculo)
        {
            DataTable DtResultado = new DataTable("vehiculo");
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_vehiculo_cedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.MySqlDbType = MySqlDbType.Int32;
                ParTextoBuscar.Value = Vehiculo.IdCliente;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;
        }

    }
}
