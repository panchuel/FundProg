using System;

namespace Tutoria3_2
{
    class Program
    {
        //Ecuaciones cuadraticas
        static void Main()
        {
            //Entradas
            Console.WriteLine("Ingrese a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese c");
            double c = double.Parse(Console.ReadLine());

            double d = (b * b) - (4 * a * c);
            //Proceso
            double x1;
            double x2;

            if(d == 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("La solución existe, es unica y el valor de x1 es " + x1 + " y el de x2 es: " + x2);
            }
            if(d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Existen dos posibles soluciones correctas y el valor de x1 es " + x1 + " y el de x2 es: " + x2);
            }
            if(d < 0)
            {
                Console.WriteLine("No es posible calcular la solución");
            }
        }
    }
}
