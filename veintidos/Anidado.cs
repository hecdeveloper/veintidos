using System;

namespace veintidos
{
    class Program                    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la temperatura actual");

            string  temperatura = Console.ReadLine();
            int numTemperatura;
            int numero;

            if(int.TryParse(temperatura, out numero))
            {
                numTemperatura = numero;
            }
            else
            {
                numTemperatura = 0;
                Console.WriteLine("El valor ingresado no es valido");
            }
            if (numTemperatura < 20)
            {
                Console.Write("Abrigate!");
            }
            else if(numTemperatura == 20)
            {
                Console.WriteLine("Vistete Comodo");
            }
            else if (numTemperatura == 30)
            {
                Console.WriteLine("Hace 30 grados que calor");
            }
            else
            {
                Console.WriteLine("Usa ropa liviana");
            }
            Console.Read();

        }
    }
}

