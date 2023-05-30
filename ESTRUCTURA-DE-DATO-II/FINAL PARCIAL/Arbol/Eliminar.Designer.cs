
namespace Arbol
{
    partial class Eliminar
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
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Txt_num = new System.Windows.Forms.TextBox();
            this.Lbl_Num = new System.Windows.Forms.Label();
            this.Lst_Antes = new System.Windows.Forms.ListBox();
            this.Lst_Despues = new System.Windows.Forms.ListBox();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Btn_Eliminar.Location = new System.Drawing.Point(327, 29);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(85, 31);
            this.Btn_Eliminar.TabIndex = 8;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Txt_num
            // 
            this.Txt_num.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_num.Location = new System.Drawing.Point(254, 29);
            this.Txt_num.Name = "Txt_num";
            this.Txt_num.Size = new System.Drawing.Size(50, 29);
            this.Txt_num.TabIndex = 7;
            // 
            // Lbl_Num
            // 
            this.Lbl_Num.AutoSize = true;
            this.Lbl_Num.Font = new System.Drawing.Font("Baloo 2 Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Num.ForeColor = System.Drawing.Color.White;
            this.Lbl_Num.Location = new System.Drawing.Point(12, 29);
            this.Lbl_Num.Name = "Lbl_Num";
            this.Lbl_Num.Size = new System.Drawing.Size(236, 30);
            this.Lbl_Num.TabIndex = 6;
            this.Lbl_Num.Text = "Ingrese numero a eliminar:";
            // 
            // Lst_Antes
            // 
            this.Lst_Antes.FormattingEnabled = true;
            this.Lst_Antes.ItemHeight = 21;
            this.Lst_Antes.Location = new System.Drawing.Point(59, 123);
            this.Lst_Antes.Name = "Lst_Antes";
            this.Lst_Antes.Size = new System.Drawing.Size(128, 172);
            this.Lst_Antes.TabIndex = 9;
            // 
            // Lst_Despues
            // 
            this.Lst_Despues.FormattingEnabled = true;
            this.Lst_Despues.ItemHeight = 21;
            this.Lst_Despues.Location = new System.Drawing.Point(254, 123);
            this.Lst_Despues.Name = "Lst_Despues";
            this.Lst_Despues.Size = new System.Drawing.Size(128, 172);
            this.Lst_Despues.TabIndex = 10;
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mostrar.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Btn_Mostrar.Location = new System.Drawing.Point(132, 301);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(148, 31);
            this.Btn_Mostrar.TabIndex = 11;
            this.Btn_Mostrar.Text = "Mostrar";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baloo 2 Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(292, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "SUBE:";
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ClientSize = new System.Drawing.Size(456, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Mostrar);
            this.Controls.Add(this.Lst_Despues);
            this.Controls.Add(this.Lst_Antes);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Txt_num);
            this.Controls.Add(this.Lbl_Num);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.TextBox Txt_num;
        private System.Windows.Forms.Label Lbl_Num;
        private System.Windows.Forms.ListBox Lst_Antes;
        private System.Windows.Forms.ListBox Lst_Despues;
        private System.Windows.Forms.Button Btn_Mostrar;
        private System.Windows.Forms.Label label1;
    }
}