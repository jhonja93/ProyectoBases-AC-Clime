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

        private bool isValid(string campo)
        {
            if (campo.Equals("costo"))
            {
                return RegExp(@"^[0-9]+(\.[0-9]+)?$", textBox12.Text);
            }
            return false;
        }
        private bool RegExp(string re, string text)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(text))
                return true;
            return false;

        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
     

        private void textBox8_Leave(object sender, EventArgs e)
        {
            
         }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "AC-Clima", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "AC-Clima", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (!isValid("costo"))
            {
                MensajeError(" formato de costo de mano de obra incorrecto");
                //errorIcon.Icon = Properties.Resources.error;
                //errorIcon.SetError(txtCorreo, "Correo Invalido");
            }
            else
            {
                MensajeOk("ok");
                //errorIcon.Icon = Properties.Resources.Ok;
                //errorIcon.SetError(txtCorreo, "Ok");
                //errorIcon.Dispose();
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)||char.IsPunctuation(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        
    }
}
