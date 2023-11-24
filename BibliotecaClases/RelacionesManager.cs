using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace BibliotecaClases
{
    /// <summary>
    /// Clase que gestiona las relaciones entre alumnos y sus padres.
    /// </summary>
    public class RelacionesManager
    {
        #region Atributos

        private string jsonFilePath = "AlumnosPadres.json";
        private List<Alumno> alumnos;

        #endregion

        #region Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase RelacionesManager.
        /// </summary>
        public RelacionesManager()
        {
            LoadAlumnos();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Carga la lista de alumnos desde el archivo JSON.
        /// </summary>
        private void LoadAlumnos()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                alumnos = JsonConvert.DeserializeObject<List<Alumno>>(json);
            }
            else
            {
                alumnos = new List<Alumno>();
            }
        }

        /// <summary>
        /// Guarda la lista de alumnos en el archivo JSON.
        /// </summary>
        private void SaveAlumnos()
        {
            var alumnosToSave = alumnos.Select(a => new { NombreUsuario = a.NombreUsuario, Padre = a.Padre, Madre = a.Madre }).ToList();
            string json = JsonConvert.SerializeObject(alumnosToSave, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }

        /// <summary>
        /// Obtiene un alumno por nombre de usuario.
        /// </summary>
        public Alumno ObtenerAlumnoPorNombreUsuario(string nombreUsuario)
        {
            return alumnos.FirstOrDefault(a => a.NombreUsuario == nombreUsuario);
        }

        /// <summary>
        /// Obtiene la lista de alumnos relacionados a un padre o madre por nombre de usuario.
        /// </summary>
        public List<Alumno> ObtenerAlumnosRelacionados(string nombreUsuario)
        {
            if (alumnos != null && nombreUsuario != null)
            {
                return alumnos.Where(alumno => alumno.Padre == nombreUsuario || alumno.Madre == nombreUsuario).ToList();
            }

            return null;
        }

        /// <summary>
        /// Crea o actualiza la relación de un alumno con sus padres.
        /// </summary>
        public void CrearRelacion(Alumno alumno)
        {
            if (alumnos != null)
            {
                var alumnoExistente = alumnos.FirstOrDefault(a => a.NombreUsuario == alumno.NombreUsuario);
                if (alumnoExistente != null)
                {
                    alumnoExistente.Padre = alumno.Padre;
                    alumnoExistente.Madre = alumno.Madre;

                }
                else
                {
                    alumnos.Add(alumno);
                }
            }

            SaveAlumnos();
        }

        /// <summary>
        /// Borra la relación de un alumno con sus padres por nombre de usuario.
        /// </summary>
        public void BorrarRelacion(string nombreUsuario)
        {
            var alumnoExistente = alumnos.FirstOrDefault(a => a.NombreUsuario == nombreUsuario);
            if (alumnoExistente != null)
            {
                alumnos.Remove(alumnoExistente);
                SaveAlumnos();
            }
        }

        #endregion
    }
}
