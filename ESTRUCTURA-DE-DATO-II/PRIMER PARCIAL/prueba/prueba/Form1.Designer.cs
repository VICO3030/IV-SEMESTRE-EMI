namespace prueba
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
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Rdb_fem = new System.Windows.Forms.RadioButton();
            this.Rdb_mas = new System.Windows.Forms.RadioButton();
            this.CBO_CARRERA = new System.Windows.Forms.ComboBox();
            this.Btn_Registrer = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LST_alumnos = new System.Windows.Forms.ListBox();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.lbl_nota2 = new System.Windows.Forms.Label();
            this.LST_aprobados = new System.Windows.Forms.ListBox();
            this.LST_reprobados = new System.Windows.Forms.ListBox();
            this.Btn_calcularnota = new System.Windows.Forms.Button();
            this.lbl_nota3 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_n3 = new System.Windows.Forms.TextBox();
            this.Btn_notalta_baja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(114, 87);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(293, 20);
            this.txt_nom.TabIndex = 1;
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(114, 125);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(293, 20);
            this.txt_cod.TabIndex = 2;
            this.txt_cod.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(114, 217);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(293, 20);
            this.txt_edad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "ESCUELA MILIAR DE INGENIERIA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edad :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Rdb_fem
            // 
            this.Rdb_fem.AutoSize = true;
            this.Rdb_fem.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_fem.Location = new System.Drawing.Point(92, 253);
            this.Rdb_fem.Name = "Rdb_fem";
            this.Rdb_fem.Size = new System.Drawing.Size(100, 23);
            this.Rdb_fem.TabIndex = 9;
            this.Rdb_fem.TabStop = true;
            this.Rdb_fem.Text = "FEMENINO";
            this.Rdb_fem.UseVisualStyleBackColor = true;
            this.Rdb_fem.CheckedChanged += new System.EventHandler(this.Rdb_hom_CheckedChanged);
            // 
            // Rdb_mas
            // 
            this.Rdb_mas.AutoSize = true;
            this.Rdb_mas.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_mas.Location = new System.Drawing.Point(259, 253);
            this.Rdb_mas.Name = "Rdb_mas";
            this.Rdb_mas.Size = new System.Drawing.Size(110, 23);
            this.Rdb_mas.TabIndex = 10;
            this.Rdb_mas.TabStop = true;
            this.Rdb_mas.Text = "MASCULINO";
            this.Rdb_mas.UseVisualStyleBackColor = true;
            this.Rdb_mas.CheckedChanged += new System.EventHandler(this.Rdb_mas_CheckedChanged);
            // 
            // CBO_CARRERA
            // 
            this.CBO_CARRERA.FormattingEnabled = true;
            this.CBO_CARRERA.Items.AddRange(new object[] {
            "ING.SISTEMAS",
            "ING. PETROLERA",
            "ING.ELECTRONICA",
            "ING.COMERCIAL",
            "ING.MECATRONICA"});
            this.CBO_CARRERA.Location = new System.Drawing.Point(116, 170);
            this.CBO_CARRERA.Name = "CBO_CARRERA";
            this.CBO_CARRERA.Size = new System.Drawing.Size(294, 21);
            this.CBO_CARRERA.TabIndex = 11;
            // 
            // Btn_Registrer
            // 
            this.Btn_Registrer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Registrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registrer.Location = new System.Drawing.Point(572, 349);
            this.Btn_Registrer.Name = "Btn_Registrer";
            this.Btn_Registrer.Size = new System.Drawing.Size(151, 36);
            this.Btn_Registrer.TabIndex = 12;
            this.Btn_Registrer.Text = "REGISTRAR ALUMNO";
            this.Btn_Registrer.UseVisualStyleBackColor = false;
            this.Btn_Registrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Limpiar.Enabled = false;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar.Location = new System.Drawing.Point(572, 425);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(151, 29);
            this.Btn_Limpiar.TabIndex = 13;
            this.Btn_Limpiar.Text = "LIMPIAR";
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cerrar.Location = new System.Drawing.Point(572, 474);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(154, 23);
            this.btn_cerrar.TabIndex = 14;
            this.btn_cerrar.Text = "CERRAR CESION";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carrera :";
            // 
            // LST_alumnos
            // 
            this.LST_alumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LST_alumnos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LST_alumnos.FormattingEnabled = true;
            this.LST_alumnos.ItemHeight = 17;
            this.LST_alumnos.Location = new System.Drawing.Point(475, 87);
            this.LST_alumnos.Name = "LST_alumnos";
            this.LST_alumnos.Size = new System.Drawing.Size(238, 174);
            this.LST_alumnos.TabIndex = 15;
            this.LST_alumnos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_nota.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nota.Location = new System.Drawing.Point(32, 320);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(63, 18);
            this.lbl_nota.TabIndex = 16;
            this.lbl_nota.Text = "nota 1 : ";
            this.lbl_nota.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_nota2
            // 
            this.lbl_nota2.AutoSize = true;
            this.lbl_nota2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_nota2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nota2.Location = new System.Drawing.Point(32, 358);
            this.lbl_nota2.Name = "lbl_nota2";
            this.lbl_nota2.Size = new System.Drawing.Size(59, 18);
            this.lbl_nota2.TabIndex = 17;
            this.lbl_nota2.Text = "nota 2 :";
            // 
            // LST_aprobados
            // 
            this.LST_aprobados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LST_aprobados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LST_aprobados.FormattingEnabled = true;
            this.LST_aprobados.ItemHeight = 17;
            this.LST_aprobados.Location = new System.Drawing.Point(210, 322);
            this.LST_aprobados.Name = "LST_aprobados";
            this.LST_aprobados.Size = new System.Drawing.Size(173, 174);
            this.LST_aprobados.TabIndex = 18;
            this.LST_aprobados.SelectedIndexChanged += new System.EventHandler(this.LST_aprobados_SelectedIndexChanged);
            // 
            // LST_reprobados
            // 
            this.LST_reprobados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LST_reprobados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LST_reprobados.FormattingEnabled = true;
            this.LST_reprobados.ItemHeight = 17;
            this.LST_reprobados.Location = new System.Drawing.Point(389, 320);
            this.LST_reprobados.Name = "LST_reprobados";
            this.LST_reprobados.Size = new System.Drawing.Size(177, 174);
            this.LST_reprobados.TabIndex = 19;
            // 
            // Btn_calcularnota
            // 
            this.Btn_calcularnota.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_calcularnota.Enabled = false;
            this.Btn_calcularnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_calcularnota.Location = new System.Drawing.Point(572, 390);
            this.Btn_calcularnota.Name = "Btn_calcularnota";
            this.Btn_calcularnota.Size = new System.Drawing.Size(151, 29);
            this.Btn_calcularnota.TabIndex = 20;
            this.Btn_calcularnota.Text = "CALCULAR NOTA";
            this.Btn_calcularnota.UseVisualStyleBackColor = false;
            this.Btn_calcularnota.Click += new System.EventHandler(this.Btn_calcularnota_Click);
            // 
            // lbl_nota3
            // 
            this.lbl_nota3.AutoSize = true;
            this.lbl_nota3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_nota3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nota3.Location = new System.Drawing.Point(32, 401);
            this.lbl_nota3.Name = "lbl_nota3";
            this.lbl_nota3.Size = new System.Drawing.Size(59, 18);
            this.lbl_nota3.TabIndex = 21;
            this.lbl_nota3.Text = "nota 3 :";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(92, 322);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(51, 20);
            this.txt_n1.TabIndex = 22;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(92, 358);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(51, 20);
            this.txt_n2.TabIndex = 23;
            // 
            // txt_n3
            // 
            this.txt_n3.Location = new System.Drawing.Point(92, 401);
            this.txt_n3.Name = "txt_n3";
            this.txt_n3.Size = new System.Drawing.Size(51, 20);
            this.txt_n3.TabIndex = 24;
            // 
            // Btn_notalta_baja
            // 
            this.Btn_notalta_baja.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_notalta_baja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_notalta_baja.Location = new System.Drawing.Point(575, 289);
            this.Btn_notalta_baja.Name = "Btn_notalta_baja";
            this.Btn_notalta_baja.Size = new System.Drawing.Size(151, 36);
            this.Btn_notalta_baja.TabIndex = 25;
            this.Btn_notalta_baja.Text = "NOTA ALTA Y BAJA";
            this.Btn_notalta_baja.UseVisualStyleBackColor = false;
            this.Btn_notalta_baja.Click += new System.EventHandler(this.Btn_notalta_baja_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::prueba.Properties.Resources.emi_900;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(781, 508);
            this.Controls.Add(this.Btn_notalta_baja);
            this.Controls.Add(this.txt_n3);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_nota3);
            this.Controls.Add(this.Btn_calcularnota);
            this.Controls.Add(this.LST_reprobados);
            this.Controls.Add(this.LST_aprobados);
            this.Controls.Add(this.lbl_nota2);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.LST_alumnos);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Registrer);
            this.Controls.Add(this.CBO_CARRERA);
            this.Controls.Add(this.Rdb_mas);
            this.Controls.Add(this.Rdb_fem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "ESCUELA MILITAR DE INGENIERIA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Rdb_fem;
        private System.Windows.Forms.RadioButton Rdb_mas;
        private System.Windows.Forms.ComboBox CBO_CARRERA;
        private System.Windows.Forms.Button Btn_Registrer;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LST_alumnos;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.Label lbl_nota2;
        private System.Windows.Forms.ListBox LST_aprobados;
        private System.Windows.Forms.ListBox LST_reprobados;
        private System.Windows.Forms.Button Btn_calcularnota;
        private System.Windows.Forms.Label lbl_nota3;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.TextBox txt_n3;
        private System.Windows.Forms.Button Btn_notalta_baja;
    }
}

