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
    public partial class Listado_cliente : Form
    {
        public Listado_cliente()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Listado_cliente_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Apellido")
            {
                this.textBox1.MaxLength = 20;
                this.textBox1.Text = "";
            }
            if (comboBox1.Text == "Cedula")
            {
                this.textBox1.Text = "";
                this.textBox1.MaxLength = 10;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.comboBox1.Text == "Cedula")
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                    e.Handled = true;
            }
            if (this.comboBox1.Text == "Apellido")
            {
                if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                    e.Handled = true;


            }
        }
    }
}
