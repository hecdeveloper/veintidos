using System;
namespace veintidos
{
	public class Humano
	{
		//miembro variable
		public string primerNombre;
		public string apellido;
		private string colorOjos;
		private int edad;

		//miembro constructor
		public Humano(string primerNombre, string apellido, string colorOjos, int edad)
		{
			this.primerNombre = primerNombre;
			this.apellido = apellido;
			this.colorOjos = colorOjos;
			this.edad = edad;
		}


		//miembro method
		public void presentarme()
		{

            Console.WriteLine("Hola, soy {0} {1} y tengo {2}. Mi color de ojos es {3}"
				, primerNombre, apellido, colorOjos, edad);
		}


	}
}
 
