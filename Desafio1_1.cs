using System;

class Program
{
    static void Main()
    {
        //Video: https://youtu.be/daPWcnzhZ2M
        
        //Entradas 

            //Para b
            Console.WriteLine("Ingrese el valor de B");
            double b = double.Parse(Console.ReadLine());
            //Para z
            Console.WriteLine("Ingrese el valor de Z");
            double z = double.Parse(Console.ReadLine());
            //Para y
            Console.WriteLine("Ingrese el valor de Y");
            double y = double.Parse(Console.ReadLine());

        //Procedimiento

            //Convertir de grados a radianes
            double bR = b * (Math.PI / 180);
            //Para encontrar a realizamos tangente inversa con Y y Z
            double aR = Math.Atan(y / z);
            double a = aR * 180 / Math.PI;
            Console.WriteLine("El angulo a es: " + a);
            //Para encontrar el x
            double x = Math.Tan(aR + bR) * z - y;

        //Salidas

            Console.WriteLine("El valor de x es: " + x);
    }
}
