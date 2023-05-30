namespace PalindromoPila
{
    partial class FRM_MENU
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
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txt_dat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LST_PALI = new System.Windows.Forms.ListBox();
            this.BTN_MOSTRAR = new System.Windows.Forms.Button();
            this.btn_palindromo = new System.Windows.Forms.Button();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PALINDROMO ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(279, 54);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(82, 35);
            this.btn_registrar.TabIndex = 1;
            this.btn_registrar.Text = "REGISTRAR ";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txt_dat
            // 
            this.txt_dat.Location = new System.Drawing.Point(142, 62);
            this.txt_dat.Name = "txt_dat";
            this.txt_dat.Size = new System.Drawing.Size(100, 20);
            this.txt_dat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "INGRESE EL DATO :";
            // 
            // LST_PALI
            // 
            this.LST_PALI.FormattingEnabled = true;
            this.LST_PALI.Location = new System.Drawing.Point(142, 115);
            this.LST_PALI.Name = "LST_PALI";
            this.LST_PALI.Size = new System.Drawing.Size(90, 121);
            this.LST_PALI.TabIndex = 5;
            // 
            // BTN_MOSTRAR
            // 
            this.BTN_MOSTRAR.Location = new System.Drawing.Point(286, 143);
            this.BTN_MOSTRAR.Name = "BTN_MOSTRAR";
            this.BTN_MOSTRAR.Size = new System.Drawing.Size(75, 29);
            this.BTN_MOSTRAR.TabIndex = 6;
            this.BTN_MOSTRAR.Text = "MOSTRAR";
            this.BTN_MOSTRAR.UseVisualStyleBackColor = true;
            this.BTN_MOSTRAR.Click += new System.EventHandler(this.BTN_MOSTRAR_Click);
            // 
            // btn_palindromo
            // 
            this.btn_palindromo.Location = new System.Drawing.Point(286, 194);
            this.btn_palindromo.Name = "btn_palindromo";
            this.btn_palindromo.Size = new System.Drawing.Size(75, 30);
            this.btn_palindromo.TabIndex = 7;
            this.btn_palindromo.Text = "PALINDROMO";
            this.btn_palindromo.UseVisualStyleBackColor = true;
            this.btn_palindromo.Click += new System.EventHandler(this.btn_palindromo_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(29, 253);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(75, 37);
            this.BTN_SALIR.TabIndex = 8;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // FRM_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 302);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.btn_palindromo);
            this.Controls.Add(this.BTN_MOSTRAR);
            this.Controls.Add(this.LST_PALI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dat);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label1);
            this.Name = "FRM_MENU";
            this.Text = "MENU PRINCIPAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox txt_dat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LST_PALI;
        private System.Windows.Forms.Button BTN_MOSTRAR;
        private System.Windows.Forms.Button btn_palindromo;
        private System.Windows.Forms.Button BTN_SALIR;
    }
}

