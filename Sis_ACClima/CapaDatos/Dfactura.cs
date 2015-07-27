using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DFactura
    {
        private string _CodigoFactura;
        private DateTime _FechaEmision;
        private float _Iva;
        private float _Subtotal;
        private float _Total;
        private string _IdOrdenTrabajo;
        private int _EsCotizacion;
        private String _TextoBuscar;

        public String TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }


        public int EsCotizacion
        {
            get { return _EsCotizacion; }
            set { _EsCotizacion = value; }
        }
        public string IdOrdenTrabajo
        {
            get { return _IdOrdenTrabajo; }
            set { _IdOrdenTrabajo = value; }
        }
        public float Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
        public float Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }
        public float Iva
        {
            get { return _Iva; }
            set { _Iva = value; }
        }
        public DateTime FechaEmision
        {
            get { return _FechaEmision; }
            set { _FechaEmision = value; }
        }
        public string CodigoFactura
        {
            get { return _CodigoFactura; }
            set { _CodigoFactura = value; }
        }

        //metodo insertar factura
        //metodo editar factura
        //metodo eliminar factura
        //metodo buscar factura

    }
}
