/*
 * 
 * ex.2 Write a program that reads two arrays from the console and compares them element by element
 * 
*/

using System;
using System.Collections.Generic;

class CompareArrays
{
    static void Main()
    {
        int size;
        do
	    {
	        Console.Write("Number of elements to compare = ");
	    } while (!int.TryParse(Console.ReadLine(), out size));
           
        //Declaring the Arrays
        int[] firstArray = new int[size];
        int[] secondArray = new int[size];

        //Filling the array
        FillingArray(size, firstArray);
        FillingArray(size, secondArray);

        //compare elements
        for (int el = 0; el < size; el++)
        {
            Console.WriteLine("Is fa {0} == sa {1} is {2}",firstArray[el],secondArray[el], firstArray[el]==secondArray[el] );            
        }
    }
    
    //Helper method to fill int array of size "size"
    private static void FillingArray(int size, int[] array)
    {
                for (int el = 0; el < size; el++)
			    {
                    int temp;
                    do
                    {
                      Console.Write("Arr[{0}] = ", el);   
                    } while (!int.TryParse(Console.ReadLine(), out temp));
			        
                    array[el] = temp;
			    }
                Console.WriteLine("----");
    }
}

