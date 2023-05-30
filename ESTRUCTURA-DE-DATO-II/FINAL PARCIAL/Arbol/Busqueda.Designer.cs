
namespace Arbol
{
    partial class Busqueda
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
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_num = new System.Windows.Forms.TextBox();
            this.Lbl_Num = new System.Windows.Forms.Label();
            this.Lst_Niveles = new System.Windows.Forms.ListBox();
            this.Lbl_niveles = new System.Windows.Forms.Label();
            this.lbl_nivelmax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.Fuchsia;
            this.Btn_Buscar.Location = new System.Drawing.Point(359, 20);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(81, 31);
            this.Btn_Buscar.TabIndex = 5;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_num
            // 
            this.Txt_num.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_num.Location = new System.Drawing.Point(255, 20);
            this.Txt_num.Name = "Txt_num";
            this.Txt_num.Size = new System.Drawing.Size(74, 29);
            this.Txt_num.TabIndex = 4;
            // 
            // Lbl_Num
            // 
            this.Lbl_Num.AutoSize = true;
            this.Lbl_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Num.ForeColor = System.Drawing.Color.White;
            this.Lbl_Num.Location = new System.Drawing.Point(25, 20);
            this.Lbl_Num.Name = "Lbl_Num";
            this.Lbl_Num.Size = new System.Drawing.Size(250, 24);
            this.Lbl_Num.TabIndex = 3;
            this.Lbl_Num.Text = "Ingrese numero a buscar:";
            // 
            // Lst_Niveles
            // 
            this.Lst_Niveles.BackColor = System.Drawing.Color.Violet;
            this.Lst_Niveles.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lst_Niveles.ForeColor = System.Drawing.Color.White;
            this.Lst_Niveles.FormattingEnabled = true;
            this.Lst_Niveles.ItemHeight = 21;
            this.Lst_Niveles.Location = new System.Drawing.Point(163, 76);
            this.Lst_Niveles.Name = "Lst_Niveles";
            this.Lst_Niveles.Size = new System.Drawing.Size(130, 193);
            this.Lst_Niveles.TabIndex = 6;
            this.Lst_Niveles.SelectedIndexChanged += new System.EventHandler(this.Lst_Niveles_SelectedIndexChanged);
            // 
            // Lbl_niveles
            // 
            this.Lbl_niveles.AutoSize = true;
            this.Lbl_niveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_niveles.ForeColor = System.Drawing.Color.White;
            this.Lbl_niveles.Location = new System.Drawing.Point(159, 295);
            this.Lbl_niveles.Name = "Lbl_niveles";
            this.Lbl_niveles.Size = new System.Drawing.Size(14, 20);
            this.Lbl_niveles.TabIndex = 7;
            this.Lbl_niveles.Text = ".";
            // 
            // lbl_nivelmax
            // 
            this.lbl_nivelmax.AutoSize = true;
            this.lbl_nivelmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivelmax.ForeColor = System.Drawing.Color.White;
            this.lbl_nivelmax.Location = new System.Drawing.Point(159, 332);
            this.lbl_nivelmax.Name = "lbl_nivelmax";
            this.lbl_nivelmax.Size = new System.Drawing.Size(14, 20);
            this.lbl_nivelmax.TabIndex = 8;
            this.lbl_nivelmax.Text = ".";
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(469, 410);
            this.Controls.Add(this.lbl_nivelmax);
            this.Controls.Add(this.Lbl_niveles);
            this.Controls.Add(this.Lst_Niveles);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_num);
            this.Controls.Add(this.Lbl_Num);
            this.Name = "Busqueda";
            this.Text = "3";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_num;
        private System.Windows.Forms.Label Lbl_Num;
        private System.Windows.Forms.ListBox Lst_Niveles;
        private System.Windows.Forms.Label Lbl_niveles;
        private System.Windows.Forms.Label lbl_nivelmax;
    }
}