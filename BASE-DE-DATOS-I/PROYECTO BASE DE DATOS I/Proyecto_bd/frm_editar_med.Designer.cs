
namespace Proyecto_bd
{
    partial class frm_editar_med
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.grp_todo = new System.Windows.Forms.GroupBox();
            this.dgv_mostrar = new System.Windows.Forms.DataGridView();
            this.grp_eliminar = new System.Windows.Forms.GroupBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.chb_eliminar = new System.Windows.Forms.CheckBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.grp_editar = new System.Windows.Forms.GroupBox();
            this.chb_correo = new System.Windows.Forms.CheckBox();
            this.btn_aplicar = new System.Windows.Forms.Button();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.chb_direc = new System.Windows.Forms.CheckBox();
            this.txt_direc = new System.Windows.Forms.TextBox();
            this.chb_amat = new System.Windows.Forms.CheckBox();
            this.txt_amat = new System.Windows.Forms.TextBox();
            this.chb_apat = new System.Windows.Forms.CheckBox();
            this.txt_apat = new System.Windows.Forms.TextBox();
            this.chb_nombre = new System.Windows.Forms.CheckBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.grp_todo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar)).BeginInit();
            this.grp_eliminar.SuspendLayout();
            this.grp_editar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(698, 320);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 5;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // grp_todo
            // 
            this.grp_todo.Controls.Add(this.dgv_mostrar);
            this.grp_todo.Controls.Add(this.grp_eliminar);
            this.grp_todo.Controls.Add(this.grp_editar);
            this.grp_todo.Enabled = false;
            this.grp_todo.Location = new System.Drawing.Point(13, 13);
            this.grp_todo.Name = "grp_todo";
            this.grp_todo.Size = new System.Drawing.Size(760, 301);
            this.grp_todo.TabIndex = 7;
            this.grp_todo.TabStop = false;
            this.grp_todo.Text = "Editar Datos";
            // 
            // dgv_mostrar
            // 
            this.dgv_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrar.Location = new System.Drawing.Point(255, 20);
            this.dgv_mostrar.Name = "dgv_mostrar";
            this.dgv_mostrar.Size = new System.Drawing.Size(486, 258);
            this.dgv_mostrar.TabIndex = 9;
            // 
            // grp_eliminar
            // 
            this.grp_eliminar.Controls.Add(this.btn_editar);
            this.grp_eliminar.Controls.Add(this.chb_eliminar);
            this.grp_eliminar.Controls.Add(this.btn_eliminar);
            this.grp_eliminar.Controls.Add(this.label1);
            this.grp_eliminar.Controls.Add(this.txt_cod);
            this.grp_eliminar.Location = new System.Drawing.Point(7, 20);
            this.grp_eliminar.Name = "grp_eliminar";
            this.grp_eliminar.Size = new System.Drawing.Size(242, 76);
            this.grp_eliminar.TabIndex = 8;
            this.grp_eliminar.TabStop = false;
            this.grp_eliminar.Text = "Busqueda";
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(80, 45);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 14;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // chb_eliminar
            // 
            this.chb_eliminar.AutoSize = true;
            this.chb_eliminar.Enabled = false;
            this.chb_eliminar.Location = new System.Drawing.Point(9, 51);
            this.chb_eliminar.Name = "chb_eliminar";
            this.chb_eliminar.Size = new System.Drawing.Size(62, 17);
            this.chb_eliminar.TabIndex = 13;
            this.chb_eliminar.Text = "Eliminar";
            this.chb_eliminar.UseVisualStyleBackColor = true;
            this.chb_eliminar.CheckedChanged += new System.EventHandler(this.chb_eliminar_CheckedChanged_1);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(161, 47);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo:";
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(136, 19);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 3;
            // 
            // grp_editar
            // 
            this.grp_editar.Controls.Add(this.chb_correo);
            this.grp_editar.Controls.Add(this.btn_aplicar);
            this.grp_editar.Controls.Add(this.txt_correo);
            this.grp_editar.Controls.Add(this.chb_direc);
            this.grp_editar.Controls.Add(this.txt_direc);
            this.grp_editar.Controls.Add(this.chb_amat);
            this.grp_editar.Controls.Add(this.txt_amat);
            this.grp_editar.Controls.Add(this.chb_apat);
            this.grp_editar.Controls.Add(this.txt_apat);
            this.grp_editar.Controls.Add(this.chb_nombre);
            this.grp_editar.Controls.Add(this.txt_nom);
            this.grp_editar.Enabled = false;
            this.grp_editar.Location = new System.Drawing.Point(7, 102);
            this.grp_editar.Name = "grp_editar";
            this.grp_editar.Size = new System.Drawing.Size(242, 177);
            this.grp_editar.TabIndex = 7;
            this.grp_editar.TabStop = false;
            this.grp_editar.Text = "Editar";
            // 
            // chb_correo
            // 
            this.chb_correo.AutoSize = true;
            this.chb_correo.Location = new System.Drawing.Point(6, 125);
            this.chb_correo.Name = "chb_correo";
            this.chb_correo.Size = new System.Drawing.Size(60, 17);
            this.chb_correo.TabIndex = 12;
            this.chb_correo.Text = "Correo:";
            this.chb_correo.UseVisualStyleBackColor = true;
            this.chb_correo.CheckedChanged += new System.EventHandler(this.chb_correo_CheckedChanged_1);
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.Location = new System.Drawing.Point(136, 149);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.Size = new System.Drawing.Size(100, 23);
            this.btn_aplicar.TabIndex = 1;
            this.btn_aplicar.Text = "Aplicar Cambios";
            this.btn_aplicar.UseVisualStyleBackColor = true;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click_1);
            // 
            // txt_correo
            // 
            this.txt_correo.Enabled = false;
            this.txt_correo.Location = new System.Drawing.Point(136, 123);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(100, 20);
            this.txt_correo.TabIndex = 11;
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            // 
            // chb_direc
            // 
            this.chb_direc.AutoSize = true;
            this.chb_direc.Location = new System.Drawing.Point(6, 99);
            this.chb_direc.Name = "chb_direc";
            this.chb_direc.Size = new System.Drawing.Size(74, 17);
            this.chb_direc.TabIndex = 10;
            this.chb_direc.Text = "Direccion:";
            this.chb_direc.UseVisualStyleBackColor = true;
            this.chb_direc.CheckedChanged += new System.EventHandler(this.chb_direc_CheckedChanged_1);
            // 
            // txt_direc
            // 
            this.txt_direc.Enabled = false;
            this.txt_direc.Location = new System.Drawing.Point(136, 97);
            this.txt_direc.Name = "txt_direc";
            this.txt_direc.Size = new System.Drawing.Size(100, 20);
            this.txt_direc.TabIndex = 9;
            // 
            // chb_amat
            // 
            this.chb_amat.AutoSize = true;
            this.chb_amat.Location = new System.Drawing.Point(6, 73);
            this.chb_amat.Name = "chb_amat";
            this.chb_amat.Size = new System.Drawing.Size(108, 17);
            this.chb_amat.TabIndex = 8;
            this.chb_amat.Text = "Apellido Materno:";
            this.chb_amat.UseVisualStyleBackColor = true;
            this.chb_amat.CheckedChanged += new System.EventHandler(this.chb_amat_CheckedChanged_1);
            // 
            // txt_amat
            // 
            this.txt_amat.Enabled = false;
            this.txt_amat.Location = new System.Drawing.Point(136, 71);
            this.txt_amat.Name = "txt_amat";
            this.txt_amat.Size = new System.Drawing.Size(100, 20);
            this.txt_amat.TabIndex = 7;
            // 
            // chb_apat
            // 
            this.chb_apat.AutoSize = true;
            this.chb_apat.Location = new System.Drawing.Point(6, 47);
            this.chb_apat.Name = "chb_apat";
            this.chb_apat.Size = new System.Drawing.Size(106, 17);
            this.chb_apat.TabIndex = 6;
            this.chb_apat.Text = "Apellido Paterno:";
            this.chb_apat.UseVisualStyleBackColor = true;
            this.chb_apat.CheckedChanged += new System.EventHandler(this.chb_apat_CheckedChanged);
            // 
            // txt_apat
            // 
            this.txt_apat.Enabled = false;
            this.txt_apat.Location = new System.Drawing.Point(136, 45);
            this.txt_apat.Name = "txt_apat";
            this.txt_apat.Size = new System.Drawing.Size(100, 20);
            this.txt_apat.TabIndex = 5;
            // 
            // chb_nombre
            // 
            this.chb_nombre.AutoSize = true;
            this.chb_nombre.Location = new System.Drawing.Point(6, 21);
            this.chb_nombre.Name = "chb_nombre";
            this.chb_nombre.Size = new System.Drawing.Size(71, 17);
            this.chb_nombre.TabIndex = 4;
            this.chb_nombre.Text = "Nombres:";
            this.chb_nombre.UseVisualStyleBackColor = true;
            this.chb_nombre.CheckedChanged += new System.EventHandler(this.chb_nombre_CheckedChanged_1);
            // 
            // txt_nom
            // 
            this.txt_nom.Enabled = false;
            this.txt_nom.Location = new System.Drawing.Point(136, 19);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 2;
            // 
            // frm_editar_med
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 353);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.grp_todo);
            this.Name = "frm_editar_med";
            this.Text = "frm_editar_med";
            this.Load += new System.EventHandler(this.frm_editar_med_Load);
            this.grp_todo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar)).EndInit();
            this.grp_eliminar.ResumeLayout(false);
            this.grp_eliminar.PerformLayout();
            this.grp_editar.ResumeLayout(false);
            this.grp_editar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.GroupBox grp_todo;
        private System.Windows.Forms.DataGridView dgv_mostrar;
        private System.Windows.Forms.GroupBox grp_eliminar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.GroupBox grp_editar;
        private System.Windows.Forms.CheckBox chb_eliminar;
        private System.Windows.Forms.CheckBox chb_correo;
        private System.Windows.Forms.Button btn_aplicar;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.CheckBox chb_direc;
        private System.Windows.Forms.TextBox txt_direc;
        private System.Windows.Forms.CheckBox chb_amat;
        private System.Windows.Forms.TextBox txt_amat;
        private System.Windows.Forms.CheckBox chb_apat;
        private System.Windows.Forms.TextBox txt_apat;
        private System.Windows.Forms.CheckBox chb_nombre;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Button btn_editar;
    }
}