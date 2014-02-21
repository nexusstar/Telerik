/*
* 13. Write a program that reverses the words in given sentence.
* Example: 
* "C# is not C++ not PHP and not Delphi!" -> "Delphi not and PHP not C++ not is C#!".
*/

using System;
using System.Linq;

class ReverseWords
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";

        char sentenceEnd = input[input.Length - 1]; //get punctuation at the end of sentence;
        input = input.Remove(input.Length - 1, 1);

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        Console.WriteLine("Result: {0}{1}\n", string.Join(" ", words), sentenceEnd);
    }
}