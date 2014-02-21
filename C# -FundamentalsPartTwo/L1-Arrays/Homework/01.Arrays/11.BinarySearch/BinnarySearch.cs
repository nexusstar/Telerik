/*
* 11. Write a program that finds the index of given element in a sorted array of integers 
* by using the binary search algorithm (find it in Wikipedia).
*/

using System;
using System.Collections.Generic;


class BinnarySearch
{

    

    static void Main()
    {
        int sizeN;
        do
        {
            Console.Write("Enter size of the array: ");
        } while (!int.TryParse(Console.ReadLine(), out sizeN) && sizeN > 0);
        Console.WriteLine(new string('-', 20));
        int[] numArray = new int[sizeN];

        for (int index = 0; index < sizeN; index++)
        {
            do
            {
                Console.Write("Enter element{0}: ", index);
            } while (!int.TryParse(Console.ReadLine(), out numArray[index]));
        }

        Console.WriteLine(new string('-', 20));
        int keySearh;
        do
        {
            Console.Write("Enter the number we search: ");
        } while (!int.TryParse(Console.ReadLine(), out keySearh));

        //int[] numArray = {-10,-1, 3, 4, 5, 6, 7, 8, 9, 10, 25 };
        //int keySearh = -1;

        //binary search index of searched integer
        int iMin = 0;
        int iMax = numArray.Length-1;
        while (iMax >= iMin)
        {
            //calculate the mid point
            int iMid = (iMin + iMax) / 2;
            if (keySearh == numArray[iMid])
            {
                Console.WriteLine("The index of {0} is {1}", keySearh, iMid);
                return;
            }
            else if (keySearh > numArray[iMid])
            {
                iMin = iMid + 1;
            }
            else
            {
                iMax = iMid - 1;
            }
        }
       
    }

    
}