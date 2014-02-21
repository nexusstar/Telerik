/*
 * 07.
 * Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
 * Ensure it will work with large files (e.g. 100 MB).
 *
 * Note: I'm using BufferedStream to ensure working with large files
 * http://stackoverflow.com/questions/2161895/reading-large-text-files-with-streams-in-c-sharp
 * 
 * 08.
 * Modify the solution of the previous problem to replace only whole words (not substrings).
 * 
 * Note: I'm using regular expressions
 * http://msdn.microsoft.com/en-us/library/h5181w5w.aspx#WordBoundary
 */

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceSubstring
{
    public static void Main()
    {
        string path = @"..\..\Files\Start.txt";
        string pathResult = @"..\..\Files\Result.txt";
        Console.WriteLine("Loading...");
        try
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            int bufferSize = 10485760; //10MB  buffer size

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                for (long i = 0; i < 5000000; i++) //if you want 100mb files make it 1 000 000
                {
                    sw.WriteLine("This is some text to test");
                    sw.WriteLine("Reading repeated 500 time");
                    sw.WriteLine(" TEST TEXT:");
                    sw.WriteLine("testTextstart with startstart start");

                }

            }
            
            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (BufferedStream bs = new BufferedStream(fs, bufferSize))
                {
                    using (StreamWriter result = new StreamWriter(pathResult, false))
                    {
                        using (StreamReader sr = new StreamReader(bs))
                        {
                            
                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                // result.WriteLine(line.Replace("start", "finish")); // ex. 07
                                result.WriteLine(Regex.Replace(line, @"\bstart\b", "finish")); //ex. 08
                            }
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Operation failed: \n {0}", e.ToString());
        }

        Console.WriteLine("Success -> check Files dir in project");

    }
}