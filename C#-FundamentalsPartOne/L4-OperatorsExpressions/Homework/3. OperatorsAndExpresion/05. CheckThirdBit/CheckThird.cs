using System;

class CheckThirdBit
{
    /// <summary>
    /// ex.5 Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
    /// </summary>
    static void Main()
    {
        //getting the number
        Console.Write("Write an int: ");
        int givenInt = int.Parse(Console.ReadLine());
        
        int bitPosition = 3;
        
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
        Console.Write("The 3 bit is: " );
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(result);

        //And finaly as the condition require it boolean expresion using thernary operator
        // condition ? first_expression : second_expression;
        Console.WriteLine(result==1?true:false);
        Console.ReadKey();
    }
}
