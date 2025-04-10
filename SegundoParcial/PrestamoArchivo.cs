using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    internal class PrestamoArchivo
    {
        public void Guardar(string archivo, List<Prestamo> prestamos)
        {
            string json = JsonConvert.SerializeObject(prestamos);
            System.IO.File.WriteAllText(archivo, json);

        }
        public List<Prestamo> Leer(string archivo)
        {
            List<Prestamo> lista = new List<Prestamo>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return lista;
        }
    }
}
