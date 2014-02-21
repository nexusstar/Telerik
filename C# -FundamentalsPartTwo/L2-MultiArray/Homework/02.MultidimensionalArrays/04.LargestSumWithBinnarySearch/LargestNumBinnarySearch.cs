/*
* 4. Write a program, that reads from the console an array of N integers
* and an integer K, sorts the array and using the method Array.BinSearch()
* finds the largest number in the array which is ≤ K. 
*/
using System;
using System.Linq;

class LargestNumBinnarySearch
{
    static void Main()
    {
        Console.Write("Write number N (size of array): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter a number K: ");
        int k = int.Parse(Console.ReadLine());

        int[] arrNumbers = new int[n];
        for (int pos = 0; pos < arrNumbers.Length; pos++)
        {
            Console.Write("num {0}: ", pos + 1);
            arrNumbers[pos] = int.Parse(Console.ReadLine());
        }

        //sort final array using method Array.Sort()
        Array.Sort(arrNumbers);

        //Search sorted array using binnary search method
        int index = Array.BinarySearch(arrNumbers, k);

        //Retruns the index of the specified value in the specified array, if value is found.
        //If value is not found and value is less than one or more elements in array, a negative number
        //which is bitwise complement of the index of the first element that is larger than value.
        //If value is not found and value is greater than any of the elements in array, a negative number which
        //is the bitwise complement of (the index of the last element + 1)

        if (index >= 0)
        {
            Console.WriteLine("\nFound equal number to K = {0}", k);
            Console.WriteLine("-> Result number: {0}\n", arrNumbers[index]);
        }
        else
        {
            if (index*(-1) == arrNumbers.Length)
            {
                Console.WriteLine("\nAll numbers are less than number K = {0}", k);
            }
            else if (index == -1)
            {
                Console.WriteLine("\nAll numbers are greater than number K = {0}", k);
            }
            else 
            {
                Console.WriteLine("\nFound smaller number to K = {0}", k);
                Console.WriteLine("-> Result number: {0}\n", arrNumbers[index*(-1)-2]);
            }
            Console.WriteLine(index);
        }
       

    }
}
