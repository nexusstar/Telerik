using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxFromFive
{
    /// <summary>
    /// ex.7 Write a program that finds the greatest of given 5 variables
    /// This time using Max method
    /// </summary>
    static void Main()
    {

        //List to store the variables
        List<double> fiveList = new List<double> { };
        for (int count = 0; count < 5; count++)
        {
            string value;
            double number;
            do
            {
                Console.Write("enter {0} number:  ", count + 1);
                value = Console.ReadLine();
            } while (!double.TryParse(value, out number));
            
            fiveList.Add(number);
        }

        //check for max
        double max = fiveList.Max();

        //write the result
        Console.Write("The max from: ");
        foreach (double item in fiveList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("is " + max);
    }
}
