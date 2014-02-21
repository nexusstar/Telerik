/*
 * 06. Excercise
 * Write a method that returns the index of the first element in array that is bigger than its neighbors, 
 * or -1, if there’s no such element.
 *  -> use the method from the previous exercise.
 * 
 */

using System;

class FirstBiggerThanNeighbours
{
    static void Main()
    {
        int[] numbersArray = EnterValuesOfArray();

        Console.WriteLine("\nNumber {0} at position {1} is first bigger than its neighbors",
            numbersArray[FindFirstBiggerThanNeigbours(numbersArray)],
            FindFirstBiggerThanNeigbours(numbersArray)
            );

    }

    static int FindFirstBiggerThanNeigbours(int[]numbers)
    {
        if (numbers.Length <= 1)
        {
            return -1;
        }
        else
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                if (IsElemementBiggerThanNeighbours(numbers, index))
                {
                    return index;
                }
            }
            return -1;
        }
    }

    static bool IsElemementBiggerThanNeighbours(int[] array, int index)
    {
        if (index < 0 && index >= array.Length)
        {
            throw new IndexOutOfRangeException();
        }
        else if (index == 0 && array.Length > 1)
        {
            return array[index] > array[index + 1];
        }
        else if (index == (array.Length - 1) && array.Length > 1)
        {
            return array[index] > array[index - 1];
        }
        else
        {
            return array[index - 1] < array[index] && array[index] > array[index + 1];
        }
    }

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
