using System;

namespace E_SmileReloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int random_x;
            int random_y;
            int random;

            // Crear caracteres y leer las teclas
            ConsoleKeyInfo tecla;
            char smile = '☻';
            int max_ancho = 40; 
            int max_alto = 17;
            Console.SetCursorPosition(1, 1);
            Console.Write("Smile");
            int x = 2;
            int y = 2;
            Console.SetCursorPosition(x, y);

            Console.Write(smile);

            do
            {

                tecla = Console.ReadKey(false);
                switch (tecla.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (x <= max_ancho)
                        {
                            x++;
                            Console.Write(' ');
                            Console.SetCursorPosition(x, y);
                            Console.Write(smile);
                            Console.SetCursorPosition(85, 15);
                            Console.Write("" + x + ", " + y + "");
                            Console.SetCursorPosition(85, 15);
                            Console.Write("Derecha →");
                            Console.SetCursorPosition(x, y);
                        }
                        break;



                    case ConsoleKey.LeftArrow:
                        if (x > 1)
                        {
                            x--;
                            Console.Write (' ');
                            Console.SetCursorPosition(x, y);
                            Console.Write(smile);
                            Console.SetCursorPosition(85, 15);
                            Console.Write("" + x + ", " + y + "");
                            Console.SetCursorPosition(85, 15);
                            Console.Write("Izquierda ←");
                            Console.SetCursorPosition(x, y);

                        }
                        break;


                    case ConsoleKey.DownArrow:
                        if (y <= max_alto)
                        {
                            y++;
                            Console.Write (' ');
                            Console.SetCursorPosition(x, y);
                            Console.Write(smile);
                            Console.SetCursorPosition(85, 15);
                            Console.Write("" + x + ", " + y + "");
                            Console.SetCursorPosition(85, 15);
                            Console.Write("Abajo ↓");
                            Console.SetCursorPosition(x, y);

                        }
                        break;


                    case ConsoleKey.UpArrow:
                        if (y > 1)
                        {
                            y--;
                            Console.Write (' ');
                            Console.SetCursorPosition(x, y);
                            Console.Write(smile);
                            Console.SetCursorPosition(85, 15);
                            Console.Write("" + x + ", " + y + "");
                            Console.SetCursorPosition(85, 15);
                            Console.Write("Arriba ↑");
                            Console.SetCursorPosition(x, y);

                        }
                        break;



                    case ConsoleKey.Tab:
                        Console.Write(' ');
                        Random genAleatoriox = new Random();
                        Random genAleatorioy = new Random();

                        random_x = genAleatoriox.Next(2, 39);
                        random_y = genAleatorioy.Next(2, 16);
                        x = random_x;
                        y = random_y;
                        Console.SetCursorPosition(x, y);
                        Console.Write(smile);
                        Console.SetCursorPosition(85, 15);
                        Console.Write("" + x + ", " + y + "");
                        Console.SetCursorPosition(85, 15);
                        Console.Write("Aleatorio");
                        Console.SetCursorPosition(x, y);
                        break;

                    //Generar los aleatorios.

                    case ConsoleKey.Escape:
                        Random genAleatoriod = new Random();

                        random = genAleatoriod.Next(0, 5);

                        switch (random)
                        {
                            case 1:
                                if (x <= max_ancho)
                                {
                                    x++;
                                    Console.Write(' ');
                                    Console.SetCursorPosition(x, y);
                                    Console.Write(smile);
                                    Console.SetCursorPosition(85, 8);
                                    Console.Write("" + x + ", " + y + "");
                                    Console.SetCursorPosition(85, 12);
                                    Console.Write("Derecha →");

                                }
                                break;

                            case 2:
                                if (x > 1)
                                {
                                    x--;
                                    Console.Write(' ');
                                    Console.SetCursorPosition(x, y);
                                    Console.Write(smile);
                                    Console.SetCursorPosition(85, 8);
                                    Console.Write("" + x + ", " + y + "");
                                    Console.SetCursorPosition(85, 12);
                                    Console.Write("Izquierda ←");


                                }
                                break;

                            case 3:
                                if (y <= max_alto)
                                {
                                    y++;
                                    Console.Write (' ');
                                    Console.SetCursorPosition(x, y);
                                    Console.Write(smile);
                                    Console.SetCursorPosition(85, 8);
                                    Console.Write(""+x+", "+ y+"");
                                    Console.SetCursorPosition(85, 12);
                                    Console.Write("Abajo ↓");


                                }
                                break;

                            case 4:
                                if (y > 1)
                                {
                                    y--;
                                    Console.Write ( ' ');
                                    Console.SetCursorPosition(x, y);
                                    Console.Write(smile);
                                    Console.SetCursorPosition(85, 8);
                                    Console.Write("" + x + ", " + y + "");
                                    Console.SetCursorPosition(85, 12);
                                    Console.Write("Arriba ↑");


                                }
                                break;
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Write(' ');
                        Console.SetCursorPosition(x, y);
                        Console.Write(smile);
                        Console.SetCursorPosition(85, 8);
                        Console.Write("" + x + ", " + y + "");
                        Console.SetCursorPosition(85, 12);
                        Console.Write("Finalizado");
                        Console.SetCursorPosition(x, y);
                        break;
                }
            }
            while (true);
        }
    }
}
