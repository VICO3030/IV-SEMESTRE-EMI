namespace Lista_Doblemente_Enlazadas
{
    partial class Frm_principal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(106, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU CICLISTA";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "MOSTRAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "REGISTRAR CICLISTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(414, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MENU DE CARRERA";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(37, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "MOSTRAR CARRERAS";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "REGISTRAR CARRERA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(672, 394);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 51);
            this.button6.TabIndex = 5;
            this.button6.Text = "SALIR ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "CICLISMO COMPETICION";
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(787, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_principal";
            this.Text = "Frm_principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}