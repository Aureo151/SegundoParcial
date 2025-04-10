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
    public partial class FormPrestamo : Form
    {
        List<Libro> libros = new List<Libro>();
        List<Lector> lectores = new List<Lector>();
        List<Prestamo> prestamos = new List<Prestamo>();
        public FormPrestamo()
        {
            InitializeComponent();
        }


        private void mostrar()
        {
            PrestamoArchivo prestamoArchivo = new PrestamoArchivo();
            prestamos = prestamoArchivo.Leer("../../Prestamos.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = prestamos;
            dataGridView1.Refresh();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            prestamo.codigo = cmbCodigo.Text;
            prestamo.no_identificacion = cmbIdentificacion.Text;
            prestamo.fecha_prestamo = dateTimePicker1.Value;

            prestamos.Add(prestamo);

            PrestamoArchivo prestamoArchivo = new PrestamoArchivo();
            prestamoArchivo.Guardar("../../Prestamos.json", prestamos);
        }

        private void FormPrestamo_Load(object sender, EventArgs e)
        {
            LibroArchivo libroArchivo = new LibroArchivo();
            libros = libroArchivo.Leer("../../Libros.json");

            cmbCodigo.DataSource = libros;
            cmbCodigo.DisplayMember = "codigo";
            cmbCodigo.ValueMember = "codigo";

            LectorArchivo lectorArchivo = new LectorArchivo();
            lectores = lectorArchivo.Leer("../../Lectores.json");

            cmbIdentificacion.DataSource = lectores;
            cmbIdentificacion.DisplayMember = "no_identificacion";
            cmbIdentificacion.ValueMember = "no_identificacion";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            this.Close();
            FormReporte formReporte = new FormReporte();
            formReporte.Show(Owner);
        }
    }
}
