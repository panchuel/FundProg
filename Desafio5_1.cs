using System;

namespace Desafio5_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido, juguemos");
            Random aleatorio = new Random();
            string continuar = "s";
            int carta = 0, total = 0, totalReal = 0, jugador = 0, jugadorMayor = 0, totalMaximo = 0, n = 0;
            Console.WriteLine("Igrese el numero de jugadores entre 2 y 5");
            n = int.Parse(Console.ReadLine());
            while (n < 2 || n > 5)
            {
                Console.WriteLine("Valor invalido, intente de nuevo");
                Console.WriteLine("Igrese el numero de jugadores entre 2 y 5");
                n = int.Parse(Console.ReadLine());
            }
            while(jugador < n)
            {
                Console.WriteLine("Bienvenido jugador " + (jugador + 1) + "!");
                int carta1 = aleatorio.Next(1, 11), carta2 = aleatorio.Next(1, 11);
                Console.WriteLine("Sus cartas son: " + carta1 + " y " + carta2);
                while (totalReal < 21 && continuar == "s")
                {                    
                    Console.WriteLine("¿Toma otra carta? (s/n): ");
                    continuar = Console.ReadLine();                                                        
                    if(continuar != "s" && continuar != "n")
                    {
                        Console.WriteLine("Respuesta invalida, intentelo de nuevo");
                        Console.WriteLine("¿Toma otra carta? (s/n): ");
                        continuar = Console.ReadLine();
                    }
                    if (continuar == "s")
                    {
                        carta = aleatorio.Next(1, 11);
                        total += carta;
                        totalReal = total + carta1 + carta2;
                    }
                    if (continuar == "n")
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
                    if (totalReal > 21)
                    {
                        Console.WriteLine("Carta = " + carta);
                        Console.WriteLine("Eliminado");
                        totalMaximo = 0;
                        break;
                    }
                    Console.WriteLine("Carta = " + carta);
                    Console.WriteLine("Puntos totales = " + totalReal);
                }
                Console.WriteLine("Gracias por participar \n");                
                if(totalReal > 21)
                {
                    totalReal = 0;
                }
                if(jugador == 0)
                {
                    totalMaximo = totalReal;
                    jugadorMayor = jugador;
                }
                if(totalReal > totalMaximo)
                {
                    totalMaximo = totalReal;
                    jugadorMayor = jugador;
                }
                total = 0;
                totalReal = 0;
                continuar = "s";
                jugador++;
            }
            Console.WriteLine("El jugador con el máximo puntaje es el jugador " + (jugadorMayor + 1) + " con un puntaje de: " + totalMaximo);            
        }
    }
}
