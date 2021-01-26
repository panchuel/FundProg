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
			//Para el lado y (aplicando ley de seno)
			double aR = a * (Math.PI / 180);
			double y = t * Math.Sin(aR);			
			//Para el lado  z 
			double z = Math.Sqrt((t * t) - (y * y));			
		
		//Salida
			//Para el angulo c
			Console.WriteLine("El angulo a es " + c);
			//Para z
			Console.WriteLine("El lado z es " + z);
			//Para el lado y
			Console.WriteLine("EL lado y es " + y);
	}
}
