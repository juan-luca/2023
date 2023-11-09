using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BibliotecaClases
{
    public class RelacionesManager
    {
        private string jsonFilePath = "AlumnosPadres.json";
        private List<Alumno> alumnos;

        public RelacionesManager()
        {
            LoadAlumnos();
        }

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

        private void SaveAlumnos()
        {
            var alumnosToSave = alumnos.Select(a => new { NombreUsuario = a.NombreUsuario, Padre = a.Padre, Madre = a.Madre }).ToList();
            string json = JsonConvert.SerializeObject(alumnosToSave, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }
        public Alumno ObtenerAlumnoPorNombreUsuario(string nombreUsuario)
        {
            return alumnos.FirstOrDefault(a => a.NombreUsuario == nombreUsuario);
        }
        public List<Alumno> ObtenerAlumnosRelacionados(string nombreUsuario)
        {
            if (alumnos != null && nombreUsuario != null)
            {
                return alumnos.Where(alumno => alumno.Padre == nombreUsuario || alumno.Madre == nombreUsuario).ToList();
            }

            return null;

        }

        public void CrearRelacion(Alumno alumno)
        {
            if(alumnos!=null)
            {
                var alumnoExistente = alumnos.FirstOrDefault(a => a.NombreUsuario == alumno.NombreUsuario);
                if (alumnoExistente != null)
                {
                    alumnoExistente.Padre = alumno.Padre;
                    alumnoExistente.Madre = alumno.Madre;
                    
                }else
                {
                    alumnos.Add(alumno);
                }
            }

            SaveAlumnos();
        }

        public void BorrarRelacion(string nombreUsuario)
        {
            var alumnoExistente = alumnos.FirstOrDefault(a => a.NombreUsuario == nombreUsuario);
            if (alumnoExistente != null)
            {
                alumnos.Remove(alumnoExistente);
                SaveAlumnos();
            }
        }
    }

}
