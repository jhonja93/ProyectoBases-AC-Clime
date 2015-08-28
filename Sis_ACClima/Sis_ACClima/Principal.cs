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
            FrmRepuesto repuesto = new FrmRepuesto();
            this.Hide();
            repuesto.ShowDialog();
            this.Show();
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado empleado = new FrmEmpleado();
            this.Hide();
            empleado.ShowDialog();
            this.Show();
        }

        private void btn_vehiculo_Click(object sender, EventArgs e)
        {
            FrmVehiculo buscar_vehiculo = new FrmVehiculo();
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
            Class1 conexion = new Class1();

            if (conexion.estadoConexion() == "")
            {
                MessageBox.Show("Conectado correctamente", "Conexión con la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.lblconexion.Text = "Conectado";
                this.lblconexion.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show("No se pudo establecer conexión con la Base de Datos\n\n" + conexion.estadoConexion(), "Conexión con la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                this.lblconexion.Text = "Desconectado";
                this.lblconexion.ForeColor = System.Drawing.Color.Red;
            }
               
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
