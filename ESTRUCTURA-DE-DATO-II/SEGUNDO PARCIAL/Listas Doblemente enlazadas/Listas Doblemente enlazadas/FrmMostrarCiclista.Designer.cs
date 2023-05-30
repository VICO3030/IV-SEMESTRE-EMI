namespace Listas_Doblemente_enlazadas
{
    partial class FrmMostrarCiclista
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
            this.DgvCiclisa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_mostrarInicio = new System.Windows.Forms.Button();
            this.Btn_MostrarFinal = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCiclisa)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCiclisa
            // 
            this.DgvCiclisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCiclisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvCiclisa.Location = new System.Drawing.Point(12, 2);
            this.DgvCiclisa.Name = "DgvCiclisa";
            this.DgvCiclisa.Size = new System.Drawing.Size(344, 136);
            this.DgvCiclisa.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numero";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Categoria";
            this.Column3.Name = "Column3";
            // 
            // Btn_mostrarInicio
            // 
            this.Btn_mostrarInicio.Location = new System.Drawing.Point(362, 12);
            this.Btn_mostrarInicio.Name = "Btn_mostrarInicio";
            this.Btn_mostrarInicio.Size = new System.Drawing.Size(92, 23);
            this.Btn_mostrarInicio.TabIndex = 1;
            this.Btn_mostrarInicio.Text = "Mostrar Final";
            this.Btn_mostrarInicio.UseVisualStyleBackColor = true;
            this.Btn_mostrarInicio.Click += new System.EventHandler(this.Btn_mostrarInicio_Click);
            // 
            // Btn_MostrarFinal
            // 
            this.Btn_MostrarFinal.Location = new System.Drawing.Point(362, 41);
            this.Btn_MostrarFinal.Name = "Btn_MostrarFinal";
            this.Btn_MostrarFinal.Size = new System.Drawing.Size(92, 23);
            this.Btn_MostrarFinal.TabIndex = 2;
            this.Btn_MostrarFinal.Text = "Mostrar inicio";
            this.Btn_MostrarFinal.UseVisualStyleBackColor = true;
            this.Btn_MostrarFinal.Click += new System.EventHandler(this.Btn_MostrarFinal_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(708, 2);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(92, 23);
            this.Btn_salir.TabIndex = 3;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // FrmMostrarCiclista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_MostrarFinal);
            this.Controls.Add(this.Btn_mostrarInicio);
            this.Controls.Add(this.DgvCiclisa);
            this.Name = "FrmMostrarCiclista";
            this.Text = "FrmMostrarCiclista";
            this.Load += new System.EventHandler(this.FrmMostrarCiclista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCiclisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCiclisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button Btn_mostrarInicio;
        private System.Windows.Forms.Button Btn_MostrarFinal;
        private System.Windows.Forms.Button Btn_salir;
    }
}