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
            if(estaregistrado && nombreDeUsuario != "" && nombreDeUsuario.Equals("Admin"))
            {
                Console.WriteLine("Hola usuario registrado");
             
                Console.WriteLine("Hola " + nombreDeUsuario);
                    
                 Console.WriteLine("Hola Admin"); 
            }
            if(esAdmin || estaregistrado)
            {
                Console.WriteLine("Estas Logueado");
            }
            Console.Read();
        }
     
    }
}

