using System;

class Program
{
    //Programa 3
	static void Main()
    {
		//Entradas
		Console.WriteLine("Agregue el valor de z");
		double z = double.Parse(Console.ReadLine());

		Console.WriteLine("Agregue el valor de c");
		double c = double.Parse(Console.ReadLine());

		//Angulo a
		double a = 180 - 90 - c;
		Console.WriteLine("El angulo a es " + a);

		//Cambio a radianes
		c = c * Math.PI / 180;
		a = a * Math.PI / 180;

		//Para el lado y (aplicando ley de seno)
		double y = z * Math.Sin(a) / Math.Sin(c);
		Console.WriteLine("El lado y es " + y);

		//Para la hipotenusa (usando pitagoras)
		double t = Math.Sqrt((z * z) + (y * y));
		Console.WriteLine("La hipotenusa es " + t);	
	}
}


