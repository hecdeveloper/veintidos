using System;
using veintidos;

namespace  Clases
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Humano luis = new Humano("Luis", "Lopez",  22,"azul");
            Humano ana = new Humano("Ana", "Llamas",  1,"Verde");
            luis.presentarme();
            ana.presentarme();
            Console.Read();

        } 

    }
}

