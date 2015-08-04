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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void btn_emp_nuevo_Click(object sender, EventArgs e) // boton Agregar Empleado
        {
            FrmMantenimientoEmpleado reg_empleado = new FrmMantenimientoEmpleado();
            reg_empleado.ShowDialog();
        }

        private void btn_emp_modificar_Click(object sender, EventArgs e) // boton Editar Empleado
        {
            // Falta enviarle campos del empleado a editar

            FrmMantenimientoEmpleado reg_empleado = new FrmMantenimientoEmpleado();
            reg_empleado.ShowDialog();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Apellido")
            {
                this.txt_cli_buscar.MaxLength = 20;
                this.txt_cli_buscar.Text = "";
            }
            if (comboBox1.Text == "Cedula")
            {
                this.txt_cli_buscar.Text = "";
                this.txt_cli_buscar.MaxLength = 10;
            }
        }

        private void txt_cli_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.comboBox1.Text == "Cedula" )
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
                if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                    e.Handled = true;


            }

        }
    }
}
