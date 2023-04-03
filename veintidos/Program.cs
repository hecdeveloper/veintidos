using System;

namespace veintidos
{
    class Program                    
    {
        static void Main(string[] args)
        {
            bool esAdmin = false;
            bool estaregistrado = true;
            string nombreDeUsuario = "";
            Console.WriteLine("Por favor, ingrese su nombre de usuario");
            nombreDeUsuario = Console.ReadLine();
            if(estaregistrado)
            {
                Console.WriteLine("Hola usuario registrado");
                if(nombreDeUsuario != "")
                {
                    Console.WriteLine("Hola " + nombreDeUsuario);
                    if (nombreDeUsuario.Equals("Admin"))
                    {
                        Console.WriteLine("Hola Admin");
                    }
                }

            }
            Console.Read();
        }
     
    }
}

