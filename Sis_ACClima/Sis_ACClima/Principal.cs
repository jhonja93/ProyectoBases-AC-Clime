using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            this.Hide();
            cliente.ShowDialog();
            this.Show();
        }

        private void btn_repuestos_Click(object sender, EventArgs e)
        {
            Repuesto repuesto = new Repuesto();
            this.Hide();
            repuesto.ShowDialog();
            this.Show();
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            this.Hide();
            empleado.ShowDialog();
            this.Show();
        }

        private void btn_vehiculo_Click(object sender, EventArgs e)
        {
            Busqueda_vehiculo buscar_vehiculo = new Busqueda_vehiculo();
            this.Hide();
            buscar_vehiculo.ShowDialog();
            this.Show();
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            this.Hide();
            factura.ShowDialog();
            this.Show();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            Reportes reporte = new Reportes();
            this.Hide();
            reporte.ShowDialog();
            this.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.lblconexion.Text = new Class1().estadoConexion()==""?"conectado":"desconectado";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
