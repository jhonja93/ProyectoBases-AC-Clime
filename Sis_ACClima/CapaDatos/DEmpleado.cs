using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class DEmpleado
    {
        private string _CedulaEmpl;
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

        public string CedulaEmpl
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

        public DEmpleado(string cedulaEmpl, string nombre, string apellido, string telefono, string direccion, string textobuscar) {
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

            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                //abrir conexino
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();

                //definir el comando
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParCedulaEmpl = new MySqlParameter();
                ParCedulaEmpl.ParameterName = "@cedula_empl";
                ParCedulaEmpl.MySqlDbType = MySqlDbType.VarChar;
                ParCedulaEmpl.Size = 10;
                ParCedulaEmpl.Value = Empleado.CedulaEmpl;
                SqlCmd.Parameters.Add(ParCedulaEmpl);

                MySqlParameter ParNombre = new MySqlParameter();
                ParNombre.ParameterName = "@nombre_empl";
                ParNombre.MySqlDbType = MySqlDbType.VarChar;
                ParNombre.Size = 20;
                ParNombre.Value = Empleado.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                MySqlParameter ParApellido = new MySqlParameter();
                ParApellido.ParameterName = "@apellido_empl";
                ParApellido.MySqlDbType = MySqlDbType.VarChar;
                ParApellido.Size = 20;
                ParApellido.Value = Empleado.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                MySqlParameter ParDireccion = new MySqlParameter();
                ParDireccion.ParameterName = "@direccion_empl";
                ParDireccion.MySqlDbType = MySqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                MySqlParameter ParTelefono = new MySqlParameter();
                ParTelefono.ParameterName = "@telefono_empl";
                ParTelefono.MySqlDbType = MySqlDbType.VarChar;
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

            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();

                //establecer el comando
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParCedulaEmpl = new MySqlParameter();
                ParCedulaEmpl.ParameterName = "@cedula_empl";
                ParCedulaEmpl.MySqlDbType = MySqlDbType.Int32;
                ParCedulaEmpl.Value = Empleado.CedulaEmpl;
                SqlCmd.Parameters.Add(ParCedulaEmpl);

                MySqlParameter ParNombre = new MySqlParameter();
                ParNombre.ParameterName = "@nombre_empl";
                ParNombre.MySqlDbType = MySqlDbType.VarChar;
                ParNombre.Size = 20;
                ParNombre.Value = Empleado.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                MySqlParameter ParApellido = new MySqlParameter();
                ParApellido.ParameterName = "@apellido_empl";
                ParApellido.MySqlDbType = MySqlDbType.VarChar;
                ParApellido.Size = 20;
                ParApellido.Value = Empleado.Apellido;
                SqlCmd.Parameters.Add(ParApellido);

                MySqlParameter ParDireccion = new MySqlParameter();
                ParDireccion.ParameterName = "@direccion_empl";
                ParDireccion.MySqlDbType = MySqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = Empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                MySqlParameter ParTelefono = new MySqlParameter();
                ParTelefono.ParameterName = "@telefono_empl";
                ParTelefono.MySqlDbType = MySqlDbType.VarChar;
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

            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();

                //establecer el comando
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParCedulaEmpl = new MySqlParameter();
                ParCedulaEmpl.ParameterName = "@cedula_empl";
                ParCedulaEmpl.MySqlDbType = MySqlDbType.Int32;
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

            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }

            return DtResultado;
        }


        //metodo buscar por nombre empleado
        public DataTable BuscarNombre(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("empleado");
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleado_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;

        }

        //metodo buscar por apellido empleado
        public DataTable BuscarApellido(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("empleado");
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleado_apellido";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;

        }

        //metodo buscar por cedula empleado
        public DataTable BuscarCedula(DEmpleado Empleado)
        {
            DataTable DtResultado = new DataTable("empleado");
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_empleado_cedula";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                MySqlParameter ParTextoBuscar = new MySqlParameter();
                ParTextoBuscar.ParameterName = "@TextoBuscar";
                ParTextoBuscar.MySqlDbType = MySqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Empleado.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                MySqlDataAdapter SqlDat = new MySqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch { DtResultado = null; }
            return DtResultado;

        }


    }
}
