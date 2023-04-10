using System;
using veintidos;

namespace  Clases
{
    class Program
    {
 
        static void Main(string[] args)
        {

            Humano juan = new Humano("Juan");
            Humano juana = new Humano("Juana", "Garay", "verde");
            Humano milena = new Humano("Juana", "Millera");
            Humano antonio = new Humano("Antonio", "Cama", 7, "Azul");

            juan.presentarme();
            juana.presentarme();
            milena.presentarme();
            antonio.presentarme();

            Console.Read();

        } 

    }
}

