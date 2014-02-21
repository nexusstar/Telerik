/*
 * Write a program that reads two integer numbers N and K and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum.
 */
using System;
using System.Collections.Generic;

class Kelements
{
    static void Main(string[] args)
    {
        int sizeN;
        int elementsK;

        do
        {
            Console.Write("Enter size of arrray: ");
        } while (!int.TryParse(Console.ReadLine(), out sizeN) && sizeN > 0);
        do
        {
            Console.Write("Enter subset count: ");
        } while (!int.TryParse(Console.ReadLine(), out elementsK) && elementsK > 0);

        if (elementsK < sizeN)
        {
            Console.WriteLine("Subset size should be less or equal to array size!");
            return;
        }

        //initialize array
        int[] arrayOfNumbers = new int[sizeN];
        for (int i = 0; i < sizeN; i++)
        {
            do
            {
                Console.Write("Enter element{0}: ", i);
            } while (!int.TryParse(Console.ReadLine(), out arrayOfNumbers[i]));
        }

        Console.WriteLine("\nArray elements \n {0}", string.Join(" ", arrayOfNumbers));
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("K - {0} elements from array with max sum", elementsK);
        
        //Solution: sort array, reverse the order and print first K elements
        //Note: this work only because we don't want the final order to be original one
        Array.Sort(arrayOfNumbers);
        Array.Reverse(arrayOfNumbers);

        //print first K element of final array
        for (int i = 0; i < elementsK; i++)
        {
            Console.Write(arrayOfNumbers[i] + " ");           
        }

        Console.WriteLine();
    }
}