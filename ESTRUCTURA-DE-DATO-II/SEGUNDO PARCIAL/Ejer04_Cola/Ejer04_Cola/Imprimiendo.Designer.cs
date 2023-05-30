namespace Ejer04_Cola
{
    partial class frm_imprimiendo
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
            this.components = new System.ComponentModel.Container();
            this.dgt_imprimirr = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgt_imprimido = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgrBarra = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.Tiempo2 = new System.Windows.Forms.Timer(this.components);
            this.Btn_Detener = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Reanudar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_imprimirr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_imprimido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgt_imprimirr
            // 
            this.dgt_imprimirr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_imprimirr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgt_imprimirr.Location = new System.Drawing.Point(25, 73);
            this.dgt_imprimirr.Name = "dgt_imprimirr";
            this.dgt_imprimirr.Size = new System.Drawing.Size(544, 253);
            this.dgt_imprimirr.TabIndex = 0;
            // 
            // nom
            // 
            this.nom.HeaderText = "NOMBRE";
            this.nom.Name = "nom";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "HOJAS";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Calidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "COLORES";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TIEMPO";
            this.Column4.Name = "Column4";
            // 
            // dgt_imprimido
            // 
            this.dgt_imprimido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_imprimido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgt_imprimido.Location = new System.Drawing.Point(596, 73);
            this.dgt_imprimido.Name = "dgt_imprimido";
            this.dgt_imprimido.Size = new System.Drawing.Size(543, 253);
            this.dgt_imprimido.TabIndex = 1;
            this.dgt_imprimido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "HOJAS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Calidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "COLORES";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "TIEMPO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // pgrBarra
            // 
            this.pgrBarra.Location = new System.Drawing.Point(352, 359);
            this.pgrBarra.Name = "pgrBarra";
            this.pgrBarra.Size = new System.Drawing.Size(484, 42);
            this.pgrBarra.TabIndex = 2;
            this.pgrBarra.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "COLA DE IMPRESION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(753, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "IMPRESOS\r\n";
            // 
            // Tiempo
            // 
            this.Tiempo.Tick += new System.EventHandler(this.tmr_tiempo_Tick);
            // 
            // Btn_Detener
            // 
            this.Btn_Detener.Location = new System.Drawing.Point(45, 359);
            this.Btn_Detener.Name = "Btn_Detener";
            this.Btn_Detener.Size = new System.Drawing.Size(78, 42);
            this.Btn_Detener.TabIndex = 5;
            this.Btn_Detener.Text = "DETENER";
            this.Btn_Detener.UseVisualStyleBackColor = true;
            this.Btn_Detener.Click += new System.EventHandler(this.BTN_IMPRIMIR_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(157, 359);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(78, 42);
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Reanudar
            // 
            this.Btn_Reanudar.Location = new System.Drawing.Point(91, 407);
            this.Btn_Reanudar.Name = "Btn_Reanudar";
            this.Btn_Reanudar.Size = new System.Drawing.Size(78, 42);
            this.Btn_Reanudar.TabIndex = 7;
            this.Btn_Reanudar.Text = "REANUDAR";
            this.Btn_Reanudar.UseVisualStyleBackColor = true;
            this.Btn_Reanudar.Click += new System.EventHandler(this.Btn_Reanudar_Click);
            // 
            // frm_imprimiendo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 460);
            this.Controls.Add(this.Btn_Reanudar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Detener);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgrBarra);
            this.Controls.Add(this.dgt_imprimido);
            this.Controls.Add(this.dgt_imprimirr);
            this.Name = "frm_imprimiendo";
            this.Text = "Imprimiendo";
            this.Load += new System.EventHandler(this.Imprimiendo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgt_imprimirr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_imprimido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgt_imprimirr;
        private System.Windows.Forms.DataGridView dgt_imprimido;
        private System.Windows.Forms.ProgressBar pgrBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Timer Tiempo2;
        private System.Windows.Forms.Button Btn_Detener;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Reanudar;
    }
}