namespace Examen
{
    partial class Form1
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
            this.btn_registrar = new System.Windows.Forms.Button();
            this.LST_PRINCIPAL = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_MOSTRAR = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(251, 34);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(91, 23);
            this.btn_registrar.TabIndex = 0;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LST_PRINCIPAL
            // 
            this.LST_PRINCIPAL.FormattingEnabled = true;
            this.LST_PRINCIPAL.Location = new System.Drawing.Point(110, 87);
            this.LST_PRINCIPAL.Name = "LST_PRINCIPAL";
            this.LST_PRINCIPAL.Size = new System.Drawing.Size(120, 212);
            this.LST_PRINCIPAL.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "MENOR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_MOSTRAR
            // 
            this.BTN_MOSTRAR.Location = new System.Drawing.Point(302, 100);
            this.BTN_MOSTRAR.Name = "BTN_MOSTRAR";
            this.BTN_MOSTRAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_MOSTRAR.TabIndex = 3;
            this.BTN_MOSTRAR.Text = "MOSTRAR";
            this.BTN_MOSTRAR.UseVisualStyleBackColor = true;
            this.BTN_MOSTRAR.Click += new System.EventHandler(this.BTN_MOSTRAR_Click);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(160, 34);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(53, 20);
            this.txt_num.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "INGRESE UN NUMERO :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "MAYOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 381);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.BTN_MOSTRAR);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LST_PRINCIPAL);
            this.Controls.Add(this.btn_registrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.ListBox LST_PRINCIPAL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_MOSTRAR;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

