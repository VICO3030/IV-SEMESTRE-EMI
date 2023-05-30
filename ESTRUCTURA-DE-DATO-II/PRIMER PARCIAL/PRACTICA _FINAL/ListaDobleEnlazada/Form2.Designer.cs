
namespace ListaDobleEnlazada
{
    partial class frm_carreras
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
            this.grp_datos = new System.Windows.Forms.GroupBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nBici = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lugar = new System.Windows.Forms.TextBox();
            this.txt_tiempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ciclista = new System.Windows.Forms.Label();
            this.lbl_cat = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.dgv_carreras = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_reg = new System.Windows.Forms.Button();
            this.grp_datos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carreras)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_datos
            // 
            this.grp_datos.Controls.Add(this.txt_fecha);
            this.grp_datos.Controls.Add(this.label5);
            this.grp_datos.Controls.Add(this.txt_nBici);
            this.grp_datos.Controls.Add(this.label4);
            this.grp_datos.Controls.Add(this.txt_lugar);
            this.grp_datos.Controls.Add(this.txt_tiempo);
            this.grp_datos.Controls.Add(this.label1);
            this.grp_datos.Controls.Add(this.label3);
            this.grp_datos.Location = new System.Drawing.Point(12, 79);
            this.grp_datos.Name = "grp_datos";
            this.grp_datos.Size = new System.Drawing.Size(298, 162);
            this.grp_datos.TabIndex = 9;
            this.grp_datos.TabStop = false;
            this.grp_datos.Text = "DATOS CARRERA";
            this.grp_datos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(181, 106);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha.TabIndex = 8;
            this.txt_fecha.TextChanged += new System.EventHandler(this.txt_fecha_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha: ";
            // 
            // txt_nBici
            // 
            this.txt_nBici.Location = new System.Drawing.Point(181, 28);
            this.txt_nBici.Name = "txt_nBici";
            this.txt_nBici.Size = new System.Drawing.Size(100, 20);
            this.txt_nBici.TabIndex = 5;
            this.txt_nBici.TextChanged += new System.EventHandler(this.txt_nBici_TextChanged);
            this.txt_nBici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nBici_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero de Bicicleta: ";
            // 
            // txt_lugar
            // 
            this.txt_lugar.Enabled = false;
            this.txt_lugar.Location = new System.Drawing.Point(96, 54);
            this.txt_lugar.Name = "txt_lugar";
            this.txt_lugar.Size = new System.Drawing.Size(185, 20);
            this.txt_lugar.TabIndex = 1;
            // 
            // txt_tiempo
            // 
            this.txt_tiempo.Enabled = false;
            this.txt_tiempo.Location = new System.Drawing.Point(181, 80);
            this.txt_tiempo.Name = "txt_tiempo";
            this.txt_tiempo.Size = new System.Drawing.Size(100, 20);
            this.txt_tiempo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lugar: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiempo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "REGISTRO DE DATOS PARA CARRERA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ciclista);
            this.groupBox1.Controls.Add(this.lbl_cat);
            this.groupBox1.Location = new System.Drawing.Point(458, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 162);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS CICLISTA";
            // 
            // lbl_ciclista
            // 
            this.lbl_ciclista.AutoSize = true;
            this.lbl_ciclista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ciclista.Location = new System.Drawing.Point(6, 26);
            this.lbl_ciclista.Name = "lbl_ciclista";
            this.lbl_ciclista.Size = new System.Drawing.Size(13, 20);
            this.lbl_ciclista.TabIndex = 6;
            this.lbl_ciclista.Text = ".";
            this.lbl_ciclista.Click += new System.EventHandler(this.lbl_ciclista_Click);
            // 
            // lbl_cat
            // 
            this.lbl_cat.AutoSize = true;
            this.lbl_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cat.Location = new System.Drawing.Point(6, 54);
            this.lbl_cat.Name = "lbl_cat";
            this.lbl_cat.Size = new System.Drawing.Size(13, 20);
            this.lbl_cat.TabIndex = 5;
            this.lbl_cat.Text = ".";
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(660, 449);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 40);
            this.btn_volver.TabIndex = 11;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // dgv_carreras
            // 
            this.dgv_carreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_carreras.Location = new System.Drawing.Point(47, 307);
            this.dgv_carreras.Name = "dgv_carreras";
            this.dgv_carreras.Size = new System.Drawing.Size(546, 150);
            this.dgv_carreras.TabIndex = 12;
            this.dgv_carreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_carreras_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ciclista";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numero";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Lugar";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tiempo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha";
            this.Column5.Name = "Column5";
            // 
            // btn_reg
            // 
            this.btn_reg.Enabled = false;
            this.btn_reg.Location = new System.Drawing.Point(108, 260);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(104, 41);
            this.btn_reg.TabIndex = 13;
            this.btn_reg.Text = "REGISTRAR CARRERA";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // frm_carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(747, 501);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.dgv_carreras);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_datos);
            this.Controls.Add(this.label2);
            this.Name = "frm_carreras";
            this.Text = "REGISTRO CARRERAS";
            this.Load += new System.EventHandler(this.frm_carreras_Load);
            this.grp_datos.ResumeLayout(false);
            this.grp_datos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_datos;
        private System.Windows.Forms.TextBox txt_lugar;
        private System.Windows.Forms.TextBox txt_tiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nBici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_ciclista;
        private System.Windows.Forms.Label lbl_cat;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.DataGridView dgv_carreras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_reg;
    }
}