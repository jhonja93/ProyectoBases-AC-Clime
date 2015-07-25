﻿using System;
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
    public partial class Repuesto : Form
    {
        public Repuesto()
        {
            InitializeComponent();
        }

        private void btn_rep_nuevo_Click(object sender, EventArgs e)
        {
            Registrar_repuesto reg_repuesto = new Registrar_repuesto();
            reg_repuesto.ShowDialog();
        }

        private void btn_rep_modificar_Click(object sender, EventArgs e)
        {
            Modificar_repuesto mod_repuesto = new Modificar_repuesto();
            mod_repuesto.ShowDialog();
        }

        private void btn_rep_consultar_Click(object sender, EventArgs e)
        {
            Consultar_repuesto consultar_repuesto = new Consultar_repuesto();
            consultar_repuesto.ShowDialog();
        }
    }
}