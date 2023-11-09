using System;
using System.Collections.Generic;

namespace BibliotecaClases
{
    public abstract class Elemento
    {
        #region Atributos
        private string remitente;
        private DateTime fecha;
        private string alumno;
        #endregion

        #region Propiedades
        public string Remitente
        {
            get { return this.remitente; }
            set { this.remitente = value; }
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        public string Alumno
        {
            get { return this.alumno; }
            set { this.alumno = value; }
        }
        #endregion

        #region Constructor
        protected Elemento(string Remitente = "", string Alumno = "", DateTime? Fecha = null)
        {
            this.remitente = Remitente;
            if (Fecha!=null)
            {
                this.fecha = Fecha.Value;
            }
            else
            {
                this.fecha = DateTime.Now;
            }
            this.alumno = Alumno;
        }
        #endregion

        #region Métodos Abstractos
        public abstract bool Crear();
        public abstract bool Modificar();
        public abstract bool Borrar();
        public abstract Elemento Buscar();
        #endregion
    }
}
