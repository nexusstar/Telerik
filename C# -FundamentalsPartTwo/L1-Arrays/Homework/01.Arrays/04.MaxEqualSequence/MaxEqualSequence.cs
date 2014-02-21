/*
        Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}. 
 */

using System;
using System.Collections.Generic;

class MaxEqualSequence
{
    //global variables to hold sequence element and sequence length
    static int seqN = 0; 
    static int seqCount = 0;
    
    static void Main(string[] args)
    {
        
        int sizeOfArray;
        do
        {
            Console.Write("Enter size of the array: ");
        } while (!int.TryParse(Console.ReadLine(), out sizeOfArray));
        Console.WriteLine(new string('-', 20));

        //initialize array
        int[] arrayOfNumbers = new int[sizeOfArray];
        FillingArray(sizeOfArray, arrayOfNumbers);

        //find best sequence
        FindBestSequence(arrayOfNumbers);

        //printing result
        Console.WriteLine("\nArray elements \n\n {0}", string.Join(" ", arrayOfNumbers));
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Max sequence of elements");
        for (int i = 0; i < seqCount; i++)
        {
            Console.Write(seqN + " ");
        }
        Console.WriteLine();
        
    }

    
    //Helper method to fill int array of size "size"
    private static void FillingArray(int size, int[] array)
    {
        for (int el = 0; el < size; el++)
        {
            int temp;
            do
            {
                Console.Write("Arr[{0}] = ", el);
            } while (!int.TryParse(Console.ReadLine(), out temp));

            array[el] = temp;
        }
        Console.WriteLine(new string('-', 20));
    }

    //Helper method to find best sequence of elements
    private static void FindBestSequence(int[] array)
    {
        int currentSequence = 0;
        int currentElement = array[0];
        seqN = 0; seqCount = 0; //reset global values

        for (int i = 1; i < array.Length; i++) //we are starting from second element
        {
            if (currentElement == array[i])
            {
                currentSequence++;
            }
            else {
                currentElement = array[i];
                currentSequence = 1;
            }
            if(currentSequence > seqCount)
            {
                seqCount = currentSequence;
                seqN = currentElement;
            }
        }
    }
}