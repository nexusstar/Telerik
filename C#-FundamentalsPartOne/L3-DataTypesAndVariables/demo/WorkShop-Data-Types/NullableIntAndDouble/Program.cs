using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableIntAndDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int? intNumber = null;
            double? doubleNumber = null;
            string strOne;
            string strTwo = null;
            string strThree = "";

            Console.WriteLine("intNumber = _{0}_", intNumber + 10);
        }
    }
}
