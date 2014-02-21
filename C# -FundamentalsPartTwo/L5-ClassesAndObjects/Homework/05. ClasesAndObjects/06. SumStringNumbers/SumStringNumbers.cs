﻿/*
 * 06.
 * You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum.
 * Example:		string = "43 68 9 23 318" -> result = 461
 */
using System;

class SumStringNumbers
{
    static void Main()
    {
        Console.Write("Enter a text (containing numbers): ");
        string str = Console.ReadLine();

        //from documentation: 
        //If the separator parameter is null or contains no characters, white-space characters are assumed to be the delimiters.
        //default char = Null
        string[] tokens = str.Split(null as char[], StringSplitOptions.RemoveEmptyEntries);

        int sum = 0;

        for (int i = 0; i < tokens.Length; i++)
        {
            int number = 0;
            sum += int.TryParse(tokens[i], out number) ? number : 0;
        }

        Console.WriteLine("\nSum of numbers: {0}\n", sum);
    }
}