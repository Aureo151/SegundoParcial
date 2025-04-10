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
    public partial class FormReporte : Form
    {
        List<Libro> libros = new List<Libro>();
        List<Lector> lectores = new List<Lector>();
        List<Prestamo> prestamos = new List<Prestamo>();
        List<Reporte> reportes = new List<Reporte>();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            reportes.Clear();
            foreach (var libro in libros)
            {
                foreach (var prestamo in prestamos)
                {
                    if (libro.codigo == prestamo.codigo)
                    {
                        foreach (var lector in lectores)
                        {
                            if (lector.no_identificacion == prestamo.no_identificacion)
                            {
                                Reporte reporte = new Reporte();
                                reporte.nombre_lector = lector.nombre_lector;
                                reporte.nombre_libro = libro.nombre_libro;
                                reporte.fecha_prestamo = prestamo.fecha_prestamo;

                                reportes.Add(reporte);
                            }
                        }
                    }
                }


            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes;
            dataGridView1.Refresh();

            int c = reportes.Count;
            label2.Visible = true;
            label2.Text = c.ToString();
        }

        private void FormReporte_Load(object sender, EventArgs e)
        {
            LibroArchivo libroArchivo = new LibroArchivo();
            libros = libroArchivo.Leer("../../Libros.json");

            LectorArchivo lectorArchivo = new LectorArchivo();
            lectores = lectorArchivo.Leer("../../Lectores.json");

            PrestamoArchivo prestamoArchivo = new PrestamoArchivo();
            prestamos = prestamoArchivo.Leer("../../Prestamos.json");
        }

        private void btnOrdenFecha_Click(object sender, EventArgs e)
        {
            reportes = reportes.OrderBy(r => r.fecha_prestamo).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes;
            dataGridView1.Refresh();
        }
    }
}
