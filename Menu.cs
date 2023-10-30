using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    static class Menu
    {
        static int minStrelochka = 2;
        
        public static int Show(int maxStrelochka = 9)
        {
            int position = 3;
            ConsoleKeyInfo key;

            do
            {
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("   ");
                if (key.Key == ConsoleKey.UpArrow && position != minStrelochka)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow && position != maxStrelochka)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    return -1;
                }
                 
               
            } while (key.Key != ConsoleKey.Enter);
            return position;
        }


    }
}
