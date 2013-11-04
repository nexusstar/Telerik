using System;

class YourAgeAfterTen
{
    /// <summary>
    /// Exercise 12*
    ///     * Write a program to read your age from the console and print how old you will be after 10 years.
    ///     
    ///         Using:
    ///         DateTime - object - Represents an instant in time, typically expressed as a date and time of day.
    ///         Datetime.Now - property - Gets a DateTime object that is set to the current date and time on this computer, expressed as the local time.
    ///         TimeSpan - object - represent a time interval(duration of time or elapsed time) that is mesasured as positive or
    ///         negative number of days
    ///         TimeSpan.TotalDays - property - Gets the value of the current TimeSpan structure expressed in whole and fractional days.
    ///         
    ///         Assumptions:
    ///         Because Earth rotates about 365.242375 times a year but normal year is 365 days, to catch up every 4th year
    ///         we add 1 day which makes 365,25 days a year. This is close but wrong by about 1 day every 100 years.
    ///         If we want to account for 400 year this gets us to 365.2425 days per year
    /// </summary>
    static void Main()
    {
        DateTime PresentDay = DateTime.Now;
        DateTime BirthDay = new DateTime(1992, 12, 13);
        TimeSpan CurrentAgeSpan = PresentDay - BirthDay;
        
        //get current age in years
        byte CurrentAge = (byte)(CurrentAgeSpan.TotalDays / 365.2425); //this can hold up to 255 byte z = (byte)(x/y) - explicit conversion
        
        Console.WriteLine("My birthday is 13 December 1992, now I am still {0} ten years from now I will be {1} years old",CurrentAge, (CurrentAge+10));
        
    }
}