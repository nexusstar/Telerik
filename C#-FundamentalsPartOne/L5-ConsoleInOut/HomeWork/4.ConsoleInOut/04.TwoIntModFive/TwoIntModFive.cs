using System;

class TwoIntModFive
{
    /// <summary>
    /// ex.4 Write a program that reads two positive integer numbers and
    /// prints how many numbers p exist between them such 
    /// that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
    /// </summary>
    static void Main()
    {
        string startInt;
        int startIntNumber;
        do
        {
          Console.Write("Write an positve int: ");
          startInt = Console.ReadLine(); 
        } while (!int.TryParse(startInt,out startIntNumber)||startIntNumber<0);
        string endInt;
        int endIntNumber;
        do
        {
            Console.Write("Write second positve int: ");
            endInt = Console.ReadLine();   
        } while (!int.TryParse(endInt, out endIntNumber) || endIntNumber<0 || endIntNumber == startIntNumber); //waiting for different value
        
        int counter = 0 ;
        if (startIntNumber > endIntNumber) //switch values if start is greater than end 
        {
            startIntNumber = startIntNumber ^ endIntNumber;
            endIntNumber = startIntNumber ^ endIntNumber;
            startIntNumber = startIntNumber ^ endIntNumber;
        }

        for (int i = startIntNumber; i <= endIntNumber; i++)
        {
            if (i%5==0)
            {
                counter++;
            }
            
        }

        Console.WriteLine("Between {0} and {1} there are: {2}", startInt,endInt,counter);
    }
}
