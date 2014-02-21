using System;
using System.Numerics;
class CalculateNandK
{
    /// <summary>
    /// ex 5. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
    /// </summary>
    static void Main()
    {
        int userN;
        int userK;
        do
        {
            Console.Write("Enter first integer N (N > 1) : ");
        } while (!int.TryParse(Console.ReadLine(), out userN) || userN <= 1);
        do
        {
            Console.Write("Enter second integer K (K > N): ");
        } while (!int.TryParse(Console.ReadLine(), out userK) || userK <= userN);
        BigInteger result = 1;

        for (int num = userK; num > 1; num--)
        {
            if (num > (userK - userN) && num > userN)
            {
                result = result * num;
                
            }
            else if (num > (userK - userN) && num <= userN) // this catch overlaping nummbers
            {
                result = result * num * num;
            }
            else if (num <= (userK - userN) && num > userN) //this skips numbers 
            {
                //skip numbers
                //Console.WriteLine(num);
                
            }
           else
            {
                result = result * num;
            }
            
              
        }
        Console.WriteLine("The {0}!*{1}!/({1}-{0})! is: {2}", userN, userK, result);
        
    }
}
// Examples:

//without overlaping numbers

// N = 4 and K = 9
//
// (1 * 2 * 3 * 4)  *   (1 * 2 * 3 * 4 * 5 * 6 * 7 * 8 * 9)
// ------------------------------------------------------ 
//                   (1 * 2 * 3 * 4 * 5 )

// (1 * 2 * 3 * 4) * (6 * 7 * 8 * 9)
// -----------------------------------------
//                     1

// 24 * 3024
// 72576

//With overlaping numbers
// N = 5 and K = 8
//
// (1 * 2 * 3 * 4 * 5)   *   (1 * 2 * 3 *  4 * 5 * 6 * 7 *8)
// --------------------------------------------------------- 
//                     (1 * 2 * 3)

// (1 * 2 * 3) * (4 * 5   *   4 * 5) * (6 * 7 * 8)
// -----------------------------------------------
//                     1

// 120 * 6720
// 806400