namespace Ejercicio02
{
    partial class FRM_PRINCIPAL
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_nrolotes = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DTG_FABRICA = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_canticompra = new System.Windows.Forms.TextBox();
            this.txt_nomcompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_mostrarFabrica = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_FABRICA)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO  Y VENTA DE LOTES ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nrolotes);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE LOTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE PRODUCTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NUMERO DE LOTES :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(134, 27);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(174, 20);
            this.txt_nom.TabIndex = 2;
            // 
            // txt_nrolotes
            // 
            this.txt_nrolotes.Location = new System.Drawing.Point(134, 61);
            this.txt_nrolotes.Name = "txt_nrolotes";
            this.txt_nrolotes.Size = new System.Drawing.Size(46, 20);
            this.txt_nrolotes.TabIndex = 3;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(355, 76);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(80, 35);
            this.btn_registrar.TabIndex = 2;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "COMPRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DTG_FABRICA
            // 
            this.DTG_FABRICA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_FABRICA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DTG_FABRICA.Location = new System.Drawing.Point(11, 229);
            this.DTG_FABRICA.Name = "DTG_FABRICA";
            this.DTG_FABRICA.Size = new System.Drawing.Size(345, 153);
            this.DTG_FABRICA.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = " FABRICA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_canticompra);
            this.groupBox2.Controls.Add(this.txt_nomcompra);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(442, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 99);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COMPRA DE LOTES";
            // 
            // txt_canticompra
            // 
            this.txt_canticompra.Location = new System.Drawing.Point(150, 65);
            this.txt_canticompra.Name = "txt_canticompra";
            this.txt_canticompra.Size = new System.Drawing.Size(46, 20);
            this.txt_canticompra.TabIndex = 3;
            // 
            // txt_nomcompra
            // 
            this.txt_nomcompra.Location = new System.Drawing.Point(134, 27);
            this.txt_nomcompra.Name = "txt_nomcompra";
            this.txt_nomcompra.Size = new System.Drawing.Size(174, 20);
            this.txt_nomcompra.TabIndex = 2;
            this.txt_nomcompra.TextChanged += new System.EventHandler(this.txt_nomcompra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "CANTIDAD A COMPRAR  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "NOMBRE PRODUCTO:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NRO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NRO LOTES";
            this.Column3.Name = "Column3";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(442, 229);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(345, 153);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NRO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "NRO LOTES";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "VENTA";
            // 
            // btn_mostrarFabrica
            // 
            this.btn_mostrarFabrica.Location = new System.Drawing.Point(225, 187);
            this.btn_mostrarFabrica.Name = "btn_mostrarFabrica";
            this.btn_mostrarFabrica.Size = new System.Drawing.Size(80, 35);
            this.btn_mostrarFabrica.TabIndex = 8;
            this.btn_mostrarFabrica.Text = "MOSTRAR ";
            this.btn_mostrarFabrica.UseVisualStyleBackColor = true;
            this.btn_mostrarFabrica.Click += new System.EventHandler(this.btn_mostrarFabrica_Click);
            // 
            // FRM_PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(831, 430);
            this.Controls.Add(this.btn_mostrarFabrica);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTG_FABRICA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FRM_PRINCIPAL";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRM_PRINCIPAL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_FABRICA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nrolotes;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DTG_FABRICA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_canticompra;
        private System.Windows.Forms.TextBox txt_nomcompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_mostrarFabrica;
    }
}

