using System;

namespace Funciones_sumatoria_factorial
{  //Sumatoria Factorial
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int numero1, numero2; double cociente; char continua;
            do
            {
                pantalla_programa("Funciones 02 Cuadrado Sumatoria y Factorial");
                numero1 = pidevalor("numero primero");
                numero2 = aleatorio.Next(1, 20);    //pidevalor("numero segundo");
                escribe_resultado(numero1, cuadrado(numero1), sumatoria(numero1), factorial(numero1));
                escribe_resultado(numero2, cuadrado(numero2), sumatoria(numero2), factorial(numero2));
                cociente = 1.0 * factorial(numero1) / cuadrado(numero2);
                Console.WriteLine("Cociente= {0} / {1} = {2} ", factorial(numero1), cuadrado(numero2), cociente);
                continua = sigue_o_no();
            }
            while (continua == 's' || continua == 'S');
            espera();
        }

        static int pidevalor(string cadenacaracteres)
        {
            Console.Write("Escriba {0}:   ", cadenacaracteres);         // Lee el número del usuario
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            return num;
        }

        static int cuadrado(int valor)
        {
            return valor * valor;
        }

        static int sumatoria(int valor)
        {
            int suma = 0;
            for (int x = 1; x <= valor; x++)
                suma = suma + x;
            return suma;
        }

        static long factorial(int valor)
        {
            long fact = 1;
            for (int x = 1; x <= valor; x++)
                fact = fact * x;
            return fact;
        }








        static void pantalla_programa(string mensaje)
        {
            Console.Clear();
            Console.Write("Universidad Panamericana   ");
            Console.WriteLine("Escuela de Ingeniería  ");
            Console.WriteLine("Programa {0}  ", mensaje);
            Console.WriteLine();
        }

        static void escribe_resultado(int x, int cuadradox, int sumatoriax, long factorialx)
        {
            Console.WriteLine("Valor: {0}\tCuadrado: {1}\tSumatoria: {2}\tFactorial: {3}\n", x, cuadradox, sumatoriax, factorialx);
            Console.WriteLine();
        }

        static char sigue_o_no()
        {
            Console.Write("\n\n¿Continua (s/n) <enter>?");         // Lee el número del usuario
            char opcion = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            return opcion;
        }

        static void espera()
        {
            Console.Write("Presione <Enter> para salir . . . ¡Adios!");
            string salir = Console.ReadLine();

        }

    }
}
