using System;
using System.Collections.Generic;

namespace CuadernoDeComunicaciones.Clases
{
    public class Calificacion : Elemento
    {
        #region Atributos
        private int calificacionNro;
        private string concepto;
        private double nota;
        private Materia materia;
        private string observacion;
        #endregion

        #region Propiedades
        public int CalificacionNro
        {
            get { return calificacionNro; }
            set { calificacionNro = value; }
        }

        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }

        public double Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public Materia Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
        #endregion

        #region Constructor
        public Calificacion(string Remitente, string Alumno, double Nota, Materia Materia, int CalificacionNro, string Concepto = "", string Observacion = "", DateTime? Fecha = null)
            : base(Remitente, Alumno, Fecha)
        {
            calificacionNro = CalificacionNro;
            concepto = Concepto;
            nota = Nota;
            materia = Materia;
            observacion = Observacion;
        }
        #endregion

        #region Métodos Públicos
        public override bool Crear()
        {
            return true; // Implementar la lógica para crear una calificación
        }

        public override void Modificar()
        {
            // Implementar la lógica para modificar una calificación
        }

        public override void Borrar()
        {
            // Implementar la lógica para borrar una calificación
        }

        public static List<Calificacion> Listar<Calificacion>()
        {
            List<Calificacion> calificaciones = new List<Calificacion>();
            // Implementar la lógica para listar calificaciones
            return calificaciones;
        }

        public override Elemento Buscar()
        {
            Elemento calificacionEncontrada = null;
            // Implementar la lógica para buscar una calificación
            return calificacionEncontrada;
        }
        #endregion
    }
}
