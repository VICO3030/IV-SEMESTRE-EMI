namespace Listas_Doblemente_enlazadas
{
    partial class FrmBuscatyEliminar
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
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.grpbLista = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.lblxd = new System.Windows.Forms.Label();
            this.lbld2 = new System.Windows.Forms.Label();
            this.grpbLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(3, 12);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 0;
            // 
            // grpbLista
            // 
            this.grpbLista.Controls.Add(this.lbld2);
            this.grpbLista.Controls.Add(this.lblxd);
            this.grpbLista.Location = new System.Drawing.Point(3, 80);
            this.grpbLista.Name = "grpbLista";
            this.grpbLista.Size = new System.Drawing.Size(200, 100);
            this.grpbLista.TabIndex = 1;
            this.grpbLista.TabStop = false;
            this.grpbLista.Text = "groupBox1";
            this.grpbLista.Visible = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(159, 8);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(254, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "volver";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblxd
            // 
            this.lblxd.AutoSize = true;
            this.lblxd.Location = new System.Drawing.Point(32, 20);
            this.lblxd.Name = "lblxd";
            this.lblxd.Size = new System.Drawing.Size(35, 13);
            this.lblxd.TabIndex = 0;
            this.lblxd.Text = "label1";
            // 
            // lbld2
            // 
            this.lbld2.AutoSize = true;
            this.lbld2.Location = new System.Drawing.Point(32, 51);
            this.lbld2.Name = "lbld2";
            this.lbld2.Size = new System.Drawing.Size(35, 13);
            this.lbld2.TabIndex = 1;
            this.lbld2.Text = "label2";
            // 
            // FrmBuscatyEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 223);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.grpbLista);
            this.Controls.Add(this.txtbuscar);
            this.Name = "FrmBuscatyEliminar";
            this.Text = "FrmBuscatyEliminar";
            this.grpbLista.ResumeLayout(false);
            this.grpbLista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.GroupBox grpbLista;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label lbld2;
        private System.Windows.Forms.Label lblxd;
    }
}