namespace Ejer04_Cola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Grp_impresion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_nro = new System.Windows.Forms.TextBox();
            this.txt_calidad = new System.Windows.Forms.ComboBox();
            this.rbd_negro = new System.Windows.Forms.RadioButton();
            this.rbd_color = new System.Windows.Forms.RadioButton();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Grp_impresion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grp_impresion
            // 
            this.Grp_impresion.Controls.Add(this.rbd_color);
            this.Grp_impresion.Controls.Add(this.rbd_negro);
            this.Grp_impresion.Controls.Add(this.txt_calidad);
            this.Grp_impresion.Controls.Add(this.txt_nro);
            this.Grp_impresion.Controls.Add(this.txt_nom);
            this.Grp_impresion.Controls.Add(this.label3);
            this.Grp_impresion.Controls.Add(this.label2);
            this.Grp_impresion.Controls.Add(this.label1);
            this.Grp_impresion.Location = new System.Drawing.Point(73, 91);
            this.Grp_impresion.Name = "Grp_impresion";
            this.Grp_impresion.Size = new System.Drawing.Size(300, 188);
            this.Grp_impresion.TabIndex = 0;
            this.Grp_impresion.TabStop = false;
            this.Grp_impresion.Text = "DATOS DE IMPRESION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Documento :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de hojas :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calidad :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(154, 44);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 3;
            // 
            // txt_nro
            // 
            this.txt_nro.Location = new System.Drawing.Point(121, 80);
            this.txt_nro.Name = "txt_nro";
            this.txt_nro.Size = new System.Drawing.Size(64, 20);
            this.txt_nro.TabIndex = 4;
            // 
            // txt_calidad
            // 
            this.txt_calidad.FormattingEnabled = true;
            this.txt_calidad.Items.AddRange(new object[] {
            "Borrador",
            "Estandar",
            "Alto"});
            this.txt_calidad.Location = new System.Drawing.Point(76, 111);
            this.txt_calidad.Name = "txt_calidad";
            this.txt_calidad.Size = new System.Drawing.Size(121, 21);
            this.txt_calidad.TabIndex = 5;
            // 
            // rbd_negro
            // 
            this.rbd_negro.AutoSize = true;
            this.rbd_negro.Location = new System.Drawing.Point(37, 149);
            this.rbd_negro.Name = "rbd_negro";
            this.rbd_negro.Size = new System.Drawing.Size(90, 17);
            this.rbd_negro.TabIndex = 6;
            this.rbd_negro.TabStop = true;
            this.rbd_negro.Text = "Blanco Negro";
            this.rbd_negro.UseVisualStyleBackColor = true;
            this.rbd_negro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbd_color
            // 
            this.rbd_color.AutoSize = true;
            this.rbd_color.Location = new System.Drawing.Point(154, 149);
            this.rbd_color.Name = "rbd_color";
            this.rbd_color.Size = new System.Drawing.Size(49, 17);
            this.rbd_color.TabIndex = 7;
            this.rbd_color.TabStop = true;
            this.rbd_color.Text = "Color";
            this.rbd_color.UseVisualStyleBackColor = true;
            this.rbd_color.CheckedChanged += new System.EventHandler(this.rbd_color_CheckedChanged);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(98, 300);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(70, 32);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(237, 300);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 32);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(355, 356);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(62, 33);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "IMPRESORA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.Grp_impresion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Grp_impresion.ResumeLayout(false);
            this.Grp_impresion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grp_impresion;
        private System.Windows.Forms.RadioButton rbd_color;
        private System.Windows.Forms.RadioButton rbd_negro;
        private System.Windows.Forms.ComboBox txt_calidad;
        private System.Windows.Forms.TextBox txt_nro;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

