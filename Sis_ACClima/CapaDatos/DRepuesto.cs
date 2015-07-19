using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;



namespace CapaDatos
{
    class DRepuesto
    {
        private int _Idrepuesto;
        private string _Nombre;
        private string _Marca;
        private string _Descripcion;
        private float _PrecioVenta;
        private int _StockInicial;
        private int _StockActual;

        private string _TextoBuscar;

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public int StockActual
        {
            get { return _StockActual; }
            set { _StockActual = value; }
        }
        public int StockInicial
        {
            get { return _StockInicial; }
            set { _StockInicial = value; }
        }

        public float PrecioVenta
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }

        public int Idrepuesto
        {
            get { return _Idrepuesto; }
            set { _Idrepuesto = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }


    }
}
