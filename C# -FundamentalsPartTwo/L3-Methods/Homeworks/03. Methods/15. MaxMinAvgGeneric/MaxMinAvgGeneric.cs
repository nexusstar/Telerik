/*
* 15. *Modify your last program and try to make it work for any number type,
* not just integer (e.g. decimal, float, byte, etc.).
* Use generic method (read in Internet about generic methods in C#).
* 
*/

using System;

class MaxMinAvgSumProduct
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

    static K FindMin<K>(params K[] numbers) where K : IComparable<K>
    {
        int minIndex = 0;

        for (int i = 1; i < numbers.Length; i++)
            if (numbers[i].CompareTo(numbers[minIndex]) == -1) minIndex = i;

        return numbers[minIndex];
    }

    static K FindMax<K>(params K[] numbers) where K : IComparable<K>
    {
        int maxIndex = 0;

        for (int i = 1; i < numbers.Length; i++)
            if (numbers[i].CompareTo(numbers[maxIndex]) == 1) maxIndex = i;

        return numbers[maxIndex];
    }

    static K FindSum<K>(params K[] numbers) where K : IComparable<K>
    {
        dynamic sum = 0;

        for (int i = 0; i < numbers.Length; i++) sum += numbers[i];

        return sum;
    }

    static float FindAvg<K>(params K[] numbers) where K : IComparable<K>
    {
        dynamic averageSum = 0;

        for (int i = 0; i < numbers.Length; i++) averageSum += numbers[i];

        return averageSum / numbers.Length;
    }

    static K FindProduct<K>(params K[] numbers) where K : IComparable<K>
    {
        dynamic product = 1;

        for (int i = 0; i < numbers.Length; i++) product *= numbers[i];

        return product;
    }
}

