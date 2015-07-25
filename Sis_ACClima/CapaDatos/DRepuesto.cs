using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DRepuesto
    {
        private int _Idrepuesto;
        private string _Nombre;
        private string _Marca;
        private string _Descripcion;
        private float _PrecioVenta;
        private int _StockInicial;
        private int _StockActual;

        private string _TextoBuscar;

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public int StockActual
        {
            get { return _StockActual; }
            set { _StockActual = value; }
        }
        public int StockInicial
        {
            get { return _StockInicial; }
            set { _StockInicial = value; }
        }

        public float PrecioVenta
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }

        public int Idrepuesto
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
        public DRepuesto(int idRepuesto, string nombre, string marca, string descripcion, float precio_venta, int stock_inicial, int stock_actual, string textoBuscar) {
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
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_repuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRepuesto = new SqlParameter();
                ParIdRepuesto.ParameterName = "@idrepuesto";
                ParIdRepuesto.SqlDbType = SqlDbType.Int;
                ParIdRepuesto.Direction = ParameterDirection.Output;//porque es un parametro de salida
                SqlCmd.Parameters.Add(ParIdRepuesto);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 25;
                Parnombre.Value = Repuesto.Nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter Parmarca = new SqlParameter();
                Parmarca.ParameterName = "@marca";
                Parmarca.SqlDbType = SqlDbType.VarChar;
                Parmarca.Size = 25;
                Parmarca.Value = Repuesto.Marca;
                SqlCmd.Parameters.Add(Parmarca);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Repuesto.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParPrecioVenta = new SqlParameter();
                ParPrecioVenta.ParameterName = "@precio_venta";
                ParPrecioVenta.SqlDbType = SqlDbType.Money;
                ParPrecioVenta.Value = Repuesto.PrecioVenta;
                SqlCmd.Parameters.Add(ParPrecioVenta);

                SqlParameter ParStockInicial = new SqlParameter();
                ParStockInicial.ParameterName = "@stock_inicial";
                ParStockInicial.SqlDbType = SqlDbType.Int;
                ParStockInicial.Value = Repuesto.StockInicial;
                SqlCmd.Parameters.Add(ParStockInicial);

                SqlParameter ParStockActual = new SqlParameter();
                ParStockActual.ParameterName = "@stock_actual";
                ParStockActual.SqlDbType = SqlDbType.Int;
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
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_repuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRepuesto = new SqlParameter();
                ParIdRepuesto.ParameterName = "@idrepuesto";
                ParIdRepuesto.SqlDbType = SqlDbType.Int;
                ParIdRepuesto.Value = Repuesto.Idrepuesto;
                SqlCmd.Parameters.Add(ParIdRepuesto);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 20;
                Parnombre.Value = Repuesto.Nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter Parmarca = new SqlParameter();
                Parmarca.ParameterName = "@marca";
                Parmarca.SqlDbType = SqlDbType.VarChar;
                Parmarca.Size = 20;
                Parmarca.Value = Repuesto.Marca;
                SqlCmd.Parameters.Add(Parmarca);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Repuesto.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParPrecioVenta = new SqlParameter();
                ParPrecioVenta.ParameterName = "@precio_venta";
                ParPrecioVenta.SqlDbType = SqlDbType.Money;
                ParPrecioVenta.Value = Repuesto.PrecioVenta;
                SqlCmd.Parameters.Add(ParPrecioVenta);

                SqlParameter ParStockInicial = new SqlParameter();
                ParStockInicial.ParameterName = "@stock_inicial";
                ParStockInicial.SqlDbType = SqlDbType.Int;
                ParStockInicial.Value = Repuesto.StockInicial;
                SqlCmd.Parameters.Add(ParStockInicial);

                SqlParameter ParStockActual = new SqlParameter();
                ParStockActual.ParameterName = "@stock_actual";
                ParStockActual.SqlDbType = SqlDbType.Int;
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
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_repuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRepuesto = new SqlParameter();
                ParIdRepuesto.ParameterName = "@idrepuesto";
                ParIdRepuesto.SqlDbType = SqlDbType.Int;
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
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_repuesto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;

        }

        //metodo buscar nombre repuesto
        public DataTable BuscarNombre(DRepuesto Repuesto) 
        {
            DataTable DtResultado = new DataTable("repuesto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_repuesto_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Repuesto.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;
        }

        //metodo buscar marca repuesto
        public DataTable BuscarMarca(DRepuesto Repuesto)
        {
            DataTable DtResultado = new DataTable("repuesto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_repuesto_marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Repuesto.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;
        }
    }
}
