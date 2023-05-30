namespace TablaSanti
{
    partial class frm_reg_pac
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
            this.txt_cod_pac = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_telfPac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_correoPac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_direccPac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_apellidoMatPac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_apellidoPatPac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomPac = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_limpiarPac = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO:";
            // 
            // txt_cod_pac
            // 
            this.txt_cod_pac.Location = new System.Drawing.Point(157, 57);
            this.txt_cod_pac.Name = "txt_cod_pac";
            this.txt_cod_pac.Size = new System.Drawing.Size(100, 20);
            this.txt_cod_pac.TabIndex = 1;
            this.txt_cod_pac.TextChanged += new System.EventHandler(this.txt_cod_pac_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_telfPac);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_correoPac);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_direccPac);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_apellidoMatPac);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_apellidoPatPac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nomPac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_cod_pac);
            this.groupBox1.Location = new System.Drawing.Point(27, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 315);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "TELEFONO:";
            // 
            // txt_telfPac
            // 
            this.txt_telfPac.Location = new System.Drawing.Point(157, 267);
            this.txt_telfPac.Name = "txt_telfPac";
            this.txt_telfPac.Size = new System.Drawing.Size(100, 20);
            this.txt_telfPac.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "CORREO ELECTRONICO:";
            // 
            // txt_correoPac
            // 
            this.txt_correoPac.Location = new System.Drawing.Point(157, 233);
            this.txt_correoPac.Name = "txt_correoPac";
            this.txt_correoPac.Size = new System.Drawing.Size(253, 20);
            this.txt_correoPac.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "DIRECCION:";
            // 
            // txt_direccPac
            // 
            this.txt_direccPac.Location = new System.Drawing.Point(157, 198);
            this.txt_direccPac.Name = "txt_direccPac";
            this.txt_direccPac.Size = new System.Drawing.Size(253, 20);
            this.txt_direccPac.TabIndex = 12;
            this.txt_direccPac.TextChanged += new System.EventHandler(this.txt_direccPac_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "APELLIDO MATERNO:";
            // 
            // txt_apellidoMatPac
            // 
            this.txt_apellidoMatPac.Location = new System.Drawing.Point(157, 163);
            this.txt_apellidoMatPac.Name = "txt_apellidoMatPac";
            this.txt_apellidoMatPac.Size = new System.Drawing.Size(253, 20);
            this.txt_apellidoMatPac.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "APELLIDO PATERNO:";
            // 
            // txt_apellidoPatPac
            // 
            this.txt_apellidoPatPac.Location = new System.Drawing.Point(157, 128);
            this.txt_apellidoPatPac.Name = "txt_apellidoPatPac";
            this.txt_apellidoPatPac.Size = new System.Drawing.Size(253, 20);
            this.txt_apellidoPatPac.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE:";
            // 
            // txt_nomPac
            // 
            this.txt_nomPac.Location = new System.Drawing.Point(157, 92);
            this.txt_nomPac.Name = "txt_nomPac";
            this.txt_nomPac.Size = new System.Drawing.Size(253, 20);
            this.txt_nomPac.TabIndex = 3;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(27, 375);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(113, 38);
            this.btn_registrar.TabIndex = 3;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(390, 375);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(113, 38);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_limpiarPac
            // 
            this.btn_limpiarPac.Location = new System.Drawing.Point(146, 375);
            this.btn_limpiarPac.Name = "btn_limpiarPac";
            this.btn_limpiarPac.Size = new System.Drawing.Size(113, 38);
            this.btn_limpiarPac.TabIndex = 6;
            this.btn_limpiarPac.Text = "LIMPIAR";
            this.btn_limpiarPac.UseVisualStyleBackColor = true;
            this.btn_limpiarPac.Click += new System.EventHandler(this.btn_limpiarPac_Click);
            // 
            // frm_reg_pac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.btn_limpiarPac);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_reg_pac";
            this.Text = "PACIENTE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cod_pac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nomPac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_correoPac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_direccPac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_apellidoMatPac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_apellidoPatPac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_telfPac;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_limpiarPac;
    }
}

