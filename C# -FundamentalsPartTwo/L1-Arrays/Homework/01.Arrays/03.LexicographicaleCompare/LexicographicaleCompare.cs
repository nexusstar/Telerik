/*
 * 
 * Write a program that compares two char arrays
 * lexicographically (letter by letter).
 * 
 */

using System;
using System.Collections.Generic;

class LexicographicaleCompare
{
    static void Main()
    {
        //InitializeArrays
        Console.Write("Enter first string : ");
        char[] firstArray = Console.ReadLine().ToCharArray();
        Console.Write("Enter second string: ");
        char[] secondArray = Console.ReadLine().ToCharArray();

        //CompareArrays length and lexicographical position of elements

        CompareTwoCharArrays(firstArray, secondArray);

    }

    //Helper Method to compare arrays
    static void CompareTwoCharArrays(char[] firstArray, char[] secondArray)
    {
        if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine("\nThe second string is lexicographically before the first");
            Console.WriteLine("Result: \n");

            //compare two arrays element by element to the lenght of firstArray
            CompareElementByElement(firstArray, secondArray);

        }
        else if (firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("\nThe first string is lexicographically before the second");
            Console.WriteLine("Result: \n");

            //compare two arrays element by element to the lenght of secondArray
            CompareElementByElement(secondArray, firstArray);
        }
        else 
        {
            Console.WriteLine("\nThe two arrays have equal sizes.");
            Console.WriteLine("Result: \n");

            //compare two arrays element by element
            CompareElementByElement(firstArray, secondArray);
        }
    }

    //Helper method going through array element by element and compare them
    static void CompareElementByElement(char[] longerArray, char[] shorterArray)
    {
        for (int i = 0; i < shorterArray.Length; i++)
            {
                if (longerArray[i] < shorterArray[i])
                {
                    Console.WriteLine("{0} is before {1}", longerArray[i], shorterArray[i]);
                    
                }
                else if (longerArray[i] > shorterArray[i])
                {
                    Console.WriteLine("{0} is after {1}", longerArray[i], shorterArray[i]);

                }
                else 
                {
                    Console.WriteLine("{0} is equal to {1}", longerArray[i], shorterArray[i]);
                }

            }
    }
}