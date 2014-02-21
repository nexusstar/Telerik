/*
* 10. Write a program that converts a string to a sequence of C#
* Unicode character literals. Use format strings. 
* 
* Sample input:
* Hi!
* 
* Expected output:
* \u0048\u0069\u0021
*/

using System;
using System.Linq;
using System.Text;

class StringToUnicode
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string word = Console.ReadLine();

        Console.WriteLine("\nResult -> \n{0}", ConvertToUnicode(word));
    }

    static string ConvertToUnicode(string word)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < word.Length; i++)
        {
            result.AppendLine(string.Format("\\u{0:X4}", (int)word[i]));
        }
            

        return result.ToString();
    }
}