using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_DE_RESISTENCIAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calcular resistencias";


            double r1 = 0, r2 = 0, r3 = 0, resultado = 0;

            Console.WriteLine("\t<< R E S I S T E N C I A S >>");
            Console.WriteLine("\n");

            Console.WriteLine("\t* [0] NEGRO                             *");
            Console.WriteLine("\t* [1] MARRON                            *");
            Console.WriteLine("\t* [2] ROJO                              *");
            Console.WriteLine("\t* [3] NARANJA                           *");
            Console.WriteLine("\t* [4] AMARILLO                          *");
            Console.WriteLine("\t* [5] VERDE                             *");
            Console.WriteLine("\t* [6] AZUL                              *");
            Console.WriteLine("\t* [7] VIOLETA                           *");
            Console.WriteLine("\t* [8] GRIS                              *");
            Console.WriteLine("\t* [9] BLANCO                            *");
            Console.WriteLine("\t*****************************************");
            Console.Write("\n");

            Console.WriteLine("Ingrese el valor de las 3 resistencias\n");

            Console.WriteLine("Ingrese el valor de la resistencia 1");
            r1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la resistencia 2");
            r2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la resistencia 3");
            r3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Ingrese el valor de la resistencia 4");
            //r4 = Convert.ToDouble(Console.ReadLine());

            if (r1 == 0 || r2 == 0 || r3 == 0)
            {
                resultado = 0;
            }
            else
            {
                resultado = 1 / ((1 / r1) + (1 / r2) + (1 / r3));
            }

            Console.WriteLine("El resultado es:" + resultado + "ohms");


            Console.ReadKey();
        }
    }
}
