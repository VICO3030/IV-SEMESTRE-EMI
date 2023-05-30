namespace Listas_Doblemente_enlazadas
{
    partial class FrmPrincipal
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
            this.Btn_registerCarrera = new System.Windows.Forms.Button();
            this.Btn_registerCiclista = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_MostrarCarrera = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_registerCarrera
            // 
            this.Btn_registerCarrera.Location = new System.Drawing.Point(125, 48);
            this.Btn_registerCarrera.Name = "Btn_registerCarrera";
            this.Btn_registerCarrera.Size = new System.Drawing.Size(135, 23);
            this.Btn_registerCarrera.TabIndex = 0;
            this.Btn_registerCarrera.Text = "Registrar a la carrera";
            this.Btn_registerCarrera.UseVisualStyleBackColor = true;
            this.Btn_registerCarrera.Click += new System.EventHandler(this.Btn_registerCarrera_Click);
            // 
            // Btn_registerCiclista
            // 
            this.Btn_registerCiclista.Location = new System.Drawing.Point(147, 62);
            this.Btn_registerCiclista.Name = "Btn_registerCiclista";
            this.Btn_registerCiclista.Size = new System.Drawing.Size(135, 23);
            this.Btn_registerCiclista.TabIndex = 1;
            this.Btn_registerCiclista.Text = "Registrar un ciclista";
            this.Btn_registerCiclista.UseVisualStyleBackColor = true;
            this.Btn_registerCiclista.Click += new System.EventHandler(this.Btn_registerCiclista_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_buscar);
            this.groupBox1.Controls.Add(this.Btn_Mostrar);
            this.groupBox1.Controls.Add(this.Btn_registerCiclista);
            this.groupBox1.Location = new System.Drawing.Point(26, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciclists";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(221, 33);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(135, 23);
            this.Btn_buscar.TabIndex = 4;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(66, 33);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(135, 23);
            this.Btn_Mostrar.TabIndex = 3;
            this.Btn_Mostrar.Text = "Mostrar";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_MostrarCarrera);
            this.groupBox2.Controls.Add(this.Btn_registerCarrera);
            this.groupBox2.Location = new System.Drawing.Point(432, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carreras";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_MostrarCarrera
            // 
            this.btn_MostrarCarrera.Location = new System.Drawing.Point(125, 19);
            this.btn_MostrarCarrera.Name = "btn_MostrarCarrera";
            this.btn_MostrarCarrera.Size = new System.Drawing.Size(135, 23);
            this.btn_MostrarCarrera.TabIndex = 4;
            this.btn_MostrarCarrera.Text = "Mostrar";
            this.btn_MostrarCarrera.UseVisualStyleBackColor = true;
            this.btn_MostrarCarrera.Click += new System.EventHandler(this.btn_MostrarCarrera_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(26, 186);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(135, 23);
            this.Btn_salir.TabIndex = 1;
            this.Btn_salir.Text = "lsita";
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 220);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_registerCarrera;
        private System.Windows.Forms.Button Btn_registerCiclista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_Mostrar;
        private System.Windows.Forms.Button btn_MostrarCarrera;
    }
}

