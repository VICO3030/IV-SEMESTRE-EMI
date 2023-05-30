namespace HISTORIA_CLINICA
{
    partial class frm_reg_hist
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.gb_historia_clinica = new System.Windows.Forms.GroupBox();
            this.txt_paciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.cod_paciente = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_pacientes = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.gb_historia_clinica.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(196, 145);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(2);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(76, 27);
            this.btn_volver.TabIndex = 8;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(103, 145);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(80, 27);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Enabled = false;
            this.btn_registrar.Location = new System.Drawing.Point(9, 145);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(89, 27);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // gb_historia_clinica
            // 
            this.gb_historia_clinica.Controls.Add(this.btn_buscar);
            this.gb_historia_clinica.Controls.Add(this.txt_paciente);
            this.gb_historia_clinica.Controls.Add(this.label7);
            this.gb_historia_clinica.Controls.Add(this.txt_descripcion);
            this.gb_historia_clinica.Controls.Add(this.cod_paciente);
            this.gb_historia_clinica.Controls.Add(this.txt_codigo);
            this.gb_historia_clinica.Controls.Add(this.label1);
            this.gb_historia_clinica.Location = new System.Drawing.Point(10, 10);
            this.gb_historia_clinica.Margin = new System.Windows.Forms.Padding(2);
            this.gb_historia_clinica.Name = "gb_historia_clinica";
            this.gb_historia_clinica.Padding = new System.Windows.Forms.Padding(2);
            this.gb_historia_clinica.Size = new System.Drawing.Size(353, 131);
            this.gb_historia_clinica.TabIndex = 5;
            this.gb_historia_clinica.TabStop = false;
            this.gb_historia_clinica.Text = "HISTORIA CLINICA";
            // 
            // txt_paciente
            // 
            this.txt_paciente.Location = new System.Drawing.Point(130, 55);
            this.txt_paciente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_paciente.Name = "txt_paciente";
            this.txt_paciente.Size = new System.Drawing.Size(92, 20);
            this.txt_paciente.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "DESCRIPCION";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(130, 90);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(208, 20);
            this.txt_descripcion.TabIndex = 7;
            // 
            // cod_paciente
            // 
            this.cod_paciente.AutoSize = true;
            this.cod_paciente.Location = new System.Drawing.Point(24, 59);
            this.cod_paciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cod_paciente.Name = "cod_paciente";
            this.cod_paciente.Size = new System.Drawing.Size(60, 13);
            this.cod_paciente.TabIndex = 2;
            this.cod_paciente.Text = "PACIENTE";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(130, 27);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(92, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_pacientes);
            this.groupBox1.Location = new System.Drawing.Point(369, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 279);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PACIENTES VALIDOS";
            // 
            // dgv_pacientes
            // 
            this.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacientes.Location = new System.Drawing.Point(7, 20);
            this.dgv_pacientes.Name = "dgv_pacientes";
            this.dgv_pacientes.Size = new System.Drawing.Size(297, 253);
            this.dgv_pacientes.TabIndex = 0;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(226, 52);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(89, 27);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // frm_reg_hist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.gb_historia_clinica);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_reg_hist";
            this.Text = "HISTORIA CLINICA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_historia_clinica.ResumeLayout(false);
            this.gb_historia_clinica.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.GroupBox gb_historia_clinica;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label cod_paciente;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_paciente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_pacientes;
        private System.Windows.Forms.Button btn_buscar;
    }
}

