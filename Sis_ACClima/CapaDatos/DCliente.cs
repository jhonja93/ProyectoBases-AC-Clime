using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
//using MySql.Data.MySqlClient;


namespace CapaDatos
{
    public class DCliente
    {
        private Int32 _Idcliente;
        private string _nombreCliente;
        private string _apellidoCliente;
        private string _tipoDocumento;
        private string _numeroDocumento;
        private string _tipoCliente;
        private string _correoCliente;
        private string _telefonoCliente;
        private string _direccionCliente;
        private string _TextoBuscar;

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public string TipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
        }

        public string NumeroDocumento
        {
            get { return _numeroDocumento; }
            set { _numeroDocumento = value; }
        }

        public string TipoCliente
        {
            get { return _tipoCliente; }
            set { _tipoCliente = value; }
        }    

        public string CorreoCliente
        {
            get { return _correoCliente; }
            set { _correoCliente = value; }
        }

        public string TelefonoCliente
        {
            get { return _telefonoCliente; }
            set { _telefonoCliente = value; }
        }  

        public string DireccionCliente
        {
            get { return _direccionCliente; }
            set { _direccionCliente = value; }
        }

        public int Idcliente
        {
            get { return _Idcliente; }
            set { _Idcliente = value; }
        }

        public string NombreCliente
        {
            get { return _nombreCliente; }
            set { _nombreCliente = value; }
        }

        public string ApellidoCliente
        {
            get { return _apellidoCliente; }
            set { _apellidoCliente = value; }
        }

        //Constructor Vacio
        public DCliente()
        {

        }

        //Constructor con Parametros
        public DCliente(Int32 idCliente, string nombre, string apellido, string tipoDoc, string numeroDoc, string tipoCli, string correo, string telefono, string direccion, string textoBuscar) 
        {
            this.Idcliente = idCliente;
            this.NombreCliente = nombre;
            this.ApellidoCliente = apellido;
            this.TipoDocumento = tipoDoc;
            this.NumeroDocumento = numeroDoc;
            this.TipoCliente = tipoCli;
            this.CorreoCliente = correo;
            this.TipoCliente = telefono;
            this.DireccionCliente = direccion;
            this.TextoBuscar = textoBuscar;
        }

        //Metodo Insertar
        public string Insertar(DCliente Cliente)
        {
            string respuesta = "";
            SqlConnection MySqlCon = new SqlConnection();
            try
            {
                //Codigo
                MySqlCon.ConnectionString = Conexion.conexion;
                MySqlCon.Open(); //Abrimos conexion con Sql
                //Establecer comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = MySqlCon;
                SqlCmd.CommandText = "spinsertar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Ingresamos parametros

                //Parametro idCliente
                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdCliente);

                //Parametro nombreCliente
                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 20;
                ParNombre.Value = Cliente.NombreCliente;
                SqlCmd.Parameters.Add(ParNombre);
                
                //Parametro apellidoCliente
                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 20;
                ParApellido.Value = Cliente.ApellidoCliente;
                SqlCmd.Parameters.Add(ParApellido);

                //Parametro tipoDocumento
                SqlParameter ParTipoDoc = new SqlParameter();
                ParTipoDoc.ParameterName = "@tipo_documento";
                ParTipoDoc.SqlDbType = SqlDbType.VarChar;
                ParTipoDoc.Size = 10;
                ParTipoDoc.Value = Cliente.TipoDocumento;
                SqlCmd.Parameters.Add(ParTipoDoc);

                //Parametro numeroDocumento
                SqlParameter ParNumDoc = new SqlParameter();
                ParNumDoc.ParameterName = "@numero_documento";
                ParNumDoc.SqlDbType = SqlDbType.VarChar;
                ParNumDoc.Size = 15;
                ParNumDoc.Value = Cliente.NumeroDocumento;
                SqlCmd.Parameters.Add(ParNumDoc);

                //Parametro TipoCliente
                SqlParameter ParTipoCliente = new SqlParameter();
                ParTipoCliente.ParameterName = "@tipo";
                ParTipoCliente.SqlDbType = SqlDbType.VarChar;
                ParTipoCliente.Size = 10;
                ParTipoCliente.Value = Cliente.TipoCliente;
                SqlCmd.Parameters.Add(ParTipoCliente);

                //Parametro correoCliente
                SqlParameter ParCorreoCli = new SqlParameter();
                ParCorreoCli.ParameterName = "@correo";
                ParCorreoCli.SqlDbType = SqlDbType.VarChar;
                ParCorreoCli.Size = 50;
                ParCorreoCli.Value = Cliente.CorreoCliente;
                SqlCmd.Parameters.Add(ParCorreoCli);

                //Parametro telefonoCliente
                SqlParameter ParTelefCLie = new SqlParameter();
                ParTelefCLie.ParameterName = "@telefono";
                ParTelefCLie.SqlDbType = SqlDbType.VarChar;
                ParTelefCLie.Size = 15;
                ParTelefCLie.Value = Cliente.TelefonoCliente;
                SqlCmd.Parameters.Add(ParTelefCLie);

                //Parametro direccionCliente
                SqlParameter ParDireCli = new SqlParameter();
                ParDireCli.ParameterName = "@direccion";
                ParDireCli.SqlDbType = SqlDbType.VarChar;
                ParDireCli.Size = 50;
                ParDireCli.Value = Cliente.DireccionCliente;
                SqlCmd.Parameters.Add(ParDireCli);

                //Ejecutamos nuestro comando

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso al Registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally 
            {
                if (MySqlCon.State == ConnectionState.Open) MySqlCon.Close();
            }
            return respuesta;
        }

