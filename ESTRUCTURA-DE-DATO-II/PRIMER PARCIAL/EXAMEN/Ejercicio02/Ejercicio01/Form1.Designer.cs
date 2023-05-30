namespace Ejercicio01
{
    partial class Frm_principal
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
            this.txt_numingreso = new System.Windows.Forms.TextBox();
            this.lista_numeros = new System.Windows.Forms.ListBox();
            this.Btn_registrar_num = new System.Windows.Forms.Button();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.lst_numeros2 = new System.Windows.Forms.ListBox();
            this.lstintercalado = new System.Windows.Forms.ListBox();
            this.btn_INTECALAR = new System.Windows.Forms.Button();
            this.btn_regi_lista2 = new System.Windows.Forms.Button();
            this.BTN_limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE NUMEROS ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE UN NUMERO : ";
            // 
            // txt_numingreso
            // 
            this.txt_numingreso.Location = new System.Drawing.Point(243, 105);
            this.txt_numingreso.Name = "txt_numingreso";
            this.txt_numingreso.Size = new System.Drawing.Size(100, 20);
            this.txt_numingreso.TabIndex = 2;
            // 
            // lista_numeros
            // 
            this.lista_numeros.FormattingEnabled = true;
            this.lista_numeros.Location = new System.Drawing.Point(42, 188);
            this.lista_numeros.Name = "lista_numeros";
            this.lista_numeros.Size = new System.Drawing.Size(88, 199);
            this.lista_numeros.TabIndex = 3;
            // 
            // Btn_registrar_num
            // 
            this.Btn_registrar_num.Location = new System.Drawing.Point(481, 92);
            this.Btn_registrar_num.Name = "Btn_registrar_num";
            this.Btn_registrar_num.Size = new System.Drawing.Size(86, 45);
            this.Btn_registrar_num.TabIndex = 4;
            this.Btn_registrar_num.Text = "REGISTRAR LISTA 1";
            this.Btn_registrar_num.UseVisualStyleBackColor = true;
            this.Btn_registrar_num.Click += new System.EventHandler(this.Btn_registrar_num_Click);
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(587, 240);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(90, 45);
            this.Btn_Mostrar.TabIndex = 5;
            this.Btn_Mostrar.Text = "MOSTRAR ";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(592, 352);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(85, 35);
            this.Btn_salir.TabIndex = 6;
            this.Btn_salir.Text = "SALIR";
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // lst_numeros2
            // 
            this.lst_numeros2.FormattingEnabled = true;
            this.lst_numeros2.Location = new System.Drawing.Point(162, 188);
            this.lst_numeros2.Name = "lst_numeros2";
            this.lst_numeros2.Size = new System.Drawing.Size(88, 199);
            this.lst_numeros2.TabIndex = 7;
            // 
            // lstintercalado
            // 
            this.lstintercalado.FormattingEnabled = true;
            this.lstintercalado.Location = new System.Drawing.Point(281, 188);
            this.lstintercalado.Name = "lstintercalado";
            this.lstintercalado.Size = new System.Drawing.Size(88, 199);
            this.lstintercalado.TabIndex = 8;
            this.lstintercalado.SelectedIndexChanged += new System.EventHandler(this.lstintercalado_SelectedIndexChanged);
            // 
            // btn_INTECALAR
            // 
            this.btn_INTECALAR.Location = new System.Drawing.Point(587, 301);
            this.btn_INTECALAR.Name = "btn_INTECALAR";
            this.btn_INTECALAR.Size = new System.Drawing.Size(90, 45);
            this.btn_INTECALAR.TabIndex = 9;
            this.btn_INTECALAR.Text = "INTERCALAR";
            this.btn_INTECALAR.UseVisualStyleBackColor = true;
            this.btn_INTECALAR.Click += new System.EventHandler(this.btn_eleminar_Click);
            // 
            // btn_regi_lista2
            // 
            this.btn_regi_lista2.Location = new System.Drawing.Point(587, 92);
            this.btn_regi_lista2.Name = "btn_regi_lista2";
            this.btn_regi_lista2.Size = new System.Drawing.Size(86, 45);
            this.btn_regi_lista2.TabIndex = 10;
            this.btn_regi_lista2.Text = "REGISTRAR LISTA 2";
            this.btn_regi_lista2.UseVisualStyleBackColor = true;
            this.btn_regi_lista2.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_limpiar
            // 
            this.BTN_limpiar.Location = new System.Drawing.Point(587, 188);
            this.BTN_limpiar.Name = "BTN_limpiar";
            this.BTN_limpiar.Size = new System.Drawing.Size(90, 45);
            this.BTN_limpiar.TabIndex = 11;
            this.BTN_limpiar.Text = "LIMPIAR";
            this.BTN_limpiar.UseVisualStyleBackColor = true;
            this.BTN_limpiar.Click += new System.EventHandler(this.BTN_limpiar_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 399);
            this.Controls.Add(this.BTN_limpiar);
            this.Controls.Add(this.btn_regi_lista2);
            this.Controls.Add(this.btn_INTECALAR);
            this.Controls.Add(this.lstintercalado);
            this.Controls.Add(this.lst_numeros2);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_Mostrar);
            this.Controls.Add(this.Btn_registrar_num);
            this.Controls.Add(this.lista_numeros);
            this.Controls.Add(this.txt_numingreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_principal";
            this.Text = "ELEMINAR REPETIDOS";
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numingreso;
        private System.Windows.Forms.ListBox lista_numeros;
        private System.Windows.Forms.Button Btn_registrar_num;
        private System.Windows.Forms.Button Btn_Mostrar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.ListBox lst_numeros2;
        private System.Windows.Forms.ListBox lstintercalado;
        private System.Windows.Forms.Button btn_INTECALAR;
        private System.Windows.Forms.Button btn_regi_lista2;
        private System.Windows.Forms.Button BTN_limpiar;
    }
}

