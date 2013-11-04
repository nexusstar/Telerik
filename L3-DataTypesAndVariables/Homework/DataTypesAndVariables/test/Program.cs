using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = 12345;
            decimal aDecimal = (decimal)Math.Sqrt(a);
            double aDouble = Math.Sqrt(a);
            float aFloat = (float)Math.Sqrt(a);
            int aInt = (int)Math.Sqrt(a);

            Console.WriteLine((decimal)Math.Sqrt(a)); // 111.10805551354
            Console.WriteLine((double)Math.Sqrt(a));   // 111.108055513541
            Console.WriteLine((float)Math.Sqrt(a));        // 111.1081
            Console.WriteLine((int)Math.Sqrt(a));           //  111

            Console.WriteLine(aInt < aFloat);
            Console.WriteLine(aDecimal < (decimal)aFloat);
        }
    }
}
