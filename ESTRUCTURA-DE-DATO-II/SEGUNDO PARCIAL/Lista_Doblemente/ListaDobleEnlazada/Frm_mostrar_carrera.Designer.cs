namespace ListaDobleEnlazada
{
    partial class Frm_mostrar_carrera
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
            this.grp_car = new System.Windows.Forms.DataGridView();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_mostrarInicio = new System.Windows.Forms.Button();
            this.Btn_MostrarFinal = new System.Windows.Forms.Button();
            this.Btn_volver = new System.Windows.Forms.Button();
            this.Btn_ordenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grp_car)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_car
            // 
            this.grp_car.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grp_car.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tiempo,
            this.lugar,
            this.fech});
            this.grp_car.Location = new System.Drawing.Point(68, 12);
            this.grp_car.Name = "grp_car";
            this.grp_car.Size = new System.Drawing.Size(343, 227);
            this.grp_car.TabIndex = 0;
            this.grp_car.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grp_car_CellContentClick);
            // 
            // tiempo
            // 
            this.tiempo.HeaderText = "Tiempo";
            this.tiempo.Name = "tiempo";
            // 
            // lugar
            // 
            this.lugar.HeaderText = "lugar";
            this.lugar.Name = "lugar";
            // 
            // fech
            // 
            this.fech.HeaderText = "Fecha";
            this.fech.Name = "fech";
            // 
            // Btn_mostrarInicio
            // 
            this.Btn_mostrarInicio.Location = new System.Drawing.Point(105, 266);
            this.Btn_mostrarInicio.Name = "Btn_mostrarInicio";
            this.Btn_mostrarInicio.Size = new System.Drawing.Size(104, 40);
            this.Btn_mostrarInicio.TabIndex = 1;
            this.Btn_mostrarInicio.Text = "MOSTRAR INICIO";
            this.Btn_mostrarInicio.UseVisualStyleBackColor = true;
            this.Btn_mostrarInicio.Click += new System.EventHandler(this.Btn_mostrar_Click);
            // 
            // Btn_MostrarFinal
            // 
            this.Btn_MostrarFinal.Location = new System.Drawing.Point(245, 266);
            this.Btn_MostrarFinal.Name = "Btn_MostrarFinal";
            this.Btn_MostrarFinal.Size = new System.Drawing.Size(104, 40);
            this.Btn_MostrarFinal.TabIndex = 2;
            this.Btn_MostrarFinal.Text = "MOSTRAR FINAL";
            this.Btn_MostrarFinal.UseVisualStyleBackColor = true;
            this.Btn_MostrarFinal.Click += new System.EventHandler(this.Btn_MostrarFinal_Click);
            // 
            // Btn_volver
            // 
            this.Btn_volver.Location = new System.Drawing.Point(488, 300);
            this.Btn_volver.Name = "Btn_volver";
            this.Btn_volver.Size = new System.Drawing.Size(81, 38);
            this.Btn_volver.TabIndex = 3;
            this.Btn_volver.Text = "VOLVER";
            this.Btn_volver.UseVisualStyleBackColor = true;
            this.Btn_volver.Click += new System.EventHandler(this.Btn_volver_Click);
            // 
            // Btn_ordenar
            // 
            this.Btn_ordenar.Location = new System.Drawing.Point(465, 26);
            this.Btn_ordenar.Name = "Btn_ordenar";
            this.Btn_ordenar.Size = new System.Drawing.Size(104, 40);
            this.Btn_ordenar.TabIndex = 4;
            this.Btn_ordenar.Text = "ORDENAR POR  TIEMPO";
            this.Btn_ordenar.UseVisualStyleBackColor = true;
            this.Btn_ordenar.Click += new System.EventHandler(this.Btn_ordenar_Click);
            // 
            // Frm_mostrar_carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(581, 350);
            this.Controls.Add(this.Btn_ordenar);
            this.Controls.Add(this.Btn_volver);
            this.Controls.Add(this.Btn_MostrarFinal);
            this.Controls.Add(this.Btn_mostrarInicio);
            this.Controls.Add(this.grp_car);
            this.Name = "Frm_mostrar_carrera";
            this.Text = "Frm_mostrar_carrera";
            this.Load += new System.EventHandler(this.Frm_mostrar_carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grp_car)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grp_car;
        private System.Windows.Forms.Button Btn_mostrarInicio;
        private System.Windows.Forms.Button Btn_MostrarFinal;
        private System.Windows.Forms.Button Btn_volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fech;
        private System.Windows.Forms.Button Btn_ordenar;
    }
}