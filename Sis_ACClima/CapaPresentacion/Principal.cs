using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_AC_CLIMA
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void btn_repuestos_Click(object sender, EventArgs e)
        {
            Repuesto repuesto = new Repuesto();
            repuesto.ShowDialog();
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.ShowDialog();
        }

        private void btn_vehiculo_Click(object sender, EventArgs e)
        {
            Busqueda_vehiculo buscar_vehiculo = new Busqueda_vehiculo();
            buscar_vehiculo.ShowDialog();
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.ShowDialog();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            Reportes reporte = new Reportes();
            reporte.ShowDialog();
        }
    }
}
