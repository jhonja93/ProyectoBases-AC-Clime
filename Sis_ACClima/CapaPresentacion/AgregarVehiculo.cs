using CapaNegocio;
using System;
using System.Collections;
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
    public partial class AgregarVehiculo : Form
    {
        private int _IdCliente;

        public AgregarVehiculo(Hashtable datos)
        {
            InitializeComponent( );
            this.IdCliente = Convert.ToInt32(datos["id"]);
            this.lblNombreCliente.Text  = Convert.ToString(datos["nombre"]) + " " + Convert.ToString(datos["apellido"]);
            
        }
       
        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_av_guardar_Click(object sender, EventArgs e)
        {
            String placa1, chasis, marca, modelo;
            placa1 = txtPlaca.Text;
            
            chasis = txt_av_chasis.Text;
            marca = txt_av_marca.Text;
            modelo = txt_av_modelo.Text;
            //cambios daniel
             try
            {
                string rpta = "";
                /*if (this.txtPlaca.Text == string.Empty ||
                    this.txt_av_placa2.Text == string.Empty ||
                    this.txt_av_chasis.Text == string.Empty ||
                    this.txtPlaca.Text.Length != 7|| this.txt_av_chasis.Text.Length!=17){
                    //poner los avisos de error
                }
                else{
                    if (this.IsNuevo)
                    {*/
                        rpta = NVehiculo.Insertar(txtPlaca.Text,txt_av_chasis.Text,txt_av_marca.Text,txt_av_modelo.Text,IdCliente);

                        if (rpta.Equals("OK")) this.MensajeOk("Se Inserto de forma correcta el registro");
                        else this.MensajeError(rpta);
                   
                }
            catch {}
            //////////////termino cambios daniel
                        
            // si todos los campos estan vacios se impide que se guarden los datos
            if (placa1 == "" && chasis == "" && marca == "" && modelo == "")
            {

                MessageBox.Show("Ingrese los datos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //-------------------------------------------------------------------//

            // si falta algun dato por ingresar tambien impide que se guarde
            else if (placa1 == "" || chasis == "" || marca == "" || modelo == "")
            {
                MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            //------------------------------------------------------------------//
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

           
        }

        private bool isValid(string campo)
        {
            if (campo.Equals("placa"))
            {
                return RegExp(@"[a-zA-Z]{3}[0-9]{3,4}", txtPlaca.Text);
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

        private void txt_av_placa2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_av_placa2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //pemitir que solo se ingresen numeros
            if (char.IsNumber(e.KeyChar))
            {
                //MessageBox.Show("Oe no ingreses numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }

            else
            {

                e.Handled = true;
            }

            //----------------------------------//-
        }

        private void txt_av_chasis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_av_chasis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
            //----------------------------------//-
        }

        private void Añadir_vehiculo_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
        
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlaca_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        //Mostrar mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "AC-Clima", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "AC-Clima", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            if (!isValid("placa"))
            {
                MensajeError("Placa incorrecta");
                //errorIcon.Icon = Properties.Resources.error;
                //errorIcon.SetError(txtCorreo, "Correo Invalido");
            }
            else
            {
                MensajeOk("Placa ok");
                //errorIcon.Icon = Properties.Resources.Ok;
                //errorIcon.SetError(txtCorreo, "Ok");
                //errorIcon.Dispose();
            }
        }

        private void txtPlaca_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
