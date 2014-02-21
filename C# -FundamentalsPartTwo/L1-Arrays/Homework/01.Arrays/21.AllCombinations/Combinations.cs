/*
* 21. Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
* Example:	N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
*           N = 3, K = 2 -> {1, 2}, {1, 3}, {2, 3}
*/
using System;

class Combinations
{
    static void Main()
    {
        Console.Write("Please enter how big is the set N: ");
        int givenN = int.Parse(Console.ReadLine()); // 3;
        Console.Write("Please enter how many elements K: ");
        int givenK = int.Parse(Console.ReadLine()); // 2;

        //initialize array
        int[] result = new int[givenK];
        int count = 1;

        //fill array with 1
        for (int index = 0; index < result.Length; index++)
        {
            result[index] = count;
        }


        do
        {
            count = 1;
            if (IsReversedArrayInIncrease(result))
            {
                PrintVariation(result);
            }
            for (int index = 0; index < givenK; index++)
            {
                result[index] += count;
                if (result[index] <= givenN)
                {
                    count = 0;
                    break;
                }
                else
                {
                    count = 1;
                    result[index] = count;

                }
            }
        } while (count != 1);

    }

    static bool IsReversedArrayInIncrease(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] <= array[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void PrintVariation(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
