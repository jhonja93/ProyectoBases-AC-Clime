namespace Proyecto_AC_CLIMA
{
    partial class Modificar_repuesto
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
            this.btn_rep_mod_cancelar = new System.Windows.Forms.Button();
            this.btn_rep_mod_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_rep_mod_pventa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rep_mod_marca = new System.Windows.Forms.TextBox();
            this.txt_rep_mod_descripcion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_rep_mod_cancelar
            // 
            this.btn_rep_mod_cancelar.Location = new System.Drawing.Point(144, 138);
            this.btn_rep_mod_cancelar.Name = "btn_rep_mod_cancelar";
            this.btn_rep_mod_cancelar.Size = new System.Drawing.Size(120, 33);
            this.btn_rep_mod_cancelar.TabIndex = 9;
            this.btn_rep_mod_cancelar.Text = "Cancelar";
            this.btn_rep_mod_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_rep_mod_guardar
            // 
            this.btn_rep_mod_guardar.Location = new System.Drawing.Point(16, 138);
            this.btn_rep_mod_guardar.Name = "btn_rep_mod_guardar";
            this.btn_rep_mod_guardar.Size = new System.Drawing.Size(120, 33);
            this.btn_rep_mod_guardar.TabIndex = 8;
            this.btn_rep_mod_guardar.Text = "Guardar";
            this.btn_rep_mod_guardar.UseVisualStyleBackColor = true;
            this.btn_rep_mod_guardar.Click += new System.EventHandler(this.btn_rep_mod_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_rep_mod_pventa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_rep_mod_marca);
            this.groupBox1.Controls.Add(this.txt_rep_mod_descripcion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 115);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del repuesto";
            // 
            // txt_rep_mod_pventa
            // 
            this.txt_rep_mod_pventa.Location = new System.Drawing.Point(106, 77);
            this.txt_rep_mod_pventa.MaxLength = 10;
            this.txt_rep_mod_pventa.Name = "txt_rep_mod_pventa";
            this.txt_rep_mod_pventa.Size = new System.Drawing.Size(109, 20);
            this.txt_rep_mod_pventa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio de venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcion";
            // 
            // txt_rep_mod_marca
            // 
            this.txt_rep_mod_marca.Location = new System.Drawing.Point(106, 51);
            this.txt_rep_mod_marca.MaxLength = 50;
            this.txt_rep_mod_marca.Name = "txt_rep_mod_marca";
            this.txt_rep_mod_marca.Size = new System.Drawing.Size(146, 20);
            this.txt_rep_mod_marca.TabIndex = 1;
            this.txt_rep_mod_marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rep_mod_marca_KeyPress);
            // 
            // txt_rep_mod_descripcion
            // 
            this.txt_rep_mod_descripcion.Location = new System.Drawing.Point(107, 25);
            this.txt_rep_mod_descripcion.MaxLength = 50;
            this.txt_rep_mod_descripcion.Name = "txt_rep_mod_descripcion";
            this.txt_rep_mod_descripcion.Size = new System.Drawing.Size(271, 20);
            this.txt_rep_mod_descripcion.TabIndex = 0;
            this.txt_rep_mod_descripcion.TextChanged += new System.EventHandler(this.txt_rep_mod_descripcion_TextChanged);
            this.txt_rep_mod_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rep_mod_descripcion_KeyPress);
            // 
            // Modificar_repuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 184);
            this.Controls.Add(this.btn_rep_mod_cancelar);
            this.Controls.Add(this.btn_rep_mod_guardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modificar_repuesto";
            this.Text = "Modificar_repuesto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_rep_mod_cancelar;
        private System.Windows.Forms.Button btn_rep_mod_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_rep_mod_pventa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rep_mod_marca;
        private System.Windows.Forms.TextBox txt_rep_mod_descripcion;
    }
}