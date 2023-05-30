
namespace Arbol
{
    partial class RECORRIDO
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
            this.Btn_Posorden = new System.Windows.Forms.Button();
            this.Btn_Inorden = new System.Windows.Forms.Button();
            this.Btn_Preorden = new System.Windows.Forms.Button();
            this.Lst_Postorden = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lst_Inorden = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lst_Preorden = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graficaDelArbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Posorden
            // 
            this.Btn_Posorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Posorden.Location = new System.Drawing.Point(501, 318);
            this.Btn_Posorden.Name = "Btn_Posorden";
            this.Btn_Posorden.Size = new System.Drawing.Size(102, 30);
            this.Btn_Posorden.TabIndex = 20;
            this.Btn_Posorden.Text = "Postorden";
            this.Btn_Posorden.UseVisualStyleBackColor = true;
            this.Btn_Posorden.Click += new System.EventHandler(this.Btn_Posorden_Click_1);
            // 
            // Btn_Inorden
            // 
            this.Btn_Inorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inorden.Location = new System.Drawing.Point(292, 318);
            this.Btn_Inorden.Name = "Btn_Inorden";
            this.Btn_Inorden.Size = new System.Drawing.Size(92, 30);
            this.Btn_Inorden.TabIndex = 19;
            this.Btn_Inorden.Text = "Inorden";
            this.Btn_Inorden.UseVisualStyleBackColor = true;
            this.Btn_Inorden.Click += new System.EventHandler(this.Btn_Inorden_Click);
            // 
            // Btn_Preorden
            // 
            this.Btn_Preorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Preorden.Location = new System.Drawing.Point(98, 318);
            this.Btn_Preorden.Name = "Btn_Preorden";
            this.Btn_Preorden.Size = new System.Drawing.Size(92, 30);
            this.Btn_Preorden.TabIndex = 18;
            this.Btn_Preorden.Text = "Preorden";
            this.Btn_Preorden.UseVisualStyleBackColor = true;
            this.Btn_Preorden.Click += new System.EventHandler(this.Btn_Preorden_Click_1);
            // 
            // Lst_Postorden
            // 
            this.Lst_Postorden.FormattingEnabled = true;
            this.Lst_Postorden.Location = new System.Drawing.Point(483, 127);
            this.Lst_Postorden.Name = "Lst_Postorden";
            this.Lst_Postorden.Size = new System.Drawing.Size(120, 160);
            this.Lst_Postorden.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(491, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Postorden";
            // 
            // Lst_Inorden
            // 
            this.Lst_Inorden.FormattingEnabled = true;
            this.Lst_Inorden.Location = new System.Drawing.Point(280, 127);
            this.Lst_Inorden.Name = "Lst_Inorden";
            this.Lst_Inorden.Size = new System.Drawing.Size(120, 160);
            this.Lst_Inorden.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Inorden";
            // 
            // Lst_Preorden
            // 
            this.Lst_Preorden.FormattingEnabled = true;
            this.Lst_Preorden.Location = new System.Drawing.Point(90, 127);
            this.Lst_Preorden.Name = "Lst_Preorden";
            this.Lst_Preorden.Size = new System.Drawing.Size(120, 160);
            this.Lst_Preorden.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Preorden";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficaDelArbolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graficaDelArbolToolStripMenuItem
            // 
            this.graficaDelArbolToolStripMenuItem.Name = "graficaDelArbolToolStripMenuItem";
            this.graficaDelArbolToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.graficaDelArbolToolStripMenuItem.Text = "Grafica del arbol";
            this.graficaDelArbolToolStripMenuItem.Click += new System.EventHandler(this.graficaDelArbolToolStripMenuItem_Click);
            // 
            // RECORRIDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(700, 427);
            this.Controls.Add(this.Btn_Posorden);
            this.Controls.Add(this.Btn_Inorden);
            this.Controls.Add(this.Btn_Preorden);
            this.Controls.Add(this.Lst_Postorden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lst_Inorden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lst_Preorden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "RECORRIDO";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RECORRIDO_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Posorden;
        private System.Windows.Forms.Button Btn_Inorden;
        private System.Windows.Forms.Button Btn_Preorden;
        private System.Windows.Forms.ListBox Lst_Postorden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Lst_Inorden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Lst_Preorden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graficaDelArbolToolStripMenuItem;
    }
}