using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class CalificacionCRUDErrorException : Exception
    {

        /// <summary>
        /// Constructor: inicializa los atributos
        /// </summary>
        public CalificacionCRUDErrorException() : base("Se ha producido un error al gestionar la calificación.")
        {
        }

        /// <summary>
        /// Constructor: inicializa los atributos con un mensaje indciado
        /// <param name="msg">string</param>
        /// </summary>
        public CalificacionCRUDErrorException(string msg) : base(msg)
        {
        }

    }
}
