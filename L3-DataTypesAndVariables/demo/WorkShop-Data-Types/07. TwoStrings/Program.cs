using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TwoStrings
{
    class Program
    {
        static void Main()
        {
            string helloStr = "Hello";
            string worldStr = "World!";
            object concatenation = helloStr + " " + worldStr;

            //string result = (string)concatenation;
            string result = concatenation.ToString();
            Console.WriteLine(result);
        }
    }
}
