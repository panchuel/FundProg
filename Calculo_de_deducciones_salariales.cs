using System;

namespace Calculo_de_deducciones_salariales
{
    class Program
    {
        static void Main()
        {
            //Video https://youtu.be/g3dLZXjTo-M
            //Entradas
            Console.WriteLine("Ingrese su salario");
            int salario_mensual = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de contrato: (1) para dependiente, (2) para independiente");
            int tipo_contrato = int.Parse(Console.ReadLine());

                //Base de cotización
                    double base_de_cotizacion = salario_mensual * 0.4;
                    if(base_de_cotizacion < 877803)
                    {
                        base_de_cotizacion = 877803;
                        //salario minimo del 2020, nos hubiera dicho que era con ese desde antes :c
                    }   
                //Deducciones    
                    double pension;
                    double eps;
                    double arl;
                    double deducciones;
                    double salario_real_mensual;
                    double salario_anual;
                
                //Proceso
                    if(tipo_contrato == 1)
                    {
                        pension = 0.04;
                        eps = 0.04;
                        deducciones = (base_de_cotizacion * pension) + (base_de_cotizacion * eps);               
                        salario_real_mensual = salario_mensual - deducciones;
                        Console.WriteLine("Su salario real mensual es: " + salario_real_mensual);
                        salario_anual = salario_real_mensual * 12 + salario_mensual;
                        Console.WriteLine("Su salario anual es. " + salario_anual);
                    }
                    else if(tipo_contrato == 2)
                    {
                        Console.WriteLine("Ingrese su riesgo laboral (del 1 al 5)");
                        int riesgo_laboral = int.Parse(Console.ReadLine());
                        pension = 0.16;
                        eps = 0.125;
                        if(riesgo_laboral == 1)
                        {
                            arl = 0.00522;
                            deducciones = (base_de_cotizacion * pension) + (base_de_cotizacion * eps) + (base_de_cotizacion * arl);
                            salario_real_mensual = salario_mensual - deducciones;
                            salario_anual = salario_real_mensual * 12;
                            Console.WriteLine("Su salario real mensual es: " + salario_real_mensual);
                            Console.WriteLine("Su salario anual es. " + salario_anual);
                        }
                        if(riesgo_laboral == 2)
                        {
                            arl = 0.010144;
                            deducciones = (base_de_cotizacion * pension) + (base_de_cotizacion * eps) + (base_de_cotizacion * arl);
                            salario_real_mensual = salario_mensual - deducciones;
                            salario_anual = salario_real_mensual * 12;
                            Console.WriteLine("Su salario real mensual es: " + salario_real_mensual);
                            Console.WriteLine("Su salario anual es. " + salario_anual);
                        }
                        if(riesgo_laboral == 3)
                        {
                            arl = 0.02436;
                            deducciones = (base_de_cotizacion * pension) + (base_de_cotizacion * eps) + (base_de_cotizacion * arl);
                            salario_real_mensual = salario_mensual - deducciones;
                            salario_anual = salario_real_mensual * 12;
                            Console.WriteLine("Su salario real mensual es: " + salario_real_mensual);
                            Console.WriteLine("Su salario anual es. " + salario_anual);
                        }
                        if(riesgo_laboral == 4)
                        {
                            arl = 0.04350;
                            deducciones = (base_de_cotizacion * pension) + (base_de_cotizacion * eps) + (base_de_cotizacion * arl);
                            salario_real_mensual = salario_mensual - deducciones;
                            salario_anual = salario_real_mensual * 12;
                            Console.WriteLine("Su salario real mensual es: " + salario_real_mensual);
                            Console.WriteLine("Su salario anual es. " + salario_anual);
                        }
                        if(riesgo_laboral == 5)
                        {
                            arl = 0.06960;
                            deducciones = (base_de_cotizacion * pension) + (base_de_cotizacion * eps) + (base_de_cotizacion * arl);
                            salario_real_mensual = salario_mensual - deducciones;
                            salario_anual = salario_real_mensual * 12;
                            Console.WriteLine("Su salario real mensual es: " + salario_real_mensual);
                            Console.WriteLine("Su salario anual es. " + salario_anual);
                        }
                        else
                        {
                            Console.WriteLine("Ese valor no se encuentra en la clase de riesgo");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No cumple con ninguno de los tipos de contrato");
                    }
        }
    }
}
