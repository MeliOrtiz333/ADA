using System;

namespace Primos_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encabezado del programa 

            Console.WriteLine("Programa de descomposicion de factores primos de N \n");

            //Variables
            int divisor = 2;
            int N;

            //Pedir variabalbles 
            Console.Write("Escriba el valor de N:  ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");
            Console.WriteLine("Factores primos \n");


            //Ciclo

            while (N > 1)
            {
                if (N % divisor == 0)
                {
                    Console.Write("{0}" + divisor);
                    N = (N / divisor);

                }



                else
                    divisor++;
            }

            //Espera
            Console.WriteLine("\n\n Programa exitoso, presione <enter> para salir....");
            string espera = Console.ReadLine();


        } 

     








        
    }
}




