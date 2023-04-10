using System;
using veintidos;

namespace  Clases
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Humano laura = new Humano("Laura", "Lopez");
            Humano franco = new Humano("Franco", "Andrade");
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

