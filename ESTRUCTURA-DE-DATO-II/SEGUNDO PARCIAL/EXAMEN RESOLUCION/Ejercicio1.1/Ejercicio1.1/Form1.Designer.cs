namespace Ejercicio1._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.LST_NUMEROS = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_posicion = new System.Windows.Forms.TextBox();
            this.LST_SUMAR = new System.Windows.Forms.ListBox();
            this.btn_posicion = new System.Windows.Forms.Button();
            this.BTN_mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA CIRCULAR SIMPLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE UN NUMERO :";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(325, 66);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(84, 30);
            this.btn_registrar.TabIndex = 2;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(197, 72);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(72, 20);
            this.txt_num.TabIndex = 4;
            // 
            // LST_NUMEROS
            // 
            this.LST_NUMEROS.FormattingEnabled = true;
            this.LST_NUMEROS.Location = new System.Drawing.Point(47, 126);
            this.LST_NUMEROS.Name = "LST_NUMEROS";
            this.LST_NUMEROS.Size = new System.Drawing.Size(104, 186);
            this.LST_NUMEROS.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "INGRESE POSICION : ";
            // 
            // TXT_posicion
            // 
            this.TXT_posicion.Location = new System.Drawing.Point(168, 338);
            this.TXT_posicion.Name = "TXT_posicion";
            this.TXT_posicion.Size = new System.Drawing.Size(72, 20);
            this.TXT_posicion.TabIndex = 7;
            // 
            // LST_SUMAR
            // 
            this.LST_SUMAR.FormattingEnabled = true;
            this.LST_SUMAR.Location = new System.Drawing.Point(213, 126);
            this.LST_SUMAR.Name = "LST_SUMAR";
            this.LST_SUMAR.Size = new System.Drawing.Size(104, 186);
            this.LST_SUMAR.TabIndex = 8;
            // 
            // btn_posicion
            // 
            this.btn_posicion.Location = new System.Drawing.Point(259, 338);
            this.btn_posicion.Name = "btn_posicion";
            this.btn_posicion.Size = new System.Drawing.Size(84, 24);
            this.btn_posicion.TabIndex = 9;
            this.btn_posicion.Text = "SUMATORIA";
            this.btn_posicion.UseVisualStyleBackColor = true;
            this.btn_posicion.Click += new System.EventHandler(this.btn_posicion_Click);
            // 
            // BTN_mostrar
            // 
            this.BTN_mostrar.Location = new System.Drawing.Point(407, 147);
            this.BTN_mostrar.Name = "BTN_mostrar";
            this.BTN_mostrar.Size = new System.Drawing.Size(84, 30);
            this.BTN_mostrar.TabIndex = 10;
            this.BTN_mostrar.Text = "MOSTRAR";
            this.BTN_mostrar.UseVisualStyleBackColor = true;
            this.BTN_mostrar.Click += new System.EventHandler(this.BTN_mostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 378);
            this.Controls.Add(this.BTN_mostrar);
            this.Controls.Add(this.btn_posicion);
            this.Controls.Add(this.LST_SUMAR);
            this.Controls.Add(this.TXT_posicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LST_NUMEROS);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.ListBox LST_NUMEROS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_posicion;
        private System.Windows.Forms.ListBox LST_SUMAR;
        private System.Windows.Forms.Button btn_posicion;
        private System.Windows.Forms.Button BTN_mostrar;
    }
}

