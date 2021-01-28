using System;

namespace Tutoria1
{
    class Program
    {
        static void Main()
        {
            //Entradas
            // Entrada del usuario de la variable X1
            Console.Write("Ingrese X1: ");
            double x1 = double.Parse(Console.ReadLine());

            // Entrada del usuario de la variable Y1
            Console.Write("Ingrese Y1: ");
            double y1 = double.Parse(Console.ReadLine());
            
            // Entrada del usuario de la variable X2
            Console.Write("Ingrese X1: ");
            double x2 = double.Parse(Console.ReadLine());

            // Entrada del usuario de la variable Y2
            Console.Write("Ingrese Y1: ");
            double y2 = double.Parse(Console.ReadLine());

            ///La formula de pendiente es y= mx+b
            /// y = y1 y x = x1
            //para encontrar m 
            double m = (y1 - y2) / (x1 - x2);
            Console.WriteLine("el valor de m es " + m);
            //para encontrar b
            double b = y1 - (m * x1);
            Console.WriteLine("el valor de b es " + b);
            //para distancia 
            double x = x1 - x2;
            double y = y1 - y2;
            double d = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine("la distancia es " + d);
        }
    }
}
