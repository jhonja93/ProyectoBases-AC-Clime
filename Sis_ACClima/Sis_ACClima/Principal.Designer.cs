namespace CapaPresentacion
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_empleado = new System.Windows.Forms.Button();
            this.btn_vehiculo = new System.Windows.Forms.Button();
            this.btn_repuestos = new System.Windows.Forms.Button();
            this.btn_factura = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_reportes
            // 
            resources.ApplyResources(this.btn_reportes, "btn_reportes");
            this.btn_reportes.BackColor = System.Drawing.Color.White;
            this.btn_reportes.Image = global::CapaPresentacion.Properties.Resources.reporte;
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.UseVisualStyleBackColor = false;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_empleado
            // 
            resources.ApplyResources(this.btn_empleado, "btn_empleado");
            this.btn_empleado.BackColor = System.Drawing.Color.White;
            this.btn_empleado.Image = global::CapaPresentacion.Properties.Resources.trabajador;
            this.btn_empleado.Name = "btn_empleado";
            this.btn_empleado.UseVisualStyleBackColor = false;
            this.btn_empleado.Click += new System.EventHandler(this.btn_empleado_Click);
            // 
            // btn_vehiculo
            // 
            resources.ApplyResources(this.btn_vehiculo, "btn_vehiculo");
            this.btn_vehiculo.BackColor = System.Drawing.Color.White;
            this.btn_vehiculo.Image = global::CapaPresentacion.Properties.Resources.vehiculo;
            this.btn_vehiculo.Name = "btn_vehiculo";
            this.btn_vehiculo.UseVisualStyleBackColor = false;
            this.btn_vehiculo.Click += new System.EventHandler(this.btn_vehiculo_Click);
            // 
            // btn_repuestos
            // 
            resources.ApplyResources(this.btn_repuestos, "btn_repuestos");
            this.btn_repuestos.BackColor = System.Drawing.Color.White;
            this.btn_repuestos.Image = global::CapaPresentacion.Properties.Resources.repuestos;
            this.btn_repuestos.Name = "btn_repuestos";
            this.btn_repuestos.UseVisualStyleBackColor = false;
            this.btn_repuestos.Click += new System.EventHandler(this.btn_repuestos_Click);
            // 
            // btn_factura
            // 
            resources.ApplyResources(this.btn_factura, "btn_factura");
            this.btn_factura.BackColor = System.Drawing.Color.White;
            this.btn_factura.Image = global::CapaPresentacion.Properties.Resources.factura12;
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.UseVisualStyleBackColor = false;
            this.btn_factura.Click += new System.EventHandler(this.btn_factura_Click);
            // 
            // btn_cliente
            // 
            resources.ApplyResources(this.btn_cliente, "btn_cliente");
            this.btn_cliente.BackColor = System.Drawing.Color.White;
            this.btn_cliente.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondoBlanco;
            this.btn_cliente.Image = global::CapaPresentacion.Properties.Resources.clientes1;
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Tan;
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.btn_empleado);
            this.Controls.Add(this.btn_vehiculo);
            this.Controls.Add(this.btn_repuestos);
            this.Controls.Add(this.btn_factura);
            this.Controls.Add(this.btn_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.Button btn_repuestos;
        private System.Windows.Forms.Button btn_vehiculo;
        private System.Windows.Forms.Button btn_empleado;
        private System.Windows.Forms.Button btn_reportes;
    }
}