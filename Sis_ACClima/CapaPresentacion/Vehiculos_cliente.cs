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
    public partial class Vehiculos_cliente : Form
    {
        public Vehiculos_cliente()
        {
            InitializeComponent();
        }

        private void btn_añadir_vehiculo_Click(object sender, EventArgs e)
        {
            Añadir_vehiculo ad_vehiculo = new Añadir_vehiculo();
            ad_vehiculo.ShowDialog();
        }
    }
}
