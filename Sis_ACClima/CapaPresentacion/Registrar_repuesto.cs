﻿using System;
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
    public partial class Registrar_repuesto : Form
    {
        public Registrar_repuesto()
        {
            InitializeComponent();
        }

        private void btn_rep_reg_guardar_Click(object sender, EventArgs e)
        {
            string descripcion, marca, pventa;
            descripcion = txt_rep_reg_descripcion.Text.Trim(); //Trim sirve para quitar espacios iniciales;
            marca = txt_rep_reg_marca.Text;
            pventa = txt_rep_reg_pventa.Text;
            

            // si todos los campos estan vacios se impide que se guarden los datos
            if (descripcion == "" && marca == "" && pventa == "")
            {

                MessageBox.Show("Ingrese los datos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //-------------------------------------------------------------------//

            // si falta algun dato por ingresar tambien impide que se guarde
            else if (descripcion == "" || marca == "" || pventa == "")
            {
                MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            //------------------------------------------------------------------//

        }

        private void txt_rep_reg_descripcion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_rep_reg_marca_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_rep_reg_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrar_repuesto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_rep_reg_pventa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_rep_reg_pventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
             if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
               {
                  e.Handled = false;
               }
               else
                  e.Handled = true;
            
        }
    }
}
