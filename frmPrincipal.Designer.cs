namespace MyPrimer_App
{
    partial class frmPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmdFinanzas = new System.Windows.Forms.Button();
            this.cmdAlmacen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(63, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 33);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Gestion Personal";
            // 
            // cmdFinanzas
            // 
            this.cmdFinanzas.Location = new System.Drawing.Point(12, 92);
            this.cmdFinanzas.Name = "cmdFinanzas";
            this.cmdFinanzas.Size = new System.Drawing.Size(168, 225);
            this.cmdFinanzas.TabIndex = 0;
            this.cmdFinanzas.Text = "Finanzas";
            this.cmdFinanzas.UseVisualStyleBackColor = true;
            this.cmdFinanzas.Click += new System.EventHandler(this.cmdFinanzas_Click);
            // 
            // cmdAlmacen
            // 
            this.cmdAlmacen.Location = new System.Drawing.Point(204, 92);
            this.cmdAlmacen.Name = "cmdAlmacen";
            this.cmdAlmacen.Size = new System.Drawing.Size(168, 225);
            this.cmdAlmacen.TabIndex = 1;
            this.cmdAlmacen.Text = "Almacen";
            this.cmdAlmacen.UseVisualStyleBackColor = true;
            this.cmdAlmacen.Click += new System.EventHandler(this.cmdAlmacen_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 343);
            this.Controls.Add(this.cmdAlmacen);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmdFinanzas);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button cmdFinanzas;
        private System.Windows.Forms.Button cmdAlmacen;
    }
}

