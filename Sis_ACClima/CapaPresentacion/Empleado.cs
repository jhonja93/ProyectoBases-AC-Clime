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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void btn_emp_nuevo_Click(object sender, EventArgs e)
        {
            Registrar_empleado reg_empleado = new Registrar_empleado();
            reg_empleado.ShowDialog();
        }

        private void btn_emp_modificar_Click(object sender, EventArgs e)
        {
            Modificar_empleado mod_empleado = new Modificar_empleado();
            mod_empleado.ShowDialog();
        }

        private void btn_emp_consultar_Click(object sender, EventArgs e)
        {
            Consultar_empleado consultar_empleado = new Consultar_empleado();
            consultar_empleado.ShowDialog();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {

        }
    }
}
