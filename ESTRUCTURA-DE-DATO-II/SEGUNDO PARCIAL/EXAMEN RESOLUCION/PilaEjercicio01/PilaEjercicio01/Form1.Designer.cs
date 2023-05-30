namespace PilaEjercicio01
{
    partial class EJERCICIO01
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_REGISTRAR = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lst_original = new System.Windows.Forms.ListBox();
            this.lst_primos = new System.Windows.Forms.ListBox();
            this.btn_list1 = new System.Windows.Forms.Button();
            this.btn_msotrarPrimos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE NUMEROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE NUMERO :";
            // 
            // BTN_REGISTRAR
            // 
            this.BTN_REGISTRAR.Location = new System.Drawing.Point(249, 78);
            this.BTN_REGISTRAR.Name = "BTN_REGISTRAR";
            this.BTN_REGISTRAR.Size = new System.Drawing.Size(80, 23);
            this.BTN_REGISTRAR.TabIndex = 2;
            this.BTN_REGISTRAR.Text = "REGISTRAR";
            this.BTN_REGISTRAR.UseVisualStyleBackColor = true;
            this.BTN_REGISTRAR.Click += new System.EventHandler(this.BTN_REGISTRAR_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(319, 326);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(62, 34);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(130, 80);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 5;
            // 
            // lst_original
            // 
            this.lst_original.FormattingEnabled = true;
            this.lst_original.Location = new System.Drawing.Point(68, 131);
            this.lst_original.Name = "lst_original";
            this.lst_original.Size = new System.Drawing.Size(76, 147);
            this.lst_original.TabIndex = 6;
            // 
            // lst_primos
            // 
            this.lst_primos.FormattingEnabled = true;
            this.lst_primos.Location = new System.Drawing.Point(192, 131);
            this.lst_primos.Name = "lst_primos";
            this.lst_primos.Size = new System.Drawing.Size(76, 147);
            this.lst_primos.TabIndex = 7;
            // 
            // btn_list1
            // 
            this.btn_list1.Location = new System.Drawing.Point(68, 299);
            this.btn_list1.Name = "btn_list1";
            this.btn_list1.Size = new System.Drawing.Size(75, 23);
            this.btn_list1.TabIndex = 8;
            this.btn_list1.Text = "MOSTRAR";
            this.btn_list1.UseVisualStyleBackColor = true;
            this.btn_list1.Click += new System.EventHandler(this.btn_list1_Click);
            // 
            // btn_msotrarPrimos
            // 
            this.btn_msotrarPrimos.Location = new System.Drawing.Point(192, 298);
            this.btn_msotrarPrimos.Name = "btn_msotrarPrimos";
            this.btn_msotrarPrimos.Size = new System.Drawing.Size(75, 35);
            this.btn_msotrarPrimos.TabIndex = 9;
            this.btn_msotrarPrimos.Text = "MOSTRAR PRIMOS";
            this.btn_msotrarPrimos.UseVisualStyleBackColor = true;
            this.btn_msotrarPrimos.Click += new System.EventHandler(this.btn_msotrarPrimos_Click);
            // 
            // EJERCICIO01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 372);
            this.Controls.Add(this.btn_msotrarPrimos);
            this.Controls.Add(this.btn_list1);
            this.Controls.Add(this.lst_primos);
            this.Controls.Add(this.lst_original);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.BTN_REGISTRAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EJERCICIO01";
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.EJERCICIO01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_REGISTRAR;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.ListBox lst_original;
        private System.Windows.Forms.ListBox lst_primos;
        private System.Windows.Forms.Button btn_list1;
        private System.Windows.Forms.Button btn_msotrarPrimos;
    }
}

