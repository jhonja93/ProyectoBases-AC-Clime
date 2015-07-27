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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_ad_cliente_Click(object sender, EventArgs e)
        {
            Listado_cliente listado = new Listado_cliente();
            listado.ShowDialog();
        }

<<<<<<< HEAD
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
=======
        private void Factura_Load(object sender, EventArgs e)
        {
>>>>>>> f08104829075419c4fe2ad75989ac797c460c9a7

        }
    }
}
