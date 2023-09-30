using System;
using System.Collections.Generic;

namespace CuadernoDeComunicaciones
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
            get { return this.calificacionNro; }
            set { this.calificacionNro = value; }
        }

        public string Concepto
        {
            get { return this.concepto; }
            set { this.concepto = value; }
        }

        public double Nota
        {
            get { return this.nota; }
            set { this.nota = value; }
        }

        public Materia Materia
        {
            get { return this.materia; }
            set { this.materia = value; }
        }

        public string Observacion
        {
            get { return this.observacion; }
            set { this.observacion = value; }
        }
        #endregion

        #region Constructor
        public Calificacion(string Remitente, string Alumno, double Nota, Materia Materia , int CalificacionNro, string Concepto = "", string Observacion = "", DateTime? Fecha = null)
            : base(Remitente, Alumno, Fecha)
        {
            this.calificacionNro = CalificacionNro;
            this.concepto = Concepto;
            this.nota = Nota;
            this.materia = Materia;
            this.observacion = Observacion;
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
