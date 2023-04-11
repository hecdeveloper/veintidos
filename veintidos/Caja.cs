using System;
namespace veintidos
{
	public class Caja
	{
		//Miembros Variables
		private int largo;
		private int alto;
		private int ancho;
		private   int volumen;

		public Caja(int largo, int alto, int ancho)
		{
			this.largo = largo;
			this.alto = alto;
			this.Ancho = ancho;

		}

		public int Volumen {
			set
			{
				volumen = value;
			}
			get
			{
				return Alto * Ancho * Largo;
			}
		}


		//Propiedad Auto Implementada
		public int Ancho { get; set; }
		public int Alto {
			get
			{
				return alto;
			}

			//set
			//{
			//	if (value < 0) value = -value; //throw new Exception("El size debe ser positivo");
			//	alto = value;
			//}
		}




		public int Largo
		{
			get => largo;
			set => largo = value;
		}

		//Miembro method
		public void MuestraInfo()
		{
			Console.WriteLine("El largo es {0}. La altura es {1}.El ancho es{2}.Por lo tanto el volumen es {3}"
				, largo, Alto, Ancho, volumen = ancho * alto * largo);
		}

		//public void SetLargo(int largo)
		//{
		//	this.largo = largo;
		//}

		//public int GetLargo()
		//{
		//	return this.largo;
		//}
	}
}

