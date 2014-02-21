/*
* 16. We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
*	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)
*/

using System;
using System.Collections.Generic;
using System.Linq;

class FindSubsetWithGivenSum
{
    
    static bool isFoundSubset = false;

    static void Main()
    {
        Console.Write("Enter a number N (size of array): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter a searched Sum: ");
        int sum = int.Parse(Console.ReadLine());

        int[] numArray = new int[n];
        Console.WriteLine("Enter a {0} number(s) to array: ", n);
        for (int i = 0; i < numArray.Length; i++)
        {
            Console.Write("   {0}: ", i + 1);
            numArray[i] = int.Parse(Console.ReadLine());
        }

        PrintAllSubsetsWithGivenSum(numArray, sum);

        
    }

    // Find and print subset
    // There will be 2^n subsets for a given set, where N is the cardinality (number of items) of that set.
    // For example, there will be 2^5 = 32 subsets for the set {1, 2, 3, 4, 5}.
    // see more at: http://www.mathsisfun.com/activity/subsets.html
    // The binary representation of each number 'i' in the range 0 to (2N - 1) is used to find the corresponding ith subset. 
    // Each '1' in the binary representation indicates an item in that position. 
    // For example, the binary representation of number 5 is 00101 which in turn represents the subset {3, 5} of the set {1, 2, 3, 4, 5}.

    static void PrintAllSubsetsWithGivenSum(int[] numbers, int searchedSum)
    {
        Console.WriteLine("\nAll subsets with sum = {0}", searchedSum);

        int subsetsCount = (int)(Math.Pow(2, numbers.Length) - 1); // Number of subsets
        List<int> subset = new List<int>();

        for (int i = 1; i <= subsetsCount; i++)
        {
            subset.Clear();

            for (int j = 0; j < numbers.Length; j++)
                if (((i >> j) & 1) == 1)
                    subset.Add(numbers[j]);

            if (subset.Sum() == searchedSum)
            {
                isFoundSubset = true;
                Console.WriteLine(string.Join(" ", subset)); // Print subset
            }
        }

        Console.WriteLine(!isFoundSubset ? "- There are no subsets with Sum " + searchedSum + "\n" : "");
    }

   
}