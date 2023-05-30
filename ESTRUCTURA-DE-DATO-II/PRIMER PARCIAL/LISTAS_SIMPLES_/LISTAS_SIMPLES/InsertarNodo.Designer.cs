namespace LISTAS_SIMPLES
{
    partial class Frm_InsertarNodo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_insertarNOM = new System.Windows.Forms.TextBox();
            this.txt_InsertarEDAD = new System.Windows.Forms.TextBox();
            this.Btn_Cabeza = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSERTAR DATO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE NOMBRE : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESE EDAD : ";
            // 
            // TXT_insertarNOM
            // 
            this.TXT_insertarNOM.Location = new System.Drawing.Point(224, 95);
            this.TXT_insertarNOM.Name = "TXT_insertarNOM";
            this.TXT_insertarNOM.Size = new System.Drawing.Size(214, 20);
            this.TXT_insertarNOM.TabIndex = 3;
            // 
            // txt_InsertarEDAD
            // 
            this.txt_InsertarEDAD.Location = new System.Drawing.Point(224, 146);
            this.txt_InsertarEDAD.Name = "txt_InsertarEDAD";
            this.txt_InsertarEDAD.Size = new System.Drawing.Size(62, 20);
            this.txt_InsertarEDAD.TabIndex = 4;
            // 
            // Btn_Cabeza
            // 
            this.Btn_Cabeza.Location = new System.Drawing.Point(98, 276);
            this.Btn_Cabeza.Name = "Btn_Cabeza";
            this.Btn_Cabeza.Size = new System.Drawing.Size(97, 43);
            this.Btn_Cabeza.TabIndex = 5;
            this.Btn_Cabeza.Text = "INSERTAR CABEZA";
            this.Btn_Cabeza.UseVisualStyleBackColor = true;
            this.Btn_Cabeza.Click += new System.EventHandler(this.Btn_Cabeza_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "INSERTAR POSICION";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(401, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "INSERTAR ULTIMO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "ELIJA COMO DESEA INSERTAR";
            // 
            // Btn_volver
            // 
            this.Btn_volver.Location = new System.Drawing.Point(693, 376);
            this.Btn_volver.Name = "Btn_volver";
            this.Btn_volver.Size = new System.Drawing.Size(97, 43);
            this.Btn_volver.TabIndex = 9;
            this.Btn_volver.Text = "VOLVER";
            this.Btn_volver.UseVisualStyleBackColor = true;
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
            // 
            // Frm_InsertarNodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(813, 440);
            this.Controls.Add(this.Btn_volver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Cabeza);
            this.Controls.Add(this.txt_InsertarEDAD);
            this.Controls.Add(this.TXT_insertarNOM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_InsertarNodo";
            this.Text = "INSERTAR";
            this.Load += new System.EventHandler(this.Btn_prim_Cabeza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_insertarNOM;
        private System.Windows.Forms.TextBox txt_InsertarEDAD;
        private System.Windows.Forms.Button Btn_Cabeza;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_volver;
    }
}