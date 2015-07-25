namespace Proyecto_AC_CLIMA
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
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_factura = new System.Windows.Forms.Button();
            this.btn_repuestos = new System.Windows.Forms.Button();
            this.btn_vehiculo = new System.Windows.Forms.Button();
            this.btn_empleado = new System.Windows.Forms.Button();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cliente
            // 
            this.btn_cliente.Location = new System.Drawing.Point(67, 33);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(135, 120);
            this.btn_cliente.TabIndex = 0;
            this.btn_cliente.Text = "Clientes";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_factura
            // 
            this.btn_factura.Location = new System.Drawing.Point(208, 33);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(135, 120);
            this.btn_factura.TabIndex = 1;
            this.btn_factura.Text = "Factura";
            this.btn_factura.UseVisualStyleBackColor = true;
            this.btn_factura.Click += new System.EventHandler(this.btn_factura_Click);
            // 
            // btn_repuestos
            // 
            this.btn_repuestos.Location = new System.Drawing.Point(349, 33);
            this.btn_repuestos.Name = "btn_repuestos";
            this.btn_repuestos.Size = new System.Drawing.Size(135, 120);
            this.btn_repuestos.TabIndex = 2;
            this.btn_repuestos.Text = "Repuestos";
            this.btn_repuestos.UseVisualStyleBackColor = true;
            this.btn_repuestos.Click += new System.EventHandler(this.btn_repuestos_Click);
            // 
            // btn_vehiculo
            // 
            this.btn_vehiculo.Location = new System.Drawing.Point(67, 177);
            this.btn_vehiculo.Name = "btn_vehiculo";
            this.btn_vehiculo.Size = new System.Drawing.Size(135, 120);
            this.btn_vehiculo.TabIndex = 3;
            this.btn_vehiculo.Text = "Vehículo";
            this.btn_vehiculo.UseVisualStyleBackColor = true;
            this.btn_vehiculo.Click += new System.EventHandler(this.btn_vehiculo_Click);
            // 
            // btn_empleado
            // 
            this.btn_empleado.Location = new System.Drawing.Point(208, 177);
            this.btn_empleado.Name = "btn_empleado";
            this.btn_empleado.Size = new System.Drawing.Size(135, 120);
            this.btn_empleado.TabIndex = 4;
            this.btn_empleado.Text = "Empleado";
            this.btn_empleado.UseVisualStyleBackColor = true;
            this.btn_empleado.Click += new System.EventHandler(this.btn_empleado_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Location = new System.Drawing.Point(349, 177);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(135, 120);
            this.btn_reportes.TabIndex = 5;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 346);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.btn_empleado);
            this.Controls.Add(this.btn_vehiculo);
            this.Controls.Add(this.btn_repuestos);
            this.Controls.Add(this.btn_factura);
            this.Controls.Add(this.btn_cliente);
            this.Name = "Principal";
            this.Text = "Principal";
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