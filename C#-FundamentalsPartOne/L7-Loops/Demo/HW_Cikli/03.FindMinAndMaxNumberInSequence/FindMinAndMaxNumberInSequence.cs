/*Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them. */
using System;

class FindMinAndMaxNumberInSequence
{
    static void Main()
    {
        int totalNumbers, min, max; ;

        Console.Write("Enter a number of numbers: ");
        bool isTotalNumbersValid = int.TryParse(Console.ReadLine(), out totalNumbers);

        if (isTotalNumbersValid)
        {
            Console.Write(" 1: ");
            min = int.Parse(Console.ReadLine());
            max = min;

            for (int i = 2; i <= totalNumbers; i++)
            {
                Console.Write(" {0}: ", i);
                int number = int.Parse(Console.ReadLine());

                if (number > max)
                {
                    max = number;
                }
                else if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine("\nThe greatest number is: {0}", max);
            Console.WriteLine("The smaller number is: {0}\n", min);
        }
        else
        {
            Console.WriteLine("Please enter valid number:");
        }
    }
}
