using System;

class Program
{
    static void Main()
    {
        //Entradas 
            //Para w
            Console.WriteLine("Ingrese el valor de w: ");
            double w = double.Parse(Console.ReadLine());
            //Para t
            Console.WriteLine("Ingrese el valor de t: ");
            double t = double.Parse(Console.ReadLine());
            //Para c
            Console.WriteLine("Ingrese el valor de c°: ");
            double c = double.Parse(Console.ReadLine());

        //Procedimientos
            //Pasar c a Radianes
            double cR = c * (Math.PI / 180);
            //Para encontrar Y
            double y = Math.Cos(cR) * t;
            //Para encontrar Z
            double z = Math.Sin(cR) * t;
            //Para encontrar D
            double d = Math.Asin(z / w);           
            //Para encontrar X
            double x = (Math.Cos(d) * w) - y;

        //Salida
            Console.WriteLine("El valor de x es: " + x);    
    }
}
