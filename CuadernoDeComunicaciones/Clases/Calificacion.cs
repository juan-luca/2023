using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CuadernoDeComunicaciones.Clases
{
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
        public Calificacion()
        {

        }

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
        public override bool Crear()
        {
            if (AgregarCalificacionAXml())
                return true;

            return false;
        }

        public override bool Modificar()
        {
            List<Calificacion> calificaciones = ListarTodos(); 
            Calificacion calificacionExistente = calificaciones.FirstOrDefault(c => c.CalificacionNro == this.CalificacionNro);

            if (calificacionExistente != null)
            {
                calificacionExistente.Alumno = this.Alumno;
                calificacionExistente.Materia = this.Materia;
                calificacionExistente.Nota = this.Nota;
                calificacionExistente.Observaciones = this.Observaciones;
                calificacionExistente.Concepto = this.Concepto;
                calificacionExistente.Fecha = this.Fecha;

                return SerializarCalificaciones(calificaciones,archivoXml);
            }

            return false;
        }

        public override bool Borrar()
        {
            List<Calificacion> calificaciones = ListarTodos();
            Calificacion calificacionExistente = calificaciones.FirstOrDefault(c => c.CalificacionNro == this.CalificacionNro);

            if (calificacionExistente != null)
            {
                calificaciones.Remove(calificacionExistente);
                return SerializarCalificaciones(calificaciones, archivoXml);
            }

            return false;
        }

        public static List<Calificacion> ListarTodos()
        {
            return DeserializarCalificaciones();
        }

        public override Elemento Buscar()
        {
            Elemento calificacionEncontrada = null;
            return calificacionEncontrada;
        }
        #endregion

        private bool AgregarCalificacionAXml()
        {
            List<Calificacion> calificaciones = ListarTodos();

            calificaciones.Add(this);

            return SerializarCalificaciones(calificaciones, archivoXml);
        }

        public static List<Calificacion> DeserializarCalificaciones()
        {
            List<Calificacion> calificaciones = new List<Calificacion>();
            string archivoXml = "Calificaciones.xml";

            if (File.Exists(archivoXml))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Calificacion>));
                    using (FileStream fs = new FileStream(archivoXml, FileMode.Open))
                    {
                        calificaciones = (List<Calificacion>)serializer.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al deserializar: " + ex.Message);
                }
            }

            return calificaciones;
        }

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
                MessageBox.Show("Error al serializar: " + ex.Message);
            }

            return Serializado;
        }

        #region Propiedades Públicas
        public int CalificacionNro
        {
            get { return this.calificacionNro; }
            set { this.calificacionNro = value; }
        }

        public Materia Materia
        {
            get { return this.materia; }
            set { this.materia = value; }
        }

        public double Nota
        {
            get { return this.nota; }
            set { this.nota = value; }
        }

        public string Observaciones
        {
            get { return this.observaciones; }
            set { this.observaciones = value; }
        }

        public string Concepto
        {
            get { return this.concepto; }
            set { this.concepto = value; }
        }
        #endregion
    }
}
