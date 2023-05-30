
namespace Arbol
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
            this.Lbl_Num = new System.Windows.Forms.Label();
            this.Txt_num = new System.Windows.Forms.TextBox();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.Btn_hojas = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Num
            // 
            this.Lbl_Num.AutoSize = true;
            this.Lbl_Num.Font = new System.Drawing.Font("Baloo 2 Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Num.ForeColor = System.Drawing.Color.White;
            this.Lbl_Num.Location = new System.Drawing.Point(12, 101);
            this.Lbl_Num.Name = "Lbl_Num";
            this.Lbl_Num.Size = new System.Drawing.Size(158, 30);
            this.Lbl_Num.TabIndex = 0;
            this.Lbl_Num.Text = "Ingrese numeros:";
            // 
            // Txt_num
            // 
            this.Txt_num.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_num.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.Txt_num.Location = new System.Drawing.Point(174, 100);
            this.Txt_num.Name = "Txt_num";
            this.Txt_num.Size = new System.Drawing.Size(93, 33);
            this.Txt_num.TabIndex = 1;
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Ingresar.Location = new System.Drawing.Point(283, 102);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(105, 31);
            this.Btn_Ingresar.TabIndex = 2;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mostrar.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Mostrar.Location = new System.Drawing.Point(66, 163);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(102, 31);
            this.Btn_Mostrar.TabIndex = 5;
            this.Btn_Mostrar.Text = "Mostrar";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // Btn_hojas
            // 
            this.Btn_hojas.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_hojas.Location = new System.Drawing.Point(174, 364);
            this.Btn_hojas.Name = "Btn_hojas";
            this.Btn_hojas.Size = new System.Drawing.Size(148, 31);
            this.Btn_hojas.TabIndex = 6;
            this.Btn_hojas.Text = "Contar hojas";
            this.Btn_hojas.UseVisualStyleBackColor = true;
            this.Btn_hojas.Click += new System.EventHandler(this.Btn_hojas_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Buscar.Location = new System.Drawing.Point(202, 163);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(102, 31);
            this.Btn_Buscar.TabIndex = 7;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Eliminar.Location = new System.Drawing.Point(335, 163);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(102, 31);
            this.Btn_Eliminar.TabIndex = 9;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BubbleGum", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = " ------------- ARBOLES -------------";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Baloo 2 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btn_salir.Location = new System.Drawing.Point(474, 250);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(87, 31);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(573, 287);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_hojas);
            this.Controls.Add(this.Btn_Mostrar);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.Txt_num);
            this.Controls.Add(this.Lbl_Num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Num;
        private System.Windows.Forms.TextBox Txt_num;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.Button Btn_Mostrar;
        private System.Windows.Forms.Button Btn_hojas;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
    }
}

