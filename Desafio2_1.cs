using System;

public class Program2
{
	public static void Main()
	{
		//Programa 1

		//Entradas
		Console.Write("Agregue el valor de t");
		double t = double.Parse(Console.ReadLine());

		Console.Write("Agregue el valor de a");
		double a = double.Parse(Console.ReadLine());

		//Angulo c
		double c = 180 - 90 - a;
		Console.WriteLine("El angulo a es " + a);

		//Para el lado z (aplicando ley de seno)

	}
}
