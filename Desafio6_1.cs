using System;

namespace Desafio6_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Juguemos! \nDebes alzanar una de las siguientes condiciones para ganar: \n" +
            "-Debes llegar a 100 puntos (o más) \nAdemás ten en cuenta que pierdes una vida si sacas dos veces uno (1)\n");
            string continuar = "s", usarDado = "";
            Random aleatorio = new Random();
            int dado1 = 0, dadoEspecial = 0, puntos = 0, turno = 1, vidas = 3, uno = 0, dadoAnterior = 0, especialesRestantes = 2;
            ///Modo trampa
            //int.Parse(Console.ReadLine());-------------- aleatorio.Next(1, 7);
            while (continuar == "s")
            {
                Console.WriteLine("Turno " + turno);               
                if(especialesRestantes > 0)
                {
                    Console.WriteLine("Desea usar su dado especial? (s/n)");
                    usarDado = Console.ReadLine();
                    if (usarDado != "s" && usarDado != "n")                                                 //Validación de usar dado especial
                    {
                        Console.WriteLine("Respuesta invalida, intente de nuevo");
                        Console.WriteLine("Desea usar su dado especial? (s/n)");
                        usarDado = Console.ReadLine();
                    }
                    if (usarDado == "s")
                    {
                        dadoEspecial = aleatorio.Next(1, 13);           
                        puntos += dadoEspecial;
                        especialesRestantes--;
                        if (uno == 2)                                                                       //Cuando ya sacaste 2 uno (1)
                        {
                            vidas -= 1;
                            puntos -= 10;
                            uno = 0;
                        }
                        Console.WriteLine("Tu dado fue " + dadoEspecial + " Puntuación: " + puntos + " Te quedan " + vidas + " vidas");
                    }
                }
                else                                                                                        //Cuando ya no tiene dados especiales
                {
                    usarDado = "n";
                }

                if (usarDado == "n")
                {
                    dado1 = aleatorio.Next(1, 7);
                    puntos += dado1;
                    if (uno == 2)                                                                           //Cuando ya sacaste 2 uno (1)
                    {
                        vidas -= 1;
                        puntos -= 10;
                        uno = 0;
                    }
                    Console.WriteLine("Tu dado fue " + dado1 + " Puntuación: " + puntos + " Te quedan " + vidas + " vidas");
                }
                
                if (puntos >= 100)                                                                          //Condición de victoria
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Has ganado, llegaste a 100 o más puntos");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }

                if(dado1 == 1 || dadoEspecial == 1)                                                         //Añadir contador a cantidad de unos (1)
                {
                    uno++;                   
                }

                if(vidas < 3)                                                                               //Seguro de que no se pasé de 3 vidas
                {
                    if (dadoAnterior == 6 && dado1 == 6 || dadoAnterior == 6 && dadoEspecial == 6)          //Añadir vidas
                    {
                        vidas++;
                    }
                }

                if(vidas == 0)                                                                              //Condición de perdida
                {
                    Console.WriteLine("Has perdido, te quedaste sin vidas");
                    break;
                }

                Console.WriteLine("¿Deseas tirar de nuevo? (s/n)");
                dadoAnterior = dado1;
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
