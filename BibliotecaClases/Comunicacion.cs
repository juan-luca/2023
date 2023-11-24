using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace BibliotecaClases
{
    /// <summary>
    /// Clase que representa una comunicación entre remitente y alumno.
    /// </summary>
    public class Comunicacion : Elemento
    {
        #region Atributos

        private int comunicacionNro;
        private Categoria categoria;
        private string texto;
        protected string archivoXml = "Comunicaciones.xml";

        #endregion

        #region Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase Comunicacion.
        /// </summary>
        public Comunicacion()
        {

        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Comunicacion con parámetros específicos.
        /// </summary>
        public Comunicacion(string Remitente, string Alumno, int ComunicacionNro, Categoria Categoria, string Texto, DateTime Fecha)
            : base(Remitente, Alumno, Fecha)
        {
            comunicacionNro = ComunicacionNro;
            categoria = Categoria;
            texto = Texto;
        }

        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Crea una nueva comunicación en la base de datos.
        /// </summary>
        public override bool Crear()
        {
            try
            {
                if (ComunicacionExisteEnBD())
                {
                    throw new Exception("La comunicación ya existe en la base de datos.");
                }

                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = "INSERT INTO Comunicaciones (Remitente, Alumno, Categoria, Texto, Fecha) VALUES (@Remitente, @Alumno, @Categoria, @Texto, @Fecha)";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Remitente", this.Remitente);
                        comando.Parameters.AddWithValue("@Alumno", this.Alumno);
                        comando.Parameters.AddWithValue("@Categoria", this.Categoria.ToString());
                        comando.Parameters.AddWithValue("@Texto", this.Texto);
                        comando.Parameters.AddWithValue("@Fecha", this.Fecha);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la comunicación en la base de datos.", ex);
            }
        }

        /// <summary>
        /// Modifica una comunicación existente en la base de datos.
        /// </summary>
        public override bool Modificar()
        {
            try
            {
                if (!ComunicacionExisteEnBD())
                {
                    throw new Exception("La comunicación no existe en la base de datos.");
                }

                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = "UPDATE Comunicaciones SET Remitente = @Remitente, Alumno = @Alumno, Categoria = @Categoria, Texto = @Texto, Fecha = @Fecha WHERE ComunicacionNro = @ComunicacionNro";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Remitente", this.Remitente);
                        comando.Parameters.AddWithValue("@Alumno", this.Alumno);
                        comando.Parameters.AddWithValue("@Categoria", this.Categoria.ToString());
                        comando.Parameters.AddWithValue("@Texto", this.Texto);
                        comando.Parameters.AddWithValue("@Fecha", this.Fecha);
                        comando.Parameters.AddWithValue("@ComunicacionNro", this.ComunicacionNro);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            return true;
                        }
                        else
                        {
                            throw new Exception("No se pudo modificar la comunicación en la base de datos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la comunicación en la base de datos.", ex);
            }
        }

        /// <summary>
        /// Verifica si la comunicación ya existe en la base de datos.
        /// </summary>
        private bool ComunicacionExisteEnBD()
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = "SELECT COUNT(*) FROM Comunicaciones WHERE ComunicacionNro = @ComunicacionNro";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ComunicacionNro", this.ComunicacionNro);

                        int cantidadComunicaciones = (int)comando.ExecuteScalar();

                        return cantidadComunicaciones > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar la existencia de la comunicación en la base de datos.", ex);
            }
        }

        /// <summary>
        /// Elimina una comunicación existente en la base de datos.
        /// </summary>
        public override bool Borrar()
        {
            try
            {
                if (!ComunicacionExisteEnBD())
                {
                    throw new Exception("La comunicación no existe en la base de datos.");
                }

                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = "DELETE FROM Comunicaciones WHERE ComunicacionNro = @ComunicacionNro";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ComunicacionNro", this.ComunicacionNro);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al borrar la comunicación en la base de datos.", ex);
            }
        }

        /// <summary>
        /// Lista todas las comunicaciones existentes en la base de datos.
        /// </summary>
        public static List<Comunicacion> ListarTodos()
        {
            try
            {
                List<Comunicacion> comunicaciones = new List<Comunicacion>();

                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = "SELECT * FROM Comunicaciones";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int comunicacionNro = reader.GetInt32(reader.GetOrdinal("ComunicacionNro"));
                                string remitente = reader.GetString(reader.GetOrdinal("Remitente"));
                                string alumno = reader.GetString(reader.GetOrdinal("Alumno"));
                                string categoria = reader.GetString(reader.GetOrdinal("Categoria"));
                                string texto = reader.GetString(reader.GetOrdinal("Texto"));
                                DateTime fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"));

                                Enum.TryParse<Categoria>(categoria, out Categoria categoriaEnum);
                                Comunicacion comunicacion = new Comunicacion(remitente, alumno, comunicacionNro, categoriaEnum, texto, fecha);

                                comunicaciones.Add(comunicacion);
                            }
                        }
                    }
                }

                return comunicaciones;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las comunicaciones desde la base de datos.", ex);
            }
        }

        /// <summary>
        /// Busca una comunicación por número de comunicación.
        /// </summary>
        public override Elemento Buscar()
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    string consulta = "SELECT * FROM Comunicaciones WHERE ComunicacionNro = @ComunicacionNro";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ComunicacionNro", this.ComunicacionNro);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int comunicacionNro = reader.GetInt32(reader.GetOrdinal("ComunicacionNro"));
                                string remitente = reader.GetString(reader.GetOrdinal("Remitente"));
                                string alumno = reader.GetString(reader.GetOrdinal("Alumno"));
                                int categoria = reader.GetInt32(reader.GetOrdinal("Categoria"));
                                string texto = reader.GetString(reader.GetOrdinal("Texto"));
                                DateTime fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"));

                                Categoria categoriaEnum = (Categoria)categoria;

                                return new Comunicacion(remitente, alumno, comunicacionNro, categoriaEnum, texto, fecha);
                            }
                        }
                    }
                }

                return null; // Si no se encuentra ninguna comunicación con ese número
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la comunicación en la base de datos.", ex);
            }
        }

        /// <summary>
        /// Lista las comunicaciones de un alumno específico.
        /// </summary>
        public static List<Comunicacion> ListarComunicacionesDeAlumno(string usuarioAlumno)
        {
            List<Comunicacion> Comunicaciones = ListarTodos();
            return Comunicaciones.Where(c => c.Alumno == usuarioAlumno).ToList();
        }

        /// <summary>
        /// Lista las comunicaciones de una lista de alumnos.
        /// </summary>
        public static List<Comunicacion> ListarComunicacionesDeAlumno(List<Alumno> alumnosComunicaciones)
        {
            List<Comunicacion> Comunicaciones = ListarTodos();
            List<string> nombresAlumnos = alumnosComunicaciones.Select(a => a.NombreUsuario).ToList();
            return Comunicaciones.Where(c => nombresAlumnos.Contains(c.Alumno)).ToList();
        }

        /// <summary>
        /// Agrega la comunicación actual a la lista de comunicaciones en el archivo XML.
        /// </summary>
        private bool AgregarComunicacionAXml()
        {
            List<Comunicacion> comunicaciones = ListarTodos();
            Comunicacion comunicacionExistente = comunicaciones.FirstOrDefault(c => c.ComunicacionNro == this.ComunicacionNro);

            if (comunicacionExistente == null)
            {
                comunicaciones.Add(this);
                return SerializarComunicaciones(comunicaciones, archivoXml);
            }

            return false;
        }

        /// <summary>
        /// Deserializa la lista de comunicaciones desde el archivo XML.
        /// </summary>
        public static List<Comunicacion> DeserializarComunicaciones()
        {
            List<Comunicacion> comunicaciones = new List<Comunicacion>();
            string archivoXml = "Comunicaciones.xml";
            if (File.Exists(archivoXml))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Comunicacion>));
                    using (FileStream fs = new FileStream(archivoXml, FileMode.Open))
                    {
                        comunicaciones = (List<Comunicacion>)serializer.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return comunicaciones;
        }

        /// <summary>
        /// Serializa la lista de comunicaciones en el archivo XML.
        /// </summary>
        public static bool SerializarComunicaciones(List<Comunicacion> comunicaciones, string archivoXml)
        {
            bool Serializado = false;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Comunicacion>));
                using (FileStream fs = new FileStream(archivoXml, FileMode.Create))
                {
                    serializer.Serialize(fs, comunicaciones);
                    Serializado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Serializado;
        }

        #endregion

        #region Propiedades Públicas

        /// <summary>
        /// Obtiene o establece el número de la comunicación.
        /// </summary>
        public int ComunicacionNro
        {
            get { return comunicacionNro; }
            set { comunicacionNro = value; }
        }

        /// <summary>
        /// Obtiene o establece la categoría de la comunicación.
        /// </summary>
        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        /// <summary>
        /// Obtiene o establece el texto de la comunicación.
        /// </summary>
        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        #endregion
    }
}
