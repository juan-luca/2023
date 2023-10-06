using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Caballo:Transporte
    {
        #region Atributos

        public string raza;
        public Colores color;

        #endregion

       

        #region Constructor

        public Caballo(string raza, byte cantPasajeros, Velocidades miVelocidad, Colores miColor):base(cantPasajeros, miVelocidad)
        {
            this.raza = raza;
            this.color = miColor;
        }

        #endregion

        #region Métodos
        public  void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine("El auto avanza a {0}", this._velocidadMaxima);
        }

        



        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            //INVOCO AL TOSTRING() DE LA CLASE BASE
            sb.AppendLine(base.Mostrar());

            sb.AppendLine("En la clase Caballo...");
            sb.Append("Raza: ");
            sb.AppendLine(this.raza);
            sb.Append("Color: ");
            sb.AppendLine(this.color.ToString());

            return sb.ToString();
        }
        #endregion


    }
}
