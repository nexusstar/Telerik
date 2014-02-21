/*
* 14
* Write methods to calculate minimum, maximum, average, sum 
* and product of given set of integer numbers. 
* Use variable number of arguments.
*/

using System;
using System.Linq;

class MaxMinAvgProgram
{
    static void Main()
    {
        Console.WriteLine("Min = {0}", FindMin(5, 1, 4, 3));
        Console.WriteLine("Max = {0}", FindMax(3, 6, 4, 2, 1, 5, 7));
        Console.WriteLine("Avg = {0}", FindAvg(16, 8, -4, 3));
        Console.WriteLine("Sum = {0}", FindSum(6, 2, -3));
        Console.WriteLine("Product = {0}", FindProduct(1, 2, 3, 4));
        Console.WriteLine();
    }


    static int FindMin(params int[] numbers)
    {
        int min = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
            if (numbers[i] < min) min = numbers[i];

        return min;
    }

    static int FindMax(params int[] numbers)
    {
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
            if (numbers[i] > max) max = numbers[i];

        return max;
    }

    static int FindSum(params int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++) sum += numbers[i];

        return sum;
    }

    static float FindAvg(params int[] numbers)
    {
        return FindSum(numbers) / numbers.Length;
    }

    static int FindProduct(params int[] numbers)
    {
        int product = 1;

        for (int i = 0; i < numbers.Length; i++) product *= numbers[i];

        return product;
    }
}