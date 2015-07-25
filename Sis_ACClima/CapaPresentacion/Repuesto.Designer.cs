namespace Proyecto_AC_CLIMA
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.txt_cli_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rep_nuevo = new System.Windows.Forms.Button();
            this.btn_rep_modificar = new System.Windows.Forms.Button();
            this.btn_rep_eliminar = new System.Windows.Forms.Button();
            this.btn_rep_consultar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(18, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 231);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de repuestos";
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
            this.txt_cli_buscar.Location = new System.Drawing.Point(61, 70);
            this.txt_cli_buscar.Name = "txt_cli_buscar";
            this.txt_cli_buscar.Size = new System.Drawing.Size(223, 20);
            this.txt_cli_buscar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar";
            // 
            // btn_rep_nuevo
            // 
            this.btn_rep_nuevo.Location = new System.Drawing.Point(18, 14);
            this.btn_rep_nuevo.Name = "btn_rep_nuevo";
            this.btn_rep_nuevo.Size = new System.Drawing.Size(99, 36);
            this.btn_rep_nuevo.TabIndex = 8;
            this.btn_rep_nuevo.Text = "+ Añadir nuevo";
            this.btn_rep_nuevo.UseVisualStyleBackColor = true;
            this.btn_rep_nuevo.Click += new System.EventHandler(this.btn_rep_nuevo_Click);
            // 
            // btn_rep_modificar
            // 
            this.btn_rep_modificar.Location = new System.Drawing.Point(357, 87);
            this.btn_rep_modificar.Name = "btn_rep_modificar";
            this.btn_rep_modificar.Size = new System.Drawing.Size(122, 31);
            this.btn_rep_modificar.TabIndex = 14;
            this.btn_rep_modificar.Text = "Modificar";
            this.btn_rep_modificar.UseVisualStyleBackColor = true;
            this.btn_rep_modificar.Click += new System.EventHandler(this.btn_rep_modificar_Click);
            // 
            // btn_rep_eliminar
            // 
            this.btn_rep_eliminar.Location = new System.Drawing.Point(357, 161);
            this.btn_rep_eliminar.Name = "btn_rep_eliminar";
            this.btn_rep_eliminar.Size = new System.Drawing.Size(122, 31);
            this.btn_rep_eliminar.TabIndex = 13;
            this.btn_rep_eliminar.Text = "Eliminar";
            this.btn_rep_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_rep_consultar
            // 
            this.btn_rep_consultar.Location = new System.Drawing.Point(357, 124);
            this.btn_rep_consultar.Name = "btn_rep_consultar";
            this.btn_rep_consultar.Size = new System.Drawing.Size(122, 31);
            this.btn_rep_consultar.TabIndex = 12;
            this.btn_rep_consultar.Text = "Consultar";
            this.btn_rep_consultar.UseVisualStyleBackColor = true;
            this.btn_rep_consultar.Click += new System.EventHandler(this.btn_rep_consultar_Click);
            // 
            // Repuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_cli_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rep_nuevo);
            this.Controls.Add(this.btn_rep_modificar);
            this.Controls.Add(this.btn_rep_eliminar);
            this.Controls.Add(this.btn_rep_consultar);
            this.Name = "Repuesto";
            this.Text = "Repuesto";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txt_cli_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rep_nuevo;
        private System.Windows.Forms.Button btn_rep_modificar;
        private System.Windows.Forms.Button btn_rep_eliminar;
        private System.Windows.Forms.Button btn_rep_consultar;
    }
}