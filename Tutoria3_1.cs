using System;

namespace Tutoria3_1
{
    class Program
    {
        //Indice de masa corporal (IMC)             
        static void Main()
        {
            //Entradas
            Console.WriteLine("Ingrese su peso en Kg");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su altura en metros");
            double altura = double.Parse(Console.ReadLine());

            //Proceso
            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Su imc es " + imc + " y se encuentra bajo de peso");
            }
            if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Su imc es " + imc + " y se encuentra en un peso normal");
            }
            if(imc >= 25 && imc < 35)
            {
                Console.WriteLine("Su imc es " + imc + " y se encuentra con sobrepeso");
            }
            if(imc >= 35)
            {
                Console.WriteLine("su imc es " + imc + "y se encuentra con obesidad");
            }
        }
    }
}
