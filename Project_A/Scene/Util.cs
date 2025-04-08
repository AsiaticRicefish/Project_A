﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A.Scene
{
    public class Util
    {
        public static void Print(string context, ConsoleColor textColor, int delay = 0)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(context);
            Thread.Sleep(delay);
            Console.ResetColor();
        }

    }
}
