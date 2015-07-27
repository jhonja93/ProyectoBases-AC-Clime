namespace CapaPresentacion
{
    partial class Repuesto
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
            this.txt_cli_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rep_nuevo = new System.Windows.Forms.Button();
            this.btn_rep_modificar = new System.Windows.Forms.Button();
            this.btn_rep_eliminar = new System.Windows.Forms.Button();
            this.btn_rep_consultar = new System.Windows.Forms.Button();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataListado);
            this.groupBox1.Location = new System.Drawing.Point(24, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(499, 284);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de repuestos";
            // 
            // txt_cli_buscar
            // 
            this.txt_cli_buscar.Location = new System.Drawing.Point(116, 90);
            this.txt_cli_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cli_buscar.Name = "txt_cli_buscar";
            this.txt_cli_buscar.Size = new System.Drawing.Size(296, 22);
            this.txt_cli_buscar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar";
            // 
            // btn_rep_nuevo
            // 
            this.btn_rep_nuevo.Location = new System.Drawing.Point(24, 17);
            this.btn_rep_nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_rep_nuevo.Name = "btn_rep_nuevo";
            this.btn_rep_nuevo.Size = new System.Drawing.Size(132, 44);
            this.btn_rep_nuevo.TabIndex = 8;
            this.btn_rep_nuevo.Text = "+ Añadir nuevo";
            this.btn_rep_nuevo.UseVisualStyleBackColor = true;
            this.btn_rep_nuevo.Click += new System.EventHandler(this.btn_rep_nuevo_Click);
            // 
            // btn_rep_modificar
            // 
            this.btn_rep_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rep_modificar.Location = new System.Drawing.Point(531, 90);
            this.btn_rep_modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_rep_modificar.Name = "btn_rep_modificar";
            this.btn_rep_modificar.Size = new System.Drawing.Size(115, 69);
            this.btn_rep_modificar.TabIndex = 14;
            this.btn_rep_modificar.Text = "Modificar";
            this.btn_rep_modificar.UseVisualStyleBackColor = true;
            this.btn_rep_modificar.Click += new System.EventHandler(this.btn_rep_modificar_Click);
            // 
            // btn_rep_eliminar
            // 
            this.btn_rep_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rep_eliminar.Location = new System.Drawing.Point(531, 311);
            this.btn_rep_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_rep_eliminar.Name = "btn_rep_eliminar";
            this.btn_rep_eliminar.Size = new System.Drawing.Size(115, 69);
            this.btn_rep_eliminar.TabIndex = 13;
            this.btn_rep_eliminar.Text = "Eliminar";
            this.btn_rep_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_rep_consultar
            // 
            this.btn_rep_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rep_consultar.Location = new System.Drawing.Point(531, 198);
            this.btn_rep_consultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_rep_consultar.Name = "btn_rep_consultar";
            this.btn_rep_consultar.Size = new System.Drawing.Size(115, 69);
            this.btn_rep_consultar.TabIndex = 12;
            this.btn_rep_consultar.Text = "Consultar";
            this.btn_rep_consultar.UseVisualStyleBackColor = true;
            this.btn_rep_consultar.Click += new System.EventHandler(this.btn_rep_consultar_Click);
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
            this.dataListado.Size = new System.Drawing.Size(485, 255);
            this.dataListado.TabIndex = 11;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Repuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_cli_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rep_nuevo);
            this.Controls.Add(this.btn_rep_modificar);
            this.Controls.Add(this.btn_rep_eliminar);
            this.Controls.Add(this.btn_rep_consultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Repuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Repuesto";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cli_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rep_nuevo;
        private System.Windows.Forms.Button btn_rep_modificar;
        private System.Windows.Forms.Button btn_rep_eliminar;
        private System.Windows.Forms.Button btn_rep_consultar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}