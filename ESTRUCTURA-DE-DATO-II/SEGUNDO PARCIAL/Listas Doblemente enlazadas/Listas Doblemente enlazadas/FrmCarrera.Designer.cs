namespace Listas_Doblemente_enlazadas
{
    partial class FrmCarrera
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
            this.txtNrobici = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.DgbCarrera = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Back.Location = new System.Drawing.Point(483, 12);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 23);
            this.Btn_Back.TabIndex = 0;
            this.Btn_Back.Text = "Volver";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // txtNrobici
            // 
            this.txtNrobici.Location = new System.Drawing.Point(159, 12);
            this.txtNrobici.Name = "txtNrobici";
            this.txtNrobici.Size = new System.Drawing.Size(100, 20);
            this.txtNrobici.TabIndex = 1;
            this.txtNrobici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNrobici_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa el nro de bici";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresa el Tiempo de la carrera";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Enabled = false;
            this.txtTiempo.Location = new System.Drawing.Point(159, 50);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingresa el lugar que llego";
            // 
            // txtLugar
            // 
            this.txtLugar.Enabled = false;
            this.txtLugar.Location = new System.Drawing.Point(159, 89);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(100, 20);
            this.txtLugar.TabIndex = 5;
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Registrar.Location = new System.Drawing.Point(483, 41);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Registrar.TabIndex = 7;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrese la fecha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(159, 115);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 8;
            this.txtfecha.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(277, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(23, 41);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // DgbCarrera
            // 
            this.DgbCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbCarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgbCarrera.Location = new System.Drawing.Point(42, 179);
            this.DgbCarrera.Name = "DgbCarrera";
            this.DgbCarrera.Size = new System.Drawing.Size(542, 171);
            this.DgbCarrera.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ciclista";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numero";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Lugar";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tiempo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha";
            this.Column5.Name = "Column5";
            // 
            // FrmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 357);
            this.Controls.Add(this.DgbCarrera);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNrobici);
            this.Controls.Add(this.Btn_Back);
            this.DoubleBuffered = true;
            this.Name = "FrmCarrera";
            this.Text = "FrmCarrera";
            this.Load += new System.EventHandler(this.FrmCarrera_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbCarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.TextBox txtNrobici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView DgbCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}