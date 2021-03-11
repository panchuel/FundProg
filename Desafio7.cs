using System;

namespace Desafio7
{
    class Program
    {
        static void Main()
        {
            //Video: https://youtu.be/4_JP6_QLKPY
            int vecesEncontrada = 0;
            string frase = "", palabra = "";
            
            Console.WriteLine("Ingrese la frase deseada");              //Ingreso de frase
            frase = Console.ReadLine();
            frase = frase.ToUpper();

            Console.WriteLine("Ingresa la palabra a buscar");           //Ingreso de palabra a buscar
            palabra = Console.ReadLine();
            palabra = palabra.ToUpper();

            string[] palabrasTotales = frase.Split(" ");                //Separar la frase en un arreglo

            for (int i = 0; i < palabrasTotales.Length; i++)
            {
                if(palabrasTotales[i] == palabra)                       //Contar las veces encontrada la palabra
                {
                    Console.WriteLine("Palabra encontrada en la posición " + i);
                    vecesEncontrada++;
                }
            }
            Console.WriteLine("Veces encontrada: " + vecesEncontrada);
        }
    }
}
