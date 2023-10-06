using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public  class Auto:Transporte
    {
        #region Atributos

        public int cantidadRuedas;

        #endregion

        #region Propiedades


        #endregion

        #region Constructor

        public Auto(byte pasajeros, Velocidades velocidad, int ruedas):base(pasajeros,velocidad)
        {
            this.cantidadRuedas = ruedas;
        }

        #endregion

        #region Métodos
        public void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine("El auto avanza a {0}", this._velocidadMaxima);
        }

        public  void Frenar()
        {
            Console.WriteLine("reduzco velocidad pisando el freno...");
        }

        #endregion

    

        public string mostrar()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            //INVOCO AL TOSTRING() DE LA CLASE BASE
            sb.AppendLine(base.Mostrar());

            sb.AppendLine("En la clase Auto...");
            sb.Append("Cantidad de ruedas: ");
            sb.AppendLine(this.cantidadRuedas.ToString());

            return sb.ToString();
        }

 
    }
}

