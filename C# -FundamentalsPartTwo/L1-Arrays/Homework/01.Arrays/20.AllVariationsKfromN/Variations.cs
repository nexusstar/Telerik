/*
* 20. Write a program that reads two numbers N and K and generates
* all the variations of K elements from the set [1..N]. 
* Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
*/
using System;

class Variations
{
    static void Main()
    {
        Console.Write("Please enter how bit is the set N: ");
        int givenN = int.Parse(Console.ReadLine()); // 4;
        Console.Write("Please enter how many elements K: ");
        int givenK = int.Parse(Console.ReadLine()); // 3;
        
        //initialize array
        int[] result = new int[givenK];
        int count = 1;

        //fill array with 1
        for (int index = 0; index < result.Length; index++)
        {
            result[index] = count;
        }


        do
        {
            count = 1;
            PrintVariation(result);
            for (int index = 0; index < givenK; index++)
            {
                result[index] += count;
                if (result[index] <= givenN)
                {
                    count = 0;
                    break;
                }
                else 
                {
                    count = 1;
                    result[index] = count; 
                    
                }
            }
        } while (count != 1);

    }
    static void PrintVariation(int[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }
}
