namespace PREGUNTA_4
{
    partial class Frm
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Num_Hojas = new System.Windows.Forms.TextBox();
            this.cbx_calcol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cola_impresion = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(213, 95);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(150, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // txt_Num_Hojas
            // 
            this.txt_Num_Hojas.Location = new System.Drawing.Point(213, 141);
            this.txt_Num_Hojas.Name = "txt_Num_Hojas";
            this.txt_Num_Hojas.Size = new System.Drawing.Size(150, 20);
            this.txt_Num_Hojas.TabIndex = 2;
            // 
            // cbx_calcol
            // 
            this.cbx_calcol.FormattingEnabled = true;
            this.cbx_calcol.Items.AddRange(new object[] {
            "Borrador y color",
            "Borrador y negro_gris",
            "Estandar y color",
            "Estandar y negro_gris",
            "Alto y color",
            "Alto y negro_gris"});
            this.cbx_calcol.Location = new System.Drawing.Point(213, 194);
            this.cbx_calcol.Name = "cbx_calcol";
            this.cbx_calcol.Size = new System.Drawing.Size(150, 21);
            this.cbx_calcol.TabIndex = 3;
            this.cbx_calcol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE DEL DOCUMENTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CALIDAD Y COLOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NUMERO DE HOJAS:";
            // 
            // btn_Cola_impresion
            // 
            this.btn_Cola_impresion.Location = new System.Drawing.Point(84, 255);
            this.btn_Cola_impresion.Name = "btn_Cola_impresion";
            this.btn_Cola_impresion.Size = new System.Drawing.Size(245, 24);
            this.btn_Cola_impresion.TabIndex = 7;
            this.btn_Cola_impresion.Text = "AGREGAR A LA COLA DE IMPRESION";
            this.btn_Cola_impresion.UseVisualStyleBackColor = true;
            this.btn_Cola_impresion.Click += new System.EventHandler(this.btn_Cola_impresion_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(80, 301);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(249, 62);
            this.btn_imprimir.TabIndex = 8;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "IMPRESORA";
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(84, 391);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(245, 24);
            this.btn_Mostrar.TabIndex = 10;
            this.btn_Mostrar.Text = "MOSTRAR COLA DE IMPRESION";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 459);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_Cola_impresion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_calcol);
            this.Controls.Add(this.txt_Num_Hojas);
            this.Controls.Add(this.txt_Nombre);
            this.Name = "Frm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbx_calcol;
        private System.Windows.Forms.TextBox txt_Num_Hojas;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cola_impresion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_Mostrar;
    }
}

