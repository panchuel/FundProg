using System;

class Program
{
	static void Main(string[] args)
	{
		//Entradas
			//Para y
			Console.WriteLine("Agregue el valor de y");
			double y = double.Parse(Console.ReadLine());
			//Para z
			Console.WriteLine("Agregue el valor de z");
			double z = double.Parse(Console.ReadLine());

		//Proceso
			//Para encontrar t
			double t = Math.Sqrt((y * y) + (z * z));
			//Para encontrar a usamos ley del seno y seno inverso
			double aR = Math.Asin(y / t);
			double a = aR * (180 / Math.PI);
			//Para encontrar c
			double c = 180 - 90 - a;

		//Salidas
			//Para t
			Console.WriteLine("El valor de t es: " + t);
			//Para a
			Console.WriteLine("El valor del angulo a es: " + a);
			//Para c
			Console.WriteLine("El valor del angulo c es: " + c);
	}
}
