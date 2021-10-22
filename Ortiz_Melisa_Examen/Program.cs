using System;

namespace Ortiz_Melisa_Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encabezado del programa y nombre
            Console.WriteLine("Programa realizado por: Melisa Ortiz Morante (0221077)\n");
            Console.WriteLine("Ingenieria Mecatronica\n");
            Console.WriteLine("Programa que solicita nombre y ID del alumno, asi como un alnalisis de la descomposicion del ID\n");


            //Variables
            string nombre;
            int ID;
            int max = 100000;
            int min = 399999;
            int programa;
            int num1;
            int num2;
            int num3;
            int mayor;
            int menor;
            int suma;


            //Pedir variables
            //Pedir nombre
            Console.Write("Hola, ¿Cual es tu nombre?:  ");
            nombre = Convert.ToString(Console.ReadLine()); 
            Console.WriteLine("Su nombre es:  " + nombre);

            //Generarle un ID al usuario
            Random generadorAleatorio = new Random();
            ID = generadorAleatorio.Next(100000, 399999);
            Console.WriteLine("Su ID es: \n" + ID);



            //Menu para que el usario seleccione
            Console.WriteLine("Primero seleccione que desea analizar del ID \n");

            //Menu
            Console.WriteLine("Presione {1} para descomoner el ID en tres partes\n");
            Console.WriteLine("Presione {2} para sumar las tres partes en las que se divide el ID\n");
            Console.WriteLine("Presione {3} para determinar cual es el mayor y cual es el menor\n");
            Console.WriteLine("Presione {4} para ver el rango de menor a mayor de los tres numeros");
            programa = Convert.ToInt32(Console.ReadLine());


            //Ciclo para eleccion de lo que se busca analizar
            switch (programa )
            {
                case 1: //Parte 1: Descomposicion en tres partes
                    Console.WriteLine("Programa que descompone el Id en tres partes\n");

                    num1 = (ID / 10000);
                    num2 = (ID / 100) %100;
                    num3 = (ID % 100);

                    Console.WriteLine("La descomposicion en tres partes es " + num1 + "... " + num2 + "... y " + num3 + "");

                   break;

                case 2: //PArte 2: Suma de los tres numeros a base de la descomposicion anterior
                    num1 = (ID / 10000);
                    num2 = (ID / 100) % 100;
                    num3 = (ID % 100);

                    suma = num1 + num2 + num3;
                    Console.WriteLine("La suma de la descomposicion en tres numeros del ID es: " + suma);

                    break;

                case 3: //Parte 3:Determinar cual de los dos tres numeros es mayor.

                    num1 = (ID / 10000);
                    num2 = (ID / 100) % 100;
                    num3 = (ID % 100);


                    if (num1 > num2)
                    {
                        mayor =num1 ;
                       
                        Console.WriteLine("El numero mayor es: ....." + mayor);
                    }
                    else if (num3> num1)
                    {
                        mayor = num3;

                        Console.WriteLine("El numero mayor es: ....." + mayor);

                    }
                    if (num2 >num3 )
                    {

                        menor = num3;
                    
                        Console.WriteLine("El numero menor es:...." + menor);
                        
                    }

                    else if (num3>num2)
                    {
                        mayor = num3;
                        Console.WriteLine("El numero mayor es: ....." + mayor);


                    }

                         break;

                case 4: //Rango ascendente
                    num1 = (ID / 10000);
                    num2 = (ID / 100) % 100;
                    num3 = (ID % 100);

                   


                    break;

            }





            //Espera
            Console.WriteLine("Programa exitoso, oprima <enter> para salir.....");
            string espera = Console.ReadLine();
















        }
    }
}
