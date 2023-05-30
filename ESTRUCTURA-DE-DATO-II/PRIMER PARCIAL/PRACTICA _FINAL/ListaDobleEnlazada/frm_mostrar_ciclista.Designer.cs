
namespace ListaDobleEnlazada
{
    partial class frm_mostrar_ciclista
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
            this.dgv_ciclista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_final = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ciclista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ciclista
            // 
            this.dgv_ciclista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ciclista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_ciclista.Location = new System.Drawing.Point(71, 12);
            this.dgv_ciclista.Name = "dgv_ciclista";
            this.dgv_ciclista.Size = new System.Drawing.Size(346, 197);
            this.dgv_ciclista.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
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
            // btn_inicio
            // 
            this.btn_inicio.Location = new System.Drawing.Point(61, 234);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(114, 34);
            this.btn_inicio.TabIndex = 1;
            this.btn_inicio.Text = "MOSTRAR INICIO";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_final
            // 
            this.btn_final.Location = new System.Drawing.Point(227, 234);
            this.btn_final.Name = "btn_final";
            this.btn_final.Size = new System.Drawing.Size(108, 34);
            this.btn_final.TabIndex = 2;
            this.btn_final.Text = "MOSTRAR FINAL";
            this.btn_final.UseVisualStyleBackColor = true;
            this.btn_final.Click += new System.EventHandler(this.btn_final_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(435, 234);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 40);
            this.btn_volver.TabIndex = 12;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // frm_mostrar_ciclista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 286);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_final);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.dgv_ciclista);
            this.Name = "frm_mostrar_ciclista";
            this.Text = "frm_mostrar_ciclista";
            this.Load += new System.EventHandler(this.frm_mostrar_ciclista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ciclista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ciclista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_final;
        private System.Windows.Forms.Button btn_volver;
    }
}