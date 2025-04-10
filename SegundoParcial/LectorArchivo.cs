using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    internal class LectorArchivo
    {
        public void Guardar(string archivo, List<Lector> lectores)
        {
            string json = JsonConvert.SerializeObject(lectores);
            System.IO.File.WriteAllText(archivo, json);

        }
        public List<Lector> Leer(string archivo)
        {
            List<Lector> lista = new List<Lector>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Lector>>(json);
            return lista;
        }
    }
}
