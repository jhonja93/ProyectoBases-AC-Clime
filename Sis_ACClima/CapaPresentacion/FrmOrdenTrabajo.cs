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
    public partial class FrmOrdenTrabajo : Form
    {
        public FrmOrdenTrabajo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRestante_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtTotalAPagar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTotalAPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtAdelanto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtAdelanto_Leave(object sender, EventArgs e)
        {
            if(Convert.ToInt32(this.txtTotalAPagar.Text)>=Convert.ToInt32(this.txtAdelanto.Text))
            { 
                this.txtRestante.Text = Convert.ToString(Convert.ToInt32(this.txtTotalAPagar.Text) - Convert.ToInt32(this.txtAdelanto.Text));
            }
            

        }
    }
}
