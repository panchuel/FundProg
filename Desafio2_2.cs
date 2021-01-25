using System;

 class Program
{
	//Programa 2
	public static void Main()
	{
		//Entradas
		Console.WriteLine("Agregue el valor de t");
		double t = double.Parse(Console.ReadLine());

		Console.WriteLine("Agregue el valor de a");
		double a = double.Parse(Console.ReadLine());

		//Angulo c
		double c = 180 - 90 - a;
		Console.WriteLine("El angulo a es " + c);

		//Para el lado z (aplicando ley de seno)
		double z = t * Math.Sin(a);
		Console.WriteLine("El lado z es " + z);

		//Para el lado  y 
		double y = Math.Sqrt((t * t) - (z * z));
		Console.WriteLine("EL lado y es " + y);
	}
}
