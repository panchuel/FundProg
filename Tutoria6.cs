using System;

namespace Tutoria6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };
            double total = 0, promedio = 0, cercano = 100;
            int indice = 0;
            double[] distancia = new double[nombres.Length];
            for (int i = 0; i < estatura.Length; i++)
            {
                total += estatura[i];
                Console.WriteLine(total);
            }

            promedio = total / estatura.Length;
            Console.WriteLine("El promedio de alturas es: " + promedio);

            for (int i = 0; i < estatura.Length; i++)
            {
                distancia[i] = Math.Abs(promedio - estatura[i]);
                Console.WriteLine(distancia[i]);

                if(distancia[i] < cercano)
                {
                    cercano = distancia[i];
                    indice = i;
                }
            }
            Console.WriteLine("El más cercano al promedio es " + nombres[indice] + " con " + estatura[indice]);
        }
    }
}
