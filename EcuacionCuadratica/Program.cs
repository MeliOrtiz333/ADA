using System;

namespace EcuacionCuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encabezado del programa
            Console.WriteLine("Programa que calcula los dos resultados de una ecuacion cuadratica \n ");

            //Variables
            double  a, b, c, D;

            //Salida
            double  x1, x2;

            //Pedir datos
            Console.Write("Ingrese el coeficiente cuadratico: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El coeficiente cuadratico es: \n" +a );

            Console.Write("Ingrese el coeficiente lineal: ");
            b  = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El coeficiente lineal es: \n" + b );

            Console.Write("Ingrese el termino independiente: ");
            c  = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El termino independiente  es: \n" +c );


            //Calculo del determinante
            D = (b * b) - (4 * a * c);

            //Determinar el valor del discriminante
            if (D < 0)
            {
                Console.WriteLine("La solucion es imagianria \n");
            }

            else
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);

                Console.WriteLine("La primera solucion es: \n" + x1);
                Console.WriteLine("La segunda solucion es: \n" + x2);

            }


            //Espera
            Console.WriteLine("\n\nPrograma exitoso, oprima <enter>");
            string espera = Console.ReadLine();







        }
    }
}
