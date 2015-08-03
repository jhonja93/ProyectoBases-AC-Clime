using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Busqueda_vehiculo : Form
    {
        public Busqueda_vehiculo()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Busqueda_vehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdenTrabajo_Click(object sender, EventArgs e)
        {
            new FrmOrdenTrabajo().ShowDialog();
        }
    }
}
