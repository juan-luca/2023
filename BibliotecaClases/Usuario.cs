using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = "SELECT * FROM Usuarios";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                NombreUsuario = reader["NombreUsuario"].ToString(),
                                Contraseña = reader["Contraseña"].ToString(),
                                Perfil = reader["Perfil"].ToString(),
                                NombreCompleto = reader["NombreCompleto"].ToString()
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
            }

            return usuarios;
        }

        
        public bool Crear()
        {
            // Verificar si el usuario ya existe
            if (UsuarioExiste(this.NombreUsuario))
            {
                throw new UsuarioRepetidoExcepcion("El usuario ya existe.");
              
            }

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = "INSERT INTO Usuarios (NombreUsuario, Contraseña, Perfil, NombreCompleto) VALUES (@NombreUsuario, @Contraseña, @Perfil, @NombreCompleto)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreUsuario", this.NombreUsuario);
                    comando.Parameters.AddWithValue("@Contraseña", this.Contraseña);
                    comando.Parameters.AddWithValue("@Perfil", this.Perfil);
                    comando.Parameters.AddWithValue("@NombreCompleto", this.NombreCompleto);

                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }

        private bool UsuarioExiste(string nombreUsuario)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @NombreUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public bool Modificar()
        {
            if (!UsuarioExiste(this.NombreUsuario))
            {
                throw new Exception("El usuario a modificar no existe.");
            }

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = "UPDATE Usuarios SET Contraseña = @Contraseña, Perfil = @Perfil, NombreCompleto = @NombreCompleto WHERE NombreUsuario = @NombreUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreUsuario", this.NombreUsuario);
                    comando.Parameters.AddWithValue("@Contraseña", this.Contraseña);
                    comando.Parameters.AddWithValue("@Perfil", this.Perfil);
                    comando.Parameters.AddWithValue("@NombreCompleto", this.NombreCompleto);

                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }

        public bool Borrar()
        {
            if (!UsuarioExiste(this.NombreUsuario))
            {
                throw new Exception("El usuario a eliminar no existe.");
            }

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = "DELETE FROM Usuarios WHERE NombreUsuario = @NombreUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreUsuario", this.NombreUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            return true;
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

