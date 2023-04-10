using System;
using veintidos;

namespace  Clases
{
    class Program
    {
 
        static void Main(string[] args)
        {

            Humano humanoBasico = new Humano("Alberto", "Perez", "Azul");
            humanoBasico.presentarme();
            Console.Read();



        } 

    }
}

