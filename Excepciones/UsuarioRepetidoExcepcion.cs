using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class UsuarioRepetidoExcepcion : Exception
    {
        /// <summary>
        /// Constructor: inicializa los atributos con un mensaje por defecto
        /// </summary>
        public UsuarioRepetidoExcepcion() : base("Este usuario ya existe")
        {
        }
        /// <summary>
        /// Constructor: inicializa los atributos con un mensaje indicado
        /// <param name="mensaje">string</param>
        /// </summary>
        public UsuarioRepetidoExcepcion(string msg) : base(msg)
        {
        }

        /// <summary>
        /// Constructor: inicializa los atributos con un mensaje y el trazo de la excepcion
        /// <param name="innerException">Exception</param>
        /// </summary>
        public UsuarioRepetidoExcepcion(Exception innerException) : base("Este usuario ya existe", innerException)
        {
        }
    }
}
