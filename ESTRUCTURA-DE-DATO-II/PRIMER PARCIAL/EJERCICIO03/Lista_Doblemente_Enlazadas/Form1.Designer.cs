namespace Lista_Doblemente_Enlazadas
{
    partial class Frm_ciclista
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
            this.txt_nom_ciclista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nro_Ciclista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.txt_categoria = new System.Windows.Forms.ComboBox();
            this.Btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nom_ciclista
            // 
            this.txt_nom_ciclista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom_ciclista.Location = new System.Drawing.Point(309, 109);
            this.txt_nom_ciclista.Name = "txt_nom_ciclista";
            this.txt_nom_ciclista.Size = new System.Drawing.Size(215, 24);
            this.txt_nom_ciclista.TabIndex = 0;
            this.txt_nom_ciclista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nom_KeyPress);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(248, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESGISTRO DECICLISTAS";
            // 
            // txt_nro_Ciclista
            // 
            this.txt_nro_Ciclista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nro_Ciclista.Location = new System.Drawing.Point(309, 157);
            this.txt_nro_Ciclista.Name = "txt_nro_Ciclista";
            this.txt_nro_Ciclista.Size = new System.Drawing.Size(119, 24);
            this.txt_nro_Ciclista.TabIndex = 2;
            this.txt_nro_Ciclista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nBici_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "NUMERO DE BICICLETA : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "CATEGORIA : ";
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.Location = new System.Drawing.Point(253, 270);
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.Size = new System.Drawing.Size(108, 45);
            this.Btn_registrar.TabIndex = 7;
            this.Btn_registrar.Text = "REGISTRAR COMPETIDOR";
            this.Btn_registrar.UseVisualStyleBackColor = true;
            this.Btn_registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_categoria
            // 
            this.txt_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoria.FormattingEnabled = true;
            this.txt_categoria.Items.AddRange(new object[] {
            "JUVENIL",
            "MAYORES",
            "SENIORS",
            "ELITE"});
            this.txt_categoria.Location = new System.Drawing.Point(309, 189);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(138, 26);
            this.txt_categoria.TabIndex = 8;
            // 
            // Btn_volver
            // 
            this.Btn_volver.Location = new System.Drawing.Point(557, 361);
            this.Btn_volver.Name = "Btn_volver";
            this.Btn_volver.Size = new System.Drawing.Size(108, 45);
            this.Btn_volver.TabIndex = 9;
            this.Btn_volver.Text = "VOLVER";
            this.Btn_volver.UseVisualStyleBackColor = true;
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
            // 
            // Frm_ciclista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lista_Doblemente_Enlazadas.Properties.Resources.pexels_pixabay_248559___Editada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 418);
            this.Controls.Add(this.Btn_volver);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.Btn_registrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nro_Ciclista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nom_ciclista);
            this.DoubleBuffered = true;
            this.Name = "Frm_ciclista";
            this.Text = "RESGISTRO_CICLISTAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nom_ciclista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nro_Ciclista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.ComboBox txt_categoria;
        private System.Windows.Forms.Button Btn_volver;
    }
}

