using System;

namespace BlackJack
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido, juguemos");            
            Random aleatorio = new Random();
            string continuar = "s";
            int carta = 0, total = 0, totalReal = 0;
            int carta1 = aleatorio.Next(1, 11), carta2 = aleatorio.Next(1, 11);
            Console.WriteLine("Sus cartas son: " + carta1 + " y " + carta2);
            while (total < 21 && continuar == "s")
            {
                Console.WriteLine("¿Toma otra carta? (s/n): ");
                continuar = Console.ReadLine();
                carta = aleatorio.Next(1, 11);
                total += carta;
                totalReal = total + carta1 + carta2;
                if (totalReal > 21)
                {
                    Console.WriteLine("Carta = " + carta);
                    Console.WriteLine("Eliminado");
                    total = 0;
                    break;
                }
                if (continuar != "s")
                {
                    Console.WriteLine("Retirado");
                    break;
                }
                if (totalReal == 21)
                {
                    Console.WriteLine("Carta = " + carta);
                    Console.WriteLine("Ganaste");
                    break;
                }
                Console.WriteLine("Carta = " + carta);
                Console.WriteLine("Puntos totales = " + totalReal);
            }
            Console.WriteLine("Gracias por participar");
        }
    }
}
