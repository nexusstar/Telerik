using System;

class SumFactDivideToExpon
{
    /// <summary>
    /// ex. 6 - Write a program that, for a given two integer numbers N and X, 
    /// calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
    /// </summary>
    static void Main()
    {
        int userN;
        double userX;
        do
        {
            Console.Write("Enter the int for N: ");
        } while (!int.TryParse(Console.ReadLine(),out userN));
        do
        {
            Console.Write("Enter the int for X: ");
        } while (!double.TryParse(Console.ReadLine(), out userX));


        double sum = 1.0;
        double numerator = 1.0;
        double denominator = 1.0;

        for (int i = 1; i <= userN; i++)
        {
            denominator = denominator * userX;
            numerator =  numerator * i;
            sum += (numerator / denominator);
        }
        Console.WriteLine("The sum is: " + sum);
    }
}
