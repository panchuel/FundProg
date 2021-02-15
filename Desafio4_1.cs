using System;

namespace Desafio4_1
{
    class Program
    {
        static void Main()
        {
            double total = 0;
            Console.WriteLine("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 0;
            string nombre = "", nombreMenor = "", nombreMayor = "";

            while (i < n)
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nombre");
                nombre = Console.ReadLine();                
                if (i == 0)
                {
                    max = edad;
                    min = edad;
                }
                if (edad > max)
                {
                    max = edad;
                    nombreMayor = nombre;
                }
                if (edad < min)
                {
                    min = edad;
                    nombreMenor = nombre;
                }
                total += edad;
                i++;
            }
            double promedio = total / n;
            Console.WriteLine("Promedio = " + promedio);
            Console.WriteLine("Mayor = " + nombreMayor + " con " + max + " años");
            Console.WriteLine("Menor = " + nombreMenor + " con " + min + " años");
        }
    }
}
