using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.ttMensaje.SetToolTip(this.txtBuscar, "Ingrese el nombre del cliente a Buscar");
            //FrmMatenimiento = new FrmMantenimientoCliente();
        }

        //Mostrar mensaje de cofirmacion
        private void MensajeOk(string mensaje) 
        {
            MessageBox.Show(mensaje, "AC-Clima", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "AC-Clima", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar los controles del formulario
        private void Limpiar()
        {
            this.txtBuscar.Text = string.Empty;
        }

        //Metodo para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }

        //Metodo Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NCliente.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Metodo BuscarNombres
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NCliente.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Metodo BuscarApellidos
        private void BuscarApellido()
        {
            this.dataListado.DataSource = NCliente.BuscarApellido(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Metodo BuscarNumeroDocumento
        private void BuscarNumeroDocumento()
        {
            this.dataListado.DataSource = NCliente.BuscarNumeroDocumento(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void button1_Click(object sender, EventArgs e) //Boton Mantenimiento
        {
            new FrmMantenimientoCliente().ShowDialog();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.OcultarColumnas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbBuscar.Text.Equals("Nombre")) this.BuscarNombre();
            if (cbBuscar.Text.Equals("Apellido")) this.BuscarApellido();
            if (cbBuscar.Text.Equals("Numero de Documento")) this.BuscarNumeroDocumento();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta seguro de Eliminar los Regisrtros Seleccionados?", "AC-Clima", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NCliente.Eliminar(Convert.ToInt32(codigo));

                            if (rpta.Equals("OK")) { this.MensajeOk("Se Elimino correctamente el/los registro"); }
                            else { this.MensajeError(rpta); }
                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
                this.dataListado.Columns[0].Visible = true;
            else
                this.dataListado.Columns[0].Visible = false;
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            Hashtable datos = new Hashtable();

            datos.Add("id", Convert.ToString(this.dataListado.CurrentRow.Cells["id_cliente"].Value));
            datos.Add("nombre", Convert.ToString(this.dataListado.CurrentRow.Cells["nombre_cli"].Value));
            datos.Add("apellido", Convert.ToString(this.dataListado.CurrentRow.Cells["apellido_cli"].Value));
            datos.Add("tipoDocumento", Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_documento"].Value));
            datos.Add("numeroDocumento", Convert.ToString(this.dataListado.CurrentRow.Cells["numero_documento"].Value));
            datos.Add("tipoCliente", Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_cli"].Value));
            datos.Add("correo", Convert.ToString(this.dataListado.CurrentRow.Cells["correo_cli"].Value));
            datos.Add("telefono", Convert.ToString(this.dataListado.CurrentRow.Cells["telefono_cli"].Value));
            datos.Add("direccion", Convert.ToString(this.dataListado.CurrentRow.Cells["direccion_cli"].Value));

            new FrmMantenimientoCliente(datos).ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Hashtable datos = new Hashtable();

            datos.Add("id", Convert.ToString(this.dataListado.CurrentRow.Cells["id_cliente"].Value));
            datos.Add("nombre", Convert.ToString(this.dataListado.CurrentRow.Cells["nombre_cli"].Value));
            datos.Add("apellido", Convert.ToString(this.dataListado.CurrentRow.Cells["apellido_cli"].Value));
            datos.Add("tipoDocumento", Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_documento"].Value));
            datos.Add("numeroDocumento", Convert.ToString(this.dataListado.CurrentRow.Cells["numero_documento"].Value));
            datos.Add("tipoCliente", Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_cli"].Value));
            datos.Add("correo", Convert.ToString(this.dataListado.CurrentRow.Cells["correo_cli"].Value));
            datos.Add("telefono", Convert.ToString(this.dataListado.CurrentRow.Cells["telefono_cli"].Value));
            datos.Add("direccion", Convert.ToString(this.dataListado.CurrentRow.Cells["direccion_cli"].Value));

            new FrmMantenimientoCliente(datos).ShowDialog();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.cbBuscar.Text == "Numero de Documento")
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                    e.Handled = true;
            }
            if (this.cbBuscar.Text == "Apellido")
            {
                if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                    e.Handled = true;
            }
            if (this.cbBuscar.Text == "Nombre")
            {
                if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                    e.Handled = true;
            }

        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscar.Text == "Apellido" || cbBuscar.Text == "Nombre")
            {
                this.txtBuscar.MaxLength = 20;
                this.txtBuscar.Text = "";
            }
            if (cbBuscar.Text == "Numero de Documento")
            {
                this.txtBuscar.Text = "";
                this.txtBuscar.MaxLength = 10;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

    }
}
