namespace Arbol_Binario
{
    partial class Form1
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
            this.LBL_MSOTRAR = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Alturalbl = new System.Windows.Forms.Label();
            this.nivellbl = new System.Windows.Forms.Label();
            this.lst_reco = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_MSOTRAR
            // 
            this.LBL_MSOTRAR.AutoSize = true;
            this.LBL_MSOTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MSOTRAR.Location = new System.Drawing.Point(12, 402);
            this.LBL_MSOTRAR.Name = "LBL_MSOTRAR";
            this.LBL_MSOTRAR.Size = new System.Drawing.Size(297, 39);
            this.LBL_MSOTRAR.TabIndex = 1;
            this.LBL_MSOTRAR.Text = "ARBOL BINARIO";
            this.LBL_MSOTRAR.Visible = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(6, 31);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(87, 30);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(100, 37);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(69, 20);
            this.txt_buscar.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nivellbl);
            this.groupBox1.Controls.Add(this.Alturalbl);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_buscar);
            this.groupBox1.Location = new System.Drawing.Point(351, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 139);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // Alturalbl
            // 
            this.Alturalbl.AutoSize = true;
            this.Alturalbl.Location = new System.Drawing.Point(9, 76);
            this.Alturalbl.Name = "Alturalbl";
            this.Alturalbl.Size = new System.Drawing.Size(10, 13);
            this.Alturalbl.TabIndex = 10;
            this.Alturalbl.Text = ".";
            // 
            // nivellbl
            // 
            this.nivellbl.AutoSize = true;
            this.nivellbl.Location = new System.Drawing.Point(9, 118);
            this.nivellbl.Name = "nivellbl";
            this.nivellbl.Size = new System.Drawing.Size(10, 13);
            this.nivellbl.TabIndex = 11;
            this.nivellbl.Text = ".";
            // 
            // lst_reco
            // 
            this.lst_reco.FormattingEnabled = true;
            this.lst_reco.Location = new System.Drawing.Point(608, 359);
            this.lst_reco.Name = "lst_reco";
            this.lst_reco.Size = new System.Drawing.Size(120, 95);
            this.lst_reco.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 488);
            this.Controls.Add(this.lst_reco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_MSOTRAR);
            this.Name = "Form1";
            this.Text = "GraficaArbol";
            this.Load += new System.EventHandler(this.GraficaArbol_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_MSOTRAR;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nivellbl;
        private System.Windows.Forms.Label Alturalbl;
        private System.Windows.Forms.ListBox lst_reco;
    }
}