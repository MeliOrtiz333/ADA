using System;

namespace Ejercicio_Funciones_2
{ //Area lateral de un cilindro

    class Program
    {
        static void Main(string[] args)
        {
            int numero, otronumero;
            int altura, radio;
            pantalla_programa("Ejemplo de Funciones 01 ");
            numero = pidevalor("número a calcular");
            escribe_resultado(numero, cuadrado(numero));
            otronumero = pidevalor("otro número");
            escribe_resultado(otronumero, cuadrado(otronumero));
            espera();
            radio = pidevalor("el valor del radio:  ");
            altura = pidevalor("el valor de la altura: ");
            Console.WriteLine("El area lateral del cilindro es : {0}", AreaLateralCilindro(radio, altura));
            espera();
        }

        static double AreaLateralCilindro(int radiocilindro, int alturacilindro)
        {
            double areacilindro;
            areacilindro = 2 * Math.PI * radiocilindro * alturacilindro;
            return areacilindro;
        }

        static int pidevalor(string cadenacaracteres)
        {
            Console.Write("Escriba {0}:   ", cadenacaracteres);         // Lee el número del usuario
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            return num;
        }

        static int cuadrado(int valor)
        {
            return valor * valor;
        }

        static int suma(int valor)
        {
            return valor + valor;
        }

        static void escribe_resultado(int x, int cuadradox)
        {
            Console.WriteLine("Valor:   {0}   y su cuadrado es :   {1}\n", x, cuadradox);
            Console.WriteLine();
        }

        static void pantalla_programa(string mensaje)
        {
            Console.Write("Universidad Panamericana   ");
            Console.WriteLine("Escuela de Ingeniería  ");
            Console.WriteLine("Programa {0}  ", mensaje);
            Console.WriteLine();
        }

        static void espera()
        {
            Console.Write("Presione <Enter> para salir . . .");
            string salir = Console.ReadLine();
        }

    }
}
