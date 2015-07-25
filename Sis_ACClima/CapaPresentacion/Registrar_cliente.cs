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
    public partial class Registrar_cliente : Form
    {
        public Registrar_cliente()
        {
            InitializeComponent();
        }

        private void btn_cli_reg_guardar_Click(object sender, EventArgs e)
        {
            string nombres, apellidos, cedula, telefono, direccion, correo;
            nombres = txt_cli_nombres.Text.Trim(); //Trim sirve para quitar espacios iniciales;
            apellidos = txt_cli_reg_apellidos.Text;
            cedula = txt_cli_reg_cedula.Text;
            telefono = txt_cli_reg_telefono.Text;
            direccion = txt_cli_reg_direccion.Text;
            correo = txt_cli_reg_correo.Text;

                    
            // si todos los campos estan vacios se impide que se guarden los datos
            if (nombres=="" && apellidos=="" && cedula=="" && telefono=="" && direccion=="" && correo=="") {

                MessageBox.Show("Ingrese los datos por favor","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            //-------------------------------------------------------------------//

            // si falta algun dato por ingresar tambien impide que se guarde
            else if (nombres == "" || apellidos == "" || cedula == "" || telefono == "" || direccion == "" || correo == "")
            {
                MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            //------------------------------------------------------------------//

            else
            {
                Añadir_vehiculo ad_vehiculo = new Añadir_vehiculo();
                ad_vehiculo.ShowDialog();
            }
        }

        private void txt_cli_nombres_Validated(object sender, EventArgs e)
        {
            
                        
        }

        private void txt_cli_nombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cli_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            //pemitir que solo se ingresen letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
        
            else if (char.IsControl(e.KeyChar)){

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

        private void txt_cli_reg_cedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cli_reg_cedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_cli_reg_apellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cli_reg_apellidos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_cli_reg_telefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_cli_reg_direccion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_cli_reg_correo_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
