/*
 * 05.
 * Write a method that calculates the number of workdays between today and given date, passed as parameter. 
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */
using System;
using System.Linq;
class Workdays
{
    static readonly DateTime[] holidays =
    {
        new DateTime(2014, 1, 1),  //Wednesday	01/01/2014	New Year 
        new DateTime(2014, 3, 3),  //Monday	03/03/2014	National Holiday Bulgaria 
        new DateTime(2014, 4, 18), //18 - Friday, 19 - Saturday , 20 - Sunday  04/2014	Easter 
        new DateTime(2014, 5, 1),  //Thursday  01/05/2014  not working day
        new DateTime(2014, 5, 2),  //Thursday  02/05/2014 Labor day  //2.05 and 5.05 is replaced by 10.05 and 31.05 
        new DateTime(2014, 5, 5),  //Monday    05/05/2014  not working day
        new DateTime(2014, 5, 6),  //Tuesday	06/05/2014	St. George        
        new DateTime(2014, 9, 22),  //Monday	22/09/2014	Independence Day Bulgaria
        new DateTime(2014, 12, 24), //Wednesday	24/12/2014	Christmas Eve
        new DateTime(2014, 12, 25), //Thursday	25/12/2014	Christmas
        new DateTime(2014, 12, 26), //Friday	26/12/2014	St. Stephen´s Day
        new DateTime(2014, 12, 31), //Wednesday	31/12/2014	New Year //is replaced on 13.12
    };

    //workdays on Saturday 
    static readonly DateTime[] workdays = 
    { 
        new DateTime(2014, 5, 10),
        new DateTime(2014, 5, 31),
        new DateTime(2014, 12, 13)                  
    };
    static void Main()
    {
        Console.Write("Enter a date to calculate the " +
            "time span \nbetween today and your date in format [YYYY MM DD]: ");
        string[] date = Console.ReadLine().Split(' ');
        
        int day = int.Parse(date[2]);
        int month = int.Parse(date[1]);
        int year = int.Parse(date[0]);

        DateTime currentDate = DateTime.Today;
        DateTime futureDate = new DateTime(year, month, day);
        
        int workdays = GetNumberOfWorkDays(currentDate, futureDate);

        Console.WriteLine("\nWorkdays from {0:dd/MM/yyyy}  to {1:dd/MM/yyyy} are: {2} \n", currentDate, futureDate, workdays);
    }

    
    static int GetNumberOfWorkDays(DateTime dateNow, DateTime dateFuture)
    {
        int numberOfWorkDays = 0;

        if (dateNow > dateFuture)
        {
            DateTime swap = dateNow;
            dateNow = dateFuture;
            dateFuture = swap;
        }

        while (dateNow <= dateFuture)
        {
            if (!holidays.Contains(dateNow) && dateNow.DayOfWeek != DayOfWeek.Saturday &&
                dateNow.DayOfWeek != DayOfWeek.Sunday || workdays.Contains(dateNow))
            {
                numberOfWorkDays++;
            }

            dateNow = dateNow.AddDays(1);
        }

        return numberOfWorkDays;
    }
}
