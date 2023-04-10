using System;
using veintidos;

namespace  Clases
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Humano luis = new Humano("Luis", "Lopez", "azul", 22);
            Humano ana = new Humano("Ana", "Llamas", "Verde", 2);
            luis.presentarme();
            ana.presentarme();
            Console.Read();

        } 

    }
}

