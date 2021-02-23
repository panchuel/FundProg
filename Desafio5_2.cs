using System;

namespace Desafio5_2
{
    class Program
    {
        static void Main()
        {
            double x = 3, resultado = 0;
            Console.WriteLine("Ingrese el valor de n");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                resultado += (Math.Pow(x, i)/Factorial(i));
                Console.WriteLine("\nIteración: " + (i + 1));
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
