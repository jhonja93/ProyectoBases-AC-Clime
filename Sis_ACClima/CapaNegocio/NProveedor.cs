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
        //Método Insertar que llama al método Insertar de la clase DProveedor
        //de la CapaDatos
        public static string Insertar(string nombre, string responsable, string direccion, string telefono)
        {
            DProveedor Obj = new DProveedor();
            Obj.NombreProveedor = nombre;
            Obj.Responsable = responsable;
            Obj.DireccionProv = direccion;
            Obj.TelefonoProv = telefono;
            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DProveedor
        //de la CapaDatos
        public static string Editar(int idproveedor, string nombre, string responsable, string direccion, string telefono)
        {
            DProveedor Obj = new DProveedor();
            Obj.NombreProveedor = nombre;
            Obj.Responsable = responsable;
            Obj.IdProveedor = idproveedor;
            Obj.DireccionProv = direccion;
            Obj.TelefonoProv = telefono;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DProveedor
        //de la CapaDatos
        public static string Eliminar(int idproveedor)
        {
            DProveedor Obj = new DProveedor();
            Obj.IdProveedor = idproveedor;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DProveedor
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DProveedor().Mostrar();
        }

        //Método BuscarRazon_Social que llama al método BuscarNombre
        //de la clase DProveedor de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarResponsable(Obj);
        }

        //Método BuscarNum_Documento que llama al método BuscarResponsable
        //de la clase DProveedor de la CapaDatos
        public static DataTable BuscarResponsable(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarResponsable(Obj);
        }
    }
}

