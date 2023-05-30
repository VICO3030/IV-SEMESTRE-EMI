namespace Listas_Doblemente_enlazadas
{
    partial class frmMostrarCarrera
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
            this.btnvolver = new System.Windows.Forms.Button();
            this.Btn_MostrarFinal = new System.Windows.Forms.Button();
            this.Btn_mostrarInicio = new System.Windows.Forms.Button();
            this.DgvCarrera = new System.Windows.Forms.DataGridView();
            this.Bici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(654, 28);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 0;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // Btn_MostrarFinal
            // 
            this.Btn_MostrarFinal.Location = new System.Drawing.Point(486, 57);
            this.Btn_MostrarFinal.Name = "Btn_MostrarFinal";
            this.Btn_MostrarFinal.Size = new System.Drawing.Size(92, 23);
            this.Btn_MostrarFinal.TabIndex = 5;
            this.Btn_MostrarFinal.Text = "Mostrar inicio";
            this.Btn_MostrarFinal.UseVisualStyleBackColor = true;
            this.Btn_MostrarFinal.Click += new System.EventHandler(this.Btn_MostrarFinal_Click);
            // 
            // Btn_mostrarInicio
            // 
            this.Btn_mostrarInicio.Location = new System.Drawing.Point(486, 28);
            this.Btn_mostrarInicio.Name = "Btn_mostrarInicio";
            this.Btn_mostrarInicio.Size = new System.Drawing.Size(92, 23);
            this.Btn_mostrarInicio.TabIndex = 4;
            this.Btn_mostrarInicio.Text = "Mostrar Final";
            this.Btn_mostrarInicio.UseVisualStyleBackColor = true;
            this.Btn_mostrarInicio.Click += new System.EventHandler(this.Btn_mostrarInicio_Click);
            // 
            // DgvCarrera
            // 
            this.DgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bici,
            this.Tiempo,
            this.Column1,
            this.Column2});
            this.DgvCarrera.Location = new System.Drawing.Point(12, 12);
            this.DgvCarrera.Name = "DgvCarrera";
            this.DgvCarrera.Size = new System.Drawing.Size(442, 126);
            this.DgvCarrera.TabIndex = 3;
            // 
            // Bici
            // 
            this.Bici.HeaderText = "bici";
            this.Bici.Name = "Bici";
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Timpo";
            this.Tiempo.Name = "Tiempo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Lugar";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "fecha";
            this.Column2.Name = "Column2";
            // 
            // BtnOrdenar
            // 
            this.BtnOrdenar.Location = new System.Drawing.Point(486, 86);
            this.BtnOrdenar.Name = "BtnOrdenar";
            this.BtnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.BtnOrdenar.TabIndex = 6;
            this.BtnOrdenar.Text = "Ordenar";
            this.BtnOrdenar.UseVisualStyleBackColor = true;
            this.BtnOrdenar.Click += new System.EventHandler(this.BtnOrdenar_Click);
            // 
            // frmMostrarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOrdenar);
            this.Controls.Add(this.Btn_MostrarFinal);
            this.Controls.Add(this.Btn_mostrarInicio);
            this.Controls.Add(this.DgvCarrera);
            this.Controls.Add(this.btnvolver);
            this.Name = "frmMostrarCarrera";
            this.Text = "frmMostrarCarrera";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarrera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button Btn_MostrarFinal;
        private System.Windows.Forms.Button Btn_mostrarInicio;
        private System.Windows.Forms.DataGridView DgvCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button BtnOrdenar;
    }
}