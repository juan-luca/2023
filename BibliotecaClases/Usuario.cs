using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Excepciones;
using Serializer;

namespace BibliotecaClases
{
    [Serializable]
    public class Usuario
    {
        #region Atributos
        private string nombreUsuario;
        private string contraseña;
        private string perfil;
        private string nombreCompleto;
        private string archivoXml = "Usuarios.xml";
        private XML<List<Usuario>> xmlSerializer = new XML<List<Usuario>>();
        #endregion

        #region Propiedades
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public string Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }
        #endregion

        #region Constructor
        public Usuario()
        {
            
        }
        public Usuario(string NombreUsuario, string Contraseña, string Perfil, string NombreCompleto)
        {
            this.nombreUsuario = NombreUsuario;
            this.contraseña = Contraseña;
            this.perfil = Perfil;
            this.nombreCompleto = NombreCompleto;
        }
        #endregion

        
        public static List<Usuario> ListarTodos()
        {
            List<Usuario> usuarios = null;
            XML<List<Usuario>> xmlSerializer = new XML<List<Usuario>>();
            try
            {
                xmlSerializer.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "Usuarios.xml", out usuarios);
                
            }
            catch (SerializerException ex)
            {
                
                throw new SerializerException(ex);
            }

            return usuarios ?? new List<Usuario>();
        }

        public bool Crear()
        {
            List<Usuario> usuarios = ListarTodos();
            Usuario usuarioExistente = usuarios.FirstOrDefault(u => u.NombreUsuario == this.NombreUsuario);

            if (usuarioExistente != null)
            {
                throw new Exception("El usuario ya existe.");
            }

            if (AgregarUsuarioAXml())
            {
                return true;
            }

            return false;
        }
        public bool Modificar()
        {
            List<Usuario> usuarios = ListarTodos();
            Usuario usuarioExistente = usuarios.FirstOrDefault(u => u.NombreUsuario == this.NombreUsuario);

            if (usuarioExistente != null)
            {
                usuarioExistente.Contraseña = this.Contraseña;
                usuarioExistente.Perfil = this.Perfil;
                usuarioExistente.NombreCompleto = this.NombreCompleto;

                return SerializarUsuarios(usuarios, archivoXml);
            }
            else
            {
                throw new Exception("El usuario a modificar no existe.");
            }
        }

        public bool Borrar()
        {
            List<Usuario> usuarios = ListarTodos();
            Usuario usuarioAEliminar = usuarios.Find(u => u.NombreUsuario == this.NombreUsuario);

            if (usuarioAEliminar != null)
            {
                usuarios.Remove(usuarioAEliminar);
                return SerializarUsuarios(usuarios, archivoXml);
            }
            else
            {
                throw new Exception("El usuario a eliminar no existe.");
            }
        }

        private bool AgregarUsuarioAXml()
        {
            
            try
            {
                List<Usuario> usuarios = ListarTodos();
                Usuario usuarioExistente = usuarios.FirstOrDefault(u => u.NombreUsuario == this.NombreUsuario);
                if (usuarioExistente == null)
                {
                    usuarios.Add(this);
                    //return SerializarUsuarios(usuarios,archivoXml);

                    //xmlSerializer.Guardar(archivoXml, usuarios);
                    return xmlSerializer.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + archivoXml, usuarios);
                }
            }
            catch (SerializerException ex)
            {

                throw new SerializerException(ex);
            }
            

            return false;
        }

        public static List<Usuario> DeserializarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string archivoXml = "Usuarios.xml";
            if (File.Exists(archivoXml))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
                    using (FileStream fs = new FileStream(archivoXml, FileMode.Open))
                    {
                        usuarios = (List<Usuario>)serializer.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al deserializar usuarios: " + ex.Message);
                }
            }

           return usuarios;
          
        }

        public static bool SerializarUsuarios(List<Usuario> usuarios, string archivoXml)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
                using (FileStream fs = new FileStream(archivoXml, FileMode.Create))
                {
                    serializer.Serialize(fs, usuarios);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al serializar usuarios: " + ex.Message);
                return false;
            }
        }

    }
}

