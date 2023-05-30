namespace LISTAS_SIMPLES
{
    partial class FRM_lista
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
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.Lst_lista = new System.Windows.Forms.ListBox();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.Btn_mostrar = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_promedio = new System.Windows.Forms.Button();
            this.Lbl_prom = new System.Windows.Forms.Label();
            this.Btn_menor = new System.Windows.Forms.Button();
            this.Btn_mayor = new System.Windows.Forms.Button();
            this.txt_menor = new System.Windows.Forms.TextBox();
            this.txt_mayor = new System.Windows.Forms.TextBox();
            this.Rbd_Edad = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Eleminar = new System.Windows.Forms.Button();
            this.txt_nom_eleminar = new System.Windows.Forms.TextBox();
            this.Btn_Insertarnodo = new System.Windows.Forms.Button();
            this.Btn_edad_eleminar = new System.Windows.Forms.Button();
            this.txt_eleminar_edad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(446, 116);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(233, 20);
            this.txt_nom.TabIndex = 0;
            this.txt_nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(446, 176);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(233, 20);
            this.txt_edad.TabIndex = 1;
            this.txt_edad.TextChanged += new System.EventHandler(this.txt_edad_TextChanged);
            // 
            // Lst_lista
            // 
            this.Lst_lista.FormattingEnabled = true;
            this.Lst_lista.Location = new System.Drawing.Point(43, 298);
            this.Lst_lista.Name = "Lst_lista";
            this.Lst_lista.Size = new System.Drawing.Size(161, 160);
            this.Lst_lista.TabIndex = 2;
            this.Lst_lista.SelectedIndexChanged += new System.EventHandler(this.Lst_lista_SelectedIndexChanged);
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.Location = new System.Drawing.Point(727, 8);
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.Size = new System.Drawing.Size(95, 46);
            this.Btn_registrar.TabIndex = 3;
            this.Btn_registrar.Text = "REGISTRAR ALUMNOS";
            this.Btn_registrar.UseVisualStyleBackColor = true;
            this.Btn_registrar.Click += new System.EventHandler(this.Btn_registrar_Click);
            // 
            // Btn_mostrar
            // 
            this.Btn_mostrar.Location = new System.Drawing.Point(727, 67);
            this.Btn_mostrar.Name = "Btn_mostrar";
            this.Btn_mostrar.Size = new System.Drawing.Size(95, 49);
            this.Btn_mostrar.TabIndex = 4;
            this.Btn_mostrar.Text = "MOSTRAR ESTUDIANTES";
            this.Btn_mostrar.UseVisualStyleBackColor = true;
            this.Btn_mostrar.Click += new System.EventHandler(this.Btn_mostrar_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(727, 267);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(95, 49);
            this.Btn_limpiar.TabIndex = 5;
            this.Btn_limpiar.Text = "LIMPIAR";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.Red;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.ForeColor = System.Drawing.Color.Red;
            this.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_salir.Location = new System.Drawing.Point(727, 335);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(95, 34);
            this.Btn_salir.TabIndex = 6;
            this.Btn_salir.Text = "SALIR";
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(203, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 22);
            this.label1.TabIndex = 7;
            this.label1.Tag = "";
            this.label1.Text = "INGRESE EL NOMBRE : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(212, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 8;
            this.label2.Tag = "";
            this.label2.Text = "INGRESE LA EDAD  : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Btn_promedio
            // 
            this.Btn_promedio.Location = new System.Drawing.Point(727, 131);
            this.Btn_promedio.Name = "Btn_promedio";
            this.Btn_promedio.Size = new System.Drawing.Size(95, 49);
            this.Btn_promedio.TabIndex = 9;
            this.Btn_promedio.Text = "EDAD PROMEDIO";
            this.Btn_promedio.UseVisualStyleBackColor = true;
            this.Btn_promedio.Click += new System.EventHandler(this.Btn_promedio_Click);
            // 
            // Lbl_prom
            // 
            this.Lbl_prom.AutoSize = true;
            this.Lbl_prom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Lbl_prom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_prom.Location = new System.Drawing.Point(76, 461);
            this.Lbl_prom.Name = "Lbl_prom";
            this.Lbl_prom.Size = new System.Drawing.Size(35, 13);
            this.Lbl_prom.TabIndex = 10;
            this.Lbl_prom.Text = "label3";
            this.Lbl_prom.Click += new System.EventHandler(this.label3_Click);
            // 
            // Btn_menor
            // 
            this.Btn_menor.Location = new System.Drawing.Point(242, 239);
            this.Btn_menor.Name = "Btn_menor";
            this.Btn_menor.Size = new System.Drawing.Size(79, 34);
            this.Btn_menor.TabIndex = 11;
            this.Btn_menor.Text = "Menor";
            this.Btn_menor.UseVisualStyleBackColor = true;
            this.Btn_menor.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_mayor
            // 
            this.Btn_mayor.Location = new System.Drawing.Point(242, 290);
            this.Btn_mayor.Name = "Btn_mayor";
            this.Btn_mayor.Size = new System.Drawing.Size(79, 34);
            this.Btn_mayor.TabIndex = 13;
            this.Btn_mayor.Text = "Mayor";
            this.Btn_mayor.UseVisualStyleBackColor = true;
            this.Btn_mayor.Click += new System.EventHandler(this.Btn_mayor_Click);
            // 
            // txt_menor
            // 
            this.txt_menor.Location = new System.Drawing.Point(341, 247);
            this.txt_menor.Name = "txt_menor";
            this.txt_menor.Size = new System.Drawing.Size(64, 20);
            this.txt_menor.TabIndex = 14;
            this.txt_menor.TextChanged += new System.EventHandler(this.txt_menor_TextChanged);
            // 
            // txt_mayor
            // 
            this.txt_mayor.Location = new System.Drawing.Point(341, 298);
            this.txt_mayor.Name = "txt_mayor";
            this.txt_mayor.Size = new System.Drawing.Size(64, 20);
            this.txt_mayor.TabIndex = 15;
            this.txt_mayor.TextChanged += new System.EventHandler(this.txt_mayor_TextChanged);
            // 
            // Rbd_Edad
            // 
            this.Rbd_Edad.AutoSize = true;
            this.Rbd_Edad.Location = new System.Drawing.Point(254, 392);
            this.Rbd_Edad.Name = "Rbd_Edad";
            this.Rbd_Edad.Size = new System.Drawing.Size(55, 17);
            this.Rbd_Edad.TabIndex = 16;
            this.Rbd_Edad.TabStop = true;
            this.Rbd_Edad.Text = "EDAD";
            this.Rbd_Edad.UseVisualStyleBackColor = true;
            this.Rbd_Edad.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(254, 425);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NOMBRE";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(250, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 18;
            this.label3.Tag = "";
            this.label3.Text = "ORDENAMIENTO";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(727, 201);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(95, 49);
            this.Btn_buscar.TabIndex = 20;
            this.Btn_buscar.Text = "BUSCAR";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LISTAS_SIMPLES.Properties.Resources.emi_900;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(274, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 36);
            this.label4.TabIndex = 21;
            this.label4.Tag = "";
            this.label4.Text = "LLENADO DE LISTA ";
            // 
            // Btn_Eleminar
            // 
            this.Btn_Eleminar.Location = new System.Drawing.Point(488, 500);
            this.Btn_Eleminar.Name = "Btn_Eleminar";
            this.Btn_Eleminar.Size = new System.Drawing.Size(95, 37);
            this.Btn_Eleminar.TabIndex = 22;
            this.Btn_Eleminar.Text = "ELEMINAR";
            this.Btn_Eleminar.UseVisualStyleBackColor = true;
            this.Btn_Eleminar.Click += new System.EventHandler(this.Btn_Eleminar_Click);
            // 
            // txt_nom_eleminar
            // 
            this.txt_nom_eleminar.Location = new System.Drawing.Point(353, 509);
            this.txt_nom_eleminar.Name = "txt_nom_eleminar";
            this.txt_nom_eleminar.Size = new System.Drawing.Size(129, 20);
            this.txt_nom_eleminar.TabIndex = 23;
            this.txt_nom_eleminar.TextChanged += new System.EventHandler(this.txt_nom_eleminar_TextChanged);
            // 
            // Btn_Insertarnodo
            // 
            this.Btn_Insertarnodo.Location = new System.Drawing.Point(727, 392);
            this.Btn_Insertarnodo.Name = "Btn_Insertarnodo";
            this.Btn_Insertarnodo.Size = new System.Drawing.Size(95, 49);
            this.Btn_Insertarnodo.TabIndex = 25;
            this.Btn_Insertarnodo.Text = "INSERTAR DATO";
            this.Btn_Insertarnodo.UseVisualStyleBackColor = true;
            this.Btn_Insertarnodo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Btn_edad_eleminar
            // 
            this.Btn_edad_eleminar.Location = new System.Drawing.Point(488, 457);
            this.Btn_edad_eleminar.Name = "Btn_edad_eleminar";
            this.Btn_edad_eleminar.Size = new System.Drawing.Size(95, 37);
            this.Btn_edad_eleminar.TabIndex = 26;
            this.Btn_edad_eleminar.Text = "ELEMINAR EDAD";
            this.Btn_edad_eleminar.UseVisualStyleBackColor = true;
            this.Btn_edad_eleminar.Click += new System.EventHandler(this.Btn_edad_eleminar_Click);
            // 
            // txt_eleminar_edad
            // 
            this.txt_eleminar_edad.Location = new System.Drawing.Point(353, 466);
            this.txt_eleminar_edad.Name = "txt_eleminar_edad";
            this.txt_eleminar_edad.Size = new System.Drawing.Size(129, 20);
            this.txt_eleminar_edad.TabIndex = 27;
            // 
            // FRM_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(906, 549);
            this.Controls.Add(this.txt_eleminar_edad);
            this.Controls.Add(this.Btn_edad_eleminar);
            this.Controls.Add(this.Btn_Insertarnodo);
            this.Controls.Add(this.txt_nom_eleminar);
            this.Controls.Add(this.Btn_Eleminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.Rbd_Edad);
            this.Controls.Add(this.txt_mayor);
            this.Controls.Add(this.txt_menor);
            this.Controls.Add(this.Btn_mayor);
            this.Controls.Add(this.Btn_menor);
            this.Controls.Add(this.Lbl_prom);
            this.Controls.Add(this.Btn_promedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_mostrar);
            this.Controls.Add(this.Btn_registrar);
            this.Controls.Add(this.Lst_lista);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_nom);
            this.Name = "FRM_lista";
            this.Text = "LISTAS_SIMPLES";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.FRM_lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.ListBox Lst_lista;
        private System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.Button Btn_mostrar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_promedio;
        private System.Windows.Forms.Label Lbl_prom;
        private System.Windows.Forms.Button Btn_menor;
        private System.Windows.Forms.Button Btn_mayor;
        private System.Windows.Forms.TextBox txt_menor;
        private System.Windows.Forms.TextBox txt_mayor;
        private System.Windows.Forms.RadioButton Rbd_Edad;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Eleminar;
        private System.Windows.Forms.TextBox txt_nom_eleminar;
        private System.Windows.Forms.Button Btn_Insertarnodo;
        private System.Windows.Forms.Button Btn_edad_eleminar;
        private System.Windows.Forms.TextBox txt_eleminar_edad;
    }
}

