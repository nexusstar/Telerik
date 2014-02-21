using System;

class GreatestCommonDivisor
{
    /// <summary>
    /// ex8. Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).
    /// note on Euclidean algorithm: 
    /// The common form of Euclid's algorithm replaces subtracting the small positive number from the big number 
    /// (possibly many times) with finding the remainder in long division.
    /// </summary>
    static void Main()
    {
        int userA;// = 1071;
        int userB; //= 462;
        do
        {
            Console.WriteLine("Enter the first number: ");
        } while (!int.TryParse(Console.ReadLine(), out userA) || userA <= 0);
        do
        {
            Console.Write("Enter the second number: ");
        } while (!int.TryParse(Console.ReadLine(), out userB) || userB <= 0);

        int greatestCD = userA % userB;
        int minNumber;
        int maxNumber;
        if (userA>userB)
        {
            minNumber = userB;
            maxNumber = userA;
        }
        else
        {
            minNumber = userA;
            maxNumber = userB;
        }

        //using while loop and %
        while (minNumber!=0)
        {
            greatestCD = minNumber;
            minNumber = maxNumber % minNumber;
            maxNumber = greatestCD;
        }

        Console.WriteLine("Greatest common divisor of {0}, {1} is: {2}", userA, userB, greatestCD);
        
    }
}