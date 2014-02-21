/*
 * ex 18. Write a program that reads an array of integers and removes from it a minimal number
 *        of elements in such way that the remaining array is sorted in increasing order.
 *        Print the remaining sorted array. Example:
 *	      {6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;

class LongestSorted
{
    static void Main()
    {
        //TESTS:
        //int[] numArray = //{ 6, 6, 5, 4, 3, 2, 1, 3, 1, 2, 3, 4, 5, 6, 3, 2, 1, 2, 1, 2, 3 }; //->{ 1, 1, 2, 3, 4, 5, 6 }
        //                 {6, 1, 4, 3, 0, 3, 6, 4, 5}; //->{1, 3, 3, 4, 5}


        //Console.Write("Enter a number N (size of array): ");
        //int n = int.Parse(Console.ReadLine());

        ////filling array elements
        //int[] numArray = new int[n];
        //Console.WriteLine("Enter a {0} number(s) to array: ", n);
        //for (int i = 0; i < numArray.Length; i++)
        //{
        //    Console.Write("   {0}: ", i + 1);
        //    numArray[i] = int.Parse(Console.ReadLine());
        //}
        
        
        //print array elements
        Console.WriteLine("Array elements: ");
        Console.WriteLine(string.Join(" ", numArray));

        PrintLongestSortedSubset(numArray);
    }

    private static void PrintLongestSortedSubset(int[] arr)
    {
        int subsetsCount = (int)(Math.Pow(2, arr.Length) - 1); // Number of subsets
        List<int> subset = new List<int>();
        List<int> remain = new List<int>();
        
        int bestCount = 0;
        int[] best = new int[0];
       
        for (int i = 1; i <= subsetsCount; i++)
        {
            subset.Clear();
            remain.Clear();

            for (int j = 0; j < arr.Length; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    subset.Add(arr[j]);
                }
                else
                {
                    remain.Add(arr[j]);
                }
            }
            if (IsElementsInIncrease(remain) && remain.Count >= bestCount)
            {
                bestCount = remain.Count;
                best = new int[remain.Count];
                remain.CopyTo(best);
            }
        }

        if (best.Length > 0)
        {
            Console.WriteLine("\nLongest sorted sequence:");
            Console.WriteLine(string.Join(" ", best) + "\n");
        }
        else
        {
            Console.WriteLine("There is no such subset sorry!");
        }
    }


    private static bool IsElementsInIncrease(List<int> lst)
    {
        for (int i = 0; i < lst.Count - 1; i++)
        {
            if (lst[i] > lst[i+1])
            {
                return false;
            }
        }
        return true;
    }
}
