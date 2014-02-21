using System;

public class DaysOfWeek
{
	static void Main()
	{
        string[] daysOfWeek = new string[]
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        
        foreach (string item in daysOfWeek)
        {
            Console.WriteLine(item);
        }
    }
}
