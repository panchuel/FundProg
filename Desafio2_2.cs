using System;

 class Program
{
	//Programa 2
	public static void Main()
	{
		//Entradas
			//Para t
			Console.WriteLine("Agregue el valor de t");
			double t = double.Parse(Console.ReadLine());
			//Para a
			Console.WriteLine("Agregue el valor de a");
			double a = double.Parse(Console.ReadLine());

		//Procedimiento
			//Angulo c
			double c = 180 - 90 - a;			
			//Para el lado z (aplicando ley de seno)
			double z = t * Math.Sin(a);			
			//Para el lado  y 
			double y = Math.Sqrt((t * t) - (z * z));			
		
		//Salida
			//Para el angulo c
			Console.WriteLine("El angulo a es " + c);
			//Para z
			Console.WriteLine("El lado z es " + z);
			//Para el lado y
			Console.WriteLine("EL lado y es " + y);
	}
}
