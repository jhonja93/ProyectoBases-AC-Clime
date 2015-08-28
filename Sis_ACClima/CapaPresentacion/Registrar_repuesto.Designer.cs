namespace CapaPresentacion
{
    partial class Registrar_Repuesto
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rep_reg_marca = new System.Windows.Forms.TextBox();
            this.txt_rep_reg_descripcion = new System.Windows.Forms.TextBox();
            this.btn_rep_reg_guardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_rep_reg_marca);
            this.groupBox1.Controls.Add(this.txt_rep_reg_descripcion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(505, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(141, 73);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.MaxLength = 10;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(327, 23);
            this.txtPrecioVenta.TabIndex = 5;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txt_rep_reg_pventa_TextChanged);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rep_reg_pventa_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio de venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcion";
            // 
            // txt_rep_reg_marca
            // 
            this.txt_rep_reg_marca.Location = new System.Drawing.Point(141, 42);
            this.txt_rep_reg_marca.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rep_reg_marca.MaxLength = 20;
            this.txt_rep_reg_marca.Name = "txt_rep_reg_marca";
            this.txt_rep_reg_marca.Size = new System.Drawing.Size(327, 23);
            this.txt_rep_reg_marca.TabIndex = 1;
            this.txt_rep_reg_marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rep_reg_marca_KeyPress);
            // 
            // txt_rep_reg_descripcion
            // 
            this.txt_rep_reg_descripcion.Location = new System.Drawing.Point(141, 103);
            this.txt_rep_reg_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rep_reg_descripcion.MaxLength = 256;
            this.txt_rep_reg_descripcion.Multiline = true;
            this.txt_rep_reg_descripcion.Name = "txt_rep_reg_descripcion";
            this.txt_rep_reg_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_rep_reg_descripcion.Size = new System.Drawing.Size(327, 59);
            this.txt_rep_reg_descripcion.TabIndex = 0;
            this.txt_rep_reg_descripcion.TextChanged += new System.EventHandler(this.txt_rep_reg_descripcion_TextChanged);
            this.txt_rep_reg_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rep_reg_descripcion_KeyPress);
            // 
            // btn_rep_reg_guardar
            // 
            this.btn_rep_reg_guardar.Location = new System.Drawing.Point(13, 212);
            this.btn_rep_reg_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rep_reg_guardar.Name = "btn_rep_reg_guardar";
            this.btn_rep_reg_guardar.Size = new System.Drawing.Size(160, 41);
            this.btn_rep_reg_guardar.TabIndex = 5;
            this.btn_rep_reg_guardar.Text = "Guardar";
            this.btn_rep_reg_guardar.UseVisualStyleBackColor = true;
            this.btn_rep_reg_guardar.Click += new System.EventHandler(this.btn_rep_reg_guardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // Registrar_Repuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_rep_reg_guardar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registrar_Repuesto";
            this.Text = "Repuesto";
            this.Load += new System.EventHandler(this.Registrar_repuesto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rep_reg_marca;
        private System.Windows.Forms.TextBox txt_rep_reg_descripcion;
        private System.Windows.Forms.Button btn_rep_reg_guardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorIcon;
    }
}