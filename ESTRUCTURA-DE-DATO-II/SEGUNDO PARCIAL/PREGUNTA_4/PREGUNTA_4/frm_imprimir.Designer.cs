namespace PREGUNTA_4
{
    partial class frm_imprimir
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
            this.pgb_Impresion = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tmr_Doc = new System.Windows.Forms.Timer(this.components);
            this.tmr_Cola = new System.Windows.Forms.Timer(this.components);
            this.lbl_Segundos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_calidad = new System.Windows.Forms.Label();
            this.lbl_Hojas = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.dgv_IMPRESOS = new System.Windows.Forms.DataGridView();
            this.ARCHIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEMPO_IMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEMPO_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_Impresion = new System.Windows.Forms.GroupBox();
            this.lbl_Finalizado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IMPRESOS)).BeginInit();
            this.gpb_Impresion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgb_Impresion
            // 
            this.pgb_Impresion.Location = new System.Drawing.Point(223, 79);
            this.pgb_Impresion.Name = "pgb_Impresion";
            this.pgb_Impresion.Size = new System.Drawing.Size(596, 61);
            this.pgb_Impresion.TabIndex = 0;
            this.pgb_Impresion.Click += new System.EventHandler(this.pgb_Impresion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "IMPRIMIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "IMPRESION";
            // 
            // tmr_Doc
            // 
            this.tmr_Doc.Tick += new System.EventHandler(this.tmr_Doc_Tick);
            // 
            // tmr_Cola
            // 
            this.tmr_Cola.Tick += new System.EventHandler(this.tmr_Cola_Tick);
            // 
            // lbl_Segundos
            // 
            this.lbl_Segundos.AutoSize = true;
            this.lbl_Segundos.Location = new System.Drawing.Point(220, 159);
            this.lbl_Segundos.Name = "lbl_Segundos";
            this.lbl_Segundos.Size = new System.Drawing.Size(62, 13);
            this.lbl_Segundos.TabIndex = 11;
            this.lbl_Segundos.Text = "0 segundos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "TIEMPO DE IMPRESION DEL DOCUMENTO:";
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(795, 372);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(118, 51);
            this.btn_Volver.TabIndex = 13;
            this.btn_Volver.Text = "VOLVER";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Calidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hojas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nombre:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_calidad
            // 
            this.lbl_calidad.AutoSize = true;
            this.lbl_calidad.Location = new System.Drawing.Point(113, 135);
            this.lbl_calidad.Name = "lbl_calidad";
            this.lbl_calidad.Size = new System.Drawing.Size(10, 13);
            this.lbl_calidad.TabIndex = 17;
            this.lbl_calidad.Text = ".";
            // 
            // lbl_Hojas
            // 
            this.lbl_Hojas.AutoSize = true;
            this.lbl_Hojas.Location = new System.Drawing.Point(113, 94);
            this.lbl_Hojas.Name = "lbl_Hojas";
            this.lbl_Hojas.Size = new System.Drawing.Size(10, 13);
            this.lbl_Hojas.TabIndex = 18;
            this.lbl_Hojas.Text = ".";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(113, 53);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(10, 13);
            this.lbl_Nombre.TabIndex = 19;
            this.lbl_Nombre.Text = ".";
            // 
            // dgv_IMPRESOS
            // 
            this.dgv_IMPRESOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IMPRESOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ARCHIVO,
            this.TIEMPO_IMP,
            this.TIEMPO_COL});
            this.dgv_IMPRESOS.Location = new System.Drawing.Point(450, 181);
            this.dgv_IMPRESOS.Name = "dgv_IMPRESOS";
            this.dgv_IMPRESOS.Size = new System.Drawing.Size(344, 128);
            this.dgv_IMPRESOS.TabIndex = 21;
            this.dgv_IMPRESOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ARCHIVO
            // 
            this.ARCHIVO.HeaderText = "ARCHIVO IMPRESO";
            this.ARCHIVO.Name = "ARCHIVO";
            // 
            // TIEMPO_IMP
            // 
            this.TIEMPO_IMP.HeaderText = "TIEMPO DE IMPRESIÓN";
            this.TIEMPO_IMP.Name = "TIEMPO_IMP";
            // 
            // TIEMPO_COL
            // 
            this.TIEMPO_COL.HeaderText = "TIEMPO EN LA COLA";
            this.TIEMPO_COL.Name = "TIEMPO_COL";
            // 
            // gpb_Impresion
            // 
            this.gpb_Impresion.Controls.Add(this.lbl_Nombre);
            this.gpb_Impresion.Controls.Add(this.lbl_Hojas);
            this.gpb_Impresion.Controls.Add(this.lbl_calidad);
            this.gpb_Impresion.Controls.Add(this.label5);
            this.gpb_Impresion.Controls.Add(this.label3);
            this.gpb_Impresion.Controls.Add(this.label1);
            this.gpb_Impresion.Location = new System.Drawing.Point(94, 189);
            this.gpb_Impresion.Name = "gpb_Impresion";
            this.gpb_Impresion.Size = new System.Drawing.Size(237, 183);
            this.gpb_Impresion.TabIndex = 22;
            this.gpb_Impresion.TabStop = false;
            this.gpb_Impresion.Text = "ARCHIVO IMPRIMIENDOSE:";
            this.gpb_Impresion.Visible = false;
            // 
            // lbl_Finalizado
            // 
            this.lbl_Finalizado.AutoSize = true;
            this.lbl_Finalizado.Location = new System.Drawing.Point(749, 159);
            this.lbl_Finalizado.Name = "lbl_Finalizado";
            this.lbl_Finalizado.Size = new System.Drawing.Size(70, 13);
            this.lbl_Finalizado.TabIndex = 23;
            this.lbl_Finalizado.Text = "FINALIZADO";
            this.lbl_Finalizado.Visible = false;
            // 
            // frm_imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 433);
            this.Controls.Add(this.lbl_Finalizado);
            this.Controls.Add(this.gpb_Impresion);
            this.Controls.Add(this.dgv_IMPRESOS);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Segundos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pgb_Impresion);
            this.Name = "frm_imprimir";
            this.Text = "}";
            this.Load += new System.EventHandler(this.frm_imprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IMPRESOS)).EndInit();
            this.gpb_Impresion.ResumeLayout(false);
            this.gpb_Impresion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb_Impresion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmr_Doc;
        private System.Windows.Forms.Timer tmr_Cola;
        private System.Windows.Forms.Label lbl_Segundos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_calidad;
        private System.Windows.Forms.Label lbl_Hojas;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.DataGridView dgv_IMPRESOS;
        private System.Windows.Forms.GroupBox gpb_Impresion;
        private System.Windows.Forms.Label lbl_Finalizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARCHIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEMPO_IMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEMPO_COL;
    }
}