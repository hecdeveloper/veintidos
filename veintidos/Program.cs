using System;
using veintidos;

namespace  Clases
{
    class Program
    {
 
        static void Main(string[] args)
        {
            //CREA UN OBJ DESDE MI CLASE    
            Humano juan = new Humano();
            //acceder a una variable
            juan.primerNombre = "Juan";
            //llama a un method
            juan.presentarme();

            Humano pedro = new Humano();
            pedro.presentarme();
            Console.Read();

        } 

     

    }
}

