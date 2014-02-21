using System;

class ExchangeBitSTwo
{
    /// <summary>
    /// ex. 13 Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
    /// </summary>
    static void Main()
    {
        // given number
        uint number;
        // position 
        byte firstBit = 3;
        // taget 
        byte targetBit = 24;
        // count of sequence to swap
        byte sequenceLength = 3;

        number = UInt32.Parse(Console.ReadLine());
        

        Console.WriteLine("Your number in binary is {0}.", Convert.ToString(number, 2).PadLeft(32, '0'));

        // XOR temporary
        uint temp = ((number >> firstBit) ^ (number >> targetBit)) & ((1U << sequenceLength) - 1);
        // bit-swapped result goes here
        uint result = number ^ ((temp << firstBit) | (temp << targetBit));

        Console.WriteLine("Your new number ({0}) in binary representation is {1}.", result, Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
