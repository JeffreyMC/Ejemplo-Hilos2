using System;
using System.Threading;

namespace Hilos2
{
	public class Impresora
	{
		//creo un objeto Random
		private static Random aleatorio = new Random();
		//este entero es para pasarle un valor aleatorio
		int inactividad;

		//constructor de la clase
		//asigna un número aleatorio a la variable inactividad
		//como se está trabajando con milisegundos, hay que saber que
		// un segundo equivale a 1000 milisegundos
		//entonces el random generará un aleatorio entre 1 y 10 segundos
		public Impresora()
		{
			inactividad = 1000 + aleatorio.Next(10000);
		}

		//Función que imprime los procesos
		//aquí se ingresan los números que pasé en el main
		//OJO el método Start con paŕámetro (requiere un Object)
		//por eso no puse del tipo Int
		public void imprimir(object x)
		{
			//obtiene el hilo actual
			Thread actual = Thread.CurrentThread;


			//imprime el nombre del hilo, más su tiempo de inactividad
			Console.WriteLine("{0} va a estar inactivo por {1} segundos"
				, actual.Name, (inactividad / 1000));

			//Imprime el número ingresado
			Console.WriteLine("El número ingresado es: {0}", x);

			// 'duerme' al hilo por el valor de la variable inactividad
			// recuerde que es un aleatorio entre 1 a 10 segundos
			Thread.Sleep(inactividad);

			//indica cuando sale el hilo, es decir cuando dejó de estar inactivo
			Console.WriteLine("{0} dejó de estar inactivo", actual.Name);
		}
	}
}

