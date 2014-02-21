/*
 * 05. Excercise
 * Write a method that checks if the element at given position 
 * in given array of integers is bigger 
 * than its two neighbors (when such exist).
 * 
 */

using System;

class BiggerThanNeighbours
{
    static void Main()
    {
        int[] numbersArray = EnterValuesOfArray();
        
        Console.Write("Enter index of number in array: ");
        int numberIndex = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nNumber {0} at position {1} is" +
            ((IsElemementBiggerThanNeighbours(numbersArray, numberIndex))?" ": " not ")
            +"bigger than its neighbors", numbersArray[numberIndex], numberIndex
            );

    }

    static bool IsElemementBiggerThanNeighbours(int[] array, int index)
    {
        if (index <0 && index>= array.Length)
        {
            throw new IndexOutOfRangeException();
        }
        else if (index == 0 && array.Length >1)
        { 
        return array[index] > array[index+1];
        }
        else if(index == (array.Length -1) && array.Length>1)
        {
            return array[index] > array[index-1];
        }
        else
        {
            return array[index-1]< array[index] && array[index]> array[index+1];
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
