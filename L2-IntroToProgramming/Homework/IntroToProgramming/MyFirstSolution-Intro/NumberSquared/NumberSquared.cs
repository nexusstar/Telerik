using System;

class NumberSquared
{
    /// <summary>
    /// Exercise 8
    ///     Create a console application that calculates and prints the square of the number 12345.
    ///         Using:
    ///          * operator - multiplication operator(*) computes the product of its operands.
    ///          Math.Pwo - method - Returns a specified number raised to the specified power.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("12345 squared is: "+ 12345*12345);
        Console.WriteLine("12345 squared is: " + Math.Pow(12345, 2));
    }
}

