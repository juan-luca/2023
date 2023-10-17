using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CuadernoDeComunicaciones.Clases
{
    public class Comunicacion : Elemento
    {
        #region Atributos
        private int comunicacionNro;
        private Categoria categoria;
        private string texto;
        protected string archivoXml = "Comunicaciones.xml";
        #endregion

        #region Constructor
        public Comunicacion()
        {

        }
        public Comunicacion(string Remitente, string Alumno, int ComunicacionNro, Categoria Categoria, string Texto, DateTime Fecha)
            : base(Remitente, Alumno, Fecha)
        {
            comunicacionNro = ComunicacionNro;
            categoria = Categoria;
            texto = Texto;
        }
        #endregion

        #region Métodos Públicos
        public override bool Crear()
        {
                if(AgregarComunicacionAXml())
                    return true;
                
            return false;
        }

        public override bool Modificar()
        {
            List<Comunicacion> comunicaciones = ListarTodos();

            Comunicacion comunicacionExistente = comunicaciones.FirstOrDefault(c => c.ComunicacionNro == this.ComunicacionNro);

            if (comunicacionExistente != null)
            {
                comunicacionExistente.Remitente = this.Remitente;
                comunicacionExistente.Alumno = this.Alumno;
                comunicacionExistente.Categoria = this.Categoria;
                comunicacionExistente.Texto = this.Texto;
                comunicacionExistente.Fecha = this.Fecha;

                if (SerializarComunicaciones(comunicaciones, archivoXml))
                {
                    return true;
                }
            }

            return false;
        }

        public override bool Borrar()
        {
            List<Comunicacion> comunicaciones = ListarTodos();

            Comunicacion comunicacionExistente = comunicaciones.FirstOrDefault(c => c.ComunicacionNro == this.ComunicacionNro);

            if (comunicacionExistente != null)
            {
                comunicaciones.Remove(comunicacionExistente);
                if (SerializarComunicaciones(comunicaciones, archivoXml))
                {
                    return true; 
                }
            }

            return false;
        }

        public static List<Comunicacion> ListarTodos()
        {

            return DeserializarComunicaciones();
        }

        public override Elemento Buscar()
        {
            Elemento comunicacionEncontrada = null;
            return comunicacionEncontrada;
        }
        #endregion


        public static List<Comunicacion> ListarComunicacionesDeAlumno(string usuarioAlumno)
        {
            List<Comunicacion> Comunicaciones = ListarTodos();
            return Comunicaciones.Where(c => c.Alumno == usuarioAlumno).ToList();
        }
        public static List<Comunicacion> ListarComunicacionesDeAlumno(List<Alumno> alumnosComunicaciones)
        {
            List<Comunicacion> Comunicaciones = ListarTodos();
            List<string> nombresAlumnos = alumnosComunicaciones.Select(a => a.NombreUsuario).ToList();
            return Comunicaciones.Where(c => nombresAlumnos.Contains(c.Alumno)).ToList();
        }

        private bool AgregarComunicacionAXml()
        {
            List<Comunicacion> comunicaciones = ListarTodos();
            Comunicacion comunicacionExistente = comunicaciones.FirstOrDefault(c => c.ComunicacionNro == this.ComunicacionNro);

            if (comunicacionExistente==null)
            {
                comunicaciones.Add(this);
                return SerializarComunicaciones(comunicaciones, archivoXml);
            }

            return false;
        }
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
                    MessageBox.Show("Error al deserializar: " + ex.Message);
                }
            }

            return comunicaciones;
        }
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
                MessageBox.Show("Error al serializar: " + ex.Message);
            }
            return Serializado;
        }

        #region Propiedades Públicas
        public int ComunicacionNro
        {
            get { return comunicacionNro; }
            set { comunicacionNro = value; }
        }

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        #endregion
    }
}
