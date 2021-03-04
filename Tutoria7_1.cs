using System;

namespace Tutoria7
{
    class Program
    {
        static void Main()
        {
            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };
            double actual = 0, siguente = 0;
            string nombreActual = "", nombreSiguiente = "";
            bool arreglo = false;

            while(!arreglo)
            {
                for (int i = 0; i < estatura.Length - 1; i++)
                {
                    actual = estatura[i];
                    nombreActual = nombres[i];
                    siguente = estatura[i + 1];
                    nombreSiguiente = nombres[i + 1];

                    if (estatura[i] > estatura[i + 1])
                    {
                        estatura[i] = siguente;
                        nombres[i] = nombreSiguiente;
                        estatura[i + 1] = actual;
                        nombres[i + 1] = nombreActual;
                    }
                }

                for (int i = 0; i < estatura.Length - 1; i++)
                {
                    if(estatura[i] < estatura[i + 1])
                    {
                        arreglo = true;
                    }
                    else
                    {
                        arreglo = false;
                        break;
                    }
                }
            }
            

            for (int i = 0; i < estatura.Length; i++)
            {
                Console.WriteLine(estatura[i] + " " + nombres[i]);
            }
        }
    }
}
