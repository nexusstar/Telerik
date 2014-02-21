/*
* 9. We are given a string containing a list of forbidden words and 
* a text containing some of these words. Write a program that replaces the 
* forbidden words with asterisks.
* 
* Example:
* Microsoft announced its next generation PHP compiler today. 
* It is based on .NET Framework 4.0 and is implemented as 
* a dynamic language in CLR.
* 
* Words: "PHP, CLR, Microsoft"
* The expected result:
* ********* announced its next generation *** compiler today. 
* It is based on .NET Framework 4.0 and is implemented as 
* a dynamic language in ***.
*/

using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class BlackListReplace
{
    static void Main()
    {
        string text = @"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string[] blackList = { "PHP", "CLR", "Microsoft" };

        string result = ReplaceBlackListedWords(text, blackList);
        
        Console.WriteLine("Censored text:");
        Console.WriteLine(result);
    }

    private static string ReplaceBlackListedWords(string text, string[] blackList)
    {
        StringBuilder result = new StringBuilder(text);
        for (int i = 0; i < blackList.Length; i++)
        {
            result.Replace(blackList[i], new string('*', blackList[i].Length));
        }
        return result.ToString();
    }
}