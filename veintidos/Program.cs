using System;

namespace veintidos
{
    class Program
    {
        static string? nombreDeUsuario;
        static string? clave;
        static void Main(string[] args)
        {
            Registro();
            Ingreso();
            Console.Read();
        }
        public static void Registro()
        {
            Console.WriteLine("Ingrese su nombre");
            nombreDeUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese su clave");
            clave = Console.ReadLine();
            Console.WriteLine("Registro exitoso");
            Console.WriteLine("--------------------");
        }
        public static void Ingreso()
        {
            Console.WriteLine("Ingrese su nombre");
            if (nombreDeUsuario == Console.ReadLine())
            {
                Console.WriteLine("Ingrese su clave");
                if (clave == Console.ReadLine())
                {
                    Console.WriteLine("Ingreso exitoso");
                }
                else
                {
                    Console.WriteLine("Clave incorrecta");
                }
            }
            else
            {
                Console.WriteLine("Usuario incorrecto");
            }
        }
    }
}

