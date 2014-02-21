/*
 * 01.
 * Write a program that reads a text file and prints on the console its odd lines.
 * 
 */
using System;
using System.IO;

class AddOddLines
{
    static void Main()
    {
        string path = @"..\..\Files\OddLines.txt";
        Console.WriteLine("Odd Lines from file ->");
        StreamReader reader = new StreamReader(path);
        using(reader)
	    {
            int count = 1;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (count++ % 2 != 0)
                {
                    Console.WriteLine("ln {0} -> {1}", count-1, line);
                }
            }
	    }
    }
}
