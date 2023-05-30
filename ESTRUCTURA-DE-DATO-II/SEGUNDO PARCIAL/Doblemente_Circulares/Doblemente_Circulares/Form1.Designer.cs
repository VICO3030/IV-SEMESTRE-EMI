namespace Doblemente_Circulares
{
    partial class Frm_Principal
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
            this.LST_NUMEROS = new System.Windows.Forms.ListBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.BTN_mostrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_eleminar = new System.Windows.Forms.TextBox();
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.txt_insertar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LST_NUMEROS
            // 
            this.LST_NUMEROS.FormattingEnabled = true;
            this.LST_NUMEROS.Location = new System.Drawing.Point(157, 137);
            this.LST_NUMEROS.Name = "LST_NUMEROS";
            this.LST_NUMEROS.Size = new System.Drawing.Size(120, 134);
            this.LST_NUMEROS.TabIndex = 0;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(537, 71);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(86, 38);
            this.btn_registrar.TabIndex = 1;
            this.btn_registrar.Text = "REGISTRAR NUMERO";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // BTN_mostrar
            // 
            this.BTN_mostrar.Location = new System.Drawing.Point(537, 137);
            this.BTN_mostrar.Name = "BTN_mostrar";
            this.BTN_mostrar.Size = new System.Drawing.Size(86, 38);
            this.BTN_mostrar.TabIndex = 2;
            this.BTN_mostrar.Text = "MOSTRAR ";
            this.BTN_mostrar.UseVisualStyleBackColor = true;
            this.BTN_mostrar.Click += new System.EventHandler(this.BTN_mostrar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(80, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "ELEMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(537, 195);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(86, 33);
            this.BTN_SALIR.TabIndex = 4;
            this.BTN_SALIR.Text = "SALIR";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "FORMULARIO DE REGISTRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "INGRESE UN NUMERO : ";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(217, 79);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(72, 20);
            this.txt_numero.TabIndex = 7;
            // 
            // txt_eleminar
            // 
            this.txt_eleminar.Location = new System.Drawing.Point(172, 328);
            this.txt_eleminar.Name = "txt_eleminar";
            this.txt_eleminar.Size = new System.Drawing.Size(72, 20);
            this.txt_eleminar.TabIndex = 8;
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.Location = new System.Drawing.Point(537, 244);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(86, 38);
            this.btn_ordenar.TabIndex = 9;
            this.btn_ordenar.Text = "ORDENAR";
            this.btn_ordenar.UseVisualStyleBackColor = true;
            this.btn_ordenar.Click += new System.EventHandler(this.btn_ordenar_Click);
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(312, 320);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(86, 35);
            this.btn_insertar.TabIndex = 10;
            this.btn_insertar.Text = "INSERTAR :";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Visible = false;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // txt_insertar
            // 
            this.txt_insertar.Location = new System.Drawing.Point(410, 328);
            this.txt_insertar.Name = "txt_insertar";
            this.txt_insertar.Size = new System.Drawing.Size(72, 20);
            this.txt_insertar.TabIndex = 11;
            this.txt_insertar.Visible = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 376);
            this.Controls.Add(this.txt_insertar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.btn_ordenar);
            this.Controls.Add(this.txt_eleminar);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTN_mostrar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.LST_NUMEROS);
            this.Name = "Frm_Principal";
            this.Text = "FORMULARIO ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LST_NUMEROS;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button BTN_mostrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_eleminar;
        private System.Windows.Forms.Button btn_ordenar;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.TextBox txt_insertar;
    }
}

