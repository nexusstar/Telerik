/*
* 16. Write a program that reads two dates in the format: day.month.year
* and calculates the number of days between them. 
* 
* Example:
* Enter the first date: 11.12.2013
* Enter the second date: 24.12.2014
* Distance: 44 days
*/

using System;
using System.Globalization;
using System.Linq;

class DaysBetweenTwoDates
{
    static void Main()
    {
        //Ease of use uncomment this two lines and comment following two one
        //string startDate = "11.12.2013"; //start of current C# curse
        //string endDate = "24.01.2014";  //last posible exam date :-)

        string startDate = GetDate();
        string endDate = GetDate();

        DateTime start = DateTime.ParseExact(startDate, "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime end = DateTime.ParseExact(endDate, "d.M.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Distance between {0} and {1} -> {2} days\n", startDate, endDate, Math.Abs((end - start).TotalDays));
        Console.WriteLine("That's it no more time!\n");
    }

    private static string GetDate()
    {
        Console.Write("Write date in format [DD.MM.YYYY]: ");
        string startDate = Console.ReadLine();
        return startDate;
    }
}