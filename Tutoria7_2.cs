using System;

namespace Tutoria7_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Juguemos Black Jack!!");
            Random aleatorio = new Random();
            string continuar = "s";
            int carta = 0, total = 0, totalReal = 0, n = 0, actualPuntaje = 0, siguientePuntaje = 0;
            string nombrePrimero = "", nombreSegundo = "";
            Console.WriteLine("Ingrese el numero de jugadores entre 2 y 5");
            n = int.Parse(Console.ReadLine());
            string[] nombres = new string[n];
            int[] puntajes = new int[n];

            while (n < 2 || n > 5)                                                          //Validación
            {
                Console.WriteLine("Valor invalido, intente de nuevo");
                Console.WriteLine("Igrese el numero de jugadores entre 2 y 5");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)                                                     //Cantidad de jugadores
            {
                Console.WriteLine("Ingrese el nombre del jugador " + (i + 1));
                nombres[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)                                                     //Juego
            {
                Console.WriteLine("Bienvenido " + nombres[i]);
                int carta1 = aleatorio.Next(1, 11), carta2 = aleatorio.Next(1, 11);
                Console.WriteLine("Sus cartas son: " + carta1 + " y " + carta2);
                totalReal = (carta1 + carta2);
                Console.WriteLine("¿Toma otra carta? (s/n): ");
                continuar = Console.ReadLine();
                while (totalReal < 21 && continuar == "s")                                  //Condición de continuar jugando
                {                   
                    
                    if (continuar != "s" && continuar != "n")                               //Validación de responder bien al continuar
                    {
                        Console.WriteLine("Respuesta invalida, intentelo de nuevo");
                        Console.WriteLine("¿Toma otra carta? (s/n): ");
                        continuar = Console.ReadLine();
                    }
                    if (continuar == "s")                                                   //Continuar
                    {
                        carta = aleatorio.Next(1, 11);
                        totalReal += carta;
                        
                    }
                    if (continuar == "n")                                                   //Retirarse
                    {
                        Console.WriteLine("Retirado");
                        totalReal += carta;
                        break;
                    }
                    if (totalReal == 21)                                                    //Ganar
                    {
                        Console.WriteLine("Carta = " + carta);
                        Console.WriteLine("Ganaste");
                        
                        break;
                    }
                    if (totalReal > 21)                                                     //Perder
                    {
                        Console.WriteLine("Carta = " + carta);
                        Console.WriteLine("Eliminado");
                        totalReal = 0;
                        break;
                    }
                    Console.WriteLine("Carta = " + carta);
                    Console.WriteLine("Puntos totales = " + totalReal);
                    Console.WriteLine("¿Toma otra carta? (s/n): ");
                    continuar = Console.ReadLine();
                }
                puntajes[i] = totalReal;
                Console.WriteLine("Gracias por participar \n");
            }

            for (int i = 0; i < n; i++)                                                     //Bubble short
            {
                for (int o = 0; o < puntajes.Length - 1; o++)
                {
                    actualPuntaje = puntajes[o];
                    nombrePrimero = nombres[o];
                    siguientePuntaje = puntajes[o + 1];
                    nombreSegundo = nombres[o + 1];

                    if(puntajes[o] < puntajes[o + 1])
                    {
                        puntajes[o] = siguientePuntaje;
                        nombres[o] = nombreSegundo;
                        puntajes[o + 1] = actualPuntaje;
                        nombres[o + 1] = nombrePrimero;
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine((i + 1) + " puesto es para " + nombres[i] + " con " + puntajes[i]);
            }
        }
    }
}
