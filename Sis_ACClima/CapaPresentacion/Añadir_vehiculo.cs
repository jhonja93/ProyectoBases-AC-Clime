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
    public partial class Añadir_vehiculo : Form
    {
        public Añadir_vehiculo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_av_guardar_Click(object sender, EventArgs e)
        {
            String placa1, placa2, chasis, marca, modelo;
            placa1 = txt_av_placa1.Text;
            placa2 = txt_av_placa2.Text;
            chasis = txt_av_chasis.Text;
            marca = txt_av_marca.Text;
            modelo = txt_av_modelo.Text;

                        
            // si todos los campos estan vacios se impide que se guarden los datos
            if (placa1 == "" && placa2 == "" && chasis == "" && marca == "" && modelo == "")
            {

                MessageBox.Show("Ingrese los datos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //-------------------------------------------------------------------//

            // si falta algun dato por ingresar tambien impide que se guarde
            else if (placa1 == "" || placa2 == "" || chasis == "" || marca == "" || modelo == "")
            {
                MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            //------------------------------------------------------------------//
        }

        private void txt_av_placa1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_av_placa1_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
