namespace ListaDobleEnlazada
{
    partial class Frm_Busqueda
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
            this.txt_nombusqueda = new System.Windows.Forms.TextBox();
            this.btn_exisstencia = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Grp_NRO = new System.Windows.Forms.GroupBox();
            this.Btn_Actualizar_tiempo = new System.Windows.Forms.Button();
            this.txt_nuevo_nro = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_nro_actual = new System.Windows.Forms.Label();
            this.Btn_volver = new System.Windows.Forms.Button();
            this.btn_eleminaci = new System.Windows.Forms.Button();
            this.Grp_NRO.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSQUEDA DE CICLISTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE NOMBRE CICLISTA :";
            // 
            // txt_nombusqueda
            // 
            this.txt_nombusqueda.Location = new System.Drawing.Point(204, 91);
            this.txt_nombusqueda.Name = "txt_nombusqueda";
            this.txt_nombusqueda.Size = new System.Drawing.Size(119, 20);
            this.txt_nombusqueda.TabIndex = 2;
            // 
            // btn_exisstencia
            // 
            this.btn_exisstencia.Location = new System.Drawing.Point(77, 166);
            this.btn_exisstencia.Name = "btn_exisstencia";
            this.btn_exisstencia.Size = new System.Drawing.Size(140, 41);
            this.btn_exisstencia.TabIndex = 3;
            this.btn_exisstencia.Text = "BUSCAR EXISTENCIA";
            this.btn_exisstencia.UseVisualStyleBackColor = true;
            this.btn_exisstencia.Click += new System.EventHandler(this.btn_exisstencia_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "MODIFICAR TIEMPO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grp_NRO
            // 
            this.Grp_NRO.Controls.Add(this.Btn_Actualizar_tiempo);
            this.Grp_NRO.Controls.Add(this.txt_nuevo_nro);
            this.Grp_NRO.Controls.Add(this.lbl);
            this.Grp_NRO.Controls.Add(this.lbl_nro_actual);
            this.Grp_NRO.Location = new System.Drawing.Point(51, 266);
            this.Grp_NRO.Name = "Grp_NRO";
            this.Grp_NRO.Size = new System.Drawing.Size(459, 166);
            this.Grp_NRO.TabIndex = 5;
            this.Grp_NRO.TabStop = false;
            this.Grp_NRO.Text = "MODIFICAR NUMERO BICICLETA";
            this.Grp_NRO.Visible = false;
            // 
            // Btn_Actualizar_tiempo
            // 
            this.Btn_Actualizar_tiempo.Location = new System.Drawing.Point(348, 100);
            this.Btn_Actualizar_tiempo.Name = "Btn_Actualizar_tiempo";
            this.Btn_Actualizar_tiempo.Size = new System.Drawing.Size(90, 41);
            this.Btn_Actualizar_tiempo.TabIndex = 8;
            this.Btn_Actualizar_tiempo.Text = "ACTUALIZAR NUMERO";
            this.Btn_Actualizar_tiempo.UseVisualStyleBackColor = true;
            this.Btn_Actualizar_tiempo.Click += new System.EventHandler(this.Btn_Actualizar_tiempo_Click);
            // 
            // txt_nuevo_nro
            // 
            this.txt_nuevo_nro.Location = new System.Drawing.Point(23, 85);
            this.txt_nuevo_nro.Name = "txt_nuevo_nro";
            this.txt_nuevo_nro.Size = new System.Drawing.Size(119, 20);
            this.txt_nuevo_nro.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(21, 52);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(148, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "INGRESE EL NUEVO NRO  :";
            // 
            // lbl_nro_actual
            // 
            this.lbl_nro_actual.AutoSize = true;
            this.lbl_nro_actual.Location = new System.Drawing.Point(7, 20);
            this.lbl_nro_actual.Name = "lbl_nro_actual";
            this.lbl_nro_actual.Size = new System.Drawing.Size(10, 13);
            this.lbl_nro_actual.TabIndex = 0;
            this.lbl_nro_actual.Text = ".";
            this.lbl_nro_actual.Click += new System.EventHandler(this.lbl_nro_actual_Click);
            // 
            // Btn_volver
            // 
            this.Btn_volver.Location = new System.Drawing.Point(521, 18);
            this.Btn_volver.Name = "Btn_volver";
            this.Btn_volver.Size = new System.Drawing.Size(90, 34);
            this.Btn_volver.TabIndex = 6;
            this.Btn_volver.Text = "VOLVER";
            this.Btn_volver.UseVisualStyleBackColor = true;
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
            // 
            // btn_eleminaci
            // 
            this.btn_eleminaci.Location = new System.Drawing.Point(521, 94);
            this.btn_eleminaci.Name = "btn_eleminaci";
            this.btn_eleminaci.Size = new System.Drawing.Size(90, 41);
            this.btn_eleminaci.TabIndex = 9;
            this.btn_eleminaci.Text = "ELEMINAR";
            this.btn_eleminaci.UseVisualStyleBackColor = true;
            this.btn_eleminaci.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(623, 476);
            this.Controls.Add(this.btn_eleminaci);
            this.Controls.Add(this.Btn_volver);
            this.Controls.Add(this.Grp_NRO);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_exisstencia);
            this.Controls.Add(this.txt_nombusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Busqueda";
            this.Text = "BUSCAR CICLISTA";
            this.Load += new System.EventHandler(this.txt_nuevotiempo_Load);
            this.Grp_NRO.ResumeLayout(false);
            this.Grp_NRO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombusqueda;
        private System.Windows.Forms.Button btn_exisstencia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Grp_NRO;
        private System.Windows.Forms.TextBox txt_nuevo_nro;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_nro_actual;
        private System.Windows.Forms.Button Btn_Actualizar_tiempo;
        private System.Windows.Forms.Button Btn_volver;
        private System.Windows.Forms.Button btn_eleminaci;
    }
}