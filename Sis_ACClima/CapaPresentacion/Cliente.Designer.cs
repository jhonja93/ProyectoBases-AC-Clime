namespace Proyecto_AC_CLIMA
{
    partial class Cliente
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
            this.btn_cli_nuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cli_buscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_cli_consultar = new System.Windows.Forms.Button();
            this.btn_cli_eliminar = new System.Windows.Forms.Button();
            this.btn_cli_modificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cli_nuevo
            // 
            this.btn_cli_nuevo.Location = new System.Drawing.Point(33, 25);
            this.btn_cli_nuevo.Name = "btn_cli_nuevo";
            this.btn_cli_nuevo.Size = new System.Drawing.Size(99, 36);
            this.btn_cli_nuevo.TabIndex = 0;
            this.btn_cli_nuevo.Text = "+ Añadir nuevo";
            this.btn_cli_nuevo.UseVisualStyleBackColor = true;
            this.btn_cli_nuevo.Click += new System.EventHandler(this.btn_cli_nuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // txt_cli_buscar
            // 
            this.txt_cli_buscar.Location = new System.Drawing.Point(76, 81);
            this.txt_cli_buscar.Name = "txt_cli_buscar";
            this.txt_cli_buscar.Size = new System.Drawing.Size(223, 20);
            this.txt_cli_buscar.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(33, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 231);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de clientes";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(277, 195);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_cli_consultar
            // 
            this.btn_cli_consultar.Location = new System.Drawing.Point(372, 135);
            this.btn_cli_consultar.Name = "btn_cli_consultar";
            this.btn_cli_consultar.Size = new System.Drawing.Size(122, 31);
            this.btn_cli_consultar.TabIndex = 5;
            this.btn_cli_consultar.Text = "Consultar";
            this.btn_cli_consultar.UseVisualStyleBackColor = true;
            this.btn_cli_consultar.Click += new System.EventHandler(this.btn_cli_consultar_Click);
            // 
            // btn_cli_eliminar
            // 
            this.btn_cli_eliminar.Location = new System.Drawing.Point(372, 172);
            this.btn_cli_eliminar.Name = "btn_cli_eliminar";
            this.btn_cli_eliminar.Size = new System.Drawing.Size(122, 31);
            this.btn_cli_eliminar.TabIndex = 6;
            this.btn_cli_eliminar.Text = "Eliminar";
            this.btn_cli_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_cli_modificar
            // 
            this.btn_cli_modificar.Location = new System.Drawing.Point(372, 98);
            this.btn_cli_modificar.Name = "btn_cli_modificar";
            this.btn_cli_modificar.Size = new System.Drawing.Size(122, 31);
            this.btn_cli_modificar.TabIndex = 7;
            this.btn_cli_modificar.Text = "Modificar";
            this.btn_cli_modificar.UseVisualStyleBackColor = true;
            this.btn_cli_modificar.Click += new System.EventHandler(this.btn_cli_modificar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 382);
            this.Controls.Add(this.btn_cli_modificar);
            this.Controls.Add(this.btn_cli_eliminar);
            this.Controls.Add(this.btn_cli_consultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_cli_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cli_nuevo);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cli_nuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cli_buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_cli_consultar;
        private System.Windows.Forms.Button btn_cli_eliminar;
        private System.Windows.Forms.Button btn_cli_modificar;
    }
}