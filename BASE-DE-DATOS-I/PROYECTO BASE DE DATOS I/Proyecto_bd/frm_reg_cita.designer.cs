namespace registro_de_las_citas
{
    partial class frm_reg_cita
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
            this.gb_citas = new System.Windows.Forms.GroupBox();
            this.txt_historial = new System.Windows.Forms.TextBox();
            this.txt_medico = new System.Windows.Forms.TextBox();
            this.mtxt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_hora = new System.Windows.Forms.MaskedTextBox();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gb_citas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_citas
            // 
            this.gb_citas.Controls.Add(this.txt_historial);
            this.gb_citas.Controls.Add(this.txt_medico);
            this.gb_citas.Controls.Add(this.mtxt_fecha);
            this.gb_citas.Controls.Add(this.mtxt_hora);
            this.gb_citas.Controls.Add(this.txt_motivo);
            this.gb_citas.Controls.Add(this.label6);
            this.gb_citas.Controls.Add(this.label5);
            this.gb_citas.Controls.Add(this.label4);
            this.gb_citas.Controls.Add(this.label3);
            this.gb_citas.Controls.Add(this.label2);
            this.gb_citas.Controls.Add(this.txt_codigo);
            this.gb_citas.Controls.Add(this.label1);
            this.gb_citas.Location = new System.Drawing.Point(10, 10);
            this.gb_citas.Margin = new System.Windows.Forms.Padding(2);
            this.gb_citas.Name = "gb_citas";
            this.gb_citas.Padding = new System.Windows.Forms.Padding(2);
            this.gb_citas.Size = new System.Drawing.Size(295, 215);
            this.gb_citas.TabIndex = 0;
            this.gb_citas.TabStop = false;
            this.gb_citas.Text = "REGISTRO DE CITAS";
            // 
            // txt_historial
            // 
            this.txt_historial.Location = new System.Drawing.Point(130, 181);
            this.txt_historial.Margin = new System.Windows.Forms.Padding(2);
            this.txt_historial.Name = "txt_historial";
            this.txt_historial.Size = new System.Drawing.Size(92, 20);
            this.txt_historial.TabIndex = 17;
            // 
            // txt_medico
            // 
            this.txt_medico.Location = new System.Drawing.Point(130, 148);
            this.txt_medico.Margin = new System.Windows.Forms.Padding(2);
            this.txt_medico.Name = "txt_medico";
            this.txt_medico.Size = new System.Drawing.Size(92, 20);
            this.txt_medico.TabIndex = 16;
            // 
            // mtxt_fecha
            // 
            this.mtxt_fecha.Location = new System.Drawing.Point(130, 84);
            this.mtxt_fecha.Margin = new System.Windows.Forms.Padding(2);
            this.mtxt_fecha.Mask = "00-00-0000";
            this.mtxt_fecha.Name = "mtxt_fecha";
            this.mtxt_fecha.Size = new System.Drawing.Size(55, 20);
            this.mtxt_fecha.TabIndex = 15;
            this.mtxt_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // mtxt_hora
            // 
            this.mtxt_hora.Location = new System.Drawing.Point(130, 119);
            this.mtxt_hora.Margin = new System.Windows.Forms.Padding(2);
            this.mtxt_hora.Mask = "90:00";
            this.mtxt_hora.Name = "mtxt_hora";
            this.mtxt_hora.Size = new System.Drawing.Size(33, 20);
            this.mtxt_hora.TabIndex = 5;
            this.mtxt_hora.ValidatingType = typeof(System.DateTime);
            // 
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(130, 54);
            this.txt_motivo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(158, 20);
            this.txt_motivo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "HISTORIAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "MEDICO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "HORA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "FECHA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MOTIVO";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(130, 27);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(92, 20);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(9, 268);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(89, 27);
            this.btn_registrar.TabIndex = 2;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(102, 268);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(80, 27);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(548, 268);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(2);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(76, 27);
            this.btn_volver.TabIndex = 4;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(301, 79);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(310, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 115);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historiales de registro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(310, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 115);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicos disponibles";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(301, 79);
            this.dataGridView2.TabIndex = 5;
            // 
            // frm_reg_cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 306);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.gb_citas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_reg_cita";
            this.Text = "REGISTRO DE LAS CITAS";
            this.Load += new System.EventHandler(this.frm_reg_cita_Load);
            this.gb_citas.ResumeLayout(false);
            this.gb_citas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_citas;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.MaskedTextBox mtxt_hora;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.MaskedTextBox mtxt_fecha;
        private System.Windows.Forms.TextBox txt_historial;
        private System.Windows.Forms.TextBox txt_medico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

