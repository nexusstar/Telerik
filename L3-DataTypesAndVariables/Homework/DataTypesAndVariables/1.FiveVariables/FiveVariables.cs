using System;

class FiveVariables
{
    /// <summary>
    /// Excercise 1. Declare five variables choosing for each of them the most 
    /// appropriate of the types byte, sbyte, short, ushort, int, uint, long,
    /// ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
    /// </summary>
    static void Main()
    {
        byte byteVariable = 57; // byte MAX value is 255 and min 0
        sbyte sbyteVariable = -115; //sbyte MAX value is 127 and min -128
        short shortVariable = -10000; // short min value is -32768 and max 32767 
        ushort ushortVariable = 52130; // ushort maxValue is 65535 and min 0
        int intVariable = 4825932; // int maxValue is 2147483647 and min is -2147483648

    }
}
