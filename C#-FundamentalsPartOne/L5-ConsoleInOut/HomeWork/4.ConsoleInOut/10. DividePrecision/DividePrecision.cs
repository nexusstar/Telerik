using System;

    class DividePrecision
    {

        /// <summary>
        /// 10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
        /// </summary>
        static void Main()
        {
            decimal num  = 2m;
            decimal result = 1m;
            int plusMinus = 1;
            while (1m/num > 0.001m)
            {
                
                result = result + (1m / num)*plusMinus;
                plusMinus = plusMinus * (-1);
                num++;
               
            }
            Console.WriteLine("The sum is {0:F3}: ", result);
            
        }
    }
