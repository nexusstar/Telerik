using System;

    class NullValues
    {
        /// <summary>
        /// 13. Create a program that assigns null values to an integer and to double variables. 
        /// Try to print them on the console, try to add some values or the null literal to
        /// them and see the result.
        /// </summary>
        static void Main()
        {
            int? nullInteger = null;
            double? nullDouble = null;
            Console.WriteLine("Null values between two dashes integer: _{0}_, and double: _{1}_",
                nullInteger, nullDouble);
            nullInteger = 1;
            nullDouble = 1d;
            Console.WriteLine("New values between two dashes integer: _{0}_, and double: _{1}_",
               nullInteger, nullDouble);
        }
    }
