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
            this.lst_repetidos = new System.Windows.Forms.ListBox();
            this.btn_eleminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE NUMEROS ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE UN NUMERO : ";
            // 
            // txt_numingreso
            // 
            this.txt_numingreso.Location = new System.Drawing.Point(180, 105);
            this.txt_numingreso.Name = "txt_numingreso";
            this.txt_numingreso.Size = new System.Drawing.Size(100, 20);
            this.txt_numingreso.TabIndex = 2;
            // 
            // lista_numeros
            // 
            this.lista_numeros.FormattingEnabled = true;
            this.lista_numeros.Location = new System.Drawing.Point(112, 170);
            this.lista_numeros.Name = "lista_numeros";
            this.lista_numeros.Size = new System.Drawing.Size(77, 134);
            this.lista_numeros.TabIndex = 3;
            // 
            // Btn_registrar_num
            // 
            this.Btn_registrar_num.Location = new System.Drawing.Point(343, 92);
            this.Btn_registrar_num.Name = "Btn_registrar_num";
            this.Btn_registrar_num.Size = new System.Drawing.Size(86, 45);
            this.Btn_registrar_num.TabIndex = 4;
            this.Btn_registrar_num.Text = "REGISTRAR NUMERO";
            this.Btn_registrar_num.UseVisualStyleBackColor = true;
            this.Btn_registrar_num.Click += new System.EventHandler(this.Btn_registrar_num_Click);
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(112, 330);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(90, 45);
            this.Btn_Mostrar.TabIndex = 5;
            this.Btn_Mostrar.Text = "MOSTRAR ";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(12, 352);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(85, 35);
            this.Btn_salir.TabIndex = 6;
            this.Btn_salir.Text = "SALIR";
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // lst_repetidos
            // 
            this.lst_repetidos.FormattingEnabled = true;
            this.lst_repetidos.Location = new System.Drawing.Point(286, 170);
            this.lst_repetidos.Name = "lst_repetidos";
            this.lst_repetidos.Size = new System.Drawing.Size(72, 134);
            this.lst_repetidos.TabIndex = 7;
            this.lst_repetidos.SelectedIndexChanged += new System.EventHandler(this.lst_repetidos_SelectedIndexChanged);
            // 
            // btn_eleminar
            // 
            this.btn_eleminar.Location = new System.Drawing.Point(268, 330);
            this.btn_eleminar.Name = "btn_eleminar";
            this.btn_eleminar.Size = new System.Drawing.Size(90, 45);
            this.btn_eleminar.TabIndex = 9;
            this.btn_eleminar.Text = "ELEMINAR REPETIDOS";
            this.btn_eleminar.UseVisualStyleBackColor = true;
            this.btn_eleminar.Click += new System.EventHandler(this.btn_eleminar_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 399);
            this.Controls.Add(this.btn_eleminar);
            this.Controls.Add(this.lst_repetidos);
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
        private System.Windows.Forms.ListBox lst_repetidos;
        private System.Windows.Forms.Button btn_eleminar;
    }
}

