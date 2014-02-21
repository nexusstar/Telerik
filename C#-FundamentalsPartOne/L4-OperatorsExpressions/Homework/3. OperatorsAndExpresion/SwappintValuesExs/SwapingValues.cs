using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappintValuesExs
{
    class SwappingValues
    {
        //swaping values using bitwise XOR
        static void Main()
        {
            uint valueX = 10;
            uint valueY = valueX<<1; // 20 valueX*2^1
            Console.WriteLine("Number uint X  :" + Convert.ToString(valueX, 2).PadLeft(32, '0'));
            Console.WriteLine("Number uint Y  :" + Convert.ToString(valueY, 2).PadLeft(32, '0'));
            valueX = valueX ^ valueY;
            Console.WriteLine("Number X - X^Y :" + Convert.ToString(valueX, 2).PadLeft(32, '0'));
            valueY = valueX ^ valueY;
            Console.WriteLine("Number Y - X^Y :" + Convert.ToString(valueY, 2).PadLeft(32, '0'));
            valueX = valueX ^ valueY;
            Console.WriteLine("Number X - X^Y :" + Convert.ToString(valueX, 2).PadLeft(32, '0'));
        }
    }
}
