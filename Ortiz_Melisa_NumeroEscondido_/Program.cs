using System;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encabezado del programa 
            Console.WriteLine("Juego para adivinar un numero aleatorio, indicando si es mayor o menor");

            //Variables
            int numero;
            int aleatorio;
            int contador = 0;
            int nivel;
            int max = 0;
            int intentos = 1;
          

            Console.WriteLine("Decida que nivel desea jugar");

            //Eleccion del nivel
            Console.WriteLine("Nivel basico {1} : 0 a 50");
            Console.WriteLine("Nivel intermedio {2} : 0 a 500");
            Console.WriteLine("Nivel avanzado {3} : 0 a 999 ");
            nivel = Convert.ToInt32(Console.ReadLine());



            //Ciclo para nivel
            switch (nivel)
            {
                case 1:
                    max = 50;

                    break;
                case 2:
                    max = 500;

                    break;

                case 3:
                    max = 999;

                    break;


            }
            Console.WriteLine("El nivel sera de 0 a  " + max);

            //Generador de  humero aleatorio.
            Random generadorAleatorio = new Random();


            aleatorio = generadorAleatorio.Next(0, max);

            //Inicio del juego 
            for (contador = 1; contador <= aleatorio; contador++)
            {
                



                Console.Write("Ingrese el numero que crea que es incognito: ");
                numero = Convert.ToInt32(Console.ReadLine());



               

                    if (aleatorio > numero)
                    {
                    
                    
                        Console.WriteLine("No, el numero es mas grande");
                    intentos = intentos + 1;
                    }
                       
                    

                    if (aleatorio < numero)
                    {

                    
                        Console.WriteLine("No, el numero es mas pequeño");
                        intentos = intentos + 1;
                    }

                    else if (aleatorio == numero)
                    {
                        Console.WriteLine("Adivinaste el numero");
                        Console.WriteLine("Lo lograste en el siguiente numero de intentos... " + intentos);


                        aleatorio = numero;
                        break;
                    
                    }


                

            }   

            //Espera
            Console.WriteLine("Para volver a jugar presione <enter>........");
            string espera = Console.ReadLine();




































        }
    }
}
