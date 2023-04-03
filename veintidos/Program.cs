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
            if(autos == 0)
            {
                Console.WriteLine("No paga impuestos");
            }else if(autos == 1)
            {
                Console.WriteLine("Paga $15");
            }else if(autos == 2)
            {
                Console.WriteLine("Paga $35");
            }else{
            Console.WriteLine("Paga $15 por cada auto");
            }
            string piedraPapelTijera = "tijera";
            switch(piedraPapelTijera)
            {
                case "piedra":
                    Console.WriteLine("Piedra mata a tijera");
                    break;
                case "papel":
                    Console.WriteLine("Papel mata a piedra");
                    break;
                case "tijera":
                    Console.WriteLine("Tiejra mata a papel");
                    break;
                default:
                    Console.WriteLine("No es una opción válida");
                    break;
            }
            Console.Read();
        }

    }
}

