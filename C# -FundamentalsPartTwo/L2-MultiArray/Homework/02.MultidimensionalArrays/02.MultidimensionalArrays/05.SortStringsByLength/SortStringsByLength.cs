/*
* 5. You are given an array of strings. Write a method that sorts
* the array by the length of its elements (the number of characters composing them).
*/

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class SortStringsByLength
{
    static void Main()
    {
        Console.Write("Enter number N (size of array):");
        int n = int.Parse(Console.ReadLine());
        
        string[] arrOfStrings = new string[n];

        for (int index = 0; index < arrOfStrings.Length; index++)
        {
            Console.Write("enter string {0}: ", index+1);
            arrOfStrings[index] = Console.ReadLine();
        }
        //Print before sorting
        Console.WriteLine("\nBefore sorting array: ");
        Console.WriteLine(string.Join(" ", arrOfStrings));
       
        //ONE - using IComparer
        Array.Sort(arrOfStrings, new StringLengthComparer());
        
        //TWO - using Lambda expression
        // Array.Sort(arrOfStrings, (x, y) => (x.Length).CompareTo(y.Length));
       
        //THREE - Using lengths of strings as keys 
        //int[] arrayKeys = GetStringArrayLengths(arrOfStrings);
        //Array.Sort(arrayKeys, arrOfStrings);
        
        //Printing result
        Console.WriteLine("\nAfter sorting array: ");
        Console.WriteLine(string.Join(" ", arrOfStrings));
    }

    //helper method to get lengths of strings
    static int[] GetStringArrayLengths(string[] arrOfStrings) 
    {
        int[] lengths = new int[arrOfStrings.Length];
        for (int index = 0; index < arrOfStrings.Length; index++)
        {
            lengths[index] = arrOfStrings[index].Length;
        }
        return lengths;
    }
}
public class StringLengthComparer : IComparer<string>
{
    public int Compare(string firstString, string secondString)
    {
        if (firstString.Length != secondString.Length)
        {
            return firstString.Length.CompareTo(secondString.Length);    
        }
        else
        {
            return firstString.CompareTo(secondString);
        }
    }
}