        //Metodo Editar
        public string Editar(DCliente Cliente)
        {
            string respuesta = "";
            SqlConnection MySqlCon = new SqlConnection();
            try
            {
                //Codigo
                MySqlCon.ConnectionString = Conexion.conexion;
                MySqlCon.Open(); //Abrimos conexion con Sql
                //Establecer comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = MySqlCon;
                SqlCmd.CommandText = "speditar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                /*-------Ingresamos parametros---------*/

                //Parametro idCliente
                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Cliente.Idcliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                //Parametro nombreCliente
                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 20;
                ParNombre.Value = Cliente.NombreCliente;
                SqlCmd.Parameters.Add(ParNombre);

                //Parametro apellidoCliente
                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 20;
                ParApellido.Value = Cliente.ApellidoCliente;
                SqlCmd.Parameters.Add(ParApellido);

                //Parametro tipoDocumento
                SqlParameter ParTipoDoc = new SqlParameter();
                ParTipoDoc.ParameterName = "@tipo_documento";
                ParTipoDoc.SqlDbType = SqlDbType.VarChar;
                ParTipoDoc.Size = 10;
                ParTipoDoc.Value = Cliente.TipoDocumento;
                SqlCmd.Parameters.Add(ParTipoDoc);

                //Parametro numeroDocumento
                SqlParameter ParNumDoc = new SqlParameter();
                ParNumDoc.ParameterName = "@numero_documento";
                ParNumDoc.SqlDbType = SqlDbType.VarChar;
                ParNumDoc.Size = 15;
                ParNumDoc.Value = Cliente.NumeroDocumento;
                SqlCmd.Parameters.Add(ParNumDoc);

                //Parametro TipoCliente
                SqlParameter ParTipoCliente = new SqlParameter();
                ParTipoCliente.ParameterName = "@tipo";
                ParTipoCliente.SqlDbType = SqlDbType.VarChar;
                ParTipoCliente.Size = 10;
                ParTipoCliente.Value = Cliente.TipoCliente;
                SqlCmd.Parameters.Add(ParTipoCliente);

                //Parametro correoCliente
                SqlParameter ParCorreoCli = new SqlParameter();
                ParCorreoCli.ParameterName = "@correo";
                ParCorreoCli.SqlDbType = SqlDbType.VarChar;
                ParCorreoCli.Size = 50;
                ParCorreoCli.Value = Cliente.CorreoCliente;
                SqlCmd.Parameters.Add(ParCorreoCli);

                //Parametro telefonoCliente
                SqlParameter ParTelefCLie = new SqlParameter();
                ParTelefCLie.ParameterName = "@telefono";
                ParTelefCLie.SqlDbType = SqlDbType.VarChar;
                ParTelefCLie.Size = 15;
                ParTelefCLie.Value = Cliente.TelefonoCliente;
                SqlCmd.Parameters.Add(ParTelefCLie);

                //Parametro direccionCliente
                SqlParameter ParDireCli = new SqlParameter();
                ParDireCli.ParameterName = "@direccion";
                ParDireCli.SqlDbType = SqlDbType.VarChar;
                ParDireCli.Size = 50;
                ParDireCli.Value = Cliente.DireccionCliente;
                SqlCmd.Parameters.Add(ParDireCli);

                //Ejecutamos nuestro comando

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Actualizo el Registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (MySqlCon.State == ConnectionState.Open) MySqlCon.Close();
            }
            return respuesta;
        }

        //Metodo Eliminar
        public string Eliminar(DCliente Cliente)
        {
            string respuesta = "";
            SqlConnection MySqlCon = new SqlConnection();
            try
            {
                //Codigo
                MySqlCon.ConnectionString = Conexion.conexion;
                MySqlCon.Open(); //Abrimos conexion con Sql
                //Establecer comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = MySqlCon;
                SqlCmd.CommandText = "speliminar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                /*-------Ingresamos parametros---------*/

                //Parametro idCliente
                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Cliente.Idcliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                //Ejecutamos nuestro comando

                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Elimino el Registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (MySqlCon.State == ConnectionState.Open) MySqlCon.Close();
            }
            return respuesta;
        }

        //Metodo Mostrar
        public DataTable Mostrar() 
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection MySqlCon = new SqlConnection();
            try
            {
                MySqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = MySqlCon;
                SqlCmd.CommandText = "spmostrar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Metodo BuscarNombre
        public DataTable BuscarNombre(DCliente Cliente) 
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection MySqlCon = new SqlConnection();
            try
            {
                MySqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = MySqlCon;
                SqlCmd.CommandText = "spbuscar_cliente_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Metodo BuscarApellido
        public DataTable BuscarApellido(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection MySqlCon = new SqlConnection();
            try
            {
                MySqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = MySqlCon;
                SqlCmd.CommandText = "spbuscar_cliente_apellidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Metodo Buscar Numero Documento
        public DataTable BuscarNumeroDocumento(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection MySqlCon = new SqlConnection();
            try
            {
                MySqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = MySqlCon;
                SqlCmd.CommandText = "spbuscar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch
            {
                DtResultado = null;
            }
            return DtResultado;
        }


    }
}
