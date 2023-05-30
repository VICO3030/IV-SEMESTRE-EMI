
namespace Aplicacion_Colas
{
    partial class Form1
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
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.Btn_Iniciar = new System.Windows.Forms.Button();
            this.RaBu_ByN = new System.Windows.Forms.RadioButton();
            this.RaBu_Color = new System.Windows.Forms.RadioButton();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComBox_Calidad = new System.Windows.Forms.ComboBox();
            this.Txt_hojas = new System.Windows.Forms.TextBox();
            this.Lbl_hojas = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.GB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.Btn_Salir);
            this.GB1.Controls.Add(this.Btn_Iniciar);
            this.GB1.Controls.Add(this.RaBu_ByN);
            this.GB1.Controls.Add(this.RaBu_Color);
            this.GB1.Controls.Add(this.Btn_Imprimir);
            this.GB1.Controls.Add(this.label1);
            this.GB1.Controls.Add(this.ComBox_Calidad);
            this.GB1.Controls.Add(this.Txt_hojas);
            this.GB1.Controls.Add(this.Lbl_hojas);
            this.GB1.Controls.Add(this.Txt_nombre);
            this.GB1.Controls.Add(this.Lbl_nombre);
            this.GB1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB1.ForeColor = System.Drawing.Color.White;
            this.GB1.Location = new System.Drawing.Point(38, 22);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(369, 394);
            this.GB1.TabIndex = 0;
            this.GB1.TabStop = false;
            this.GB1.Text = "Datos de Impresion";
            // 
            // Btn_Iniciar
            // 
            this.Btn_Iniciar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Iniciar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Iniciar.Location = new System.Drawing.Point(122, 295);
            this.Btn_Iniciar.Name = "Btn_Iniciar";
            this.Btn_Iniciar.Size = new System.Drawing.Size(130, 33);
            this.Btn_Iniciar.TabIndex = 30;
            this.Btn_Iniciar.Text = "Iniciar";
            this.Btn_Iniciar.UseVisualStyleBackColor = true;
            this.Btn_Iniciar.Click += new System.EventHandler(this.Btn_Iniciar_Click);
            // 
            // RaBu_ByN
            // 
            this.RaBu_ByN.AutoSize = true;
            this.RaBu_ByN.Location = new System.Drawing.Point(183, 207);
            this.RaBu_ByN.Name = "RaBu_ByN";
            this.RaBu_ByN.Size = new System.Drawing.Size(145, 25);
            this.RaBu_ByN.TabIndex = 10;
            this.RaBu_ByN.TabStop = true;
            this.RaBu_ByN.Text = "Blanco y Negro";
            this.RaBu_ByN.UseVisualStyleBackColor = true;
            // 
            // RaBu_Color
            // 
            this.RaBu_Color.AutoSize = true;
            this.RaBu_Color.Location = new System.Drawing.Point(54, 207);
            this.RaBu_Color.Name = "RaBu_Color";
            this.RaBu_Color.Size = new System.Drawing.Size(69, 25);
            this.RaBu_Color.TabIndex = 9;
            this.RaBu_Color.TabStop = true;
            this.RaBu_Color.Text = "Color";
            this.RaBu_Color.UseVisualStyleBackColor = true;
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.ForeColor = System.Drawing.Color.Black;
            this.Btn_Imprimir.Location = new System.Drawing.Point(122, 256);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(130, 33);
            this.Btn_Imprimir.TabIndex = 8;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Calidad:";
            // 
            // ComBox_Calidad
            // 
            this.ComBox_Calidad.BackColor = System.Drawing.Color.Black;
            this.ComBox_Calidad.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Calidad.ForeColor = System.Drawing.Color.White;
            this.ComBox_Calidad.FormattingEnabled = true;
            this.ComBox_Calidad.Items.AddRange(new object[] {
            "Borrador",
            "Estandar",
            "Alta"});
            this.ComBox_Calidad.Location = new System.Drawing.Point(175, 140);
            this.ComBox_Calidad.Name = "ComBox_Calidad";
            this.ComBox_Calidad.Size = new System.Drawing.Size(143, 29);
            this.ComBox_Calidad.TabIndex = 4;
            this.ComBox_Calidad.Text = "Elegir Opcion";
            // 
            // Txt_hojas
            // 
            this.Txt_hojas.Location = new System.Drawing.Point(190, 82);
            this.Txt_hojas.Name = "Txt_hojas";
            this.Txt_hojas.Size = new System.Drawing.Size(128, 29);
            this.Txt_hojas.TabIndex = 3;
            // 
            // Lbl_hojas
            // 
            this.Lbl_hojas.AutoSize = true;
            this.Lbl_hojas.Location = new System.Drawing.Point(18, 90);
            this.Lbl_hojas.Name = "Lbl_hojas";
            this.Lbl_hojas.Size = new System.Drawing.Size(152, 21);
            this.Lbl_hojas.TabIndex = 2;
            this.Lbl_hojas.Text = "Cantidad de hojas:";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(190, 37);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(128, 29);
            this.Txt_nombre.TabIndex = 1;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Location = new System.Drawing.Point(18, 37);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(77, 21);
            this.Lbl_nombre.TabIndex = 0;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.Color.Black;
            this.Btn_Salir.Location = new System.Drawing.Point(122, 334);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(130, 33);
            this.Btn_Salir.TabIndex = 36;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(479, 428);
            this.Controls.Add(this.GB1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComBox_Calidad;
        private System.Windows.Forms.TextBox Txt_hojas;
        private System.Windows.Forms.Label Lbl_hojas;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.RadioButton RaBu_ByN;
        private System.Windows.Forms.RadioButton RaBu_Color;
        private System.Windows.Forms.Button Btn_Iniciar;
        private System.Windows.Forms.Button Btn_Salir;
    }
}

