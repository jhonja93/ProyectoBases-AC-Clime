using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string str = this.txtTotalAPagar.Text + e.KeyChar;
            e.Handled = !KeyEnteredIsValid(str) && !char.IsControl(e.KeyChar);
        }

        private void txtAdelanto_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = this.txtAdelanto.Text + e.KeyChar;
            e.Handled = !KeyEnteredIsValid(str) && !char.IsControl(e.KeyChar);
        }

        private void txtAdelanto_Leave(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToDouble(this.txtTotalAPagar.Text)>=Convert.ToDouble(this.txtAdelanto.Text))
             
                    this.txtRestante.Text = Convert.ToString(Convert.ToDouble(this.txtTotalAPagar.Text) - Convert.ToDouble(this.txtAdelanto.Text));
            }
            catch(Exception ex){}
            

        }
        private bool KeyEnteredIsValid(string key)
        {
            Regex regex;
            regex = new Regex(@"^(\d+|(\d+))(\,\d{0,2})?$");
            return regex.IsMatch(key);
        }
        private void FrmOrdenTrabajo_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimePicker1.Value.CompareTo(DateTime.Now)<0) {
                this.dateTimePicker1.Value = DateTime.Now;
            }
        }
    }
}
