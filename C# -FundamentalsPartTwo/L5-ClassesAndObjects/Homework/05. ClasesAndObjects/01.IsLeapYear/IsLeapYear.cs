/*
 * 01.
 * Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
 */

using System;

class IsLeapYear
{
    static void Main()
    {
        Console.Write("Please enter year: ");
        DateTime userYear = DateTime.Parse("1.1." + Console.ReadLine() + "");
        Console.WriteLine("\nYear {0} is leap: {1}", userYear.Year, DateTime.IsLeapYear(userYear.Year));

        //Math test
        Console.Write("\nMath test: ");
        Console.WriteLine( IsLeap(userYear.Year));
    }

    //return true or false if year is leap
    static bool IsLeap(int year)
    {
        return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
    }
}
