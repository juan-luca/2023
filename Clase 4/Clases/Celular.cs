using System;
using System.Collections.Generic;

namespace Clases
{
    public class Celular
    {
        #region Atributos Privados

        private List<Contacto> agenda;
        private string marca;
        private string modelo;
        private bool encendido;
        private double almacenamientoTotal;
        private double almacenamientoDisponible;
        private List<App> appsInstaladas;
        #endregion

        #region Propiedades Públicas

        public List<Contacto> Agenda
        {
            get { return agenda; }
            set { agenda = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public bool Encendido
        {
            get { return encendido; }
            set { encendido = value; }
        }

        public double AlmacenamientoTotal
        {
            get { return almacenamientoTotal; }
            set { almacenamientoTotal = value; }
        }

        public double AlmacenamientoDisponible
        {
            get { return almacenamientoDisponible; }
            set { almacenamientoDisponible = value; }
        }

        public List<App> AppsInstaladas
        {
            get { return appsInstaladas; }
            set { appsInstaladas = value; }
        }

        #endregion

        #region Constructor

        public Celular(string marca, string modelo, double almacenamientoTotal)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.agenda = new List<Contacto>();
            this.encendido = false;
            this.almacenamientoTotal = almacenamientoTotal;
            this.almacenamientoDisponible = almacenamientoTotal;
            this.appsInstaladas = new List<App>();
        }

        #endregion

        #region Métodos Públicos

        private bool VerificarEncendido()
        {
            if (!encendido)
            {
                Console.WriteLine("El celular está apagado. Enciéndelo para continuar.");
            }
            return encendido;
        }

        public void Encender()
        {
            encendido = true;
            Console.WriteLine("El celular está encendido.");
        }

        public void Apagar()
        {
            encendido = false;
            Console.WriteLine("El celular está apagado.");
        }

        public void AgregarContacto(Contacto contacto)
        {
            if (VerificarEncendido())
            {
                agenda.Add(contacto);
                Console.WriteLine($"Contacto '{contacto.Nombre}' agregado a la agenda.");
            }
        }

        public void MostrarInformacion()
        {
            if (VerificarEncendido())
            {
                Console.WriteLine("Marca: " + marca);
                Console.WriteLine("Modelo: " + modelo);
                Console.WriteLine("Encendido: " + (encendido ? "Sí" : "No"));
                Console.WriteLine("Almacenamiento Total: " + almacenamientoTotal + " GB");
                Console.WriteLine("Almacenamiento Disponible: " + almacenamientoDisponible + " GB");
                Console.WriteLine("Agenda:");
                foreach (Contacto contacto in agenda)
                {
                    Console.WriteLine("- Nombre: " + contacto.Nombre);
                    Console.WriteLine("  Número de Teléfono: " + contacto.NumeroTelefono);
                }
            }
        }

        public bool BuscarContactoEnAgenda(Contacto contacto)
        {
            if (VerificarEncendido())
            {
                return agenda.Contains(contacto);
            }
            return false;
        }

        public void Llamar(Contacto contacto)
        {
            if (VerificarEncendido())
            {
                if (BuscarContactoEnAgenda(contacto))
                {
                    Console.WriteLine($"Llamando a {contacto.Nombre} ({contacto.NumeroTelefono})...");
                }
                else
                {
                    Console.WriteLine($"El contacto '{contacto.Nombre}' no está en la agenda.");
                }
            }
        }

        public bool VerificarEspacioDisponible(double pesoNecesario)
        {
            if (VerificarEncendido())
            {
                return almacenamientoDisponible >= pesoNecesario;
            }
            return false;
        }

        private void InstalarApp(App aplicacion)
        {
            if (VerificarEncendido())
            {
                if (VerificarEspacioDisponible(aplicacion.Peso))
                {
                    this.almacenamientoDisponible -= aplicacion.Peso;
                    this.appsInstaladas.Add(aplicacion);

                    Console.WriteLine($"Aplicación '{aplicacion.Nombre}' instalada.");
                }
                else
                {
                    Console.WriteLine($"No hay suficiente espacio para instalar la aplicación '{aplicacion.Nombre}'.");
                }
            }
        }

        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Celular celular, App aplicacion)
        {
            if (celular.VerificarEncendido())
            {
                foreach (App appInstalada in celular.AppsInstaladas)
                {
                    if (appInstalada.Nombre == aplicacion.Nombre)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Celular celular, App aplicacion)
        {
            return !(celular == aplicacion);
        }

        public static Celular operator +(Celular celular, App aplicacion)
        {
            celular.InstalarApp(aplicacion);
            return celular;
        }

        #endregion
    }
}
