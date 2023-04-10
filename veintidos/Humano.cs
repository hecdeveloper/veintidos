﻿using System;
namespace veintidos
{
	public class Humano
	{
		//miembro variable
		public string primerNombre;
		public string apellido;
		private int edad;
		private string colorOjos;

		//constructor por defecto
		public Humano()
		{
			Console.WriteLine("Constructor llamado. Objeto Creado");
		}


		//miembro constructor
		public Humano(string primerNombre, string apellido, int edad, string colorOjos)
		{
			this.primerNombre = primerNombre;
			this.apellido = apellido;
			this.edad = edad;
			this.colorOjos = colorOjos;
		}

        public Humano(string primerNombre, string apellido, string colorOjos)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
        }


        //miembro method
        public void presentarme()
		{
			if (edad != 0)
            Console.WriteLine("Hola, soy {0} {1} y tengo {2} anyo. Mi color de ojos es {3}"
				, primerNombre, apellido, edad, colorOjos);
			else
                Console.WriteLine("Hola, soy {0} {1}. Mi color de ojos es {2}"
            , primerNombre, apellido, colorOjos);
        }


	}
}
 
