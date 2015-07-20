using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class DProveedor
    {
        private int _IdProveedor;
        private string _NombreProveedor;
        private string _Responsable;
        private string _TelefonoProv;
        private string _DireccionProv;

        private string _TextoBuscar;

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public int IdProveedor
        {
            get { return _IdProveedor; }
            set { _IdProveedor = value; }
        }

        public string NombreProveedor
        {
            get { return _NombreProveedor; }
            set { _NombreProveedor = value; }
        }

        public string Responsable
        {
            get { return _Responsable; }
            set { _Responsable = value; }
        }

        public string TelefonoProv
        {
            get { return _TelefonoProv; }
            set { _TelefonoProv = value; }
        }

        public string DireccionProv
        {
            get { return _DireccionProv; }
            set { _DireccionProv = value; }
        }

        //constructor vacío
        public DProveedor(){}

        //constructor con parámetros
        public DProveedor(int idProveedor, string nombreProv, string responsable, string telefonoProv, string direccionProv, string textoBuscar) {

            this.IdProveedor = idProveedor;
            this.NombreProveedor = nombreProv;
            this.Responsable = responsable;
            this.TelefonoProv = telefonoProv;
            this.DireccionProv = direccionProv;
            this.TextoBuscar = textoBuscar;

        }

        //método insertar proveedor

        public string Insertar(DProveedor Proveedor) 
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();

            try {
                //abrir conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //definir el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros a enviarse con el comando, dependen del procedure creado en la base, se crea una nueva instancia
                //de SqlParameter por cada parametro del procedure
                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@idproveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParNombreProv = new SqlParameter();
                ParNombreProv.ParameterName = "@nombreprov";
                ParNombreProv.SqlDbType = SqlDbType.VarChar;
                ParNombreProv.Size = 15;
                ParNombreProv.Value = Proveedor.NombreProveedor;
                SqlCmd.Parameters.Add(ParNombreProv);

                SqlParameter ParResponsable = new SqlParameter();
                ParResponsable.ParameterName = "@responsable";
                ParResponsable.SqlDbType = SqlDbType.VarChar;
                ParResponsable.Size = 15;
                ParResponsable.Value = Proveedor.Responsable;
                SqlCmd.Parameters.Add(ParResponsable);

                SqlParameter ParTelefonoProv = new SqlParameter();
                ParTelefonoProv.ParameterName = "@telefonoprov";
                ParTelefonoProv.SqlDbType = SqlDbType.VarChar;
                ParTelefonoProv.Size = 12;
                ParResponsable.Value = Proveedor.TelefonoProv;
                SqlCmd.Parameters.Add(ParResponsable);

                SqlParameter ParDireccionProv = new SqlParameter();
                ParDireccionProv.ParameterName = "@direccionprov";
                ParDireccionProv.SqlDbType = SqlDbType.VarChar;
                ParDireccionProv.Size = 50;
                ParDireccionProv.Value = Proveedor.DireccionProv;
                SqlCmd.Parameters.Add(ParDireccionProv);

                //ejecutamos el comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            
            catch (Exception ex) { rpta=ex.Message; }
            
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

        //metodo editar repuesto
        public string editar(DProveedor Proveedor) {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try { 
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //se establecen los parametros a enviarse en el comando
                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@idproveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = Proveedor.IdProveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParNombreProv = new SqlParameter();
                ParNombreProv.SqlDbType = SqlDbType.VarChar;
                ParNombreProv.Size = 15;
                ParNombreProv.Value = Proveedor.NombreProveedor;
                SqlCmd.Parameters.Add(ParNombreProv);

                SqlParameter ParResponsable = new SqlParameter();
                ParResponsable.ParameterName = "@responsable";
                ParResponsable.SqlDbType = SqlDbType.VarChar;
                ParResponsable.Size = 15;
                ParResponsable.Value = Proveedor.Responsable;
                SqlCmd.Parameters.Add(ParResponsable);

                SqlParameter ParTelefonoProv = new SqlParameter();
                ParTelefonoProv.ParameterName = "@telefonoprov";
                ParTelefonoProv.SqlDbType = SqlDbType.VarChar;
                ParTelefonoProv.Size = 12;
                ParResponsable.Value = Proveedor.TelefonoProv;
                SqlCmd.Parameters.Add(ParResponsable);

                SqlParameter ParDireccionProv = new SqlParameter();
                ParDireccionProv.ParameterName = "@direccionprov";
                ParDireccionProv.SqlDbType = SqlDbType.VarChar;
                ParDireccionProv.Size = 50;
                ParDireccionProv.Value = Proveedor.DireccionProv;
                SqlCmd.Parameters.Add(ParDireccionProv);

                //ejecutamos el comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizó el Registro";
            }

            catch (Exception ex) { rpta = ex.Message; }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

        //metodo eliminar proveedor
        public string Eliminar(DProveedor Proveedor) {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //se establecen los parametros a enviarse en el comando
                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@idproveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = Proveedor.IdProveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);


                //ejecutamos el comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Eliminó el Registro";
            }

            catch (Exception ex) { rpta = ex.Message; }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        
        }

        //metodo mostrar proveedores
        public DataTable Mostrar() 
        {
            DataTable DtResultado = new DataTable("proveedor");

            SqlConnection SqlCon = new SqlConnection();
            try {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex) { DtResultado = null; }

            return DtResultado;
        }

        //metodo buscar por nombre proveedor
        public DataTable BuscarNombre(DProveedor Proveedor)
        {
            DataTable DtResultado = new DataTable("proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Proveedor.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex) { DtResultado = null; }
            return DtResultado;

        }

    }
}
