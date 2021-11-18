using System;

namespace Arreglos_alumno_y_calificacion
{
    struct Alumno
    {
        public string ID;
        public string nombre;
        public DateTime ingreso;
        public int[] cali;
        public double promedio;


    }
    class program
    {
        static void Main(string[] args) //Arreglo de estructura de alumnos.
        {
            string fecha = "";
            string[] nombres = { "María", "José", "Alicia", "Marina", "Mauricio", "Fernando" };
            Random aleatorio = new Random();
            Console.Write("Número de alumnos:  ");
            int N = int.Parse(Console.ReadLine());
            Alumno[] arr = new Alumno[N];
            Console.WriteLine();

            //Pedir datos del alumno.
            for (int i = 0; i < N; i++)
            {
                int acumulador = 0;
                Console.Write("ID del alumno {0}: ", (i + 1));
                arr[i].ID = Convert.ToString(aleatorio.Next(1000000, 999999));
                Console.WriteLine(arr[i].ID);
                fecha = Convert.ToString(aleatorio.Next(1, 13)) + "-";
                fecha = fecha + Convert.ToString(aleatorio.Next(1, 32));
                fecha = fecha + Convert.ToString(aleatorio.Next(2010, 2015));
                arr[i].ingreso = DateTime.Parse(fecha);
                Console.Write("Fecha de ingreso: " + fecha);
                Console.Write("Fecha de ingreso: " + arr[i].ingreso);

                Console.Write("Nombre del alumno:  ");
                arr[i].nombre = nombres[aleatorio.Next(0, 8)];
                Console.WriteLine(arr[i].nombre);

                //Calificación
                arr[i].cali = new int[6];
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("\t Calificación {0}: ", (j + 1));
                    arr[i].cali[j] = aleatorio.Next(0, 101);
                    Console.WriteLine(arr[i].cali[j]);
                    acumulador += arr[i].cali[j];
                }
                arr[i].promedio = acumulador / 6.0;
                Console.WriteLine();
            }










            espera_inico();
            //Mostrar la estructura.
            for (int k = 0; k < N; k++)
            {
                Console.WriteLine("Alumno {0}", (k + 1));
                Console.WriteLine("\tID:\t {0}\n\t Fecha de Ingreso: {1} \n\t Nombre del alumno", arr[k].ID, arr[k].ingreso, arr[k].nombre); //Mostrar datos.
                //Mostrar calificaciones
                for (int z = 0; z < 6; z++)
                {
                    Console.WriteLine("\t\tCalificación {0}: {1}", (z + 1), (arr[k].cali[z]));

                }
                Console.WriteLine("\n\tSU promedio es: {0} \n presione <enter> para continuar", arr[k].promedio);
                Console.ReadLine();
            }


        }
        static void espera_inico()
        {
            Console.WriteLine("Presione <enter> para visualizar la estructura completa");
            string salir = Console.ReadLine();
        }


    }
}
