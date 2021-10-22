using System;

namespace Divisores_de_un_numero_N
{
    class Program
    {
        static void Main(string[] args)
        {  
            //Encabezado del programa 
            Console.WriteLine("Programa que calcula el maximo comun divisor de un numero dado \n");

            //Variables
            int numero1;
            int numero2;
            int resultado;

            //Pedir variables
            Console.Write("Ingrese el primer numero entero al que quiere sacarle el maximo comun divisor:   ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero que proporcionó es  \n" + numero1);

            Console.Write("Ingrese el segundo numero entero al que quiere sacarle el maximo comun divisor:   ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero que proporcionó es  \n" + numero2);

            //Saber cual es mayor
            int a = Math.Max(numero1, numero2);
            int b = Math.Min(numero1, numero2);

            do
            {
                resultado = b;
                b = (a % b);
                a = resultado;
            }


            while (b != 0);


            //Mostrar el maximo comun divisor
            Console.WriteLine("El maximo comun divisor entre " + numero1 + " y " + numero2+ " es \n" + resultado);
            Console.ReadKey(true);

            //Espera
            Console.WriteLine("Programa exitoso, presione <enter> para salir...");
            string espera = Console.ReadLine();














        }
    }
}
