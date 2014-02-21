/*
 * 09. Excercise
 * Write a method that return the maximal element in a portion of array of integers starting at given index.
 * Using it write another method that sorts an array in ascending / descending order.
 * 
 */

using System;
using System.Collections.Generic;

class MaxElementInPart
{
    static void Main()
    {
        int[] numbersArray = EnterValuesOfArray(); //{ 7, 8, 8, 9, 10, 7, 6, 1 };
        
        //print array before sorting
        Console.WriteLine(string.Join(" ", numbersArray));

        Console.Write("\nEnter start index: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("\nMax element in interval [{0}, {1}] -> {2}", start, end, FindMaxElementInPortion(numbersArray, start, end));

        Console.Write("Type \"1\" for Ascending order or \"0\" for Descending: ");
        int sortChoice = int.Parse(Console.ReadLine());

        SortingInOrder(numbersArray, 3);
        
        //print array after sorting
        Console.WriteLine(string.Join(" ", numbersArray));


    }
    
    static int FindMaxElementInPortion(int[] array, int start, int end)
    {
        if (start < 0 || start >= array.Length || end < 0 || end >= array.Length)
            throw new IndexOutOfRangeException();
        
        if (start > end)
        {
            start = start ^ end; end = start ^ end; start = start ^ end;
        }

        int indexMax = start;
        for (int i = start; i <= end; i++)
        {
            if (array[indexMax]< array[i])
                indexMax = i;
        }

        return array[indexMax];
    }

    static int[] SortingInOrder(int[] array, int order) //selection sort
    {
        int start = 0;
        int end = array.Length-1;
        int currentIndex = Array.IndexOf(array, FindMaxElementInPortion(array, start, end));
        if (order == 1) //ascending order
        {
            while (start != end)
            {
                Swap(array, currentIndex, end);
                end--;
                currentIndex = Array.IndexOf(array, FindMaxElementInPortion(array, start, end));
            }
        }
        else if (order == 0) //descending order
        {
            while (start != end)
            {
                Swap(array, currentIndex, start);
                start++;
                currentIndex = Array.IndexOf(array, FindMaxElementInPortion(array, start, end));
            }
        }
        else
        { 
            throw new NotSupportedException("Supported options are 1 and 0");
        }

        return array;
    }
    
    //swaping elements in array by indexx
    static void Swap(int[] arr, int current, int swap)
    {
        int temp = arr[current];
        arr[current] = arr[swap];
        arr[swap] = temp;
    }

    //filling array with values
    static int[] EnterValuesOfArray()
    {
        Console.Write("Enter a number N (size of array): ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        Console.WriteLine("\nEnter a {0} number(s) to array: ", n);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("   {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        return numbers;
    }
}
