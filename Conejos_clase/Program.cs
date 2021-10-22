using System;

namespace Conejos_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            do
            {
                descripcion();
                int N;
                Console.Write("De la cantidad de meses que desea calcular: ");
                N = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("  ");
                conejos_crecimiento(N);
                continuar = seguir_o_terminar();
            }
            while (continuar == 's' || continuar == 'S');
            espera();
        }
        static void conejos_crecimiento(int N)
        {
            long fn = 1, fn1, fn2;
            Console.WriteLine("Calculo de meses\t\t f(N-2)\t\t f(N-1)\t\t Cantidad_de_parejas_de_conejos_que_habrá --> f(N)\n");
            fn1 = 1; fn2 = 1;
            if(N<2)
            {
                fn = 1;
                Console.WriteLine(" 1\t\t {0}\t\t {1}\t\t {2}\t\t", fn2, fn1, fn);
            }
            else
            {
               for(int n=3; n<=N; n++)
                {
                    fn = fn1 + fn2;
                    Console.WriteLine(" {0}\t\t  {1}\t\t  {2}\t\t {3}\t\t", n, fn2, fn1, fn);
                    fn2 = fn1; fn1 = fn;
                }
            }

        }
       static void descripcion()
       {
            Console.Clear();
            Console.WriteLine("Melisa Ortiz Morante"); 
       }
        static char seguir_o_terminar()
        {
            Console.Write("\n\n ¿Desea continuar? (si o no), presione <enter>");
            char opcion = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            return opcion;
        }
        static void espera()
        {
            Console.Write("Presione <enter> si desea salir");
            string salir = Console.ReadLine();
        }
    }
}
