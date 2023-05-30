namespace Lista_Baketball
{
    partial class LISTA_EQUIPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LISTA_EQUIPOS));
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lst_FORMULARIONBA = new System.Windows.Forms.ListBox();
            this.txt_nombreequipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cantidadAni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.Btn_mostrarlista = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_nombre
            // 
            resources.ApplyResources(this.Lbl_nombre, "Lbl_nombre");
            this.Lbl_nombre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lst_FORMULARIONBA
            // 
            this.Lst_FORMULARIONBA.FormattingEnabled = true;
            resources.ApplyResources(this.Lst_FORMULARIONBA, "Lst_FORMULARIONBA");
            this.Lst_FORMULARIONBA.Name = "Lst_FORMULARIONBA";
            this.Lst_FORMULARIONBA.SelectedIndexChanged += new System.EventHandler(this.Lst_FORMULARIONBA_SelectedIndexChanged);
            // 
            // txt_nombreequipo
            // 
            resources.ApplyResources(this.txt_nombreequipo, "txt_nombreequipo");
            this.txt_nombreequipo.Name = "txt_nombreequipo";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // txt_cantidadAni
            // 
            resources.ApplyResources(this.txt_cantidadAni, "txt_cantidadAni");
            this.txt_cantidadAni.Name = "txt_cantidadAni";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Name = "label2";
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.Btn_registrar, "Btn_registrar");
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.UseVisualStyleBackColor = false;
            this.Btn_registrar.Click += new System.EventHandler(this.Btn_registrar_Click);
            // 
            // Btn_mostrarlista
            // 
            this.Btn_mostrarlista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.Btn_mostrarlista, "Btn_mostrarlista");
            this.Btn_mostrarlista.Name = "Btn_mostrarlista";
            this.Btn_mostrarlista.UseVisualStyleBackColor = false;
            this.Btn_mostrarlista.Click += new System.EventHandler(this.Btn_mostrarlista_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.Btn_limpiar, "Btn_limpiar");
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = false;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.Btn_salir, "Btn_salir");
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // LISTA_EQUIPOS
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_mostrarlista);
            this.Controls.Add(this.Btn_registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cantidadAni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombreequipo);
            this.Controls.Add(this.Lst_FORMULARIONBA);
            this.Controls.Add(this.Lbl_nombre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LISTA_EQUIPOS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.ListBox Lst_FORMULARIONBA;
        private System.Windows.Forms.TextBox txt_nombreequipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cantidadAni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.Button Btn_mostrarlista;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_salir;
    }
}

