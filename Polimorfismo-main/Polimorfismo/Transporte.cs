using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Transporte
    {
        #region Atributos

        protected byte _cantidadPasajeros;
        protected Velocidades _velocidadMaxima;

        #endregion



        #region Constructor

        public Transporte(byte pasajeros, Velocidades velocidadMaxima)
        {
            this._cantidadPasajeros = pasajeros;
            this._velocidadMaxima = velocidadMaxima;
        }

        #endregion

        #region Métodos 
        public void Avanzar()
        {
            Console.WriteLine("Estoy avanzando");
        }


        

        #endregion

        #region Polimorfismo ToString

        //SOBRESCRIBO EL MÉTODO TOSTRING(), 
        //HEREDADO DE OBJECT
        public string Mostrar()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            sb.AppendLine("En la clase Transporte...");
            sb.Append("Cantidad de pasajeros: ");
            sb.AppendLine(this._cantidadPasajeros.ToString());
            sb.Append("Velocidad Máxima: ");
            sb.AppendLine(((Int32)this._velocidadMaxima).ToString());

            return sb.ToString();
        }

        #endregion
    }
}
