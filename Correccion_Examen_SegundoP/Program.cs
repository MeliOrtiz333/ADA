using System;

namespace Correccion_Examen_SegundoP
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            int N = 1;
            int[] a = new int[9999];
            pantalla_programa("Correccion Examen Segundo Parcial");
            num_aleatorio(ref N);
            do
            {
                continuar = menu();
                switch (continuar)
                {
                    case '1': Console.WriteLine("El numero 7 aparece en {0} números en el rango de 1 a N\n", numero_rango(N)); break;
                    case '2': generar_arreglo(N, ref a); break;
                    case '3': mostrar_arreglo(numero_rango(N), a); break;
                    case '4': Console.WriteLine("El numero {0} se encontró exitosamente", buscar_arreglo()); break;
                }
            }
            while (continuar == '1' || continuar == '2' || continuar == '3' || continuar == '3' || continuar == '4');
            espera();
        }
        static void pantalla_programa(string mensaje)
        {

            Console.Clear();
            Console.WriteLine("Examen Segundo Parcial");
            Console.Write("Universidad Panamericana: Escuela de Ingenieria");
            Console.WriteLine("Melisa Ortiz Morante (0221077)");
            Console.WriteLine("Programa {0}: ", mensaje);
            Console.WriteLine();
        } //Datos
        static int pidevalor(string cadenacaracteres)
        {
            Console.Write("Escriba {0}:   ", cadenacaracteres);         
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            return num;
        } //Pedir valor

        // 1) --> Generar y mostrar numero aleatorio 
        static void num_aleatorio( ref int num) 
        {
            Random aleatorio = new Random();
            num = aleatorio.Next(1000, 9999);
            Console.WriteLine("El  numero aleatorio es: {0}", num);
            Console.WriteLine("  ");
        }

        // 2.1) --> Mostrar en que numeros aparece el digito "7".
        // 2.2) --> Método que guarda en un arreglo , enteros cuando el digito si este incluido. 
        static int numero_rango(int num) 
        {
            Console.WriteLine("El numero 7 aparece en {0} números en el rango de 1 a N\n");
            int numR = 0;
            for (int x= 1; x<=num; x++)
            {
                int unidades, decenas, centenas, unidadesdemillar;
                unidadesdemillar = x / 1000;
                centenas = (x / 100) % 10;
                decenas = (x / 10) % 10;
                unidades = x % 10;
                if (unidadesdemillar == 7  ||  centenas ==7  ||  decenas == 7  ||  unidades ==  7)
                {
                    numR++;
                }
            }
            return numR;

        }

        //3) Generar arreglo que muestre numeros incluidos.
        static void generar_arreglo(int num, ref int[] arreglo)
        {
            Console.WriteLine(" Generar un arreglo de numero que muestren las cantidades que contienen el digito 7");
            Console.WriteLine("  ");
            int numR = 0;
            for (int x = 1; x <= num; x++)
            {
                int unidades, decenas, centenas, unidadesdemillar;
                unidadesdemillar = x / 1000;
                centenas = (x / 100) % 10;
                decenas = (x / 10) % 10;
                unidades = x % 10;
                if (unidadesdemillar == 7 || centenas == 7 || decenas == 7 || unidades == 7)
                {
                    numR++;
                    arreglo[numR] = x;
                }
            }
            Console.WriteLine(" Se generó el arreglo con exito");
            Console.WriteLine("  ");
        } //Se genera el arreglo

        
        static void mostrar_arreglo (int indice, int [] arreglo)
        {
            Console.Write("Los valores del arreglo son:  ");
            for (int x= 1; x<=indice; x++)
            {
                Console.Write("({0}) - {1}, ", x, arreglo[x]);
            } 
        } //Mostrar el arrgelo generado
        
       //4 ) Pedir valor y reconocer si el digito "7" está incluido. 
        static int buscar_arreglo()
        {
            int z = pidevalor("De el numero que quiera buscar");
                int unidades, decenas, centenas, unidadesdemillar;
                unidadesdemillar = z/ 1000;
                centenas = (z / 100) % 10;
                decenas = (z  / 10) % 10;
                unidades = z % 10;
                if (unidadesdemillar == 7 || centenas == 7 || decenas == 7 || unidades == 7)
                {
                      Console.WriteLine("El numero {0}, contiene el digito 7", z);
                }
                else
                {
                     Console.WriteLine("El numero {0}, NO contiene el digito 7", z);
                Console.WriteLine(" ");
                }
            return z;
                
        }

        static char menu()
        {
            
                Console.Write("\t Menú de opciones\n ");
                Console.Write("\t1.- Cantidad de numeros del 1 a N en donde se encuentra el digito 7\n");
                Console.Write("\t2.- Generar arreglo de números que tienen como parte de sus digitos al 7\n");
                Console.Write("\t3.- Mostrar el arreglo de los números que tienen como parte de sus digitos al 7\n");
                Console.Write("\t4.-Pedir numero y buscar en el si este contiene al número 7\n");
                Console.WriteLine("Presione <enter> para salir\n");
                Console.Write("\t\n Se seleccionó la siguiente opción: ");
                char opcion = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                return opcion;    
        } //Creación del menú
        static void espera()
        {
            Console.Write("Presione <enter> para salir");
            string salir = Console.ReadLine();
        }


    }
}
