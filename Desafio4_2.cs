using System;

namespace Desafio4_2
{
    class Program
    {
        static void Main()
        {            
            //Video: https://youtu.be/ND-A_qiYHXg
            
            Console.WriteLine("Juguemos! \nDebes alzanar una de las siguientes condiciones para ganar: \n" +
            "-Debes llegar a 100 puntos (o más) \n-Si sacas 3 dados dobles seguidos \nAdemás ten en cuenta que pierdes" +
            "si ambos dados son uno (1) \n\n");
            double porcentajeMayor6 = 0, turno = 1, turnosDe6 = 0;
            string continuar = "s";
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, puntos = 0, dobles = 0;

            while(continuar == "s")
            {
                dado1 = aleatorio.Next(1, 7);                      /*int.Parse(Console.ReadLine())*/
                dado2 = aleatorio.Next(1, 7);                      /*aleatorio.Next(1, 7)*/
                puntos += dado1 + dado2;
                turno++;
                Console.WriteLine("Tus dados fueron "+ dado1 + " y " + dado2 + " Puntuación: " + puntos);
                if(puntos >= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Has ganado, llegaste a 100 o más puntos");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                if(dado1 == dado2)
                {
                    dobles++;
                    if(dobles == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Has ganado porque sacaste 3 pares seguidos, IDOLO!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
                else
                {
                    dobles = 0;
                }
                if(dado1 + dado2 > 6)
                {
                    turnosDe6++;
                }              
                if(dado1 == 1 && dado2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Has perdido, ambos dados fueron 1");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                porcentajeMayor6 = Math.Round((turnosDe6 / turno) * 100, 2);

                Console.WriteLine("¿Deseas tirar de nuevo? (s/n)");
                continuar = Console.ReadLine();
            }            
            Console.WriteLine("El porcentaje de turnos donde sacaste más de 6 fue: " + porcentajeMayor6 + "%");
            Console.WriteLine("Gracias por jugar, tu puntuación fue: " + puntos);            
        }
    }
}
