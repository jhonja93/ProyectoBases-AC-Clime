namespace CapaPresentacion
{
    partial class FrmMantenimientoEmpleado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_emp_reg_direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_emp_reg_telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_emp_reg_cedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_emp_reg_apellidos = new System.Windows.Forms.TextBox();
            this.txt_emp_reg_nombres = new System.Windows.Forms.TextBox();
            this.btn_emp_reg_guardar = new System.Windows.Forms.Button();
            this.btn_emp_reg_cancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_emp_reg_direccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_emp_reg_telefono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_emp_reg_cedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_emp_reg_apellidos);
            this.groupBox1.Controls.Add(this.txt_emp_reg_nombres);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del empleado";
            // 
            // txt_emp_reg_direccion
            // 
            this.txt_emp_reg_direccion.Location = new System.Drawing.Point(105, 130);
            this.txt_emp_reg_direccion.MaxLength = 256;
            this.txt_emp_reg_direccion.Multiline = true;
            this.txt_emp_reg_direccion.Name = "txt_emp_reg_direccion";
            this.txt_emp_reg_direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_emp_reg_direccion.Size = new System.Drawing.Size(226, 40);
            this.txt_emp_reg_direccion.TabIndex = 9;
            this.txt_emp_reg_direccion.TextChanged += new System.EventHandler(this.txt_emp_reg_direccion_TextChanged);
            this.txt_emp_reg_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_reg_direccion_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección";
            // 
            // txt_emp_reg_telefono
            // 
            this.txt_emp_reg_telefono.Location = new System.Drawing.Point(106, 104);
            this.txt_emp_reg_telefono.MaxLength = 9;
            this.txt_emp_reg_telefono.Name = "txt_emp_reg_telefono";
            this.txt_emp_reg_telefono.Size = new System.Drawing.Size(225, 20);
            this.txt_emp_reg_telefono.TabIndex = 7;
            this.txt_emp_reg_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_reg_telefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono";
            // 
            // txt_emp_reg_cedula
            // 
            this.txt_emp_reg_cedula.Location = new System.Drawing.Point(106, 77);
            this.txt_emp_reg_cedula.MaxLength = 10;
            this.txt_emp_reg_cedula.Name = "txt_emp_reg_cedula";
            this.txt_emp_reg_cedula.Size = new System.Drawing.Size(225, 20);
            this.txt_emp_reg_cedula.TabIndex = 5;
            this.txt_emp_reg_cedula.TextChanged += new System.EventHandler(this.txt_emp_reg_cedula_TextChanged);
            this.txt_emp_reg_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_reg_cedula_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nro. de cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // txt_emp_reg_apellidos
            // 
            this.txt_emp_reg_apellidos.Location = new System.Drawing.Point(106, 51);
            this.txt_emp_reg_apellidos.MaxLength = 20;
            this.txt_emp_reg_apellidos.Name = "txt_emp_reg_apellidos";
            this.txt_emp_reg_apellidos.Size = new System.Drawing.Size(225, 20);
            this.txt_emp_reg_apellidos.TabIndex = 1;
            this.txt_emp_reg_apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_reg_apellidos_KeyPress);
            // 
            // txt_emp_reg_nombres
            // 
            this.txt_emp_reg_nombres.Location = new System.Drawing.Point(107, 25);
            this.txt_emp_reg_nombres.MaxLength = 20;
            this.txt_emp_reg_nombres.Name = "txt_emp_reg_nombres";
            this.txt_emp_reg_nombres.Size = new System.Drawing.Size(224, 20);
            this.txt_emp_reg_nombres.TabIndex = 0;
            this.txt_emp_reg_nombres.TextChanged += new System.EventHandler(this.txt_emp_reg_nombres_TextChanged);
            this.txt_emp_reg_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_reg_nombres_KeyPress);
            // 
            // btn_emp_reg_guardar
            // 
            this.btn_emp_reg_guardar.Location = new System.Drawing.Point(142, 202);
            this.btn_emp_reg_guardar.Name = "btn_emp_reg_guardar";
            this.btn_emp_reg_guardar.Size = new System.Drawing.Size(92, 32);
            this.btn_emp_reg_guardar.TabIndex = 5;
            this.btn_emp_reg_guardar.Text = "&Guardar";
            this.btn_emp_reg_guardar.UseVisualStyleBackColor = true;
            this.btn_emp_reg_guardar.Click += new System.EventHandler(this.btn_emp_reg_guardar_Click);
            // 
            // btn_emp_reg_cancelar
            // 
            this.btn_emp_reg_cancelar.Location = new System.Drawing.Point(270, 202);
            this.btn_emp_reg_cancelar.Name = "btn_emp_reg_cancelar";
            this.btn_emp_reg_cancelar.Size = new System.Drawing.Size(86, 32);
            this.btn_emp_reg_cancelar.TabIndex = 6;
            this.btn_emp_reg_cancelar.Text = "&Cancelar";
            this.btn_emp_reg_cancelar.UseVisualStyleBackColor = true;
            this.btn_emp_reg_cancelar.Click += new System.EventHandler(this.btn_emp_reg_cancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 202);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 32);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmMantenimientoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 242);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btn_emp_reg_cancelar);
            this.Controls.Add(this.btn_emp_reg_guardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMantenimientoEmpleado";
            this.Text = "Registrar_empleado";
            this.Load += new System.EventHandler(this.FrmMantenimientoEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_emp_reg_direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_emp_reg_telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_emp_reg_cedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_emp_reg_apellidos;
        private System.Windows.Forms.TextBox txt_emp_reg_nombres;
        private System.Windows.Forms.Button btn_emp_reg_guardar;
        private System.Windows.Forms.Button btn_emp_reg_cancelar;
        private System.Windows.Forms.Button btnNuevo;
    }
}