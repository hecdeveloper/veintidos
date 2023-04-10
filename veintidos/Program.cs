using System;
using veintidos;

namespace  Clases
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Caja caja = new Caja();
            caja.SetLargo(5);
            caja.alto = 3;
            caja.ancho = 4;
            caja.MuestraInfo(); 
        
            Console.Read();

        } 

    }
}

