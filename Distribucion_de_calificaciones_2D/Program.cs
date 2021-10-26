using System;

namespace Distribucion_de_calificaciones_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos, materias, buscaAlumno, buscaMateria;
            char continua;
            do
            {
                pantalla_programa("Arreglos: Distribucion de calificaciones en 2D");
                int[,] calificacionAlumnos = new int[10001, 101];
                alumnos = pidevalor("Numero de alumnos");
                materias = pidevalor("NUmero de materias");
                genera_calificaciones(calificacionAlumnos, alumnos, materias);
                muestra_calificacion(calificacionAlumnos, alumnos, materias);
                continua = seguir_o_no();

            }
            while (continua == 's' || continua == 'S');
            espera();
        }
        static int pidevalor(string cadenadecaracteres)
        {
            Console.Write("escriba el valor {0}:   ", cadenadecaracteres);
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");
            return num;

        }
        static void genera_calificaciones(int[,] arregloCali, int numAlumnos, int numMaterias)
        {
            Random numeroAleatorio = new Random();
            int calificacion = 0;
            for(int x=1; x<=numAlumnos;x++)
            {
                int promedioAlumno = 0;
                for (int m=1; m<=numMaterias;m++)
                {
                    calificacion = numeroAleatorio.Next(0, 101);
                    arregloCali[x, m] = calificacion;
                    promedioAlumno = promedioAlumno + calificacion;
                }
                arregloCali[x, 0] = promedioAlumno / numMaterias;
            }
        }
        static void muestra_calificacion(int[,] arregloCali, int numAlumnos, int numMaterias)
        {
            int promedioGen = 0;
            for (int x=1; x<=numMaterias;x++)
            {
                Console.Write("Alumno {0,2} : ", x);
                for (int m=1; m<=numMaterias; m++)
                {
                    Console.Write("{0,3}", arregloCali[x, m]);
                }
                Console.Write("\t Promedio= {0,3}", arregloCali[x, 0]);
                Console.WriteLine(" ");
                promedioGen = promedioGen + arregloCali[x, 0];
            }
            promedioGen = promedioGen / numAlumnos;
            Console.WriteLine("\n\tEl promedio general de los {0,2} alumnos es igual a {1,3}", numAlumnos, promedioGen);
            Console.WriteLine(" ");

        }
        static void pantalla_programa(string mensaje)
        {
            Console.Clear();
            Console.Write("Universidad Panamericana");
            Console.WriteLine("Melisa Ortiz Morante");
            Console.WriteLine("Programa {0}: ", mensaje);
            Console.WriteLine();

        }
        static char seguir_o_no()
        {
            Console.Write("\n\n¿Desea continuar?, (s/n), presione <enter> para salir");
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
