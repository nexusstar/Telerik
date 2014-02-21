using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    class Program
    {
        //create simple delegate that gets ints as input and returns int
        public delegate int BinnaryOp(int x, int y);
        public class SimpleMath
        {
            public static int Aadd(int x, int y)
            {
                return x + y;
            }

            public static int Subtract(int x, int y)
            {
                return x - y;
            }

            public static int Power(int x, int y)
            {
                return x * y;
            }
            
        }
        static void Main(string[] args)
        {
            BinnaryOp b = new BinnaryOp(SimpleMath.Aadd);

            Console.WriteLine(b(10,10));
            Console.WriteLine(b(10,20));
        }
    }
}
