using System;

class QuadraticEquation
{
    /// <summary>
    /// ex 6. Write a program that reads the coefficients a, b and c of a quadratic equation
    /// ax2+bx+c=0 and solves it (prints its real roots).
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Please enter coefficients of the equation ax^2+bx+c=0");

        string quadraticCoefficient;
        double a;
        do
        {
            Console.Write("Write down the (a): ");
            quadraticCoefficient = Console.ReadLine();
        } while (!double.TryParse(quadraticCoefficient, out a));
        
        double b;
        string linearCoefficient;
        do
        {
            Console.Write("Write down the (b): ");
            linearCoefficient = Console.ReadLine();

        } while (!double.TryParse(linearCoefficient, out b));
       

        double c;
        string freeTerm;
        do
        {
            Console.Write("Write donw the (c): ");
            freeTerm = Console.ReadLine();     
        } while (!double.TryParse(freeTerm,out c));

        //calculate the discriminant
        double quadraticD = b * b - 4 * a * c;

        //calculate the solution
        double x1;
        double x2;
        double sqrtD;
        if (quadraticD < 0)
        {
            Console.WriteLine("There are no real roots. There are two distinct (non-real) complex roors");
            sqrtD = Math.Sqrt(Math.Abs(quadraticD));
            x1 = x2 = -b / (2 * a);
            double imaginariNumber = sqrtD / (2 * a);
            Console.WriteLine("The solution is x = {0:F2} +- {1:F2}", x1, imaginariNumber);
        }
        else if (quadraticD == 0)
        {
            Console.WriteLine("There are exactly one real root");
            x1 = x2 = -b / (2*a);
            Console.WriteLine("The solution is x1 = x2 = {0}", x1);
        }
        else
        {
            Console.WriteLine("There are two distinct roots which are real numbers");
            sqrtD = Math.Sqrt(quadraticD);
            x1 = (-b + sqrtD) / (2 * a);
            x2 = (-b - sqrtD) / (2 * a);
            Console.WriteLine("The solution is x1 = {0:F4} and x2 = {1:F4}", x1,x2);
        }

    }
}
