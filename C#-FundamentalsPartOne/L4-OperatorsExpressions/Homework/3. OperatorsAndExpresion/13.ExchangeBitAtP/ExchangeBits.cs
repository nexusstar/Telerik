using System;

class ExchangeBits
{
    /// <summary>
    /// ex.13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
    /// </summary>
    static void Main()
    {
        //getting the number
        Console.Write("Write an int: ");
        int givenInt = int.Parse(Console.ReadLine());

        //position
        int bitPosition = 3;
        int bitPositionSecond = 4;
        int bitPositionThird = 5;

        //target
        int bitTarget = 24;
        int bitTargetSecond = 25;
        int bitTargetThird = 26;

        //getting values
      
        int maskPosition        = 1 << bitPosition;
        int maskPositionSecond  = 1 << bitPositionSecond;
        int maskPositionThird    = 1 << bitPositionThird;

        int targetMask       = 1 << bitTarget;
        int targetMaskSecond = 1 << bitTargetSecond;
        int targetMaskThird  = 1 << bitTargetThird;
        
        //with bitwise '&' we get as result only the bit we seek. 0 & 1 = 0;  1 & 1 = 1; 
        int resultPosition = givenInt & maskPosition;
        resultPosition = resultPosition >> bitPosition;

        int resultPositionSecond = givenInt & maskPositionSecond;
        resultPositionSecond = resultPositionSecond >> bitPositionSecond;

        int resultPositionThird = givenInt & maskPositionThird;
        resultPositionThird = resultPositionThird >> bitPositionThird;

        int resultTarget = givenInt & targetMask;
        resultTarget = resultTarget >> bitTarget;

        int resultTargetSecond = givenInt & targetMaskSecond;
        resultTargetSecond = resultTargetSecond >> bitTargetSecond;

        int resultTargetThird = givenInt & targetMaskThird;
        resultTargetThird = resultTargetThird >> bitTargetThird;
        
        //Uncoment to see number mask,a target and the result represented as 32bit binnary number
        //Console.WriteLine("Number int   :" + Convert.ToString(givenInt, 2).PadLeft(32, '0'));
        //Console.WriteLine("Mask int     :" + Convert.ToString(maskPosition, 2).PadLeft(32, '0'));
        //Console.WriteLine("Result Pos.  :" + Convert.ToString(resultPosition, 2).PadLeft(32, '0'));
        //Console.WriteLine("Result Targ. :" + Convert.ToString(resultTarget, 2).PadLeft(32, '0'));
        
        //exchange bits
        int result;
        
        if (resultPosition == 1)
        {
            maskPosition = 1 << bitTarget;
            result = givenInt | maskPosition;
        }
        else
        {
            maskPosition = ~(1 << bitTarget);
            result = givenInt & maskPosition;
        }
        
        if (resultTarget == 1)
        {
            targetMask = 1 << bitPosition;
            result = result | targetMask;
        }
        else
        {
            targetMask = ~(1 << bitPosition);
            result = result & targetMask;
        }

        //second numbers
        if (resultPositionSecond == 1)
        {
            maskPositionSecond = 1 << bitTargetSecond;
            result = result | maskPositionSecond;
        }
        else
        {
            maskPositionSecond = ~(1 << bitTargetSecond);
            result = result & maskPositionSecond;
        }

        if (resultTargetSecond == 1)
        {
            targetMaskSecond = 1 << bitPositionSecond;
            result = result | targetMaskSecond;
        }
        else
        {
            targetMaskSecond = ~(1 << bitPositionSecond);
            result = result & targetMaskSecond;
        }

        //third number
        if (resultPositionThird == 1)
        {
            maskPositionThird = 1 << bitTargetThird;
            result = result | maskPositionThird;
        }
        else
        {
            maskPositionThird = ~(1 << bitTargetThird);
            result = result & maskPositionThird;
        }

        if (resultTargetThird == 1)
        {
            targetMaskThird = 1 << bitPositionThird;
            result = result | targetMaskThird;
        }
        else
        {
            targetMaskThird = ~(1 << bitPositionThird);
            result = result & targetMaskThird;
        }

        Console.WriteLine("Number bits   :" + Convert.ToString(givenInt, 2).PadLeft(32, '0'));
        Console.WriteLine("Result bits  :" + Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine(result);
    }
}
