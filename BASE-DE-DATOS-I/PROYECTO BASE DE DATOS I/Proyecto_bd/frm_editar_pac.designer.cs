namespace TablaSanti
{
    partial class frm_editar_pac
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
            this.grp_mod = new System.Windows.Forms.GroupBox();
            this.txt_telf_nuevo = new System.Windows.Forms.TextBox();
            this.txt_correo_nuevo = new System.Windows.Forms.TextBox();
            this.txt_direcc_nuevo = new System.Windows.Forms.TextBox();
            this.txt_apMat_nuevo = new System.Windows.Forms.TextBox();
            this.txt_apPat_nuevo = new System.Windows.Forms.TextBox();
            this.txt_nom_nuevo = new System.Windows.Forms.TextBox();
            this.btn_actualizarDatos = new System.Windows.Forms.Button();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_modificar_paciente = new System.Windows.Forms.Button();
            this.chb_eliminar = new System.Windows.Forms.CheckBox();
            this.chb_nom = new System.Windows.Forms.CheckBox();
            this.chb_apat = new System.Windows.Forms.CheckBox();
            this.chb_amat = new System.Windows.Forms.CheckBox();
            this.chb_direc = new System.Windows.Forms.CheckBox();
            this.chb_correo = new System.Windows.Forms.CheckBox();
            this.chb_telf = new System.Windows.Forms.CheckBox();
            this.grp_mod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_mod
            // 
            this.grp_mod.Controls.Add(this.chb_telf);
            this.grp_mod.Controls.Add(this.chb_correo);
            this.grp_mod.Controls.Add(this.chb_direc);
            this.grp_mod.Controls.Add(this.chb_amat);
            this.grp_mod.Controls.Add(this.chb_apat);
            this.grp_mod.Controls.Add(this.chb_nom);
            this.grp_mod.Controls.Add(this.txt_telf_nuevo);
            this.grp_mod.Controls.Add(this.txt_correo_nuevo);
            this.grp_mod.Controls.Add(this.txt_direcc_nuevo);
            this.grp_mod.Controls.Add(this.txt_apMat_nuevo);
            this.grp_mod.Controls.Add(this.txt_apPat_nuevo);
            this.grp_mod.Controls.Add(this.txt_nom_nuevo);
            this.grp_mod.Controls.Add(this.btn_actualizarDatos);
            this.grp_mod.Enabled = false;
            this.grp_mod.Location = new System.Drawing.Point(730, 289);
            this.grp_mod.Name = "grp_mod";
            this.grp_mod.Size = new System.Drawing.Size(319, 206);
            this.grp_mod.TabIndex = 0;
            this.grp_mod.TabStop = false;
            this.grp_mod.Text = "MODIFICAR PACIENTE";
            // 
            // txt_telf_nuevo
            // 
            this.txt_telf_nuevo.Enabled = false;
            this.txt_telf_nuevo.Location = new System.Drawing.Point(144, 147);
            this.txt_telf_nuevo.Name = "txt_telf_nuevo";
            this.txt_telf_nuevo.Size = new System.Drawing.Size(169, 20);
            this.txt_telf_nuevo.TabIndex = 25;
            // 
            // txt_correo_nuevo
            // 
            this.txt_correo_nuevo.Enabled = false;
            this.txt_correo_nuevo.Location = new System.Drawing.Point(144, 121);
            this.txt_correo_nuevo.Name = "txt_correo_nuevo";
            this.txt_correo_nuevo.Size = new System.Drawing.Size(169, 20);
            this.txt_correo_nuevo.TabIndex = 22;
            // 
            // txt_direcc_nuevo
            // 
            this.txt_direcc_nuevo.Enabled = false;
            this.txt_direcc_nuevo.Location = new System.Drawing.Point(144, 95);
            this.txt_direcc_nuevo.Name = "txt_direcc_nuevo";
            this.txt_direcc_nuevo.Size = new System.Drawing.Size(169, 20);
            this.txt_direcc_nuevo.TabIndex = 19;
            // 
            // txt_apMat_nuevo
            // 
            this.txt_apMat_nuevo.Enabled = false;
            this.txt_apMat_nuevo.Location = new System.Drawing.Point(191, 69);
            this.txt_apMat_nuevo.Name = "txt_apMat_nuevo";
            this.txt_apMat_nuevo.Size = new System.Drawing.Size(122, 20);
            this.txt_apMat_nuevo.TabIndex = 16;
            // 
            // txt_apPat_nuevo
            // 
            this.txt_apPat_nuevo.Enabled = false;
            this.txt_apPat_nuevo.Location = new System.Drawing.Point(191, 43);
            this.txt_apPat_nuevo.Name = "txt_apPat_nuevo";
            this.txt_apPat_nuevo.Size = new System.Drawing.Size(116, 20);
            this.txt_apPat_nuevo.TabIndex = 13;
            // 
            // txt_nom_nuevo
            // 
            this.txt_nom_nuevo.Enabled = false;
            this.txt_nom_nuevo.Location = new System.Drawing.Point(138, 17);
            this.txt_nom_nuevo.Name = "txt_nom_nuevo";
            this.txt_nom_nuevo.Size = new System.Drawing.Size(169, 20);
            this.txt_nom_nuevo.TabIndex = 10;
            // 
            // btn_actualizarDatos
            // 
            this.btn_actualizarDatos.Location = new System.Drawing.Point(174, 173);
            this.btn_actualizarDatos.Name = "btn_actualizarDatos";
            this.btn_actualizarDatos.Size = new System.Drawing.Size(139, 23);
            this.btn_actualizarDatos.TabIndex = 0;
            this.btn_actualizarDatos.Text = "ACTUALIZAR DATOS";
            this.btn_actualizarDatos.UseVisualStyleBackColor = true;
            this.btn_actualizarDatos.Click += new System.EventHandler(this.btn_actualizarDatos_Click);
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(804, 130);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(154, 20);
            this.txt_cod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "INGRESE CODIGO DE PACIENTE A BUSCAR:";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(909, 185);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 497);
            this.dataGridView1.TabIndex = 6;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(943, 544);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(106, 23);
            this.btn_volver.TabIndex = 7;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_modificar_paciente
            // 
            this.btn_modificar_paciente.Location = new System.Drawing.Point(907, 156);
            this.btn_modificar_paciente.Name = "btn_modificar_paciente";
            this.btn_modificar_paciente.Size = new System.Drawing.Size(77, 23);
            this.btn_modificar_paciente.TabIndex = 8;
            this.btn_modificar_paciente.Text = "MODIFICAR";
            this.btn_modificar_paciente.UseVisualStyleBackColor = true;
            this.btn_modificar_paciente.Click += new System.EventHandler(this.btn_modificar_cliente_Click);
            // 
            // chb_eliminar
            // 
            this.chb_eliminar.AutoSize = true;
            this.chb_eliminar.Enabled = false;
            this.chb_eliminar.Location = new System.Drawing.Point(773, 191);
            this.chb_eliminar.Name = "chb_eliminar";
            this.chb_eliminar.Size = new System.Drawing.Size(62, 17);
            this.chb_eliminar.TabIndex = 10;
            this.chb_eliminar.Text = "Eliminar";
            this.chb_eliminar.UseVisualStyleBackColor = true;
            this.chb_eliminar.CheckedChanged += new System.EventHandler(this.chb_eliminar_CheckedChanged);
            // 
            // chb_nom
            // 
            this.chb_nom.AutoSize = true;
            this.chb_nom.Location = new System.Drawing.Point(6, 20);
            this.chb_nom.Name = "chb_nom";
            this.chb_nom.Size = new System.Drawing.Size(114, 17);
            this.chb_nom.TabIndex = 11;
            this.chb_nom.Text = "NUEVO NOMBRE";
            this.chb_nom.UseVisualStyleBackColor = true;
            this.chb_nom.CheckedChanged += new System.EventHandler(this.chb_nom_CheckedChanged);
            // 
            // chb_apat
            // 
            this.chb_apat.AutoSize = true;
            this.chb_apat.Location = new System.Drawing.Point(6, 45);
            this.chb_apat.Name = "chb_apat";
            this.chb_apat.Size = new System.Drawing.Size(174, 17);
            this.chb_apat.TabIndex = 27;
            this.chb_apat.Text = "NUEVO APELLIDO PATERNO";
            this.chb_apat.UseVisualStyleBackColor = true;
            this.chb_apat.CheckedChanged += new System.EventHandler(this.chb_apat_CheckedChanged);
            // 
            // chb_amat
            // 
            this.chb_amat.AutoSize = true;
            this.chb_amat.Location = new System.Drawing.Point(6, 71);
            this.chb_amat.Name = "chb_amat";
            this.chb_amat.Size = new System.Drawing.Size(176, 17);
            this.chb_amat.TabIndex = 28;
            this.chb_amat.Text = "NUEVO APELLIDO MATERNO";
            this.chb_amat.UseVisualStyleBackColor = true;
            this.chb_amat.CheckedChanged += new System.EventHandler(this.chb_amat_CheckedChanged);
            // 
            // chb_direc
            // 
            this.chb_direc.AutoSize = true;
            this.chb_direc.Location = new System.Drawing.Point(6, 97);
            this.chb_direc.Name = "chb_direc";
            this.chb_direc.Size = new System.Drawing.Size(125, 17);
            this.chb_direc.TabIndex = 29;
            this.chb_direc.Text = "NUEVA DIRECCION";
            this.chb_direc.UseVisualStyleBackColor = true;
            this.chb_direc.CheckedChanged += new System.EventHandler(this.chb_direc_CheckedChanged);
            // 
            // chb_correo
            // 
            this.chb_correo.AutoSize = true;
            this.chb_correo.Location = new System.Drawing.Point(6, 123);
            this.chb_correo.Name = "chb_correo";
            this.chb_correo.Size = new System.Drawing.Size(113, 17);
            this.chb_correo.TabIndex = 30;
            this.chb_correo.Text = "NUEVO CORREO";
            this.chb_correo.UseVisualStyleBackColor = true;
            this.chb_correo.CheckedChanged += new System.EventHandler(this.chb_correo_CheckedChanged);
            // 
            // chb_telf
            // 
            this.chb_telf.AutoSize = true;
            this.chb_telf.Location = new System.Drawing.Point(6, 149);
            this.chb_telf.Name = "chb_telf";
            this.chb_telf.Size = new System.Drawing.Size(124, 17);
            this.chb_telf.TabIndex = 31;
            this.chb_telf.Text = "NUEVO TELEFONO";
            this.chb_telf.UseVisualStyleBackColor = true;
            this.chb_telf.CheckedChanged += new System.EventHandler(this.chb_telf_CheckedChanged);
            // 
            // frm_editar_pac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 579);
            this.Controls.Add(this.chb_eliminar);
            this.Controls.Add(this.btn_modificar_paciente);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.grp_mod);
            this.Name = "frm_editar_pac";
            this.Text = "FRM_MODIFICAR_PACIENTES";
            this.Load += new System.EventHandler(this.frm_editar_pac_Load);
            this.grp_mod.ResumeLayout(false);
            this.grp_mod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_mod;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.TextBox txt_telf_nuevo;
        private System.Windows.Forms.TextBox txt_correo_nuevo;
        private System.Windows.Forms.TextBox txt_direcc_nuevo;
        private System.Windows.Forms.TextBox txt_apMat_nuevo;
        private System.Windows.Forms.TextBox txt_apPat_nuevo;
        private System.Windows.Forms.TextBox txt_nom_nuevo;
        private System.Windows.Forms.Button btn_actualizarDatos;
        private System.Windows.Forms.Button btn_modificar_paciente;
        private System.Windows.Forms.CheckBox chb_eliminar;
        private System.Windows.Forms.CheckBox chb_telf;
        private System.Windows.Forms.CheckBox chb_correo;
        private System.Windows.Forms.CheckBox chb_direc;
        private System.Windows.Forms.CheckBox chb_amat;
        private System.Windows.Forms.CheckBox chb_apat;
        private System.Windows.Forms.CheckBox chb_nom;
    }
}