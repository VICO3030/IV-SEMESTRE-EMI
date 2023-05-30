namespace PREGUNTA_4
{
    partial class Cola_Impresion
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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.dgv_Mostrado = new System.Windows.Forms.DataGridView();
            this.NOMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CALCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mostrado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(900, 420);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(159, 46);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "VOLVER";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // dgv_Mostrado
            // 
            this.dgv_Mostrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mostrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMB,
            this.HOJ,
            this.CALCOL});
            this.dgv_Mostrado.Location = new System.Drawing.Point(202, 96);
            this.dgv_Mostrado.Name = "dgv_Mostrado";
            this.dgv_Mostrado.Size = new System.Drawing.Size(349, 219);
            this.dgv_Mostrado.TabIndex = 1;
            // 
            // NOMB
            // 
            this.NOMB.HeaderText = "NOMBRE";
            this.NOMB.Name = "NOMB";
            // 
            // HOJ
            // 
            this.HOJ.HeaderText = "CANTIDAD DE HOJAS";
            this.HOJ.Name = "HOJ";
            // 
            // CALCOL
            // 
            this.CALCOL.HeaderText = "CALIDAD Y COLOR";
            this.CALCOL.Name = "CALCOL";
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(662, 338);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(159, 46);
            this.btn_Mostrar.TabIndex = 2;
            this.btn_Mostrar.Text = "MOSTRAR";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // Cola_Impresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 497);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.dgv_Mostrado);
            this.Controls.Add(this.btn_Volver);
            this.Name = "Cola_Impresion";
            this.Text = "Cola_Impresion";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mostrado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.DataGridView dgv_Mostrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMB;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALCOL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Mostrar;
    }
}