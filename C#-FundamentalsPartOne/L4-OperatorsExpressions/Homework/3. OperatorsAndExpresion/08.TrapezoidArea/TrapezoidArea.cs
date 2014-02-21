using System;

class TrapezoidArea
{
    /// <summary>
    /// ex.8 Write an expression that calculates trapezoid's area by given sides a and b and height h.
    /// a. Trapezoid area with sides a, b and height h is ((a+b)/2)*h
    /// assumptions: the data is entered correctly
    /// </summary>
    static void Main()
    {
        Console.Write("Enter side a: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter side b: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter height h: ");
        double trapezoidH = double.Parse(Console.ReadLine());

        Console.WriteLine("The area of Trapezoid with sides {0}, {1} and height {2} is: {3}", sideA, sideB, trapezoidH, (((sideB+sideA)/2.0)*trapezoidH));
    }
}

