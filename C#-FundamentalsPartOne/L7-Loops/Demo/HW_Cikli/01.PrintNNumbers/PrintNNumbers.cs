/*Write a program that prints all the numbers from 1 to N. */
using System;

class PrintNNumbers
{
    static void Main()
    {
        int n;
        bool isNValid = false;

        Console.WriteLine("Please enter a value:");
        isNValid = int.TryParse(Console.ReadLine(), out n);

        if (isNValid)
        {
            Console.WriteLine("Values from 1 to N:\n");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(" {0}", i);
            }
        }
        else
        {
            Console.WriteLine("Please enter valid number:");
        }
    }
}