using System;

class HoldBitAtP
{
    /// <summary>
    ///ex.12 We are given integer number n, value v (v=0 or 1) and a position p. 
    ///Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	///Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	///n = 5 (00000101), p=2, v=0  1 (00000001)
    /// </summary>
    static void Main()
    {
        //getting the number
        Console.Write("Write an int: ");
        int givenInt = int.Parse(Console.ReadLine());
        Console.Write("Choose position: ");
        int bitPosition = int.Parse(Console.ReadLine());
        Console.Write("Choose value 0 or 1: ");
        int bitValue = int.Parse(Console.ReadLine());

        //create the mask and result if 1 or 0
        int maskPosition;
        int result;

        if (bitValue == 1)
        {
            maskPosition = 1 << bitPosition;
            result = givenInt | maskPosition;
        }
        else
        {
            maskPosition = ~(1 << bitPosition);
            result = givenInt & maskPosition;
            
        }

        //Uncoment to see number mask and the result represented as 32bit binnary number
        //Console.WriteLine("Number int   :" + Convert.ToString(givenInt, 2).PadLeft(32, '0'));
        //Console.WriteLine("Mask int     :" + Convert.ToString(maskPosition, 2).PadLeft(32, '0'));
        //Console.WriteLine("Result       :" + Convert.ToString(result, 2).PadLeft(32, '0'));

        //printing the result

        Console.Write("The {0} when put {1} at position {2} is: ", givenInt, bitValue, bitPosition);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(result);


        Console.ReadKey();
    }
}