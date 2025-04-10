using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FormLibro formLibro  = new FormLibro();
            formLibro.Show();
        }

        private void btnLectores_Click(object sender, EventArgs e)
        {
            FormLector formLector = new FormLector();
            formLector.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FormPrestamo formPrestamo = new FormPrestamo();
            formPrestamo.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ;
        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
        }
    }
}
