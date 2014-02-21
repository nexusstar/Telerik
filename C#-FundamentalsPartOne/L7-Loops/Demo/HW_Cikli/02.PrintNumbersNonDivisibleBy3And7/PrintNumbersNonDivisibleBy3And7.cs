/*Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.*/
using System;

class PrintNumbersNonDivisibleBy3And7
{
    static void Main()
    {
        int n;
        bool isNValid = false;

        Console.WriteLine("Please enter a value:");
        isNValid = int.TryParse(Console.ReadLine(), out n);

        if (isNValid)
        {
            Console.WriteLine(" numbers from 1 to N, that are not divisible by 3 and 7 at the same time are:\n");
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    Console.WriteLine(" {0}", i);
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter valid number:");
        }
    }
}
