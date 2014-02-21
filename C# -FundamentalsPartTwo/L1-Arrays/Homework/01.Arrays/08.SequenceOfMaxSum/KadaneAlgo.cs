
/*
   Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)? - YES
 
 */
using System;

class KadaneAlgo
{
    static void Main(string[] args)
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
        Console.WriteLine("{0}",String.Join(" ", numArray));

        //Kadane's Algorithm - http://en.wikipedia.org/wiki/Kadane%27s_Algorithm
        //the idea behind the algorithm is to check the sum  and until the sum is positive
        //to store it.

        //initialize
        long maxSoFar = 0;
        long maxEndingHere = 0;
        int begin = 0; 
        int end = 0; 
        //loop entire array
        for (int index = 0; index < numArray.Length; index++)
        {
                
            if (maxEndingHere <= 0)
            {
                maxEndingHere = 0;
                begin = index; //start of reseted sum index
            }
            maxEndingHere = maxEndingHere + numArray[index];
            if (maxSoFar < maxEndingHere)
            {
                end = index; // end of best sum index
                maxSoFar = maxEndingHere;
            }
        }

        //print results
        Console.WriteLine("The max sequential sum: " + maxSoFar);
        Console.WriteLine("The sum is result of following sequence");
        for (int i = begin; i <= end; i++)
        {
            Console.Write(numArray[i] + " ");
        }

    }
}

/*
 * Test Cases
 * 
 *  int[] numArray  = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
 *  
 * int [] numArray = { 1, 2, 3, -5, 3, 4, 5, -10, 1, 1, 2, -5 };
 * 
 *  int [] numArray = { 1, 2, -3, 4, -4, 1, 2, 3, 4 };
 * 
*/