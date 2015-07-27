namespace CapaPresentacion
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
            this.txt_cli_buscar = new System.Windows.Forms.TextBox();
            this.btn_emp_nuevo = new System.Windows.Forms.Button();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_emp_modificar
            // 
            this.btn_emp_modificar.Location = new System.Drawing.Point(588, 84);
            this.btn_emp_modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_emp_modificar.Name = "btn_emp_modificar";
            this.btn_emp_modificar.Size = new System.Drawing.Size(102, 85);
            this.btn_emp_modificar.TabIndex = 14;
            this.btn_emp_modificar.Text = "Modificar";
            this.btn_emp_modificar.UseVisualStyleBackColor = true;
            this.btn_emp_modificar.Click += new System.EventHandler(this.btn_emp_modificar_Click);
            // 
            // btn_emp_eliminar
            // 
            this.btn_emp_eliminar.Location = new System.Drawing.Point(588, 274);
            this.btn_emp_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_emp_eliminar.Name = "btn_emp_eliminar";
            this.btn_emp_eliminar.Size = new System.Drawing.Size(102, 85);
            this.btn_emp_eliminar.TabIndex = 13;
            this.btn_emp_eliminar.Text = "Eliminar";
            this.btn_emp_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_emp_consultar
            // 
            this.btn_emp_consultar.Location = new System.Drawing.Point(588, 181);
            this.btn_emp_consultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_emp_consultar.Name = "btn_emp_consultar";
            this.btn_emp_consultar.Size = new System.Drawing.Size(102, 85);
            this.btn_emp_consultar.TabIndex = 12;
            this.btn_emp_consultar.Text = "Consultar";
            this.btn_emp_consultar.UseVisualStyleBackColor = true;
            this.btn_emp_consultar.Click += new System.EventHandler(this.btn_emp_consultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataListado);
            this.groupBox1.Location = new System.Drawing.Point(13, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(567, 305);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de empleados";
            // 
            // txt_cli_buscar
            // 
            this.txt_cli_buscar.Location = new System.Drawing.Point(158, 75);
            this.txt_cli_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cli_buscar.Name = "txt_cli_buscar";
            this.txt_cli_buscar.Size = new System.Drawing.Size(415, 22);
            this.txt_cli_buscar.TabIndex = 10;
            // 
            // btn_emp_nuevo
            // 
            this.btn_emp_nuevo.Location = new System.Drawing.Point(20, 13);
            this.btn_emp_nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_emp_nuevo.Name = "btn_emp_nuevo";
            this.btn_emp_nuevo.Size = new System.Drawing.Size(132, 44);
            this.btn_emp_nuevo.TabIndex = 8;
            this.btn_emp_nuevo.Text = "+ Añadir nuevo";
            this.btn_emp_nuevo.UseVisualStyleBackColor = true;
            this.btn_emp_nuevo.Click += new System.EventHandler(this.btn_emp_nuevo_Click);
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Location = new System.Drawing.Point(7, 22);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(553, 276);
            this.dataListado.TabIndex = 10;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Apellido",
            "Cedula"});
            this.comboBox1.Location = new System.Drawing.Point(20, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Apellido";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 432);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_emp_modificar);
            this.Controls.Add(this.btn_emp_eliminar);
            this.Controls.Add(this.btn_emp_consultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_cli_buscar);
            this.Controls.Add(this.btn_emp_nuevo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_emp_modificar;
        private System.Windows.Forms.Button btn_emp_eliminar;
        private System.Windows.Forms.Button btn_emp_consultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cli_buscar;
        private System.Windows.Forms.Button btn_emp_nuevo;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}