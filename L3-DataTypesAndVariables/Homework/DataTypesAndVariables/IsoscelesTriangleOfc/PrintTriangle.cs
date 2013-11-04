using System;

class PrintTriangle
{
    /// <summary>
    /// 
    /// </summary>
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;              

        char copyrightSymbol = (char)0xA9;
        for (int count = 0; count < 12; count++) // 9 symbol + 3 interval = 12 count
        {
            if ((count < 2) || (count == 3)) 
            {
                Console.Write(" ");
            }
            else
            {
                if (count == 2 || count ==6 )
                {
                    Console.WriteLine(copyrightSymbol);
                }
                else
                {
                    Console.Write(copyrightSymbol);
                }
            }
        }
        Console.WriteLine();
        string line = string.Empty;
        int lineCount = 3;
        for (int count = 0; count < lineCount; count++)
        {
            line = new string(copyrightSymbol, 2 * count + 1);
            Console.WriteLine(line.PadLeft(lineCount+count));
        }

    }
}