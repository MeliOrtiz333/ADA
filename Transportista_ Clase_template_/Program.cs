using System;

namespace Transportista__Clase_template_
{
    class Program
    {
        static void Main(string[] args)
        {
            int Camiones = 0, Viajes = 0, Destinos = 0;
            char continua;
            pantalla_programa("TRANSPORTISTA MÉTODOS");
            espera_inicio();
            do
            {
                int destino1 = 0, destino2 = 0, destino3 = 0, destino4 = 0;
                pantalla_programa("Transportista C-camiones, V-viajes, D-destinos: Toluca, Querétaro, León y Guadalajara");
                Camiones = pidevalor("Número de Camiones");
                Viajes = pidevalor("Número de Viajes  ");
                Destinos = 4;   //Destinos = pidevalor("Número de Destinos"); 
                calcula_viaje(Camiones, Viajes, Destinos, ref destino1, ref destino2, ref destino3, ref destino4);
                resultados_finales(Camiones, Viajes, Destinos, destino1, destino2, destino3, destino4);
                continua = sigue_o_no();
            }
            while (continua == 's' || continua == 'S');
            espera();
        }


















        static void calcula_viaje(int xcamion, int xviajes, int xdestinos, ref int d1, ref int d2, ref int d3, ref int d4)
        {
            Console.Write("Camiones: {0}", xcamion);
            Console.Write("\tViajes: {0}", xviajes);
            Console.WriteLine("\tDestinos: {0}", xdestinos);
            Console.WriteLine();
            Random numeroAleatorio = new Random();
            for (int camion = 1; camion <= xcamion; camion++)
            {
                int tol = 0, qro = 0, lon = 0, gdl = 0;
                Console.WriteLine("Camión: {0}", camion);
                for (int viajes = 1; viajes <= xviajes; viajes++)
                {
                    switch (numeroAleatorio.Next(1, xdestinos + 1))
                    {
                        case 1: tol++; Console.Write("Toluca    \t"); break;
                        case 2: qro++; Console.Write("Querétaro \t"); break;
                        case 3: lon++; Console.Write("León      \t"); break;
                        case 4: gdl++; Console.Write("Guadalajara\t"); break;
                    }
                    if (viajes % 5 == 0) Console.WriteLine();
                }
                pantalla_destinos();
                escribe_destinos(camion, tol, qro, lon, gdl);
                d1 = d1 + tol;
                d2 = d2 + qro;
                d3 = d3 + lon;
                d4 = d4 + gdl;
                Console.Write("Acum");
                escribe_destinos(camion, d1, d2, d3, d4);
            }
        }










        static void pantalla_programa(string mensaje)
        {
            Console.Clear();
            Console.Write("Universidad Panamericana   ");
            Console.WriteLine("Escuela de Ingeniería  ");
            Console.WriteLine("Programa {0}  ", mensaje);
            Console.WriteLine();
        }

        static void pantalla_destinos()
        {
            Console.WriteLine();
            Console.WriteLine("Camión     \tToluca     \tQuerétaro  \tLeón        \tGuadalajara");
        }

        static void escribe_destinos(int c, int d1, int d2, int d3, int d4)
        {
            Console.WriteLine("  {0}\t\t  {1}\t\t  {2}\t\t  {3}\t\t  {4}", c, d1, d2, d3, d4);
            Console.WriteLine();
        }

        static void resultados_finales(int c, int v, int d, int d1, int d2, int d3, int d4)
        {
            Console.WriteLine("\n  RESULTADOS FINALES");
            Console.Write("Camiones: {0}", c);
            Console.Write("\tViajes: {0}", v);
            Console.WriteLine("\tDestinos: {0}", d);
            pantalla_destinos();
            escribe_destinos(0, d1, d2, d3, d4);
            Console.WriteLine();
        }











        static int pidevalor(string cadenacaracteres)
        {
            Console.Write("Escriba {0}:   ", cadenacaracteres);         // Lee el número del usuario
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            return num;
        }

        static char sigue_o_no()
        {
            Console.Write("\n\n¿Continua (s/n) <enter>?");         // Lee el número del usuario

            char opcion = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            return opcion;
        }

        static void espera()
        {
            Console.Write("Presione <Enter> para salir . . . ¡Adios!");
            string salir = Console.ReadLine();
        }

        static void espera_inicio()
        {
            Console.Write("Presione <Enter> para empezar la ejecución");
            string salir = Console.ReadLine();
        }


    }
}
