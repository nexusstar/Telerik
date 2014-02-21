/*
 * Sorting an array means to arrange its elements in increasing order.
 * Write a program to sort an array.
 * Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.
 * 
 */

using System;
using System.Collections.Generic;

class SelectionSort
{
    static void Main()
    {
        int sizeOfArray;
        do
        {
            Console.Write("Enter size of the array: ");
        } while (!int.TryParse(Console.ReadLine(), out sizeOfArray));
        Console.WriteLine(new string('-', 20));
        
        //initialize array
        int[] arrayOfNumbers = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            do
            {
                Console.Write("Enter element{0}: ", i);
            } while (!int.TryParse(Console.ReadLine(), out arrayOfNumbers[i]));
        }

        //print array before sorting
        Console.WriteLine("\nArray elements \n {0}", string.Join(" ", arrayOfNumbers));
        Console.WriteLine(new string('-', 20));

        //selection sort algorithm        
        for (int index = 0; index < arrayOfNumbers.Length; index++)
        {
            //assume the current Number with index is minimum
            int indexMin = index;

            //test against alements after current element to find the smallest
            for (int nextIndex = index+1; nextIndex < arrayOfNumbers.Length; nextIndex++)
            {
                if (arrayOfNumbers[nextIndex] < arrayOfNumbers[indexMin])
                {
                    //found new minimum remember its index
                    indexMin = nextIndex;
                }
            }
            //indexMin is the index of found min number swap it with current position
            if (indexMin != index)
            {
                arrayOfNumbers[index] = arrayOfNumbers[index] ^ arrayOfNumbers[indexMin];
                arrayOfNumbers[indexMin] = arrayOfNumbers[index] ^ arrayOfNumbers[indexMin];
                arrayOfNumbers[index] = arrayOfNumbers[index] ^ arrayOfNumbers[indexMin];

            }
        }

        //print array after sorting
        Console.WriteLine("\nSorted Array elements \n {0}", string.Join(" ", arrayOfNumbers));
        Console.WriteLine(new string('-', 20));
    }
}