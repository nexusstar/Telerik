using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompadreTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            float firstNum = float.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            float secondNum = float.Parse(Console.ReadLine());
            float result = (float)(firstNum - secondNum);

            bool areEqual = result == 0;
            Console.WriteLine("Are equal: " + areEqual);

        }
    }
}
