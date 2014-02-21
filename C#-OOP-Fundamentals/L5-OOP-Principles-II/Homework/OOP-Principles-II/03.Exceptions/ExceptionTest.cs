namespace _03.Exceptions
{
    using System;
    using System.Globalization;
    
    class ExceptionTest
    {
        static void Main(string[] args)
        {
            // example with integer number
            int minValue = 1;
            int maxValue = 100;

            Console.WriteLine("Please, enter a number between {0} and {1}:", minValue, maxValue);
            int number = int.Parse(Console.ReadLine());
            
            if (number < minValue || number > maxValue)
            {
                throw new InvalidRangeException<int>("Number out of range!", minValue, maxValue);
                
            }

            // example with date
            DateTime minDate = DateTime.ParseExact("01.01.1990", "d.M.yyyy", CultureInfo.InvariantCulture);
            DateTime maxDate = DateTime.ParseExact("05.03.2014", "d.M.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Please, enter a date between {0} and {1}:", minDate.ToShortDateString(), maxDate.ToShortDateString());
            string dateStr = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateStr, "d.M.yyyy", CultureInfo.InvariantCulture);
            if (date < minDate || date > maxDate)
            {                
                throw new InvalidRangeException<DateTime>("Date out of range!", minDate, maxDate);
            }
        }
    }
}
