using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace BibliotecaClases
{
    /// <summary>
    /// Clase que representa una calificación de un alumno en una materia.
    /// </summary>
    public class Calificacion : Elemento
    {
        #region Atributos

        private int calificacionNro;
        private Materia materia;
        private double nota;
        private string observaciones;
        private string concepto;
        protected string archivoXml = "Calificaciones.xml";

        #endregion

        #region Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase Calificacion.
        /// </summary>
        public Calificacion()
        {

        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Calificacion con parámetros específicos.
        /// </summary>
        public Calificacion(string Remitente, string Alumno, double Nota, Materia Materia, int CalificacionNro, string Concepto = "", string Observaciones = "", DateTime? Fecha = null)
            : base(Remitente, Alumno, Fecha)
        {
            this.calificacionNro = CalificacionNro;
            this.concepto = Concepto;
            this.nota = Nota;
            this.materia = Materia;
            this.observaciones = Observaciones;
        }

        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Crea una nueva calificación en la base de datos.
        /// </summary>
        public override bool Crear()
        {
            try
            {
                if (AgregarCalificacionABD())
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear calificación: " + ex.Message);
                throw new Exception("Error al crear calificación.", ex);
            }
        }

        /// <summary>
        /// Modifica una calificación existente en la base de datos.
        /// </summary>
        public override bool Modificar()
        {
            try
            {
                if (CalificacionExiste(this.calificacionNro))
                {
                    using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                    {
                        string consulta = "UPDATE Calificaciones SET Alumno = @Alumno, Materia = @Materia, Nota = @Nota, " +
                                          "Observaciones = @Observaciones, Concepto = @Concepto, Fecha = @Fecha " +
                                          "WHERE CalificacionNro = @CalificacionNro";

                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@CalificacionNro", this.calificacionNro);
                            comando.Parameters.AddWithValue("@Alumno", this.Alumno);
                            comando.Parameters.AddWithValue("@Materia", this.materia.ToString());
                            comando.Parameters.AddWithValue("@Nota", this.nota);
                            comando.Parameters.AddWithValue("@Observaciones", this.observaciones);
                            comando.Parameters.AddWithValue("@Concepto", this.concepto);
                            comando.Parameters.AddWithValue("@Fecha", this.Fecha);

                            comando.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
                else
                {
                    throw new Exception("La calificación a modificar no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar calificación: " + ex.Message);
                throw new Exception("Error al modificar calificación.", ex);
            }
        }

        /// <summary>
        /// Elimina una calificación existente en la base de datos.
        /// </summary>
        public override bool Borrar()
        {
            try
            {
                if (CalificacionExiste(this.calificacionNro))
                {
                    using (SqlConnection conexion = ConexionBD.ObtenerConexion())
                    {
                        string consulta = "DELETE FROM Calificaciones WHERE CalificacionNro = @CalificacionNro";

                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@CalificacionNro", this.calificacionNro);

                            comando.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
                else
                {
                    throw new Exception("La calificación a borrar no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al borrar calificación: " + ex.Message);
                throw new Exception("Error al borrar calificación.", ex);
            }
        }

        /// <summary>
        /// Lista todas las calificaciones existentes en la base de datos.
        /// </summary>
        public static List<Calificacion> ListarTodos()
        {
            return DeserializarCalificaciones();
        }

        /// <summary>
        /// Busca una calificación en la base de datos.
        /// </summary>
        public override Elemento Buscar()
        {
            Elemento calificacionEncontrada = null;
            return calificacionEncontrada;
        }
        /// <summary>
        /// Lista las calificaciones de un alumno específico.
        /// </summary>
        public static List<Calificacion> ListarCalificacionesDeAlumno(string usuarioAlumno)
        {
            List<Calificacion> calificaciones = ListarTodos();
            return calificaciones.Where(c => c.Alumno == usuarioAlumno).ToList();
        }

        /// <summary>
        /// Lista las calificaciones de una lista de alumnos.
        /// </summary>
        public static List<Calificacion> ListarCalificacionesDeAlumno(List<Alumno> alumnosCalificaciones)
        {
            List<Calificacion> calificaciones = ListarTodos();
            List<string> nombresAlumnos = alumnosCalificaciones.Select(a => a.NombreUsuario).ToList();
            return calificaciones.Where(c => nombresAlumnos.Contains(c.Alumno)).ToList();
        }

        /// <summary>
        /// Agrega la calificación actual a la base de datos.
        /// </summary>
        private bool AgregarCalificacionABD()
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = "INSERT INTO Calificaciones (Alumno, Remitente, Materia, Nota, Observaciones, Concepto, Fecha) " +
                                  "VALUES (@Alumno, @Remitente, @Materia, @Nota, @Observaciones, @Concepto, @Fecha)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Alumno", this.Alumno);
                    comando.Parameters.AddWithValue("@Remitente", this.Remitente);
                    comando.Parameters.AddWithValue("@Materia", this.materia.ToString());
                    comando.Parameters.AddWithValue("@Nota", this.nota);
                    comando.Parameters.AddWithValue("@Observaciones", this.observaciones);
                    comando.Parameters.AddWithValue("@Concepto", this.concepto);
                    comando.Parameters.AddWithValue("@Fecha", this.Fecha);

                    comando.ExecuteNonQuery();
                }
            }

            return true;
        }

        /// <summary>
        /// Deserializa las calificaciones desde la base de datos.
        /// </summary>
        public static List<Calificacion> DeserializarCalificaciones()
        {
            List<Calificacion> calificaciones = new List<Calificacion>();

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = "SELECT * FROM Calificaciones";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Calificacion calificacion = new Calificacion
                            {
                                calificacionNro = Convert.ToInt32(reader["CalificacionNro"]),
                                Alumno = reader["Alumno"].ToString(),
                                Remitente = reader["Remitente"].ToString(),
                                materia = (Materia)Enum.Parse(typeof(Materia), reader["Materia"].ToString()),
                                nota = Convert.ToDouble(reader["Nota"]),
                                observaciones = reader["Observaciones"].ToString(),
                                concepto = reader["Concepto"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"])
                            };

                            calificaciones.Add(calificacion);
                        }
                    }
                }
            }

            return calificaciones;
        }

        /// <summary>
        /// Serializa las calificaciones en un archivo XML.
        /// </summary>
        public static bool SerializarCalificaciones(List<Calificacion> calificaciones, string archivoXml)
        {
            bool Serializado = false;

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Calificacion>));
                using (FileStream fs = new FileStream(archivoXml, FileMode.Create))
                {
                    serializer.Serialize(fs, calificaciones);
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

        #region Métodos Privados

        /// <summary>
        /// Verifica si la calificación ya existe en la base de datos.
        /// </summary>
        private bool CalificacionExiste(int calificacionNro)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                string consulta = "SELECT COUNT(*) FROM Calificaciones WHERE CalificacionNro = @CalificacionNro";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@CalificacionNro", calificacionNro);

                    int count = (int)comando.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        #endregion

       

        #region Propiedades Públicas

        /// <summary>
        /// Obtiene o establece el número de la calificación.
        /// </summary>
        public int CalificacionNro
        {
            get { return this.calificacionNro; }
            set { this.calificacionNro = value; }
        }

        /// <summary>
        /// Obtiene o establece la materia de la calificación.
        /// </summary>
        public Materia Materia
        {
            get { return this.materia; }
            set { this.materia = value; }
        }

        /// <summary>
        /// Obtiene o establece la nota de la calificación.
        /// </summary>
        public double Nota
        {
            get { return this.nota; }
            set { this.nota = value; }
        }

        /// <summary>
        /// Obtiene o establece las observaciones de la calificación.
        /// </summary>
        public string Observaciones
        {
            get { return this.observaciones; }
            set { this.observaciones = value; }
        }

        /// <summary>
        /// Obtiene o establece el concepto de la calificación.
        /// </summary>
        public string Concepto
        {
            get { return this.concepto; }
            set { this.concepto = value; }
        }

        #endregion
    }
}
