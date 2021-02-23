using System;

namespace Desafio5_3
{
    class Program
    {
        static void Main()
        {
            double resultado = 0;
            Console.WriteLine("Ingrese el valor de x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de n:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                resultado += (Math.Pow(-1, i) / Factorial((2 * i) + 1) * Math.Pow(x, (2 * i) + 1));
                Console.WriteLine("\n Iteración: " + i);
                Console.WriteLine(resultado);
            }
        }

        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}
