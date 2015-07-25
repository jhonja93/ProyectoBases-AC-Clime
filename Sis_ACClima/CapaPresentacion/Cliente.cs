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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cli_nuevo_Click(object sender, EventArgs e)
        {

            Registrar_cliente reg_cliente = new Registrar_cliente();
            reg_cliente.ShowDialog();
        }

        private void btn_cli_modificar_Click(object sender, EventArgs e)
        {
            Modificar_cliente mod_cliente = new Modificar_cliente();
            mod_cliente.ShowDialog();
        }

        private void btn_cli_consultar_Click(object sender, EventArgs e)
        {
            Consultar_cliente consultar_cliente = new Consultar_cliente();
            consultar_cliente.ShowDialog();
        }
    }
}
