using Newtonsoft.Json;
using System.IO;

namespace BibliotecaClases
{
    public class Configuraciones
    {
        public bool ModoOscuro { get; set; }

        // Otros ajustes de configuración según sea necesario

        public Configuraciones()
        {
            // Valores predeterminados
            ModoOscuro = false;
        }

        // Método para guardar las configuraciones en un archivo JSON
        public void GuardarConfiguraciones(string rutaArchivo)
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(rutaArchivo, json);
        }

        // Método para cargar las configuraciones desde un archivo JSON
        public static Configuraciones CargarConfiguraciones(string rutaArchivo= "configuraciones.json")
        {
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                return JsonConvert.DeserializeObject<Configuraciones>(json);
            }

            return new Configuraciones(); // Si el archivo no existe, devuelve nuevas configuraciones predeterminadas
        }
    }
}
