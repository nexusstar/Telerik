/*
* 4. Write a program that finds how many times a substring is contained in a 
* given text (perform case insensitive search).
* 
* Example: The target substring is "in". The text is as follows:
*  
*   "We are living in an yellow submarine. We don't have anything else.  
*   Inside the submarine is very tight. So we are drinking all the day. 
*   We will move out of it in 5 days."                                   
*  
*   The result is: 9.

*/

using System;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;

namespace _04.CountSubstrings
{
    class CountSubstrings
    {
        static void Main()
        {
            string text = @"We are living in an yellow submarine. We don't have anything else.
        Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";                             

            string pattern = "in";
            
            Stopwatch sw = new Stopwatch();
            
            sw.Start();
            int countedPattern = CountSubstring(text,pattern);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            sw.Restart();
            
            //usefull example is regex faster than iterative approach
            sw.Start();
            int countedPatternRegex = CountSubstringWithRegex(text, pattern);
            sw.Stop();
            
            Console.WriteLine(sw.Elapsed);

            Console.WriteLine("Searched [{0}] in text: ", pattern);
            Console.WriteLine(text);
            Console.Write("\nResult -> iterative: {0} regex:{1}\n ", countedPattern, countedPatternRegex);
        }

        private static  int CountSubstring(string input, string search)
        {
            int index = input.IndexOf(search, StringComparison.OrdinalIgnoreCase);
            int count = 0;

            while (index != -1)
            {
                count++;
                index = input.IndexOf(search, index + 1, StringComparison.OrdinalIgnoreCase);
            }
            return count;
        }
        private static int CountSubstringWithRegex(string input, string pattern)
        {
            return Regex.Matches(input, pattern, RegexOptions.IgnoreCase).Count;
        }
    }
}
