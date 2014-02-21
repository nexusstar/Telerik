/*
 * ex. 17. Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
 *  Find in the array a subset of K elements that have sum S or indicate about its absence.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;

class FindSubsetK
{
    static bool isFoundSubset = false;

    static void Main()
    {
        //TESTS
        //int[] numArray = { 2, 1, 2, 4, 3, 5, 2, 6 };
        //int k = 4;
        //int sum = 14;
        //int[] numArray = { 1, -1, 2, -3, 4, -5 };
        //int k = 2;
        //int sum = 3;

        Console.Write("Enter a number N (size of array): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter a searched Sum: ");
        int sum = int.Parse(Console.ReadLine());

        Console.Write("Enter a number K(size of subset)");
        int k = int.Parse(Console.ReadLine());

        //filling array elements
        int[] numArray = new int[n];
        Console.WriteLine("Enter a {0} number(s) to array: ", n);
        for (int i = 0; i < numArray.Length; i++)
        {
            Console.Write("   {0}: ", i + 1);
            numArray[i] = int.Parse(Console.ReadLine());
        }

        //print array elements
        Console.WriteLine(string.Join(" ", numArray));

        PrintAllSubsetsofSizeWithSum(numArray, sum, k);
    }

    static void PrintAllSubsetsofSizeWithSum(int[] numbers, int searchedSum, int subsetSize)
    {
        Console.WriteLine("\nAll subsets with sum = {0} and size = {1}", searchedSum, subsetSize);

        int subsetsCount = (int)(Math.Pow(2, numbers.Length) - 1); // Number of subsets
        List<int> subset = new List<int>();

        for (int i = 1; i <= subsetsCount; i++)
        {
            subset.Clear();

            for (int j = 0; j < numbers.Length; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    subset.Add(numbers[j]);
                }
            }
            if (subset.Sum() == searchedSum && subset.Count() == subsetSize)
            {
                isFoundSubset = true;
                Console.WriteLine(string.Join(" ", subset)); // Print subset
            }
        }

        Console.WriteLine(!isFoundSubset ? "- There are no subsets with Sum " + searchedSum + "\n" : "");
    }
}
