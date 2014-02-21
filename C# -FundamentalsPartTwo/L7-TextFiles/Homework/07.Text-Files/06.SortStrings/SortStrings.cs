
/*
* 6. Write a program that reads a text file containing a list of strings,
* sorts them and saves them to another text file.
*   
*                   Example:       
*                                  
*           Ivan		   George  
*           Peter		   Ivan    
*           Maria   ---->  Maria   
*           George	       Peter   

*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _06.SortStrings
{
    class SortStrings
    {
        static void Main()
        {
            string pathStart = @"..\..\Files\Start.txt";
            string pathResult = @"..\..\Files\Result.txt";
            List<string> strings = new List<string>();

            using (StreamReader reader = new StreamReader(pathStart))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] tokens = line.Split(new char[] { ' ', '\n', ',', '.' }, 
                        StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < tokens.Length; i++)
                    {
                        strings.Add(tokens[i]);
                    }
                }
            }
            Console.WriteLine("Readed unorderd strings: ");
            Console.WriteLine(string.Join(", ", strings.ToArray()));
            
            strings.Sort();

            Console.WriteLine("Sorted strings: ");
            Console.WriteLine(string.Join(", ", strings.ToArray()));

            //write result to file
            using (StreamWriter writer = new StreamWriter(pathResult,false))
            {
                for (int i = 0; i < strings.Count; i++)
                {
                    writer.WriteLine(strings[i]);
                }
            }
        }
    }
}
