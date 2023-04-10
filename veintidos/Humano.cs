using System;
namespace veintidos
{
	public class Humano
	{
		//miembro variable
		public string primerNombre;
		public string apellido;

		//miembro constructor
		public Humano(string miPrimerNombre, string apellido)
		{
			primerNombre = miPrimerNombre;
			this.apellido = apellido;
		}


		//miembro method
		public void presentarme()
		{

			Console.WriteLine("Hola, soy {0} {1}", primerNombre, apellido);
		}


	}
}

