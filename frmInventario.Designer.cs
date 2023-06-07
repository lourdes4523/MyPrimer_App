namespace MyPrimer_App
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmdComida = new System.Windows.Forms.PictureBox();
            this.cmdFrio = new System.Windows.Forms.PictureBox();
            this.cmdLimpieza = new System.Windows.Forms.PictureBox();
            this.cmdBaño = new System.Windows.Forms.PictureBox();
            this.cmdVerTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cmdComida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdFrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdLimpieza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBaño)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(349, 73);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "ALMACEN";
            // 
            // cmdComida
            // 
            this.cmdComida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdComida.Image = ((System.Drawing.Image)(resources.GetObject("cmdComida.Image")));
            this.cmdComida.Location = new System.Drawing.Point(12, 106);
            this.cmdComida.Name = "cmdComida";
            this.cmdComida.Size = new System.Drawing.Size(179, 164);
            this.cmdComida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdComida.TabIndex = 6;
            this.cmdComida.TabStop = false;
            this.cmdComida.Click += new System.EventHandler(this.cmdComida_Click);
            // 
            // cmdFrio
            // 
            this.cmdFrio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdFrio.Image = ((System.Drawing.Image)(resources.GetObject("cmdFrio.Image")));
            this.cmdFrio.Location = new System.Drawing.Point(197, 106);
            this.cmdFrio.Name = "cmdFrio";
            this.cmdFrio.Size = new System.Drawing.Size(179, 164);
            this.cmdFrio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdFrio.TabIndex = 7;
            this.cmdFrio.TabStop = false;
            this.cmdFrio.Click += new System.EventHandler(this.cmdFrio_Click);
            // 
            // cmdLimpieza
            // 
            this.cmdLimpieza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLimpieza.Image = ((System.Drawing.Image)(resources.GetObject("cmdLimpieza.Image")));
            this.cmdLimpieza.Location = new System.Drawing.Point(12, 281);
            this.cmdLimpieza.Name = "cmdLimpieza";
            this.cmdLimpieza.Size = new System.Drawing.Size(179, 164);
            this.cmdLimpieza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdLimpieza.TabIndex = 8;
            this.cmdLimpieza.TabStop = false;
            this.cmdLimpieza.Click += new System.EventHandler(this.cmdLimpieza_Click);
            // 
            // cmdBaño
            // 
            this.cmdBaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdBaño.Image = ((System.Drawing.Image)(resources.GetObject("cmdBaño.Image")));
            this.cmdBaño.Location = new System.Drawing.Point(197, 281);
            this.cmdBaño.Name = "cmdBaño";
            this.cmdBaño.Size = new System.Drawing.Size(179, 164);
            this.cmdBaño.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdBaño.TabIndex = 9;
            this.cmdBaño.TabStop = false;
            this.cmdBaño.Click += new System.EventHandler(this.cmdBaño_Click);
            // 
            // cmdVerTodo
            // 
            this.cmdVerTodo.Location = new System.Drawing.Point(140, 463);
            this.cmdVerTodo.Name = "cmdVerTodo";
            this.cmdVerTodo.Size = new System.Drawing.Size(75, 23);
            this.cmdVerTodo.TabIndex = 10;
            this.cmdVerTodo.Text = "Ver Todo";
            this.cmdVerTodo.UseVisualStyleBackColor = true;
            this.cmdVerTodo.Click += new System.EventHandler(this.cmdVerTodo_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 498);
            this.Controls.Add(this.cmdVerTodo);
            this.Controls.Add(this.cmdBaño);
            this.Controls.Add(this.cmdLimpieza);
            this.Controls.Add(this.cmdFrio);
            this.Controls.Add(this.cmdComida);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdComida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdFrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdLimpieza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBaño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox cmdComida;
        private System.Windows.Forms.PictureBox cmdFrio;
        private System.Windows.Forms.PictureBox cmdLimpieza;
        private System.Windows.Forms.PictureBox cmdBaño;
        private System.Windows.Forms.Button cmdVerTodo;
    }
}