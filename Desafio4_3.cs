using System;

namespace Desafio4_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Vamos a jugar! \n Para ganar necesitas cumplir una de las siguientes condiciones: \n" +
                "-Debes obtener 100 o más puntos \n -Si sacas 12 y en el turno siguiente sacas 10 \n " +
                "Ten en cuenta que después del tercer turno si sacas un número impar pierdes");
            int dado = 0, puntuación = 0, dadoAnterior = 0, turno = 0;
            string continuar = "s";
            Random aleatorio = new Random();
            
            while(continuar == "s")
            {
                dado = aleatorio.Next(1, 13);                   /*int.Parse(Console.ReadLine())*/
                Console.WriteLine("El dado dió un: " + dado);   /*aleatorio.Next(1, 7)*/
                puntuación += dado;
                turno++;
                if (turno > 3)
                {
                    if(dado % 2 != 0) //Detectar si el número es par o no
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Has perdido, sacaste un número impar");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }
                if (puntuación >= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Has ganado, sacaste 100 o más");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                if(dadoAnterior == 12 && dado == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Has ganado, sacaste 12 y luego 10, tienes mucha suerte!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                Console.WriteLine("¿Deseas tirar de nuevo el dado? (s/n)");
                dadoAnterior = dado;
                continuar = Console.ReadLine();
            }
        }
    }
}
