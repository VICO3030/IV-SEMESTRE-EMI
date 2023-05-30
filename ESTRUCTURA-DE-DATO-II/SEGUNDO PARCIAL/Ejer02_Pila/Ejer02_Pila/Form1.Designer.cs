namespace Ejer02_Pila
{
    partial class FRM_EMPRESA
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
            this.grp_venta = new System.Windows.Forms.GroupBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GRP_REGISTRO = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRP_COMPRAS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_comprasss = new System.Windows.Forms.Button();
            this.grp_venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRP_REGISTRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRP_COMPRAS)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_venta
            // 
            this.grp_venta.Controls.Add(this.txt_descrip);
            this.grp_venta.Controls.Add(this.txt_precio);
            this.grp_venta.Controls.Add(this.txt_stock);
            this.grp_venta.Controls.Add(this.txt_cod);
            this.grp_venta.Controls.Add(this.label5);
            this.grp_venta.Controls.Add(this.label4);
            this.grp_venta.Controls.Add(this.label3);
            this.grp_venta.Controls.Add(this.label2);
            this.grp_venta.Location = new System.Drawing.Point(132, 120);
            this.grp_venta.Name = "grp_venta";
            this.grp_venta.Size = new System.Drawing.Size(378, 176);
            this.grp_venta.TabIndex = 0;
            this.grp_venta.TabStop = false;
            this.grp_venta.Text = "VENTA";
            this.grp_venta.Enter += new System.EventHandler(this.grp_venta_Enter);
            // 
            // txt_descrip
            // 
            this.txt_descrip.Location = new System.Drawing.Point(170, 147);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(163, 20);
            this.txt_descrip.TabIndex = 7;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(146, 109);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(69, 20);
            this.txt_precio.TabIndex = 6;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(146, 71);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 20);
            this.txt_stock.TabIndex = 5;
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(146, 39);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DESCRIBA EL ARTICULO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "INGRESE EL PRECIO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "INGRESE EL STOCK :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "INGRESE EL CODIGO :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE ARTICULO";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(575, 112);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(88, 35);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "AGREGAR TIENDA";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(748, 79);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(78, 35);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "VOLVER";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejer02_Pila.Properties.Resources.ventas_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(57, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GRP_REGISTRO
            // 
            this.GRP_REGISTRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRP_REGISTRO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.GRP_REGISTRO.Location = new System.Drawing.Point(12, 357);
            this.GRP_REGISTRO.Name = "GRP_REGISTRO";
            this.GRP_REGISTRO.Size = new System.Drawing.Size(443, 150);
            this.GRP_REGISTRO.TabIndex = 5;
            this.GRP_REGISTRO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRP_REGISTRO_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "STOCK";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRECIO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DESCRIPCION";
            this.Column4.Name = "Column4";
            // 
            // GRP_COMPRAS
            // 
            this.GRP_COMPRAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRP_COMPRAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.GRP_COMPRAS.Location = new System.Drawing.Point(461, 357);
            this.GRP_COMPRAS.Name = "GRP_COMPRAS";
            this.GRP_COMPRAS.Size = new System.Drawing.Size(443, 150);
            this.GRP_COMPRAS.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CODIGO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "STOCK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "TIENDA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(625, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "ALMACEN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "AGREGAR ALMACEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_comprasss
            // 
            this.btn_comprasss.Location = new System.Drawing.Point(575, 221);
            this.btn_comprasss.Name = "btn_comprasss";
            this.btn_comprasss.Size = new System.Drawing.Size(88, 35);
            this.btn_comprasss.TabIndex = 11;
            this.btn_comprasss.Text = "AÑADIR COMPRAS";
            this.btn_comprasss.UseVisualStyleBackColor = true;
            this.btn_comprasss.Click += new System.EventHandler(this.button2_Click);
            // 
            // FRM_EMPRESA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(928, 523);
            this.Controls.Add(this.btn_comprasss);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GRP_COMPRAS);
            this.Controls.Add(this.GRP_REGISTRO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_venta);
            this.Name = "FRM_EMPRESA";
            this.Text = "EMPRESA ARTICULOS";
            this.Load += new System.EventHandler(this.FRM_EMPRESA_Load);
            this.grp_venta.ResumeLayout(false);
            this.grp_venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRP_REGISTRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRP_COMPRAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_venta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView GRP_REGISTRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView GRP_COMPRAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_comprasss;
    }
}

