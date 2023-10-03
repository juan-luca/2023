using System.Xml.Serialization;
using CuadernoDeComunicaciones.Clases;

namespace CuadernoDeComunicaciones
{
    internal static class Program
    {
      
        [STAThread]
        static void Main()
        {
            GuardarUsuariosEnXML();
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
        public static void GuardarUsuariosEnXML()
        {
            List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario("Director", "contrase�a_director", "Director","Roberto"),
            new Usuario("Profesor", "contrase�a_profesor", "Profesor", "Ludmila"),
            new Usuario("Preceptor", "contrase�a_preceptor", "Preceptor", "Carlos"),
            new Usuario("Padres", "contrase�a_padres", "Padres", "Sebastian"),
            new Usuario("Alumno", "contrase�a_alumno", "Alumno", "Juan")
        };

            string archivoXML = "usuarios.xml";

            try
            {
                using (FileStream fs = new FileStream(archivoXML, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
                    serializer.Serialize(fs, usuarios);
                    Console.WriteLine("Archivo XML de usuarios creado con �xito.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear el archivo XML de usuarios: " + ex.Message);
            }
        }
    }
}