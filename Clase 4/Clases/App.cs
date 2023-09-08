using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class App
    {
        #region Atributos Privados

        private string nombre;
        private double peso;

        #endregion

        #region Propiedades Públicas

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        #endregion

        #region Constructor

        public App(string nombre, double peso)
        {
            this.nombre = nombre;
            this.peso = peso;
        }

        #endregion
    }

}
