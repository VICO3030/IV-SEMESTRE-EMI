
namespace AplicacionColas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtHojas = new System.Windows.Forms.TextBox();
            this.rdbColor = new System.Windows.Forms.RadioButton();
            this.rdbBlancoYnegro = new System.Windows.Forms.RadioButton();
            this.cboCalidad = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Hojas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calidad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(259, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtHojas
            // 
            this.txtHojas.Location = new System.Drawing.Point(259, 159);
            this.txtHojas.Name = "txtHojas";
            this.txtHojas.Size = new System.Drawing.Size(100, 20);
            this.txtHojas.TabIndex = 4;
            // 
            // rdbColor
            // 
            this.rdbColor.AutoSize = true;
            this.rdbColor.Location = new System.Drawing.Point(107, 295);
            this.rdbColor.Name = "rdbColor";
            this.rdbColor.Size = new System.Drawing.Size(49, 17);
            this.rdbColor.TabIndex = 6;
            this.rdbColor.TabStop = true;
            this.rdbColor.Text = "Color";
            this.rdbColor.UseVisualStyleBackColor = true;
            // 
            // rdbBlancoYnegro
            // 
            this.rdbBlancoYnegro.AutoSize = true;
            this.rdbBlancoYnegro.Location = new System.Drawing.Point(282, 295);
            this.rdbBlancoYnegro.Name = "rdbBlancoYnegro";
            this.rdbBlancoYnegro.Size = new System.Drawing.Size(98, 17);
            this.rdbBlancoYnegro.TabIndex = 7;
            this.rdbBlancoYnegro.TabStop = true;
            this.rdbBlancoYnegro.Text = "Blanco y Negro";
            this.rdbBlancoYnegro.UseVisualStyleBackColor = true;
            // 
            // cboCalidad
            // 
            this.cboCalidad.FormattingEnabled = true;
            this.cboCalidad.Items.AddRange(new object[] {
            "Borrador",
            "Estandar",
            "Alto"});
            this.cboCalidad.Location = new System.Drawing.Point(259, 213);
            this.cboCalidad.Name = "cboCalidad";
            this.cboCalidad.Size = new System.Drawing.Size(121, 21);
            this.cboCalidad.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(107, 363);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimir.Location = new System.Drawing.Point(290, 363);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Epson";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboCalidad);
            this.Controls.Add(this.rdbBlancoYnegro);
            this.Controls.Add(this.rdbColor);
            this.Controls.Add(this.txtHojas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtHojas;
        private System.Windows.Forms.RadioButton rdbColor;
        private System.Windows.Forms.RadioButton rdbBlancoYnegro;
        private System.Windows.Forms.ComboBox cboCalidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label4;
    }
}

