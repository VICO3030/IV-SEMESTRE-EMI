
namespace ListaDobleEnlazada
{
    partial class frm_ciclistas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nBici = new System.Windows.Forms.TextBox();
            this.grp_datos = new System.Windows.Forms.GroupBox();
            this.cmb_cat = new System.Windows.Forms.ComboBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.grp_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(141, 48);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(185, 20);
            this.txt_nom.TabIndex = 1;
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            this.txt_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nom_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "REGISTRAR COMPETIDORES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero de Bicicleta: ";
            // 
            // txt_nBici
            // 
            this.txt_nBici.Location = new System.Drawing.Point(226, 74);
            this.txt_nBici.Name = "txt_nBici";
            this.txt_nBici.Size = new System.Drawing.Size(100, 20);
            this.txt_nBici.TabIndex = 5;
            this.txt_nBici.TextChanged += new System.EventHandler(this.txt_nBici_TextChanged);
            this.txt_nBici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nBici_KeyPress);
            // 
            // grp_datos
            // 
            this.grp_datos.BackColor = System.Drawing.Color.Transparent;
            this.grp_datos.Controls.Add(this.cmb_cat);
            this.grp_datos.Controls.Add(this.txt_nom);
            this.grp_datos.Controls.Add(this.label1);
            this.grp_datos.Controls.Add(this.txt_nBici);
            this.grp_datos.Controls.Add(this.label3);
            this.grp_datos.Controls.Add(this.label4);
            this.grp_datos.ForeColor = System.Drawing.Color.White;
            this.grp_datos.Location = new System.Drawing.Point(33, 91);
            this.grp_datos.Name = "grp_datos";
            this.grp_datos.Size = new System.Drawing.Size(395, 173);
            this.grp_datos.TabIndex = 7;
            this.grp_datos.TabStop = false;
            this.grp_datos.Text = "DATOS PRINCIPALES";
            this.grp_datos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmb_cat
            // 
            this.cmb_cat.FormattingEnabled = true;
            this.cmb_cat.Items.AddRange(new object[] {
            "NIÑOS",
            "JUVENIL",
            "MAYORES",
            "SENIOR",
            "ELITE"});
            this.cmb_cat.Location = new System.Drawing.Point(154, 102);
            this.cmb_cat.Name = "cmb_cat";
            this.cmb_cat.Size = new System.Drawing.Size(172, 21);
            this.cmb_cat.TabIndex = 8;
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_reg.Location = new System.Drawing.Point(512, 111);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(119, 48);
            this.btn_reg.TabIndex = 8;
            this.btn_reg.Text = "REGISTRAR COMPETIDOR";
            this.btn_reg.UseVisualStyleBackColor = false;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_volver.Location = new System.Drawing.Point(610, 343);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(105, 39);
            this.btn_volver.TabIndex = 9;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // frm_ciclistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = global::ListaDobleEnlazada.Properties.Resources.pexels_pixabay_248559___Editada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 394);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.grp_datos);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "frm_ciclistas";
            this.Text = "REGISTRO CICLISTAS";
            this.Load += new System.EventHandler(this.frm_ciclistas_Load);
            this.grp_datos.ResumeLayout(false);
            this.grp_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nBici;
        private System.Windows.Forms.GroupBox grp_datos;
        private System.Windows.Forms.ComboBox cmb_cat;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_volver;
    }
}

