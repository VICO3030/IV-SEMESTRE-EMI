namespace Listas_Doblemente_enlazadas
{
    partial class FrmCiclistsa
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
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroBici = new System.Windows.Forms.TextBox();
            this.Cmb_Ciclista = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(481, 12);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 0;
            this.Btn_Back.Text = "Volver";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Registrar.Location = new System.Drawing.Point(481, 41);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Registrar.TabIndex = 15;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre del conductor";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nro bici";
            // 
            // txtNroBici
            // 
            this.txtNroBici.Location = new System.Drawing.Point(180, 43);
            this.txtNroBici.Name = "txtNroBici";
            this.txtNroBici.Size = new System.Drawing.Size(100, 20);
            this.txtNroBici.TabIndex = 9;
            this.txtNroBici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroBici_KeyPress);
            // 
            // Cmb_Ciclista
            // 
            this.Cmb_Ciclista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Ciclista.FormattingEnabled = true;
            this.Cmb_Ciclista.Items.AddRange(new object[] {
            "Infantil",
            "Juvenil",
            "Mayores",
            "Seniors",
            "Elite"});
            this.Cmb_Ciclista.Location = new System.Drawing.Point(159, 123);
            this.Cmb_Ciclista.Name = "Cmb_Ciclista";
            this.Cmb_Ciclista.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Ciclista.TabIndex = 16;
            // 
            // FrmCiclistsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 422);
            this.Controls.Add(this.Cmb_Ciclista);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNroBici);
            this.Controls.Add(this.Btn_Back);
            this.DoubleBuffered = true;
            this.Name = "FrmCiclistsa";
            this.Text = "FrmCiclistsa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroBici;
        private System.Windows.Forms.ComboBox Cmb_Ciclista;
    }
}