using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class DProveedor
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
        public DProveedor(Int32 idProveedor, string nombreProv, string responsable, string telefonoProv, string direccionProv, string textoBuscar) {

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

            MySqlConnection SqlCon = new MySqlConnection();

            try {
                //abrir conexion
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();

                //definir el comando
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros a enviarse con el comando, dependen del procedure creado en la base, se crea una nueva instancia
                //de MySqlParameter por cada parametro del procedure
                MySqlParameter ParIdProveedor = new MySqlParameter();
                ParIdProveedor.ParameterName = "@idproveedor";
                ParIdProveedor.MySqlDbType = MySqlDbType.Int32;
                ParIdProveedor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdProveedor);

                MySqlParameter ParNombreProv = new MySqlParameter();
                ParNombreProv.ParameterName = "@nombreprov";
                ParNombreProv.MySqlDbType = MySqlDbType.VarChar;
                ParNombreProv.Size = 15;
                ParNombreProv.Value = Proveedor.NombreProveedor;
                SqlCmd.Parameters.Add(ParNombreProv);

                MySqlParameter ParResponsable = new MySqlParameter();
                ParResponsable.ParameterName = "@responsable";
                ParResponsable.MySqlDbType = MySqlDbType.VarChar;
                ParResponsable.Size = 15;
                ParResponsable.Value = Proveedor.Responsable;
                SqlCmd.Parameters.Add(ParResponsable);

                MySqlParameter ParTelefonoProv = new MySqlParameter();
                ParTelefonoProv.ParameterName = "@telefonoprov";
                ParTelefonoProv.MySqlDbType = MySqlDbType.VarChar;
                ParTelefonoProv.Size = 12;
                ParResponsable.Value = Proveedor.TelefonoProv;
                SqlCmd.Parameters.Add(ParResponsable);

                MySqlParameter ParDireccionProv = new MySqlParameter();
                ParDireccionProv.ParameterName = "@direccionprov";
                ParDireccionProv.MySqlDbType = MySqlDbType.VarChar;
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

        //metodo editar proveedor
        public string Editar(DProveedor Proveedor) {
            string rpta = "";

            MySqlConnection SqlCon = new MySqlConnection();
            try { 
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();

                //establecer el comando
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //se establecen los parametros a enviarse en el comando
                MySqlParameter ParIdProveedor = new MySqlParameter();
                ParIdProveedor.ParameterName = "@idproveedor";
                ParIdProveedor.MySqlDbType = MySqlDbType.Int32;
                ParIdProveedor.Value = Proveedor.IdProveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);

                MySqlParameter ParNombreProv = new MySqlParameter();
                ParNombreProv.MySqlDbType = MySqlDbType.VarChar;
                ParNombreProv.Size = 15;
                ParNombreProv.Value = Proveedor.NombreProveedor;
                SqlCmd.Parameters.Add(ParNombreProv);

                MySqlParameter ParResponsable = new MySqlParameter();
                ParResponsable.ParameterName = "@responsable";
                ParResponsable.MySqlDbType = MySqlDbType.VarChar;
                ParResponsable.Size = 15;
                ParResponsable.Value = Proveedor.Responsable;
                SqlCmd.Parameters.Add(ParResponsable);

                MySqlParameter ParTelefonoProv = new MySqlParameter();
                ParTelefonoProv.ParameterName = "@telefonoprov";
                ParTelefonoProv.MySqlDbType = MySqlDbType.VarChar;
                ParTelefonoProv.Size = 12;
                ParResponsable.Value = Proveedor.TelefonoProv;
                SqlCmd.Parameters.Add(ParResponsable);

                MySqlParameter ParDireccionProv = new MySqlParameter();
                ParDireccionProv.ParameterName = "@direccionprov";
                ParDireccionProv.MySqlDbType = MySqlDbType.VarChar;
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

            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();

                //establecer el comando
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //se establecen los parametros a enviarse en el comando
                MySqlParameter ParIdProveedor = new MySqlParameter();
                ParIdProveedor.ParameterName = "@idproveedor";
                ParIdProveedor.MySqlDbType = MySqlDbType.Int32;
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

            MySqlConnection SqlCon = new MySqlConnection();
            try {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }

            return DtResultado;
        }

        //metodo buscar por nombre proveedor
        public DataTable BuscarNombre(DProveedor Proveedor)
        {
            DataTable DtResultado = new DataTable("proveedor");
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Proveedor.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;

        }

        //metodo buscar por responsable
        public DataTable BuscarResponsable(DProveedor Proveedor)
        {
            DataTable DtResultado = new DataTable("proveedor");
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_proveedor_responsable";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Proveedor.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;

        }

    }
}
