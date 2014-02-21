/* 01. Describe the strings in C#. What is typical for the string data type? 
*     Describe the most important methods of the String class.
*/

using System;
using System.Collections.Generic;


class DescribeStrings
{
    static void Main()
    {
        List<string> info = new List<string> {
        "Strings are collections of characters. Strings are actualy char arrays.                                                                   ",
        "Strings are readOnly - That means that they cannot be modified.                                                                           ",
        "If you want to modify string\n - you must create new string and copy all of the old characters to it\n - together with the new characters     ",
        "Strings are referal type of object in C#. That means that they use the Heap memory for storage.                                           ",
        "One of the most important String Methods are:                                                                                             ",
        " - Split:\n this one splits the string into other string[] array based on specified delimiter                                               ",
        " - IndexOf: Returns the position (index) of the first occurance of the specified character or substring                                   ",
        " - Concat / \n: You can concatenate or join multiple strings onto one with specific delimiter of desired                                ",
        " - Replace:\n It replaces specific substring with new one                                                                                   ",
        " - Length:\n This one returns the length of the string(the length of the char[] array)                                                      ",
        " - Substring:\n Crop part of the string based on Starting index and crop length                                                             ",
        " - ToUpper, ToLower \n- this are self explanatory. Uppers or Lowers the case of the string.                                                          ",
        " - Trim, TrimEnd, TrimStart:\n Removes the whitespace at the start and at the end of the string                                             ",
        "- Padleft and PadRight\n - Trimming a string removes extra characters on either end. Padding a string instead adds extra characters."
        };
        foreach (var item in info)
        {
            Console.WriteLine(item + "\n");
            Console.ReadKey();
        }
    }
}