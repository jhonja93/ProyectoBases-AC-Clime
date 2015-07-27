using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    class Nvehiculo
    {
        //Método Insertar que llama al método Insertar de la clase DVehiculo
        //de la CapaDatos
        public static string Insertar(string placa, string nChasis, string marca, string modelo, int idCliente)
        {
            DVehiculo Obj = new DVehiculo();
            Obj.PlacaVeh = placa;
            Obj.NChasis = nChasis;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.IdCliente = idCliente;
            return Obj.Insertar(Obj);
        }
        //Método Editar que llama al método Editar de la clase DVehiculo
        //de la CapaDatos
        public static string Editar(string placa, string nChasis, string marca, string modelo, int idCliente)
        {
            DVehiculo Obj = new DVehiculo();
            Obj.PlacaVeh = placa;
            Obj.NChasis = nChasis;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.IdCliente = idCliente;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase Dvehiculo
        //de la CapaDatos
        public static string Eliminar(string placa)
        {
            DVehiculo Obj = new DVehiculo();
            Obj.PlacaVeh = placa;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase Dvehiculo
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DVehiculo().Mostrar();
        }

        public static DataTable BuscarPlaca(string textobuscar)
        {
            DVehiculo Obj = new DVehiculo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarPlaca(Obj);
        }

        public static DataTable BuscarChasis(string textobuscar)
        {
            DVehiculo Obj = new DVehiculo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarChasis(Obj);
        }

        public static DataTable BuscarCedula(string textobuscar)
        {
            DVehiculo Obj = new DVehiculo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCedula(Obj);
        }
    }
}
