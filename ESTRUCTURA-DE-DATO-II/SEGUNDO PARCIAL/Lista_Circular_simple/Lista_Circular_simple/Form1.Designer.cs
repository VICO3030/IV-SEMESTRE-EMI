namespace Lista_Circular_simple
{
    partial class FRM_PRINCIPAL
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
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lst_lista = new System.Windows.Forms.ListBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.BTN_SALIR = new System.Windows.Forms.Button();
            this.txt_eleminarnum = new System.Windows.Forms.TextBox();
            this.BTN_ELEMINARNUM = new System.Windows.Forms.Button();
            this.BTN_ORDENAR = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.txt_insertar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA CIRCULAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE UN NUMERO : ";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(455, 59);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(88, 43);
            this.btn_registrar.TabIndex = 2;
            this.btn_registrar.Text = "REGISTRAR  NUMERO  ";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(199, 71);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 3;
            // 
            // lst_lista
            // 
            this.lst_lista.FormattingEnabled = true;
            this.lst_lista.Location = new System.Drawing.Point(53, 114);
            this.lst_lista.Name = "lst_lista";
            this.lst_lista.Size = new System.Drawing.Size(116, 160);
            this.lst_lista.TabIndex = 4;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(455, 125);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(88, 43);
            this.btn_mostrar.TabIndex = 5;
            this.btn_mostrar.Text = "MOSTRAR";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // BTN_SALIR
            // 
            this.BTN_SALIR.Location = new System.Drawing.Point(455, 192);
            this.BTN_SALIR.Name = "BTN_SALIR";
            this.BTN_SALIR.Size = new System.Drawing.Size(88, 43);
            this.BTN_SALIR.TabIndex = 6;
            this.BTN_SALIR.Text = "SALIR ";
            this.BTN_SALIR.UseVisualStyleBackColor = true;
            this.BTN_SALIR.Click += new System.EventHandler(this.BTN_SALIR_Click);
            // 
            // txt_eleminarnum
            // 
            this.txt_eleminarnum.Location = new System.Drawing.Point(133, 363);
            this.txt_eleminarnum.Name = "txt_eleminarnum";
            this.txt_eleminarnum.Size = new System.Drawing.Size(71, 20);
            this.txt_eleminarnum.TabIndex = 7;
            // 
            // BTN_ELEMINARNUM
            // 
            this.BTN_ELEMINARNUM.Location = new System.Drawing.Point(34, 353);
            this.BTN_ELEMINARNUM.Name = "BTN_ELEMINARNUM";
            this.BTN_ELEMINARNUM.Size = new System.Drawing.Size(78, 39);
            this.BTN_ELEMINARNUM.TabIndex = 9;
            this.BTN_ELEMINARNUM.Text = "ELEMINAR NUM";
            this.BTN_ELEMINARNUM.UseVisualStyleBackColor = true;
            this.BTN_ELEMINARNUM.Click += new System.EventHandler(this.BTN_ELEMINARNUM_Click);
            // 
            // BTN_ORDENAR
            // 
            this.BTN_ORDENAR.Location = new System.Drawing.Point(455, 257);
            this.BTN_ORDENAR.Name = "BTN_ORDENAR";
            this.BTN_ORDENAR.Size = new System.Drawing.Size(88, 43);
            this.BTN_ORDENAR.TabIndex = 10;
            this.BTN_ORDENAR.Text = "ORDENAR";
            this.BTN_ORDENAR.UseVisualStyleBackColor = true;
            this.BTN_ORDENAR.Click += new System.EventHandler(this.BTN_ORDENAR_Click);
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(265, 358);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(78, 29);
            this.btn_insertar.TabIndex = 11;
            this.btn_insertar.Text = "INSERTAR";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Visible = false;
            this.btn_insertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_insertar
            // 
            this.txt_insertar.Location = new System.Drawing.Point(366, 363);
            this.txt_insertar.Name = "txt_insertar";
            this.txt_insertar.Size = new System.Drawing.Size(71, 20);
            this.txt_insertar.TabIndex = 12;
            this.txt_insertar.Visible = false;
            // 
            // FRM_PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 408);
            this.Controls.Add(this.txt_insertar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.BTN_ORDENAR);
            this.Controls.Add(this.BTN_ELEMINARNUM);
            this.Controls.Add(this.txt_eleminarnum);
            this.Controls.Add(this.BTN_SALIR);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.lst_lista);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_PRINCIPAL";
            this.Text = "FORMULARIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.ListBox lst_lista;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button BTN_SALIR;
        private System.Windows.Forms.TextBox txt_eleminarnum;
        private System.Windows.Forms.Button BTN_ELEMINARNUM;
        private System.Windows.Forms.Button BTN_ORDENAR;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.TextBox txt_insertar;
    }
}

