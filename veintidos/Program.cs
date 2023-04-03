using System;

namespace Switch
{
    class Program
    {
        static int record = 300;
        static string recordPersona = "Juan";
        static void Main(string[] args)
        {
            
        }
        public static void revisarRecord(int puntaje, string jugador)
        {
            if(puntaje > record)
            {
                record = puntaje;
                recordPersona = jugador;
                Console.WriteLine("El nuevo Record es" + puntaje);
                Console.WriteLine("Fue logrado por" + jugador);
            }
        }
    }
}

