using System;

class GreatestCommonDivisor
{
    /// <summary>
    /// ex8. Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).
    /// note on Euclidean algorithm: 
    /// Starting with a pair of positive integers, form a new pair consisting of the smaller number and the difference 
    /// between the larger number and the smaller number. This process repeats until the numbers in the new pair are equal to each other;
    /// </summary>
    static void Main()
    {
        int userA;// = 1071;
        int userB; //= 462;
        do
        {
            Console.WriteLine("Enter the first number: ");
        } while (!int.TryParse(Console.ReadLine(), out userA)|| userA<=0);
        do
        {
            Console.Write("Enter the second number: ");
        } while (!int.TryParse(Console.ReadLine(),out userB) || userB <=0);

        int minNumber;
        int maxNumber;
        if (userA > userB)
        {
            minNumber = userB;
            maxNumber = userA;
        }
        else
        {
            minNumber = userA;
            maxNumber = userB;
        }

        //using while loop and subtraction
        while (minNumber != 0)
        {
            if (maxNumber > minNumber)
            {
                maxNumber = maxNumber - minNumber;
            }
            else
            {
                minNumber = minNumber - maxNumber;
            }
        }

        Console.WriteLine("Greatest common divisor of {0}, {1} is: {2}", userA, userB, maxNumber);

    }
}