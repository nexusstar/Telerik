﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void PrintList(IList<int> collection)
        {
            foreach (var number in collection)
            {
                Console.WriteLine(number);
            }
        }
    }
}
