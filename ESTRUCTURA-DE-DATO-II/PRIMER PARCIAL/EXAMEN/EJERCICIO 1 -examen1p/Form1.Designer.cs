namespace EJERCICIO_1__examen1p
{
    partial class Frm_lista
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
            this.lst_listaL = new System.Windows.Forms.ListBox();
            this.lst_listaR = new System.Windows.Forms.ListBox();
            this.lbl_ingresaNumero = new System.Windows.Forms.Label();
            this.txt_nuevoNumero = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.rbt_mosLista_R = new System.Windows.Forms.RadioButton();
            this.rbt_mosLista_L = new System.Windows.Forms.RadioButton();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_formulario2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_listaL
            // 
            this.lst_listaL.FormattingEnabled = true;
            this.lst_listaL.ItemHeight = 16;
            this.lst_listaL.Location = new System.Drawing.Point(12, 113);
            this.lst_listaL.Name = "lst_listaL";
            this.lst_listaL.Size = new System.Drawing.Size(148, 260);
            this.lst_listaL.TabIndex = 0;
            this.lst_listaL.SelectedIndexChanged += new System.EventHandler(this.lst_listaL_SelectedIndexChanged);
            // 
            // lst_listaR
            // 
            this.lst_listaR.FormattingEnabled = true;
            this.lst_listaR.ItemHeight = 16;
            this.lst_listaR.Location = new System.Drawing.Point(345, 113);
            this.lst_listaR.Name = "lst_listaR";
            this.lst_listaR.Size = new System.Drawing.Size(176, 260);
            this.lst_listaR.TabIndex = 1;
            // 
            // lbl_ingresaNumero
            // 
            this.lbl_ingresaNumero.AutoSize = true;
            this.lbl_ingresaNumero.Location = new System.Drawing.Point(29, 25);
            this.lbl_ingresaNumero.Name = "lbl_ingresaNumero";
            this.lbl_ingresaNumero.Size = new System.Drawing.Size(149, 16);
            this.lbl_ingresaNumero.TabIndex = 4;
            this.lbl_ingresaNumero.Text = "INGRESAR NUMEROS";
            // 
            // txt_nuevoNumero
            // 
            this.txt_nuevoNumero.Location = new System.Drawing.Point(216, 19);
            this.txt_nuevoNumero.Name = "txt_nuevoNumero";
            this.txt_nuevoNumero.Size = new System.Drawing.Size(120, 22);
            this.txt_nuevoNumero.TabIndex = 5;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(372, 19);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(103, 23);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(203, 285);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // rbt_mosLista_R
            // 
            this.rbt_mosLista_R.AutoSize = true;
            this.rbt_mosLista_R.BackColor = System.Drawing.Color.Transparent;
            this.rbt_mosLista_R.Location = new System.Drawing.Point(174, 199);
            this.rbt_mosLista_R.Name = "rbt_mosLista_R";
            this.rbt_mosLista_R.Size = new System.Drawing.Size(149, 20);
            this.rbt_mosLista_R.TabIndex = 12;
            this.rbt_mosLista_R.TabStop = true;
            this.rbt_mosLista_R.Text = "MOSTAR LISTA \"R\"";
            this.rbt_mosLista_R.UseVisualStyleBackColor = false;
            this.rbt_mosLista_R.CheckedChanged += new System.EventHandler(this.rbt_mosLista_R_CheckedChanged);
            // 
            // rbt_mosLista_L
            // 
            this.rbt_mosLista_L.AutoSize = true;
            this.rbt_mosLista_L.BackColor = System.Drawing.Color.Transparent;
            this.rbt_mosLista_L.Location = new System.Drawing.Point(177, 150);
            this.rbt_mosLista_L.Name = "rbt_mosLista_L";
            this.rbt_mosLista_L.Size = new System.Drawing.Size(146, 20);
            this.rbt_mosLista_L.TabIndex = 11;
            this.rbt_mosLista_L.TabStop = true;
            this.rbt_mosLista_L.Text = "MOSTAR LISTA \"L\"";
            this.rbt_mosLista_L.UseVisualStyleBackColor = false;
            this.rbt_mosLista_L.CheckedChanged += new System.EventHandler(this.rbt_mosLista_L_CheckedChanged);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(32, 68);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(103, 23);
            this.btn_mostrar.TabIndex = 13;
            this.btn_mostrar.Text = "MOSTRAR";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_formulario2
            // 
            this.btn_formulario2.Location = new System.Drawing.Point(314, 396);
            this.btn_formulario2.Name = "btn_formulario2";
            this.btn_formulario2.Size = new System.Drawing.Size(207, 23);
            this.btn_formulario2.TabIndex = 14;
            this.btn_formulario2.Text = "IR A LA PREGUNTA 2";
            this.btn_formulario2.UseVisualStyleBackColor = true;
            this.btn_formulario2.Click += new System.EventHandler(this.btn_formulario2_Click);
            // 
            // Frm_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 431);
            this.Controls.Add(this.btn_formulario2);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.rbt_mosLista_R);
            this.Controls.Add(this.rbt_mosLista_L);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_nuevoNumero);
            this.Controls.Add(this.lbl_ingresaNumero);
            this.Controls.Add(this.lst_listaR);
            this.Controls.Add(this.lst_listaL);
            this.Name = "Frm_lista";
            this.Text = "LISTA DE NUMEROS REPETIDOS";
            this.Load += new System.EventHandler(this.Frm_lista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_listaL;
        private System.Windows.Forms.ListBox lst_listaR;
        private System.Windows.Forms.Label lbl_ingresaNumero;
        private System.Windows.Forms.TextBox txt_nuevoNumero;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.RadioButton rbt_mosLista_R;
        private System.Windows.Forms.RadioButton rbt_mosLista_L;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_formulario2;
    }
}

