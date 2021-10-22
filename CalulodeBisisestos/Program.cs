using System;

namespace CalulodeBisisestos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encabezado del programa
            Console.WriteLine("Programa para calcular si un año es bisisesto o no: \t");

            //Variable
            int N;


            //Pedir variables
            Console.Write("Ingrese el año a analizar: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El año es: " + N);

            //Identificar si es bisisesto

            if (N % 100 != 0)
            {
               if (N % 4==0)
               {
                    Console.WriteLine("El año es bisiesto\n");
               }

                else
                {

                    Console.WriteLine("El año no es bisisesto \n ");


                }


            }
            else if (N % 400==0)
            {
                Console.WriteLine("El año es bisisesto \n");


            }
            else
            {
                Console.WriteLine("El año no es bisiesto \n");


            }

            //Espera
            Console.WriteLine("\n\nPrograma exitoso, oprima <enter> ");
            string espera = Console.ReadLine();




        }
    }
}
