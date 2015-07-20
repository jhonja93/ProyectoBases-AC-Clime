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
    public partial class FrmMantenimientoCliente : Form
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;


        public FrmMantenimientoCliente()
        {
            InitializeComponent();

            this.ttMensaje2.SetToolTip(this.txtNombre, "Ingrese el nombre del cliente");
            this.ttMensaje2.SetToolTip(this.txtApellido, "Ingrese el apellido del cliente");
            this.ttMensaje2.SetToolTip(this.txtCorreo, "Ingrese el correo del cliente");
            this.ttMensaje2.SetToolTip(this.txtNumDoc, "Ingrese el numero de documento del cliente");
            this.ttMensaje2.SetToolTip(this.txtTelefono, "Ingrese el telefono del cliente");
        }

        public FrmMantenimientoCliente(Hashtable datos)
        {
            InitializeComponent();
            this.Habilitar(false);
            this.Botones();

            this.ttMensaje2.SetToolTip(this.txtNombre, "Ingrese el nombre del cliente");
            this.ttMensaje2.SetToolTip(this.txtApellido, "Ingrese el apellido del cliente");
            this.ttMensaje2.SetToolTip(this.txtCorreo, "Ingrese el correo del cliente");
            this.ttMensaje2.SetToolTip(this.txtNumDoc, "Ingrese el numero de documento del cliente");
            this.ttMensaje2.SetToolTip(this.txtTelefono, "Ingrese el telefono del cliente");

            this.txtCodigo.Text = Convert.ToString(datos["id"]);
            this.txtNombre.Text = Convert.ToString(datos["nombre"]);
            this.txtApellido.Text = Convert.ToString(datos["apellido"]);
            this.txtCorreo.Text = Convert.ToString(datos["correo"]);
            this.txtDireccion.Text = Convert.ToString(datos["direccion"]);
            this.txtNumDoc.Text = Convert.ToString(datos["numeroDocumento"]);
            this.txtTelefono.Text = Convert.ToString(datos["telefono"]);
            this.cbxTipoDoc.Text = Convert.ToString(datos["tipoDocumento"]);
            this.lblTipoCliente.Text = Convert.ToString(datos["tipoCliente"]);
                
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
            this.txtNombre.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtNumDoc.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;

        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            //this.txtCodigo.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtCorreo.ReadOnly = !valor;
            this.txtNumDoc.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else 
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        private void Mostrar()
        {
            this.Habilitar(false);
            this.Botones();

            if (cbxTipoDoc.Text == "Cedula")
            {
                lblTipoCliente.Text = "Natural";
                lblNombre.Text = "Nombre:";
                lblApellido.Enabled = true;
                txtApellido.Enabled = true;
            }
            else if (cbxTipoDoc.Text == "RUC")
            {
                lblTipoCliente.Text = "Juridico";
                lblNombre.Text = "Empresa:";
                lblApellido.Enabled = false;
                txtApellido.Enabled = false;

            }
            else if (cbxTipoDoc.Text == "Pasaporte")
            {
                lblTipoCliente.Text = "Extranjero";
                lblNombre.Text = "Nombre:";
                lblApellido.Enabled = true;
                txtApellido.Enabled = true;
            } 

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoDoc.Text == "Cedula") 
            {
                lblTipoCliente.Text = "Natural";
                lblNombre.Text = "Nombre:";
                lblApellido.Enabled = true;
                txtApellido.Enabled = true;
            }
            else if (cbxTipoDoc.Text == "RUC")
            {
                lblTipoCliente.Text = "Juridico";
                lblNombre.Text = "Empresa:";
                lblApellido.Enabled = false;
                txtApellido.Enabled = false;

            }
            else if (cbxTipoDoc.Text == "Pasaporte")
            {
                lblTipoCliente.Text = "Extranjero";
                lblNombre.Text = "Nombre:";
                lblApellido.Enabled = true;
                txtApellido.Enabled = true;
            } 
        }

        private void FrmMantenimientoCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Habilitar(false);
            this.Botones();
            this.Mostrar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();
            //this.txtCodigo.ReadOnly = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty ||
                    this.txtApellido.Text == string.Empty ||
                    this.txtNumDoc.Text == string.Empty)
                {
                    MensajeError("Falta Ingresar Datos");
                    errorIcon.SetError(txtNombre, "Ingrese un Valor");
                    errorIcon.SetError(txtApellido, "Ingrese un Valor");
                    errorIcon.SetError(txtNumDoc, "Ingrese un Valor");
                }
                else 
                {
                    if (this.IsNuevo)
                    {
                        rpta = NCliente.Insertar(this.txtNombre.Text.Trim().ToUpper(), this.txtApellido.Text.Trim().ToUpper(), 
                            this.cbxTipoDoc.Text, this.txtNumDoc.Text, this.lblTipoCliente.Text, this.txtCorreo.Text.Trim(), this.txtTelefono.Text, this.txtDireccion.Text.ToUpper());

                        if (rpta.Equals("OK")) this.MensajeOk("Se Inserto de forma correcta el registro");
                        else this.MensajeError(rpta);
                    }
                    else 
                    {
                        rpta = NCliente.Editar(Convert.ToInt32(this.txtCodigo.Text),this.txtNombre.Text.Trim().ToUpper(), this.txtApellido.Text.Trim().ToUpper(),
                            this.cbxTipoDoc.Text, this.txtNumDoc.Text, this.lblTipoCliente.Text, this.txtCorreo.Text.Trim(), this.txtTelefono.Text, this.txtDireccion.Text.ToUpper());

                        if (rpta.Equals("OK")) this.MensajeOk("Se Actualizo de forma correcta el registro");
                        else this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtNumDoc_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else { this.MensajeError("Debe se seleccionar primero el registro a Modificar"); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Habilitar(false);
            this.Limpiar();
            this.txtCodigo.Text = string.Empty;

            this.Close();
        }
    }
}
