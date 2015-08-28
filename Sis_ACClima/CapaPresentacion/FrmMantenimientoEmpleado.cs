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
    public partial class FrmMantenimientoEmpleado : Form
    {
        public FrmMantenimientoEmpleado()
        {
            InitializeComponent();
        }

        private void txt_emp_reg_nombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_emp_reg_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            //pemitir que solo se ingresen letras
            if (char.IsLetter(e.KeyChar))
            {
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

        private void txt_emp_reg_apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //pemitir que solo se ingresen letras
            if (char.IsLetter(e.KeyChar))
            {
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

        private void txt_emp_reg_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_emp_reg_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            //----------------------------------//-
        }

        private void txt_emp_reg_cedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_emp_reg_cedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_emp_reg_telefono_KeyPress(object sender, KeyPressEventArgs e)
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

        //Mostrar mensaje de cofirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "AC-Clima", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres, apellidos, cedula, telefono, direccion;
            nombres = txt_emp_reg_nombres.Text.Trim(); //Trim sirve para quitar espacios iniciales;
            apellidos = txt_emp_reg_apellidos.Text;
            cedula = txt_emp_reg_cedula.Text;
           

            // si algunos de los campos not null esta vacio se impide que se guarden los datos
            if (nombres == "" || apellidos == "" || cedula == "")
            {
                MensajeError("Faltan datos por ingresar");
            }
            else { MensajeOk("Registro Exitoso"); }
        }

        private void btn_emp_reg_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void FrmMantenimientoEmpleado_Load(object sender, EventArgs e)
        {

        }

    }
}
