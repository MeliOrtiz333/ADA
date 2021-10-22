using System;

namespace ADA_2021_ConsApp_20210921_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leer teclas
            ConsoleKeyInfo tecla;
            char smile = '☻';
            int max_ancho = 50; 
            int max_alto = 15;
            Console.SetCursorPosition(1, 1);
            Console.Write("Smile");
            int x = 1;
            int y = 2;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(smile);

            do
            {
                tecla = Console.ReadKey(false);
                switch (tecla.Key)
                {


                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(x, y); Console.Write(' ');
                        Console.SetCursorPosition(1, 1);
                        Console.Write("Derecha ");
                        if (x < max_ancho) x++;
                        Console.SetCursorPosition(x, y);
                        Console.Write(smile);
                        break;



                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(x, y); Console.Write(' ');
                        Console.SetCursorPosition(1, 1);
                        Console.Write("Izquierda ");
                        if (x>1) x--;
                        Console.SetCursorPosition(x, y);
                        Console.Write(smile);
                        break;


                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(x, y); Console.Write(' ');
                        Console.SetCursorPosition(1, 1);
                        Console.Write("Arriba " );
                        if (y>2) y--;
                        Console.SetCursorPosition(x, y);
                        Console.Write(smile);
                        break;

                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(x, y); Console.Write(' ');
                        Console.SetCursorPosition(1, 1);
                        Console.Write("Abajo ");
                        if (y< max_ancho ) y++;
                        Console.SetCursorPosition(x, y);
                        Console.Write(smile);
                        break;

                    case ConsoleKey.Tab:
                        Console.SetCursorPosition(51, 1); Console.Write("      ");
                        Console.SetCursorPosition(51, 1);
                        Console.Write("{0}, {1}", x, y);
                        break;




                }
            }
            while (tecla.Key != ConsoleKey.Spacebar);
        }
    }
}
