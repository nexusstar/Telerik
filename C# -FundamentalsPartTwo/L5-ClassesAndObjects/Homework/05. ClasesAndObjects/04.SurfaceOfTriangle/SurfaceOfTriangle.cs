/*
 * 04.
 * Write methods that calculate the surface of a triangle by given:
 * -> Side and an altitude to it
 * -> Three sides
 * -> Two sides and an angle between them
 */

using System;

class SurfaceOfTriangle
{
    static void Main()
    {
        Console.WriteLine("Choose triangle's details to calculate its surface: ");
        Console.WriteLine("   1) Side and an altitude to it");
        Console.WriteLine("   2) Three sides");
        Console.WriteLine("   3) Two sides and an angle between them");
        Console.Write("\nEnter your choice: ");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1: BySideAndAltitude(); break;
            case 2: ByThreeSides(); break;
            case 3: ByTwoSidesAndAngle(); break;
            default: Console.WriteLine("\nError! Invalid input data!\n"); break;
        }
    }
    
    //Method one calculate surface by side and altitude
    static void BySideAndAltitude()
    {
        Console.Write("\nEnter side's length: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter altitude's length: ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("\nArea: {0} \n", (a * h) / 2);
    }

    static void ByThreeSides() //Heron formula
    {
        Console.Write("\nEnter a side's length: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("\nEnter b side's length: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("\nEnter c side's length: ");
        double c = double.Parse(Console.ReadLine());

        double s = (a + b + c)/2;

        Console.WriteLine("\nArea: {0} \n", Math.Sqrt(s*(s-a)*(s-b)*(s-c)));
    }

    static void ByTwoSidesAndAngle() 
    {
        Console.Write("\nEnter first side's length: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("\nEnter second side's length: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("\nEnter angle: ");
        double angle = double.Parse(Console.ReadLine());

        Console.WriteLine("\nArea: {0} \n", ((a * b) * Math.Sin(angle) / 2));        
    }

}
