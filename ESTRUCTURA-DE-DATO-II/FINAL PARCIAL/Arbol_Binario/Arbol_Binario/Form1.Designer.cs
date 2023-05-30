namespace Arbol_Binario
{
    partial class Frm_principal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_preorden = new System.Windows.Forms.Button();
            this.btn_inorden = new System.Windows.Forms.Button();
            this.btn_postorden = new System.Windows.Forms.Button();
            this.lst_preorden = new System.Windows.Forms.ListBox();
            this.lst_inorden = new System.Windows.Forms.ListBox();
            this.lst_postOrden = new System.Windows.Forms.ListBox();
            this.btn_MostrarGrafica = new System.Windows.Forms.Button();
            this.btn_hojas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "   ARBOL\r\n  BINARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Arbol_Binario.Properties.Resources.dfd4;
            this.pictureBox1.Location = new System.Drawing.Point(12, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE UN NUMERO :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(249, 125);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 5;
            this.txt_numero.TextChanged += new System.EventHandler(this.txt_numero_TextChanged);
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(443, 119);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(87, 30);
            this.btn_insertar.TabIndex = 6;
            this.btn_insertar.Text = "INSERTAR";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "ELEMINAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_preorden
            // 
            this.btn_preorden.Location = new System.Drawing.Point(49, 194);
            this.btn_preorden.Name = "btn_preorden";
            this.btn_preorden.Size = new System.Drawing.Size(87, 30);
            this.btn_preorden.TabIndex = 9;
            this.btn_preorden.Text = "PREORDE";
            this.btn_preorden.UseVisualStyleBackColor = true;
            this.btn_preorden.Click += new System.EventHandler(this.btn_preorden_Click);
            // 
            // btn_inorden
            // 
            this.btn_inorden.Location = new System.Drawing.Point(179, 194);
            this.btn_inorden.Name = "btn_inorden";
            this.btn_inorden.Size = new System.Drawing.Size(87, 30);
            this.btn_inorden.TabIndex = 10;
            this.btn_inorden.Text = "INORDEN";
            this.btn_inorden.UseVisualStyleBackColor = true;
            this.btn_inorden.Click += new System.EventHandler(this.btn_inorden_Click);
            // 
            // btn_postorden
            // 
            this.btn_postorden.Location = new System.Drawing.Point(298, 194);
            this.btn_postorden.Name = "btn_postorden";
            this.btn_postorden.Size = new System.Drawing.Size(87, 30);
            this.btn_postorden.TabIndex = 11;
            this.btn_postorden.Text = "POSTORDE";
            this.btn_postorden.UseVisualStyleBackColor = true;
            this.btn_postorden.Click += new System.EventHandler(this.btn_postorden_Click);
            // 
            // lst_preorden
            // 
            this.lst_preorden.FormattingEnabled = true;
            this.lst_preorden.Location = new System.Drawing.Point(49, 243);
            this.lst_preorden.Name = "lst_preorden";
            this.lst_preorden.Size = new System.Drawing.Size(95, 121);
            this.lst_preorden.TabIndex = 12;
            // 
            // lst_inorden
            // 
            this.lst_inorden.FormattingEnabled = true;
            this.lst_inorden.Location = new System.Drawing.Point(179, 243);
            this.lst_inorden.Name = "lst_inorden";
            this.lst_inorden.Size = new System.Drawing.Size(95, 121);
            this.lst_inorden.TabIndex = 13;
            this.lst_inorden.SelectedIndexChanged += new System.EventHandler(this.lst_inorden_SelectedIndexChanged);
            // 
            // lst_postOrden
            // 
            this.lst_postOrden.FormattingEnabled = true;
            this.lst_postOrden.Location = new System.Drawing.Point(298, 243);
            this.lst_postOrden.Name = "lst_postOrden";
            this.lst_postOrden.Size = new System.Drawing.Size(95, 121);
            this.lst_postOrden.TabIndex = 14;
            // 
            // btn_MostrarGrafica
            // 
            this.btn_MostrarGrafica.Location = new System.Drawing.Point(443, 263);
            this.btn_MostrarGrafica.Name = "btn_MostrarGrafica";
            this.btn_MostrarGrafica.Size = new System.Drawing.Size(87, 30);
            this.btn_MostrarGrafica.TabIndex = 15;
            this.btn_MostrarGrafica.Text = "GRAFICA";
            this.btn_MostrarGrafica.UseVisualStyleBackColor = true;
            this.btn_MostrarGrafica.Click += new System.EventHandler(this.btn_MostrarGrafica_Click);
            // 
            // btn_hojas
            // 
            this.btn_hojas.Location = new System.Drawing.Point(443, 315);
            this.btn_hojas.Name = "btn_hojas";
            this.btn_hojas.Size = new System.Drawing.Size(87, 30);
            this.btn_hojas.TabIndex = 16;
            this.btn_hojas.Text = "HOJAS";
            this.btn_hojas.UseVisualStyleBackColor = true;
            this.btn_hojas.Click += new System.EventHandler(this.btn_hojas_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(549, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_hojas);
            this.Controls.Add(this.btn_MostrarGrafica);
            this.Controls.Add(this.lst_postOrden);
            this.Controls.Add(this.lst_inorden);
            this.Controls.Add(this.lst_preorden);
            this.Controls.Add(this.btn_postorden);
            this.Controls.Add(this.btn_inorden);
            this.Controls.Add(this.btn_preorden);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_principal";
            this.Text = "ARBOL BINARIO";
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_preorden;
        private System.Windows.Forms.Button btn_inorden;
        private System.Windows.Forms.Button btn_postorden;
        private System.Windows.Forms.ListBox lst_preorden;
        private System.Windows.Forms.ListBox lst_inorden;
        private System.Windows.Forms.ListBox lst_postOrden;
        private System.Windows.Forms.Button btn_MostrarGrafica;
        private System.Windows.Forms.Button btn_hojas;
        private System.Windows.Forms.Button button2;
    }
}

