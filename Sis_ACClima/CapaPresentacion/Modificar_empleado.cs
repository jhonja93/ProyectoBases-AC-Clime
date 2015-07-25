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
    public partial class Modificar_empleado : Form
    {
        public Modificar_empleado()
        {
            InitializeComponent();
        }

        private void txt_emp_mod_nombres_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_emp_mod_apellidos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_emp_mod_direccion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_emp_mod_cedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_emp_mod_telefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_emp_mod_guardar_Click(object sender, EventArgs e)
        {
            string nombres, apellidos, cedula, telefono, direccion;
            nombres = txt_emp_mod_nombres.Text.Trim(); //Trim sirve para quitar espacios iniciales;
            apellidos = txt_emp_mod_apellidos.Text;
            cedula = txt_emp_mod_cedula.Text;
            telefono = txt_emp_mod_telefono.Text;
            direccion = txt_emp_mod_direccion.Text;


            // si todos los campos estan vacios se impide que se guarden los datos
            if (nombres == "" && apellidos == "" && cedula == "" && telefono == "" && direccion == "")
            {

                MessageBox.Show("Ingrese los datos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //-------------------------------------------------------------------//

            // si falta algun dato por ingresar tambien impide que se guarde
            else if (nombres == "" || apellidos == "" || cedula == "" || telefono == "" || direccion == "")
            {
                MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            //------------------------------------------------------------------//

        }
    }
}
