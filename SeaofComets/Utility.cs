using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaofComets
{
    public static class Utility
    {
        public static void Greeting(string message)
        {
            Console.WriteLine(message);
        }

        public static void ChangeBackgroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }

        public static void ChangeForegroundColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
}
