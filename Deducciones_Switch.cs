using System;

namespace Deducciones_Switch
{
    class Program
    {
        static void Main()
        {
            //Video: https://youtu.be/VK6qa8SN2kk
            //Entradas
            Console.WriteLine("Ingrese su salario");
            int salario_mensual = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de contrato: (1) para dependiente, (2) para independiente");
            int tipo_contrato = int.Parse(Console.ReadLine());

            //Base de cotización
            double base_de_cotizacion = salario_mensual * 0.4;
            if (base_de_cotizacion < 877803)
            {
                base_de_cotizacion = 877803;
                //salario minimo del 2020, nos hubiera dicho que era con ese desde antes :c
            }
            //Deducciones    
            double pension = 0;
            double eps = 0;
            double arl = 0;
            double deducciones = 0;
            double salario_real_mensual = 0;
            double salario_anual = 0;
            int bonificaciones = 0;
            int riesgoLaboral = 0;
            //Proceso
            switch (tipo_contrato)
            {
                case 1:
                    pension = 0.04;
                    eps = 0.04;
                    bonificaciones = salario_mensual;
                    break;

                case 2:
                    pension = 0.16;
                    eps = 0.125;
                    Console.WriteLine("Ingrese el riesgo laboral de 1 a 5: ");
                    riesgoLaboral = int.Parse(Console.ReadLine());
                    switch (riesgoLaboral)
                    {
                        case 1:                            
                            arl = 0.00522;
                            break;
                        case 2:
                            arl = 0.010144;
                            break;
                        case 3:
                            arl = 0.02436;
                            break;
                        case 4:
                            arl = 0.04350;
                            break;
                        case 5:
                            arl = 0.06960;
                            break;                           
                    }
                    break;                      
            }
            deducciones = base_de_cotizacion * (eps + pension + arl);
            salario_real_mensual = salario_mensual - deducciones;
            Console.WriteLine("Su salario mensual real es: " + salario_real_mensual);
            salario_anual = (salario_real_mensual * 12) + bonificaciones;
            Console.WriteLine("Su salario anual es: " + salario_anual);
        }
    }
}
