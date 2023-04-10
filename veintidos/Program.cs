using System;
using veintidos;

namespace  Clases
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Humano laura = new Humano();
            Humano franco = new Humano();
            laura.primerNombre = "Laura";
            franco.primerNombre = "Franco";
            laura.apellido = "Lopez";
            franco.apellido = "Milano";
            laura.presentarme();
            franco.presentarme();
            Console.Read();

        } 

     

    }
}

