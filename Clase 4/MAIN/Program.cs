using System;


    class Program
    {
        static void Main(string[] args)
        {
            // Crear un celular
            
            Clases.Celular miCelular = new Clases.Celular("Marca", "Modelo", 64.0);

            // Encender el celular
            miCelular.Encender();

        // Crear una aplicación
        Clases.App miApp = new Clases.App("MiApp", 10.0);

            // Instalar la aplicación en el celular
            miCelular = miCelular + miApp;

            // Comprobar si la aplicación está instalada
            if (miCelular == miApp)
            {
                Console.WriteLine($"La aplicación '{miApp.Nombre}' está instalada en el celular.");
            }
            else
            {
                Console.WriteLine($"La aplicación '{miApp.Nombre}' no está instalada en el celular.");
            }

            // Apagar el celular
            miCelular.Apagar();

        // Intentar instalar una aplicación cuando el celular está apagado
        Clases.App otraApp = new Clases.App("OtraApp", 5.0);
            miCelular = miCelular + otraApp; // Debería mostrar un mensaje de que el celular está apagado

            // Mostrar información del celular
            miCelular.MostrarInformacion();
        }
    }

