/*
* 02.
 * Write a program that concatenates two text files into another text file.
*/

using System;
using System.IO;
using System.Linq;


class ConcatenateTwoFiles
{
    static void Main()
    {
        string pathFirst = @"..\..\Files\First.txt";
        string pathSecond = @"..\..\Files\Second.txt";
        string pathResult = @"..\..\Files\Result.txt";
        StreamWriter result = new StreamWriter(pathResult, true);
        StreamReader reader = new StreamReader(pathFirst);
        Console.WriteLine("Loading ...");
        using (result)
        {
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    result.WriteLine(reader.ReadLine());
                }
            }
        
            reader = new StreamReader(pathSecond);
        
            while (!reader.EndOfStream)
                {
                    result.WriteLine(reader.ReadLine());
                }
        }
        Console.WriteLine("Success ->");
    }
}
