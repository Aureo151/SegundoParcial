using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    internal class LibroArchivo
    {
        public void Guardar(string archivo, List<Libro> libros)
        {
            string json = JsonConvert.SerializeObject(libros);
            System.IO.File.WriteAllText(archivo, json);

        }
        public List<Libro> Leer(string archivo)
        {
            List<Libro> lista = new List<Libro>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Libro>>(json);
            return lista;
        }
    }
}
