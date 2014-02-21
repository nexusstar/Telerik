using System;

class CirclePerArea
{
    /// <summary>
    /// ex. 2 Write a program that reads the radius r of a circle and prints its perimeter and area.
    /// </summary>
    static void Main()
    {
        Console.Write("Please enter the radius r of a circle: ");
        double radiusGiven = double.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of circle with radius {0} is:{1:F6} ",radiusGiven, radiusGiven*Math.PI*2);
        Console.WriteLine("The area of a circle with radius {0} is:   {1:F6}", radiusGiven, radiusGiven * radiusGiven * Math.PI);
    }
}
