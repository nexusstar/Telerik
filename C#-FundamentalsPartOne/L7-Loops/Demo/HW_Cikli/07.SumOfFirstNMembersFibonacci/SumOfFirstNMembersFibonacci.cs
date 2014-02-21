/*Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
*/
using System;

class SumOfFirstNMembersFibonacci
{
    static void Main()
    {
        uint n;

        Console.WriteLine("Please enter N:");
        bool isNValid = uint.TryParse(Console.ReadLine(), out n);

        if (isNValid)
        {
            uint f0 = 0;
            uint f1 = 1;
            uint f2 = 0;
            uint sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                f0 = f1;
                f1 = f2;
                f2 = f0 + f1;
                sum = sum + f2;               
            } 
            Console.WriteLine("\nThe First Fibonacci {0} members : sum = {1} \n", n, sum);
        }
        else
        {
            Console.WriteLine("Please enter valid number.");
        }

    }
}
