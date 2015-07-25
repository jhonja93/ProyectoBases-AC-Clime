namespace Proyecto_AC_CLIMA
{
    partial class Empleado
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
            this.btn_emp_modificar = new System.Windows.Forms.Button();
            this.btn_emp_eliminar = new System.Windows.Forms.Button();
            this.btn_emp_consultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txt_cli_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_emp_nuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_emp_modificar
            // 
            this.btn_emp_modificar.Location = new System.Drawing.Point(380, 85);
            this.btn_emp_modificar.Name = "btn_emp_modificar";
            this.btn_emp_modificar.Size = new System.Drawing.Size(122, 31);
            this.btn_emp_modificar.TabIndex = 14;
            this.btn_emp_modificar.Text = "Modificar";
            this.btn_emp_modificar.UseVisualStyleBackColor = true;
            this.btn_emp_modificar.Click += new System.EventHandler(this.btn_emp_modificar_Click);
            // 
            // btn_emp_eliminar
            // 
            this.btn_emp_eliminar.Location = new System.Drawing.Point(380, 159);
            this.btn_emp_eliminar.Name = "btn_emp_eliminar";
            this.btn_emp_eliminar.Size = new System.Drawing.Size(122, 31);
            this.btn_emp_eliminar.TabIndex = 13;
            this.btn_emp_eliminar.Text = "Eliminar";
            this.btn_emp_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_emp_consultar
            // 
            this.btn_emp_consultar.Location = new System.Drawing.Point(380, 122);
            this.btn_emp_consultar.Name = "btn_emp_consultar";
            this.btn_emp_consultar.Size = new System.Drawing.Size(122, 31);
            this.btn_emp_consultar.TabIndex = 12;
            this.btn_emp_consultar.Text = "Consultar";
            this.btn_emp_consultar.UseVisualStyleBackColor = true;
            this.btn_emp_consultar.Click += new System.EventHandler(this.btn_emp_consultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(41, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 231);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de empleados";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(277, 195);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txt_cli_buscar
            // 
            this.txt_cli_buscar.Location = new System.Drawing.Point(84, 68);
            this.txt_cli_buscar.Name = "txt_cli_buscar";
            this.txt_cli_buscar.Size = new System.Drawing.Size(223, 20);
            this.txt_cli_buscar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar";
            // 
            // btn_emp_nuevo
            // 
            this.btn_emp_nuevo.Location = new System.Drawing.Point(41, 12);
            this.btn_emp_nuevo.Name = "btn_emp_nuevo";
            this.btn_emp_nuevo.Size = new System.Drawing.Size(99, 36);
            this.btn_emp_nuevo.TabIndex = 8;
            this.btn_emp_nuevo.Text = "+ Añadir nuevo";
            this.btn_emp_nuevo.UseVisualStyleBackColor = true;
            this.btn_emp_nuevo.Click += new System.EventHandler(this.btn_emp_nuevo_Click);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 351);
            this.Controls.Add(this.btn_emp_modificar);
            this.Controls.Add(this.btn_emp_eliminar);
            this.Controls.Add(this.btn_emp_consultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_cli_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_emp_nuevo);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_emp_modificar;
        private System.Windows.Forms.Button btn_emp_eliminar;
        private System.Windows.Forms.Button btn_emp_consultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txt_cli_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_emp_nuevo;
    }
}