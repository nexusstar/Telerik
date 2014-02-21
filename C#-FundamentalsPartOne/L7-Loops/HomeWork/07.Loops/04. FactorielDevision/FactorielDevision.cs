using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FactorielDevision
{
    /// <summary>
    /// ex. 4 Write a program that calculates N!/K! for given N and K (1 < K < N ).
    /// </summary>
    static void Main()
    {
        int userN;
        int userK;
        do
        {
            Console.Write("Please enter first int N (>1): ");
        } while (!int.TryParse(Console.ReadLine(), out userN) || userN <= 2);
        do
        {
            Console.Write("Please enter second int K (<N): ");
        } while (!int.TryParse(Console.ReadLine(), out userK) || userK<=1 || userK >= userN);
        int result = 1;
        //In this expression as divident N! is greater than divisor K! the calculation starts from k+1 and ends in n
        for (int i = userK+1; i <= userN; i++)
        {
            result = i * result; 
        }
        Console.WriteLine(result);
    }
}
