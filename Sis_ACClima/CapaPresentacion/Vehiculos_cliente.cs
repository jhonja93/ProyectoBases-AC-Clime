using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using System.Collections;

namespace CapaPresentacion
{
    public partial class Vehiculos_cliente : Form
    {
        string codigoCliente;
        public Vehiculos_cliente()
        {
            InitializeComponent();

        }

        public void mostrarVehiculosCliente() {
            this.dataListado.DataSource = NVehiculo.BuscarCedula(codigoCliente);
            this.dataListado.Columns[0].Visible = false;
        }

        public Vehiculos_cliente(Hashtable datos)
        {
            InitializeComponent();
            this.txtProp.Text = Convert.ToString(datos["propietario"]);
            this.txtNumDoc.Text = Convert.ToString(datos["numDoc"]);
            this.codigoCliente = Convert.ToString(datos["id"]);
        }

        private void btn_añadir_vehiculo_Click(object sender, EventArgs e)
        {
            Hashtable datos = new Hashtable();
            //datos.Add("id", txt_ced.Text);
       
            AgregarVehiculo ad_vehiculo = new AgregarVehiculo(datos);
            ad_vehiculo.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void busqueda_Vehiculo()
        {
            //this.dataListado.DataSource = NVehiculo.BuscarCedula(this.txt_ced.Text);
            this.OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void Vehiculos_cliente_Load(object sender, EventArgs e)
        {
            this.mostrarVehiculosCliente();
        }
       
       
    }
}
