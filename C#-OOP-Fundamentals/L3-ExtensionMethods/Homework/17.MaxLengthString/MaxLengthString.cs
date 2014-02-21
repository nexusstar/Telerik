/*
 * Write a program to return the string with maximum length from an array of strings. Use LINQ.
 */

namespace _17.MaxLengthString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class MaxLengthString
    {
        public static int longestElement = 0;

        public static void Main()
        {
            string[] stringArray = new string[] { "0", "012", "01234567", "0123456789012", "123", "0123231" };

            //with lambda expression
            string answerWithExtension = stringArray.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);

            Console.WriteLine("Using lambda expression");
            Console.WriteLine(answerWithExtension);

            //with linq
            var answerWithQuery = from st in stringArray
                                  where GetLongerStr(st)
                                  select st;

            Console.WriteLine("\nUsing LINQ:");
            Console.WriteLine(answerWithQuery.Last());
        }

        private static bool GetLongerStr(string st)
        {
            if (st.Length > longestElement)
            {
                longestElement = st.Length;
                return true;
            }
            return false;
        }
    }
}
