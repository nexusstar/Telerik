/*
 * 23.
 * Write a program that reads a string from the console and replaces all
 * series of consecutive identical letters with a single one. 
 * Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

class ReplaceRepeats
{
    static void Main(string[] args)
    {
        string input = "aaaaabbbbbcdddeeeedssaa";
        
        StringBuilder result = new StringBuilder();
        char currentToken = input[0];
        for (int i = 1; i < input.Length; i++)
        {
            if (currentToken != input[i])
            {
                result.Append(currentToken);
            }
                currentToken = input[i];
        }
        if (currentToken != result[result.Length - 1])
        {
            result.Append(currentToken);
        }
        Console.WriteLine("Input string \n{0}\nResult:\n{1}", input, result.ToString());
    }
}
