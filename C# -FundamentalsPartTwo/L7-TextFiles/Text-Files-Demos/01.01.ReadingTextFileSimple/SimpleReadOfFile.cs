using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._01.ReadingTextFileSimple
{
    class SimpleReadOfFile
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\..\Some.txt", Encoding.GetEncoding("windows-1251"));
            using (reader)
            {
                int line = 0;
                string lineStr = reader.ReadLine();
                while (lineStr  != null)
                {
                    line++;
                    Console.WriteLine("Line {0}: {1}", 
                        
                        line, lineStr );
                    lineStr = reader.ReadLine();
                }
            }
           
            //reader.Close();
        }
    }
}
