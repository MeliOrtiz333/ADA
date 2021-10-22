using System;

namespace Transportista_F
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            do
            {
                Console.Clear();
                int camiones, viaje, queretaro = 0, guadalajara = 0, toluca = 0, leon = 0;
                pantalla_programa("Programa que calcula el numero de viajes por camion de manera aleatoria");
            
                continuar = seguir_o_no();
            }
            while (continuar == 's' || continuar == 'S');
            espera();
        }


        static void pantalla_programa(string mensaje)
        {
            Console.Clear();
            Console.Write("Universidad Panamericana   ");
            Console.WriteLine("Escuela de Ingeniería  ");
            Console.WriteLine("Melisa Ortiz Morante");
            Console.WriteLine("Programa {0}  ", mensaje);
            Console.WriteLine();
        }
        static int pidevalor(string cadenadecaracteres)
        {
            int salida;
            Console.WriteLine("{0}", cadenadecaracteres);
            salida = Convert.ToInt32(Console.ReadLine());
            return salida;

        }

        static void lugar(ref int queretaro, ref int guadalajara, ref int  toluca, ref int leon)
        {
           int  viaje = pidevalor("La cantidad de viajes");
           int camiones = pidevalor("La cantidad de camiones");
            for (int i = 1; i <= camion; i++)
            {
                lugar(viaje, i, ref queretaro, ref guadalajara, ref toluca, ref leon);
                Console.WriteLine("");
            }
            Console.WriteLine("\nQueretaro\tGuadalajara\tToluca\tLeon");
            Console.WriteLine("{0}\t\t\t{1}\t\t\t{2}\t\t\t{3}", queretaro, guadalajara, toluca, leon);

        }

        public static void camion(int camiones, int viajes, ref int queretaro, ref int guadalajara, ref int toluca, ref int leon)
        { 
            int caso, queretaroL, guadalajaraL, tolucaL, leonL;
            queretaroL, guadalajaraL, tolucaL,leonL = 0
            Console.WriteLine("");
            Console.WriteLine("Camnion: {0}", camiones);
            for (int i = 1; i <= viajes; i++)
            {
                Random generadorAleatorio = new Random();
                caso = generadorAleatorio.Next(1, 5);

                switch (caso)

                 caso 1:
                Console.Write("\nQueretaro\t");
                queretaro++;
                queretaroL++;
                break;

                caso 2:
                Console.Write("\nGuadalajara\t");
                guadalajara++;
                guadalajaraL++;
                break;

                caso 3:
                Console.Write("\nToluca\t");
                toluca++;
                tolucaL++;
                break;

                caso 4:
                Console.Write("\nLeon\t");
                leon++;
                leonL++;
                break;


            }
            Console.WriteLine("\nQueretaro\tGuadalajara\tToluca\tLeon");
            Console.WriteLine("{0}\t\t\t{1}\t\t\t{2}\t\t\t{3}", queretaro, guadalajara, toluca, leon);
        }


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
            Console.Write("Presione <Enter> para salir . . . ¡Adios!");
            string salir = Console.ReadLine();

        }

    }
}
