namespace TablaSanti
{
    partial class frm_rep_pac
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_mostrarPac = new System.Windows.Forms.Button();
            this.dtgv_pacientes = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_cod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(683, 348);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_mostrarPac
            // 
            this.btn_mostrarPac.Location = new System.Drawing.Point(27, 350);
            this.btn_mostrarPac.Name = "btn_mostrarPac";
            this.btn_mostrarPac.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrarPac.TabIndex = 4;
            this.btn_mostrarPac.Text = "MOSTRAR";
            this.btn_mostrarPac.UseVisualStyleBackColor = true;
            this.btn_mostrarPac.Click += new System.EventHandler(this.btn_mostrarPac_Click);
            // 
            // dtgv_pacientes
            // 
            this.dtgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_pacientes.Location = new System.Drawing.Point(27, 26);
            this.dtgv_pacientes.Name = "dtgv_pacientes";
            this.dtgv_pacientes.Size = new System.Drawing.Size(731, 300);
            this.dtgv_pacientes.TabIndex = 3;
            this.dtgv_pacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(108, 350);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(190, 351);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 7;
            // 
            // frm_rep_pac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 385);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_mostrarPac);
            this.Controls.Add(this.dtgv_pacientes);
            this.Name = "frm_rep_pac";
            this.Text = "REGISTRO DE PACIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_mostrarPac;
        private System.Windows.Forms.DataGridView dtgv_pacientes;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_cod;
    }
}