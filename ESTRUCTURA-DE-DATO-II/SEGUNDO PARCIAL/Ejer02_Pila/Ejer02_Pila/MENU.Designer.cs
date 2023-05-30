namespace Ejer02_Pila
{
    partial class FRM_MENU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MENU));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPRESA DE VENTA Y COMPRA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Black;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(12, 33);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(150, 47);
            this.btn_registrar.TabIndex = 1;
            this.btn_registrar.Text = "REGISTRAR ARTICULO";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Black;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(48, 86);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(77, 39);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btn_registrar);
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Location = new System.Drawing.Point(163, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 142);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FRM_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FRM_MENU";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.FRM_MENU_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}