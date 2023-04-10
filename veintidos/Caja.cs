using System;
namespace veintidos
{
	public class Caja
	{
		//Miembros Variables
		private int largo;
		public int alto;
		public int ancho;
		public int volumen;

		//Miembro method
		public void MuestraInfo()
		{
			Console.WriteLine("El largo es {0}. La altura es {1}.El ancho es{2}.Por lo tanto el volumen es {3}"
				, largo, alto, ancho, volumen = ancho * alto * largo);
		}

		public void SetLargo(int largo)
		{
			this.largo = largo;
		}

		public int GetLargo()
		{
			return this.largo;
		}
	}
}

