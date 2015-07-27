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
    public partial class Modificar_repuesto : Form
    {
        public Modificar_repuesto()
        {
            InitializeComponent();
        }

        private void txt_rep_mod_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_rep_mod_descripcion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_rep_mod_marca_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_rep_mod_guardar_Click(object sender, EventArgs e)
        {
            string descripcion, marca, pventa;
            descripcion = txt_rep_mod_descripcion.Text.Trim(); //Trim sirve para quitar espacios iniciales;
            marca = txt_rep_mod_marca.Text;
            pventa = txt_rep_mod_pventa.Text;
            

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
    }
}
