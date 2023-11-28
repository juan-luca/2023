using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;
using Excepciones;
using Serializer;

namespace BibliotecaClases
{
    /// <summary>
    /// Clase que representa a un usuario del sistema.
    /// </summary>
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

        public string Division { get; set; }

        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene o establece el nombre de usuario.
        /// </summary>
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        /// <summary>
        /// Obtiene o establece la contraseña del usuario.
        /// </summary>
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        /// <summary>
        /// Obtiene o establece el perfil del usuario.
        /// </summary>
        public string Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        /// <summary>
        /// Obtiene o establece el nombre completo del usuario.
        /// </summary>
        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase Usuario.
        /// </summary>
        public Usuario()
        {

        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Usuario con los datos proporcionados.
        /// </summary>
        public Usuario(string NombreUsuario, string Contraseña, string Perfil, string NombreCompleto,string Division="0")
        {
            this.nombreUsuario = NombreUsuario;
            this.contraseña = Contraseña;
            this.perfil = Perfil;
            this.nombreCompleto = NombreCompleto;
            this.Division = Division;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Lista todos los usuarios almacenados en la base de datos.
        /// </summary>
        /// <returns>Una lista de usuarios.</returns>
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
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                Division = reader["IdDivision"].ToString()
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
            }

            return usuarios;
        }

        /// <summary>
        /// Crea un nuevo usuario en la base de datos.
        /// </summary>
        /// <returns>Devuelve true si la creación es exitosa; de lo contrario, lanza una excepción.</returns>
        public bool Crear()
        {
            // Verificar si el usuario ya existe
            if (UsuarioExiste(this.NombreUsuario))
            {
                throw new UsuarioRepetidoExcepcion("El usuario ya existe.");
            }

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = "INSERT INTO Usuarios (NombreUsuario, Contraseña, Perfil, NombreCompleto, IdDivision) VALUES (@NombreUsuario, @Contraseña, @Perfil, @NombreCompleto, @Division)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreUsuario", this.NombreUsuario);
                    comando.Parameters.AddWithValue("@Contraseña", this.Contraseña);
                    comando.Parameters.AddWithValue("@Perfil", this.Perfil);
                    comando.Parameters.AddWithValue("@NombreCompleto", this.NombreCompleto);
                    comando.Parameters.AddWithValue("@Division", this.Division);

                    comando.ExecuteNonQuery();
                }
            }

            // Agregar usuario al archivo XML
            AgregarUsuarioAXml();

            return true;
        }

        /// <summary>
        /// Modifica los datos de un usuario en la base de datos.
        /// </summary>
        /// <returns>Devuelve true si la modificación es exitosa; de lo contrario, lanza una excepción.</returns>
        public bool Modificar()
        {
            if (!UsuarioExiste(this.NombreUsuario))
            {
                throw new Exception("El usuario a modificar no existe.");
            }

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = "UPDATE Usuarios SET Contraseña = @Contraseña, Perfil = @Perfil, NombreCompleto = @NombreCompleto, IdDivision = @Division WHERE NombreUsuario = @NombreUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreUsuario", this.NombreUsuario);
                    comando.Parameters.AddWithValue("@Contraseña", this.Contraseña);
                    comando.Parameters.AddWithValue("@Perfil", this.Perfil);
                    comando.Parameters.AddWithValue("@NombreCompleto", this.NombreCompleto);
                    comando.Parameters.AddWithValue("@Division", this.Division.ToString());

                    comando.ExecuteNonQuery();
                }
            }

            // Modificar usuario en el archivo XML
            ModificarUsuarioEnXml();

            return true;
        }

        /// <summary>
        /// Elimina un usuario de la base de datos.
        /// </summary>
        /// <returns>Devuelve true si el borrado es exitoso; de lo contrario, lanza una excepción.</returns>
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

            // Eliminar usuario del archivo XML
            EliminarUsuarioDeXml();

            return true;
        }

        #endregion

        #region Métodos Privados

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

        private void AgregarUsuarioAXml()
        {
            try
            {
                List<Usuario> usuarios = DeserializarUsuarios();
                Usuario usuarioExistente = usuarios.Find(u => u.NombreUsuario == this.NombreUsuario);
                if (usuarioExistente == null)
                {
                    usuarios.Add(this);
                    SerializarUsuarios(usuarios);
                }
            }
            catch (SerializerException ex)
            {
                throw new SerializerException(ex);
            }
        }

        private void ModificarUsuarioEnXml()
        {
            try
            {
                List<Usuario> usuarios = DeserializarUsuarios();
                Usuario usuarioExistente = usuarios.Find(u => u.NombreUsuario == this.NombreUsuario);
                if (usuarioExistente != null)
                {
                    usuarios.Remove(usuarioExistente);
                    usuarios.Add(this);
                    SerializarUsuarios(usuarios);
                }
            }
            catch (SerializerException ex)
            {
                throw new SerializerException(ex);
            }
        }

        private void EliminarUsuarioDeXml()
        {
            try
            {
                List<Usuario> usuarios = DeserializarUsuarios();
                Usuario usuarioExistente = usuarios.Find(u => u.NombreUsuario == this.NombreUsuario);
                if (usuarioExistente != null)
                {
                    usuarios.Remove(usuarioExistente);
                    SerializarUsuarios(usuarios);
                }
            }
            catch (SerializerException ex)
            {
                throw new SerializerException(ex);
            }
        }

        private List<Usuario> DeserializarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
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

        private bool SerializarUsuarios(List<Usuario> usuarios)
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

        #endregion
    }
}
