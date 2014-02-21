using System;
using System.Globalization;
using System.Threading;

class RectangleArea
{
    /// <summary>
    /// ex. 3 Write an expression that calculates rectangle’s area by given width and height.
    /// </summary>
    static void Main()
    {
        //making sure that decimal separator is culture independent
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Please write the side 'a' and 'b' of rectangle:");
        double sideA;
        double sideB;
        
        while (true)
        {
            Console.Write("Side a: ");
            if (double.TryParse(Console.ReadLine(), out sideA))
            {
                break;
            }
            else
            {
                Console.WriteLine("Entered value could not be read as a number try again");
            }
            
        }
        
        while (true)
        {
            Console.Write("Side b: ");
            if (double.TryParse(Console.ReadLine(), out sideB))
            {
                break;
            }
            else
            {
                Console.WriteLine("Entered value could not be read as a number try again");
            }

        } 
        
        //printing result    
        Console.WriteLine("The area of rectangle with sides {0} and {1} is: {2}", sideA, sideB,sideA*sideB);
        Console.ReadKey();

    }
}
