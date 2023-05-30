
namespace Arbol
{
    partial class Hojas
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
            this.Lst_Hojas = new System.Windows.Forms.ListBox();
            this.Lbl_cant_Hojas = new System.Windows.Forms.Label();
            this.Btn_Hojas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baloo 2 Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hojas:";
            // 
            // Lst_Hojas
            // 
            this.Lst_Hojas.FormattingEnabled = true;
            this.Lst_Hojas.ItemHeight = 21;
            this.Lst_Hojas.Location = new System.Drawing.Point(60, 89);
            this.Lst_Hojas.Name = "Lst_Hojas";
            this.Lst_Hojas.Size = new System.Drawing.Size(120, 172);
            this.Lst_Hojas.TabIndex = 1;
            // 
            // Lbl_cant_Hojas
            // 
            this.Lbl_cant_Hojas.AutoSize = true;
            this.Lbl_cant_Hojas.ForeColor = System.Drawing.Color.White;
            this.Lbl_cant_Hojas.Location = new System.Drawing.Point(118, 45);
            this.Lbl_cant_Hojas.Name = "Lbl_cant_Hojas";
            this.Lbl_cant_Hojas.Size = new System.Drawing.Size(0, 21);
            this.Lbl_cant_Hojas.TabIndex = 2;
            // 
            // Btn_Hojas
            // 
            this.Btn_Hojas.Font = new System.Drawing.Font("Baloo 2 Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Hojas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Btn_Hojas.Location = new System.Drawing.Point(50, 277);
            this.Btn_Hojas.Name = "Btn_Hojas";
            this.Btn_Hojas.Size = new System.Drawing.Size(143, 37);
            this.Btn_Hojas.TabIndex = 19;
            this.Btn_Hojas.Text = "Mostrar Hojas";
            this.Btn_Hojas.UseVisualStyleBackColor = true;
            this.Btn_Hojas.Click += new System.EventHandler(this.Btn_Hojas_Click);
            // 
            // Hojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(580, 367);
            this.Controls.Add(this.Btn_Hojas);
            this.Controls.Add(this.Lbl_cant_Hojas);
            this.Controls.Add(this.Lst_Hojas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Hojas";
            this.Text = "Hojas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Lst_Hojas;
        private System.Windows.Forms.Label Lbl_cant_Hojas;
        private System.Windows.Forms.Button Btn_Hojas;
    }
}