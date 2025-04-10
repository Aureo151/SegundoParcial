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
    public partial class FormLibro : Form
    {
        List<Libro> libros = new List<Libro>();
        public FormLibro()
        {
            InitializeComponent();
        }

        private void mostrar()
        {
            LibroArchivo libroArchivo = new LibroArchivo();
            libros = libroArchivo.Leer("../../Libros.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = libros;
            dataGridView1.Refresh();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro();

            libro.codigo = txtCodigo.Text;
            libro.nombre_libro = txtNombre.Text;
            libro.autor = txtAutor.Text;

            libros.Add(libro);

            LibroArchivo libroArchivo = new LibroArchivo();
            libroArchivo.Guardar("../../Libros.json", libros);

            txtNombre.Clear();
            txtAutor.Clear();
            txtCodigo.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
