namespace registro_de_las_citas
{
    partial class frm_rep_cita
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
            this.brb_reporte_citas = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_volver_reporte = new System.Windows.Forms.Button();
            this.brb_reporte_citas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // brb_reporte_citas
            // 
            this.brb_reporte_citas.Controls.Add(this.dataGridView1);
            this.brb_reporte_citas.Location = new System.Drawing.Point(9, 10);
            this.brb_reporte_citas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brb_reporte_citas.Name = "brb_reporte_citas";
            this.brb_reporte_citas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brb_reporte_citas.Size = new System.Drawing.Size(632, 213);
            this.brb_reporte_citas.TabIndex = 0;
            this.brb_reporte_citas.TabStop = false;
            this.brb_reporte_citas.Text = "REPORTE DE CITAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(92, 228);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(62, 28);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 233);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(20, 228);
            this.btn_mostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(68, 28);
            this.btn_mostrar.TabIndex = 3;
            this.btn_mostrar.Text = "MOSTRAR";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_volver_reporte
            // 
            this.btn_volver_reporte.Location = new System.Drawing.Point(570, 228);
            this.btn_volver_reporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_volver_reporte.Name = "btn_volver_reporte";
            this.btn_volver_reporte.Size = new System.Drawing.Size(71, 28);
            this.btn_volver_reporte.TabIndex = 4;
            this.btn_volver_reporte.Text = "VOLVER";
            this.btn_volver_reporte.UseVisualStyleBackColor = true;
            this.btn_volver_reporte.Click += new System.EventHandler(this.btn_volver_reporte_Click);
            // 
            // frm_rep_cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 266);
            this.Controls.Add(this.btn_volver_reporte);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.brb_reporte_citas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_rep_cita";
            this.Text = "reporte_citas";
            this.brb_reporte_citas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox brb_reporte_citas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_volver_reporte;
    }
}