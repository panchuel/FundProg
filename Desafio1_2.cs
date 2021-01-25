using System;

class Program
{
    static void Main()
    {
        //Entradas

            //Para b
            Console.WriteLine("Ingrese b");
            double b = double.Parse(Console.ReadLine());
            //Para d
            Console.WriteLine("Ingrese d");
            double d = double.Parse(Console.ReadLine());
            //Para y       
            Console.WriteLine("Ingrese y");
            double y = double.Parse(Console.ReadLine());

        //Procedimeinto 

            //para encontrar a
            double a = 180 - 90 - b - d;
            Console.WriteLine("El valor de a es: " + a);            
            //para encontrar c
            double c = 180 - 90 - a;
            Console.WriteLine("El valor de c es: " + c);
            double cR = c * (Math.PI / 180);
            //para encontrar z
            double z = Math.Tan(cR) * y;
            
        //Salida
            Console.WriteLine("El valor de z es: " + z);
    }
}
