using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NEmpleado
    {
        //Método Insertar que llama al método Insertar de la clase DEmpleado
        //de la CapaDatos
        public static string Insertar(string nombre, string apellido, string telefono, string direccion)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Telefono = telefono;
            Obj.Direccion = direccion;
            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DEmpleado
        //de la CapaDatos
        public static string Editar(string cedula, string nombre, string apellido, string telefono, string direccion)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.CedulaEmpl = cedula;
            Obj.Nombre = nombre;
            Obj.Apellido = apellido;
            Obj.Telefono = telefono;
            Obj.Direccion = direccion;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DEmpleado
        //de la CapaDatos
        public static string Eliminar(string cedula)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.CedulaEmpl = cedula;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DEmpleado
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DEmpleado().Mostrar();
        }

        //Método BuscarNombre que llama al método BuscarNombre
        //de la clase DEmpleado de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        //Método BuscarApellido que llama al método BuscarApellido
        //de la clase DEmpleado de la CapaDatos
        public static DataTable BuscarApellido(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellido(Obj);
        }

        //Método BuscarCedula que llama al método BuscarCedula
        //de la clase DEmpleado de la CapaDatos
        public static DataTable BuscarCedula(string textobuscar)
        {
            DEmpleado Obj = new DEmpleado();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCedula(Obj);
        }
    }
}

