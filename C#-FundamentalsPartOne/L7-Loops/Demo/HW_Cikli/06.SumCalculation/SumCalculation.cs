/*Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N */
using System;

class SumCalculation
{
    static void Main()
    {
        uint n, x;

        Console.Write("Please enter N: ");
        bool isNValid = uint.TryParse(Console.ReadLine(), out n);

        Console.Write("Please enter X: ");
        bool isXValid = uint.TryParse(Console.ReadLine(), out x);

        if (isNValid && isXValid)
        {
            decimal sum = 1m;

            for (int i = 1; i <= n; i++)
            {
                decimal factorial = i;
                factorial = CalculateFactorial(factorial); //calculate factorial of i (1!; 2!; 3! etc.)
                Console.WriteLine("\nfactorial is = {0}\n", factorial);
                sum = sum + factorial / (decimal)Math.Pow(x, i); // X^N =(decimal)Math.Pow(x, i)
            }

            Console.WriteLine("\nSum is = {0}\n", sum);
        }
        else
        {
            Console.WriteLine("Please enter valid number:");
        }
    }

    static decimal CalculateFactorial(decimal number)
    {
        if (number < 1) return 1;
        return number * CalculateFactorial(number - 1);
    }
}

