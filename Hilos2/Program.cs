using System;
using System.Threading;

namespace Hilos2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Impresora impresora1 = new Impresora();
			Thread proceso1 = new Thread(new ParameterizedThreadStart(impresora1.imprimir));
			proceso1.Name = "Primer_Proceso";

			Impresora impresora2 = new Impresora();
			Thread proceso2 = new Thread(new ParameterizedThreadStart(impresora2.imprimir));
			proceso2.Name = "Segundo_Proceso";

			Impresora impresora3 = new Impresora();
			Thread proceso3 = new Thread(new ParameterizedThreadStart(impresora3.imprimir));
			proceso3.Name = "Tercer_Proceso";

			Console.WriteLine("Iniciando procesos...\n");
			proceso1.Start(5);
			proceso2.Start(10);
			proceso3.Start(15);

			Console.WriteLine("\nProcesos iniciados");

			Console.ReadKey();
		}
	}
}
