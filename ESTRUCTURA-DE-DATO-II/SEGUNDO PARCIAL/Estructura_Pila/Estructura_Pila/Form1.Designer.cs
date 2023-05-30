namespace Estructura_Pila
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
            this.txt_DATO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_apilar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_desapilar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.LST_PILA = new System.Windows.Forms.ListBox();
            this.txt_eleminar = new System.Windows.Forms.TextBox();
            this.btn_eleminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_DATO
            // 
            this.txt_DATO.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DATO.Location = new System.Drawing.Point(230, 56);
            this.txt_DATO.Name = "txt_DATO";
            this.txt_DATO.Size = new System.Drawing.Size(73, 20);
            this.txt_DATO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE DATO :";
            // 
            // btn_apilar
            // 
            this.btn_apilar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apilar.Location = new System.Drawing.Point(309, 48);
            this.btn_apilar.Name = "btn_apilar";
            this.btn_apilar.Size = new System.Drawing.Size(62, 35);
            this.btn_apilar.TabIndex = 3;
            this.btn_apilar.Text = "APILAR";
            this.btn_apilar.UseVisualStyleBackColor = true;
            this.btn_apilar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar.Location = new System.Drawing.Point(276, 118);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 31);
            this.btn_mostrar.TabIndex = 4;
            this.btn_mostrar.Text = "MOSTRAR";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_desapilar
            // 
            this.btn_desapilar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desapilar.Location = new System.Drawing.Point(276, 169);
            this.btn_desapilar.Name = "btn_desapilar";
            this.btn_desapilar.Size = new System.Drawing.Size(87, 31);
            this.btn_desapilar.TabIndex = 5;
            this.btn_desapilar.Text = "DESAPILAR";
            this.btn_desapilar.UseVisualStyleBackColor = true;
            this.btn_desapilar.Click += new System.EventHandler(this.btn_desapilar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(276, 221);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 34);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // LST_PILA
            // 
            this.LST_PILA.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LST_PILA.FormattingEnabled = true;
            this.LST_PILA.ItemHeight = 16;
            this.LST_PILA.Location = new System.Drawing.Point(142, 118);
            this.LST_PILA.Name = "LST_PILA";
            this.LST_PILA.Size = new System.Drawing.Size(93, 148);
            this.LST_PILA.TabIndex = 7;
            // 
            // txt_eleminar
            // 
            this.txt_eleminar.Location = new System.Drawing.Point(177, 287);
            this.txt_eleminar.Name = "txt_eleminar";
            this.txt_eleminar.Size = new System.Drawing.Size(43, 20);
            this.txt_eleminar.TabIndex = 8;
            this.txt_eleminar.Visible = false;
            // 
            // btn_eleminar
            // 
            this.btn_eleminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eleminar.Location = new System.Drawing.Point(95, 287);
            this.btn_eleminar.Name = "btn_eleminar";
            this.btn_eleminar.Size = new System.Drawing.Size(76, 20);
            this.btn_eleminar.TabIndex = 9;
            this.btn_eleminar.Text = "ELEMINAR :";
            this.btn_eleminar.UseVisualStyleBackColor = true;
            this.btn_eleminar.Visible = false;
            this.btn_eleminar.Click += new System.EventHandler(this.btn_eleminar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(95, 324);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(76, 20);
            this.btn_buscar.TabIndex = 10;
            this.btn_buscar.Text = "BUSCAR :";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Visible = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(177, 324);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(43, 20);
            this.txt_buscar.TabIndex = 11;
            this.txt_buscar.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estructura_Pila.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(396, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_eleminar);
            this.Controls.Add(this.txt_eleminar);
            this.Controls.Add(this.LST_PILA);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_desapilar);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_apilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DATO);
            this.Controls.Add(this.label1);
            this.Name = "Frm_principal";
            this.Text = "PILA";
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DATO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_apilar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_desapilar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ListBox LST_PILA;
        private System.Windows.Forms.TextBox txt_eleminar;
        private System.Windows.Forms.Button btn_eleminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

