using System;

class Program
{
    static void Main()
    {
        //Video https://youtu.be/8iYWxngcguU
        //Entradas 
            Console.WriteLine("Ingrese w, d°, x:");
            //Para w
            double w = double.Parse(Console.ReadLine());
            //Para d
            double d = double.Parse(Console.ReadLine());
            //Para x
            double x = double.Parse(Console.ReadLine());

        //Convertir angulos a radianes
            double dR = d * (Math.PI / 180);

        //Procedimiento

            //Para encontrar y
            double y = Math.Cos(dR) * w - x;

        //Salidas
            Console.WriteLine("El valor de y es: " + y);
    }
}
