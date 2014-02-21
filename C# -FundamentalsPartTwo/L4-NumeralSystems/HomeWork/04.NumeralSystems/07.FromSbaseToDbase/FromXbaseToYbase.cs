/*
 * 07.
 * Write a program to convert from any numeral system of 
 * given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
 */

using System;

class FromXbaseToYbase
{
    static void Main()
    {
        //number base calculator http://www.cleavebooks.co.uk/scol/calnumba.htm

        //Test(); //<= test method
        
        Console.Write("\nEnter a number: ");
        string n = Console.ReadLine();

        Console.Write("\nEnter value for x(base): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("\nEnter value for y(base to convert): ");
        int y = int.Parse(Console.ReadLine());

        Console.Write("\n{0} base {1} -> base {2}: ", n, x, y);
        Console.WriteLine(BaseXtoBaseY(n,x,y));
    }

    

    //converts baseX number to decimal
    private static long BaseXtoDecimal(string number, int baseX)
    {
        long decimalNumber = 0;
        for (int i = number.Length - 1, power = 1; i >= 0; i--, power *= baseX)
        {
            if (number[i] >= '0' && number[i] <= '9')
            {
                decimalNumber += (number[i] - '0') * power;
            }
            else if (number[i] >= 'A' && number[i] <= 'F') //this is clipped to 16 for more change letter to Z
            {
                decimalNumber += (number[i] - 'A' + 10) * power;
            }
        }
        return decimalNumber;
    }

    //convert decimal number to baseX number
    private static string DecimalToBaseY(long number, int baseX)
    {
        string baseXresult = string.Empty;
        while (number > 0)
        {
            char remainder;
            if (number % baseX >= 10)
            {
                remainder = (char)('A' + number % baseX - 10);
            }
            else
            {
                remainder = (char)('0' + number % baseX);
            }
            baseXresult = remainder + baseXresult;
            number /= baseX;
        }
        return baseXresult;
    }

    //Converts baseX to baseY number using decimal as proxy
    private static string BaseXtoBaseY(string number, int x, int y)
    {
        long toDecimal = BaseXtoDecimal(number, x);
        
        string result = DecimalToBaseY(toDecimal, y);
        
        return result;
        
    }
    
    //test method for ease of use
    private static void Test()
    {
        Console.Write("\nFF base 16 -> base 10: ");
        Console.WriteLine(BaseXtoBaseY("FF", 16, 10));

        Console.Write("\n5808 base 13 -> base 5: ");
        Console.WriteLine(BaseXtoBaseY("5808", 13, 5));

        Console.Write("\n2767A9 base 12 -> base 16: ");
        Console.WriteLine(BaseXtoBaseY("2767A9", 12, 16));

        Console.Write("\n101 1001 base 2 -> base 12: ");
        Console.WriteLine(BaseXtoBaseY("1011001", 2, 12));
    }
}
