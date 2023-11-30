using Newtonsoft.Json;
using System.IO;

namespace BibliotecaClases
{
    public class Configuraciones
    {
        public bool ModoOscuro { get; set; }
        private IErrorLogger<CustomError> errorLogger = new ErrorLogger<CustomError>();

        // Otros ajustes de configuración según sea necesario

        public Configuraciones()
        {
            // Valores predeterminados
            ModoOscuro = false;
        }

        // Método para guardar las configuraciones en un archivo JSON
        public void GuardarConfiguraciones(string rutaArchivo)
        {
            try
            {
                string json = JsonConvert.SerializeObject(this, Formatting.Indented);
                File.WriteAllText(rutaArchivo, json);
            }
            catch (Exception ex)
            {
                CustomError error = new CustomError($"Error al crear el usuario: {ex.Message}");

                if (errorLogger != null)
                {
                    errorLogger.LogError(error);
                }
                throw new Exception("Error al crear el usuario.", ex);
            }

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
