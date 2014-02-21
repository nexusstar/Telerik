/*
* 04. 
* Write a program that compares two text files line by line and prints 
 * the number of lines that are the same and the number of lines that are different. 
 * Assume the files have equal number of lines.
 */


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class DiffOFfiles
{
    static List<int> equalLines = new List<int>();
    static List<int> diffLines = new List<int>();

    static void Main()
    {
        string pathFirst = @"..\..\Files\First.txt";
        string pathSecond = @"..\..\Files\Second.txt";

        StreamReader reader = new StreamReader(pathFirst);
        int equalCount = 0;
        int diffCount = 0;
        int count = 0;
        Console.WriteLine("Loading...");
        using (reader)
        {
            using (StreamReader readerSecond = new StreamReader(pathSecond))
            {
                while (!readerSecond.EndOfStream || !reader.EndOfStream)
                {
                    ++count;
                    if (String.Compare(readerSecond.ReadLine(), reader.ReadLine(), false) == 0) //comparing honoring the case
                    {
                        equalCount++;
                        equalLines.Add(count);
                    }
                    else
                    {
                        diffCount++;
                        diffLines.Add(count);
                    }
                }
            }
        }
        Console.WriteLine("Success in comparing files");

        Console.WriteLine("Result -> \n {0} equal \n {1} different", equalCount, diffCount );
        Console.Write("Equal lines: ");
        Console.WriteLine(string.Join(", ", equalLines.ToArray()));
        Console.Write("Different lines: ");
        Console.WriteLine(string.Join(", ", diffLines.ToArray()));
        
        
    }
}
