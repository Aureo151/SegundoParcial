namespace SegundoParcial
{
    partial class Form1
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
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnLectores = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLibros
            // 
            this.btnLibros.Location = new System.Drawing.Point(62, 147);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(203, 93);
            this.btnLibros.TabIndex = 0;
            this.btnLibros.Text = "Ir a Libros";
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnLectores
            // 
            this.btnLectores.Location = new System.Drawing.Point(551, 147);
            this.btnLectores.Name = "btnLectores";
            this.btnLectores.Size = new System.Drawing.Size(153, 93);
            this.btnLectores.TabIndex = 1;
            this.btnLectores.Text = "Ir a Lectores";
            this.btnLectores.UseVisualStyleBackColor = true;
            this.btnLectores.Click += new System.EventHandler(this.btnLectores_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Location = new System.Drawing.Point(310, 147);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(172, 93);
            this.btnPrestamos.TabIndex = 2;
            this.btnPrestamos.Text = "Ir a Prestamos";
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(310, 263);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(172, 93);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Ir a Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.btnLectores);
            this.Controls.Add(this.btnLibros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnLectores;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnReporte;
    }
}

