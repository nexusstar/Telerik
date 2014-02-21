/*
 * 12. Write a program that creates an array containing all letters from the alphabet (A-Z). 
 *     Read a word from the console and print the index of each of its letters in the array.
 */
using System;
using System.Collections.Generic;

class AllLettersArray
{
    static void Main()
    {
        char[] alphaOmega = new char[52]; 
        for (int i = 0; i < 26; i++) //for A-Z in english alphabet
        {
            alphaOmega[i] = Convert.ToChar(i+65);
            alphaOmega[i + 26] = Convert.ToChar(i + 97);
        }

        Console.Write("Please enter single word: ");
        string givenWord = Console.ReadLine();
        for (int i = 0; i < givenWord.Length; i++)
        {
            Console.WriteLine("Letter '{0}' -> index: {1} / ASCII index: {2}", 
                givenWord[i], Array.IndexOf(alphaOmega, givenWord[i]), (int)givenWord[i]);
        }

        //Console.WriteLine("{0}", String.Join(" ", alphaOmega));

    }
}

