/*
   Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)
 */

using System;

class MostFrequentNumber
{
    static void Main()
    {
        int sizeN;
        do
        {
            Console.Write("Enter size of the array: ");
        } while (!int.TryParse(Console.ReadLine(), out sizeN) && sizeN > 0);

        Console.WriteLine(new string('-', 20));
        int[] numArray = new int[sizeN];

        for (int index = 0; index < sizeN; index++)
        {
            do
            {
                Console.Write("Enter element{0}: ", index);
            } while (!int.TryParse(Console.ReadLine(), out numArray[index]));
        }

        //print array elements
        Console.WriteLine("Array elements: ");
        Console.WriteLine("{0}", String.Join(" ", numArray));
       
        //sort array in place using Array.Sort() method
        Array.Sort(numArray);
       
        //The idea is simple loop entire array and count matching number and store the best sum and num
        int longSoFar = 1;
        int maxSequence = 0;
        int bestMatch = numArray[0];
        int currentMatch = numArray[0];

        for (int index = 1; index < numArray.Length; index++)
        {
            if (currentMatch == numArray[index])
            {
                longSoFar++;
            }
            else
            {
                longSoFar = 1;
                currentMatch = numArray[index];

            }
            if (maxSequence < longSoFar)
            {
                maxSequence = longSoFar;
                bestMatch = numArray[index];
            }
        }
        Console.WriteLine(maxSequence);
        Console.WriteLine(bestMatch);
    }
}
