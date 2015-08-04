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
    public partial class FrmVehiculo : Form
    {
        public FrmVehiculo()
        {
            InitializeComponent();
            //this.btnOrdenTrabajo.Enabled = false;
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.comboBox1.Text == "Num. Documento" || this.comboBox1.Text == "Chasis")
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
                            if (char.IsLetter(e.KeyChar)||char.IsControl(e.KeyChar)) {
                                e.Handled = false;

                            }
                            else
                                e.Handled=true;

                           
            }
        }
        private bool isValid(string campo)
        {
            if (campo.Equals("placa"))
            {
                return RegExp(@"[a-zA-Z]{3}[0-9]{3,4}", txtBuscar.Text);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Placa") {
                this.txtBuscar.Text = "";
                this.txtBuscar.MaxLength = 7;
            }
                
                if (comboBox1.Text == "Num. Documento") {
                    this.txtBuscar.Text = "";
                    this.txtBuscar.MaxLength = 10;
                }
                
                if (comboBox1.Text == "Chasis") {
                    this.txtBuscar.Text = "";
                    this.txtBuscar.MaxLength = 13;
                }
               
                if (comboBox1.Text == "Apellido") {
                    this.txtBuscar.MaxLength = 20;
                    this.txtBuscar.Text = "";
                }
                
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "AC-Clima", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "AC-Clima", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Placa")
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
        }
    }
}
