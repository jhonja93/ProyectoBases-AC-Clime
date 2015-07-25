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
        //Método Insertar que llama al método Insertar de la clase DRepuesto
        //de la CapaDatos
        public static string Insertar(string nombre, string marca, string descripcion, float precioVenta, int stockInicial, int stockActual)
        {
            DRepuesto Obj = new DRepuesto();
            Obj.Nombre = nombre;
            Obj.Marca = marca;
            Obj.Descripcion = descripcion;
            Obj.PrecioVenta = precioVenta;
            Obj.StockInicial = stockInicial;
            Obj.StockActual = stockActual;
            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DRepuesto
        //de la CapaDatos
        public static string Editar(int idRepuesto, string nombre, string marca, string descripcion, float precioVenta, int stockInicial, int stockActual)
        {
            DRepuesto Obj = new DRepuesto();
            Obj.Idrepuesto = idRepuesto;
            Obj.Nombre = nombre;
            Obj.Marca = marca;
            Obj.Descripcion = descripcion;
            Obj.PrecioVenta = precioVenta;
            Obj.StockInicial = stockInicial;
            Obj.StockActual = stockActual;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DRepuesto
        //de la CapaDatos
        public static string Eliminar(int idRepuesto)
        {
            DRepuesto Obj = new DRepuesto();
            Obj.Idrepuesto = idRepuesto;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DRepuesto
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DRepuesto().Mostrar();
        }

        //Método BuscarRazon_Social que llama al método BuscarNombre
        //de la clase DRepuesto de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DRepuesto Obj = new DRepuesto();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        //Método BuscarNum_Documento que llama al método BuscarMarca
        //de la clase DRepuesto de la CapaDatos
        public static DataTable BuscarResponsable(string textobuscar)
        {
            DRepuesto Obj = new DRepuesto();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarMarca(Obj);
        }
    }
}

