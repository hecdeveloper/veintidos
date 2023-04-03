using System;

namespace veintidos
{
    class Anidado                    
    {
        static void Main(string[] args)
        {
            bool esAdmin = false;
            bool estaregistrado = true;
            string nombreDeUsuario = "";
            if(estaregistrado)
            {
                Console.WriteLine("Hola usuario registrado");
                if(nombreDeUsuario != "")
                {
                    Console.WriteLine("Hola" + nombreDeUsuario);
                    if (nombreDeUsuario.Equals("Admin"));
                    {
                        Console.WriteLine("Hola Admin");
                    }
                }

            }
        }
    }
}

