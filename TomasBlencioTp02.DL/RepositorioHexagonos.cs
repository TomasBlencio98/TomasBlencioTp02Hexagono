using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TomasBlencioTp02.BL;

namespace TomasBlencioTp02.DL
{
    public class RepositorioHexagonos
    {
        public List<Hexagono> listaHexagonos { get; set; } = new List<Hexagono>();
        private readonly string _archivo = Environment.CurrentDirectory + "//Hexagonos.txt";

        public RepositorioHexagonos()
        {
            LeerDatosDelArchivo();
        }

        private void LeerDatosDelArchivo()
        {

            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine();
                    Hexagono hexagono = ConstruirHexagono(linea);
                    listaHexagonos.Add(hexagono);
                }
                lector.Close();
            }
            else
            {
                Console.WriteLine("Error, no se pudo encontrar el archivo.");
            }

        }

        private Hexagono ConstruirHexagono(string linea)
        {
            var campos = linea.Split(';');
            return new Hexagono
            {
                Lado = double.Parse(campos[0]),
                Borde = campos[1]
            };
        }

        //Metodos
        public List<Hexagono> GetLista()
        {
            return listaHexagonos;
        }
        public int GetCantidad()
        {
            return listaHexagonos.Count;
        }
        public void Agregar(Hexagono hexagono)
        {
            listaHexagonos.Add(hexagono);
            GuardarDatosEnArchivo(hexagono);
        }

        private void GuardarDatosEnArchivo(Hexagono hexagono)
        {
            StreamWriter escritor = new StreamWriter(_archivo,true);
            string linea = ConstruirLinea(hexagono);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private string ConstruirLinea(Hexagono hexagono)
        {
            return $"{hexagono.Lado};{hexagono.Borde}";
        }

        public void Borrar(Hexagono hexagono)
        {
            listaHexagonos.Remove(hexagono);
        }

        public List<Hexagono> OrdenarPorLado()
        {
            return listaHexagonos.OrderBy(h => h.Lado).ToList();
        }

        public List<Hexagono> OrdenarPorApotema()
        {
            return listaHexagonos.OrderByDescending(h => h.GetApotema()).ToList();
        }

        
    }
}
