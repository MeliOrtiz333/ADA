using System;

namespace Correccion_Examen_SegundoP
{   //1.- Generar 3 numeros aleatorios.
    //2.- Sumar, restar, multiplicar y dividir, promedio.
    //3.- Mostrar resultado.
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            int[] a = new int[9999];
            int suma, multiplicacion, resta;
            double promedio, division;


            do
            {
                pantalla_programa("Practica suma, resta, multiplicacion, division y promedio");
                llenar_arreglo(ref a);

                continuar = menu();

                switch (continuar)
                {
                    case '1':
                        suma = suma_arreglo(a);
                        Console.WriteLine("\t La suma del arreglo es: {0} ", suma);
                        break;

                    case '2':
                        multiplicacion = multiplicacion_arreglo(a);
                        Console.WriteLine("\t La multiplicacion del arreglo es: {0} ", multiplicacion);
                        break;

                    case '3':
                        division = division_arreglo(a);
                        Console.WriteLine("\t La division del arreglo es: {0} ", division);
                        break;

                    case '4':
                        resta = resta_arreglo(a);
                        Console.WriteLine("\t La resta del arreglo es:{0}", resta);
                        break;

                    case '5':
                        promedio = promedio_arreglo(a);
                        Console.WriteLine("\t El promedio del arreglo es: {0}", promedio);
                        break;





                }





            }
            while (continuar == '1' || continuar == '2' || continuar == '3' || continuar == '4' || continuar == '5');


        }

        static void pantalla_programa(string mensaje)
        {
            Console.WriteLine("Melisa Ortiz");
            Console.WriteLine("Programa {0}:  ", mensaje);
            Console.WriteLine("  ");
        }

        static int pidevalor(string cadenadecaracteres)
        {
            int num = 0;
            Console.WriteLine("De el valor {0}: ", cadenadecaracteres);
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");
            return num;
        }
        static int num_aleatorio()
        {
            Random aleatorio = new Random();
            int num = aleatorio.Next(1000, 9999);
            Console.WriteLine("El  numero aleatorio generado es: {0}", num);
            Console.WriteLine("  ");
            return num;
        }

        static void llenar_arreglo(ref int[] arreglo)
        {

            for (int i = 0; i <= 2; i++)
            {
                arreglo[i] = num_aleatorio();

            }




        }

        static int suma_arreglo(int[] arreglo)
        {
            int suma = 0;

            for (int j = 0; j <= 2; j++)
            {
                suma = arreglo[j] + suma;
            }
            return suma;



        }
        static int multiplicacion_arreglo(int[] arreglo)
        {
            int multiplicacion = 0;

            for (int z = 0; z <= 2; z++)
            {
                multiplicacion = arreglo[z] * multiplicacion;

            }
            return multiplicacion;


        }

        static double division_arreglo(int[] arreglo)
        {

            double division = 0;

            for (int x = 0; x <= 2; x++)
            {
                division = arreglo[x] / division;

            }
            return division;
        }

        static int resta_arreglo(int[] arreglo)
        {
            int resta = 0;

            for (int y = 0; y <= 2; y++)

            {
                resta = arreglo[y] - resta;

            }
            return resta;
        }

        static double promedio_arreglo(int[] arreglo)
        {
            int suma = suma_arreglo(arreglo);
            double promedio = suma / 3;

            return promedio;
        }


        static char menu()
        {
            Console.WriteLine("Menu de opciones\t");
            Console.WriteLine("1.- Suma\n");
            Console.WriteLine("2- Multiplicacion\n");
            Console.WriteLine("3.- Division\n");
            Console.WriteLine("4.- Resta\n");
            Console.WriteLine("5.- Promedio\n");
            char opcion = Convert.ToChar(Console.ReadLine());
            return opcion;
        }

        

    }
}

