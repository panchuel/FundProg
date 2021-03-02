using System;

namespace Desafio6_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Juguemos! \nDebes alzanar una de las siguientes condiciones para ganar: \n" +
            "-Debes llegar a 100 puntos (o más) \nAdemás ten en cuenta que pierdes una vida si sacas dos veces uno (1)\n");
            string continuar = "s";
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, puntos = 0, turno = 1, vidas = 3;
            ///Modo trampa
            //int.Parse(Console.ReadLine());-------------- aleatorio.Next(1, 7);
            while (continuar == "s")
            {
                Console.WriteLine("Turno " + turno);               
                
                if (turno % 2 == 0)                                                                             //Turno para perder vida
                {
                    vidas -= 1;
                }
                
                if(turno % 3 != 0)                                                                              //Verifica que sea turno multiplo de 3
                {
                    dado1 = aleatorio.Next(1, 7);
                    puntos += dado1;
                    Console.WriteLine("Tu dado fue " + dado1 + " Puntuación: " + puntos + " Te quedan " + vidas + " vidas");
                }

                else
                {
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    puntos += dado1 + dado2;
                    Console.WriteLine("Tu dado fue " + dado1 + " y " + dado2 + " Puntuación: " + puntos + " Te quedan " + vidas + " vidas");
                }              

                if (vidas < 3)                                                                                  //Seguro de que no se pasé de 3 vidas
                {
                    if (dado1 == dado2)                                                                         //Añadir vidas
                    {
                        vidas++;
                    }
                }

                if (vidas == 0)                                                                                  //Condición de perdida
                {
                    Console.WriteLine("Has perdido, te quedaste sin vidas");
                    break;
                }

                if (puntos >= 100)                                                                              //Condición de victoria
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Has ganado, llegaste a 100 o más puntos");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }

                Console.WriteLine("¿Deseas tirar de nuevo? (s/n)");
                continuar = Console.ReadLine();

                if (continuar != "s" && continuar != "n")
                {
                    Console.WriteLine("Respuesta invalida, intente de nuevo");
                    Console.WriteLine("Desea usar su dado especial? (s/n");
                    continuar = Console.ReadLine();
                }
                turno++;
            }
            Console.WriteLine("Gracias por jugar, tu puntuación fue: " + puntos);
        }
    }
}
