/*
 * 10. Write a program that finds in given array of integers a sequence of given sum S (if present).
 *     Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
 */
using System;

class SequenceOfSum
{
    
    static void Main()
    {
        int sizeN;
        do
        {
            Console.Write("Enter size of the array: ");
        } while (!int.TryParse(Console.ReadLine(), out sizeN) && sizeN > 0);

        long sumWeSeek;
        do
        {
            Console.Write("Enter size of the array: ");
        } while (!long.TryParse(Console.ReadLine(), out sumWeSeek));

        Console.WriteLine(new string('-', 20));
        int[] numArray = new int[sizeN];

        for (int index = 0; index < sizeN; index++)
        {
            do
            {
                Console.Write("Enter element{0}: ", index);
            } while (!int.TryParse(Console.ReadLine(), out numArray[index]));
        }

        //int[] numArray = { 2, 7, -4, 5, 2, 3, 1, 2, 3 };
        //long sumWeSeek = 5;

        //print array elements
        Console.WriteLine("Array elements: ");
        Console.WriteLine("{0}", String.Join(" ", numArray));
        
        Console.WriteLine("\n" + new string('-', 40));
        Console.WriteLine("Sequences with sum {0}: ", sumWeSeek);
        
        long currentSum = 0;
        int begin = 0;
        int end = 0;
        bool noSuchSum = true;
        //loop entire array
        for (int index = 0; index < numArray.Length; index++)
        {
            if (numArray[index] == sumWeSeek) //number is exactly the sum
            {
                end = index;
                begin = index;
                PrintSequece(begin, end, numArray);
                noSuchSum = false;
                continue;
            }

            currentSum = numArray[index]; //start
            begin = index;
            
            
            for (int j = index+1; j < numArray.Length; j++)
            {
                currentSum = currentSum + numArray[j];
                if (currentSum == sumWeSeek)
                {
                    end = j;
                    PrintSequece(begin, end, numArray);
                    noSuchSum = false;
                    break;
                }
                
                
            }
        }

        if (noSuchSum)
        {
            Console.WriteLine("There are no such sequences Sorry!");
        }
        
    }
    //Helper method to Print Sequences of original array
    private static void PrintSequece(int begin, int end, int[] array)
    {
        for (int i = begin; i <= end; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(); 
    }
}
