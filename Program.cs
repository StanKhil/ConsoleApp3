using System;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Paint over everything!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\n\n\n\n");
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < 20; i++) { Console.Write("-"); }
            Console.Write("\n");
            for (int i = 0; i < 15; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("            ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("|");
                for (int j = 1; j < 19; j++) { Console.Write(" "); }
                Console.Write("|\n");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("            ");
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < 20; i++) { Console.Write("-"); }
            Console.Write("\n");
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.BackgroundColor= ConsoleColor.Green;
            int x = 20;
            int y = 15;
            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey(true);
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write(" ");

                if (k.Key == ConsoleKey.LeftArrow || k.Key == ConsoleKey.A){
                    if (x != 13) x--;
                    else  x = 30; 
                }
                else if (k.Key == ConsoleKey.RightArrow || k.Key == ConsoleKey.D)
                {
                    if (x != 30) x++;
                    else x = 13;
                }
                else if (k.Key == ConsoleKey.DownArrow || k.Key == ConsoleKey.S)
                {
                    if (y != 21) y++;
                    else y = 7;
                }
                else if (k.Key == ConsoleKey.UpArrow || k.Key == ConsoleKey.W)
                {
                    if (y != 7) y--;
                    else y = 21;
                }
               
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.WriteLine((char)1);
            }
            Thread.Sleep(15); 
        }
    }
}