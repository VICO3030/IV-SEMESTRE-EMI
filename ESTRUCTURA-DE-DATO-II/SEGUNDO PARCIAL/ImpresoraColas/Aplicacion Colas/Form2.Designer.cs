
namespace Aplicacion_Colas
{
    partial class Form2
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
            this.DGV_2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Detener = new System.Windows.Forms.Button();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.Tiempo2 = new System.Windows.Forms.Timer(this.components);
            this.DGV_1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Reanudar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_2
            // 
            this.DGV_2.BackgroundColor = System.Drawing.Color.White;
            this.DGV_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column7});
            this.DGV_2.Location = new System.Drawing.Point(499, 56);
            this.DGV_2.Name = "DGV_2";
            this.DGV_2.Size = new System.Drawing.Size(477, 301);
            this.DGV_2.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Hojas";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Calidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Colores";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tiempo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Estado";
            this.Column7.Name = "Column7";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Peru;
            this.progressBar1.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar1.Location = new System.Drawing.Point(40, 374);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(784, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 26;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(495, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Terminados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cola Impresion";
            // 
            // Btn_Detener
            // 
            this.Btn_Detener.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Detener.ForeColor = System.Drawing.Color.Black;
            this.Btn_Detener.Location = new System.Drawing.Point(360, 403);
            this.Btn_Detener.Name = "Btn_Detener";
            this.Btn_Detener.Size = new System.Drawing.Size(130, 33);
            this.Btn_Detener.TabIndex = 28;
            this.Btn_Detener.Text = "Detener";
            this.Btn_Detener.UseVisualStyleBackColor = true;
            this.Btn_Detener.Click += new System.EventHandler(this.Btn_Detener_Click);
            // 
            // Tiempo
            // 
            this.Tiempo.Interval = 10;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // Tiempo2
            // 
            this.Tiempo2.Tick += new System.EventHandler(this.Tiempo2_Tick);
            // 
            // DGV_1
            // 
            this.DGV_1.AllowUserToDeleteRows = false;
            this.DGV_1.BackgroundColor = System.Drawing.Color.White;
            this.DGV_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DGV_1.Location = new System.Drawing.Point(12, 56);
            this.DGV_1.Name = "DGV_1";
            this.DGV_1.Size = new System.Drawing.Size(478, 301);
            this.DGV_1.TabIndex = 29;
            this.DGV_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hojas";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Calidad";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Colores";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tiempo";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Estado";
            this.Column6.Name = "Column6";
            // 
            // Btn_Reanudar
            // 
            this.Btn_Reanudar.Enabled = false;
            this.Btn_Reanudar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reanudar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Reanudar.Location = new System.Drawing.Point(524, 403);
            this.Btn_Reanudar.Name = "Btn_Reanudar";
            this.Btn_Reanudar.Size = new System.Drawing.Size(130, 33);
            this.Btn_Reanudar.TabIndex = 36;
            this.Btn_Reanudar.Text = "Reanudar";
            this.Btn_Reanudar.UseVisualStyleBackColor = true;
            this.Btn_Reanudar.Click += new System.EventHandler(this.Btn_Reanudar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Enabled = false;
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.Color.Black;
            this.Btn_Salir.Location = new System.Drawing.Point(193, 403);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(130, 33);
            this.Btn_Salir.TabIndex = 35;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(988, 457);
            this.Controls.Add(this.Btn_Reanudar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.DGV_1);
            this.Controls.Add(this.Btn_Detener);
            this.Controls.Add(this.DGV_2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Detener;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Timer Tiempo2;
        private System.Windows.Forms.DataGridView DGV_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button Btn_Reanudar;
        private System.Windows.Forms.Button Btn_Salir;
    }
}