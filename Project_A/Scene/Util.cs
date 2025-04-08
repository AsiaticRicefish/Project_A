using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Scene
{
    public static class Util
    {
        public static void Print(string context, ConsoleColor textColor, int delay = 0)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(context);
            Thread.Sleep(delay);
            Console.ResetColor();
        }

        public static void PressAnyKey(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("계속하려면 아무키나 누르세요");
            Console.ReadKey(true);
        }

    }
}
