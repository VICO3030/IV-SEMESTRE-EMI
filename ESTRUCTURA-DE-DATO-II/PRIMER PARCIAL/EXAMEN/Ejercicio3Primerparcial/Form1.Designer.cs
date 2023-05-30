namespace Ejercicio3Primerparcial
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
            this.lst_lista = new System.Windows.Forms.ListBox();
            this.txt_p = new System.Windows.Forms.TextBox();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_lista
            // 
            this.lst_lista.FormattingEnabled = true;
            this.lst_lista.Location = new System.Drawing.Point(190, 148);
            this.lst_lista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lst_lista.Name = "lst_lista";
            this.lst_lista.Size = new System.Drawing.Size(128, 186);
            this.lst_lista.TabIndex = 17;
            // 
            // txt_p
            // 
            this.txt_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p.Location = new System.Drawing.Point(210, 94);
            this.txt_p.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(86, 24);
            this.txt_p.TabIndex = 16;
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_texto.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto.Location = new System.Drawing.Point(59, 97);
            this.lbl_texto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(133, 18);
            this.lbl_texto.TabIndex = 15;
            this.lbl_texto.Text = "inrgese la letra";
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Aqua;
            this.btn_registrar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(452, 123);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(98, 37);
            this.btn_registrar.TabIndex = 18;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.BackColor = System.Drawing.Color.Aqua;
            this.btn_Mostrar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar.Location = new System.Drawing.Point(452, 184);
            this.btn_Mostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(98, 37);
            this.btn_Mostrar.TabIndex = 19;
            this.btn_Mostrar.Text = "MOSTRAR";
            this.btn_Mostrar.UseVisualStyleBackColor = false;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackColor = System.Drawing.Color.Aqua;
            this.btn_verificar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verificar.Location = new System.Drawing.Point(452, 297);
            this.btn_verificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(98, 37);
            this.btn_verificar.TabIndex = 20;
            this.btn_verificar.Text = "VERIFICAR";
            this.btn_verificar.UseVisualStyleBackColor = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "PALINDROMO";
            // 
            // BTN_limpiar
            // 
            this.BTN_limpiar.BackColor = System.Drawing.Color.Aqua;
            this.BTN_limpiar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_limpiar.Location = new System.Drawing.Point(452, 239);
            this.BTN_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_limpiar.Name = "BTN_limpiar";
            this.BTN_limpiar.Size = new System.Drawing.Size(98, 37);
            this.BTN_limpiar.TabIndex = 22;
            this.BTN_limpiar.Text = "LIMPIAR";
            this.BTN_limpiar.UseVisualStyleBackColor = false;
            this.BTN_limpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BTN_limpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.lst_lista);
            this.Controls.Add(this.txt_p);
            this.Controls.Add(this.lbl_texto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_lista;
        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_limpiar;
    }
}

