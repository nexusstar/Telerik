﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.eXCHANGEvALUES
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a = {0}, b = {1}", a, b);
            
        }
    }
}
