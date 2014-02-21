using System;

class CurrentDateAndTime
{
    /// <summary>
    /// Exercise 7
    ///     Create a console application that prints the current date and time.
    ///         Using:
    ///         DateTime - object - Represents an instant in time, typically expressed as a date and time of day.
    ///         Datetime.Now - property - Gets a DateTime object that is set to the current date and time on this computer,
    ///         expressed as the local time.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Current date and time is: "+ DateTime.Now);
    }
}

