/*
 * 
 * Write a program that finds the maximal increasing sequence in an array.
 * Example: {3, 2, 3, 4, 2, 2, 4}->{2, 3, 4}.
 * 
 */
using System;
using System.Collections.Generic;

 class MaxAraySequence
{
    static void Main()
    {
        int size;
        do
        {
            Console.Write("Enter size of arrray: ");
        } while (!int.TryParse(Console.ReadLine(), out size) && size > 0);

        //initialize array
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            do
            {
                Console.Write("Enter element{0}: ", i);
            } while (!int.TryParse(Console.ReadLine(), out array[i]));
        }
        
        //finding the best sequence
        int currentNumber = array[0]; 
        int sequenceCount = 1;
        int bestSequence = 1;
        int lastIndex = 0;
        
        for (int element = 1; element < array.Length; element++)
        {
            if (currentNumber < array[element])
            {
                sequenceCount++;
                currentNumber = array[element];
                lastIndex = element;
            }
            else if (currentNumber > array[element])
            {
                if (bestSequence < sequenceCount)
                {
                    bestSequence = sequenceCount; 
                }
                sequenceCount = 1;
                currentNumber = array[element];
                
            }
        }

        //if we go out of for loop with new best 
        if (sequenceCount > bestSequence)
        {
            bestSequence = sequenceCount;
        }

        //printing the result
        Console.WriteLine("\nArray elements \n {0}", string.Join(" ", array));
        Console.WriteLine(new string('-', 20));
        
        Console.WriteLine("Max sequence of elements");
        if (array.Length == 1)
        {
            Console.WriteLine(array[0]);
        }
        else
        {
            for (int i = 0; i < bestSequence; i++)
            {
                Console.Write(array[lastIndex - bestSequence + 1 + i] + " ");

            }
            Console.WriteLine();
        }
        
        Console.WriteLine(new string('-', 20));

    }
}

 /*
  * { 1, 2, 3, 4, 1, 2, 3, 4, 5 }; - {1,2,3,4,5}
  * {1}; - {1}
  * 
  * 
 */