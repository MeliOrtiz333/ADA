using System;

namespace Distribucion_calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos;
            char continua;
            do
            {
                pantalla_programa("Arreglos: Distribución de calificaciones");
                int[] calificacionAlumnos = new int[11];
                alumnos = pidevalor("Numero de alumnos");
                genera_calificaciones(calificacionAlumnos, alumnos);
                muestra_calificaciones(calificacionAlumnos, alumnos);
                continua = sigue_o_no();
            }
            while (continua == 's' || continua == 'S');
            espera();
        }
        static int pidevalor(string cadenadecaracteres)
        {
            Console.Write("Escriba {0}:  ", cadenadecaracteres);
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");
            return num;
        }
        static void genera_calificaciones(int [] arreglocalif, int numAleatorios, int[] Notas)
        {
            Random numeroAleatorio = new Random();
            int calificacion = 0;
            int rango = 0;
            for (int x=1; x<=numAleatorios; x++)
            {
                calificacion = numeroAleatorio.Next(0, 101);
                Notas[x] = calificacion;
                Console.Write("{0,4}", calificacion);
                rango = calificacion / 10;
                Console.Write("-{0}-\t", rango);
                ++arreglocalif[rango];
            }
            Console.WriteLine(" ");
        }
        static void muestra_calificaciones(int[] arreglo2, int totalAlumnos)
        {
            Console.WriteLine("\nRango\tFrecuencia en Porcentaje\t|-----------------------| 30%");
            for(int indice=0; indice <arreglo2.Length;indice++)
            {
                int proporcion = arreglo2[indice] * 100 / totalAlumnos;
                if (indice < 10)
                    Console.Write("{0}--{1}\t{2}\t{3}%\t", indice * 10, indice * 10 + 9, arreglo2[indice], proporcion);
                else
                    Console.Write("{0}      \t{1}\t{2}%\t", indice * 10, arreglo2[indice], proporcion);
                for (int x=1; x<=proporcion; x++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
        static void pantalla_programa(string mensaje)
        {
            Console.WriteLine("Universidad Panamericana");
            Console.WriteLine("Melisa Ortiz Morante");
            Console.WriteLine("Programa {0} ", mensaje);
            Console.WriteLine();
        }
        static char seguir_o_no()
        {
            Console.Write("\n\n ¿Desea continuar? (s/n), presione <enter>");
            char opcion = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            return opcion;
        }
        static void espera()
        {
            Console.Write("Presione <enter> para salir");
            string salir = Console.ReadLine();

        }





    }
}
