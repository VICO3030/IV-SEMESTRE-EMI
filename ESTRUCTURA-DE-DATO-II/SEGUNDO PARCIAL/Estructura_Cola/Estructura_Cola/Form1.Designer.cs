namespace Estructura_Cola
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
            this.txt_dato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_encolar = new System.Windows.Forms.Button();
            this.btn_desencolar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.LST_COLAS = new System.Windows.Forms.ListBox();
            this.BTN_BUSCAR = new System.Windows.Forms.Button();
            this.BTN_ELEMINAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTRUCTURA COLA";
            // 
            // txt_dato
            // 
            this.txt_dato.Location = new System.Drawing.Point(157, 77);
            this.txt_dato.Name = "txt_dato";
            this.txt_dato.Size = new System.Drawing.Size(57, 20);
            this.txt_dato.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE DATO :";
            // 
            // btn_encolar
            // 
            this.btn_encolar.Location = new System.Drawing.Point(288, 77);
            this.btn_encolar.Name = "btn_encolar";
            this.btn_encolar.Size = new System.Drawing.Size(68, 29);
            this.btn_encolar.TabIndex = 3;
            this.btn_encolar.Text = "ENCOLAR";
            this.btn_encolar.UseVisualStyleBackColor = true;
            this.btn_encolar.Click += new System.EventHandler(this.btn_encolar_Click);
            // 
            // btn_desencolar
            // 
            this.btn_desencolar.Location = new System.Drawing.Point(288, 133);
            this.btn_desencolar.Name = "btn_desencolar";
            this.btn_desencolar.Size = new System.Drawing.Size(98, 29);
            this.btn_desencolar.TabIndex = 4;
            this.btn_desencolar.Text = "DESENCOLAR";
            this.btn_desencolar.UseVisualStyleBackColor = true;
            this.btn_desencolar.Click += new System.EventHandler(this.btn_desencolar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(288, 185);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(86, 32);
            this.btn_mostrar.TabIndex = 5;
            this.btn_mostrar.Text = "MOSTRAR";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(288, 244);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(68, 29);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // LST_COLAS
            // 
            this.LST_COLAS.FormattingEnabled = true;
            this.LST_COLAS.Location = new System.Drawing.Point(74, 133);
            this.LST_COLAS.Name = "LST_COLAS";
            this.LST_COLAS.Size = new System.Drawing.Size(110, 186);
            this.LST_COLAS.TabIndex = 7;
            // 
            // BTN_BUSCAR
            // 
            this.BTN_BUSCAR.Location = new System.Drawing.Point(288, 290);
            this.BTN_BUSCAR.Name = "BTN_BUSCAR";
            this.BTN_BUSCAR.Size = new System.Drawing.Size(68, 29);
            this.BTN_BUSCAR.TabIndex = 8;
            this.BTN_BUSCAR.Text = "BUSCAR";
            this.BTN_BUSCAR.UseVisualStyleBackColor = true;
            this.BTN_BUSCAR.Click += new System.EventHandler(this.BTN_BUSCAR_Click);
            // 
            // BTN_ELEMINAR
            // 
            this.BTN_ELEMINAR.Location = new System.Drawing.Point(288, 337);
            this.BTN_ELEMINAR.Name = "BTN_ELEMINAR";
            this.BTN_ELEMINAR.Size = new System.Drawing.Size(86, 29);
            this.BTN_ELEMINAR.TabIndex = 9;
            this.BTN_ELEMINAR.Text = "ELEMINAR";
            this.BTN_ELEMINAR.UseVisualStyleBackColor = true;
            this.BTN_ELEMINAR.Click += new System.EventHandler(this.BTN_ELEMINAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 378);
            this.Controls.Add(this.BTN_ELEMINAR);
            this.Controls.Add(this.BTN_BUSCAR);
            this.Controls.Add(this.LST_COLAS);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_desencolar);
            this.Controls.Add(this.btn_encolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dato);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_encolar;
        private System.Windows.Forms.Button btn_desencolar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ListBox LST_COLAS;
        private System.Windows.Forms.Button BTN_BUSCAR;
        private System.Windows.Forms.Button BTN_ELEMINAR;
    }
}

