namespace SegundoParcial
{
    partial class FormPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.cmbIdentificacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Libro a Prestar";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(244, 50);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(168, 24);
            this.cmbCodigo.TabIndex = 1;
            // 
            // cmbIdentificacion
            // 
            this.cmbIdentificacion.FormattingEnabled = true;
            this.cmbIdentificacion.Location = new System.Drawing.Point(244, 103);
            this.cmbIdentificacion.Name = "cmbIdentificacion";
            this.cmbIdentificacion.Size = new System.Drawing.Size(168, 24);
            this.cmbIdentificacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion del Lector";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Prestamo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(64, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 56);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(689, 285);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(125, 56);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "Ir a Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(461, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(353, 214);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(319, 208);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(125, 56);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FormPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 353);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbIdentificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCodigo);
            this.Controls.Add(this.label1);
            this.Name = "FormPrestamo";
            this.Text = "FormPrestamo";
            this.Load += new System.EventHandler(this.FormPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.ComboBox cmbIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrar;
    }
}