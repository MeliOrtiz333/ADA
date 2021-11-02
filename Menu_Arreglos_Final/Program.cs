using System;

namespace E_OperacionesArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            char cont = 's';
            int[] arra = new int[askint("Escriba la longitud del arreglo a generar:")];
            do
            {
                int selec = 0;
                Options(ref selec);
                Menu(ref arra, ref selec);
                cont = s_or_n();
            }
            while (cont == 's' || cont == 'S');
        }

        static void genArrayrand(ref int[] arr, int min, int max)
        {
            Random genAleatorio = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = genAleatorio.Next(min, max + 1);
            }
        }
        static int askint(string mes)
        {
            int output;
            Console.WriteLine("{0}", mes);
            output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        static char s_or_n()
        {
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("¿Quieres continuar? (s/n) <enter>");
            char output = Convert.ToChar(Console.ReadLine());
            return output;
        }
        static void Menu(ref int[] arra, ref int selec)
        {



            switch (selec)
            {
                case 1: // X INDICE
                    Console.Clear();
                    Console.WriteLine("Mostrar arreglo por índice");
                    printArray(arra);

                    break;
                case 2: // GENERAR ARREGLO ALEATORIO
                    Console.Clear();
                    Console.WriteLine("Generar arreglo aleatorio");
                    int min = askint("Escriba el valor aleatorio mínimo");
                    int max = askint("Escriba el valor aleatorio Máximo");
                    genArrayrand(ref arra, min, max);
                    printArray(arra);

                    break;
                case 3: //X COLUMNA 
                    Console.Clear();
                    Console.WriteLine("Mostrar arreglo en una columna");
                    printArrayCol(arra);

                    break;
                case 4: //POSICION DE UN VALOR
                    Console.Clear();
                    Console.WriteLine("Buscar posición de un valor en el arreglo");
                    printArray(arra);
                    int target = askint("Qué valor quiere encontrar");
                    int found = findArrayValue(arra, target);
                    Console.WriteLine("El valor se encontró {0} veces", found);

                    break;
                case 5: //X COLOR
                    Console.Clear();
                    Console.WriteLine("Buscar posición de un valor en el arreglo con color");
                    printArray(arra);
                    int targetc = askint("Qué valor quiere encontrar");
                    int foundc = findArrayValueColor(arra, targetc);
                    Console.WriteLine("El valor se encontró {0} veces", foundc);

                    break;
                case 6: // X RANGO
                    Console.Clear();
                    Console.WriteLine("Buscar posición de valores de un rango en el arreglo");
                    printArray(arra);
                    int minr = askint("Escriba el mínimo del rango");
                    int maxr = askint("Escriba el máximo del rango");
                    int foundr = findArrayValueRange(arra, minr, maxr);
                    Console.WriteLine("Hay {0} valores en el rango de {1} a {2}", foundr, minr, maxr);

                    break;
                case 7: // ORDENAR
                    Array.Sort(arra);
                    printArray(arra);
                    break;
                case 8: //REINICIAR
                    arra = new int[askint("Escriba la longitud del arreglo a generar:")];
                    break;

            }

        }

        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }

        }
        static void printArrayCol(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}  ", arr[i]);
            }
        }
        static int findArrayValue(int[] arr, int target)
        {
            int i, count = 0;
            Console.Write("El número {0} se encuentra en las posiciones: ", target);
            for (i = 0; i < arr.Length; i++)
            {

                if (arr[i] == target)
                {
                    count++;
                    Console.Write("{0}", i);
                }

            }
            Console.Write("\n");
            return (count);

        }
        static int findArrayValueColor(int[] arr, int target)
        {
            int i, count = 0;
            for (i = 0; i < arr.Length; i++)
            {

                if (arr[i] == target)
                {
                    count++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("{0} ", arr[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("{0} ", arr[i]);
                }
                Console.ForegroundColor = ConsoleColor.White;

            }
            Console.Write("\n");
            return (count);

        }
        static int findArrayValueRange(int[] arr, int min, int max)
        {
            int i, count = 0;
            Console.Write("Los números en el rango de {0} a {1} se encuentra en las posiciones: ", min, max);
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= min && arr[i] <= max)
                {
                    count++;
                    Console.Write("{0}", i);
                }
                Console.Write("\n");
            }
            return (count);

        }

        static void Options(ref int selec)
        {
            Console.WriteLine("");
            Console.WriteLine("Operaciones cor el arreglo");
            Console.WriteLine("1-Mostrar arreglo por índice");
            Console.WriteLine("2-Generar arreglo aleatorio");
            Console.WriteLine("3-Mostrar arreglo en columna");
            Console.WriteLine("4-Buscar posición de valor en arreglo");
            Console.WriteLine("5-Buscar número en el arreglo con color");
            Console.WriteLine("6-Busacar valores dentro de un rango en el arreglo");
            Console.WriteLine("7-Ordenar el arreglo");
            Console.WriteLine("8-Reiniciar arreglo y cambiar su longitud");
            Console.WriteLine("");
            selec = askint("Selccione una opción:");
        }
    }
}
