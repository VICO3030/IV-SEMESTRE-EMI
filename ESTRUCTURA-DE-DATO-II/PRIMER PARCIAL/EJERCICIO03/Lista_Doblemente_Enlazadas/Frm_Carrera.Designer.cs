namespace Lista_Doblemente_Enlazadas
{
    partial class Frm_Carrera
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nBici = new System.Windows.Forms.TextBox();
            this.txt_lugar = new System.Windows.Forms.TextBox();
            this.txt_tiempo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_registrar_carr = new System.Windows.Forms.Button();
            this.Btn_volver = new System.Windows.Forms.Button();
            this.Grp_ciclista = new System.Windows.Forms.GroupBox();
            this.lbl_cat_mostrar = new System.Windows.Forms.Label();
            this.lbl_nombre_Mostrar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ciclista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grp_ciclista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NRO DE BICICLETA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(885, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIEMPO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIEMPO  : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "LUGAR : ";
            // 
            // txt_nBici
            // 
            this.txt_nBici.Location = new System.Drawing.Point(193, 115);
            this.txt_nBici.Name = "txt_nBici";
            this.txt_nBici.Size = new System.Drawing.Size(100, 20);
            this.txt_nBici.TabIndex = 4;
            this.txt_nBici.TextChanged += new System.EventHandler(this.txt_nroBiciCarre_TextChanged);
            this.txt_nBici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nBici_KeyPress);
            // 
            // txt_lugar
            // 
            this.txt_lugar.Enabled = false;
            this.txt_lugar.Location = new System.Drawing.Point(193, 144);
            this.txt_lugar.Name = "txt_lugar";
            this.txt_lugar.ShortcutsEnabled = false;
            this.txt_lugar.Size = new System.Drawing.Size(100, 20);
            this.txt_lugar.TabIndex = 5;
            // 
            // txt_tiempo
            // 
            this.txt_tiempo.Enabled = false;
            this.txt_tiempo.Location = new System.Drawing.Point(193, 178);
            this.txt_tiempo.Name = "txt_tiempo";
            this.txt_tiempo.ShortcutsEnabled = false;
            this.txt_tiempo.Size = new System.Drawing.Size(100, 20);
            this.txt_tiempo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "CARRERA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Btn_registrar_carr
            // 
            this.Btn_registrar_carr.Location = new System.Drawing.Point(193, 267);
            this.Btn_registrar_carr.Name = "Btn_registrar_carr";
            this.Btn_registrar_carr.Size = new System.Drawing.Size(85, 32);
            this.Btn_registrar_carr.TabIndex = 8;
            this.Btn_registrar_carr.Text = "REGISTRAR";
            this.Btn_registrar_carr.UseVisualStyleBackColor = true;
            this.Btn_registrar_carr.Click += new System.EventHandler(this.Btn_registrar_carr_Click);
            // 
            // Btn_volver
            // 
            this.Btn_volver.Location = new System.Drawing.Point(12, 349);
            this.Btn_volver.Name = "Btn_volver";
            this.Btn_volver.Size = new System.Drawing.Size(85, 32);
            this.Btn_volver.TabIndex = 9;
            this.Btn_volver.Text = "VOLVER";
            this.Btn_volver.UseVisualStyleBackColor = true;
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
            // 
            // Grp_ciclista
            // 
            this.Grp_ciclista.Controls.Add(this.lbl_cat_mostrar);
            this.Grp_ciclista.Controls.Add(this.lbl_nombre_Mostrar);
            this.Grp_ciclista.Location = new System.Drawing.Point(398, 73);
            this.Grp_ciclista.Name = "Grp_ciclista";
            this.Grp_ciclista.Size = new System.Drawing.Size(234, 226);
            this.Grp_ciclista.TabIndex = 10;
            this.Grp_ciclista.TabStop = false;
            this.Grp_ciclista.Text = "DATOS CICLISTA";
            // 
            // lbl_cat_mostrar
            // 
            this.lbl_cat_mostrar.AutoSize = true;
            this.lbl_cat_mostrar.Location = new System.Drawing.Point(6, 58);
            this.lbl_cat_mostrar.Name = "lbl_cat_mostrar";
            this.lbl_cat_mostrar.Size = new System.Drawing.Size(10, 13);
            this.lbl_cat_mostrar.TabIndex = 1;
            this.lbl_cat_mostrar.Text = ".";
            this.lbl_cat_mostrar.Click += new System.EventHandler(this.lbl_cat_mostrar_Click);
            // 
            // lbl_nombre_Mostrar
            // 
            this.lbl_nombre_Mostrar.AutoSize = true;
            this.lbl_nombre_Mostrar.Location = new System.Drawing.Point(6, 29);
            this.lbl_nombre_Mostrar.Name = "lbl_nombre_Mostrar";
            this.lbl_nombre_Mostrar.Size = new System.Drawing.Size(10, 13);
            this.lbl_nombre_Mostrar.TabIndex = 0;
            this.lbl_nombre_Mostrar.Text = ".";
            this.lbl_nombre_Mostrar.Click += new System.EventHandler(this.lbl_nombre_Mostrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "FECHA : ";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(193, 213);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ShortcutsEnabled = false;
            this.txt_fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ciclista,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(150, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // Ciclista
            // 
            this.Ciclista.HeaderText = "Ciclista";
            this.Ciclista.Name = "Ciclista";
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
            // Frm_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Grp_ciclista);
            this.Controls.Add(this.Btn_volver);
            this.Controls.Add(this.Btn_registrar_carr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tiempo);
            this.Controls.Add(this.txt_lugar);
            this.Controls.Add(this.txt_nBici);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Carrera";
            this.Text = "Frm_Carrera";
            this.Load += new System.EventHandler(this.Frm_Carrera_Load);
            this.Grp_ciclista.ResumeLayout(false);
            this.Grp_ciclista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nBici;
        private System.Windows.Forms.TextBox txt_lugar;
        private System.Windows.Forms.TextBox txt_tiempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_registrar_carr;
        private System.Windows.Forms.Button Btn_volver;
        private System.Windows.Forms.GroupBox Grp_ciclista;
        private System.Windows.Forms.Label lbl_cat_mostrar;
        private System.Windows.Forms.Label lbl_nombre_Mostrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}