using System;
using System.Text;
namespace Clase_2
{
    class Program
{
    static void Main(string[] args)
    {
     
        StringBuilder parrafoSB = TextOperations.ConvertirParrafoASB("Parece que el verano finalmente ha llegado. Los días son largos y soleados, y el clima es perfecto para pasar tiempo al aire libre. La playa es el lugar ideal para relajarse y tomar el sol. También es un buen momento para disfrutar de una barbacoa con amigos y familiares en el jardín. Además, las noches cálidas son ideales para observar las estrellas en el cielo. En resumen, el verano es una temporada maravillosa llena de diversión y aventuras.\"");

       

        Console.WriteLine("Párrafo en StringBuilder:");
        TextOperations.MostrarTextoSB(parrafoSB);

        Console.ReadKey(); 
    }
}
}