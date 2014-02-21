/*
 * 
 * ex 01. Write a program that allocates array of 20 integers 
 * and initializes each element by its index multiplied by 5.
 * Print the obtained array on the console.
 * 
 */

using System;

class ArrayOfTwenty
{
    static void Main()
    {
        //allocates array of 20 integers
        int[] intArray = new int[20];

        //initializes each element by its index multiplied by 5
        for (int index = 0; index < intArray.Length; index++)
        {
            intArray[index] = index * 5;
        }
        
        //print the obtained array
        for (int index = 0; index < intArray.Length; index++)
        {
            Console.WriteLine(String.Format("{0, 2} -> {1, 2}", index, intArray[index]));
        }

    }
}