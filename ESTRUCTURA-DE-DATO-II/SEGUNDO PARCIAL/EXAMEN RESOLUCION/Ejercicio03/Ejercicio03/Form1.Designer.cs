namespace Ejercicio03
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
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.LST_ESPERA = new System.Windows.Forms.ListBox();
            this.LST_ATENDIDOS = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_atendidos = new System.Windows.Forms.Button();
            this.CBO_DIAS = new System.Windows.Forms.ComboBox();
            this.BNT_LIMPIAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANCO UNION";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(228, 57);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(48, 20);
            this.txt_cantidad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE LA CANTIDAD DE PERSONAS : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(300, 48);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(86, 36);
            this.btn_registrar.TabIndex = 3;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // LST_ESPERA
            // 
            this.LST_ESPERA.FormattingEnabled = true;
            this.LST_ESPERA.Location = new System.Drawing.Point(39, 101);
            this.LST_ESPERA.Name = "LST_ESPERA";
            this.LST_ESPERA.Size = new System.Drawing.Size(116, 225);
            this.LST_ESPERA.TabIndex = 4;
            this.LST_ESPERA.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LST_ATENDIDOS
            // 
            this.LST_ATENDIDOS.FormattingEnabled = true;
            this.LST_ATENDIDOS.Location = new System.Drawing.Point(190, 101);
            this.LST_ATENDIDOS.Name = "LST_ATENDIDOS";
            this.LST_ATENDIDOS.Size = new System.Drawing.Size(117, 225);
            this.LST_ATENDIDOS.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(439, 217);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 39);
            this.btn_mostrar.TabIndex = 7;
            this.btn_mostrar.Text = "MOSTRAR";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_atendidos
            // 
            this.btn_atendidos.Location = new System.Drawing.Point(439, 168);
            this.btn_atendidos.Name = "btn_atendidos";
            this.btn_atendidos.Size = new System.Drawing.Size(87, 27);
            this.btn_atendidos.TabIndex = 8;
            this.btn_atendidos.Text = "ATENDIDOS";
            this.btn_atendidos.UseVisualStyleBackColor = true;
            this.btn_atendidos.Click += new System.EventHandler(this.btn_atendidos_Click);
            // 
            // CBO_DIAS
            // 
            this.CBO_DIAS.FormattingEnabled = true;
            this.CBO_DIAS.Items.AddRange(new object[] {
            "LUNES ",
            "MARTES",
            "MIERCOLES ",
            "JUEVES ",
            "VIERNES"});
            this.CBO_DIAS.Location = new System.Drawing.Point(439, 141);
            this.CBO_DIAS.Name = "CBO_DIAS";
            this.CBO_DIAS.Size = new System.Drawing.Size(87, 21);
            this.CBO_DIAS.TabIndex = 9;
            this.CBO_DIAS.SelectedIndexChanged += new System.EventHandler(this.CBO_DIAS_SelectedIndexChanged);
            // 
            // BNT_LIMPIAR
            // 
            this.BNT_LIMPIAR.Location = new System.Drawing.Point(439, 101);
            this.BNT_LIMPIAR.Name = "BNT_LIMPIAR";
            this.BNT_LIMPIAR.Size = new System.Drawing.Size(87, 27);
            this.BNT_LIMPIAR.TabIndex = 10;
            this.BNT_LIMPIAR.Text = "LIMPIAR";
            this.BNT_LIMPIAR.UseVisualStyleBackColor = true;
            this.BNT_LIMPIAR.Click += new System.EventHandler(this.BNT_LIMPIAR_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "MOSTRARATENTIDOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BNT_LIMPIAR);
            this.Controls.Add(this.CBO_DIAS);
            this.Controls.Add(this.btn_atendidos);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LST_ATENDIDOS);
            this.Controls.Add(this.LST_ESPERA);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BANCO PRINCIPAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.ListBox LST_ESPERA;
        private System.Windows.Forms.ListBox LST_ATENDIDOS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_atendidos;
        private System.Windows.Forms.ComboBox CBO_DIAS;
        private System.Windows.Forms.Button BNT_LIMPIAR;
        private System.Windows.Forms.Button button1;
    }
}

