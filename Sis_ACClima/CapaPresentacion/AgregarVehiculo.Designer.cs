﻿namespace CapaPresentacion
{
    partial class AgregarVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_av_chasis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_av_marca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_av_modelo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_av_guardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(119, 29);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(182, 20);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged_1);
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress_1);
            this.txtPlaca.Leave += new System.EventHandler(this.txtPlaca_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Número de chasis";
            // 
            // txt_av_chasis
            // 
            this.txt_av_chasis.Location = new System.Drawing.Point(121, 60);
            this.txt_av_chasis.MaxLength = 13;
            this.txt_av_chasis.Name = "txt_av_chasis";
            this.txt_av_chasis.Size = new System.Drawing.Size(180, 20);
            this.txt_av_chasis.TabIndex = 6;
            this.txt_av_chasis.TextChanged += new System.EventHandler(this.txt_av_chasis_TextChanged);
            this.txt_av_chasis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_av_chasis_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Marca";
            // 
            // txt_av_marca
            // 
            this.txt_av_marca.Location = new System.Drawing.Point(119, 91);
            this.txt_av_marca.Name = "txt_av_marca";
            this.txt_av_marca.Size = new System.Drawing.Size(182, 20);
            this.txt_av_marca.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Modelo";
            // 
            // txt_av_modelo
            // 
            this.txt_av_modelo.Location = new System.Drawing.Point(122, 121);
            this.txt_av_modelo.Name = "txt_av_modelo";
            this.txt_av_modelo.Size = new System.Drawing.Size(179, 20);
            this.txt_av_modelo.TabIndex = 10;
            this.txt_av_modelo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_av_modelo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.txt_av_marca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_av_chasis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 156);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de vehículo";
            // 
            // btn_av_guardar
            // 
            this.btn_av_guardar.Location = new System.Drawing.Point(12, 196);
            this.btn_av_guardar.Name = "btn_av_guardar";
            this.btn_av_guardar.Size = new System.Drawing.Size(112, 32);
            this.btn_av_guardar.TabIndex = 12;
            this.btn_av_guardar.Text = "Guardar";
            this.btn_av_guardar.UseVisualStyleBackColor = true;
            this.btn_av_guardar.Click += new System.EventHandler(this.btn_av_guardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cliente:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(60, 11);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(66, 10);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(10, 13);
            this.lblNombreCliente.TabIndex = 16;
            this.lblNombreCliente.Text = ".";
            // 
            // AgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 243);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_av_guardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarVehiculo";
            this.Text = "Agregar Vehiculo";
            this.Load += new System.EventHandler(this.Añadir_vehiculo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_av_chasis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_av_marca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_av_modelo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_av_guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNombreCliente;
    }
}