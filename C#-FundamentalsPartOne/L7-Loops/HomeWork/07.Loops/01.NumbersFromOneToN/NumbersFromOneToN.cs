using System;

class NumberFromOneToN
{
    /// <summary>
    /// ex. 1 - Write a program that prints all the numbers from 1 to N.
    /// Note: as "all the numbers"  include such numbers as 0, negative numbers,
    /// rational numbers, irrational numbers, and complex numbers.
    /// This programs makes following assumptions:
    /// 1. All the numbers are all integer numbers in the interval 1 to N
    /// 2. The user must specify integer number
    /// 3. When N is less than 1 the interval will be N to 1
    /// </summary>
    /// 
    static void Main()
    {
        int userN;
        do
        {
            Console.Write("Enter an integer: ");
        } while (!int.TryParse(Console.ReadLine(), out userN));
        if (userN >= 1)
        {
            for (int num = 1; num <= userN; num++)
            {
                Console.Write(num + " ");
            }
        }
        else
        {
            for (int num = userN; num <= 1; num++)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }
}
