namespace LISTAS_SIMPLES
{
    partial class Frm_Buscar
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
            this.lbl_nom_Buscar = new System.Windows.Forms.Label();
            this.Btn_volver = new System.Windows.Forms.Button();
            this.txtbuscar_nom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GRP_EDAD = new System.Windows.Forms.GroupBox();
            this.Btn_Actualizar_edad = new System.Windows.Forms.Button();
            this.txt_nuevaedad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_edad_actual = new System.Windows.Forms.Label();
            this.GRP_EDAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nom_Buscar
            // 
            this.lbl_nom_Buscar.AutoSize = true;
            this.lbl_nom_Buscar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_Buscar.Location = new System.Drawing.Point(122, 33);
            this.lbl_nom_Buscar.Name = "lbl_nom_Buscar";
            this.lbl_nom_Buscar.Size = new System.Drawing.Size(217, 17);
            this.lbl_nom_Buscar.TabIndex = 0;
            this.lbl_nom_Buscar.Text = "INGRESE EL NOMBRE A BUSCAR :";
            this.lbl_nom_Buscar.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_volver
            // 
            this.Btn_volver.Location = new System.Drawing.Point(704, 432);
            this.Btn_volver.Name = "Btn_volver";
            this.Btn_volver.Size = new System.Drawing.Size(90, 41);
            this.Btn_volver.TabIndex = 1;
            this.Btn_volver.Text = "VOLVER";
            this.Btn_volver.UseVisualStyleBackColor = true;
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
            // 
            // txtbuscar_nom
            // 
            this.txtbuscar_nom.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar_nom.Location = new System.Drawing.Point(375, 25);
            this.txtbuscar_nom.Name = "txtbuscar_nom";
            this.txtbuscar_nom.Size = new System.Drawing.Size(260, 25);
            this.txtbuscar_nom.TabIndex = 2;
            this.txtbuscar_nom.TextChanged += new System.EventHandler(this.txtbuscar_nom_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "MODIFICAR EDAD  ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "BUSCAR EXISTENCIA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GRP_EDAD
            // 
            this.GRP_EDAD.Controls.Add(this.Btn_Actualizar_edad);
            this.GRP_EDAD.Controls.Add(this.txt_nuevaedad);
            this.GRP_EDAD.Controls.Add(this.label1);
            this.GRP_EDAD.Controls.Add(this.lbl_edad_actual);
            this.GRP_EDAD.Location = new System.Drawing.Point(100, 176);
            this.GRP_EDAD.Name = "GRP_EDAD";
            this.GRP_EDAD.Size = new System.Drawing.Size(561, 228);
            this.GRP_EDAD.TabIndex = 6;
            this.GRP_EDAD.TabStop = false;
            this.GRP_EDAD.Text = "EDAD A MODIFICAR";
            this.GRP_EDAD.Visible = false;
            this.GRP_EDAD.Enter += new System.EventHandler(this.GRP_EDAD_Enter);
            // 
            // Btn_Actualizar_edad
            // 
            this.Btn_Actualizar_edad.Location = new System.Drawing.Point(431, 136);
            this.Btn_Actualizar_edad.Name = "Btn_Actualizar_edad";
            this.Btn_Actualizar_edad.Size = new System.Drawing.Size(90, 41);
            this.Btn_Actualizar_edad.TabIndex = 7;
            this.Btn_Actualizar_edad.Text = "ACTUALIZAR EDAD";
            this.Btn_Actualizar_edad.UseVisualStyleBackColor = true;
            this.Btn_Actualizar_edad.Click += new System.EventHandler(this.Btn_Actualizar_edad_Click);
            // 
            // txt_nuevaedad
            // 
            this.txt_nuevaedad.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nuevaedad.Location = new System.Drawing.Point(46, 96);
            this.txt_nuevaedad.Name = "txt_nuevaedad";
            this.txt_nuevaedad.Size = new System.Drawing.Size(89, 25);
            this.txt_nuevaedad.TabIndex = 7;
            this.txt_nuevaedad.TextChanged += new System.EventHandler(this.txt_nuevaedad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "INGRESE LA NUEVA EDAD  :";
            // 
            // lbl_edad_actual
            // 
            this.lbl_edad_actual.AutoSize = true;
            this.lbl_edad_actual.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad_actual.Location = new System.Drawing.Point(22, 27);
            this.lbl_edad_actual.Name = "lbl_edad_actual";
            this.lbl_edad_actual.Size = new System.Drawing.Size(11, 17);
            this.lbl_edad_actual.TabIndex = 7;
            this.lbl_edad_actual.Text = ".";
            this.lbl_edad_actual.Click += new System.EventHandler(this.lbl_edad_actual_Click);
            // 
            // Frm_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(854, 527);
            this.Controls.Add(this.GRP_EDAD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtbuscar_nom);
            this.Controls.Add(this.Btn_volver);
            this.Controls.Add(this.lbl_nom_Buscar);
            this.Name = "Frm_Buscar";
            this.Text = "Frm_Buscar";
            this.GRP_EDAD.ResumeLayout(false);
            this.GRP_EDAD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nom_Buscar;
        private System.Windows.Forms.Button Btn_volver;
        private System.Windows.Forms.TextBox txtbuscar_nom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GRP_EDAD;
        private System.Windows.Forms.TextBox txt_nuevaedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_edad_actual;
        private System.Windows.Forms.Button Btn_Actualizar_edad;
    }
}