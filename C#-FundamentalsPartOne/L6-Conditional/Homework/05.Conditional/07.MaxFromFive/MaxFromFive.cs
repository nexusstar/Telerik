using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxFromFive
{
    /// <summary>
    /// ex.7 Write a program that finds the greatest of given 5 variables
    /// </summary>
    static void Main()
    {

        //array to store the variables
        double[] fiveNumbers = new double [5];
        for (int count = 0; count< 5; count++)
        {
            string value;
            double number;
            do
            {
                Console.Write("enter {0} number:  ", count+1);
                value = Console.ReadLine();
            } while (!double.TryParse(value, out number));
            fiveNumbers[count] = number;
        }

        //check for max value
        double max = fiveNumbers[0];
        foreach (double item in fiveNumbers)
        {
            if (max < item)
            {
                max = item;
            }
        }
        
        Console.Write("The max from: ");
        foreach (double item in fiveNumbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("is "+ max);
    }
}
