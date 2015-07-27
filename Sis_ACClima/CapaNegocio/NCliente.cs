using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NCliente
    {
        /*Metodo Insertar que llama al metodo Insertar de la clase
         DCliente de la CapaDatos*/
        public static string Insertar(string nombre, string apellido,
            string tipoDoc, string numDoc, string tipoCli, string correo,
            string telefono, string direccion)
        {
            DCliente Obj = new DCliente();
            Obj.NombreCliente = nombre;
            Obj.ApellidoCliente = apellido;
            Obj.TipoDocumento = tipoDoc;
            Obj.NumeroDocumento = numDoc;
            Obj.TipoCliente = tipoCli;
            Obj.CorreoCliente = correo;
            Obj.TelefonoCliente = telefono;
            Obj.DireccionCliente = direccion;

            return Obj.Insertar(Obj);
        }

        /*Metodo Editar que llama al metodo Insertar de la clase
         DCliente de la CapaDatos*/
        public static string Editar(int idCliente, string nombre, string apellido,
            string tipoDoc, string numDoc, string tipoCli, string correo,
            string telefono, string direccion)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente = idCliente;
            Obj.NombreCliente = nombre;
            Obj.ApellidoCliente = apellido;
            Obj.TipoDocumento = tipoDoc;
            Obj.NumeroDocumento = numDoc;
            Obj.TipoCliente = tipoCli;
            Obj.CorreoCliente = correo;
            Obj.TelefonoCliente = telefono;
            Obj.DireccionCliente = direccion;

            return Obj.Editar(Obj);
        }

        /*Metodo Eliminar que llama al metodo Insertar de la clase
         DCliente de la CapaDatos*/
        public static string Eliminar(int idCliente)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente = idCliente;
            return Obj.Eliminar(Obj);
        }

        /*Metodo Mostrar que llama al metodo Insertar de la clase
         DCliente de la CapaDatos*/
        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }

        /*Metodo BuscarNombre que llama al metodo Insertar de la clase
         DCliente de la CapaDatos*/
        public static DataTable BuscarNombre(string textoBuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textoBuscar;
            return Obj.BuscarNombre(Obj);
        }

        /*Metodo BuscarApellidos que llama al metodo Insertar de la clase
         DCliente de la CapaDatos*/
        public static DataTable BuscarApellido(string textoBuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textoBuscar;
            return Obj.BuscarApellido(Obj);
        }

        /*Metodo BuscarNumeroDocumento que llama al metodo Insertar de la clase
         DCliente de la CapaDatos*/
        public static DataTable BuscarNumeroDocumento(string textoBuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textoBuscar;
            return Obj.BuscarNumeroDocumento(Obj);
        }
    }
}
