namespace pasos
{
    partial class VICTOR
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tex_COD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "codigo del estudiante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tex_COD
            // 
            this.tex_COD.Location = new System.Drawing.Point(214, 35);
            this.tex_COD.Name = "tex_COD";
            this.tex_COD.Size = new System.Drawing.Size(100, 20);
            this.tex_COD.TabIndex = 1;
            this.tex_COD.Text = "C9901-5";
            this.tex_COD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // VICTOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::pasos.Properties.Resources.emi_900;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 442);
            this.Controls.Add(this.tex_COD);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "VICTOR";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.LightBlue;
            this.Load += new System.EventHandler(this.VICTOR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tex_COD;
    }
}

