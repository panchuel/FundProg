using System;

class Program
{
    //Programa 3
	static void Main()
    {
		//Entradas
			//Para z
			Console.WriteLine("Agregue el valor de z");
			double z = double.Parse(Console.ReadLine());
			//Para c
			Console.WriteLine("Agregue el valor de c");
			double c = double.Parse(Console.ReadLine());

		//Procedimiento
			//Angulo a
			double a = 180 - 90 - c;
			//Cambio a radianes
			cR = c * Math.PI / 180;
			aR = a * Math.PI / 180;
			//Para el lado y (aplicando ley de seno)
			double y = z * Math.Sin(aR) / Math.Sin(cR);
			//Para la hipotenusa (usando pitagoras)
			double t = Math.Sqrt((z * z) + (y * y));			
		
		//Salida
			//Para a
			Console.WriteLine("El angulo a es " + a);
			//Para y
			Console.WriteLine("El lado y es " + y);
			//Para t
			Console.WriteLine("La hipotenusa es " + t);
	}
}


