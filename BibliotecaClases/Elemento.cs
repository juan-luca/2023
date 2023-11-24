using System;
using System.Collections.Generic;

namespace BibliotecaClases
{
    /// <summary>
    /// Clase base abstracta que representa un elemento genérico.
    /// </summary>
    public abstract class Elemento
    {
        #region Atributos

        private string remitente;
        private DateTime fecha;
        private string alumno;

        #endregion

        #region Propiedades

        /// <summary>
        /// Obtiene o establece el remitente del elemento.
        /// </summary>
        public string Remitente
        {
            get { return this.remitente; }
            set { this.remitente = value; }
        }

        /// <summary>
        /// Obtiene o establece la fecha del elemento.
        /// </summary>
        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        /// <summary>
        /// Obtiene o establece el alumno asociado al elemento.
        /// </summary>
        public string Alumno
        {
            get { return this.alumno; }
            set { this.alumno = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Inicializa una nueva instancia de la clase Elemento.
        /// </summary>
        /// <param name="Remitente">Remitente del elemento.</param>
        /// <param name="Alumno">Alumno asociado al elemento.</param>
        /// <param name="Fecha">Fecha del elemento (opcional, por defecto es la fecha actual).</param>
        protected Elemento(string Remitente = "", string Alumno = "", DateTime? Fecha = null)
        {
            this.remitente = Remitente;
            if (Fecha != null)
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

        /// <summary>
        /// Crea un nuevo elemento.
        /// </summary>
        /// <returns>Devuelve true si la creación es exitosa; de lo contrario, false.</returns>
        public abstract bool Crear();

        /// <summary>
        /// Modifica el elemento actual.
        /// </summary>
        /// <returns>Devuelve true si la modificación es exitosa; de lo contrario, false.</returns>
        public abstract bool Modificar();

        /// <summary>
        /// Borra el elemento actual.
        /// </summary>
        /// <returns>Devuelve true si el borrado es exitoso; de lo contrario, false.</returns>
        public abstract bool Borrar();

        /// <summary>
        /// Busca un elemento según ciertos criterios.
        /// </summary>
        /// <returns>Devuelve el elemento encontrado o null si no se encuentra.</returns>
        public abstract Elemento Buscar();

        #endregion
    }
}
