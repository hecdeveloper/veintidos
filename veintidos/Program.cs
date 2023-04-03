using System;

namespace Switch
{
    class Program
    {
        static string? nombreDeUsuario;
        static string? clave;
        static void Main(string[] args)
        {
            int autos = 5;

            switch (autos)
            {
              case 0:
                Console.WriteLine("No paga impuestos");
                break;
            case 1:
                Console.WriteLine("Paga $15");
                break;
            case 2:
                Console.WriteLine("Paga $35");
                break;
            default:
                Console.WriteLine("Paga $15 por cada auto");
                break;
            } 
            Console.Read();
        }

    }
}

