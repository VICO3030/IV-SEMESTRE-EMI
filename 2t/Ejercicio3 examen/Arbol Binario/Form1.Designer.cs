namespace Arbol_Binario
{
    partial class principal
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
            this.txtDAto = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.lstpreOrden = new System.Windows.Forms.ListBox();
            this.lstInOrdne = new System.Windows.Forms.ListBox();
            this.lstPosrOrden = new System.Windows.Forms.ListBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnPreordne = new System.Windows.Forms.Button();
            this.BtnInordern = new System.Windows.Forms.Button();
            this.BtnPostOrden = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDAto
            // 
            this.txtDAto.Location = new System.Drawing.Point(12, 12);
            this.txtDAto.Name = "txtDAto";
            this.txtDAto.Size = new System.Drawing.Size(100, 20);
            this.txtDAto.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(118, 10);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(118, 39);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(118, 68);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(109, 23);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Impares y pares";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // lstpreOrden
            // 
            this.lstpreOrden.FormattingEnabled = true;
            this.lstpreOrden.Location = new System.Drawing.Point(12, 152);
            this.lstpreOrden.Name = "lstpreOrden";
            this.lstpreOrden.Size = new System.Drawing.Size(120, 108);
            this.lstpreOrden.TabIndex = 4;
            // 
            // lstInOrdne
            // 
            this.lstInOrdne.FormattingEnabled = true;
            this.lstInOrdne.Location = new System.Drawing.Point(138, 152);
            this.lstInOrdne.Name = "lstInOrdne";
            this.lstInOrdne.Size = new System.Drawing.Size(120, 108);
            this.lstInOrdne.TabIndex = 5;
            // 
            // lstPosrOrden
            // 
            this.lstPosrOrden.FormattingEnabled = true;
            this.lstPosrOrden.Location = new System.Drawing.Point(264, 152);
            this.lstPosrOrden.Name = "lstPosrOrden";
            this.lstPosrOrden.Size = new System.Drawing.Size(120, 108);
            this.lstPosrOrden.TabIndex = 6;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(138, 266);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(120, 23);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpia";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnPreordne
            // 
            this.BtnPreordne.Location = new System.Drawing.Point(12, 123);
            this.BtnPreordne.Name = "BtnPreordne";
            this.BtnPreordne.Size = new System.Drawing.Size(120, 23);
            this.BtnPreordne.TabIndex = 8;
            this.BtnPreordne.Text = "preorden";
            this.BtnPreordne.UseVisualStyleBackColor = true;
            this.BtnPreordne.Click += new System.EventHandler(this.BtnPreordne_Click);
            // 
            // BtnInordern
            // 
            this.BtnInordern.Location = new System.Drawing.Point(138, 123);
            this.BtnInordern.Name = "BtnInordern";
            this.BtnInordern.Size = new System.Drawing.Size(120, 23);
            this.BtnInordern.TabIndex = 9;
            this.BtnInordern.Text = "Inorder";
            this.BtnInordern.UseVisualStyleBackColor = true;
            this.BtnInordern.Click += new System.EventHandler(this.BtnInordern_Click);
            // 
            // BtnPostOrden
            // 
            this.BtnPostOrden.Location = new System.Drawing.Point(264, 123);
            this.BtnPostOrden.Name = "BtnPostOrden";
            this.BtnPostOrden.Size = new System.Drawing.Size(120, 23);
            this.BtnPostOrden.TabIndex = 10;
            this.BtnPostOrden.Text = "postOrden";
            this.BtnPostOrden.UseVisualStyleBackColor = true;
            this.BtnPostOrden.Click += new System.EventHandler(this.BtnPostOrden_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Suma Nodos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnPostOrden);
            this.Controls.Add(this.BtnInordern);
            this.Controls.Add(this.BtnPreordne);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.lstPosrOrden);
            this.Controls.Add(this.lstInOrdne);
            this.Controls.Add(this.lstpreOrden);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtDAto);
            this.Name = "principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDAto;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ListBox lstpreOrden;
        private System.Windows.Forms.ListBox lstInOrdne;
        private System.Windows.Forms.ListBox lstPosrOrden;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnPreordne;
        private System.Windows.Forms.Button BtnInordern;
        private System.Windows.Forms.Button BtnPostOrden;
        private System.Windows.Forms.Button button1;
    }
}

