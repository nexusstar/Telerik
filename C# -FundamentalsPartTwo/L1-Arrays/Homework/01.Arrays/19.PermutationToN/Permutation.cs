/*
*   19. Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
*   Example: n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
*/
using System;

class Permutation
{
    static void Main()
    {
        Console.Write("Please enter how big is the set N: ");
        int givenN = int.Parse(Console.ReadLine()); // 3;
        int givenK = givenN;

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
            if (IsElementsDifferent(result))
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

    static bool IsElementsDifferent(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
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
