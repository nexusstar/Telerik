using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSteck
{
    class method
    {
       
        static void Main()
        {
            Console.WriteLine(CalcSum(4,2,3));
            Console.WriteLine(CalcSum(1,2,3,4));
            
        }
        static long CalcSum(params int[] firstNum)
        {
            long sum = 0;
            foreach (int item in firstNum)
            {
                sum += item;
            }
            return sum;
        }
    }
   
}
