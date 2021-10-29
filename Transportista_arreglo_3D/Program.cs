using System;

namespace Transportista_arreglo_3D
{
    class Program
    {
        static void Main(string[] args)
        {
            int camiones = 0, viajes = 0, destinos = 0, semanas = 0;
            int[,,] arreglo_viajes = new int[100, 60, 1000];
            int[,,] arreglo_3D = new int[100, 1000, 60];
            string[] arreglo_destino = { "", "Toluca    ", "Queretaro   ", "Leon  ", "Guadalajara  ", "Pachuca  ", "Puebla  ", "Monterrey  ", "Oaxaca  ", " Veracruz  ", " Tijuana  " };
            char continuar;
            pantalla_programa("Transportista 3D");
            espera_inicio();
            do
            {
                pantalla_programa("TRansportista: Camiones, Viajes y Destinos");
                camiones = pidevalor("Numero de camiones");
                viajes = pidevalor("Numero de viajes");
                destinos = pidevalor("Numero de destinos");
                pantalla_destinos(destinos, arreglo_destino);
                semanas = pidevalor("Semanas");
                calcula_viaje(camiones, viajes, destinos, semanas, arreglo_viajes, arreglo_3D, arreglo_destino);
                resultados_finales(camiones, viajes, destinos, semanas, arreglo_viajes, arreglo_3D, arreglo_destino);
                continuar = seguir_o_no();
            }
            while (continuar == 's' || continuar == 'S');
            espera();
        }
        static int pidevalor(string cadenadecaracteres)
        {
            Console.Write("Escriba {0}:   ", cadenadecaracteres);
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");
            return num;

        }
        static void calcula_viaje(int xcamion, int xviajes, int xdestinos, int xsemanas, int[,,]xarr_viajes,int [,,] xArr_3D, string[] xarr_destinos)
        {
            Console.Write("\tCamiones: {0}  ", xcamion );
            Console.Write("\tViajes: {0}  ", xviajes);
            Console.Write("\tSemanas: {0}  ", xsemanas);
            Console.WriteLine("\tDestinos: {0}  ", xdestinos);
            Console.WriteLine();
            Random numeroAleatorio = new Random();
            int viajeAleatorio;
            for(int camion=1; camion<=xcamion;camion ++)
            {
                Console.WriteLine("Camion: {0}", camion);
                for (int semana =1; semana <= xsemanas; semana ++)
                {
                    Console.WriteLine("Semana: {0}", semana);
                    for(int viajes=1; viajes<=xviajes; viajes ++)
                    {
                        viajeAleatorio = numeroAleatorio.Next(1, xdestinos + 1);
                        Console.Write(xarr_destinos[viajeAleatorio] + "\t");
                        xArr_3D[camion, semana, viajeAleatorio]++;
                        xArr_3D[camion, 0, viajeAleatorio]++;
                        xArr_3D[0, 0, viajeAleatorio]++;

                    }
                    pantalla_destinos(xdestinos, xarr_destinos);
                    escribe_destinos(camion, semana, xdestinos, xArr_3D);
                    Console.WriteLine("Total");
                    escribe_destinos(camion, 0, xdestinos, xArr_3D);
                    Console.WriteLine();

                }
            }
        }
        static void pantalla_programa(string mensaje)
        {
            Console.Clear();
            Console.Write("Universidad Panmaericana");
            Console.WriteLine("Melisa Ortiz Morante");
            Console.WriteLine("Programa {0}", mensaje);
            Console.WriteLine();
        }
        static void pantalla_destinos(int D, string[] xarr_dest)
        {
            Console.WriteLine();
            for(int destino=1; destino<= D; destino++)
            {
                Console.Write("({0}):{1}\t", destino, xarr_dest[destino]);
            }
            Console.WriteLine();
        }
        static void escribe_destinos(int C, int S, int D, int[,,] arreglo3D)
        {
            for(int destino=1;destino<=D; destino++)
            {
                Console.Write("{0,11}\t", arreglo3D[C, S, destino]);

            }
            Console.WriteLine();
        }
        static void resultados_finales(int C, int V, int D, int S, int [,,]xarr_viajes, int [,,]xArr_3D,string []xarr_destinos)
        {
            Console.WriteLine("\n Resultados Finales");
            Console.Write("Camiones: {0}", C);
            Console.Write("\tViajes:{0}", V);
            Console.Write("\tSemanas:{0}", S);
            Console.Write("\tDestinos:{0}", D);
            pantalla_destinos(D, xarr_destinos);
            escribe_destinos(0, 0, D, xArr_3D);

        }
        static char seguir_o_no()
        {
            Console.Write("\n\n¿Continua (s/n) <enter>?");
            char opcion = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            return opcion;
        }
        static void espera()
        {
            Console.Write("Presione <Enter> para salir );
            string salir = Console.ReadLine();
        }

        static void espera_inicio()
        {
            Console.Write("Presione <Enter> para empezar la ejecución");
            string salir = Console.ReadLine();
        }






    }
}
