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
    public partial class FormLector : Form
    {
        List<Lector> lectores = new List<Lector>();
        public FormLector()
        {
            InitializeComponent();
        }
        private void mostrar()
        {
            LectorArchivo lectorArchivo = new LectorArchivo();
            lectores = lectorArchivo.Leer("../../Lectores.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lectores;
            dataGridView1.Refresh();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Lector lector = new Lector();
            lector.no_identificacion = txtIdentificacion.Text;
            lector.nombre_lector = txtNombre.Text;

            lectores.Add(lector);

            LectorArchivo lectorArchivo = new LectorArchivo();
            lectorArchivo.Guardar("../../Lectores.json", lectores);

            txtNombre.Clear();
            txtIdentificacion.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
