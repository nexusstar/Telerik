
namespace _01_02_ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class ExtensionMethodsTest
    {
        static void Main()
        {
            //Test StringBuilder.Substring
            StringBuilder stringBuilderInput = new StringBuilder();
            stringBuilderInput.Append("01234 I have the simplest tastes. I am always satisfied with the best.");

            //get Substring
            StringBuilder substringOne = stringBuilderInput.Substring(5);
            StringBuilder substringTwo = stringBuilderInput.Substring(5, 28);
            StringBuilder substringThree = stringBuilderInput.Substring(33);

            Console.WriteLine(substringOne.ToString());
            Console.WriteLine(substringTwo.ToString());
            Console.WriteLine(substringThree.ToString());

            //Test IEnumerable extensions
            List<int> testInts = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            byte[] testByte = new byte[] {1, 2, 3, 4 };
            decimal[] testDecimal = new decimal[] { 1.0m, 2.5m, 4.5m, 7.5m, 10m };
            string[] testString = new string[] {"Some", " Text", " to", " test" };

            //testing Sum
            Console.WriteLine(Divider("IEnumerable<T>.Sum"));

            Console.WriteLine(testInts.Sum());
            Console.WriteLine(testByte.Sum());
            Console.WriteLine(testDecimal.Sum());
            Console.WriteLine(testString.Sum());

            //List<int> empty = new List<int>();
            //Console.WriteLine(empty.Sum()); //this will throw exception

            //testing Product
            Console.WriteLine(Divider("IEnumerable<T>.Product"));

            Console.WriteLine(testInts.Product());
            Console.WriteLine(testByte.Product());
            Console.WriteLine(testDecimal.Product());
            //Console.WriteLine(testString.Product()); //this will throw exception

            //testing Average
            Console.WriteLine(Divider("IEnumerable<T>.Average"));

            Console.WriteLine(testInts.Average());
            Console.WriteLine(testByte.Average());
            Console.WriteLine(testDecimal.Average());
            //Console.WriteLine(testString.Product()); //this will throw exception

            //testing Min
            Console.WriteLine(Divider("IEnumerable<T>.Min"));

            Console.WriteLine(testInts.Min());
            Console.WriteLine(testByte.Min());
            Console.WriteLine(testDecimal.Min());
            Console.WriteLine(testString.Min());

            //testing Max
            Console.WriteLine(Divider("IEnumerable<T>.Max"));

            Console.WriteLine(testInts.Max());
            Console.WriteLine(testByte.Max());
            Console.WriteLine(testDecimal.Max());
            Console.WriteLine(testString.Max()); 





        }

        private static string Divider(string text)
        {
            StringBuilder divider = new StringBuilder();
            divider.Append(new string('-', 10));
            divider.Append(text);
            divider.Append(new string('-', 10));

            return divider.ToString();
        }
    }
}
