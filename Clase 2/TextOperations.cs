using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    public class TextOperations
    {
        public static int ContarLetras(string palabra)
        {
            return palabra.Length;
        }


        public static int ContarPalabras(string texto)
        {
            string[] palabras = texto.Split(new char[] { ' ', '\t', '\n', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;

        }

        public static int ContarVocales(string palabra)
        {
            int contador = 0;
            foreach (char c in palabra.ToLower())
            {
                if("aeiouáéíóú".Contains(c)) contador++;

            }

            return contador;
        }


        public static int ContarConsonantes(string palabra)
        {
            int contador = 0;
            foreach (char c in palabra.ToLower())
            {
                if ("bcdfghjklmnpqrstvwxyz".Contains(c)) contador++;

            }

            return contador;

        }

        public static string ReemplazarCaracter(string palabra, char original, char nuevo)
        {
            return palabra.Replace(original, nuevo);
        }

        public static bool ConvertirStringAEntero(string palabra, out int numeroEntero)
        {
            return int.TryParse(palabra, out numeroEntero);

        }

        public static StringBuilder ConvertirStringASB(string palabra)
        {
            return new StringBuilder(palabra);
        }

        public static StringBuilder ConvertirParrafoASB(string parrafo)
        {
            string[] palabras = parrafo.Split(new char[] { '.' });
            StringBuilder sb = new StringBuilder();

            foreach(string palabra in palabras)
            {
                sb.AppendLine(palabra);
            }

            return sb;
        }

        public static void MostrarTexto(string mensaje, string texto)
        {
            Console.WriteLine($"{mensaje}: {texto}");
        }

        public static void MostrarTextoSB(StringBuilder texto)
        {
            Console.WriteLine(texto.ToString());
        }


    }
}
