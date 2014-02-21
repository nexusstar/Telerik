using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

class CountingNumbers
{
    /// <summary>
    /// ex. 11 - * Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	/// 0  "Zero"
	/// 273  "Two hundred seventy three"
	/// 400  "Four hundred"
	/// 501  "Five hundred and one"
	/// 711  "Seven hundred and eleven
    /// </summary>
    private static string[] ones = 
    { 
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"

    };
    private static string[] teens = 
    {
            "ten", "eleven", "twelve", "thirteen", "fourteen",
            "fifteen", "sixteen",  "seventeen", "eighteen",  "nineteen"
    };
    private static string[] tens = 
    {
            "",  "ten", "twenty", "thirty",  "fourty",  "fifty",
            "sixty", "seventy", "eighty",  "ninety"
      };
    

    
    static void Main()
    {
        
        int number;
        do
        {
            Console.Write("Please enter number in interval [0 - 999]:");
        }
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 999);

        // convert number to int[] array
        string str = number.ToString();
        char[] numChars = str.ToCharArray();
        int[] numArray = new int[numChars.Length];

        for (int i = 0; i < numChars.Length; i++)
        {
            numArray[i] = (int)(Char.GetNumericValue(numChars[i]));
        }

        //Print result
        Console.Write("The Number is: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        if (numArray.Length == 1)
        {
            Console.WriteLine(ones[numArray[0]]);
        }
        else if (numArray.Length == 2)
        {
            Console.WriteLine(teens[numArray[1]]);
        }
        else
        {
            if (numArray[2] == 0 && numArray[1] == 0)
            {
                Console.WriteLine("{0} hundred",
                ones[numArray[0]]
                );
            }
            else if (numArray[2] == 0)
            {
                Console.WriteLine("{0} hundred and {1}",
                ones[numArray[0]],
                tens[numArray[1]]
                );

            }
            else
            {
                if (numArray[1] == 1)
                {
                    Console.WriteLine("{0} hundred and {1}",
                    ones[numArray[0]],
                    teens[numArray[2]]
                );
                }
                else
                {
                    Console.WriteLine("{0} hundred and {1} {2}",
                    ones[numArray[0]],
                    tens[numArray[1]],
                    ones[numArray[2]]
                    );
                }
            }

        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
    }
    
    
}
