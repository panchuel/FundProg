using System;

namespace Calculo_cuota_moderadora
{
    class Program
    {
        static void Main()
        {
            //Video: https://youtu.be/r4FYPRYNr0U
            //Entradas
            int smmv = 908526;
            Console.WriteLine("Ingrese su salario");
            int salario = int.Parse(Console.ReadLine());

            //Calculo de tarifas
            if (salario <= smmv * 2)
            {
                Console.WriteLine("A usted le corresponde la tarifa A");
            }
            else if (salario > smmv * 2 && salario < smmv * 5)
            {
                Console.WriteLine("A usted le corresponde la tarifa B");
            }
            else
            {
                Console.WriteLine("A usted le corresponde la tarifa C");
            }
        }
    }
}
