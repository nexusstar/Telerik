using System;

class FirstTenNumbers
{
    /// <summary>
    /// Exercise 9
    ///     Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
    ///         Using:
    ///         for loop : run a statement or a block of statements repeatedly until a specified expression evaluates to false.
    ///         if-else: The if statement selects a statement for execution based on the value of a Boolean expression
    ///         % operator: computes the remainder after dividing its first operand by its second.
    ///         == operator: the equality operator (==) returns true if the values of its operands are equal, false otherwise.
    /// </summary>
    static void Main()
    {
        for (int number = 2; number < 12; number++)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
            else
            {
                Console.Write(-number + " ");
            }
        }
        Console.WriteLine();
    }
}

