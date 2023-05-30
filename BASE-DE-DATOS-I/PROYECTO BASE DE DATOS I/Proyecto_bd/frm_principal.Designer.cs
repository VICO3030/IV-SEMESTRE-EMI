
namespace Proyecto_bd
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.recetaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratorioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarDatosToolStripMenuItem,
            this.mostrarDatosToolStripMenuItem,
            this.editarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertarDatosToolStripMenuItem
            // 
            this.insertarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicoToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.historiaToolStripMenuItem,
            this.citaToolStripMenuItem1,
            this.recetaToolStripMenuItem1,
            this.laboratorioToolStripMenuItem1});
            this.insertarDatosToolStripMenuItem.Name = "insertarDatosToolStripMenuItem";
            this.insertarDatosToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.insertarDatosToolStripMenuItem.Text = "Insertar Datos";
            // 
            // medicoToolStripMenuItem
            // 
            this.medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            this.medicoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.medicoToolStripMenuItem.Text = "Medico";
            this.medicoToolStripMenuItem.Click += new System.EventHandler(this.medicoToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // historiaToolStripMenuItem
            // 
            this.historiaToolStripMenuItem.Name = "historiaToolStripMenuItem";
            this.historiaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.historiaToolStripMenuItem.Text = "Historia";
            this.historiaToolStripMenuItem.Click += new System.EventHandler(this.historiaToolStripMenuItem_Click);
            // 
            // citaToolStripMenuItem1
            // 
            this.citaToolStripMenuItem1.Name = "citaToolStripMenuItem1";
            this.citaToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.citaToolStripMenuItem1.Text = "Cita";
            this.citaToolStripMenuItem1.Click += new System.EventHandler(this.citaToolStripMenuItem1_Click);
            // 
            // mostrarDatosToolStripMenuItem
            // 
            this.mostrarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicoToolStripMenuItem1,
            this.pacienteToolStripMenuItem1,
            this.historiaToolStripMenuItem1,
            this.citaToolStripMenuItem,
            this.recetaToolStripMenuItem,
            this.laboratorioToolStripMenuItem});
            this.mostrarDatosToolStripMenuItem.Name = "mostrarDatosToolStripMenuItem";
            this.mostrarDatosToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.mostrarDatosToolStripMenuItem.Text = "Mostrar Datos";
            this.mostrarDatosToolStripMenuItem.Click += new System.EventHandler(this.mostrarDatosToolStripMenuItem_Click);
            // 
            // medicoToolStripMenuItem1
            // 
            this.medicoToolStripMenuItem1.Name = "medicoToolStripMenuItem1";
            this.medicoToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.medicoToolStripMenuItem1.Text = "Medico";
            this.medicoToolStripMenuItem1.Click += new System.EventHandler(this.medicoToolStripMenuItem1_Click);
            // 
            // pacienteToolStripMenuItem1
            // 
            this.pacienteToolStripMenuItem1.Name = "pacienteToolStripMenuItem1";
            this.pacienteToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.pacienteToolStripMenuItem1.Text = "Paciente";
            this.pacienteToolStripMenuItem1.Click += new System.EventHandler(this.pacienteToolStripMenuItem1_Click);
            // 
            // historiaToolStripMenuItem1
            // 
            this.historiaToolStripMenuItem1.Name = "historiaToolStripMenuItem1";
            this.historiaToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.historiaToolStripMenuItem1.Text = "Historia";
            this.historiaToolStripMenuItem1.Click += new System.EventHandler(this.historiaToolStripMenuItem1_Click);
            // 
            // citaToolStripMenuItem
            // 
            this.citaToolStripMenuItem.Name = "citaToolStripMenuItem";
            this.citaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.citaToolStripMenuItem.Text = "Cita";
            this.citaToolStripMenuItem.Click += new System.EventHandler(this.citaToolStripMenuItem_Click);
            // 
            // recetaToolStripMenuItem
            // 
            this.recetaToolStripMenuItem.Name = "recetaToolStripMenuItem";
            this.recetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recetaToolStripMenuItem.Text = "Receta";
            this.recetaToolStripMenuItem.Click += new System.EventHandler(this.recetaToolStripMenuItem_Click);
            // 
            // laboratorioToolStripMenuItem
            // 
            this.laboratorioToolStripMenuItem.Name = "laboratorioToolStripMenuItem";
            this.laboratorioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.laboratorioToolStripMenuItem.Text = "Laboratorio";
            this.laboratorioToolStripMenuItem.Click += new System.EventHandler(this.laboratorioToolStripMenuItem_Click);
            // 
            // editarDatosToolStripMenuItem
            // 
            this.editarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicoToolStripMenuItem2,
            this.pacienteToolStripMenuItem2});
            this.editarDatosToolStripMenuItem.Name = "editarDatosToolStripMenuItem";
            this.editarDatosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.editarDatosToolStripMenuItem.Text = "Editar Datos";
            // 
            // medicoToolStripMenuItem2
            // 
            this.medicoToolStripMenuItem2.Name = "medicoToolStripMenuItem2";
            this.medicoToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.medicoToolStripMenuItem2.Text = "Medico";
            this.medicoToolStripMenuItem2.Click += new System.EventHandler(this.medicoToolStripMenuItem2_Click);
            // 
            // pacienteToolStripMenuItem2
            // 
            this.pacienteToolStripMenuItem2.Name = "pacienteToolStripMenuItem2";
            this.pacienteToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.pacienteToolStripMenuItem2.Text = "Paciente";
            this.pacienteToolStripMenuItem2.Click += new System.EventHandler(this.pacienteToolStripMenuItem2_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(322, 65);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(116, 64);
            this.btn_conectar.TabIndex = 1;
            this.btn_conectar.Text = "Conectar Base de datos";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(322, 135);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(116, 64);
            this.btn_desconectar.TabIndex = 2;
            this.btn_desconectar.Text = "Desconectar Base de datos";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconectar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(322, 205);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(116, 64);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // recetaToolStripMenuItem1
            // 
            this.recetaToolStripMenuItem1.Name = "recetaToolStripMenuItem1";
            this.recetaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.recetaToolStripMenuItem1.Text = "Receta";
            this.recetaToolStripMenuItem1.Click += new System.EventHandler(this.recetaToolStripMenuItem1_Click);
            // 
            // laboratorioToolStripMenuItem1
            // 
            this.laboratorioToolStripMenuItem1.Name = "laboratorioToolStripMenuItem1";
            this.laboratorioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.laboratorioToolStripMenuItem1.Text = "Laboratorio";
            this.laboratorioToolStripMenuItem1.Click += new System.EventHandler(this.laboratorioToolStripMenuItem1_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_desconectar);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_principal";
            this.Text = "frm_principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem2;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ToolStripMenuItem citaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recetaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem laboratorioToolStripMenuItem1;
    }
}