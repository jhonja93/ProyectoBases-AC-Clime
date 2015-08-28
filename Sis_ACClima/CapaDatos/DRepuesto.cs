using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;


namespace CapaDatos
{
    public class DRepuesto
    {
        private Int32 _Idrepuesto;
        private string _Nombre;
        private string _Marca;
        private string _Descripcion;
        private float _PrecioVenta;
        private Int32 _StockInicial;
        private Int32 _StockActual;

        private string _TextoBuscar;

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public Int32 StockActual
        {
            get { return _StockActual; }
            set { _StockActual = value; }
        }
        public Int32 StockInicial
        {
            get { return _StockInicial; }
            set { _StockInicial = value; }
        }

        public float PrecioVenta
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }

        public Int32 Idrepuesto
        {
            get { return _Idrepuesto; }
            set { _Idrepuesto = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        //constructor vacio
        public DRepuesto() { 
        }

        //constructor con parametros
        public DRepuesto(Int32 idRepuesto, string nombre, string marca, string descripcion, float precio_venta, Int32 stock_inicial, Int32 stock_actual, string textoBuscar) {
            this.Idrepuesto = idRepuesto;
            this.Nombre = nombre;
            this.Marca = marca;
            this.Descripcion = descripcion;
            this.PrecioVenta = precio_venta;
            this.StockInicial = stock_inicial;
            this.StockActual = stock_actual;
            this.TextoBuscar = textoBuscar;
        }

        //metodo insertar repuesto
        public string Insertar(DRepuesto Repuesto) {
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
                SqlCmd.CommandText = "spinsertar_repuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIdRepuesto = new MySqlParameter();
                ParIdRepuesto.ParameterName = "@idrepuesto";
                ParIdRepuesto.MySqlDbType = MySqlDbType.Int32;
                ParIdRepuesto.Direction = ParameterDirection.Output;//porque es un parametro de salida
                SqlCmd.Parameters.Add(ParIdRepuesto);

                MySqlParameter Parnombre = new MySqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.MySqlDbType = MySqlDbType.VarChar;
                Parnombre.Size = 25;
                Parnombre.Value = Repuesto.Nombre;
                SqlCmd.Parameters.Add(Parnombre);

                MySqlParameter Parmarca = new MySqlParameter();
                Parmarca.ParameterName = "@marca";
                Parmarca.MySqlDbType = MySqlDbType.VarChar;
                Parmarca.Size = 25;
                Parmarca.Value = Repuesto.Marca;
                SqlCmd.Parameters.Add(Parmarca);

                MySqlParameter ParDescripcion = new MySqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.MySqlDbType = MySqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Repuesto.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                MySqlParameter ParPrecioVenta = new MySqlParameter();
                ParPrecioVenta.ParameterName = "@precio_venta";
                ParPrecioVenta.MySqlDbType = MySqlDbType.Float;
                ParPrecioVenta.Value = Repuesto.PrecioVenta;
                SqlCmd.Parameters.Add(ParPrecioVenta);

                MySqlParameter ParStockInicial = new MySqlParameter();
                ParStockInicial.ParameterName = "@stock_inicial";
                ParStockInicial.MySqlDbType = MySqlDbType.Int32;
                ParStockInicial.Value = Repuesto.StockInicial;
                SqlCmd.Parameters.Add(ParStockInicial);

                MySqlParameter ParStockActual = new MySqlParameter();
                ParStockActual.ParameterName = "@stock_actual";
                ParStockActual.MySqlDbType = MySqlDbType.Int32;
                ParStockActual.Value = Repuesto.StockActual;
                SqlCmd.Parameters.Add(ParStockActual);


                //ejecutamos nuestor comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
            
        }

        //metodo editar repuesto
        public string Editar(DRepuesto Repuesto) {
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
                SqlCmd.CommandText = "speditar_repuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIdRepuesto = new MySqlParameter();
                ParIdRepuesto.ParameterName = "@idrepuesto";
                ParIdRepuesto.MySqlDbType = MySqlDbType.Int32;
                ParIdRepuesto.Value = Repuesto.Idrepuesto;
                SqlCmd.Parameters.Add(ParIdRepuesto);

                MySqlParameter Parnombre = new MySqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.MySqlDbType = MySqlDbType.VarChar;
                Parnombre.Size = 20;
                Parnombre.Value = Repuesto.Nombre;
                SqlCmd.Parameters.Add(Parnombre);

                MySqlParameter Parmarca = new MySqlParameter();
                Parmarca.ParameterName = "@marca";
                Parmarca.MySqlDbType = MySqlDbType.VarChar;
                Parmarca.Size = 20;
                Parmarca.Value = Repuesto.Marca;
                SqlCmd.Parameters.Add(Parmarca);

                MySqlParameter ParDescripcion = new MySqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.MySqlDbType = MySqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Repuesto.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                MySqlParameter ParPrecioVenta = new MySqlParameter();
                ParPrecioVenta.ParameterName = "@precio_venta";
                ParPrecioVenta.MySqlDbType = MySqlDbType.Float;
                ParPrecioVenta.Value = Repuesto.PrecioVenta;
                SqlCmd.Parameters.Add(ParPrecioVenta);

                MySqlParameter ParStockInicial = new MySqlParameter();
                ParStockInicial.ParameterName = "@stock_inicial";
                ParStockInicial.MySqlDbType = MySqlDbType.Int32;
                ParStockInicial.Value = Repuesto.StockInicial;
                SqlCmd.Parameters.Add(ParStockInicial);

                MySqlParameter ParStockActual = new MySqlParameter();
                ParStockActual.ParameterName = "@stock_actual";
                ParStockActual.MySqlDbType = MySqlDbType.Int32;
                ParStockActual.Value = Repuesto.StockActual;
                SqlCmd.Parameters.Add(ParStockActual);


                //ejecutamos nuestor comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";
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
        public string Eliminar(DRepuesto Repuesto) {
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
                SqlCmd.CommandText = "speliminar_repuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParIdRepuesto = new MySqlParameter();
                ParIdRepuesto.ParameterName = "@idrepuesto";
                ParIdRepuesto.MySqlDbType = MySqlDbType.Int32;
                ParIdRepuesto.Value = Repuesto.Idrepuesto;
                SqlCmd.Parameters.Add(ParIdRepuesto);

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

        //metodo mostrar repuestos
        public DataTable Mostrar() {
            DataTable DtResultado = new DataTable("repuesto");
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_repuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;

        }

        //metodo buscar nombre repuesto
        public DataTable BuscarNombre(DRepuesto Repuesto) 
        {
            DataTable DtResultado = new DataTable("repuesto");
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_repuesto_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Repuesto.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;
        }

        //metodo buscar marca repuesto
        public DataTable BuscarMarca(DRepuesto Repuesto)
        {
            DataTable DtResultado = new DataTable("repuesto");
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_repuesto_marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Repuesto.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;
        }
    }
}
