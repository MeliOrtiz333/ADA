using System;

namespace Distribucion_de_calificaciones_3D
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos, materias, semestres;
            char continuar;
            do
            {
                pantalla_programa("Arreglos:Distribucion de calificaciones 3D");
                int[,,] calificacionAlumnos = new int[2001, 18, 15];
                alumnos = pidevalor("Alumnos");
                semestres = pidevalor("Semestres");
                materias = pidevalor("Materias");
                genera_calificaciones(calificacionAlumnos, alumnos, materias, semestres);
                espera();
                muestra_calificaciones(calificacionAlumnos, alumnos, materias, semestres);

                continuar = seguir_o_no();
            }
            while (continuar == 's' || continuar == 'S');
            espera();

        }
        static int pidevalor(string cadenadecaracteres)
        {
            Console.Write("Escriba el valor {0}:   ", cadenadecaracteres);
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");
            return num;
        }
        static void genera_calificaciones(int [,,] arregloCali, int numAlumnos, int numMaterias, int numSemestres)
        {
            Random numeroAleatorio = new Random();
            int calificacion = 0;
            for (int x=1; x<=numAlumnos;x++)
            {
                for(int s=1; s<=numSemestres; s++)
                {
                    int promedioAlumno = 0;
                    for (int m=1; m<=numMaterias;m++)
                    {
                        calificacion = numeroAleatorio.Next(0, 101);
                        arregloCali[x, s, m] = calificacion;
                        promedioAlumno = promedioAlumno + calificacion;
                    }
                    arregloCali[x, s, 0] = promedioAlumno / numMaterias;
                        
                }
            }
            Console.WriteLine("Arreglo exitoso");
        }
        static void muestra_calificaciones(int[,,] arregloCali, int numAlumnos, int numMaterias, int numSemestres)
        {
            int promedioG = 0;
            for(int x=1; x<=numAlumnos; x++)
            {
                Console.WriteLine("Alumno {0,2}: ", x);
                for(int s=1; s<=numSemestres;s++)
                {
                    Console.Write("Semestre {0,2}:  ", s);
                    for (int m=1; m<=numMaterias; m++)
                    {
                        Console.Write("{0,3}", arregloCali[x, s, m]);
                    }
                    Console.Write("\t El promedio es igual a {0,3}", arregloCali[x, s, 0]);
                    Console.WriteLine(" ");
                    promedioG = promedioG + arregloCali[x, s, 0];
                }
            }
            promedioG = promedioG / numSemestres / numAlumnos;
            Console.WriteLine("\n\t El promedio general de los {0,2} aalumnos es igual a {1,3}", numAlumnos, promedioG);
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
