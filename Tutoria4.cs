using System;

namespace Tutoria4
{
    class Program
    {
        static void Main()
        {
            //Entradas
            Console.WriteLine("Ingrese el numero de votos por el partido a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos por el partido b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos en blanco");
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de población");
            int poblacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de población votante");
            double porcentaje_votacion = double.Parse(Console.ReadLine());
            int mayores = (int)(poblacion * (porcentaje_votacion/100));
            int abstencion = mayores - (a + b + blanco + anulados);

            //Programa
            bool A = anulados < ((a + b) * 30.0 / 100);
            bool B = a + b > blanco;
            bool C = abstencion < a + b + blanco + anulados;

            if((A||B)&& C)
            {
                Console.WriteLine("Votaciones exitosas");
                if(a > b)
                {
                    Console.WriteLine("Ganó el partido a");
                }
                else
                {
                    Console.WriteLine("Ganó el partido b");
                }
            }
            else
            {
                Console.WriteLine("La elecciones deben repetirse");
            }
        }
    }
}
