using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceMinMax
{
    /// <summary>
    /// ex. 3 - Write a program that reads from the console a sequence of N integer numbers 
    /// and returns the minimal and maximal of them.
    /// </summary>
    static void Main()
    {
        int userNum;
        do
        {
            Console.Write("Enter how much number to compare: ");  
        } while (!int.TryParse(Console.ReadLine(), out userNum) || userNum<=0);
        
        int userMin; int userMax;
        int currentNum;
        do
        {
            Console.Write("Enter number 1: ");
        } while (!int.TryParse(Console.ReadLine(), out currentNum));
        userMin = userMax = currentNum;
        
        for (int count = 2; count <= userNum; count++)
        {

            do
            {
                Console.Write("Enter number {0}: ", count);
            } while (!int.TryParse(Console.ReadLine(), out currentNum));
            if (currentNum >= userMax)
            {
                userMax = currentNum;
            }
            else if (userMin >= currentNum)
            {
                userMin = currentNum;
            }
        }
        Console.WriteLine("For this sequence Max is: {0} and Min is: {1}", userMax, userMin);
      
    }
}