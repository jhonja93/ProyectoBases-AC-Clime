namespace CapaPresentacion
{
    partial class Registrar_empleado
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(434, 250);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del empleado";
            // 
            // txt_emp_reg_direccion
            // 
            this.txt_emp_reg_direccion.Location = new System.Drawing.Point(140, 160);
            this.txt_emp_reg_direccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_emp_reg_direccion.MaxLength = 50;
            this.txt_emp_reg_direccion.Multiline = true;
            this.txt_emp_reg_direccion.Name = "txt_emp_reg_direccion";
            this.txt_emp_reg_direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_emp_reg_direccion.Size = new System.Drawing.Size(278, 69);
            this.txt_emp_reg_direccion.TabIndex = 9;
            this.txt_emp_reg_direccion.TextChanged += new System.EventHandler(this.txt_emp_reg_direccion_TextChanged);
            this.txt_emp_reg_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_reg_direccion_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección";
            // 
            // txt_emp_reg_telefono
            // 
            this.txt_emp_reg_telefono.Location = new System.Drawing.Point(141, 128);
            this.txt_emp_reg_telefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_emp_reg_telefono.MaxLength = 9;
            this.txt_emp_reg_telefono.Name = "txt_emp_reg_telefono";
            this.txt_emp_reg_telefono.Size = new System.Drawing.Size(277, 23);
            this.txt_emp_reg_telefono.TabIndex = 7;
            this.txt_emp_reg_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_reg_telefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono";
            // 
            // txt_emp_reg_cedula
            // 
            this.txt_emp_reg_cedula.Location = new System.Drawing.Point(141, 95);
            this.txt_emp_reg_cedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_emp_reg_cedula.MaxLength = 10;
            this.txt_emp_reg_cedula.Name = "txt_emp_reg_cedula";
            this.txt_emp_reg_cedula.Size = new System.Drawing.Size(277, 23);
            this.txt_emp_reg_cedula.TabIndex = 5;
            this.txt_emp_reg_cedula.TextChanged += new System.EventHandler(this.txt_emp_reg_cedula_TextChanged);
            this.txt_emp_reg_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_reg_cedula_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nro. de cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // txt_emp_reg_apellidos
            // 
            this.txt_emp_reg_apellidos.Location = new System.Drawing.Point(141, 63);
            this.txt_emp_reg_apellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_emp_reg_apellidos.MaxLength = 50;
            this.txt_emp_reg_apellidos.Name = "txt_emp_reg_apellidos";
            this.txt_emp_reg_apellidos.Size = new System.Drawing.Size(277, 23);
            this.txt_emp_reg_apellidos.TabIndex = 1;
            this.txt_emp_reg_apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_reg_apellidos_KeyPress);
            // 
            // txt_emp_reg_nombres
            // 
            this.txt_emp_reg_nombres.Location = new System.Drawing.Point(143, 31);
            this.txt_emp_reg_nombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_emp_reg_nombres.MaxLength = 50;
            this.txt_emp_reg_nombres.Name = "txt_emp_reg_nombres";
            this.txt_emp_reg_nombres.Size = new System.Drawing.Size(275, 23);
            this.txt_emp_reg_nombres.TabIndex = 0;
            this.txt_emp_reg_nombres.TextChanged += new System.EventHandler(this.txt_emp_reg_nombres_TextChanged);
            this.txt_emp_reg_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emp_reg_nombres_KeyPress);
            // 
            // btn_emp_reg_guardar
            // 
            this.btn_emp_reg_guardar.Location = new System.Drawing.Point(13, 273);
            this.btn_emp_reg_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_emp_reg_guardar.Name = "btn_emp_reg_guardar";
            this.btn_emp_reg_guardar.Size = new System.Drawing.Size(157, 39);
            this.btn_emp_reg_guardar.TabIndex = 5;
            this.btn_emp_reg_guardar.Text = "Guardar";
            this.btn_emp_reg_guardar.UseVisualStyleBackColor = true;
            this.btn_emp_reg_guardar.Click += new System.EventHandler(this.btn_emp_reg_guardar_Click);
            // 
            // btn_emp_reg_cancelar
            // 
            this.btn_emp_reg_cancelar.Location = new System.Drawing.Point(191, 273);
            this.btn_emp_reg_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_emp_reg_cancelar.Name = "btn_emp_reg_cancelar";
            this.btn_emp_reg_cancelar.Size = new System.Drawing.Size(157, 39);
            this.btn_emp_reg_cancelar.TabIndex = 6;
            this.btn_emp_reg_cancelar.Text = "Guardar";
            this.btn_emp_reg_cancelar.UseVisualStyleBackColor = true;
            // 
            // Registrar_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 325);
            this.Controls.Add(this.btn_emp_reg_cancelar);
            this.Controls.Add(this.btn_emp_reg_guardar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registrar_empleado";
            this.Text = "Registrar_empleado";
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
    }
}