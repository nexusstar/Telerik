/*
* 03. 
*  Write a program that reads a text file and inserts line numbers in front of 
*  each of its lines.The result should be written to another text file.
*/

using System;
using System.IO;
using System.Linq;

class InsertLineNumbers
{
    static void Main()
    {
        string pathFirst = @"..\..\Files\First.txt";
        string pathResult = @"..\..\Files\Result.txt";
        StreamWriter resultWriter = new StreamWriter(pathResult, true);
        StreamReader reader = new StreamReader(pathFirst);
        Console.WriteLine("Loading ...");
        int counter = 0; 
        using (resultWriter)
        {
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    resultWriter.WriteLine(++counter +" " + reader.ReadLine()); 
                } 
            }
        }
        Console.WriteLine("Success..e");
    }
}
