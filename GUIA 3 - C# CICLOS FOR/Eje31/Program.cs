﻿using System;

namespace Eje31
{
    /*Hacer un programa para ingresar 10 números, luego informar los 2 mayores valores ingresados,
    aclarando cual es el máximo y cuál es el segundo máximo descartando los números repetidos.

    Ejemplo A: 10, 8,12, 78 ,55, 20, 12, 40, 31, 28 el resultado será 78 y 55.
    Ejemplo B: -20, - 25, -3, -8, -50, -45, -20, -22, -15, -11 el resultado será -3 y -8.
    Ejemplo C: 20, 20, 12, 9, 14, 14, 8, 8, 10, 3 el resultado será 20 y 14.

    En el ejemplo C el valor 20 aparece dos veces, pero sólo se considera una vez.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, num, may = 0, med = 0;

            for (x = 0; x < 10; x++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    may = num;
                }

                if (num >= may)
                {
                    may = num;
                }
                else
                {
                    if (med == 0)
                    {
                        med = num;
                    }
                    else
                    {
                        if (num > med)
                        {
                            med = num;
                        }
                    }
                }

            }

            Console.WriteLine("El mayor es: " + may + ", y el segundo mayor es: " + med);
        }
    }
}
