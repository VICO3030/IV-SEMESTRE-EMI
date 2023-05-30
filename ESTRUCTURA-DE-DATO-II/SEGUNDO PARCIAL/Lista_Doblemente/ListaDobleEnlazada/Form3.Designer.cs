
namespace ListaDobleEnlazada
{
    partial class frm_principal
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_buscar_ca = new System.Windows.Forms.Button();
            this.btn_mostrar_ca = new System.Windows.Forms.Button();
            this.btn_reg_ca = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_menu_ciclista = new System.Windows.Forms.GroupBox();
            this.btn_buscar_cic = new System.Windows.Forms.Button();
            this.btn_mostrar_cic = new System.Windows.Forms.Button();
            this.btn_reg_cic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.grp_menu_ciclista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SpringGreen;
            this.groupBox2.Controls.Add(this.btn_buscar_ca);
            this.groupBox2.Controls.Add(this.btn_mostrar_ca);
            this.groupBox2.Controls.Add(this.btn_reg_ca);
            this.groupBox2.Location = new System.Drawing.Point(424, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 160);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MENU CARRERA";
            // 
            // btn_buscar_ca
            // 
            this.btn_buscar_ca.Location = new System.Drawing.Point(37, 105);
            this.btn_buscar_ca.Name = "btn_buscar_ca";
            this.btn_buscar_ca.Size = new System.Drawing.Size(146, 37);
            this.btn_buscar_ca.TabIndex = 4;
            this.btn_buscar_ca.Text = "BUCAR CARRERA";
            this.btn_buscar_ca.UseVisualStyleBackColor = true;
            this.btn_buscar_ca.Click += new System.EventHandler(this.btn_buscar_ca_Click);
            // 
            // btn_mostrar_ca
            // 
            this.btn_mostrar_ca.Location = new System.Drawing.Point(37, 62);
            this.btn_mostrar_ca.Name = "btn_mostrar_ca";
            this.btn_mostrar_ca.Size = new System.Drawing.Size(146, 37);
            this.btn_mostrar_ca.TabIndex = 3;
            this.btn_mostrar_ca.Text = "MOSTRAR REGISTRO";
            this.btn_mostrar_ca.UseVisualStyleBackColor = true;
            this.btn_mostrar_ca.Click += new System.EventHandler(this.btn_mostrar_ca_Click);
            // 
            // btn_reg_ca
            // 
            this.btn_reg_ca.Location = new System.Drawing.Point(37, 19);
            this.btn_reg_ca.Name = "btn_reg_ca";
            this.btn_reg_ca.Size = new System.Drawing.Size(146, 37);
            this.btn_reg_ca.TabIndex = 2;
            this.btn_reg_ca.Text = "REGISTRAR CARRERA";
            this.btn_reg_ca.UseVisualStyleBackColor = true;
            this.btn_reg_ca.Click += new System.EventHandler(this.btn_reg_ca_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(358, 374);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(101, 41);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "COMPETICION INTERNCAIONAL CICLISMO";
            // 
            // grp_menu_ciclista
            // 
            this.grp_menu_ciclista.BackColor = System.Drawing.Color.SpringGreen;
            this.grp_menu_ciclista.Controls.Add(this.btn_buscar_cic);
            this.grp_menu_ciclista.Controls.Add(this.btn_mostrar_cic);
            this.grp_menu_ciclista.Controls.Add(this.btn_reg_cic);
            this.grp_menu_ciclista.Location = new System.Drawing.Point(132, 171);
            this.grp_menu_ciclista.Name = "grp_menu_ciclista";
            this.grp_menu_ciclista.Size = new System.Drawing.Size(219, 159);
            this.grp_menu_ciclista.TabIndex = 0;
            this.grp_menu_ciclista.TabStop = false;
            this.grp_menu_ciclista.Text = "MENU CICLISTA";
            // 
            // btn_buscar_cic
            // 
            this.btn_buscar_cic.Location = new System.Drawing.Point(37, 105);
            this.btn_buscar_cic.Name = "btn_buscar_cic";
            this.btn_buscar_cic.Size = new System.Drawing.Size(146, 37);
            this.btn_buscar_cic.TabIndex = 4;
            this.btn_buscar_cic.Text = "BUSCAR CICLISTA";
            this.btn_buscar_cic.UseVisualStyleBackColor = true;
            this.btn_buscar_cic.Click += new System.EventHandler(this.btn_buscar_cic_Click);
            // 
            // btn_mostrar_cic
            // 
            this.btn_mostrar_cic.Location = new System.Drawing.Point(37, 62);
            this.btn_mostrar_cic.Name = "btn_mostrar_cic";
            this.btn_mostrar_cic.Size = new System.Drawing.Size(146, 37);
            this.btn_mostrar_cic.TabIndex = 3;
            this.btn_mostrar_cic.Text = "MOSTRAR REGISTRO";
            this.btn_mostrar_cic.UseVisualStyleBackColor = true;
            this.btn_mostrar_cic.Click += new System.EventHandler(this.btn_mostrar_cic_Click);
            // 
            // btn_reg_cic
            // 
            this.btn_reg_cic.Location = new System.Drawing.Point(37, 19);
            this.btn_reg_cic.Name = "btn_reg_cic";
            this.btn_reg_cic.Size = new System.Drawing.Size(146, 37);
            this.btn_reg_cic.TabIndex = 2;
            this.btn_reg_cic.Text = "REGISTRAR CICLISTA";
            this.btn_reg_cic.UseVisualStyleBackColor = true;
            this.btn_reg_cic.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ListaDobleEnlazada.Properties.Resources.pexels_pixabay_71104__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_menu_ciclista);
            this.Name = "frm_principal";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.groupBox2.ResumeLayout(false);
            this.grp_menu_ciclista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_menu_ciclista;
        private System.Windows.Forms.Button btn_buscar_cic;
        private System.Windows.Forms.Button btn_mostrar_cic;
        private System.Windows.Forms.Button btn_reg_cic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_buscar_ca;
        private System.Windows.Forms.Button btn_mostrar_ca;
        private System.Windows.Forms.Button btn_reg_ca;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}