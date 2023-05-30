namespace Lista_simple
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
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.BTN_REGISTRAR = new System.Windows.Forms.Button();
            this.BTN_MOSTRAR = new System.Windows.Forms.Button();
            this.BTN_LIMPIAR = new System.Windows.Forms.Button();
            this.LST_LISTAREGISTRO = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(178, 89);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE USUARIOS DE INTERNET ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE USUARIO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CODIGO :";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(178, 129);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 3;
            // 
            // BTN_REGISTRAR
            // 
            this.BTN_REGISTRAR.Location = new System.Drawing.Point(370, 89);
            this.BTN_REGISTRAR.Name = "BTN_REGISTRAR";
            this.BTN_REGISTRAR.Size = new System.Drawing.Size(90, 31);
            this.BTN_REGISTRAR.TabIndex = 5;
            this.BTN_REGISTRAR.Text = "REGISTRAR";
            this.BTN_REGISTRAR.UseVisualStyleBackColor = true;
            this.BTN_REGISTRAR.Click += new System.EventHandler(this.BTN_REGISTRAR_Click);
            // 
            // BTN_MOSTRAR
            // 
            this.BTN_MOSTRAR.Location = new System.Drawing.Point(370, 140);
            this.BTN_MOSTRAR.Name = "BTN_MOSTRAR";
            this.BTN_MOSTRAR.Size = new System.Drawing.Size(74, 35);
            this.BTN_MOSTRAR.TabIndex = 6;
            this.BTN_MOSTRAR.Text = "MOSTRAR";
            this.BTN_MOSTRAR.UseVisualStyleBackColor = true;
            this.BTN_MOSTRAR.Click += new System.EventHandler(this.BTN_MOSTRAR_Click);
            // 
            // BTN_LIMPIAR
            // 
            this.BTN_LIMPIAR.Location = new System.Drawing.Point(370, 193);
            this.BTN_LIMPIAR.Name = "BTN_LIMPIAR";
            this.BTN_LIMPIAR.Size = new System.Drawing.Size(74, 35);
            this.BTN_LIMPIAR.TabIndex = 7;
            this.BTN_LIMPIAR.Text = "LIMPIAR";
            this.BTN_LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // LST_LISTAREGISTRO
            // 
            this.LST_LISTAREGISTRO.FormattingEnabled = true;
            this.LST_LISTAREGISTRO.Location = new System.Drawing.Point(43, 184);
            this.LST_LISTAREGISTRO.Name = "LST_LISTAREGISTRO";
            this.LST_LISTAREGISTRO.Size = new System.Drawing.Size(103, 160);
            this.LST_LISTAREGISTRO.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 364);
            this.Controls.Add(this.LST_LISTAREGISTRO);
            this.Controls.Add(this.BTN_LIMPIAR);
            this.Controls.Add(this.BTN_MOSTRAR);
            this.Controls.Add(this.BTN_REGISTRAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_usuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button BTN_REGISTRAR;
        private System.Windows.Forms.Button BTN_MOSTRAR;
        private System.Windows.Forms.Button BTN_LIMPIAR;
        private System.Windows.Forms.ListBox LST_LISTAREGISTRO;
    }
}

