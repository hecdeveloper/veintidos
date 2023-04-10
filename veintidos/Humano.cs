using System;
namespace veintidos
{
	public class Humano
	{
		//miembro variable
		public string primerNombre;
		public string apellido;
		private int edad;
		private string colorOjos;

		//miembro constructor
		public Humano(string primerNombre, string apellido, int edad, string colorOjos)
		{
			this.primerNombre = primerNombre;
			this.apellido = apellido;
			this.edad = edad;
			this.colorOjos = colorOjos;
		}


		//miembro method
		public void presentarme()
		{
			if (edad == 1)
            Console.WriteLine("Hola, soy {0} {1} y tengo {3} anyo. Mi color de ojos es {2}"
				, primerNombre, apellido, colorOjos, edad);
			else
                Console.WriteLine("Hola, soy {0} {1} y tengo {3} anyos. Mi color de ojos es {2}"
           , primerNombre, apellido, colorOjos, edad);
        }


	}
}
 
