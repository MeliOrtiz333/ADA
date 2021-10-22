using System;

namespace NumerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encabezado del programa
            Console.WriteLine("Programa que convierte a numeros romanos \n");

            //Declaracion de variables
            //Entrada
            int N;

            //Salida
            int unidades, decenas, centenas, unidadesm;

            //Leer el numero
            Console.Write("Ingrese el numero a convertir: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero es: \n");



            unidades = (N % 10);
            decenas = (N / 10) % 10;
            centenas = (N / 100) % 10;
            unidadesm = (N / 1000) % 10;

            Console.Write("Número      : \t");
            Console.Write("{0} {1} {2} {3} \t\t\t\n", unidades, decenas, centenas , unidadesm);
            Console.Write("\t\t\t\t\t\t\t\n");

            Console.Write("Numero romano: \t");



            //Separacion del numero

            switch (unidadesm)
            {
                case 1:
                    Console.Write("M");
                    break;
                case 2:
                    Console.Write("MM");
                    break;
                case 3:
                    Console.Write("MMM");
                    break;




            }

            switch (centenas)
            {
                case 1:
                    Console.Write("C");
                    break;

                case 2:
                    Console.Write("CC");
                    break;
                case 3:
                    Console.Write("CCC");
                    break;
                case 4:
                    Console.Write("CD");
                    break;
                case 5:
                    Console.Write("D");
                    break;
                case 6:
                    Console.Write("DC");
                    break;
                case 7:
                    Console.Write("DCC");
                    break;

                case 8:
                    Console.Write("DCCC");
                    break;
                case 9:
                    Console.Write("CM");
                    break;


            }
            switch (decenas)
            {
                case 1:
                    Console.Write("X");
                    break;
                case 2:
                    Console.Write("XX");
                    break;
                case 3:
                    Console.Write("XXX");
                    break;
                case 4:
                    Console.Write("XL");
                    break;
                case 5:
                    Console.Write("L");
                    break;
                case 6:
                    Console.Write("LX");
                    break;
                case 7:
                    Console.Write("LXX");
                    break;
                case 8:
                    Console.Write("LXXX");
                    break;
                case 9:
                    Console.Write("XC");
                    break;



            }

            switch (unidades)

            {
               

                case 1:
                    Console.WriteLine(" I ");
                    break;

                case 2:
                    Console.WriteLine("II ");
                    break;

                case 3:
                    Console.WriteLine("III ");
                    break;

                case 4:
                    Console.WriteLine("IV ");
                    break;

                case 5:
                    Console.WriteLine("V ");
                    break;

                case 6:
                    Console.WriteLine(" VI ");
                    break;

                case 7:
                    Console.WriteLine(" VII ");
                    break;

                case 8:
                    Console.WriteLine(" VIII ");
                    break;

                case 9:
                    Console.WriteLine(" IX ");
                    break;

            }
  
  
         

            Console.WriteLine("\t\t\t");
            Console.WriteLine("\t\t\t\t\t\t");


            Console.WriteLine("\n\n");

            //Cambio de color a la pantalla
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            //Espera
            Console.Write("Programa exitoso, presione <enter> para salir....");
            string espera = Console.ReadLine();





        }
    }

}
