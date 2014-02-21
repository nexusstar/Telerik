using System;

class ExtractBitAtP
{
    /// <summary>
    /// ex.11 - Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.
    /// </summary>
    static void Main()
    {
        //getting the number
        Console.Write("Write an int: ");
        int givenInt = int.Parse(Console.ReadLine());
        Console.Write("Choose position as integer counting from 0: ");
        int bitPosition = int.Parse(Console.ReadLine());

        //create the mask
        int maskPosition = 1 << bitPosition;

        //with bitwise '&' we get as result only the bit we seek. 0 & 1 = 0;  1 & 1 = 1; 
        int result = givenInt & maskPosition;


        //Uncoment to see number mask and the result represented as 32bit binnary number
        //Console.WriteLine("Number int   :" + Convert.ToString(givenInt, 2).PadLeft(32, '0'));
        //Console.WriteLine("Mask int     :" + Convert.ToString(maskPosition, 2).PadLeft(32, '0'));
        //Console.WriteLine("Result with &:" + Convert.ToString(result, 2).PadLeft(32, '0'));

        //printing the result
        result = result >> bitPosition;
        Console.Write("The {0} bit is: ", bitPosition);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(result);

        
        Console.ReadKey();
    }
}