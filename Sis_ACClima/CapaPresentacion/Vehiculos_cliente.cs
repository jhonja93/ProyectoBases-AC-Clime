using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Vehiculos_cliente : Form
    {
        public Vehiculos_cliente()
        {
            InitializeComponent();
        }

        private void btn_añadir_vehiculo_Click(object sender, EventArgs e)
        {
            AgregarVehiculo ad_vehiculo = new AgregarVehiculo();
            ad_vehiculo.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Vehiculos_cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
