using System;

class CheckBitAtP
{
    /// <summary>
    /// ex.10 Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1.
    /// Example: v=5; p=1  false.
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

        //And finaly as the condition require it boolean expresion using thernary operator
        // condition ? first_expression : second_expression;
        Console.WriteLine(result == 1 ? true : false);
        Console.ReadKey();
    }
}
