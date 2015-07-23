using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class DEmpleado
    {
        private int _CedulaEmpl;
        private string _Nombre;
        private string _Telefono;
        private string _Direccion;
        private string _Apellido;

        private string _TextoBuscar;


        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public int CedulaEmpl
        {
            get { return _CedulaEmpl; }
            set { _CedulaEmpl = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public DEmpleado() { }

        public DEmpleado(int cedulaEmpl, string nombre, string apellido, string telefono, string direccion, string textobuscar) {
            this.CedulaEmpl = cedulaEmpl;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.TextoBuscar = textobuscar;
            this.Apellido = apellido;
        }


        //metodo insertar proveedor

        public string Insertar(DEmpleado Empleado) {

            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //abrir conexino
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //definir el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCedulaEmpl = new SqlParameter();
                ParCedulaEmpl.ParameterName = "@cedula_empl";
                ParCedulaEmpl.SqlDbType = SqlDbType.Int;
                ParCedulaEmpl.Value = Empleado.CedulaEmpl;
                SqlCmd.Parameters.Add(ParCedulaEmpl);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_empl";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 20;
                ParNombre.Value = Empleado.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido_empl";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 20;
                ParApellido.Value = Empleado.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion_empl";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono_empl";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                //ejecutamos el comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se Ingresó el registro";


            }
            catch (Exception ex) { rpta = ex.Message; }
            finally {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

        //metodo editar Empleado
        public string Editar(DEmpleado Empleado)
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCedulaEmpl = new SqlParameter();
                ParCedulaEmpl.ParameterName = "@cedula_empl";
                ParCedulaEmpl.SqlDbType = SqlDbType.Int;
                ParCedulaEmpl.Value = Empleado.CedulaEmpl;
                SqlCmd.Parameters.Add(ParCedulaEmpl);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_empl";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 20;
                ParNombre.Value = Empleado.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido_empl";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 20;
                ParApellido.Value = Empleado.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion_empl";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono_empl";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                //ejecutamos el comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "no se Ingresó el registro";


            }
            catch (Exception ex) { rpta = ex.Message; }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

        public string Eliminar(DEmpleado Empleado)
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCedulaEmpl = new SqlParameter();
                ParCedulaEmpl.ParameterName = "@cedula_empl";
                ParCedulaEmpl.SqlDbType = SqlDbType.Int;
                ParCedulaEmpl.Value = Empleado.CedulaEmpl;
                SqlCmd.Parameters.Add(ParCedulaEmpl);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Eliminar Empleado";
            }
            catch (Exception ex) { rpta = ex.Message; }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }


        //metodo mostrar empleados
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("empleado");

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex) { DtResultado = null; }

            return DtResultado;
        }


        //metodo buscar por nombre empleado
        public DataTable BuscarNombre(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex) { DtResultado = null; }
            return DtResultado;

        }









    }
}
