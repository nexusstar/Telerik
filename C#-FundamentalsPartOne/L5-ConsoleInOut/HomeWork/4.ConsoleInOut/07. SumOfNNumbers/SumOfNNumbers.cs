using System;

    class SumOfNNumbers
    {
        /// <summary>
        /// ex. 7 - Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
        /// </summary>
        static void Main()
        {
            string startNumber;
            int n;
            do
            {
                Console.Write("Enter how much numbers you want to sum (positive int): ");
                startNumber = Console.ReadLine();
            } while (!int.TryParse(startNumber, out n));
            decimal result = 0;
            string userNumber;
            double num = 0;
            int counter = 1;

            while (true)
            {
                //check input
                do
                {
                    Console.Write("Enter number {0} of {1}: " ,counter ,startNumber);
                    userNumber = Console.ReadLine();
                } while (!double.TryParse(userNumber, out num));

                n--;
                counter++; //this is only for styling purpose

                result = result + (decimal)num;
                if (n ==0)
                {
                    Console.WriteLine("The sum is: " + result);
                    break;
                }
            }
        }
    }